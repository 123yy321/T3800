using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3800.T3800.SqlService
{
    class SQLConnect
    {
        public SQLConnect _Connect;
        public SQLiteConnection _ConnectionDB;
        public SQLConnect()
        {
            this.SetSQLiteConnection("");
        }

        public SQLConnect GetSQLConnectInstance()
        {
            if (_Connect == null)
            {
                _Connect = new SQLConnect();
            }
            return this._Connect;
        }

        public void SetSQLiteConnection(string connectString)
        {
            if (!string.IsNullOrWhiteSpace(connectString))
            {
                _ConnectionDB = new SQLiteConnection(connectString);
                _ConnectionDB.Open();
            }
            else
            {
                _ConnectionDB = null;
            }
        }
    }
}
