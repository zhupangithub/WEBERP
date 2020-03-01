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


class wh_orders(osv.Model):
    _inherit = 'sale.order'
    _columns = {
        # 'user_id_salesman': fields.many2one('res.users', u'业务员', required=True),
        'res_customer_date': fields.date(u'客户交货日期', help="客户交货日期不能小于当前日期", required=True),
    }

    _defaults = {
        'user_id_salesman': lambda cr, uid, id, c={}: id,
    }


wh_orders()


class wh_purchase(osv.Model):
    _inherit = 'purchase.order'
    _columns = {
        'kaipiao': fields.many2one('res.partner', u'开票单位', readonly=True,
                                   states={'draft': [('readonly', False)], 'sent': [('readonly', False)]},
                                   required=True, change_default=True, select=True, track_visibility='always'),
        'jh': fields.many2one('res.partner', u'交货单位', readonly=True,
                              states={'draft': [('readonly', False)], 'sent': [('readonly', False)]},
                              required=True, change_default=True, select=True, track_visibility='always'),
        'res_jh_date': fields.date(u'交货日期', help="交货日期不能小于当前日期", required=True),
    }

    def _default_company(self, cr, uid, context=None):
        user = self.pool.get('res.users').browse(cr, uid, uid, context=context)
        return user.company_id.id

    _defaults = {
        'kaipiao': _default_company,
        'jh': _default_company,
    }


wh_purchase()


class wh_partner(osv.Model):
    _inherit = "res.partner"
    _columns = {
        'customer_type': fields.property(type='selection', selection=[('1', u'客户'), ('2', u'供应商'), ('3', u'外发供应商')],
                                         string="合作伙伴类型",
                                         copy=True, required=True),
    }


wh_partner()


# 产品新增字段
class wh_product(osv.Model):
    _inherit = 'product.template'
    _columns = {
        'product_size': fields.char(u'产品尺寸'),
        'product_caizhi': fields.char(u'产品材质'),
    }
    # _defaults = {
    #     'pro_item_active': False,
    # }


wh_product()


# 用户权限设置-工单的访问权限
class wh_user(osv.Model):
    _inherit = 'res.users'
    _columns = {
        'workcenter_ids': fields.many2many('mrp.workcenter', 'res_users_workcenter', 'res_user_id', 'res_center_id',
                                           '关联工作中心'),
    }
    # _defaults = {
    #     'pro_item_active': False,
    # }


wh_user()

# vim:expandtab:smartin dent:tabstop=4:softtabstop=4:shiftwidth=4:
