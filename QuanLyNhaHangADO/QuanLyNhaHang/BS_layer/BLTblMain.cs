﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.BS_layer
{
     class BLTblMain
    {
        DAL db = null;

        public BLTblMain()
        {
            db = new DAL();
        }


        //fOR Kitchen Lấy các đơn có trạng thái Pending
        // Khi khách hàng đặt món ăn, nhân viên phục vụ thường sẽ ghi lại thông tin đơn hàng và chuyển nó đến bếp để chuẩn bị món ăn.
        // Trạng thái "Pending" được sử dụng để đánh dấu rằng đơn hàng chưa được bếp xác nhận và bắt đầu quá trình chuẩn bị.
        public DataSet GetOrders()
        {
            return db.ExecuteQueryDataSet("Select * from tblMain where status = 'Pending'", CommandType .Text);
        }

        //Trạng thái "Pending" thường xuất hiện khi đang chờ các bước xác nhận, xử lý thanh toán hoặc xử lý cuối cùng của giao dịch.
        public DataSet GetBills()
        {
            return db.ExecuteQueryDataSet("Select MaBill, TableName, WaiterName, aTime, orderType, status,total from tblMain where status <> 'Pending'", CommandType.Text);
        }
        public DataSet GetMain(int MaBill)
        {
            return db.ExecuteQueryDataSet("SELECT * FROM tblMain WHERE MaBill = " + MaBill, CommandType.Text);
        }
       /* public DataSet GetMainBetDate(DateTime sDate, DateTime eDate)
        {
            return //db.ExecuteQueryDataSet("SELECT * FROM tblMain 
        }
*/

        //for billlist
        //public DataSet Get


        public int  AddTblMain(DateTime date, string time,  string TableName, string WaiterName , string Status, string orderType, double Total, double received,double change,string driverID, string cusName, string cusPhone, ref string err)
        {
            //date.ToShortDateString();

            string sqlString = "Insert Into tblMain ( aDate, aTime, TableName, WaiterName, Status, orderType, total, received, change ,driverID, cusName, cusPhone) Values  (" + "'" +
date.ToString("yyyy-MM-dd") + "', '" + time + "', N'" + TableName + "',N'" + WaiterName + "', '" + Status + "', '" + orderType + "', " +
Total + ", " + received + ", " + change + ", N'"+ driverID + "', '" + cusName + "', '" + cusPhone + "' ); " + " SELECT SCOPE_IDENTITY()";
            /*string sqlString = @"Insert into tblMain Values (@aDate,@aTime,@TableName,@WaiterName, @status, @lorderType,@total,@received,@change);
 Select SCOPE_IDENTITY()";*/
            // return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            return db.MyExecuteScalar(sqlString, CommandType.Text);
        }

        public bool UpdateTblMain(int MainID, DateTime date, string time, string TableName, string WaiterName, string Status, string orderType, double Total, double received, double change, ref string err)
        {

            /*string sqlString = "UPDATE SanPham SET TenSP = N'" + TenSP + "', MaLoaiSP = N'" + MaLoaiSP + "', TenLoaiSP = N'"
        + TenLoaiSP + "', GiaSP = " + GiaSP + ", AnhSP = 0x" + imageHex + " WHERE MaSP = '" + MaSP + "'";*/

            string sqlString = "UPDATE tblMain SET aDate = '" + date.ToString("yyyy-MM-dd") + "', aTime = '" + time + "', TableName = N'"
        + TableName + "', WaiterName = N'" + WaiterName + "', Status = '" + Status + "', orderType = '"+ orderType + "', total = "+ Total +" , received = "+ received + " ,  change = " + change + " WHERE MaBill = " + MainID;
                return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
            
            
        }


        //update trang thai thanh Complete ccho form Kitchen
        public bool UpdateStatus(int MaBill,ref string err)
        {
            string sqlString = "UPDATE tblMain set status = 'Complete' Where MaBill = " + MaBill;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool UpdateCheckOut(int MaBill, double total, double received,double change, string status, ref string err)
        {
            string sqlString = "UPDATE tblMain set total = "+ total +", received = " + received+ " , change = "+ change+" , status = '" +status +"' Where MaBill = " + MaBill;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        //Kết nội 2 Table tblDetail va tblMain
        public DataSet GetJoin(int MaBill)
        {
            return db.ExecuteQueryDataSet("Select * from tblMain m inner join tblDetails d on m.MaBill = d.MaBill WHERE m.MaBill = " + MaBill +"", CommandType.Text);
        }

        public DataSet GetJoinKIT(int MaBill)
        {
            // return db.ExecuteQueryDataSet("Select * from tblMain m inner join tblDetails d on m.MaBill = d.MaBill inner join SANPHAM s on s.MaSP = d.proID  WHERE m.MaBill = " + MaBill + "", CommandType.Text);
            // return db.ExecuteQueryDataSet("SELECT *, d.proName AS proNameDetails FROM tblMain m INNER JOIN tblDetails d ON m.MaBill = d.MaBill WHERE m.MaBill = " + MaBill + " ", CommandType.Text);
            return db.ExecuteQueryDataSet("SELECT DISTINCT * FROM tblMain m INNER JOIN tblDetails d ON m.MaBill = d.MaBill WHERE m.MaBill = " + MaBill, CommandType.Text);
            // return db.ExecuteQueryDataSet("SELECT m.MaBill, m.Time, m.Status, m.Type, SUM(d.Qty) AS TotalQty, m.proName FROM tblMain m INNER JOIN tblDetails d ON m.MaBill = d.MaBill WHERE m.MaBill = " + MaBill + " GROUP BY m.MaBill, m.Time, m.Status, m.Type, m.proName", CommandType.Text);
           // return db.ExecuteQueryDataSet("SELECT DISTINCT m.*, d.* FROM tblMain m INNER JOIN tblDetails d ON m.MaBill = d.MaBill WHERE m.MaBill = " + MaBill, CommandType.Text);
        }
        public DataSet GetJoinTABLE(int MaBill)
        {
            return db.ExecuteQueryDataSet("Select * from tblMain m inner join tblDetails d on m.MaBill = d.MaBill  inner join BAN t on m.TableName = t.Tname  WHERE m.MaBill = " + MaBill + "", CommandType.Text);
        }
        public string doanhthu(string ordertype, string month, string year)
        {            
            string startDate;
            string endDate;
            if (month != "2")
            {
                startDate = month + "-01-" + year;
                endDate = month + "-30-" + year;
            }
            else
            {
                startDate = month + "-01-" + year;
                endDate = month + "-28-" + year;
            }
            string query = "SELECT SUM(total) AS TongDoanhThu FROM tblMain WHERE orderType = '" + ordertype + "' AND aDate BETWEEN '" + startDate + "' AND '" + endDate + "'";

            DataSet ds = db.ExecuteQueryDataSet(query, CommandType.Text);
            string dt = "";
            foreach (DataRow row in ds.Tables[0].Rows)  
            {
                dt = row["TongDoanhThu"].ToString();
            }
            if (dt == "")
            {
                dt = "0";
            }
            return dt;
        }

    }
}
