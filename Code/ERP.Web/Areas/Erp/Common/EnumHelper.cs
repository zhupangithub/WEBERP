using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Web
{
    public static class EnumHelper
    {
        /// <summary>
        /// 获取枚举的key value desc集合
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static List<EnumItem> GetEnumList(Type enumType)
        {
            List<EnumItem> tbList = new List<EnumItem>();
            foreach (int i in Enum.GetValues(enumType))
            {
                EnumItem bdc = new EnumItem();
                bdc.Key = Enum.Parse(enumType, i.ToString()).ToString();
                bdc.Value = i;
                FieldInfo info = Enum.Parse(enumType, i.ToString()).GetType().GetField(bdc.Key);
                DescriptionAttribute[] EnumAttributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (EnumAttributes.Length > 0)
                {
                    bdc.Desc = EnumAttributes[0].Description;
                }
                tbList.Add(bdc);
            }
            return tbList;
        }

        /// <summary>
        /// 扩展方法，获得枚举的Description
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <param name="nameInstend">当枚举没有定义DescriptionAttribute,是否用枚举名代替，默认使用</param>
        /// <returns>枚举的Description</returns>
        public static string GetDescription(this Enum value, bool nameInstend = true)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name == null)
            {
                return null;
            }
            FieldInfo field = type.GetField(name);
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attribute == null && nameInstend == true)
            {
                return name;
            }
            return attribute == null ? null : attribute.Description;
        }
    }
    public class EnumItem
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public string Desc { get; set; }
    }
}
