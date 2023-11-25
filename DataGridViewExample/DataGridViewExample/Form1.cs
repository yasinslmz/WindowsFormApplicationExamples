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


namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        SqlConnection db=new SqlConnection(@"Data Source=DESKTOP-JU3J93J;initial catalog=SchoolDb;integrated security=true");
        //SqlConnection db=new SqlConnection(@"Data Source=(localdb)MsSqlLocalDb;initial catalog=SchoolDb;user id=sa;password=123");

        DataTable dt = new DataTable(); //sanal tablo
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                MessageBox.Show("Bağlantı Gerçekleşti");
                db.Close();
            }
            catch 
            {
                MessageBox.Show("Sever'a Bağlanamadı");
            }

           

            dt.Columns.Add("Id");//Sanal tablo sütun başlıkları
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            dt.Columns.Add("Status");

            DataRow dr = dt.NewRow();//Sanal tablo satır oluşturma
            dr["Id"] = 1; //sanal tablo satır içerikleri
            dr["Name"] = "Erhan";
            dr["Surname"] = "Kaya";
            dr["Age"] = 33;
            dr["Status"] = "Active";

            dt.Rows.Add(dr);//Sanal tablo satırını sanal tabloya aktarma


            dr = dt.NewRow();//Sanal tablo satır oluşturma
            dr["Id"] = 2; //sanal tablo satır içerikleri
            dr["Name"] = "Ahmet";
            dr["Surname"] = "Akif";
            dr["Age"] = 23;
            dr["Status"] = "passive";

            dt.Rows.Add(dr);

            dataGridView2.DataSource = dt;



            db.Open();

            string sorgu = "select s.Id,c.Name as ClassName, s.Name, s.Surname,s.Age,s.Status " +
                            "from students as s inner join classes as c on(s.ClassesId=c.Id)  " +
                            "where s.Status=1";
            SqlCommand sqlCommand=new SqlCommand(sorgu,db);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            db.Close();


            db.Open();

            string sorgu2 = "select * from students";

            SqlCommand sqlCommand1 = new SqlCommand(sorgu2,db);
            SqlDataReader reader= sqlCommand1.ExecuteReader();

            while (reader.Read())
            {
                if (Convert.ToBoolean(reader["Status"]) != false)
                {
                    listBox1.Items.Add(reader["Name"] + "\t" + reader["Surname"]);

                }
            }


            db.Close();



        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            DataRow NewUser=dt.NewRow();
            NewUser["Id"] = IdNud.Value;
            NewUser["Name"]=NameTxt.Text;
            NewUser["Surname"]=SurnameTxt.Text;
            NewUser["Age"] = AgeNud.Value;
            NewUser["Status"]=StatusCb.SelectedItem.ToString();

            dt.Rows.Add(NewUser);
        }
    }
}
