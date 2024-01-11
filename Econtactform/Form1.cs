using Econtactform.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Econtactform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       contactClass c=new contactClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the value from the input fields
            c.FirstName=txtboxFirstName.Text;
            c.LastName=txtboxLastName.Text;
            c.ContactNo=txtboxContact.Text;
            c.Address=txtboxAddress.Text;
            c.Gender=cmbGender.Text;
            c.Deposit=txtboxdeposit.Text;
            c.Withdraw=txtboxwithdraw.Text;
            // Inserting the data into the database using the method we created
            bool success = c.Insert(c);

            if(success==true)
            {
                //Successfully inserted
                MessageBox.Show("New Contact successfully inserted");
                // call the method here
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new Contact");
            }
            // Load data on the data grid view
            DataTable dt = c.Select(); 
            dgvContactList.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        // Method to clear all the field
        public void Clear()
        {
            textboxCrn.Text = "";
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContact.Text = "";
            txtboxAddress.Text = "";
            cmbGender.Text = "";
            txtboxdeposit.Text = "";
            txtboxwithdraw.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the data from the text box
            c.Crn = int.Parse(textboxCrn.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContact.Text;
            c.Address = txtboxAddress.Text;
            c.Gender=cmbGender.Text;
            c.Deposit = txtboxdeposit.Text;
            c.Withdraw = txtboxwithdraw.Text;

            // Update data into the database
            bool success = c.Update(c);

            if(success==true)
            {
                // Updated successfully
                MessageBox.Show("Contact has been updated successfully");
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                // Failed to update
                MessageBox.Show("failed to Update contact.Try Again!");
            }
        }

        private void dgvContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the data from Grid  and load it to the text boxes respectively
            // Identify the row on which mouse is clicked
            int rowIndex=e.RowIndex;
            textboxCrn.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContact.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
            txtboxdeposit.Text = dgvContactList.Rows[rowIndex].Cells[6].Value.ToString();
            txtboxwithdraw.Text = dgvContactList.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Call clear method here
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get data from the textbox
            c.Crn=Convert.ToInt32(textboxCrn.Text);
            bool success = c.Delete(c);

            if(success == true )
            {
                // Successfully deleted
                MessageBox.Show("Deleted successfully!");
                // Refresh Data Grid
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("failed to delete. Make sure that you press delete button and then Try Again!");
            }
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings[name:"connstring"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the value from the textbox
            string keyword=txtSearch.Text;
            
            SqlConnection conn= new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contactform WHERE FirstName LIKE '%"+keyword+"%' or LastName LIKE '%"+keyword+"%' or Address LIKE '%"+keyword+"%' ",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }
    }
}
