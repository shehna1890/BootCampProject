using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ComplaintRegistration.DAL
{
    public class RegDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();



        public RegDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;

        }

        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }
        public object exescalar(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            object ob = cmd.ExecuteScalar();
            return ob;

        }
        public SqlDataReader exereader(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public void fillgrid(String sql, GridView dv)
        {
            dv.DataSource = exedataset(sql);
            dv.DataBind();

        }
        public int exenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public DataSet exedataset(String sql)
        {

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataTable exedatatable(String sql)
        {

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UserRegisterInsert(BAL.RegBAL obj)
        {
            object ob = exescalar("insert into LoginDetails values('" + obj.UserName + "','" + obj.Password + "','User','Not Confirmed');select @@IDENTITY");
            string qry = "Insert into UserRegister values('" + obj.Name + "','" + obj.Email + "','" + obj.PhoneNumber + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();

        }
        public int LoginUser(BAL.LgBAL obj)
        {
            object ob = exescalar("Select * from LoginDetails where Username = '" + obj.UserName + "' and password = '" + obj.Password + "'");
            SqlCommand cmd = new SqlCommand();
            SqlCommand command = new SqlCommand();
            return (int)ob;

        }
   
        public DataTable CheckLogin(BAL.LgBAL obj)
        {
            string qry = "SELECT * From LoginDetails Where Username = '" + obj.UserName + "' AND password = '" + obj.Password + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int ProductDetailsInsert(BAL.LgBAL obj)
        {
            string qry = "Insert into  ProductDetails values('" + obj.ProductName + "'," + obj.ProductPrice + ")";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();

        }
        public DataTable ProductDetailsView(BAL.LgBAL obj)
        {
            string s = "select * from ProductDetails";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewTable (BAL.RegBAL obj)
        {
            string s = "SELECT * from UserRegister";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;

        }
        public int Complaintinsert(BAL.LgBAL obj)
        {
            string qry2 = "insert into ComplaintDetails(User_Id,Product_Id,Complaint_Date,Complaint,Status)values ('" + obj.UserId + "','" + obj.ProductId + "',GETDATE(),'" + obj.ComplaintBox + "','Notyet')";
            SqlCommand cmd = new SqlCommand(qry2, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public void fillddlInsert (string sql, DropDownList ddl, String text, String val, BAL.LgBAL obj)
        {
            ddl.DataTextField = text;
            ddl.DataValueField = val;
            ddl.DataSource = exedataset(sql);
            ddl.DataBind();

            ddl.Items.Insert(0, new ListItem("..select", "0"));

        }
        public DataTable GetProdetails (BAL.LgBAL obj)
        {
            string qry3  = "select * from ProductDetails";
            SqlCommand cmd = new SqlCommand(qry3, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public int Querryinsert (BAL.LgBAL obj)
        {
            string qry2 = "insert into Querry(User_Id,Product_Id,Querry,User_Name)values ('" + obj.UserId + "','" + obj.ProductId + "','" + obj.QuerryBox + "','" + obj.UserName + "')";
            SqlCommand cmd = new SqlCommand(qry2, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable QuerryDetailsView (BAL.LgBAL obj)
        {
            string s = "select * from Querry";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable UpdateQuerryTable (BAL.LgBAL obj)
        {
            string s = "select * from Querry";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;


        }
        public DataTable ViewSpecificQueryDetails(BAL.LgBAL obj)
        {
            string qry = "SELECT l.UserName,p.*,q.* FROM Querry q INNER JOIN LoginDetails ON l.Id=q.User_Id INNER JOIN ProductDetails p on p.Product_Id=q.Product_Id WHERE q.Querry_Id='" + obj.QuerryId + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            return dt;
           
        }
        public int GiveReplyDetails(BAL.LgBAL obj)
        {
            string qry ="UPDATE Querry SET Reply='"+obj.Reply+"' WHERE Querry_Id='"+obj.QuerryId+"'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();

        }
        
        public DataTable complaintview(BAL.LgBAL obj)
        {
            string s = "select * from ComplaintDetails where Status='Notyet' AND Complaint_Date >='" + obj.Fromdate + "' AND Complaint_Date <='" + obj.Todate + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Allcomplaintview(BAL.LgBAL obj)
        {
            string s = "select * from ComplaintDetails";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int complaintApprove(BAL.LgBAL obj)
        {
            string s = "update ComplaintDetails set Status='InProcess' where Complaint_Id='" + obj.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }
        public DataTable complaintinprocess(BAL.LgBAL obj)
        {
            string s = "select * from ComplaintDetails where Status='InProcess' AND Complaint_Date >='" + obj.Fromdate + "' AND Complaint_Date <='" + obj.Todate + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int complaintclose(BAL.LgBAL obj)
        {
            string s = "update ComplaintDetails set Status='Closed' where Complaint_Id='" + obj.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }
        


    }
}
