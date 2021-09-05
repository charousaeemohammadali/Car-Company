using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
   public static class MyExtentionFunction
    {
        public static Int64 ConvertToInt64(this TextBox t)
        {
            return t.Text.Trim() == "" ? 0 : Convert.ToInt64(t.Text.Trim());
        }
        public static Int32 ConvertToInt32(this TextBox t)
        {
            return t.Text.Trim() == "" ? 0 : Convert.ToInt32(t.Text.Trim());
        }
        public static Int16 ConvertToInt16(this TextBox t)
        {
            return t.Text.Trim() == "" ? (Int16)0 : Convert.ToInt16(t.Text.Trim());
        }

        public static int GetValue(this ComboBox Combo)
        {
            return Combo.SelectedIndex==-1 ? -1 : Convert.ToInt32(Combo.SelectedValue);
        }
    }
}
