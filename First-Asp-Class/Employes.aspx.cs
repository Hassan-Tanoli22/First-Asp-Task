using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Asp_Class
{
    public partial class Employes : System.Web.UI.Page
    {
        DbCon db = new DbCon();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
            }

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            String qry = "insert into employes(name,email,address,phonenumber,designation,employecode) values ('"+Textname.Text+ "', '" + Textemail.Text + "', '" + Textaddress.Text + "', '" + Textphonenumber.Text + "', '" + Textdesignation.Text + "', '" + Textemployecode.Text + "') ";
        if (db.UDI(qry))
            {
                LabelMsg.Text = "record inserted";
            }
        else
            {
                LabelMsg.Text = "record not inserted";
            }
            LoadGridView();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            String qry = "select * from employes where StudentID='"+Textid.Text+"'";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                Textname.Text = dt.Rows[0]["name"].ToString();
                Textemail.Text = dt.Rows[0]["email"].ToString();
                Textaddress.Text = dt.Rows[0]["address"].ToString();
                Textphonenumber.Text = dt.Rows[0]["phonenumber"].ToString();
                Textdesignation.Text = dt.Rows[0]["designation"].ToString();
                Textemployecode.Text = dt.Rows[0]["employecode"].ToString();
            }
            LoadGridView();
        }

        private void LoadGridView ()
        {
            String qry = "Select * from employes";
            DataTable dt = db.Search(qry);
            if (dt != null)
            {
                EmployesGridView.DataSource = dt;
                EmployesGridView.DataBind();
            }
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            Textid.Text = String.Empty;
            Textname.Text = String.Empty;
            Textemail.Text = String.Empty;
            Textaddress.Text = String.Empty;
            Textphonenumber.Text = String.Empty;
            Textdesignation.Text = String.Empty;
            Textemployecode.Text = String.Empty;
        }
    }
}