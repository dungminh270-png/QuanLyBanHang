using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class DataProvider
    {
        public static string ChuoiKetNoi
        {
            get
            {
                return @"Server=.;Database=QLBanHang;Trusted_Connection=True;";
            }

        }

        public static DataTable TruyVanLayDuLieu (string sql)   
        {
            DataTable dt = new DataTable();
            var connection =new SqlConnection(ChuoiKetNoi);
            var DataAdapter = new SqlDataAdapter(sql, connection);
            DataAdapter.Fill(dt);
            return dt;
        }

        public static DataTable TruyVanLayDuLieu(string sql, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (var connection = new SqlConnection(ChuoiKetNoi))
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public static bool TruyVanXuLiDuLieu(string sql)
        {
            try
            {
                var connection = new SqlConnection(ChuoiKetNoi);
                var command = new SqlCommand(sql, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                //handle error
                return false;
            }
        }
    }
}
