using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Data;

namespace KPSonar
{
    class DBConnect
    {
        private MySqlConnection m_cConnection;
        private string m_strServer;
        private string m_strDatabase;
        private string m_nUID;
        private string m_strPassword;
        private string m_strMysqlDumpExe = "C:\\xampp\\mysql\\bin\\mysqldump.exe";
        private string m_strMysqlExe = "C:\\xampp\\mysql\\bin\\mysql.exe";

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            m_strServer = "localhost";
            //database = "connectcsharptomysql";
            m_strDatabase = "kpsonar";
            m_nUID = "jagdish";
            m_strPassword = "jagdish";
            string connectionString;
            connectionString = "SERVER=" + m_strServer + ";" 
                + "DATABASE=" + m_strDatabase + ";" + "UID=" + m_nUID + ";" 
                + "PASSWORD=" + m_strPassword + ";";

            m_cConnection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                m_cConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                m_cConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool IsConnected()
        {
            bool bReturn = false;

            //open connection
            if (this.OpenConnection() == true)
            {
                //close connection
                this.CloseConnection();
                bReturn = true;
            }
            return bReturn;
        }
        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, m_cConnection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = m_cConnection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, m_cConnection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, m_cConnection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, m_cConnection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar()+"");
                
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup(string pathFolder)
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                //path = "D:\\Code\\Sonar\\Data\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                path = pathFolder + "\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);

                
                ProcessStartInfo psi = new ProcessStartInfo();
                //psi.FileName = "C:\\xampp\\mysql\\bin\\mysqldump.exe";
                psi.FileName = m_strMysqlDumpExe;
                
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", m_nUID, m_strPassword, m_strServer, m_strDatabase);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                string strException;
                strException = "Unable to backup! because of " + ex.Message;
                MessageBox.Show(strException);
            }
        }

        //Restore
        public void Restore(string path)
        {
            try
            {               
                if (String.IsNullOrEmpty(path) == true)
                {
                    return;
                }
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                //psi.FileName = "C:\\xampp\\mysql\\bin\\mysql.exe";
                psi.FileName = m_strMysqlExe;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", m_nUID, m_strPassword, m_strServer, m_strDatabase);
                psi.UseShellExecute = false;

                
                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                string strException;
                strException = "Unable to Restore! because of " + ex.Message;
                MessageBox.Show(strException);
            }
        }

        //Insert statement
        public bool Insert(string strQuery)
        {
            return ExecuteGeneral(strQuery);
        }
        public bool Update(string strQuery)
        {
            return ExecuteGeneral(strQuery);
        }

        public bool Delete(string strQuery)
        {
            return ExecuteGeneral(strQuery);
        }

        public bool ExecuteGeneral(string strQuery)
        {
            bool bReturn = false;
            try
            {
                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(strQuery, m_cConnection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                    bReturn = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            return bReturn;
        }
        public void GridDisplay(DataGridView DataGridView1, string query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //close connection
                this.CloseConnection();

                //string query = " select * from  " + strTableName; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, m_cConnection))
                {
                    try
                    {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataGridView1.DataSource = ds.Tables[0];
                    }                    
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public string GetDataValue(string query, string strColumnName)
        {
            string strDataValue = "";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, m_cConnection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    strDataValue = dataReader.GetString(strColumnName);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            return strDataValue;
        }

        public string GetMysqlDumpExe()
        {
            return m_strMysqlDumpExe;
        }

        public void SetMysqlDumpExe(string strMysqlDumpExe)
        {
            m_strMysqlDumpExe = strMysqlDumpExe;
        }

        public string GetMysqlExe()
        {
            return m_strMysqlExe;
        }
        public void SetMysqlExe(string strMysqlExe)
        {
            m_strMysqlExe = strMysqlExe;
        }

    }
}
