using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctors_Patients_portal
{
    public partial class admin : Form
    {
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        DataTable dtAdmin = new DataTable();
        DataTable dtDoctorAcc = new DataTable();

        char c;
        public admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }
    
        private void btnAdminRequest_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            c = 'a';
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            dtAdmin.Clear();
            dataGridView1.Refresh();
            string query = "select * from Admin where status = 0";
            da.readDatathroughAdapter(query, dtAdmin);
            dataGridView1.DataSource = dtAdmin;
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            btn.HeaderText = "";
            btn.Name = "yesbtn";
            btn.Text = "Accept";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            da.closeConn();
        }

        private void btnDoctorRequest_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
            c = 'b';
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            dtDoctorAcc.Clear();
            dataGridView1.Refresh();
            string query = "select Id,Name,Address,User_name,Specialist,status from Doctor where status=0";
            da.readDatathroughAdapter(query, dtDoctorAcc);
            dataGridView1.DataSource = dtDoctorAcc;
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            btn.HeaderText = "";
            btn.Name = "yesbtn";
            btn.Text = "Accept";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            da.closeConn();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            c = 'd';
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dt.Clear();
            dataGridView2.Refresh();
            string query = "select Id,Name,Address,User_name,Password,Specialist from Doctor where status=1";
            da.readDatathroughAdapter(query, dt);
            dataGridView2.DataSource = dt;
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            btn.HeaderText = "";
            btn.Name = "yesbtn";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
            da.closeConn();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            c = 'p';
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dt.Clear();
            dataGridView2.Refresh();
            string query = "select * from Patient";
            da.readDatathroughAdapter(query, dt);
            dataGridView2.DataSource = dt;
            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
            btn.HeaderText = "";
            btn.Name = "yesbtn";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
            da.closeConn();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            dataGridView2.Refresh();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(c=='d')
            {
                //MessageBox.Show(dataGridView2.Rows[e.row]);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (c=='d')
                    {
                        int a;
                        string s = dt.Rows[e.RowIndex]["Id"].ToString();
                        bool result = Int32.TryParse(s, out a);
                        string st = "Delete from Doctor where Id="+a+";";
                        da.Execute(st);

                        dataGridView2.DataSource = null;
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                        dt.Clear();
                        string query = "select * from Doctor";
                        da.readDatathroughAdapter(query, dt);
                        dataGridView2.DataSource = dt;
                        DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                        btn.HeaderText = "";
                        btn.Name = "yesbtn";
                        btn.Text = "Delete";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView2.Columns.Add(btn);
                        da.closeConn();
                    }
                    else if(c=='p')
                    {
                        int a;
                        string s = dt.Rows[e.RowIndex]["Id"].ToString();
                        bool result = Int32.TryParse(s, out a);
                        string st = "Delete from Patient where Id=" + a + ";";
                        da.Execute(st);
                        dataGridView2.DataSource = null;
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                        dt.Clear();
                        string query = "select * from Patient";
                        da.readDatathroughAdapter(query, dt);
                        dataGridView2.DataSource = dt;
                        DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                        btn.HeaderText = "";
                        btn.Name = "yesbtn";
                        btn.Text = "Delete";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView2.Columns.Add(btn);
                        da.closeConn();
                    }
                }
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                DialogResult dialogResult = MessageBox.Show("Do you want to Accept this Request?", "New Request", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (c == 'a')
                    {
                        
                        int a;
                        string s = dtAdmin.Rows[e.RowIndex]["Id"].ToString();
                        bool result = Int32.TryParse(s, out a);
                        string st = "UPDATE Admin SET status= 1 Where id ='" + a + "'";
                        da.Execute(st);

                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        dtAdmin.Clear();
                        dataGridView1.Refresh();
                        string query = "select * from Admin where status = 0";
                        da.readDatathroughAdapter(query, dtAdmin);
                        dataGridView1.DataSource = dtAdmin;
                        DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                        btn.HeaderText = "";
                        btn.Name = "yesbtn";
                        btn.Text = "Accept";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(btn);
                        da.closeConn();

                    }
                    else if (c == 'b')
                    {
                        int a;
                        string s = dtDoctorAcc.Rows[e.RowIndex]["Id"].ToString();
                        bool result = Int32.TryParse(s, out a);
                        string st = "UPDATE Doctor SET status= 1 Where id ='" + a + "'";
                        da.Execute(st);
               
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dtDoctorAcc.Clear();
                        dataGridView1.Refresh();
                        string query = "select Id,Name,Address,User_name,Specialist,status from Doctor where status=0";
                        da.readDatathroughAdapter(query, dtDoctorAcc);
                        dataGridView1.DataSource = dtDoctorAcc;
                        DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();
                        btn.HeaderText = "";
                        btn.Name = "yesbtn";
                        btn.Text = "Accept";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(btn);
                        da.closeConn();

                    }
                }

            }
        }
    }
}
