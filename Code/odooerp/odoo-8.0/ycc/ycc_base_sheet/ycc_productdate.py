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


class ycc_loss(osv.Model):
    _name = "ycc.loss"
    # _log_access = False
    _description = "ycc.loss"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.many2one('product.uom', u'针对损耗单位', required=True),
        'loss_type': fields.selection([(u'成品', u'成品'), (u'半成品', u'半成品'), (u'物料', u'物料')], '损耗类别', required=True,
                                      copy=True, ),
        'loss_min': fields.integer(u'损耗区间起', required=True),
        'loss_max': fields.integer(u'损耗区间止', required=True),
        'loss_number': fields.float(u'损耗率', required=True,digits=(16,4)),
        'loss_active': fields.boolean(u'启用', select=2, copy=True),
        'loss_username': fields.many2one('res.users', u'资料建档人', required=True, copy=True),
    }
    _defaults = {
        'loss_active': True,
        'loss_username': lambda cr, uid, id, c={}: id,
    }


ycc_loss()


class ycc_product_type(osv.Model):
    _name = "ycc.product.type"
    # _log_access = False
    _description = "ycc.product.type"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.char(u'市', size=64, required=True, copy=True),
        'sheng':fields.many2one("res.country.state", u'对应省份',required=True, ondelete='restrict'),
        'pro_type_active': fields.boolean(u'启用', select=2, copy=True),
        'numbers':fields.integer(u'邮编'),
        'pro_type_username': fields.many2one('res.users', u'资料建档人', required=True, copy=True),
    }
    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'该市已存在,不能重复添加!'),
    ]

    _defaults = {
        'pro_type_active': True,
        'pro_type_username': lambda cr, uid, id, c={}: id,
    }


ycc_product_type()

# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4: