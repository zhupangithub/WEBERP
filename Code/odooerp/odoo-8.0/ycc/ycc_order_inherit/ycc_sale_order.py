# -*- coding: utf-8 -*-
##############################################################################
# OpenERP Connector
# Copyright 2013 Amos <sale@100china.cn>
##############################################################################

from datetime import datetime, timedelta
import time
from openerp import SUPERUSER_ID
from openerp.osv import fields, osv
from openerp.tools.translate import _
from openerp.tools import DEFAULT_SERVER_DATE_FORMAT, DEFAULT_SERVER_DATETIME_FORMAT
import openerp.addons.decimal_precision as dp
from openerp import workflow
import Tkinter
import tkMessageBox

try:
    from openerp import SUPERUSER_ID
except ImportError:
    SUPERUSER_ID = SUPERUSER_ID


class ycc_orders(osv.Model):
    _inherit = 'sale.order'
    _columns = {
        'order_type': fields.selection(
            [(u'大货单', u'大货单'), (u'样品单', u'样品单'), (u'客户追加补数单', u'客户追加补数单'), (u'生产补料单', u'生产补料单'), (u'客户备货单', u'客户备货单'),
             (u'客户翻单', u'客户翻单'),
             (u'加急单', u'加急单')], '订单类别', required=True, copy=True, ),
        'level_kh': fields.char(u'客户等级', required=True),
        'sale_department': fields.char(u'销售部门', required=True),
        'user_id_salesman': fields.many2one('hr.employee', u'业务员', required=True),
        'user_ids': fields.many2one('res.users', u'销售助理', required=True),
        'partner_id_type': fields.many2one('res.partner.line', u'付款客户', readonly=True,
                                           states={'draft': [('readonly', False)], 'sent': [('readonly', False)]},
                                           required=True, change_default=True, select=True, track_visibility='always'),
        'closed_partner': fields.many2one('res.partner.line', u'收货客户', readonly=True,
                                          states={'draft': [('readonly', False)], 'sent': [('readonly', False)]},
                                          required=True, change_default=True, select=True, track_visibility='always'),
        'contact': fields.char(u'收货联系人', required=True),
        'phone': fields.char(u'联系电话'),
        'res_customer_date': fields.date(u'客户需求日期', help="客户需求日期不能小于当前日期"),
        'cost_name1': fields.char(u'附加费用一'),
        'cost_name2': fields.char(u'附加费用二'),
        'cost_name3': fields.char(u'附加费用三'),
        'cost_amount1': fields.float(u'金额一'),
        'cost_amount2': fields.float(u'金额二'),
        'cost_amount3': fields.float(u'金额三'),
        'res_address': fields.char(u'收货地址', required=True),
        'res_brand': fields.char(u'品牌客户'),
        'currency_type': fields.many2one('res.currency', u'币别', domain=[('active', '=', True)], required=True),
        'exchange': fields.float(u'汇率', required=True),
        'positive_describe': fields.text(u' '),
        'side_describe': fields.text(u' '),
        'product_a': fields.boolean(u'无毒'),
        'product_b': fields.boolean(u'无铅'),
        'product_c': fields.boolean(u'无镍'),
        'product_d': fields.boolean(u'无偶氮'),
        'product_e': fields.boolean(u'过检针'),
        'product_f': fields.boolean(u'抗酵素石磨水洗'),
        'product_g': fields.boolean(u'防酸抗碱处理'),
        'product_h': fields.boolean(u'DTB烟雾防腐蚀'),
        'product_i': fields.boolean(u'过48小时烟雾'),
        'product_j': fields.boolean(u'过5次机洗'),
        'detection_a': fields.boolean(u'中国QB'),
        'detection_b': fields.boolean(u'美国ASTM'),
        'detection_c': fields.boolean(u'英国BS'),
        'detection_d': fields.boolean(u'德国CA'),
        'detection_e': fields.boolean(u'日本JIS'),
        'detection_f': fields.boolean(u'德国BV'),
        'light_a': fields.boolean(u'CWF'),
        'light_b': fields.boolean(u'自然光'),
        'light_c': fields.boolean(u'D65'),
        'light_d': fields.boolean(u'TL84'),
        'light_e': fields.boolean(u'F'),
        'light_f': fields.boolean(u'UV'),
        'process_a': fields.boolean(u'固色'),
        'process_b': fields.boolean(u'防火防水'),
        'process_c': fields.boolean(u'特别固色'),
        'process_d': fields.boolean(u'要求带荧光'),
        'process_e': fields.boolean(u'除油'),
        'process_f': fields.boolean(u'(硬挺)树脂整理'),
        'process_g': fields.boolean(u'日光灯'),
        'packaging_a': fields.boolean(u'YCC'),
        'packaging_b': fields.boolean(u'中性'),
        'packaging_c': fields.boolean(u'指定'),
        'packaging_text': fields.text(u' '),
        'bleaching': fields.text(u' '),
    }

    _defaults = {
        'user_ids': lambda cr, uid, id, c={}: id,
        'order_type': u'大货单',
    }


    def onchange_closed_partner(self, cr, uid, ids, closed_partner, context=None):
        res = {}
        partners = ""
        if closed_partner:
            cr.execute("select name from res_partner_line where id=%s and id!=%s", (closed_partner, 0))
            partners = self.pool.get('res.partner').browse(cr, uid, cr.fetchone()[0], context=context)
            res['contact'] = partners.res_contact
            res['phone'] = partners.res_contact_phone
            res['level_kh'] = partners.res_level.name
            res['res_brand'] = partners.res_brand.name
            res['res_address'] = partners.street
            res['currency_type'] = partners.res_currency_type
            res['user_id_salesman'] = partners.user_id.id
        return {'value': res}

    # 得到部门
    def onchange_closed_salesman(self, cr, uid, ids, closed_salesman, context=None):
        res = {}
        partners = ""
        if closed_salesman:
            hrs = self.pool.get('hr.employee').browse(cr, uid, closed_salesman, context=context)
            res['sale_department'] = hrs.department_id.name
        return {'value': res}

    # 得到汇率
    def onchange_currency_type(self, cr, uid, ids, currency_type, context=None):
        res = {}
        if currency_type:
            currency = self.pool.get('res.currency').browse(cr, uid, currency_type, context=context)
            res['exchange'] = currency.rate_silent
        return {'value': res}


ycc_orders()


class ycc_order_line(osv.Model):
    _inherit = 'sale.order.line'
    _columns = {
        'product_style': fields.char(u'款号'),
        'product_color': fields.many2one('ycc.color', u'色带颜色', required=True, domain=[('color_active', '=', True)]),
        'pro_on_color': fields.many2one('ycc.color', u'上止颜色', required=True),
        'pro_under_color': fields.many2one('ycc.color', u'下止颜色', domain=[('color_active', '=', True)]),
        'pullhead_on_name': fields.many2one('product.template', u'上拉名称', required=True,
                                            domain=[('pro_slider', '!=', False)]),
        'pullhead_on_color': fields.many2one('ycc.color', u'上拉颜色', required=True, domain=[('color_active', '=', True)]),
        'pullhead_under_name': fields.many2one('product.template', u'下拉名称', domain=[('pro_slider', '!=', False)]),
        'pullhead_under_color': fields.many2one('ycc.color', u'下拉颜色', domain=[('color_active', '=', True)]),
        'stitches_color': fields.many2one('ycc.color', u'缝线颜色'),
        'cloth_color': fields.many2one('ycc.color', u'布胶颜色'),
        'order_join': fields.many2one('sale.order', u'关联订单'),
        'pro_slider_color': fields.many2one('ycc.color', u'链牙颜色', required=True),
        'length': fields.float(u'拉链长度', required=True),
        'loss_number': fields.integer(u"损耗数量"),
        'square_color': fields.many2one('ycc.color', u'方块插销'),
        'me_state': fields.char(u'产品材质'),
        'kbk_state': fields.char(u'开闭口')
    }

    def onchange_product_color(self, cr, uid, ids, product_color, context=None):
        res = {}
        if product_color:
            currency = self.pool.get('ycc.color').browse(cr, uid, product_color, context=context)
            res['pullhead_on_color'] = currency.id
            res['pro_on_color'] = currency.id
            res['square_color'] = currency.id
            res['pro_under_color'] = currency.id
            res['pro_slider_color'] = currency.id
            res['cloth_color'] = currency.id
            res['stitches_color'] = currency.id
        return {'value': res}

    def save_action_ok(self, cr, uid, ids, context=None):  # 订单行生产BOM
        try:
            max_pro_temp_id = "select max(id) from product_template"
            max_pro_product_id = "select max(id) from product_product"
            max_mrp_bom = "select max(id) from mrp_bom"
            query_mrp_bom_line = "SELECT a.product_uos_qty,a.create_date, a.product_id, a.product_uom,\
                                    a.sequence,a.create_uid, a.write_uid, a.routing_id, a.product_rounding,\
                                    a.write_date, a.product_qty, a.product_uos, a.product_efficiency, a.type,\
                                     c.sedai_oks,c.id,b.name_template,c.pro_slider_active,a.id,c.length_ok,c.pro_select_color,b.id FROM mrp_bom_line a inner join product_product b on a.product_id=b.id inner join\
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
			    sedai_oks, pro_material, pro_kaibikou, length_ok, pro_slider_active,pro_lianya_color, date_ends, pro_size, pro_color_key, pro_slider,
			    pro_item_active, pro_length, virtual_item_key)(select end_location_id,warranty,pro_typeid,uos_id, list_price, weight, color, image, write_uid,
			    mes_type, uom_id, description_purchase, create_date, uos_coeff,create_uid, sale_ok, categ_id, product_manager, message_last_post,
			    company_id, state, uom_po_id, description_sale, description,weight_net, volume, write_date, active, rental, image_medium,
			    %s, type, image_small, track_all, track_outgoing, loc_rack,loc_case, track_incoming, loc_row, sale_delay, produce_delay,
			    track_production, purchase_ok, pro_vacancy, pro_select_color,
			    sedai_oks, pro_material, pro_kaibikou, length_ok, pro_slider_active,%s, date_ends, pro_size, %s, %s,
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
            order_line = self.pool.get('sale.order.line').browse(cr, uid, ids)  # 订单行
            product = self.pool.get('product.product').browse(cr, uid, order_line.product_id.id)  # 产品表
            product_tmp = self.pool.get('product.template').browse(cr, uid, product.product_tmpl_id.id)  # 产品模板表
            if int(order_line.pullhead_on_name) != False:
                names = product_tmp.pro_material + product_tmp.pro_size + product_tmp.pro_kaibikou + order_line.product_color.name + str(
                    order_line.length) + "CM" + " DT" + order_line.pullhead_on_name.name
            # 生成带颜色的拉头BOM
            new_sliders_ok=1
            if int(order_line.pullhead_on_name) != False and int(order_line.pullhead_on_color) != False:
                strs = order_line.pullhead_on_name.name
                slider_names = strs.split('&&&')[0]
                slider_name = slider_names + "&&&" + order_line.pullhead_on_color.name
                cr.execute("select count(1) from product_template where name=%s and id!=%s", (slider_name, 0))
                if [x[0] for x in cr.fetchall()] == [0L]:
                    ####产品名称,链牙,色带,关联的拉头,长度,虚拟物品，ID获取后，添加一个新的产品
                    cr.execute(add_product_template, (
                        slider_name, None, None, order_line.pullhead_on_name.id, 0, None,
                        order_line.pullhead_on_name.id))
                    cr.execute(max_pro_temp_id)
                    # 获取最近插入的哪一行记录的ID,并向product_product表中添加一行数据
                    slider_pro_tem_maxid = cr.fetchone()
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                               (order_line.pullhead_on_name.id, 0))
                    slider_prid = cr.fetchone()
                    cr.execute(add_product_product_sel, (slider_name, slider_pro_tem_maxid, slider_prid))
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                               (slider_pro_tem_maxid, 0))
                    slider_product_ids = cr.fetchone()[0]
                    print("HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH")
                    new_sliders_ok=slider_product_ids
                    # 添加在补货规则的信息
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                               (order_line.pullhead_on_name.id, 0))
                    product = cr.fetchone()
                    cr.execute("update sale_order_line set pullhead_on_name=%s where id=%s",
                               (slider_pro_tem_maxid, order_line.id))
                    cr.execute(luxian, (slider_pro_tem_maxid, order_line.pullhead_on_name.id))  #####Coyp路线
                    cr.execute(rules, ('OP/000' + str(slider_pro_tem_maxid), slider_product_ids,
                                       product))  ##生成在补货规则
                    cr.execute(caigou, (slider_pro_tem_maxid, order_line.pullhead_on_name.id))  ###添加采购商
                    cr.execute("select count(1) from mrp_bom where product_tmpl_id =(%s) and id!=%s",
                               (order_line.pullhead_on_name.id, 0))
                    line_slider = [x[0] for x in cr.fetchall()]
                    # 判断是否有这个虚拟产品的虚拟BOM
                    if line_slider != [0L]:
                        cr.execute("select count(1) from mrp_bom where NAME =%s and id!=%s",
                                   (slider_name, 0))
                        # 判断是否有这个产品真实产品BOM
                        if [x[0] for x in cr.fetchall()] == [0L]:
                            cr.execute(query_mrp_bom, (order_line.pullhead_on_name.id, 0))
                            # 循环遍历该产品的虚拟物品BOM信息，并生成真实真实BOM
                            for bom in cr.fetchall():
                                # 向BOM行中添加数据
                                cr.execute(add_mrp_bom_sel,
                                           (slider_pro_tem_maxid, slider_name, slider_product_ids, bom[18]))
                                # 得到最近添加的BOM信息
                                cr.execute(max_mrp_bom)
                                bom_id_max_t = cr.fetchone()  # 获取到最近添加的BOM
                                cr.execute(query_mrp_bom_line, (bom[18], 0))
                                for bom_line in cr.fetchall():  # 遍历BOM明细中的数据
                                    cr.execute(add_mrp_bom_line_sel,
                                               (bom_line[2], bom_line[10], bom_id_max_t, bom_line[18]))
                else:
                    cr.execute("select id from product_template where name=%s and id!=%s", (slider_name, 0))
                    ups_id = cr.fetchone()[0]
                    print("JJJJJJJJJJJJJJJJJJJJJJJ",ups_id)
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",(ups_id,0))
                    new_sliders_ok=cr.fetchone()[0]
                    cr.execute("update sale_order_line set pullhead_on_name=%s where id=%s",
                               (ups_id, order_line.id))
            if int(order_line.pullhead_under_name) != False and int(order_line.pullhead_under_color) != False:
                strs2 = order_line.pullhead_on_name.name
                slider_names2 = strs2.split('&&&')[0]
                slider_name2 = slider_names2 + " " + order_line.pullhead_under_name.name
                cr.execute("select count(1) from product_template where name=%s and id!=%s", (slider_name2, 0))
                if [x[0] for x in cr.fetchall()] == [0L]:
                    ####产品名称,链牙,色带,关联的拉头,长度,虚拟物品，ID获取后，添加一个新的产品
                    cr.execute(add_product_template, (
                        slider_name2, None, None, order_line.pullhead_under_name.id, 0, None,
                        order_line.pullhead_under_name.id))
                    cr.execute(max_pro_temp_id)
                    # 获取最近插入的哪一行记录的ID,并向product_product表中添加一行数据
                    slider_pro_tem_maxid2 = cr.fetchone()
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                               (order_line.pullhead_under_name.id, 0))
                    slider_prid2 = cr.fetchone()
                    cr.execute(add_product_product_sel, (slider_name, slider_pro_tem_maxid2[0], slider_prid2))
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                               (slider_pro_tem_maxid2[0], 0))
                    slider_product_ids2 = cr.fetchone()[0]
                    # 添加在补货规则的信息
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                               (order_line.pullhead_under_name.id, 0))
                    product2 = cr.fetchone()
                    cr.execute("update sale_order_line set pullhead_under_name=%s where id=%s",
                               (slider_pro_tem_maxid2[0], order_line.id))
                    cr.execute(luxian, (slider_pro_tem_maxid2[0], order_line.pullhead_under_name.id))  #####Coyp路线
                    cr.execute(rules, ('OP/000' + str(slider_pro_tem_maxid2[0]), slider_product_ids2,
                                       product2))  ##生成在补货规则
                    cr.execute(caigou, (slider_pro_tem_maxid2[0], order_line.pullhead_under_name.id))  ###添加采购商
                    cr.execute("select count(1) from mrp_bom where product_tmpl_id =(%s) and id!=%s",
                               (order_line.pullhead_under_name.id, 0))
                    line_slider2 = [x[0] for x in cr.fetchall()]
                    # 判断是否有这个虚拟产品的虚拟BOM
                    if line_slider2 != [0L]:
                        cr.execute("select count(1) from mrp_bom where NAME =%s and id!=%s",
                                   (slider_name2, 0))
                        # 判断是否有这个产品真实产品BOM
                        if [x[0] for x in cr.fetchall()] == [0L]:
                            cr.execute(query_mrp_bom, (order_line.pullhead_under_name.id, 0))
                            # 循环遍历该产品的虚拟物品BOM信息，并生成真实真实BOM
                            for bom in cr.fetchall():
                                # 向BOM行中添加数据
                                cr.execute(add_mrp_bom_sel,
                                           (slider_pro_tem_maxid2, slider_name2, slider_product_ids2, bom[18]))
                                # 得到最近添加的BOM信息
                                cr.execute(max_mrp_bom)
                                bom_id_max_t = cr.fetchone()  # 获取到最近添加的BOM
                                cr.execute(query_mrp_bom_line, (bom[18], 0))
                                for bom_line in cr.fetchall():  # 遍历BOM明细中的数据
                                    cr.execute(add_mrp_bom_line_sel,
                                               (bom_line[2], bom_line[10], bom_id_max_t, bom_line[18]))
                else:
                    cr.execute("select id from product_template where name=%s and id!=%s", (slider_name2, 0))
                    ups_id2 = cr.fetchone()[0]
                    cr.execute("update sale_order_line set pullhead_under_name=%s where id=%s",
                               (ups_id2, order_line.id))

            if int(order_line.pullhead_on_name) != False and int(order_line.pullhead_under_name) != False:
                names = product_tmp.pro_material + product_tmp.pro_size + product_tmp.pro_kaibikou + order_line.product_color.name + str(
                    order_line.length) + "CM" + " DT" + order_line.pullhead_on_name.name + u"下拉" + order_line.pullhead_under_name.name
            if product_tmp.pro_item_active == True:
                cr.execute("select count(1) from ycc_loss where %s>loss_min and %s<loss_max",
                           (order_line.product_uos_qty, order_line.product_uos_qty))
                if [x[0] for x in cr.fetchall()] != [0L]:  # 计算损耗
                    cr.execute("select loss_number from ycc_loss where %s>=loss_min and %s<=loss_max",
                               (int(order_line.product_uom_qty), int(order_line.product_uom_qty)))
                    ycc_loss = cr.fetchone()  ######损耗率
                    result = float(order_line.product_uom_qty * ycc_loss[0])
                    cr.execute(
                        "update sale_order_line set product_uom_qty=%s,loss_number=%s where id=%s",
                        (int(result + order_line.product_uom_qty),
                         int(result),
                         order_line.id))
                cr.execute("select count(1) from product_template where name=%s and id!=%s", (names, 0))
                if [x[0] for x in cr.fetchall()] == [0L]:
                    ####产品名称,链牙,色带,长度,虚拟物品，ID获取后，添加一个新的产品
                    cr.execute(add_product_template, (
                        names, order_line.pro_slider_color.id, order_line.product_color.id, None, order_line.length,
                        product_tmp.id, product_tmp.id))
                    cr.execute(max_pro_temp_id)
                    # 获取最近插入的哪一行记录的ID,并向product_product表中添加一行数据
                    liners2 = cr.fetchone()
                    cr.execute(add_product_product_sel, (names, liners2, order_line.product_id.id))
                    cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s", (liners2[0], 0))
                    product_ids = cr.fetchone()
                    # 添加在补货规则的信息
                    cr.execute("update sale_order_line set product_id=%s where id=%s", (product_ids[0], order_line.id))
                    cr.execute(luxian, (liners2[0], product_tmp.id))  #####Coyp路线
                    cr.execute(rules, ('OP/000' + str(liners2[0]), product_ids, order_line.product_id.id))  ##生成在补货规则
                    cr.execute(caigou, (liners2[0], product_tmp.id))  ###添加采购商
                else:
                    if product_tmp.pro_item_active == True:
                        cr.execute("select id from product_template where virtual_item_key=%s and name=%s",
                                   (product_tmp.id, names))
                        template_id = cr.fetchone()
                        cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                                   (template_id, 0))
                        product_id = cr.fetchone()
                        cr.execute("update sale_order_line set product_id=%s where id=%s", (product_id, order_line.id))
                ##############################################################################################################
                # 以下代码生成BOM
                cr.execute("select count(1) from mrp_bom where product_tmpl_id =(%s) and id!=%s", (product_tmp.id, 0))
                line_mrp1 = [x[0] for x in cr.fetchall()]
                # 判断是否有这个虚拟产品的虚拟BOM
                if line_mrp1 != [0L]:
                    cr.execute("select count(1) from mrp_bom where NAME =%s and id!=%s",
                               (names, 0))
                    # 判断是否有这个产品真实产品BOM
                    if [x[0] for x in cr.fetchall()] == [0L]:
                        cr.execute("select id from product_template where virtual_item_key=%s and NAME=%s",
                                   (product_tmp.id, names))
                        virtua_count = cr.fetchone();
                        # 得到product_id的key
                        cr.execute("select id from product_product where product_tmpl_id=%s and id!=%s",
                                   (virtua_count[0], 0))
                        addr_obj = cr.fetchone()
                        cr.execute(query_mrp_bom, (product_tmp.id, 0))
                        # 循环遍历该产品的虚拟物品BOM信息，并生成真实真实BOM
                        for bom in cr.fetchall():
                            # 向BOM行中添加数据
                            cr.execute(add_mrp_bom_sel, (virtua_count[0], names, addr_obj[0], bom[18]))
                            # 得到最近添加的BOM信息
                            cr.execute(max_mrp_bom)
                            bom_id_max_t = cr.fetchone()  # 获取到最近添加的BOM
                            cr.execute(query_mrp_bom_line, (bom[18], 0))
                            for bom_line in cr.fetchall():  # 遍历BOM明细中的数据
                                # 遍历BOM行信息
                                new_product_id = bom_line[2]  ##二层BOM行中的产品ID
                                new_pro_tem_id = bom_line[15]  ##BOM模板ID
                                sedai_names = ''  ##新生成的物料名称
                                sedai_length = bom_line[10]  ###长度计算的时候使用
                                if bom_line[20] == u'色胚' and order_line.product_color.name != None:  # 色带
                                    sedai_names = bom_line[16] + "&&" + order_line.product_color.name
                                    if bom_line[19] == True:  # 是否和长度关联勾选时
                                        sedai_length = order_line.length + product_tmp.pro_vacancy  # 产品长度加上空位的长度

                                if bom_line[20] == u'上止' and order_line.pro_on_color.name != None:  # 甲醛
                                    sedai_names = bom_line[16] + "&&" + order_line.pro_on_color.name
                                    if bom_line[19] == True:  # 是否和长度关联勾选时
                                        sedai_length = order_line.length + product_tmp.pro_vacancy

                                if bom_line[20] == u'下止' and order_line.pro_under_color.name != None:  # 甲醛
                                    sedai_names = bom_line[16] + "&&" + order_line.pro_under_color.name
                                    if bom_line[19] == True:  # 是否和长度关联勾选时
                                        sedai_length = order_line.length + product_tmp.pro_vacancy

                                if bom_line[20] == u'布胶' and order_line.cloth_color.name != None:  # 布胶
                                    sedai_names = bom_line[16] + "&&" + order_line.cloth_color.name
                                    if bom_line[19] == True:  # 是否和长度关联勾选时
                                        sedai_length = order_line.length + product_tmp.pro_vacancy

                                if bom_line[20] == u'链牙' and order_line.pro_slider_color.name != None:  # 链牙
                                    sedai_names = bom_line[16] + "&&" + order_line.pro_slider_color.name
                                    if bom_line[19] == True:  # 是否和长度关联勾选时
                                        sedai_length = order_line.length + product_tmp.pro_vacancy

                                if bom_line[20] == u'方块插销' and order_line.square_color.name != None:  # 链牙
                                    sedai_names = bom_line[16] + "&&" + order_line.square_color.name
                                    if bom_line[19] == True:  # 是否和长度关联勾选时
                                        sedai_length = order_line.length + product_tmp.pro_vacancy

                                if bom_line[14] == False:  ##没有勾选和颜色关联
                                    sedai_names = bom_line[16]
                                if bom_line[14] == None:
                                    sedai_names = bom_line[16]
                                if bom_line[17] == True:  # 当是虚拟拉头的时候
                                    # cr.execute("select id from product_product where product_tmpl_id=%s and id!=0%s",
                                    #            (new_sliders_ok, 0))
                                    new_product_id = new_sliders_ok # 订单行中的拉头
                                cr.execute("select COUNT(1) from product_product where name_template=%s and id!=%s",
                                           (sedai_names, 0))
                                if [x[0] for x in cr.fetchall()] == [0L]:  # 查询产品表中是否有这个物料，如果没有就添加
                                    ####产品名称,链牙,色带,长度,虚拟物品，ID获取后，添加一个新的产品
                                    cr.execute(add_product_template,
                                               (sedai_names, None, None, None, 0, None, bom_line[15]))
                                    cr.execute(max_pro_temp_id)
                                    max_new_pro_tem_id = cr.fetchone()  ##获取到最近插入的物料ID，product_template表中
                                    cr.execute(add_product_product_sel,
                                               (sedai_names, max_new_pro_tem_id[0], bom_line[21]))
                                    cr.execute(max_pro_product_id)
                                    new_product_id = cr.fetchone()[0]  ##最近插入的product表的ID
                                    new_pro_tem_id = max_new_pro_tem_id[0]
                                    cr.execute(luxian, (new_pro_tem_id, bom_line[15]))
                                    cr.execute(rules, ('OP/000' + str(new_pro_tem_id), new_product_id, bom_line[21]))
                                    cr.execute(caigou, (new_pro_tem_id, bom_line[15]))
                                if bom_line[20] != None and bom_line[20] != sedai_names:
                                    cr.execute(
                                        "select id,product_tmpl_id from product_product where name_template=%s and id!=0%s",
                                        (sedai_names, 0))
                                    res_pro = cr.fetchone()
                                    new_product_id = res_pro[0]
                                    new_pro_tem_id = res_pro[1]
                                cr.execute(add_mrp_bom_line_sel,
                                           (new_product_id, sedai_length, bom_id_max_t[0], bom_line[18]))
                                cr.execute("select pro_item_active from product_template where id=%s and id!=%s",(bom[9],0))
                                bools=cr.fetchone()[0]
                                print("TTTTTTTTTTTTTTTTTTTTTT",bom_line[17],bom[9],bools)
                                if bom_line[17] != True and bools!=True:
                                    cr.execute("delete from mrp_bom where name=%s and id!=%s", (sedai_names, 0))
                                cr.execute("select COUNT(1)from mrp_bom where name=%s and id!=%s",
                                           (sedai_names, 0))
                                if [x[0] for x in cr.fetchall()] == [0L]:
                                    cr.execute("select product_id from mrp_bom_line where bom_id=%s and id!=%s",
                                               (bom[18], 0))
                                    # 遍历BOM行中的产品
                                    for bom_state in cr.fetchall():
                                        cr.execute("select count(1) from mrp_bom where product_id=%s and id!=%s",
                                                   (bom_state[0], 0))
                                        if [x[0] for x in cr.fetchall()] != [0L]:
                                            cr.execute(query_mrp_bom,
                                                       (bom_line[15], 0))
                                            for new_mrp_bom in cr.fetchall():
                                                cr.execute("select COUNT(1)from mrp_bom where name=%s and id!=%s",
                                                           (sedai_names, 0))
                                                bom_id_max_new = None
                                                if [x[0] for x in cr.fetchall()] == [0L]:
                                                    cr.execute(add_mrp_bom_sel, (
                                                        new_pro_tem_id, sedai_names, new_product_id, new_mrp_bom[18]))
                                                    cr.execute(max_mrp_bom)
                                                    bom_id_max_new = cr.fetchone()[0]  ###最近添加的BOMID
                                                cr.execute(query_mrp_bom_line, (new_mrp_bom[18], 0))
                                                for new_mrp_bom_line in cr.fetchall():  # 第三层的BOM解析
                                                    #############################################
                                                    ########产品模板对象#########################
                                                    new_product_id2 = new_mrp_bom_line[2]
                                                    new_pro_tem_id2 = new_mrp_bom_line[15]
                                                    sedai_names2 = ''
                                                    sedai_length2 = new_mrp_bom_line[10]
                                                    if new_mrp_bom_line[
                                                        20] == u'色胚' and order_line.product_color.name != None:  # 色带
                                                        sedai_names2 = new_mrp_bom_line[
                                                                           16] + "&&" + order_line.product_color.name
                                                        if new_mrp_bom_line[19] == True:
                                                            sedai_length2 = order_line.length + product_tmp.pro_vacancy
                                                    if new_mrp_bom_line[
                                                        20] == u'上止' and order_line.pro_on_color.name != None:  # 甲醛
                                                        sedai_names2 = new_mrp_bom_line[
                                                                           16] + "&&" + order_line.pro_on_color.name
                                                        if new_mrp_bom_line[19] == True:
                                                            sedai_length2 = order_line.length + product_tmp.pro_vacancy
                                                    if new_mrp_bom_line[
                                                        20] == u'下止' and order_line.pro_under_color.name != None:  # 甲醛
                                                        sedai_names2 = new_mrp_bom_line[
                                                                           16] + "&&" + order_line.pro_under_color.name
                                                        if new_mrp_bom_line[19] == True:
                                                            sedai_length2 = order_line.length + product_tmp.pro_vacancy
                                                    if new_mrp_bom_line[
                                                        20] == u'布胶' and order_line.cloth_color.name != None:  # 布胶
                                                        sedai_names2 = new_mrp_bom_line[
                                                                           16] + "&&" + order_line.cloth_color.name
                                                        if new_mrp_bom_line[19] == True:
                                                            sedai_length2 = order_line.length + product_tmp.pro_vacancy
                                                    if new_mrp_bom_line[
                                                        20] == u'链牙' and order_line.pro_slider_color.name != None:  # 链牙
                                                        sedai_names2 = new_mrp_bom_line[
                                                                           16] + "&&" + order_line.pro_slider_color.name
                                                        if new_mrp_bom_line[19] == True:
                                                            sedai_length2 = order_line.length + product_tmp.pro_vacancy
                                                    if new_mrp_bom_line[
                                                        20] == u'方块插销' and order_line.square_color.name != None:  # 链牙
                                                        sedai_names2 = new_mrp_bom_line[
                                                                           16] + "&&" + order_line.square_color.name
                                                        if new_mrp_bom_line[19] == True:
                                                            sedai_length2 = order_line.length + product_tmp.pro_vacancy
                                                    if new_mrp_bom_line[14] == False:
                                                        sedai_names2 = new_mrp_bom_line[16]
                                                    if new_mrp_bom_line[14] == None:
                                                        sedai_names2 = new_mrp_bom_line[16]
                                                    cr.execute(
                                                        "select COUNT(1) from product_product where name_template=%s and id!=%s",
                                                        (sedai_names2, 0))
                                                    if [x[0] for x in cr.fetchall()] == [0L]:  # 查询产品表中是否有这个物料，如果没有就添加
                                                        ####产品名称,链牙,色带,长度,虚拟物品，ID获取后，添加一个新的产品
                                                        cr.execute(add_product_template, (
                                                            sedai_names2, None, None, None, 0, None,
                                                            new_mrp_bom_line[15]))
                                                        cr.execute(max_pro_temp_id)
                                                        max_new_pro_tem_id2 = cr.fetchone()  # 最近插入的物料的ID
                                                        cr.execute(add_product_product_sel, (
                                                            sedai_names2, max_new_pro_tem_id2[0], new_mrp_bom_line[21]))
                                                        cr.execute(max_pro_product_id)
                                                        new_product_id2 = cr.fetchone()[0]
                                                        new_pro_tem_id2 = max_new_pro_tem_id2[0]
                                                        cr.execute(luxian, (new_pro_tem_id2, new_mrp_bom_line[15]))
                                                        cr.execute(rules, (
                                                            'OP/000' + str(new_pro_tem_id2), new_product_id2,
                                                            new_mrp_bom_line[21]))
                                                        cr.execute(caigou, (new_pro_tem_id2, new_mrp_bom_line[15]))
                                                    if new_mrp_bom_line[20] != None and new_mrp_bom_line[
                                                        20] != sedai_names2:
                                                        cr.execute(
                                                            "select id,product_tmpl_id from product_product where name_template=%s and id!=0%s",
                                                            (sedai_names2, 0))
                                                        res_pros = cr.fetchone()
                                                        new_product_id2 = res_pros[0]
                                                        new_pro_tem_id2 = res_pros[1]
                                                    if bom_id_max_new != None:
                                                        cr.execute(
                                                            "select count(1) from mrp_bom_line where bom_id=%s and product_id=%s",
                                                            (bom_id_max_new, new_product_id2))
                                                        if [x[0] for x in cr.fetchall()] == [0L]:
                                                            cr.execute(add_mrp_bom_line_sel, (
                                                                new_product_id2, sedai_length2, bom_id_max_new,
                                                                new_mrp_bom_line[18]))
                                                    cr.execute("select pro_item_active from product_template where id=%s and id!=%s",(new_mrp_bom[9],0))
                                                    bools2=cr.fetchone()[0]
                                                    print("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS",new_mrp_bom[9],bools2,new_mrp_bom_line[17])
                                                    if new_mrp_bom_line[17] != True and bools2!=True:
                                                        cr.execute("delete from mrp_bom where name=%s and id!=%s",
                                                                   (sedai_names2, 0))
                                                    cr.execute("select COUNT(1)from mrp_bom where name=%s and id!=%s",
                                                               (sedai_names2, 0))
                                                    if [x[0] for x in cr.fetchall()] == [0L]:
                                                        cr.execute(
                                                            "select product_id from mrp_bom_line where bom_id=%s and id!=%s",
                                                            (new_mrp_bom[18], 0))
                                                        # 遍历BOM行中的产品
                                                        for bom_state2 in cr.fetchall():
                                                            cr.execute(
                                                                "select count(1) from mrp_bom where product_id=%s and id!=%s",
                                                                (bom_state2[0], 0))
                                                            if [x[0] for x in cr.fetchall()] != [0L]:
                                                                cr.execute(query_mrp_bom,
                                                                           (new_mrp_bom_line[15], 0))
                                                                for new_mrp_bom2 in cr.fetchall():
                                                                    cr.execute(
                                                                        "select COUNT(1)from mrp_bom where name=%s and id!=%s",
                                                                        (sedai_names2, 0))
                                                                    if [x[0] for x in cr.fetchall()] == [0L]:
                                                                        cr.execute(add_mrp_bom_sel, (
                                                                            new_pro_tem_id2, sedai_names2,
                                                                            new_product_id2,
                                                                            new_mrp_bom2[18]))
                                                                    cr.execute(max_mrp_bom)
                                                                    bom_id_max_new2 = cr.fetchone()[0]
                                                                    cr.execute(query_mrp_bom_line,
                                                                               (new_mrp_bom2[18], 0))
                                                                    for new_mrp_bom_line2 in cr.fetchall():
                                                                        cr.execute(
                                                                            "select count(1) from mrp_bom_line where bom_id=%s and product_id=%s",
                                                                            (bom_id_max_new2, new_mrp_bom_line2[2]))
                                                                        if [x[0] for x in cr.fetchall()] == [0L]:
                                                                            cr.execute(add_mrp_bom_line_sel, (
                                                                                new_mrp_bom_line2[2],
                                                                                new_mrp_bom_line2[10],
                                                                                bom_id_max_new2, new_mrp_bom_line2[18]))
                    cr.commit()
        except Exception, e:
            cr.execute("select count(1) from mrp_bom where product_tmpl_id =(%s) and id!=%s", (product_tmp.id, 0))
            if [x[0] for x in cr.fetchall()] == [0L]:
                raise osv.except_osv(_('请维护该产品的BOM模板,产品名称为:'), _(product_tmp.name))
            else:
                raise osv.except_osv(_('程序异常,请联系管理员！'), _(e.message))
            cr.rollback()
        return True

    _sql_constraints = [
        ('check_length', 'check(length>0)', u'拉链长度不能为0！'),
    ]
    _defaults = {
        'length': lambda *a: 7.0,
    }


ycc_order_line()


class ycc_partner(osv.Model):
    _inherit = "res.partner"
    _columns = {
        'res_brand': fields.many2one('ycc.brand', u'客户品牌', domain=[('brand_active', '=', True)]),
        'res_level': fields.many2one('ycc.level', u'等级', domain=[('level_active', '=', True)], required=True),
        'res_contact': fields.char(u'收货联系人', required=True),
        'res_contact_phone': fields.char(u'收货联系人电话'),
        'res_line': fields.one2many('res.partner.line', 'line_id'),
        'res_type_id': fields.many2many('res.type.line', 'res_partner_type', id1='type_id', id2='res_type_id',
                                        string='成品类别'),
        'res_currency_type': fields.many2one('res.currency', u'币别', domain=[('active', '=', True)],
                                             required=True),
        'state': fields.selection([('draft', u'草稿'),
                                   ('review', u'等待经理审核'),
                                   ('review2', u'等待大区审核'),
                                   ('done', u'已完成'),
                                   ('cancel', u'取消'), ],
                                  u'状态'),
        'shi_state': fields.many2one("ycc.product.type", u'市(区)', ondelete='restrict'),
    }
    _defaults = {
        'state': lambda *a: 'draft',
        'country_id': 49,
    }

    def onchange_state2(self, cr, uid, ids, state_id, context=None):
        domain = {}
        if state_id:
            domain = {'shi_state':
                          [('sheng', '=', state_id)]}
        return {'domain': domain}

    def onchange_chengshi(self, cr, uid, ids, shi_state, context=None):
        res = {}
        if shi_state:
            partner = self.pool.get('ycc.product.type').browse(cr, uid, shi_state, context=context)
            res['city'] = partner.name
            res['zip'] = partner.numbers
            res['state_id'] = partner.sheng
        return {'value': res}

    def dt_review(self, cr, uid, ids, context=None):
        return self.write(cr, uid, ids, {'state': 'review'})

    def dt_cancel(self, cr, uid, ids, context=None):
        state = 'cancel'
        message = '单据已取消'
        self.dt_action(cr, uid, ids, state, message, context=context)
        return True

    def dt_done(self, cr, uid, ids, context=None):
        state = 'review2'
        message = '提交到大区'
        self.dt_action(cr, uid, ids, state, message, context=context)
        return True

    def dt_done2(self, cr, uid, ids, context=None):
        state = 'done'
        message = '单据已完成'
        self.dt_action(cr, uid, ids, state, message, context=context)
        return True


    def dt_draft(self, cr, uid, ids, context={}):
        state = 'draft'
        message = '单据重置为草稿'
        self.dt_action(cr, uid, ids, state, message, context=context)
        return True

    def dt_action(self, cr, uid, ids, state, message, context={}):
        self.write(cr, uid, ids, {'state': state}, context=context)
        # 推送消息
        self.message_post(cr, uid, ids, body=_(message), context=context)
        return True


ycc_partner()


class res_item_line(osv.Model):
    _description = 'res.type.line'
    _name = 'res.type.line'
    _columns = {
        'name': fields.char(u'成品名称', required=True),
        'active': fields.boolean(u'是否启用'),
    }

    _defaults = {
        'active': 1,
    }


res_item_line()


class ycc_partner_line(osv.Model):
    _name = "res.partner.line"
    _log_access = False
    _description = "res.partner.line"
    _columns = {
        'name': fields.many2one('res.partner', u'关系客户', required=True),
        'line_id': fields.many2one('res.partner'),
        'line_address': fields.char(u'收货地址'),
        'line_username': fields.char(u'联系人'),
        'line_phone': fields.char(u'联系人电话'),
        'line_relation': fields.selection(
            [(u'下单', u'下单'), (u'品牌', u'品牌'), (u'开票', u'开票'), (u'收货', u'收货'), (u'付款', u'付款'), (u'加工', u'加工')], '关系',
            required=True,
            copy=True, ),
        'line_active': fields.boolean(u'是否有效', select=2),
    }

    _defaults = {
        'line_active': True,
    }

    def onchange_partner_id(self, cr, uid, ids, line_name, context=None):
        res = {}
        if line_name:
            partner = self.pool.get('res.partner').browse(cr, uid, line_name, context=context)
            res['line_username'] = partner.res_contact
            res['line_phone'] = partner.res_contact_phone
            res['line_address'] = partner.street
        return {'value': res}


ycc_partner_line()


class ycc_product(osv.Model):
    _inherit = 'product.template'
    _columns = {
        'pro_kaibikou': fields.selection([(u'开口', u'开口'), (u'闭口', u'闭口'), (u'双开', u'双开')], '开闭口',
                                         copy=True),
        'pro_material': fields.selection([('N', 'N'), ('M', 'M'), ('D', 'D'), ('C', 'C')], '产品材质',
                                         copy=True),
        'pro_size': fields.selection(
            [(u'3号', u'3号'), (u'4号', u'4号'), (u'5号', u'5号'), (u'7号', u'7号'), (u'8号', u'8号'), (u'10号', u'10号'),
             (u'30号', u'30号')], '产品型号', copy=True),
        'pro_item_active': fields.boolean(u'是否是虚拟物品', select=2),
        'pro_slider_active': fields.boolean(u'是否为拉头物品'),
        'pro_slider': fields.many2one('product.template', u'关联的拉头物品', domain=[('pro_slider_active', '=', True)]),
        'pro_color_key': fields.many2one('ycc.color', u'色带颜色', domain=[('color_active', '=', True)]),
        'pro_lianya_color': fields.many2one('ycc.color', u'链牙颜色', domain=[('color_active', '=', True)]),
        'pro_length': fields.float(u'产品长度'),
        'virtual_item_key': fields.many2one('product.template', u'关联的虚拟物品', domain=[('pro_item_active', '=', True)]),
        'date_ends': fields.datetime(u'有效日期'),
        'sedai_oks': fields.boolean(u'是否和颜色关联'),
        'pro_select_color': fields.selection(
            [(u'色胚', u'色带'), (u'布胶', u'布胶'), (u'上止', u'上止'), (u'下止', u'下止'), (u'方块插销', u'方块插销'), (u'链牙', u'链牙')],
            '关联颜色',
            required=True, copy=True, ),
        'length_ok': fields.boolean(u'是否和长度关联'),
        'pro_vacancy': fields.float(u'空位长度', required=True),
        'pro_typeid': fields.selection([(u'BT(本头)', u'BT(本头)'), (u'LP(拉片)', u'LP(拉片)'), (u'LJJ(连接件)', u'LJJ(连接件)'),
                                        (u'TZDT(涂装拉头)', u'TZDT(涂装拉头)'), ],
                                       '分类码', copy=True),
        'tem_type_id': fields.many2many('product.tem.line', 'product_line', id1='type_id', id2='tem_type_id',
                                        string='拉片适用型号'),
    }
    _defaults = {
        'pro_item_active': True,
    }

    def onchange_pro_material(self, cr, uid, ids, pro_material, context=None):
        res = {}
        global str1
        str1 = ''
        if pro_material:
            str1 = pro_material
            res['name'] = str1
            res['pro_size'] = ''
            res['pro_kaibikou'] = ''
        return {'value': res}

    def onchange_pro_size(self, cr, uid, ids, pro_size, pro_typeid, context=None):
        res = {}
        global str2
        str2 = ''
        if pro_size:
            str2 = str1 + pro_size
            res['name'] = str2
            res['pro_kaibikou'] = ''
        if pro_size and pro_typeid:
            str2 = str1 + pro_size + pro_typeid
            res['name'] = str2
            res['pro_kaibikou'] = ''
        return {'value': res}

    def onchange_pro_kaibikou(self, cr, uid, ids, pro_kaibikou, context=None):
        res = {}
        global str3
        str3 = ''
        if pro_kaibikou:
            str3 = str2 + pro_kaibikou
            res['name'] = str3
        return {'value': res}


ycc_product()


class product_tem_line(osv.Model):
    _description = 'Partner Tags'
    _name = 'product.tem.line'
    _columns = {
        'name': fields.selection(
            [(u'3号', u'3号'), (u'4号', u'4号'), (u'5号', u'5号'), (u'7号', u'7号'), (u'8号', u'8号'), (u'10号', u'10号'),
             (u'30号', u'30号')], '型号大小', copy=True),
        'active': fields.boolean('Active',
                                 help="The active field allows you to hide the category without removing it."),
    }

    _defaults = {
        'active': 1,
    }


product_tem_line()
# vim:expandtab:smartin dent:tabstop=4:softtabstop=4:shiftwidth=4: