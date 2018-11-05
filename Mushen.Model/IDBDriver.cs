using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Mushen.Fuwen
{
    public interface IDBDriver
    {
        eDataType DBType { get; }

        string Left { get; }

        string Right { get; }

        string ConnStr { get; }

        string GetDBName { get; }

        string GetDBSource();

        IDbConnection Connection { get; }

        void Open();

        void BeginTransaction();
        void Rollback();
        void Commit();

        void Close();

        int GetNewKeyWithInsert(string tablename, string keyColName, string[] colNames, object[] colValues);

        int GetNewKeyWithInsert(string tablename, string keyColName, string[] colNames, object[] colValues, string filter);

        int GetNewKeyWithInsert(string tablename, string keyColName, string[] colNames, object[] colValues, string filter, string updateCmdTxt, out bool isNew);

        int ExecuteNonQuery(string cmdText);

        int ExecuteNonQuery(string cmdText, string paramName, object paramValue);

        int ExecuteNonQuery(string cmdText, string paramName, object paramValue, int timeout);

        int ExecuteNonQuery(string cmdText, string[] paramNames, object[] paramValues);

        int ExecuteNonQuery(string cmdText, string[] paramNames, object[] paramValues, int timeout);

        IDataReader ExecuteReader(string cmdText);

        IDataReader ExecuteReader(string cmdText, string paramName, object paramValue);
        IDataReader ExecuteReader(string cmdText, string[] paramNames, object[] paramValues);

        object ExecuteScalar(string cmdText);

        object ExecuteScalar(string cmdText, string paramName, object paramValue);
        object ExecuteScalar(string cmdText, string[] paramNames, object[] paramValues);

        DataTable Fill(string cmdText);

        DataTable Fill(string cmdText, string paramName, object paramValue);

        DataTable Fill(string cmdText, string[] paramNames, object[] paramValues);

        System.Data.DataTable Fill(string cmdText, int start, int count);
        System.Data.DataTable Fill(string cmdText, int start, int count, string paramName, object paramValue);
        System.Data.DataTable Fill(string cmdText, int start, int count, string[] paramNames, object[] paramValues);

        void FillTable(DataTable dt, string cmdText, string paramName, object paramValue);
        void FillTable(DataTable dt, string cmdText, string[] paramNames, object[] paramValues);

        string MyConvertSQL(object source);

        void BulkCopy(DataTable dtSource, string desTablename);
        void BulkCopy(System.Data.DataTable dtSource, string desTablename, Dictionary<string, string> dicMap);
        void BulkCopy(System.Data.OleDb.OleDbDataReader reader, string desTablename, Dictionary<string, string> dicMap);

        void BatchUpdate(List<string> sqlList);
        void BulkCopyPartCols(System.Data.DataTable dtSource, string desTablename, string[] cols);
        void BulkCopyFromCSV(string csvFilename, string destTablename);
        void BulkCopy(IDataReader reader, string desTablename);
    }
}
