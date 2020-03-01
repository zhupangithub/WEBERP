# -*- coding: utf-8 -*-
##############################################################################
# OpenERP Connector
# Copyright 2013 Amos <sale@100china.cn>
##############################################################################

from datetime import datetime
from dateutil.relativedelta import relativedelta
from openerp.osv import fields, osv
import openerp.addons.decimal_precision as dp
import time
from openerp.tools.translate import _
import datetime
import simplejson
import random
import string

try:
    from openerp import SUPERUSER_ID
except ImportError:
    SUPERUSER_ID = SUPERUSER_ID


class ycc_slider_model(osv.Model):
    _name = "ycc.create.slider"
    # _log_access = False
    _description = "ycc.create.slider"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.many2one('product.template', u'虚拟拉头', domain=[('pro_slider_active', '=', True)], required=True),
        'slider_bentou': fields.many2one('product.template', u'本头', required=True,
                                         domain="[('pro_typeid','=','BT(本头)')]"),
        'state': fields.selection([('draft', u'草稿'),
                                   ('review', u'等待审核'),
                                   ('done', u'已完成'),
                                   ('cancel', u'取消'), ],
                                  u'状态'),
    }

    _defaults = {
        'state': lambda *a: 'draft',
        'slider_state': True,
    }

    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'该拉头模板已存在,不能重复添加!'),
    ]

    def dt_review(self, cr, uid, ids, context=None):
        return self.write(cr, uid, ids, {'state': 'review'})

    def dt_cancel(self, cr, uid, ids, context=None):
        state = 'cancel'
        message = '单据已取消'
        self.dt_action(cr, uid, ids, state, message, context=context)
        return True

    def dt_done(self, cr, uid, ids, context=None):
        try:
            max_pro_temp_id = "select max(id) from product_template"
            max_pro_product_id = "select max(id) from product_product"
            sql_str = "select id from product_product where product_tmpl_id=%s and id!=%s"
            max_mrp_bom = "select max(id) from mrp_bom"
            query_mrp_bom_line = "SELECT a.product_uos_qty,a.create_date, a.product_id, a.product_uom,\
                                    a.sequence,a.create_uid, a.write_uid, a.routing_id, a.product_rounding,\
                                    a.write_date, a.product_qty, a.product_uos, a.product_efficiency, a.type,\
                                     c.sedai_oks,c.id,b.name_template,c.pro_slider_active,a.id,c.pro_typeid,c.length_ok,c.pro_select_color,b.id FROM mrp_bom_line a inner join product_product b on a.product_id=b.id inner join\
                                      product_template c on c.id=b.product_tmpl_id  where a.bom_id=%s and a.id!=%s"

            query_mrp_bom = "select a.code,a.create_date,a.product_uom, a.sequence, a.write_uid,\
                  a.product_qty, a.create_uid, a.message_last_post, a.company_id,\
                    a.product_tmpl_id, a.routing_id, a.type,a.active,a.write_date,a.product_efficiency,\
                                    a.name, a.product_rounding, a.product_id,a.id FROM  mrp_bom a  where a.product_tmpl_id=%s AND a.id!=%s"

            add_mrp_bom_line_sel = '''INSERT INTO mrp_bom_line(product_uos_qty, date_stop, create_date, product_id, product_uom,
            sequence, date_start, create_uid, write_uid, routing_id, product_rounding,write_date, product_qty, product_uos, product_efficiency, type,
            bom_id)(select product_uos_qty, date_stop, create_date, %s, product_uom,sequence, date_start, create_uid, write_uid, routing_id, product_rounding,
            write_date, %s, product_uos, product_efficiency, type, %s from mrp_bom_line where id=%s)'''

            add_product_template = '''INSERT INTO product_template(end_location_id,warranty,pro_typeid, uos_id, list_price, weight, color, image, write_uid,
			    mes_type, uom_id, description_purchase, create_date, uos_coeff,
			    create_uid, sale_ok, categ_id, product_manager, message_last_post,company_id, state, uom_po_id, description_sale, description,
			    weight_net, volume, write_date, active, rental, image_medium,name, type, image_small, track_all, track_outgoing, loc_rack,
			    loc_case, track_incoming, loc_row, sale_delay, produce_delay,track_production, purchase_ok, pro_vacancy, pro_select_color,
			    sedai_oks, pro_material, pro_kaibikou, length_ok, pro_slider_active,pro_lianya_color, date_ends, pro_size, pro_color_key,virtual_item_key ,
			    pro_item_active, pro_length,pro_slider)(select end_location_id,warranty,pro_typeid,uos_id, list_price, weight, color, image, write_uid,
			    mes_type, uom_id, description_purchase, create_date, uos_coeff,create_uid, sale_ok, categ_id, product_manager, message_last_post,
			    company_id, state, uom_po_id, description_sale, description,weight_net, volume, write_date, active, rental, image_medium,
			    %s, type, image_small, track_all, track_outgoing, loc_rack,loc_case, track_incoming, loc_row, sale_delay, produce_delay,
			    track_production, purchase_ok, pro_vacancy, pro_select_color,
			    sedai_oks, pro_material, pro_kaibikou, length_ok, False,%s, date_ends, pro_size, %s, pro_slider,
			    False, %s, %s from product_template where id=%s)'''

            add_product_product_sel = ''' INSERT INTO product_product(ean13, create_date, default_code, name_template, create_uid,
                message_last_post, product_tmpl_id, image_variant, write_uid,write_date, active)(select ean13, create_date, default_code,%s, create_uid,
                message_last_post,%s, image_variant, write_uid,write_date, active from product_product where id=%s)'''
            luxian = '''insert into stock_route_product(product_id,route_id)(select %s,route_id from
                        stock_route_product where product_id=%s)'''
            rules = '''insert into stock_warehouse_orderpoint(product_max_qty, create_uid, qty_multiple, create_date, name,
                        location_id, company_id, write_uid, write_date, logic, active,
                            warehouse_id, product_min_qty, product_id)(select product_max_qty, create_uid, qty_multiple, create_date,%s,
                        location_id, company_id, write_uid, write_date, logic, active,
                            warehouse_id, product_min_qty, %s from stock_warehouse_orderpoint where product_id=%s)'''
            add_mrp_bom_sel = '''INSERT INTO mrp_bom(
                date_stop, code, create_date, product_uom, sequence, write_uid,product_qty, create_uid, date_start, message_last_post, company_id,
                product_tmpl_id, routing_id, type, write_date, active, product_efficiency,
                name, product_rounding, product_id)(select date_stop, code, create_date, product_uom, sequence, write_uid,
                product_qty, create_uid, date_start, message_last_post, company_id,
                %s, routing_id, type, write_date, active, product_efficiency,%s, product_rounding, %s from mrp_bom where id=%s)'''
            caigou = '''INSERT INTO product_supplierinfo(
            create_uid, product_code, create_date, name, sequence, product_name,
            company_id, write_uid, delay, write_date, min_qty, qty, product_tmpl_id)(select create_uid, product_code, create_date, name, sequence, product_name,
            company_id, write_uid, delay, write_date, min_qty, qty, %s from product_supplierinfo where product_tmpl_id=%s)'''
            slider_line = self.pool.get('ycc.create.slider').browse(cr, uid, ids)  # 订单行
            cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s", (slider_line.name.id, 0))
            product = cr.fetchone()
            pro_temp = self.pool.get('product.template').browse(cr,uid,slider_line.name.id)  # 订单行
            state = 'done'
            message = '单据已完成'
            self.dt_action(cr, uid, ids, state, message, context=context)
            if slider_line.name.name != False:
                cr.execute("select b.name_template,a.id  from product_template a inner join product_product b on a.id=b.product_tmpl_id\
                where a.pro_typeid='LP(拉片)' and a.pro_item_active=False and a.pro_material=%s and a.id!=%s",(pro_temp.pro_material,0))
                for slider in cr.fetchall():
                    names = slider_line.name.name + slider[0]
                    cr.execute("select count(1) from product_template where name=%s and id!=%s", (names, 0))
                    if [x[0] for x in cr.fetchall()] == [0L]:
                        ####产品名称,链牙,色带,长度,虚拟物品，ID获取后，添加一个新的产品
                        cr.execute(add_product_template, (
                            names, None, None, 0,
                            slider_line.name.id, slider_line.name.id))
                        cr.execute(max_pro_temp_id)
                        # 获取最近插入的哪一行记录的ID,并向product_product表中添加一行数据
                        liners2 = cr.fetchone()
                        cr.execute(add_product_product_sel, (names, liners2, product))
                        cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                                   (liners2[0], 0))
                        product_ids = cr.fetchone()
                        cr.execute(luxian, (liners2[0], slider_line.name.id))  #####Coyp路线
                        cr.execute(rules, ('OP/000' + str(liners2[0]), product_ids, product))  ##生成在补货规则
                        cr.execute(caigou, (liners2[0], slider_line.name.id))  ###添加采购商
                        # 以下代码生成BOM
                        cr.execute("select count(1) from mrp_bom where product_tmpl_id =(%s) and id!=%s",
                                   (slider_line.name.id, 0))
                        line_mrp1 = [x[0] for x in cr.fetchall()]
                        # 判断是否有这个虚拟产品的虚拟BOM
                        if line_mrp1 != [0L]:
                            cr.execute("select count(1) from mrp_bom where NAME =%s and id!=%s",
                                       (names, 0))
                            # 判断是否有这个产品真实产品BOM
                            if [x[0] for x in cr.fetchall()] == [0L]:
                                cr.execute("select id from product_template where pro_slider=%s and NAME=%s",
                                           (slider_line.name.id, names))
                                virtua_count = cr.fetchone();
                                # 得到product_id的key
                                cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                                           (virtua_count[0], 0))
                                addr_obj = cr.fetchone()
                                cr.execute(query_mrp_bom, (slider_line.name.id, 0))
                                # 循环遍历该产品的虚拟物品BOM信息，并生成真实真实BOM
                                for bom in cr.fetchall():
                                    # 向BOM行中添加数据
                                    cr.execute(add_mrp_bom_sel, (virtua_count[0], names, addr_obj[0], bom[18]))
                                    # 得到最近添加的BOM信息
                                    cr.execute(max_mrp_bom)
                                    bom_id_max_t = cr.fetchone()  # 获取到最近添加的BOM
                                    cr.execute(query_mrp_bom_line, (bom[18], 0))
                                    for bom_line in cr.fetchall():  # 遍历BOM明细中的数据
                                        indexs = bom_line[2]
                                        if bom_line[19] == u'BT(本头)':
                                            print("AAAAAAAAAA")
                                            cr.execute(sql_str,
                                                       (slider_line.slider_bentou.id, 0))
                                            indexs = cr.fetchone()
                                        if bom_line[19] == u'LP(拉片)':
                                            cr.execute(sql_str,
                                                       (slider[1], 0))
                                            indexs = cr.fetchone()
                                            print("DDDDDDDDDDDDDDDDDDDDD", indexs)
                                        cr.execute(add_mrp_bom_line_sel,
                                                   (indexs, bom_line[10], bom_id_max_t, bom_line[18]))
            cr.commit()
        except Exception, e:
            cr.execute("select count(1) from mrp_bom where product_tmpl_id =%s and id!=%s", (slider_line.name.id, 0))
            if [x[0] for x in cr.fetchall()] == [0L]:
                raise osv.except_osv(_('请维护该拉头的BOM模板,拉头名称为:'), _(slider_line.name.name))
            else:
                raise osv.except_osv(_('程序异常,请联系管理员！'), _(e.message))
            cr.rollback()
        return True

    def dt_draft(self, cr, uid, ids, context={}):
        state = 'draft'
        message = '单据重置为草稿'
        self.dt_action(cr, uid, ids, state, message, context=context)
        return True

    # 按钮的触发事件类
    def dt_action(self, cr, uid, ids, state, message, context={}):
        self.write(cr, uid, ids, {'state': state}, context=context)
        self.message_post(cr, uid, ids, body=_(message), context=context)
        return True

    def onchange_slider_name(self, cr, uid, ids, slider_name, context=None):
        res = {}
        domain = {}
        bentou = ''
        if slider_name:
            cr.execute("select count(1) from mrp_bom where product_tmpl_id=%s and id!=%s", (slider_name, 0))
            if [x[0] for x in cr.fetchall()] != [0L]:
                cr.execute("select id from mrp_bom where product_tmpl_id=%s and id!=%s", (slider_name, 0))
                pro_ids = cr.fetchone()
                cr.execute("select c.pro_typeid,c.id from mrp_bom_line a inner join product_product b\
                on a.product_id=b.id inner join product_template c on b.product_tmpl_id=c.id\
                 where a.bom_id=%s and a.id!=%s", (pro_ids[0], 0))
                for bom_line in cr.fetchall():
                    if bom_line[0] == u'BT(本头)':
                        bentou = bom_line[1]
            domain = {'slider_bentou':
                          [('virtual_item_key', '=', bentou)]}
        return {'value': res, 'domain': domain}


ycc_slider_model()

