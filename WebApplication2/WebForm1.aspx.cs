using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(@"data source = amdesk ; initial catalog = StockManag ; integrated security = false; User ID = Stock; Password = St@ck@mdesk0823;");

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus(); //AfficherStock();
        }
        

       /*private void AfficherStock()
        {
            cn.Open();
            string Sql = "select Article, Lot, NPalette, Quantite, Allee, Travee, Niveau from StockInventaire order by SaveDateTime desc";
            SqlCommand cmd = new SqlCommand(Sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
            cn.Close();
        }*/

        private void Reset()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into StockInventaire (CodeAll,Article,Lot,NPalette,Quantite,Allee,Travee,Niveau,SaveDateTime) values (@CodeAll,@Article,@Lot,@NPalette,@Quantite,@Allee,@Travee,@Niveau,@SaveDateTime) ", cn);
            cmd.Parameters.AddWithValue("@CodeAll", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Article", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Lot", TextBox3.Text);
            cmd.Parameters.AddWithValue("@NPalette", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Quantite", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Allee", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Travee", TextBox7.Text);
            cmd.Parameters.AddWithValue("@Niveau", TextBox8.Text);
            cmd.Parameters.AddWithValue("@SaveDateTime", DateTime.Now);
            cmd.ExecuteNonQuery();
            cn.Close();
            //Response.Write("Success");
            Reset();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(TextBox1.Text != "")
            {
                int charLocation = TextBox1.Text.IndexOf('&');
                int txt1prt = TextBox1.Text.Substring(0, charLocation).Length;
                int txt1all = TextBox1.Text.Length;
                int txt1total = txt1all - txt1prt;

                //15
                if (txt1prt == 15 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 15);
                    TextBox3.Text = TextBox1.Text.Substring(16, 6);
                    TextBox4.Text = TextBox1.Text.Substring(23, 5);
                    TextBox5.Text = TextBox1.Text.Substring(29, 2);
                }
                if (txt1prt == 15 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 15);
                    TextBox3.Text = TextBox1.Text.Substring(16, 6);
                    TextBox4.Text = TextBox1.Text.Substring(23, 5);
                    TextBox5.Text = TextBox1.Text.Substring(29, 3);
                }
                if (txt1prt == 15 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 15);
                    TextBox3.Text = TextBox1.Text.Substring(16, 6);
                    TextBox4.Text = TextBox1.Text.Substring(23, 5);
                    TextBox5.Text = TextBox1.Text.Substring(29, 4);
                }

                //16
                if (txt1prt == 16 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 16);
                    TextBox3.Text = TextBox1.Text.Substring(17, 6);
                    TextBox4.Text = TextBox1.Text.Substring(24, 5);
                    TextBox5.Text = TextBox1.Text.Substring(30, 2);
                }
                if (txt1prt == 16 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 16);
                    TextBox3.Text = TextBox1.Text.Substring(17, 6);
                    TextBox4.Text = TextBox1.Text.Substring(24, 5);
                    TextBox5.Text = TextBox1.Text.Substring(30, 3);
                }
                if (txt1prt == 16 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 17);
                    TextBox3.Text = TextBox1.Text.Substring(17, 6);
                    TextBox4.Text = TextBox1.Text.Substring(24, 5);
                    TextBox5.Text = TextBox1.Text.Substring(30, 4);
                }

                //17
                if (txt1prt == 17 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 17);
                    TextBox3.Text = TextBox1.Text.Substring(18, 6);
                    TextBox4.Text = TextBox1.Text.Substring(25, 5);
                    TextBox5.Text = TextBox1.Text.Substring(31, 2);
                }
                if (txt1prt == 17 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 17);
                    TextBox3.Text = TextBox1.Text.Substring(18, 6);
                    TextBox4.Text = TextBox1.Text.Substring(25, 5);
                    TextBox5.Text = TextBox1.Text.Substring(31, 3);
                }
                if (txt1prt == 17 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 17);
                    TextBox3.Text = TextBox1.Text.Substring(18, 6);
                    TextBox4.Text = TextBox1.Text.Substring(25, 5);
                    TextBox5.Text = TextBox1.Text.Substring(31, 4);
                }

                //18
                if (txt1prt == 18 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 18);
                    TextBox3.Text = TextBox1.Text.Substring(19, 6);
                    TextBox4.Text = TextBox1.Text.Substring(26, 5);
                    TextBox5.Text = TextBox1.Text.Substring(32, 2);
                }

                if (txt1prt == 18 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 18);
                    TextBox3.Text = TextBox1.Text.Substring(19, 6);
                    TextBox4.Text = TextBox1.Text.Substring(26, 5);
                    TextBox5.Text = TextBox1.Text.Substring(32, 3);
                }

                if (txt1prt == 18 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 18);
                    TextBox3.Text = TextBox1.Text.Substring(19, 6);
                    TextBox4.Text = TextBox1.Text.Substring(26, 5);
                    TextBox5.Text = TextBox1.Text.Substring(32, 4);
                }

                //19
                if (txt1prt == 19 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 19);
                    TextBox3.Text = TextBox1.Text.Substring(20, 6);
                    TextBox4.Text = TextBox1.Text.Substring(27, 5);
                    TextBox5.Text = TextBox1.Text.Substring(33, 2);
                }

                if (txt1prt == 19 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 19);
                    TextBox3.Text = TextBox1.Text.Substring(20, 6);
                    TextBox4.Text = TextBox1.Text.Substring(27, 5);
                    TextBox5.Text = TextBox1.Text.Substring(33, 3);
                }

                if (txt1prt == 19 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 19);
                    TextBox3.Text = TextBox1.Text.Substring(20, 6);
                    TextBox4.Text = TextBox1.Text.Substring(27, 5);
                    TextBox5.Text = TextBox1.Text.Substring(33, 4);
                }

                //20
                if (txt1prt == 20 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 20);
                    TextBox3.Text = TextBox1.Text.Substring(21, 6);
                    TextBox4.Text = TextBox1.Text.Substring(28, 5);
                    TextBox5.Text = TextBox1.Text.Substring(34, 2);
                }

                if (txt1prt == 20 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 20);
                    TextBox3.Text = TextBox1.Text.Substring(21, 6);
                    TextBox4.Text = TextBox1.Text.Substring(28, 5);
                    TextBox5.Text = TextBox1.Text.Substring(34, 3);
                }

                if (txt1prt == 20 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 20);
                    TextBox3.Text = TextBox1.Text.Substring(21, 6);
                    TextBox4.Text = TextBox1.Text.Substring(28, 5);
                    TextBox5.Text = TextBox1.Text.Substring(34, 4);
                }

                //21
                if (txt1prt == 21 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 21);
                    TextBox3.Text = TextBox1.Text.Substring(22, 6);
                    TextBox4.Text = TextBox1.Text.Substring(29, 5);
                    TextBox5.Text = TextBox1.Text.Substring(35, 2);
                }

                if (txt1prt == 21 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 21);
                    TextBox3.Text = TextBox1.Text.Substring(22, 6);
                    TextBox4.Text = TextBox1.Text.Substring(29, 5);
                    TextBox5.Text = TextBox1.Text.Substring(35, 3);
                }

                if (txt1prt == 21 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 21);
                    TextBox3.Text = TextBox1.Text.Substring(22, 6);
                    TextBox4.Text = TextBox1.Text.Substring(29, 5);
                    TextBox5.Text = TextBox1.Text.Substring(35, 4);
                }

                //22
                if (txt1prt == 22 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 22);
                    TextBox3.Text = TextBox1.Text.Substring(23, 6);
                    TextBox4.Text = TextBox1.Text.Substring(30, 5);
                    TextBox5.Text = TextBox1.Text.Substring(36, 2);
                }

                if (txt1prt == 22 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 22);
                    TextBox3.Text = TextBox1.Text.Substring(23, 6);
                    TextBox4.Text = TextBox1.Text.Substring(30, 5);
                    TextBox5.Text = TextBox1.Text.Substring(36, 3);
                }

                if (txt1prt == 22 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 22);
                    TextBox3.Text = TextBox1.Text.Substring(22, 6);
                    TextBox4.Text = TextBox1.Text.Substring(30, 5);
                    TextBox5.Text = TextBox1.Text.Substring(36, 4);
                }

                //23
                if (txt1prt == 23 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 23);
                    TextBox3.Text = TextBox1.Text.Substring(24, 6);
                    TextBox4.Text = TextBox1.Text.Substring(31, 5);
                    TextBox5.Text = TextBox1.Text.Substring(37, 2);
                }

                if (txt1prt == 23 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 23);
                    TextBox3.Text = TextBox1.Text.Substring(24, 6);
                    TextBox4.Text = TextBox1.Text.Substring(31, 5);
                    TextBox5.Text = TextBox1.Text.Substring(37, 3);
                }

                if (txt1prt == 23 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 23);
                    TextBox3.Text = TextBox1.Text.Substring(24, 6);
                    TextBox4.Text = TextBox1.Text.Substring(31, 5);
                    TextBox5.Text = TextBox1.Text.Substring(37, 4);
                }

                //24
                if (txt1prt == 24 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 24);
                    TextBox3.Text = TextBox1.Text.Substring(25, 6);
                    TextBox4.Text = TextBox1.Text.Substring(32, 5);
                    TextBox5.Text = TextBox1.Text.Substring(38, 2);
                }

                if (txt1prt == 24 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 24);
                    TextBox3.Text = TextBox1.Text.Substring(25, 6);
                    TextBox4.Text = TextBox1.Text.Substring(32, 5);
                    TextBox5.Text = TextBox1.Text.Substring(38, 3);
                }

                if (txt1prt == 24 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 24);
                    TextBox3.Text = TextBox1.Text.Substring(25, 6);
                    TextBox4.Text = TextBox1.Text.Substring(32, 5);
                    TextBox5.Text = TextBox1.Text.Substring(38, 4);
                }

                //25
                if (txt1prt == 25 && txt1total == 16)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 25);
                    TextBox3.Text = TextBox1.Text.Substring(26, 6);
                    TextBox4.Text = TextBox1.Text.Substring(33, 5);
                    TextBox5.Text = TextBox1.Text.Substring(39, 2);
                }

                if (txt1prt == 25 && txt1total == 17)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 25);
                    TextBox3.Text = TextBox1.Text.Substring(26, 6);
                    TextBox4.Text = TextBox1.Text.Substring(33, 5);
                    TextBox5.Text = TextBox1.Text.Substring(39, 3);
                }

                if (txt1prt == 25 && txt1total == 18)
                {
                    TextBox2.Text = TextBox1.Text.Substring(0, 24);
                    TextBox3.Text = TextBox1.Text.Substring(26, 6);
                    TextBox4.Text = TextBox1.Text.Substring(33, 5);
                    TextBox5.Text = TextBox1.Text.Substring(39, 4);
                }

                TextBox6.Focus();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}