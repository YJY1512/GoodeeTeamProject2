﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Team2_Project_DTO;

namespace Team2_Project_DAO
{
    public class AnalysisDAO : IDisposable
    {
        SqlConnection conn;
        public AnalysisDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        
        public List<TimeProductionHistoryDTO> GetWorkOrder(string from, string to) //날짜기준으로 시간대별실적 (작업조회기준) 데이터 가져오기
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SP_TimeProductionHistory";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrdDateFrom", from);
                    cmd.Parameters.AddWithValue("@PrdDateTo", to);

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<TimeProductionHistoryDTO> list = Helper.DataReaderMapToList<TimeProductionHistoryDTO>(reader);
                    reader.Close();
                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<TimeProductionHistoryDTO> GetTimeProductionHistory(string WorkOrderNo) //시간대별 데이터
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SP_TIMETEST"; /////SP_테스트용아닌걸로 수정
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@WorkOrderNo", WorkOrderNo);
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<TimeProductionHistoryDTO> list = Helper.DataReaderMapToList<TimeProductionHistoryDTO>(reader);
                    reader.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<CodeDTO> GetWoStatus() //작업지시상태
        {
            try
            {
                string sql = @"SELECT Sys_Ma_Code Category, Sys_Mi_Code Code, Sys_Mi_Name Name
                                 FROM Sys_Mi_Master
                                WHERE Sys_Ma_Code = 'WO_STATUS'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                List<CodeDTO> list = Helper.DataReaderMapToList<CodeDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }



    }
}
