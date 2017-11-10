using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.DataTypeAttributes
{
    public class ValidateTaiwanAddressAttribute : DataTypeAttribute
    {
        public ValidateTaiwanAddressAttribute()
            : base(DataType.Text)
        {
            ErrorMessage = "地址列必須出現【台灣】字樣！";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }

            string str = value as String;

            return str.Contains("台灣");
        }

    }
}