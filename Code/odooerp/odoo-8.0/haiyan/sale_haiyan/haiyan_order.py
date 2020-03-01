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

try:
    from openerp import SUPERUSER_ID
except ImportError:
    SUPERUSER_ID = SUPERUSER_ID


class haiyan_orders(osv.Model):
    _inherit = 'sale.order'
    _columns = {
        'company': fields.many2one('res.partner', u'摄影公司', readonly=True,
                                   states={'draft': [('readonly', False)], 'sent': [('readonly', False)]},
                                   required=True, change_default=True, select=True, track_visibility='always'),
        'consultant': fields.many2one("res.partner", u'西服顾问 '),
        'designer': fields.many2one("res.partner", u'设计师 '),
        'order_instructions': fields.text(u'订单说明', help=u'订单的特殊要求（例如：加急单）'),
        'date_state': fields.date(u'试版日期'),
        'date_end': fields.date(u'试取日期', help=u'客户取衣服的时间'),
        'order_chuzu_datestate': fields.date(u'出租取件日'),
        'order_chuzu_dateend': fields.date(u'出租还件日'),
        'order_yajin': fields.float(u'押金(或定金)'),
        'order_yukuan': fields.float(u'余款金额'),
        'order_type': fields.property(type='selection',
                                      selection=[('1', u'订做'), ('2', u'出租'), ('3', u'买卖'), ('4', u'包套')],
                                      string="交易类型", copy=True),
    }


haiyan_orders()


class haiyan_order_line(osv.Model):
    _inherit = 'sale.order.line'
    _columns = {
        'haiyan_name': fields.many2one('zp.haiyan', u'量身单号2', states={'draft': [('readonly', False)]}, readonly=True),
    }


haiyan_order_line()


class haiyan_partner(osv.Model):
    _inherit = "res.partner"
    _columns = {
        'haiyan_customer_image1': fields.binary("1"),
        'haiyan_customer_image2': fields.binary("2"),
        'haiyan_customer_image3': fields.binary("3"),
        'haiyan_customer_image4': fields.binary("4"),
        'haiyan_customer_dinhun': fields.date(u'订婚日期'),
        'haiyan_customer_jiehunri': fields.date(u'结婚日期'),
        'haiyan_paizhao_date': fields.date(u'拍照日期'),
        'haiyan_customer_vip': fields.property(type='selection',
                                               selection=[('1', u'新客户'), ('2', u'VIP客户'), ('3', u'超级VIP')],
                                               string="客户级别", copy=True),
        'haiyan_customer_shengri': fields.date(u'生日'),
        'haiyan_customer_zhiye': fields.char(u'职业'),
        'haiyan_customer_income': fields.float(u'年收入'),
        'haiyan_phase': fields.property(type='selection',
                                        selection=[('1', u'量身'), ('2', u'试版'), ('3', u'成品')],
                                        string="量身阶段", copy=True),
        'haiyan_intend': fields.property(type='selection',
                                         selection=[('no', u'不会再来消费'), ('notsure', u'不确定'), ('yes', u'下次还会来'),
                                                    ('sure', u'推荐亲友')],
                                         string="客户意愿", copy=True),
    }

    def _check_dates(self, cr, uid, ids, context=None):
        for phase in self.read(cr, uid, ids, ['haiyan_customer_dinhun', 'haiyan_customer_jiehunri'], context=context):
            if phase['haiyan_customer_dinhun'] and phase['haiyan_customer_jiehunri'] and phase[
                'haiyan_customer_dinhun'] > phase['haiyan_customer_jiehunri']:
                return False
        return True

    _constraints = [
        (_check_dates, u'订婚日期不能大于结婚日期！', ['date_start', 'date_end']  ),
    ]


haiyan_partner()


# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4: