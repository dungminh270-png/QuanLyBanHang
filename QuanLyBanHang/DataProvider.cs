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
        //public static bool TruyVanXuLiDuLieu(string sql)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(ChuoiKetNoi))
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(sql, connection))
        //            {
        //                int rows = command.ExecuteNonQuery(); // trả về số dòng bị ảnh hưởng
        //                if (rows > 0)
        //                    return true;
        //                else
        //                {
        //                    MessageBox.Show("Không có bản ghi nào bị ảnh hưởng.\nCó thể mã không tồn tại hoặc bị khóa ràng buộc.",
        //                                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //}

    }
}
