using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class LogUserMsg
    {
        public static string GetTransId(string UserId)
        {
            using (var db=new TestDemoWinFormEntities())
            {
                var transId = db.Proc_GetTransId(UserId).First().ToString();
                return transId;
            }          
        }
    }
}
