using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudreveMiddleLayer.Data
{
    public class DataHelper : IDisposable
    {
        string DB_Connection_String = "Data Source={0};Version=3;";
        SQLiteConnection conn = null;
        SQLiteCommand cmd = null;
        SQLiteDataAdapter da = null;
        SQLiteTransaction tr = null;
        List<SQLiteParameter> parameterCollection = null;

        #region Constructor

        public DataHelper(string dbPath)
        {
            DB_Connection_String = string.Format(DB_Connection_String, dbPath);
        }

        public DataHelper()
        {
            DB_Connection_String = string.Format(DB_Connection_String, Util.DataBaseFullPath);
        }

        public SQLiteConnection Connection
        {
            get { return conn; }
        }

        public void Dispose()
        {
            if (conn != null)
            {
                conn.Dispose();
            }
            conn = null;
            //provider = null;
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (da != null)
            {
                da.Dispose();
                da = null;
            }
            if (tr != null)
            {
                tr.Dispose();
                tr = null;
            }
            parameterCollection = null;
            //providerName = null;
        }

        #endregion

        #region Build DB Object

        private bool BuildConnection()
        {
            if ((conn != null) && (conn.ConnectionString.Trim() != ""))
            {
                return true;
            }
            conn = new SQLiteConnection(DB_Connection_String);
            System.Console.WriteLine(conn.DataSource);
            return true;
        }

        private bool BuildCommand()
        {
            if ((conn == null) || (conn.ConnectionString.Trim() == ""))
            {
                if (!BuildConnection())
                {
                    throw new Exception("Build Connection failed.");
                }
            }
            if (OpenConnection())
            {
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (tr != null)
                {
                    cmd.Transaction = tr;
                }
                if (parameterCollection != null)
                {
                    for (int i = 0; i < parameterCollection.Count; i++)
                    {
                        cmd.Parameters.Add(parameterCollection[i]);
                    }
                }
                return true;
            }
            else
            {
                throw new Exception("Can not open connection.");
            }
        }

        private bool BuildCommand(string sql)
        {
            if ((conn == null) || (conn.ConnectionString.Trim() == ""))
            {
                if (!BuildConnection())
                {
                    throw new Exception("Build Connection failed.");
                }
            }
            if (OpenConnection())
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                if (tr != null)
                {
                    cmd.Transaction = tr;
                }
                if (parameterCollection != null)
                {
                    cmd.Parameters.Clear();
                    for (int i = 0; i < parameterCollection.Count; i++)
                    {
                        cmd.Parameters.Add(parameterCollection[i]);
                    }
                }
                return true;
            }
            else
            {
                throw new Exception("Can not open connection.");
            }
        }

        /// <summary>
        /// It ONLY could been called after Command has been built.
        /// </summary>
        /// <returns></returns>
        private bool BuildDataAdapter()
        {
            //if (provider == null)
            //{
            //    if (!BuildProviderFactory())
            //    {
            //        throw new Exception("Build Provider failed.");
            //    }
            //}
            //da = provider.CreateDataAdapter();
            da = new SQLiteDataAdapter();
            da.SelectCommand = cmd;
            if (conn.State != ConnectionState.Open)
            {
                if (!OpenConnection())
                {
                    throw new Exception("Can not open connection.");
                }
            }
            return true;
        }

        #endregion

        #region Connection Object

        private bool OpenConnection()
        {
            if ((conn == null) || (conn.ConnectionString.Trim() == ""))
            {
                if (!BuildConnection())
                {
                    throw new Exception("Build Connection failed.");
                }
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return true;
        }

        private bool CloseConnection()
        {
            if (tr == null)
            {
                if ((conn == null) || (conn.ConnectionString.Trim() == ""))
                {
                    return true;
                }
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return true;
        }

        #endregion

        #region Parameter Object

        /// <summary>
        /// Add Parameter to Command object
        /// </summary>
        /// <returns></returns>
        public bool AddParameter(string parameterName, object parameterValue, ParameterDirection pd = ParameterDirection.Input)
        {
            //if (provider == null)
            //{
            //    if (!BuildProviderFactory())
            //    {
            //        throw new Exception("Build Provider failed.");
            //    }
            //}
            if (parameterCollection == null)
            {
                parameterCollection = new List<SQLiteParameter>();
            }
            SQLiteParameter dpName = new SQLiteParameter();
            dpName.ParameterName = parameterName;
            dpName.Value = parameterValue;
            dpName.Direction = pd;
            parameterCollection.Add(dpName);

            return true;
        }

        public bool AddParameter(string parameterName, DbType type, object parameterValue)
        {
            //if (provider == null)
            //{
            //    if (!BuildProviderFactory())
            //    {
            //        throw new Exception("Build Provider failed.");
            //    }
            //}
            if (parameterCollection == null)
            {
                parameterCollection = new List<SQLiteParameter>();
            }
            SQLiteParameter dpName = new SQLiteParameter();
            dpName.ParameterName = parameterName;
            dpName.Value = parameterValue;
            dpName.DbType = type;
            parameterCollection.Add(dpName);

            return true;
        }

        public bool RemoveParameter(string parameterName)
        {
            if (cmd == null)
            {
                throw new Exception("Command Object is null.");
            }

            if (parameterCollection == null)
            {
                parameterCollection = new List<SQLiteParameter>();
            }

            for (int i = 0; i < parameterCollection.Count; i++)
            {
                if (parameterCollection[i].ParameterName == parameterName)
                {
                    parameterCollection.RemoveAt(i);
                    break;
                }
            }
            return true;
        }

        public void ClearParameter()
        {
            if (parameterCollection != null)
            {
                parameterCollection.Clear();
            }
            if (cmd != null)
            {
                cmd.Parameters.Clear();
            }
        }

        #endregion

        #region Get Data

        /// <summary>
        /// Please call AddParameter function first before calling this function if you used parameter in your sql.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ds"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool GetData(string sql, System.Data.DataSet ds, string tableName)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    for (int i = 0; i < parameterCollection.Count; i++)
                    {
                        cmd.Parameters.Add(parameterCollection[i]);
                    }

                    if (BuildDataAdapter())
                    {
                        if (ds.Tables.Contains(tableName))
                        {
                            ds.Tables.Remove(tableName);
                        }
                        da.Fill(ds, tableName);
                        return ds.Tables[tableName].Rows.Count > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        /// <summary>
        /// Please call AddParameter function first before calling this function if you used parameter in your sql.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public System.Data.DataSet GetData(string sql, string tableName)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    if (BuildDataAdapter())
                    {
                        System.Data.DataSet ds = new System.Data.DataSet();
                        if (ds.Tables.Contains(tableName))
                        {
                            ds.Tables.Remove(tableName);
                        }
                        da.Fill(ds, tableName);
                        return ds;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        /// <summary>
        /// Please call AddParameter function first before calling this function if you used parameter in your sql.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool GetData(string sql, DataTable dt)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    if (BuildDataAdapter())
                    {
                        da.Fill(dt);
                        return dt.Rows.Count > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        public bool GetDataFromStoredProcedure(string storedProcedureName, System.Data.DataSet ds)
        {
            try
            {
                if (BuildCommand(storedProcedureName))
                {
                    this.cmd.CommandType = CommandType.StoredProcedure;
                    if (BuildDataAdapter())
                    {
                        da.Fill(ds);
                        return ds.Tables.Count > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        public bool ExistRecord(string sql)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    if (BuildDataAdapter())
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            return rdr.Read();
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        public int ExecuteScalar(string sql)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        #endregion

        #region Execute SQL

        /// <summary>
        /// Please call AddParameter function first before calling this function if you used parameter in your sql.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public bool ExecuteSQL(string sql)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    int effectRowCount = cmd.ExecuteNonQuery();
                    return effectRowCount > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        public bool ExecuteSQL(string sql, string returnParameterName, ref int sqlReturnValue)
        {
            try
            {
                if (BuildCommand(sql))
                {
                    int effectRowCount = cmd.ExecuteNonQuery();
                    if (effectRowCount > 0)
                    {
                        sqlReturnValue = (Int32)cmd.Parameters[returnParameterName].Value;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
                ClearParameter();
            }
        }

        #endregion

        #region Transaction

        public void BeginTransaction()
        {
            if (OpenConnection())
            {
                tr = conn.BeginTransaction();
            }
        }

        public void RollBack()
        {
            if (tr != null)
            {
                tr.Rollback();
                tr.Dispose();
                tr = null;
            }
            CloseConnection();
        }

        public void Commit()
        {
            if (tr != null)
            {
                tr.Commit();
                tr.Dispose();
                tr = null;
            }
            CloseConnection();
        }

        #endregion


        public static object SqlNull(object obj)
        {
            if (obj == null)
            {
                return DBNull.Value;
            }
            if (obj.GetType() == Type.GetType("System.String"))
            {
                if ((obj == null) || (obj.ToString() == ""))
                    return DBNull.Value;
            }
            if (obj.GetType() == Type.GetType("System.Int32"))
            {
                if ((obj == null) || ((int)obj <= -1))
                    return DBNull.Value;
            }
            if (obj.GetType() == Type.GetType("System.Single"))
            {
                if ((obj == null) || ((float)obj <= -1))
                    return DBNull.Value;
            }
            if (obj.GetType() == Type.GetType("System.Double"))
            {
                if ((obj == null) || ((double)obj <= -1))
                    return DBNull.Value;
            }
            if (obj.GetType() == Type.GetType("System.DateTime"))
            {
                if ((obj == null) || ((DateTime)obj == DateTime.MinValue))
                    return DBNull.Value;
            }
            if (obj.GetType() == Type.GetType("System.Drawing.Image"))
            {
                if (obj == null)
                {
                    return DBNull.Value;
                }
            }
            if (obj.GetType() == Type.GetType("System.Byte[]"))
            {
                if (obj == null)
                {
                    return DBNull.Value;
                }
            }
            return obj;
        }
    }
}
