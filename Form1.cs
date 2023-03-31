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

namespace KOPluginDatabaseEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=;Initial Catalog=2300PKDB;User ID=sa; Password=");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select sSid as ID,Strname as Name From K_MONSTER where Strname like '%"+textBox1.Text+"%'", con);
            ds = new DataSet();
            
            da.Fill(ds, "K_MONSTER");
            dataGridView1.DataSource = ds.Tables["K_MONSTER"];
            con.Close();
            
        }
        string veri; // monster kodu
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    try
      //      {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";

                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";


                veri = ds.Tables["K_MONSTER"].Rows[e.RowIndex]["ID"].ToString();
                komut.CommandText = "select * from K_MONSTER_ITEM where sIndex=" + veri + "";
                //  MessageBox.Show(veri.ToString());
                con.Open();
                komut.Connection = con;
                komut.ExecuteNonQuery();
               
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["iItem01"].ToString();
                    textBox3.Text = dr["iItem02"].ToString();
                    textBox4.Text = dr["iItem03"].ToString();
                    textBox5.Text = dr["iItem04"].ToString();
                    textBox6.Text = dr["iItem05"].ToString();

                    textBox7.Text = dr["sPersent01"].ToString();
                    textBox8.Text = dr["sPersent02"].ToString();
                    textBox9.Text = dr["sPersent03"].ToString();
                    textBox10.Text = dr["sPersent04"].ToString();
                    textBox11.Text = dr["sPersent05"].ToString();


                }
                dr.Close();


                SqlDataReader dre;
                komut.CommandText = "select count(*) from K_MONSTER_ITEM where sIndex=" + veri;
                komut.Connection = con;
                komut.ExecuteNonQuery();
                dre = komut.ExecuteReader();
                dre.Close();
                object sonuc = komut.ExecuteScalar();
                label1.Text = sonuc != null ? sonuc.ToString() : "0";
                if (label1.Text!="0")
                {

                    komut.CommandText = "select * from ITEM where Num=" + Convert.ToInt32(textBox2.Text);


                    komut.Connection = con;
                    komut.ExecuteNonQuery();
                    dre = komut.ExecuteReader();
                    if (dre.Read())
                    {

                        textBox13.Text = dre["StrName"].ToString();
                    }
                    dre.Close();
                }

                if (label1.Text != "0")
                {
                    komut.CommandText = "select * from ITEM where Num=" + Convert.ToInt32(textBox3.Text);

                    komut.Connection = con;
                    komut.ExecuteNonQuery();
                    dre = komut.ExecuteReader();
                    if (dre.Read())
                    {
                        textBox14.Text = dre["StrName"].ToString();
                    }
                    dre.Close();
                }
                if (label1.Text != "0")
                {
                    komut.CommandText = "select * from ITEM where Num=" + Convert.ToInt32(textBox4.Text);

                    komut.Connection = con;
                    komut.ExecuteNonQuery();
                    dre = komut.ExecuteReader();
                    if (dre.Read())
                    {
                        textBox15.Text = dre["StrName"].ToString();
                    }

                    dre.Close();
                }
                if (label1.Text != "0")
                {
                    komut.CommandText = "select * from ITEM where Num=" + Convert.ToInt32(textBox5.Text);

                    komut.Connection = con;
                    komut.ExecuteNonQuery();
                    dre = komut.ExecuteReader();
                    if (dre.Read())
                    {
                        textBox16.Text = dre["StrName"].ToString();
                    }

                    dre.Close();
                }
                if (label1.Text != "0")
                {
                    komut.CommandText = "select * from ITEM where Num=" + Convert.ToInt32(textBox6.Text);

                    komut.Connection = con;
                    komut.ExecuteNonQuery();
                    dre = komut.ExecuteReader();
                    if (dre.Read())
                    {
                        textBox17.Text = dre["StrName"].ToString();
                    }

                    dre.Close();
                }


                con.Close();
       //     }
       //     catch (Exception ex) 
      //      {
       //         MessageBox.Show(ex.ToString());
             
               
         //   }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string kayit = "update K_MONSTER_ITEM set iItem01=@item1,iItem02=@item2,iItem03=@item3,iItem04=@item4,iItem05=@item5,sPersent01=@persent1,sPersent02=@persent2,sPersent03=@persent3,sPersent04=@persent4,sPersent05=@persent5 where sIndex="+veri;
            komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@item1", textBox2.Text);
            komut.Parameters.AddWithValue("@item2", textBox3.Text);
            komut.Parameters.AddWithValue("@item3", textBox4.Text);
            komut.Parameters.AddWithValue("@item4", textBox5.Text);
            komut.Parameters.AddWithValue("@item5", textBox6.Text);

            komut.Parameters.AddWithValue("@persent1", textBox7.Text);
            komut.Parameters.AddWithValue("@persent2", textBox8.Text);
            komut.Parameters.AddWithValue("@persent3", textBox9.Text);
            komut.Parameters.AddWithValue("@persent4", textBox10.Text);
            komut.Parameters.AddWithValue("@persent5", textBox11.Text);
          
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            con.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string itemtype;
            int type=0;
            itemtype = comboBox1.Text;
            if (itemtype=="Hepsi")
            {
                type = 0;
            }
            else if (itemtype=="Upgrade")
            {
                type = 5;
            }
            else if (itemtype == "Magic")
            {
                type = 1;
            }
            else if (itemtype == "Rare")
            {
                type = 2;
            }
            else if (itemtype == "Craft")
            {
                type = 3;
            }
            else if (itemtype == "Unique")
            {
                type = 4;
            }
            else if (itemtype == "Reb Upgrade")
            {
                type = 11;
            }
            else if (itemtype == "Reb Uniq")
            {
                type = 12;
            }
            if (type==0)
            {
                komut.CommandText = "select * from ITEM where StrName like '%" + textBox12.Text + "%'";
            }
            else
            {
                komut.CommandText = "select * from ITEM where StrName like '%" + textBox12.Text + "%' and ItemType=" + type;
            }
           
            listBox1.Items.Clear();
       //     komut.CommandText = "select * from ITEM where StrName like '%" + textBox12.Text + "%'";
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
                textBox13.Text = dr["StrName"].ToString();
                textBox7.Text = "0";
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
                textBox14.Text = dr["StrName"].ToString();
                textBox8.Text = "0";
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
                textBox15.Text = dr["StrName"].ToString();
                textBox9.Text = "0";
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
                textBox16.Text = dr["StrName"].ToString();
                textBox10.Text = "0";
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
                textBox17.Text = dr["StrName"].ToString();
                textBox11.Text = "0";
            }
            con.Close();
            dr.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string listsec;
            
            listsec = listBox1.SelectedItem.ToString();
          //  MessageBox.Show(listsec.Substring(0,9));
            int itemnum = 0;
            itemnum =Convert.ToInt32( listsec.Substring(0, 9));
            
           

            komut.CommandText = "select * from ITEM where Num="+itemnum;
            con.Open();
            komut.Connection = con;
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                listBox2.Items.Add("Item Numarası : "+dr["Num"].ToString());
                listBox2.Items.Add("Item Adı : "+dr["StrName"].ToString());
                listBox2.Items.Add("Attack Power : "+dr["Damage"].ToString());
                listBox2.Items.Add("Max Duration : " + dr["Duration"].ToString());
                listBox2.Items.Add("Defence : " + dr["Ac"].ToString());
                listBox2.Items.Add("Req STR : " + dr["Reqstr"].ToString());
                listBox2.Items.Add("Dagger AC : " + dr["DaggerAc"].ToString());
                listBox2.Items.Add("Mace AC : " + dr["MaceAc"].ToString());
                listBox2.Items.Add("Axe AC : " + dr["AxeAc"].ToString());
                listBox2.Items.Add("Spear AC : " + dr["SpearAc"].ToString());
                listBox2.Items.Add("Bow AC : " + dr["BowAc"].ToString());
                listBox2.Items.Add("Fire Damage : " + dr["FireDamage"].ToString());
                listBox2.Items.Add("Ice Damage : " + dr["IceDamage"].ToString());
                listBox2.Items.Add("Lightning Damage : " + dr["LightningDamage"].ToString());
                listBox2.Items.Add("Poison Damage : " + dr["PoisonDamage"].ToString());
                listBox2.Items.Add("Str Bonus : " + dr["StrB"].ToString());
                listBox2.Items.Add("HP Bonus : " + dr["StaB"].ToString());
                listBox2.Items.Add("Dex Bonus : " + dr["DexB"].ToString());
                listBox2.Items.Add("Magic Power Bonus : " + dr["ChaB"].ToString());
                listBox2.Items.Add("Int Bonus : " + dr["IntelB"].ToString());
                listBox2.Items.Add("Fire Resis : " + dr["FireR"].ToString());
                listBox2.Items.Add("Glacier Resis : " + dr["ColdR"].ToString());
                listBox2.Items.Add("Lightning Resis : " + dr["LightningR"].ToString());
                listBox2.Items.Add("Magic Resis : " + dr["MagicR"].ToString());
                listBox2.Items.Add("Poison Resis : " + dr["PoisonR"].ToString());
                listBox2.Items.Add("Curse Resis : " + dr["CurseR"].ToString());



            }
            con.Close();
            dr.Close();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
