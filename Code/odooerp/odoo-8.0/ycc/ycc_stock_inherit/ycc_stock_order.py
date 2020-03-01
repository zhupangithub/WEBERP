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


class ycc_stock_product(osv.Model):
    _inherit = 'product.template'
    _columns = {
        'end_location_id': fields.many2one('stock.location', u'最终库位',required=True)
    }
    # _defaults = {
    #     'end_location_id': True,
    # }

ycc_stock_product()

# vim:expandtab:smartin dent:tabstop=4:softtabstop=4:shiftwidth=4: