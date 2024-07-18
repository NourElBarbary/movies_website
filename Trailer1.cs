using SWE_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.IO;
using AxWMPLib;
using WMPLib;
namespace SWE_Project
{
    public partial class Trailer1 : Form
    {
        string user_name;
        string film_name;
       
        public Trailer1(string x,string user,string film,string path,string d ,OracleDataReader dr)
        {
            InitializeComponent();
            imdb_rate_lb.Text += " " + x + "/5";
            user_name = user;
            film_name = film;
           
            label1.Text = "Discription : " + d;

            label1.Text += "\n \n Actors :\n";
            while (dr.Read())
            {
                label1.Text += "\t\t " + dr[0] + "\n";
            }

            wmp.URL = path;
            wmp.Ctlcontrols.play();

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            var dsh = new dashboard(user_name);
            dsh.Show();
            this.Hide();
        }

        private void pb_str5_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow;
            pb_str2.Image = Resources.yellow;
            pb_str3.Image = Resources.yellow;
            pb_str4.Image = Resources.yellow;
            pb_str5.Image = Resources.yellow;
            lbl_ratings.Text = "5";


        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow;
            pb_str2.Image = Resources.yellow;
            pb_str3.Image = Resources.yellow;
            pb_str4.Image = Resources.yellow;

            pb_str5.Image = Resources.white;
            lbl_ratings.Text = "4";
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow;
            pb_str2.Image = Resources.yellow;
            pb_str3.Image = Resources.yellow;

            pb_str4.Image = Resources.white;
            pb_str5.Image = Resources.white;
            lbl_ratings.Text = "3";
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow;
            pb_str2.Image = Resources.yellow;

            pb_str3.Image = Resources.white;
            pb_str4.Image = Resources.white;
            pb_str5.Image = Resources.white;
            lbl_ratings.Text = "2";
        }

        private void pb_str1_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow;

            pb_str2.Image = Resources.white;
            pb_str3.Image = Resources.white;
            pb_str4.Image = Resources.white;
            pb_str5.Image = Resources.white;
            lbl_ratings.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(c);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            
            cmd.Connection = conn;
            cmd2.Connection = conn;

            cmd.CommandText = "select film_id from film where title=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":name", film_name);
            int film_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            cmd2.CommandText = "insert into rate values(:film_id,:user_name,:rate)";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("id", film_id);
            cmd2.Parameters.Add("user", user_name);
            cmd2.Parameters.Add("rate", lbl_ratings.Text.ToString());
            int r;
            try
            {
                 r = cmd2.ExecuteNonQuery();
            }
            catch
            {
                r = -1;
            }
            if (r != -1)
            {
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "select avg(rate) from rate where film_id=:id";
                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.Add(":id", film_id);
                double rate;
                try
                {//feh exception ehna hn3dlo
                    rate = Convert.ToDouble(cmd3.ExecuteScalar());
                }
                catch
                {
                    rate = 0;
                }

                string result = string.Format("{0:0.0}", rate);
               

                MessageBox.Show("Rating Saved","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                imdb_rate_lb.Text="IMDb Rate:"+ " " + result + "/5";
                


            }
            else
            {
                MessageBox.Show("You Have Already Rated This Movie","Failed",MessageBoxButtons.OK,MessageBoxIcon.Hand);

            }

        }

        private void AddToWatchlist_btn_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            f.insert_to_watchlist(film_name, user_name);
        }
    }
}
