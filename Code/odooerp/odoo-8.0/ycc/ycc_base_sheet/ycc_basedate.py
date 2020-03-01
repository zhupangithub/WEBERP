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


class ycc_color(osv.Model):
    _name = "ycc.color"
    # _log_access = False
    _description = "ycc.color"
    _inherit = ['mail.thread']
    _columns = {
        'color_id': fields.char(u'颜色名称', required=True),
        'name': fields.char(u'颜色编号', size=64, required=True, help=u"颜色描述"),
        'color_bool': fields.boolean(u'是否免染色费'),
        'color_active': fields.boolean(u'启用', select=2),
        'color_username': fields.many2one('res.users', u'资料建档人'),
    }

    _defaults = {
        'color_active': True,
        'color_username': lambda cr, uid, id, c={}: id,
    }

ycc_color()


class ycc_brand(osv.Model):
    _name = "ycc.brand"
    # _log_access = False
    _description = "ycc.brand"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.char(u'品牌名称', size=64, required=True),
        'brand_active': fields.boolean(u'启用', select=2),
        'brand_username': fields.many2one('res.users', u'资料建档人', required=True),
    }

    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'该品牌已存在,不能重复添加!'),
    ]

    _defaults = {
        'brand_active': True,
        'brand_username': lambda cr, uid, id, c={}: id,
    }


ycc_brand()



class ycc_level(osv.Model):
    _name = "ycc.level"
    # _log_access = False
    _description = "ycc.level"
    _inherit = ['mail.thread']
    _columns = {
        'name': fields.char(u'等级名称', size=64, required=True),
        'level_active': fields.boolean(u'启用', select=2),
        'level_username': fields.many2one('res.users', u'资料建档人', required=True),
    }
    _sql_constraints = [
        ('name_uniq', 'unique(name)', u'该等级名称已存在,不能重复添加!'),
    ]

    _defaults = {
        'level_active': True,
        'level_username': lambda cr, uid, id, c={}: id,
    }


ycc_level()





# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4: