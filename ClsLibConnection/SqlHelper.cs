using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ClsLibConnection
{
    public sealed class SqlHelper
    {
        public static DataSet ExecuteDataSet(String ConnectionString, SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                DataSet ds = new DataSet();

                con.Open();

                cmd.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static int ExecuteNonQuery(String ConnectionString, SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                cmd.Connection = con;

                int output = cmd.ExecuteNonQuery();

                return output;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public static DataSet AccessExecuteDataSet(String ConnectionString, OleDbCommand cmd)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);

            try
            {
                DataSet ds = new DataSet();

                con.Open();

                cmd.Connection = con;

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(ds);

                return ds;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static int AccessExecuteNonQuery(String ConnectionString, OleDbCommand cmd)
        {
            OleDbConnection con = new OleDbConnection(ConnectionString);

            try
            {
                con.Open();

                cmd.Connection = con;

                int output = cmd.ExecuteNonQuery();

                return output;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public static DataTable ExecuteDataReader(String ConnectionString, SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                cmd.Connection = con;

                dt.Load(cmd.ExecuteReader());

                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static object ExecuteScalar(String ConnectionString, SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            try
            {
                con.Open();

                cmd.Connection = con;

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
