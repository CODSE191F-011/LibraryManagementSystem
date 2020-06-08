using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Views
{
    public partial class Supp : Form
    {
        public Supp()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from supplier";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            SupplierGridView1.DataSource = dt;
        }

        private int Sup_ID;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO supplier( S_ID,S_Name, S_Address, Email, Telno) VALUES( @id, @Name, @Location, @mail, @tel)";
                cmd.Parameters.AddWithValue("@id", txtsupId.Text);
                cmd.Parameters.AddWithValue("@Name", txtsupName.Text);
                cmd.Parameters.AddWithValue("@Location", txtsupLoc.Text);
                cmd.Parameters.AddWithValue("@mail", txtsupMail.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data is Successfully Inserted");
                ResetFormData();
            }
        }

        private bool IsValid()
        {
            if (txtsupName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Supplier Name is required", "Required Field Error");
                return false;
            }

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Sup_ID != 0)
            {

                MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE supplier set S_Name=@Name, S_Address=@Location, Email=@mail, Telno=@tel WHERE S_ID=@Id";
                cmd.Parameters.AddWithValue("@Name", txtsupName.Text);
                cmd.Parameters.AddWithValue("@Location", txtsupLoc.Text);
                cmd.Parameters.AddWithValue("@mail", txtsupMail.Text);
                cmd.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd.Parameters.AddWithValue("@Id", this.Sup_ID);
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data is Successfully Updated", "Success");

                LoadDataIntoDataGridView();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please select a supplier record to update", "Select Supplier");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Sup_ID != 0)
            {

                MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM supplier WHERE S_ID=@Id";
                cmd.Parameters.AddWithValue("@Id", this.Sup_ID);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Data is Successfully Deleted", "Success");

                LoadDataIntoDataGridView();
                ResetFormData();

            }
            else
            {
                MessageBox.Show("Please select a supplier to delete", "Select Supplier");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }
        private void ResetFormData()
        {
            this.Sup_ID = 0;
            txtsupId.Clear();
            txtsupName.Clear();
            txtsupLoc.Clear();
            txtsupMail.Clear();
            txtTel.Clear();

            txtsupName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != string.Empty)
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();

                if (rbn2.Checked)
                {
                    cmd.CommandText = "Select * from supplier where S_Address=@Location";
                    cmd.Parameters.AddWithValue("@Location", txtSearch.Text);
                }
                else
                {
                    cmd.CommandText = "Select * from supplier where S_Name=@Name";
                    cmd.Parameters.AddWithValue("@Name", txtSearch.Text);
                }


                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                SupplierGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter any value to search", "Search value required");
            }
        }

        private void SupplierCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            Sup_ID = Convert.ToInt32(SupplierGridView1.SelectedRows[0].Cells[0].Value);
            txtsupName.Text = SupplierGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsupLoc.Text = SupplierGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtsupMail.Text = SupplierGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtTel.Text = SupplierGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
