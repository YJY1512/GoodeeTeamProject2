using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Team2_Project_DTO;
using System.Diagnostics;

namespace Team2_Project_DAO
{
    public class OrderDAO : IDisposable
    {
        string connStr = null;
        SqlConnection conn;

        public OrderDAO()
        {
            connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetOrderList(string[] list)
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SP_PrdReq_Read", conn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@fromDate", list[0]);
                    da.SelectCommand.Parameters.AddWithValue("@toDate", list[1]);
                    da.SelectCommand.Parameters.AddWithValue("@category", list[4]);

                    if (string.IsNullOrWhiteSpace(list[2]))
                        da.SelectCommand.Parameters.AddWithValue("@Item_Code", DBNull.Value);
                    else
                        da.SelectCommand.Parameters.AddWithValue("@Item_Code", list[2]);

                    if (string.IsNullOrWhiteSpace(list[3]))
                        da.SelectCommand.Parameters.AddWithValue("@Prj_No", DBNull.Value);
                    else
                        da.SelectCommand.Parameters.AddWithValue("@Prj_No", list[3]);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }

        public bool Insert(OrderDTO data, string Ins_Emp)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_PrdReq_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_Code", data.Item_Code);
                    cmd.Parameters.AddWithValue("@Req_Qty", data.Req_Qty);
                    cmd.Parameters.AddWithValue("@Prj_No", data.Prj_No);
                    cmd.Parameters.AddWithValue("@Req_Date", data.Req_Date);
                    cmd.Parameters.AddWithValue("@Delivery_Date", data.Delivery_Date);
                    cmd.Parameters.AddWithValue("@Remark", data.Remark);
                    cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);

                    int a = cmd.ExecuteNonQuery(); 

                    if (a < 1)
                        return false;
                }

                return true;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public string Update(OrderDTO data, string Ins_Emp)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_PrdReq_Update";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_Code", data.Item_Code);
                    cmd.Parameters.AddWithValue("@Req_Qty", data.Req_Qty);
                    cmd.Parameters.AddWithValue("@Prj_No", data.Prj_No);
                    cmd.Parameters.AddWithValue("@Delivery_Date", data.Delivery_Date);
                    cmd.Parameters.AddWithValue("@Remark", data.Remark);
                    cmd.Parameters.AddWithValue("@Up_Emp", Ins_Emp);
                    cmd.Parameters.AddWithValue("@Prd_Req_No", data.Prd_Req_No);

                    SqlParameter PO_CD = new SqlParameter("@PO_CD", SqlDbType.Int);
                    PO_CD.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(PO_CD);

                    cmd.ExecuteNonQuery();

                    if (Convert.ToInt32(PO_CD.Value) == 1)
                        return "이미 생성된 생산계획 또는 생산지시가 있어 생산요청을 수정할 수 없습니다.";
                }

                return "";
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return "생산요청 수정 중 오류가 발생했습니다. 다시 시도해 주세요.";
            }
        }

        public string Delete(string ordId, string Ins_Emp)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_PrdReq_Delete";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Prd_Req_No", ordId);
                    cmd.Parameters.AddWithValue("@Up_Emp", Ins_Emp);

                    SqlParameter PO_CD = new SqlParameter("@PO_CD", SqlDbType.Int);
                    PO_CD.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(PO_CD);

                    cmd.ExecuteNonQuery();

                    if (Convert.ToInt32(PO_CD.Value) == 1)
                        return "이미 생성된 생산계획 또는 생산지시가 있어 생산요청을 삭제할 수 없습니다.";
                }

                return "";
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return "생산요청 삭제 중 오류가 발생했습니다. 다시 시도해 주세요.";
            }
        }
    }
}
