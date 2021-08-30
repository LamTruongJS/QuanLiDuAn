using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Helper.Services
{
    public class TextService
    {
        public string GenerateId(string current_id, string prefix)
        {
            string day = DateTime.Now.Day.ToString("00");
            string month = DateTime.Now.Month.ToString("00");
            string year = DateTime.Now.Year.ToString().Substring(2, 2);

            string date = day + month + year;
            string num = "0001";

            if (!String.IsNullOrEmpty(current_id))
            {
                string date_now = current_id.Substring(2, 6);

                if (date.Equals(date_now))
                {
                    num = current_id.Substring(8);
                    int new_num = int.Parse(num);
                    new_num = new_num + 1;
                    num = new_num.ToString("0000");
                }
            }
            return prefix + date + num;
        }
    }
}
