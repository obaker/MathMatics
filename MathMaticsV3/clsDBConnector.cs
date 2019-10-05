using System.Data.OleDb;
namespace MathMaticsV3
{
    class clsDBConnector
    {
        OleDbConnection conn = new OleDbConnection();
        //string dbProvider;
        //string dbSource;

        public void Connect()
        {
           // dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
           // dbSource = "Data Source =dbStudentlates.accdb";
           // conn.ConnectionString = dbProvider + dbSource;
            conn.ConnectionString = Properties.Settings.Default.dbMathMaticsConnectionString;
            conn.Open();
        }

        public void close()
        {
            conn.Close();
        }

        public void DoDML(string dmlString)
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand(dmlString, conn);
            cmd.ExecuteNonQuery();
        }

        public OleDbDataReader DoSQL(string sqlString)
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand(sqlString, conn);
            return cmd.ExecuteReader() ;
        }  
    }
}
