using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OfficePS.Validation
{
    public class DateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                if (Convert.ToDateTime(value) > DateTime.Now)
                    return false;
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
