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


class zp_haiyan_order(osv.Model):
    _name = "zp.haiyan"
    # _log_access = False
    _description = "zp.haiyan"
    _inherit = ['mail.thread']
    _columns = {
        'partner_id': fields.many2one('res.partner', u'客户名称', required=True),
        'name': fields.char(u'量身单号', size=64, required=True, help=u"量身单号，用作量身单的标识"),
        'user_id': fields.many2one('res.users', u'量身师', required=True),
        'team_name': fields.many2one('crm.case.section', u'门市点'),
        'state': fields.selection([('draft', u'草稿'),
                                   ('review', u'等待审核'),
                                   ('done', u'已完成'),
                                   ('sent', u'发送邮件'),
                                   ('cancel', u'取消'), ],
                                  u'状态', ),
        'coat_shoulder': fields.char(u'肩宽'),
        'coat_shoulder_two': fields.char(),
        'coat_shoulder_three': fields.char(),
        'coat_sleeves': fields.char(u'袖长'),
        'coat_sleeves_two': fields.char(),
        'coat_sleeves_three': fields.char(),
        'coat_before_long': fields.char(u'前衣长'),
        'coat_before_long_two': fields.char(),
        'coat_before_long_three': fields.char(),
        'coat_after_long': fields.char(u'后衣长'),
        'coat_after_long_two': fields.char(),
        'coat_after_long_three': fields.char(),
        'coat_chest': fields.char(u'胸围'),
        'coat_chest_two': fields.char(),
        'coat_chest_three': fields.char(),
        'coat_waist': fields.char(u'腰围'),
        'coat_waist_two': fields.char(),
        'coat_waist_three': fields.char(),
        'coat_hip': fields.char(u'臀围'),
        'coat_hip_two': fields.char(),
        'coat_hip_three': fields.char(),
        'coat_chest_width': fields.char(u'胸宽'),
        'coat_chest_width_two': fields.char(),
        'coat_chest_width_three': fields.char(),
        'coat_back_width': fields.char(u'背宽'),
        'coat_back_width_two': fields.char(),
        'coat_back_width_three': fields.char(),
        'coat_neck_size': fields.char(u'领围'),
        'coat_neck_shape': fields.property(type='selection',
                                           selection=[('1', u'宽角领'), ('2', u'针孔领'), ('3', u'小方领'), ('4', u'圆角领'),
                                                      ('5', u'翼型领')],
                                           string="领型", copy=True),
        'coat_before_yijing': fields.char(u'前襟'),
        'coat_xiukou': fields.char(u'袖口'),
        'coat_try': fields.char(u'试版款'),
        'coat_number': fields.float(u'上衣试版码数'),
        'coat_customized': fields.char(u'定做款'),
        'coat_count': fields.integer(u'定做件数'),
        'coat_gaodijian': fields.boolean(u'高低肩'),
        'coat_dadu': fields.boolean(u'大肚'),
        'coat_xiajian': fields.boolean(u'斜肩'),
        'coat_pingjian': fields.boolean(u'平肩'),
        'coat_youbei': fields.boolean(u'有背'),
        'coat_tingxiong': fields.boolean(u'挺胸'),
        'coat_beizhu': fields.text(u'备注'),
        # 裤子部门的字段
        'trousers_waist': fields.char(u'腰围'),
        'trousers_waist_two': fields.char(),
        'trousers_waist_three': fields.char(),
        'trousers_hip': fields.char(u'臀围'),
        'trousers_hip_two': fields.char(),
        'trousers_hip_three': fields.char(),
        'trousers_long': fields.char(u'裤长'),
        'trousers_long_two': fields.char(),
        'trousers_long_three': fields.char(),
        'trousers_shangdang': fields.char(u'上档'),
        'trousers_shangdang_two': fields.char(),
        'trousers_shangdang_three': fields.char(),
        'trousers_quandang': fields.char(u'全档'),
        'trousers_quandang_two': fields.char(),
        'trousers_quandang_three': fields.char(),
        'trousers_yaoxia': fields.char(u'腰下'),
        'trousers_yaoxia_two': fields.char(),
        'trousers_yaoxia_three': fields.char(),
        'trousers_tuiwei': fields.char(u'腿围'),
        'trousers_tuiwei_two': fields.char(),
        'trousers_tuiwei_three': fields.char(),
        'trousers_xiwei': fields.char(u'膝围'),
        'trousers_xiwei_two': fields.char(),
        'trousers_xiwei_three': fields.char(),
        'trousers_kukou': fields.char(u'裤口'),
        'trousers_youdu': fields.boolean(u'有肚'),
        'trousers_stui': fields.boolean(u'S腿'),
        'trousers_qiaotui': fields.boolean(u'翘腿'),
        'trousers_pingtun': fields.boolean(u'平臀'),
        'trousers_otui': fields.boolean(u'O腿'),
        'trousers_xtui': fields.boolean(u'X腿'),
        'trousers_dazhe': fields.boolean(u'打折'),
        'trousers_pingkou': fields.boolean(u'平口'),
        'trousers_mashu': fields.float(u'裤子试穿码数'),
        'trousers_kuanshi': fields.char(u'定做款式'),
        'trousers_count': fields.integer(u'定做件数'),
        'trousers_beizhu': fields.text(u'备注'),
        'shirt_color': fields.property(type='selection',
                                       selection=[('1', u'白色'), ('2', u'粉色'), ('3', u'紫色'), ('4', u'浅蓝色'),
                                                  ('5', u'浅蓝色'), ('6', u'橙色'), ('7', u'米黄色')],
                                       string=u"衬衣颜色", copy=True),
        'shirt_beizhu': fields.text(u'备注'),
        'shirt_shoulder': fields.char(u'肩宽'),
        'shirt_shoulder_two': fields.char(),
        'shirt_shoulder_three': fields.char(),
        'shirt_sleeves': fields.char(u'袖长'),
        'shirt_sleeves_two': fields.char(),
        'shirt_sleeves_three': fields.char(),
        'shirt_yichang': fields.char(u'衬衣衣长'),
        'shirt_yichang_two': fields.char(),
        'shirt_yichang_three': fields.char(),
        'shirt_houchang': fields.char(u'衬衣后长'),
        'shirt_houchang_two': fields.char(),
        'shirt_houchang_three': fields.char(),
        'shirt_chest': fields.char(u'胸围'),
        'shirt_chest_two': fields.char(),
        'shirt_chest_three': fields.char(),
        'shirt_waist': fields.char(u'腰围'),
        'shirt_waist_two': fields.char(),
        'shirt_waist_three': fields.char(),
        'shirt_hip': fields.char(u'臀围'),
        'shirt_hip_two': fields.char(),
        'shirt_hip_three': fields.char(),
        'shirt_chest_width': fields.char(u'胸宽'),
        'shirt_chest_width_two': fields.char(),
        'shirt_chest_width_three': fields.char(),
        'shirt_back_width': fields.char(u'背宽'),
        'shirt_back_width_two': fields.char(),
        'shirt_back_width_three': fields.char(),
        'shirt_back_linwei': fields.char(u'衬衣领围'),
        'shirt_neck_shape': fields.property(type='selection',
                                            selection=[('1', u'宽角领'), ('2', u'针孔领'), ('3', u'小方领'), ('4', u'圆角领'),
                                                       ('5', u'翼型领')],
                                            string="衬衣领型", copy=True),
        'shirt_before_yijing': fields.char(u'衬衣前襟'),
        'shirt_xiukou': fields.char(u'衬衣袖口'),
        'shirt_try': fields.char(u'衬衣试穿款'),
        'shirt_number': fields.float(u'衬衣试版码数'),
        'shirt_customized': fields.char(u'衬衣定做款'),
        'shirt_count': fields.integer(u'衬衣定做件数'),
        'shirt_gaodijian': fields.boolean(u'高低肩'),
        'shirt_dadu': fields.boolean(u'大肚'),
        'shirt_xiajian': fields.boolean(u'斜肩'),
        'shirt_pingjian': fields.boolean(u'平肩'),
        'shirt_youbei': fields.boolean(u'有背'),
        'shirt_tingxiong': fields.boolean(u'挺胸'),
        'haiyan_customer_image1': fields.binary("1"),
        'haiyan_customer_image2': fields.binary("2"),
        'haiyan_customer_image3': fields.binary("3"),
        'haiyan_customer_image4': fields.binary("4"),
        'vest_count': fields.integer(u'背心件数'),
        'vest_qianchang': fields.char(u'背心前长'),
        'vest_houchang': fields.char(u'背心后长'),
        'vest_shang': fields.char(u'上'),
        'vest_zhong': fields.char(u'中'),
        'vest_mashu': fields.float(u'试穿码数'),
        'vest_beizhu': fields.text(u'背心备注'),
        'peijian_niukou': fields.property(type='selection',
                                          selection=[('1', u'A纽扣'), ('2', u'B纽扣'), ('3', u'C纽扣'), ('4', u'D纽扣'),
                                                     ('5', u'E纽扣'), ('6', u'F纽扣'), ('7', u'G纽扣')],
                                          string=u"纽扣", copy=True),
        'peijian_xiuzi': fields.property(type='selection', selection=[('true', u'需要'), ('false', u'不需要')],
                                         string=u"秀字", copy=True),
        'peijian_color': fields.property(type='selection',
                                         selection=[('1', u'白色'), ('2', u'粉色'), ('3', u'紫色'), ('4', u'浅蓝色'),
                                                    ('5', u'浅蓝色'), ('6', u'橙色'), ('7', u'米黄色'), ('8', u'黑色'),
                                                    ('9', u'蓝色')],
                                         string=u"衬衣颜色", copy=True),
        'peijian_lingdai': fields.boolean(u'领带'),
        'peijian_lingjie': fields.boolean(u'领结'),
        'peijian_xiukou': fields.boolean(u'袖扣'),
        'peijian_daijing': fields.boolean(u'袋巾'),
        'peijian_yaofeng': fields.boolean(u'腰丰'),
        'peijian_beizhu': fields.text(u'工艺要求'),
    }

    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'量身单名称已存在!'),
    ]


    def onchange_partner_id(self, cr, uid, ids, partner_id, context=None):
        res = {}
        if partner_id:
            partners = self.pool.get('res.partner').browse(cr, uid, partner_id, context=context)
            res['haiyan_customer_image1'] = partners.haiyan_customer_image1
            res['haiyan_customer_image2'] = partners.haiyan_customer_image2
            res['haiyan_customer_image3'] = partners.haiyan_customer_image3
            res['haiyan_customer_image4'] = partners.haiyan_customer_image4
            # resuts =  random.choice('ABCDEFGHIJKLMNOPQRSTUVWXYZ',3)
            res['name'] = ""
            resuts = string.join(random.sample('ABCDEFGHIJKLMNOPQRSTUVWXYZ', 2)).replace(' ', '')
            res['name'] = resuts + "000" + str(partners.id)
        return {'value': res}


    _defaults = {
        # 'datetime': lambda *a: time.strftime('%Y-%m-%d %H:%M:%S'),
        # 'date_start': lambda *a: time.strftime('%Y-%m-%d'),
        'state': lambda *a: 'draft',
        'user_id': lambda cr, uid, id, c={}: id,
        # 'team_name': lambda s, cr, uid, c: s.pool.get('crm.case.section')._company_default_get(cr, uid, 'hr.employee',
        # context=c),
    }


    def haiyan_review(self, cr, uid, ids, context=None):
        state = 'review'
        self.write(cr, uid, ids, {'state': state}, context=context)
        p = self.browse(cr, uid, ids[0])
        if p.partner_id:
            self.message_subscribe(cr, uid, ids, [p.partner_id.id], context=context)
        return True


    def haiyan_cancel(self, cr, uid, ids, context=None):
        state = 'cancel'
        message = '单据已取消'
        self.haiyan_action(cr, uid, ids, state, message, context=context)
        return True


    def haiyan_done(self, cr, uid, ids, context={}):
        state = 'done'
        message = '单据已完成'
        self.haiyan_action(cr, uid, ids, state, message, context=context)
        return True


    def haiyan_draft(self, cr, uid, ids, context={}):
        state = 'draft'
        message = '单据重置为草稿'
        self.haiyan_action(cr, uid, ids, state, message, context=context)
        return True


    # 按钮的触发事件类
    def haiyan_action(self, cr, uid, ids, state, message, context={}):
        self.write(cr, uid, ids, {'state': state}, context=context)

        # 推送消息
        self.message_post(cr, uid, ids, body=_(message), context=context)

        return True


zp_haiyan_order()

# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4: