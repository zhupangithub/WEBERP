# -*- coding: utf-8 -*-
##############################################################################
# OpenERP Connector
# Copyright 2013 Amos <sale@100china.cn>
##############################################################################

{
    'name': 'YCC基础资料表',  # 模块名称
    'summary': 'YCC基础资料表',  # 摘要
    'version': '1.0',  # 版本
    'category': 'Tools',  #分类
    'sequence': 1,  #排序
    'author': '祝盼',  #作者
    'website': 'http://www.rapodoo.com',  #网址
    # 'images' : ['images/amos.jpeg',],#模块图片
    'depends': ['mail'],  #关联模块
    'data': [
        'base_xml/color_view.xml',
        'base_xml/brand_view.xml',
        'base_xml/level_view.xml',
        'product_xml/loss_view.xml',
        'product_xml/product_type.xml',
        'slider_model_view.xml',
        'slider_create_view.xml'
    ],  #更新XML,CSV
    'installable': True,  #是否可安装
    'application': True,  #是否认证
    'auto_install': False,  #是否自动安装
    'description': """
实例模块
====================================
YCC的基础资料


其它说明
""",
}

# vim:expandtab:smartindent:tabstop=4:softtabstop=4:shiftwidth=4:
