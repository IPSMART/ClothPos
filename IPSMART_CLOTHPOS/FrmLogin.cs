using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPSMART_CLOTHPOS;
namespace IPSMART_CLOTHPOS
{

    public partial class FrmLogin : Form
    {
        DBConnection Cn = new DBConnection();
        string sql = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bindCompany();
        }
        private void bindCompany()
        {
            sql = "select distinct compnm,compcd from sd_company ";
            var dt = Cn.SQLquery(sql);
            cmbCompany.DataSource = dt;
            cmbCompany.ValueMember = "compcd";
            cmbCompany.DisplayMember = "compnm";
        }
        
        private void bindLocation(string compcd)
        {
            sql = "select distinct loccd,locnm from sd_company a  where compcd='" + compcd + "'" + " ";
            var dt = Cn.SQLquery(sql);
            cmbLocation.DataSource = dt;
            cmbLocation.ValueMember = "loccd";
            cmbLocation.DisplayMember = "locnm";

            //var dt = Cn.SQLquery(sql); string loccd = "";
            //if (dt.Rows.Count > 0)
            //{
            //    schemaname = dt.Rows[0]["schema_name"].ToString();
            //}


            //sql = "select distinct schema_name from sd_company a  where compcd='" + compcd + "'"+ " ";
            //var dt = Cn.SQLquery(sql);string schemaname = "";
            //if (dt.Rows.Count > 0)
            //{
            //    schemaname = dt.Rows[0]["schema_name"].ToString();
            //}

            //sql = "select distinct locnm,loccd from"
            //    + "" + schemaname + ".M_loca where compcd='" + compcd + "'";
            //    +" ";
            //var dt = Cn.SQLquery(sql);
            //cmbCompany.DataSource = dt;
            //cmbCompany.ValueMember = "compnm";
            //cmbCompany.DisplayMember = "compcd";
        }
        private void bindFinyr(string compcd, string loccd)
        {
            sql = "select distinct year_code,from_date from sd_company where compcd='" + compcd + "' and loccd='" + loccd + "' ";
            var dt = Cn.SQLquery(sql);
            cmbFinyr.DataSource = dt;
            cmbFinyr.ValueMember = "year_code";
            cmbFinyr.DisplayMember = "from_date";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindLocation(cmbCompany.SelectedValue.ToString());
        }
        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindFinyr(cmbCompany.SelectedValue.ToString(), cmbLocation.SelectedValue.ToString());
        }
    }
}
