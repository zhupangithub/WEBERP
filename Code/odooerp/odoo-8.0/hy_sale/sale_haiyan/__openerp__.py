# -*- coding: utf-8 -*-
##############################################################################
# OpenERP Connector
# Copyright 2013 Amos <sale@100china.cn>
##############################################################################

{
    'name': '海彦订单管理', #模块名称
    'summary': 'haiyan_inherits', #摘要
    'version': '1.0', #版本
    'category': 'Tools', #分类
    'sequence': 1001, #排序
    'author': '祝盼', #作者
    'website': 'http://www.rapodoo.com', #网址
    # 'images' : ['images/amos.jpeg',],#模块图片
    'depends': ['base', 'sale'], #关联模块
    'data': [
        'haiyan_order_view.xml',
        'haiyan_order_report.xml',
        'report_order.xml',
    ], #更新XML,CSV
    'installable': True, #是否可安装
    'application': True, #是否认证
    'auto_install': False, #是否自动安装
    'description': """
实例模块
====================================


对于多个/实例继承机制:字典映射业务对象所在的名称的名称对应的外键字段名称使用
""",
}

# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4:
