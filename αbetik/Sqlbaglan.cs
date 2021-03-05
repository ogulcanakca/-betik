using System;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace αbetik
{
    internal class Sqlbaglan
    {
        private static Sqlbaglan baglanti;
        private static object lockThis = new object();

        private Sqlbaglan()
        {
            
        }
        public static Sqlbaglan NesneVer()
        {

            lock (lockThis)
            {
                if (baglanti == null)
                {
                    baglanti = new Sqlbaglan();
                }
                return baglanti;
            }

        }
        public SqlConnection thisConn { get; set; }
        public SqlCommand thisQuery { get; set; }

        public SqlDataAdapter thisDa { get; set; }
        public OleDbConnection thisOleConn { get; set; }
        public OleDbCommand thisOleQuery { get; set; }
        public OleDbDataReader thisOleDr { get; set; }
        public OleDbDataAdapter thisOleDa { get; set; }
    }
}