# -*- coding: utf-8 -*-
##############################################################################
# OpenERP Connector
# Copyright 2013 Amos <sale@100china.cn>
##############################################################################

{
    'name': '量身单',# 模块名称
    'summary': '海彦',#摘要
    'version': '1.0',#版本
    'category': 'Tools',#分类
    'sequence': 1,#排序
    'author': '祝盼',#作者
    'website': 'http://www.rapodoo.com',  #网址
    # 'images' : ['images/amos.jpeg',],#模块图片
    'depends': ['base', 'product', 'sale', 'mail'],  #关联模块
    'data': [
        'main_view.xml',
        'shirt_order_view.xml',
        'vest_order_view.xml',
        'haiyan_report.xml',
        'report_tailored.xml',
    ],  #更新XML,CSV
    'installable': True,  #是否可安装
    'application': True,  #是否认证
    'auto_install': False,  #是否自动安装
    'description': """
实例模块
====================================
海彦男仕礼服


其它说明
""",
}

# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4:
