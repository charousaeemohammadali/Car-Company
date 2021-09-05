
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarCompany.Model;

namespace System
{
   public static class DbCommon
    {
        private static CarCompanyEntities _Context = new CarCompanyEntities();
        public static CarCompanyEntities Context
        {
            get { return _Context; }
        }

        public static void Save()
        {
            _Context.SaveChanges();
        }
    }
}