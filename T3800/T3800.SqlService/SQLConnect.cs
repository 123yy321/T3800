using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3800.T3800.SqlService
{
    class SQLConnect
    {
        public SQLConnect connect;
        public SQLConnect()
        {

        }

        public SQLConnect GetSQLConnect()
        {
            if (connect == null)
            {
                connect = new SQLConnect();
            }
            return this.connect;
        }

        
    }
}
