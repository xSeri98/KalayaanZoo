using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KalayaanZoo
{
    public partial class frmLogin : Form
    {
        public string connectionString;
        public mngLogin userLogin;
        SqlConnection sqlCon;
        SqlConnection sqlCon2;
        SqlConnection sqlCon3;
        public static string userName;
        public static string mngID;
        public frmLogin()
        {
            InitializeComponent();
            userLogin = new mngLogin(); //mngLogin class instance para sa manager login
            connectionString = ConfigurationManager.ConnectionStrings["GagoZoo.Properties.Settings.KalayaanZooConnectionString1"].ConnectionString; // sql coonetion initialize para doon sa database
        }

        //Executes pag click ng button, verifying lang kung nag-e-exist ba yung user sa database then pag meron proceed sa mainUI
        private void loginBtn_Click(object sender, System.EventArgs e)
        {

            if (!string.IsNullOrEmpty(usertxtBox.Text) && !string.IsNullOrEmpty(passtxtBox.Text))
            {

                if (isVerified(passtxtBox.Text))
                {
                    mainUI uI = new mainUI();
                    this.Hide();
                    uI.ShowDialog();
                    this.Dispose();        
                }
                else
                {
                    MessageBox.Show("Wrong password/username", "Error!");
                }
            }
            else
            {
                MessageBox.Show("Don't leave out any empty fields!","Error!");
            }
        }

        //Method sa pag verify 
        public bool isVerified(string pass)
        {

            sqlCon = new SqlConnection(connectionString);
            sqlCon2 = new SqlConnection(connectionString);
            sqlCon3 = new SqlConnection(connectionString);

            userLogin.Username = usertxtBox.Text;
            userLogin.Password = passtxtBox.Text;

            string query = "select password from ManagerAccounts where user_name =" + "'" + userLogin.Username + "'";
            string queryUser = "select user_name from ManagerAccounts where user_name =" + "'" + userLogin.Username + "'";
            string querymngID = "select mng_ID from ManagerAccounts where user_name =" + "'" + userLogin.Username + "'";

            SqlCommand cmd1 = new SqlCommand(query, sqlCon);
            SqlCommand cmd2 = new SqlCommand(queryUser, sqlCon2);
            SqlCommand cmd3 = new SqlCommand(querymngID, sqlCon3);


            sqlCon3.Open();

            using (sqlCon3)
            using (var reader = cmd3.ExecuteReader())
            {

                if (reader.Read())
                {
                    mngID = reader["mng_ID"].ToString();

                }

            }

            sqlCon3.Close();


            sqlCon2.Open();

            using (sqlCon2)
            using (var reader = cmd2.ExecuteReader())
            {

                if (reader.Read())
                {
                    userName = reader["user_name"].ToString();

                }

            }

            sqlCon2.Close();

            string password = string.Empty;

            sqlCon.Open();


            using (sqlCon)
            using (var reader = cmd1.ExecuteReader())
            {

                if (reader.Read())
                {
                    password = reader["password"].ToString();

                }

            }
            sqlCon.Close();



            if (userLogin.Password.Equals(password) && !string.IsNullOrEmpty(passtxtBox.Text))
            {             
                return true;
            }

            else
            {          
                return false;
            }
        }
    }
}