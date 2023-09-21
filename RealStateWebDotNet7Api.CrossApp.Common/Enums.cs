using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateWebDotNet7Api.CrossApp.Common
{
    public enum ActionsEnum
    {
        [Description("Insert")]
        Insert,
        [Description("Update")]
        Update,
        [Description("Delete")]
        Delete,
        [Description("Get")]
        Get,
        
    }

    public enum LogTypes
    {
        [Description("Error")]
        Error,
        [Description("Warning")]
        Warning,
        [Description("Info")]
        Info,
      
    }

    public static class EnumExtensionMethods
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
        }
    }

}
