/*************************************************************************
 * 文件名称 ：TabType.cs                          
 * 描述说明 ：共通编辑页面明细TAB类型
 * 
 * 创建信息 : create by liuhuisheng.xm@gmail.com on 2012-11-10
 * 修订信息 : modify by (person) on (date) for (reason)
 * 
 * 版权信息 : Copyright (c) 2013 厦门纵云信息科技有限公司 www.zoewin.com
**************************************************************************/

using System.ComponentModel;

namespace Zephyr.Core
{
    public enum TabType
    {
        Grid,
        Form,
        UnKnown
    }

    public enum BaseType
    {
        [Description("单位")]
        UnitType = 1,
        [Description("物料")]
        MaterialType = 2,
        [Description("客户等级")]
        CustomerGrade = 3,
        [Description("产品")]
        ProductType = 4,
        [Description("装订法")]
        zhuangding = 5,
        [Description("包装法")]
        baozhuang = 6,
        [Description("部件")]
        parts = 7,
        [Description("工序")]
        process = 8,
    }
}
