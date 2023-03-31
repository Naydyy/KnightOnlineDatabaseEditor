using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;



namespace KOPluginDatabaseEditor
{
    public partial class Form2 : Form
    {
        static Thread islem;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=2300PKDB;User ID=sa; Password=");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
        private void Form2_Load(object sender, EventArgs e)
        {

        }
      
        private void button32_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            lb2.Items.Clear();
         
           
            string veriler;
            komut.CommandText = "select * from MAKE_ITEM_GROUP where iItemGroupNum="+textBox31.Text;
            //  MessageBox.Show(veri.ToString());
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
          

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text=dr["iItem_1"].ToString();
                textBox2.Text = dr["iItem_2"].ToString();
                textBox3.Text = dr["iItem_3"].ToString();
                textBox4.Text = dr["iItem_4"].ToString();
                textBox5.Text = dr["iItem_5"].ToString();
                textBox6.Text = dr["iItem_6"].ToString();
                textBox7.Text = dr["iItem_7"].ToString();
                textBox8.Text = dr["iItem_8"].ToString();
                textBox9.Text = dr["iItem_9"].ToString();
                textBox10.Text = dr["iItem_10"].ToString();
                textBox11.Text = dr["iItem_11"].ToString();
                textBox12.Text = dr["iItem_12"].ToString();
                textBox13.Text = dr["iItem_13"].ToString();
                textBox14.Text = dr["iItem_14"].ToString();
                textBox15.Text = dr["iItem_15"].ToString();
                textBox16.Text = dr["iItem_16"].ToString();
                textBox17.Text = dr["iItem_17"].ToString();
                textBox18.Text = dr["iItem_18"].ToString();
                textBox19.Text = dr["iItem_19"].ToString();
                textBox20.Text = dr["iItem_20"].ToString();
                textBox21.Text = dr["iItem_21"].ToString();
                textBox22.Text = dr["iItem_22"].ToString();
                textBox23.Text = dr["iItem_23"].ToString();
                textBox24.Text = dr["iItem_24"].ToString();
                textBox25.Text = dr["iItem_25"].ToString();
                textBox26.Text = dr["iItem_26"].ToString();
                textBox27.Text = dr["iItem_27"].ToString();
                textBox28.Text = dr["iItem_28"].ToString();
                textBox29.Text = dr["iItem_29"].ToString();
                textBox30.Text = dr["iItem_30"].ToString();

                
                lb.Items.Add(textBox1.Text);
                lb.Items.Add(textBox2.Text);
                lb.Items.Add(textBox3.Text);
                lb.Items.Add(textBox4.Text);
                lb.Items.Add(textBox5.Text);
                lb.Items.Add(textBox6.Text);
                lb.Items.Add(textBox7.Text);
                lb.Items.Add(textBox8.Text);
                lb.Items.Add(textBox9.Text);
                lb.Items.Add(textBox10.Text);

             
                lb.Items.Add(textBox11.Text);
                lb.Items.Add(textBox12.Text);
                lb.Items.Add(textBox13.Text);
                lb.Items.Add(textBox14.Text);
                lb.Items.Add(textBox15.Text);
                lb.Items.Add(textBox16.Text);
                lb.Items.Add(textBox17.Text);
                lb.Items.Add(textBox18.Text);
                lb.Items.Add(textBox19.Text);
                lb.Items.Add(textBox20.Text);

                lb.Items.Add(textBox21.Text);
                lb.Items.Add(textBox22.Text);
                lb.Items.Add(textBox23.Text);
                lb.Items.Add(textBox24.Text);
                lb.Items.Add(textBox25.Text);
                lb.Items.Add(textBox26.Text);
                lb.Items.Add(textBox27.Text);
                lb.Items.Add(textBox28.Text);
                lb.Items.Add(textBox29.Text);
                lb.Items.Add(textBox30.Text);
               
                


            }
            dr.Close();






            int cc = lb.Items.Count;
            for (int i = 0; i < cc; i++)
            {
                komut.CommandText = "select * from ITEM where Num=" + Convert.ToInt32(lb.Items[i].ToString());

                komut.Connection = con;
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();
                dr.Close();
                object sonuc = komut.ExecuteScalar();
                label1.Text = sonuc != null ? sonuc.ToString() : "0";
               






                komut.CommandText = "select * from ITEM where Num=" +Convert.ToInt32(lb.Items[i].ToString());

                komut.Connection = con;
                komut.ExecuteNonQuery();
                dr = komut.ExecuteReader();

                if (label1.Text == "0")
                {
                    lb2.Items.Add("ITEM YOK");
                
                }
                else
                {
                    while (dr.Read())
                    {

                        lb2.Items.Add(dr["StrName"].ToString());

                    }
                }
               
              
                dr.Close();
                
            }
           
          
            textBox33.Text = lb2.Items[0].ToString();
            textBox34.Text = lb2.Items[1].ToString();
            textBox35.Text = lb2.Items[2].ToString();
            textBox36.Text = lb2.Items[3].ToString();
            textBox37.Text = lb2.Items[4].ToString();
            textBox38.Text = lb2.Items[5].ToString();
            textBox39.Text = lb2.Items[6].ToString();
            textBox40.Text = lb2.Items[7].ToString();
            textBox41.Text = lb2.Items[8].ToString();
            textBox42.Text = lb2.Items[9].ToString();
            textBox43.Text = lb2.Items[10].ToString();
            textBox44.Text = lb2.Items[11].ToString();
            textBox45.Text = lb2.Items[12].ToString();
            textBox46.Text = lb2.Items[13].ToString();
            textBox47.Text = lb2.Items[14].ToString();
            textBox48.Text = lb2.Items[15].ToString();
            textBox49.Text = lb2.Items[16].ToString();
            textBox50.Text = lb2.Items[17].ToString();
            textBox51.Text = lb2.Items[18].ToString();
            textBox52.Text = lb2.Items[19].ToString();
            textBox53.Text = lb2.Items[20].ToString();
            textBox54.Text = lb2.Items[21].ToString();
            textBox55.Text = lb2.Items[22].ToString();
            textBox56.Text = lb2.Items[23].ToString();
            textBox57.Text = lb2.Items[24].ToString();
            textBox58.Text = lb2.Items[25].ToString();
            textBox59.Text = lb2.Items[26].ToString();
            textBox60.Text = lb2.Items[27].ToString();
            textBox61.Text = lb2.Items[28].ToString();
            textBox62.Text = lb2.Items[29].ToString();
            con.Close();
            lb.Items.Clear();
            lb2.Items.Clear();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
          
            listBox1.Items.Clear();
            komut.CommandText = "select * from ITEM where StrName like '%" + textBox32.Text + "%'";
            //  MessageBox.Show(veri.ToString());
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Num"]+"-"+dr["StrName"]);
               


            }
            con.Close();
            dr.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Num"].ToString();
                textBox33.Text = dr["StrName"].ToString();
               
            }
            con.Close();
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["Num"].ToString();
                textBox34.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = dr["Num"].ToString();
                textBox35.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox4.Text = dr["Num"].ToString();
                textBox36.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox5.Text = dr["Num"].ToString();
                textBox37.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox6.Text = dr["Num"].ToString();
                textBox38.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox7.Text = dr["Num"].ToString();
                textBox39.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox8.Text = dr["Num"].ToString();
                textBox40.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox9.Text = dr["Num"].ToString();
                textBox41.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox10.Text = dr["Num"].ToString();
                textBox42.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox11.Text = dr["Num"].ToString();
                textBox43.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox12.Text = dr["Num"].ToString();
                textBox44.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox13.Text = dr["Num"].ToString();
                textBox45.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox14.Text = dr["Num"].ToString();
                textBox46.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox15.Text = dr["Num"].ToString();
                textBox47.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox16.Text = dr["Num"].ToString();
                textBox48.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox16.Text = dr["Num"].ToString();
                textBox49.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox17.Text = dr["Num"].ToString();
                textBox50.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox19.Text = dr["Num"].ToString();
                textBox51.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox20.Text = dr["Num"].ToString();
                textBox52.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox21.Text = dr["Num"].ToString();
                textBox53.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox22.Text = dr["Num"].ToString();
                textBox54.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox23.Text = dr["Num"].ToString();
                textBox55.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox24.Text = dr["Num"].ToString();
                textBox56.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox25.Text = dr["Num"].ToString();
                textBox57.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox26.Text = dr["Num"].ToString();
                textBox58.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox27.Text = dr["Num"].ToString();
                textBox59.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox28.Text = dr["Num"].ToString();
                textBox60.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox29.Text = dr["Num"].ToString();
                textBox61.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string listsec;
            listsec = listBox1.SelectedItem.ToString();
            int itemnum = 0;
            itemnum = Convert.ToInt32(listsec.Substring(0, 9));
            komut.CommandText = "select * from ITEM where Num=" + itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox30.Text = dr["Num"].ToString();
                textBox62.Text = dr["StrName"].ToString();

            }
            con.Close();
            dr.Close();
        }
        }
    }

