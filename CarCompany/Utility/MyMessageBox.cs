using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
   public static class MyMessageBox
    {
        public static void ShowSuccess()
        {
            MessageBox.Show(" عملیات با موفقیت انجام شد ", " اطلاع ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowValidationError()
        {
            MessageBox.Show(" لطفا اطلاعات باکس های ستاره دار را وارد کنید ", " خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSelectionError()
        {
            MessageBox.Show(" لطفا موردی را از لیست انتخاب کنید ", " خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool ShowConfirm()
        {
            return (MessageBox.Show(" آیا عملیات انجام شود؟ ", " سوال ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
        public static void ShowCustomError(string str)
        {
            MessageBox.Show(str, " خطا ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
