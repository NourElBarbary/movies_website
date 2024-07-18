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
namespace SWE_Project
{

    public partial class admin_control : Form
    {
        string c = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";
        string s = "select * from imdb_user";
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        string videoFilePath;
        byte[] videoData;
        string videoName;
        public admin_control()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            user_pl.BringToFront();
            adapter = new OracleDataAdapter(s, c);
            adapter.SelectCommand.CommandType = CommandType.Text;
            ds = new DataSet();
            adapter.Fill(ds);
            user_grid.DataSource = ds.Tables[0];


            FIlm_Category_cmb.Items.Clear();
            Film_description_txt.Clear();
            Film_director_cmb.Items.Clear();
            Film_duration_txt.Clear();
            Film_lang_cmb.Items.Clear();
            Film_title_txt.Clear();
            Film_photo_pb.Image = null;

            Movies_cmb.Items.Clear();
            Actors_cmb.Items.Clear();

        }



        private void photo_choose_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*. jpeg,*.png) |*.BMP;*.JPG;*.JPEG;*. PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog.FileName);
                Film_photo_pb.Image = img;
                Film_photo_pb.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void movie_grid_show_btn_Click(object sender, EventArgs e)
        {
            movie_pl.BringToFront();
            string c = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(c);
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();

            cmd2.Connection = conn;

            cmd2.CommandText = @"select director_name from directors ";
            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr = cmd2.ExecuteReader();

            while (dr.Read())
            {
                Film_director_cmb.Items.Add(dr[0]);

            }
            dr.Dispose();

            FIlm_Category_cmb.Items.Add("Action");
            FIlm_Category_cmb.Items.Add("Drama");
            FIlm_Category_cmb.Items.Add("Comedy");
            FIlm_Category_cmb.Items.Add("Horror");
            FIlm_Category_cmb.Items.Add("Crime");
            FIlm_Category_cmb.Items.Add("Mystrey");

            Film_lang_cmb.Items.Add("English");
            Film_lang_cmb.Items.Add("Arabic");
            Film_lang_cmb.Items.Add("Spain");
            Film_lang_cmb.Items.Add("Turkey");
            Film_lang_cmb.Items.Add("German");

            Movies_cmb.Items.Clear();
            Actors_cmb.Items.Clear();



        }

        private void save_movie_btn_Click(object sender, EventArgs e)
        {
            string c = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(c);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            OracleCommand cmd3 = new OracleCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;
            cmd3.Connection = conn;
            cmd.CommandText = "select director_id from directors where director_name=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", Film_director_cmb.SelectedItem.ToString());
            int director_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            cmd2.CommandText = "select max(film_id) from film";
            cmd2.CommandType = CommandType.Text;
            int film_id;
            try
            {
                film_id= Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            }
            catch
            {
                film_id = 1;
            }
            ++film_id;

            string query = "Insert Into FILM values (:film_id ,:title ,:releasedate ,:film_category ,:Film_Language, :FILM_DURATION ,:description ,:director_id ,:film_photo,:film_video)";
            cmd3.CommandText = query;
            cmd3.CommandType = CommandType.Text;

            cmd3.Parameters.Add(":film_id", OracleDbType.Int32).Value = film_id;

            cmd3.Parameters.Add(":title ", OracleDbType.Varchar2).Value = Film_title_txt.Text.ToLower();

            cmd3.Parameters.Add(":releasedate ", OracleDbType.Date).Value = Convert.ToDateTime(FIlm_date_dp.Value);

            cmd3.Parameters.Add(":film_category", OracleDbType.Varchar2).Value = FIlm_Category_cmb.SelectedItem;

            cmd3.Parameters.Add(":Film_Language", OracleDbType.Varchar2).Value = Film_lang_cmb.SelectedItem;

            cmd3.Parameters.Add(":FILM_DURATION ", OracleDbType.Int32).Value = Convert.ToInt32(Film_duration_txt.Text);

            cmd3.Parameters.Add(":description ", OracleDbType.Varchar2).Value = Film_description_txt.Text;

            cmd3.Parameters.Add(":director_id ", OracleDbType.Int32).Value = director_id;

            cmd3.Parameters.Add(":film_photo ", OracleDbType.Blob).Value = imageToByteArray(Film_photo_pb.Image);

            cmd3.Parameters.Add(":film_video ", OracleDbType.Blob, videoData.Length).Value = videoData;

            int r = cmd3.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Successful Insertion", "Insert Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unsuccessful Insertion", "Insert Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();




        }
        private byte[] imageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            this.Close();
            FIlm_Category_cmb.Items.Clear();
            Film_description_txt.Clear();
            Film_director_cmb.Items.Clear();
            Film_duration_txt.Clear();
            Film_lang_cmb.Items.Clear();
            Film_title_txt.Clear();
            Film_photo_pb.Image = null;

            Movies_cmb.Items.Clear();
            Actors_cmb.Items.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void save_user_btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void Video_select_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files |*.MP4; *.avi;*.wv;*.mov;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoFilePath = openFileDialog.FileName;
                videoData = File.ReadAllBytes(videoFilePath);
                videoName = Path.GetFileName(videoFilePath);

            }
        }

        private void Actor_Director_btn_Click(object sender, EventArgs e)
        {
            Actor_director_pl.BringToFront();
        }

        private void AddActorsToMovies_btn_Click(object sender, EventArgs e)
        {
            string c = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(c);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();

            cmd.Connection = conn;
            cmd2.Connection = conn;

            cmd.CommandText = "get_movies";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("title", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Movies_cmb.Items.Add(dr[0]);
            }
            dr.Dispose();


            cmd2.CommandText = "get_actors";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("title", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Actors_cmb.Items.Add(dr2[0]);
            }
            dr2.Dispose();





            AddActorsToMovies_pl.BringToFront();
        }

        private void Save_actor_btn_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();

            f.InsertActor(Actor_name_txt.Text.ToString().ToLower(), Actor_bd_dp.Value, actor_gender_cmb.SelectedItem.ToString());
            Actor_name_txt.Clear();

        }

        private void Save_Director_btn_Click(object sender, EventArgs e)
        {
            string ordb = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=hr;Password=hr";

            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            int maxID, newID;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "SELECT max(director_id) FROM Directors";
            maxID = Convert.ToInt32(c.ExecuteScalar());
            newID = maxID + 1;
            c.CommandText = "INSERT INTO Directors (director_id, director_name, bd) VALUES (:id, :name, :bd)";
            c.Parameters.Add("id", newID);
            c.Parameters.Add("name", Director_name_txt.Text);
            c.Parameters.Add("bd", Director_bd_pd.Value);
            c.ExecuteNonQuery();

        }

        private void Save_actor_movie_btn_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            f.InsertFilmAndActorIds(Movies_cmb.Text.ToString(), Actors_cmb.Text.ToString());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            search_pl.BringToFront();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string sc = "select title , releasedate from film f,actor a ,imdb_filmactors fc where f.film_id=fc.film_id and a.actor_id=fc.actor_id and lower(a.actor_name)=:actor";
            OracleDataAdapter adapter2;
            DataSet ds2;
           
            adapter2 = new OracleDataAdapter(sc, c);
            adapter2.SelectCommand.Parameters.Add("actor", actor_search_txt.Text.ToLower());
            adapter2.SelectCommand.CommandType = CommandType.Text;
            ds2 = new DataSet();
            adapter2.Fill(ds2);
            actor_grid.DataSource = ds2.Tables[0];
        }
    }
}

