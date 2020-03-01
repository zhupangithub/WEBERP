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


class whprocess(osv.Model):
    _name = "wh.process"
    # _log_access = False
    _description = "wh.wh_process"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.char(u'工序名称', size=64, required=True),
        'waifa': fields.boolean(u'外发工序', select=2),
        'process_active': fields.boolean(u'启用', select=2),
        'process_username': fields.many2one('res.users', u'资料建档人', required=True),
    }

    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'该工序已存在,不能重复添加!'),
    ]

    _defaults = {
        'process_active': True,
        'process_username': lambda cr, uid, id, c={}: id,
    }


whprocess()


class hetong(osv.Model):
    _name = "wh.hetong"
    # _log_access = False
    _description = "wh.wh_hetong"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.char(u'合同名称', size=64, required=True),
        'type': fields.property(type='selection', selection=[('1', u'销售订单'), ('2', u'购货'), ('3', u'外发加工')],
                                string="合同类型",
                                copy=True, required=True),
        'hetong_active': fields.boolean(u'启用', select=2),
        'context': fields.text(u'合同条款', required=True),
        'hetong_username': fields.many2one('res.users', u'资料建档人', required=True),
    }

    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'该工序已存在,不能重复添加!'),
    ]

    _defaults = {
        'hetong_active': True,
        'hetong_username': lambda cr, uid, id, c={}: id,
    }


hetong()

# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4:
