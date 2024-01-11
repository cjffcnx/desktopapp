using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtactform.econtactClasses
{
    internal class contactClass
    {
        //Getter and setter Properties
        // Acts as a data carrier in app
        public int Crn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public string Deposit { get; set; }

        public string Withdraw { get; set; }

        // Creating a database connection
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        // Creating a method to select data from the database
        public DataTable Select()
        {
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_contactform";
                // Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) { }
            finally {
                conn.Close();
            }
            return dt;
        }
        // Inserting data into database
        public bool Insert(contactClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect to the database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                // Step2: Create a SQL Query to insert the data
                string sql = "INSERT INTO tbl_contactform (FirstName,LastName, ContactNo, Address,Gender,Deposit, Withdraw) VALUES(@FirstName,@LastName, @ContactNo, @Address,@Gender,@Deposit, @Withdraw)";
            // Creating SQL command using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
                // Create parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Deposit",c.Deposit );
                cmd.Parameters.AddWithValue("@Withdraw", c.Withdraw);

                // Now opening the connection
                conn.Open ();
                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then the values of rows present will be greater than zero else value will be less
                if(rows > 0)
                {
                isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }


            }
            catch (Exception ex)
            {

            }
            finally { 
                conn.Close(); 
            }
            return isSuccess;
        }
        // Method to update data into the application
        public bool Update(contactClass c)
        {
            // Create a default return type and set value to false
        bool isSuccess = false;
            // Creating a SQL Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                // SQL to update data in our database
                string sql = "UPDATE tbl_contactform SET FirstName=@FirstName,LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender, Deposit=@Deposit, Withdraw=@Withdraw WHERE Crn=@Crn ";
           // Creating SQL command to insert data into this query
            SqlCommand cmd=new SqlCommand(sql, conn);

                // Create parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Deposit", c.Deposit);
                cmd.Parameters.AddWithValue("@Withdraw", c.Withdraw);
                cmd.Parameters.AddWithValue("@Crn", c.Crn);
// Opening the database connection
conn.Open ();
                int rows = cmd.ExecuteNonQuery();
                // If the query runs successfully the value of the rows will be greater than zero else less than zero
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
// Method to delete data from the database
public bool Delete(contactClass c)
        {
// Create a default return value and set its value to false
bool isSuccess = false;
// Create an SQL Connection
SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                // SQL To delete data
                string sql = "DELETE from tbl_contactform WHERE Crn=@Crn";

                // Create SQL COmmand to pass contact id
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Crn", c.Crn);

                // Open Connection
                conn.Open ();

                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully the values of the rows will be greater than zero else less than zero
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception ex)
            {

            }
            finally {
                conn.Close(); 
            }

            return isSuccess;
        }

    }

    }

