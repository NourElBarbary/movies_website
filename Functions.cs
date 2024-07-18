using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SWE_Project
{
    class Functions
    {
     
        string ordb = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";
        OracleConnection conn;
        public bool signIn(string email, string password)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from imdb_User where mail=:email and user_password=:password";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("Email", email);
            cmd.Parameters.Add("Password", password);
            OracleDataReader dr = cmd.ExecuteReader();
         
            if (dr.Read())
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
            

        }
        public  bool ValidatePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {

                return false;
            }

            string s = phoneNumber.Substring(0, 3);
            if (s != "010" || s != "011" || s != "012" || s != "015")
            {
                return false;
            }

            return true;

        }
        public  bool ValidateEmail(string email)
        {
            int cnt = 0;
            // Check if the email contains only one @ symbol
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    cnt++;
                }
            }
            if (cnt != 1)
            {
                return false;
            }

            // Split the email into username and domain parts
            string[] parts = email.Split('@');

            if (parts.Length != 2)
            {
                return false;
            }

            // Check if the domain part contains a dot and has at least one character before and after the dot
            string part2 = parts[1];
            if (part2.IndexOf(".") == -1 || part2.IndexOf(".") == 0 || part2.IndexOf(".") == part2.Length - 1)
            {
                return false;
            }

            return true;
        }
        public bool validpassword(string password)
        {

            if (password.Length != 8 || password.Contains(" "))
            {
                return false;
            }
            else
            { return true; }
        }
        public bool checking_email(string email)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select mail from imdb_user where mail=:email   ";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("email", email);
            OracleDataReader r = cmd.ExecuteReader();


            if (r.Read())
            {
               
                r.Close();

                return false;
            }
            else
            {
 
                r.Close();

                return true;
            }

        }
        public bool checking_name(string name)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select user_name from imdb_user where user_name=:name ";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("name", name);
            OracleDataReader r = cmd.ExecuteReader();


            if (r.Read())
            { 
                r.Close();

                return false;
            }
            else
            {
                r.Close();

                return true;
            }

        }
        public bool loginadmin(string name, string password)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from imdb_admin where admin_username=:name and admin_password=:pass  ";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("name", name);
            cmd.Parameters.Add("pass", password);
            OracleDataReader r = cmd.ExecuteReader();


            if (r.Read())
            {
                r.Close();
                
                return true;
            }
            else
            {
                r.Close();
                
                return false;
            }

        }
        public bool InsertUser(string email, string username, string passwordTextbox)
        {
            
            
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into imdb_user values(:name,:mail,:pass) ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("name",username);
                cmd.Parameters.Add("mail", email);
                cmd.Parameters.Add("pass", passwordTextbox);
                int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                return true;
            }
            else
            {
                return false;
            }

            }

        public int avg_rate(string id)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "avg_rate";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("rate", OracleDbType.Int32, System.Data.ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int r;
            try
            {
                r = Convert.ToInt32(cmd.Parameters["rate"].Value.ToString());
            }
            catch
            {
                r = 0;
            }
            return r;

        }

        public void InsertActor(string name, DateTime bd, string gender)
        {
            

            conn = new OracleConnection(ordb);
            conn.Open();

            int maxId = 0;
            OracleCommand maxIdCommand = new OracleCommand("SELECT MAX(actor_id) FROM actor", conn);
            //OracleDataReader reader = maxIdCommand.ExecuteReader();
            maxId = Convert.ToInt32( maxIdCommand.ExecuteScalar());
            //if (reader.Read() && !reader.IsDBNull(0))
            //{
            //    maxId = reader.GetInt32(0);
            //}
            //reader.Close();

            int newId = maxId + 1;

            OracleCommand insertCommand = new OracleCommand();
            insertCommand.Connection = conn;
            insertCommand.CommandText = "INSERT INTO actor VALUES(:id, :name, :bd, :gender)";
            insertCommand.Parameters.Add("id", newId);
            insertCommand.Parameters.Add("name", name);
            insertCommand.Parameters.Add("bd", bd);
            insertCommand.Parameters.Add("gender", gender);

            insertCommand.ExecuteNonQuery();

            conn.Close();
        }
        public void insert_to_watchlist(string filmname, string username)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select film_id from film where title=:filmname";

            cmd.Parameters.Add("film_id", filmname);

            int id = Convert.ToInt32(cmd.ExecuteScalar());
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "insert into watchlist values(:username,:film_id)";
            cmd2.Parameters.Add("username", username);
            cmd2.Parameters.Add("film_id", id);
            int r = cmd2.ExecuteNonQuery();
             

        }

        public void InsertFilmAndActorIds(string filmname, string actorname)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            OracleCommand insertcmd = new OracleCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;
            insertcmd.Connection = conn;


            cmd.CommandText = "select film_id from Film where title=:filmname";
            cmd.Parameters.Add("filmname", filmname);

            
            int filmId = Convert.ToInt32(cmd.ExecuteScalar());


            cmd2.CommandText = "select actor_id from Actor where actor_name = :actorname";
            
            cmd2.Parameters.Add("actorname", actorname);


            int actorId = Convert.ToInt32(cmd2.ExecuteScalar());


            insertcmd.CommandText = "insert into imdb_filmactors values (:actorId,:filmid )";
            insertcmd.Parameters.Add("actorid", actorId);
            insertcmd.Parameters.Add("filmid", filmId);
            insertcmd.ExecuteNonQuery();
            insertcmd.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();

        }







    }




    }

