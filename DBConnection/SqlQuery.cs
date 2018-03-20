using System;
using System.Data;
using System.Data.SqlClient;

using System.Collections.Generic;

using ServiceTypes;

namespace DBConnection
{
    public class SqlQuery
    {
        //private static string connectionString = "server=dbsrv2;packet size=4096;integrated security=SSPI;database=abonents;persist security info=false";
        private static string connectionString = string.Empty;// "Data Source=db2;Initial Catalog=Safeguard;Integrated Security=True";

        /// <summary>
        /// Set connection string to SQL server
        /// </summary>
        public static string ConnectionString
        {
            set { connectionString = value; }
        }

        public static string GenerateConnectionString(string serverName, string databaseName, bool integratedSecurity, string login = null, string password = null)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder["Data Source"] = serverName;
            sqlConnectionStringBuilder["Initial Catalog"] = databaseName;
            sqlConnectionStringBuilder["integrated Security"] = integratedSecurity;

            //sqlConnectionStringBuilder["Connect Timeout"] = 1000;
            //sqlConnectionStringBuilder["Trusted_Connection"] = true;

            sqlConnectionStringBuilder["User ID"] = login;
            sqlConnectionStringBuilder["Password"] = password;

            return sqlConnectionStringBuilder.ConnectionString;
        }

        /// <summary>
        /// Tryed connect to database using connection string
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns>True - if connection string valid</returns>
        public static bool TestConnectionString(string connectionString)
        {
            bool isValid = false;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    isValid = true;
                }
            }
            catch (SqlException exception)
            {
                ExceptionHandler.Handler.ProcessSqlException(null, exception);
            }

            return isValid;
        }
        
        /// <summary>
        /// Run special query. Returns a count of rows updated
        /// </summary>
        /// <param name="queryString">Special string query</param>
        /// <param name="connectionString">Connection string to SQL server</param>
        public static int RunSimpleQuery(string queryString, string connectionString = null)
        {
            int result = -1;

            using (SqlConnection connection = new SqlConnection(connectionString ?? SqlQuery.connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                result = command.ExecuteNonQuery();
            }

            return result;
        }
        
        /// <summary>
        /// Run special query with returns DataTable
        /// </summary>
        /// <param name="queryString">Special string query</param>
        /// <param name="connectionString">Connection string to SQL server</param>
        /// <returns></returns>
        public static DataTable RunTableQuery(string queryString, string connectionString = null)
        {
            DataTable dataTable = new DataTable();
            RunTableQuery(dataTable, queryString, connectionString ?? SqlQuery.connectionString);
            return dataTable;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable">Filling dataTable</param>
        /// <param name="queryString">Spetioal string query</param>
        /// <param name="connectionString">Connection string to SQL server</param>
        public static int RunTableQuery(DataTable dataTable, string queryString, string connectionString = null)
        {
            int result = -1;

            using (SqlCommand command = new SqlCommand(queryString, new SqlConnection(connectionString ?? SqlQuery.connectionString)))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                result = adapter.Fill(dataTable);
            }

            return result;
        }

        //public static DataSet RunTableQuery(DataSet ds, string tableName, )
        
        
        /// <summary>
        /// Безопасное чтение из базы данных с закрытием указаного окна в случае ошибки
        /// </summary>
        /// <param name="form"></param>
        /// <param name="sqlQuery"></param>
        /// <returns>DataTable or null</returns>
        public static DataTable ReadData(System.Windows.Forms.Form form, string sqlQuery)
        {
            DataTable dataTable = null;

            if (form == null || form.DialogResult != System.Windows.Forms.DialogResult.Abort)
            {
                try
                {
                    dataTable = DBConnection.SqlQuery.RunTableQuery(sqlQuery);
                }
                catch (SqlException exception)
                {
                    ExceptionHandler.Handler.ProcessSqlException(form, exception);

                    //аварийное закрытие окна
                    if (form != null)
                    {
                        form.DialogResult = System.Windows.Forms.DialogResult.Abort;
                        form.Close();
                    }
                }
            }

            return dataTable;
        }

        /// <summary>
        /// Безопасное чтение из базы данных с закрытием указаного окна в случае ошибки
        /// </summary>
        /// <param name="form"></param>
        /// <param name="sqlQuery"></param>
        /// <returns>DataTable or null</returns>
        public static void ReadData(System.Windows.Forms.Form form, DataTable dataTable, string sqlQuery)
        {
            if (form == null || form.DialogResult != System.Windows.Forms.DialogResult.Abort)
            {
                try
                {
                    DBConnection.SqlQuery.RunTableQuery(dataTable, sqlQuery);
                }
                catch (SqlException exception)
                {
                    ExceptionHandler.Handler.ProcessSqlException(form, exception);

                    //аварийное закрытие окна
                    if (form != null)
                    {
                        form.DialogResult = System.Windows.Forms.DialogResult.Abort;
                        form.Close();
                    }
                }
            }
        }

        #region Методы преобразования для базы данных
        /// <summary>
        /// возвращает тип команды строкой
        /// </summary>
        /// <param name="actionType"></param>
        /// <returns></returns>
        public static string ActionTypeToDbString(ActionType actionType)
        {
            string actionTypeString = "null";

            if (actionType == ActionType.Add)
            {
                actionTypeString = "'insert'";
            }
            else if (actionType == ActionType.Edit)
            {
                actionTypeString = "'update'";
            }
            else if (actionType == ActionType.Archive)
            {
                actionTypeString = "'delete'";//или update
            }
            else if (actionType == ActionType.Remove)
            {
                actionTypeString = "'delete'";
            }
            else
            {
                actionTypeString = "'none'";
            }

            return actionTypeString;
        }

        /// <summary>
        /// возвращает строку в одинарных кавычках или строку "null", если строка пустая или null
        /// </summary>
        /// <param name="str">исходная строка или null</param>
        /// <returns></returns>
        public static string StrToDbString(string str)
        {
            string dbString = "null";

            if (str != null)
            {
                if (str.Length > 0)
                {
                    dbString = "N'" + str.Replace("'", "''") + "'";
                }
            }

            return dbString;
        }

        /*
        /// <summary>
        /// Возвращает число типа int в виде строки или строку "null", если ссылка на объект типа int
        /// </summary>
        /// <param name="objectInt"></param>
        /// <returns></returns>
        public static string ObjectIntToDbString(object objectInt)//Не используется
        {
            string dbString = "null";

            if (objectInt != null)
            {
                dbString = "'" + ((int)objectInt).ToString() + "'";
            }

            return dbString;
        }
        */
        /// <summary>
        /// Возвращает ID или строку "null", если ID меньше 1 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string IdToDbId(int id)
        {
            string dbString = "null";

            if (id > 0)
            {
                dbString = id.ToString();
            }

            return dbString;
        }
        /*
        /// <summary>
        /// Возвращает значение Int разобрав строку
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int StringToInt(string stringInt)
        {
            int result = 0;

            if (stringInt != null && stringInt.Trim().Length > 0)
            {
                result = int.Parse(stringInt);
            }

            return result;
        }

        /// <summary>
        /// Возвращает значение Decimal разобрав строку
        /// </summary>
        /// <param name="stringDecimal"></param>
        /// <returns></returns>
        public static decimal StringToDecimal(string stringDecimal)
        {
            decimal result = 0;

            if (stringDecimal != null && stringDecimal.Trim().Length > 0)
            {
                //result = decimal.Parse(str.Replace(".", ","));
                result = decimal.Parse(stringDecimal, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));//работает с '.' ,а с расский работает с ','
            }

            return result;
        }
        */
        /// <summary>
        /// Возвращает число типа int/decimal в виде строки или строку "null", если ссылка на объект типа int нулевая
        /// </summary>
        /// <param name="objectData"></param>
        /// <returns></returns>
        public static string ConvertToDbString(object objectData)
        {
            string dbString = "null";

            if (objectData != null)
            {
                if(objectData is decimal)
                {
                    dbString = ((decimal)objectData).ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));// "'" + ((decimal)objectDecimal).ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-US")) + "'";//результат должен быть через точку
                }
                else if (objectData is int)
                {
                    dbString = ((int)objectData).ToString();// "'" + ((int)objectDecimal).ToString() + "'";
                }
                else if (objectData is string)
                {
                    if (((string)objectData).Length > 0)
                    {
                        dbString = "'" + ((string)objectData).Replace("'", "''") + "'";
                    }
                }
            }

            return dbString;
        }

        /// <summary>
        /// Возвращает object{decimal} или null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static object GetObjectDecimalFromDbType<T>(T data)
        {
            object obj = null;

            if(data != null)
            {
                if (data is float)
                {
                    obj = (decimal)(data as float?);
                }
                else if (data is decimal)
                {
                    obj = (data as decimal?);
                }
            }

            return obj;
        }
        #endregion

        public static void Test()
        {
            //sqlConnection.ConnectionString = connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            DataTable dataTableKey = new DataTable();
            DataTable dataTable = new DataTable();
            
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT USER_NAME()", sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand("_Test", sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTableKey);
                }
                
                using (SqlCommand command = new SqlCommand(string.Format("sp_setapprole {0}, {1}"
                        , dataTableKey.Rows[0]["app_role_name"].ToString()
                        , dataTableKey.Rows[0]["app_role_password"].ToString()), sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                /*
                dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand(string.Format("sp_setapprole {0}, {1}"
                        , dataTableKey.Rows[0]["app_role_name"].ToString()
                        , dataTableKey.Rows[0]["app_role_password"].ToString()), sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                */
                dataTable = new DataTable();
                using (SqlCommand command = new SqlCommand("SELECT USER_NAME()", sqlConnection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException exception)
            {
                ExceptionHandler.Handler.ProcessSqlException(null, exception);
            }
            sqlConnection.Close();
        }
    }
}
