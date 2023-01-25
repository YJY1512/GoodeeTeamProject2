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
            string sql = @"select Prd_Req_No, convert(nvarchar(10), Req_Date, 23) Req_Date, Req_Seq, pr.Item_Code, Item_Name, Req_Qty, pr.Prj_No, Prj_Name, Company_Name, convert(nvarchar(10), Delivery_Date, 23) Delivery_Date, Remark
                            from Production_Req pr inner join Project p on pr.Prj_No = p.Prj_No
                                                    inner join Item_Master i on pr.Item_Code = i.Item_Code
                            where Req_Date between @fromReqDate and @toReqDate
                            and Delivery_Date between @fromDueDate and @toDueDate";

            if (!string.IsNullOrWhiteSpace(list[4]))
            {
                sql += " and pr.Item_Code = @Item_Code";
            }
            if (!string.IsNullOrWhiteSpace(list[4]))
            {
                sql += " and pr.Prj_No = @Prj_No";
            }

            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@fromReqDate", list[0]);
                da.SelectCommand.Parameters.AddWithValue("@toReqDate", list[1]);
                da.SelectCommand.Parameters.AddWithValue("@fromDueDate", list[2]);
                da.SelectCommand.Parameters.AddWithValue("@toDueDate", list[3]);
                if (!string.IsNullOrWhiteSpace(list[4]))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Item_Code", list[4]);
                }
                if (!string.IsNullOrWhiteSpace(list[4]))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Prj_No", list[5]);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Insert(OrderDTO data, string Ins_Emp)
        {
            Ins_Emp = "1000"; //나중에 수정!!!
            
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetReq_Seq", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_Code", data.Item_Code);
                    cmd.Parameters.AddWithValue("@Req_Qty", data.Req_Qty);
                    cmd.Parameters.AddWithValue("@Prj_No", data.Prj_No);
                    cmd.Parameters.AddWithValue("@Delivery_Date", data.Delivery_Date);
                    cmd.Parameters.AddWithValue("@Remark", data.Remark);
                    cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        public bool Update(OrderDTO data, string Ins_Emp)
        {
            Ins_Emp = "1000"; //나중에 수정!!!

            string sql = @"update Production_Req 
                            set Item_Code = @Item_Code, Req_Qty = @Req_Qty, Prj_No = @Prj_No, Delivery_Date = @Delivery_Date, Remark = @Remark, Up_Date = getdate(), Up_Emp = @Ins_Emp
                            where Prd_Req_No = @Prd_Req_No";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Item_Code", data.Item_Code);
                    cmd.Parameters.AddWithValue("@Req_Qty", data.Req_Qty);
                    cmd.Parameters.AddWithValue("@Prj_No", data.Prj_No);
                    cmd.Parameters.AddWithValue("@Delivery_Date", data.Delivery_Date);
                    cmd.Parameters.AddWithValue("@Remark", data.Remark);
                    cmd.Parameters.AddWithValue("@Ins_Emp", Ins_Emp);
                    cmd.Parameters.AddWithValue("@Prd_Req_No", data.Prd_Req_No);

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

        //public bool Delete(string ordID) //미구현
        //{
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.CommandText = "SP_UserDelete";
        //            cmd.Connection = conn;
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@User_ID", empID);
        //            if (cmd.ExecuteNonQuery() < 1)
        //            {
        //                return false;
        //            }
        //        }

        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
