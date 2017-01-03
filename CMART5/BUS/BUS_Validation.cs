using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMART5.BUS
{
    class BUS_Validation
    {
        public bool IsNum(TextBox t)
        {
            try
            {
                float tmp = float.Parse(t.Text.ToString());
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool Required(string t)
        {
            string tmp = t;
            if (string.IsNullOrEmpty(tmp) || string.IsNullOrWhiteSpace(tmp))
            {
                return false;
            }
            return true;
        }
        public bool Required(DevExpress.XtraEditors.TextEdit t)
        {
            string tmp = t.Text.ToString();
            if (string.IsNullOrEmpty(tmp) || string.IsNullOrWhiteSpace(tmp))
            {
                return false;
            }
            return true;
        }
        public bool Required(TextBox t)
        {
            string tmp = t.Text.ToString();
            if (string.IsNullOrEmpty(tmp) || string.IsNullOrWhiteSpace(tmp))
            {
                return false;
            }
            return true;
        }

        public bool MaxLength(TextBox t, int maxLength)
        {
            string tmp = t.Text.ToString();
            if (tmp.Length > maxLength)
            {
                return false;
            }
            return true;
        }

        public bool MinLength(TextBox t, int minLength)
        {
            string tmp = t.Text.ToString();
            if (tmp.Length < minLength)
            {
                return false;
            }
            return true;
        }

        public bool Range(TextBox t, int l, int h)
        {
            try
            {
                int a = int.Parse(t.Text.ToString());
                if (a > h) return false;
                if (a < l) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RegExEmail(TextBox t)
        {
            Regex regex = new Regex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            Match match = regex.Match(t.Text.ToString());
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public bool Compare(TextBox t1, TextBox t2)
        {
            string tmp1 = t1.Text.ToString();
            string tmp2 = t2.Text.ToString();
            if (tmp1 != tmp2)
            {
                return false;
            }
            return true;
        }
        public bool Compare(DevExpress.XtraEditors.TextEdit t1, DevExpress.XtraEditors.TextEdit t2)
        {
            string tmp1 = t1.EditValue.ToString();
            string tmp2 = t1.EditValue.ToString();
            if (tmp1 != tmp2)
            {
                return false;
            }
            return true;
        }
        public bool Compare(TextBox t1, string t)
        {
            string tmp1 = t1.Text.ToString();
            if (tmp1 != t)
            {
                return false;
            }
            return true;
        }
        public bool Compare(DevExpress.XtraEditors.TextEdit t1, string t)
        {
            string tmp1 = t1.Text.ToString();
            if (tmp1 != t)
            {
                return false;
            }
            return true;
        }
        public bool Compare(DateTimePicker dt1, DateTimePicker dt2)
        {
            if (dt1.Value > dt2.Value)
            {
                return false;
            }
            return true;
        }
    }
}
