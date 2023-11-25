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

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection("Data Source=DESKTOP-JU3J93J;initial catalog=SchoolDb; user id=sa;password=123456789");
        int SelectStudentId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentData();
            ClassesData();
        }

        public void StudentData()
        {
            db.Open();

            string sorgu = "select s.Id,c.Name as ClassName,s.Name,s.Surname,s.Age,s.Status from Students s inner join Classes c on (s.ClassesId=c.Id) ";

            SqlCommand sqlCommand=new SqlCommand(sorgu,db);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            
            StudentDgv.DataSource = dt;

            db.Close();
        }

        public void ClassesData()
        {
            db.Open();

            string sorgu = "select * from Classes where Status=1";
            SqlCommand sqlCommand = new SqlCommand(sorgu,db);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand);

            DataTable dt2 = new DataTable();
            sqlDataAdapter2.Fill(dt2);

            ClassesCb.DisplayMember = "Name";
            ClassesCb.ValueMember = "Id";
            ClassesCb.DataSource= dt2;

            UClassesCb.DisplayMember = "Name";
            UClassesCb.ValueMember = "Id";
            UClassesCb.DataSource= dt2;

            db.Close();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            string Name=NameTxt.Text;
            string Surname=SurnameTxt.Text;
            int Age=Convert.ToInt32(AgeNud.Value);
            int Status = Convert.ToBoolean(StatusCb.Checked)==true?1:0;
            int ClassesId = Convert.ToInt32(ClassesCb.SelectedValue);

            db.Open();
            string sorgu = $"Insert into Students(ClassesId,Name,Surname,Age,Status) Values({ClassesId},'{Name}','{Surname}',{Age},{Status})";
            SqlCommand sqlCommand = new SqlCommand(sorgu,db);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Eklendi");
             db.Close();

            StudentData();
           
        }

        private void StudentDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UNameTxt.Text = StudentDgv.CurrentRow.Cells[2].Value.ToString();
            UsurnameTxt.Text = StudentDgv.CurrentRow.Cells[3].Value.ToString();
            UAgeNud.Value = Convert.ToInt32(StudentDgv.CurrentRow.Cells[4].Value);
            UStatusCb.Checked = Convert.ToBoolean(StudentDgv.CurrentRow.Cells[5].Value);
            UClassesCb.Text = StudentDgv.CurrentRow.Cells[1].Value.ToString();
            SelectStudentId = Convert.ToInt32(StudentDgv.CurrentRow.Cells[0].Value);


            SelectedIdLbl.Text = StudentDgv.CurrentRow.Cells[2].Value.ToString()+" "+ StudentDgv.CurrentRow.Cells[3].Value.ToString();
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            string Name = UNameTxt.Text;
            string Surname = UsurnameTxt.Text;
            int Age = Convert.ToInt32(UAgeNud.Value);
            int Status = Convert.ToBoolean(UStatusCb.Checked) == true ? 1 : 0;
            int ClassesId = Convert.ToInt32(UClassesCb.SelectedValue);

            db.Open();
            string sorgu = $"Update Students set ClassesId={ClassesId},Name='{Name}',Surname='{Surname}',Age={Age},Status={Status} where Id={SelectStudentId}";
            SqlCommand sqlCommand = new SqlCommand(sorgu, db);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show(Name+" "+Surname+ " Adlı Öğrenci Güncellendi");
            db.Close();
            SelectStudentId = 0;
            UNameTxt.Clear();
            UsurnameTxt.Clear();
            UAgeNud.Value = 0;
            UStatusCb.Checked = false;

            StudentData();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            //db.Open();
            //string sorgu = $"Delete from Students where Id={SelectStudentId}";
            //SqlCommand sqlCommand=new SqlCommand(sorgu, db);
            //sqlCommand.ExecuteNonQuery();

            //MessageBox.Show("Öğrenci Silindi");
            //db.Close();


            db.Open();

            SqlCommand sqlCommand = new SqlCommand("DeleteUser",db);//Stored Procedure Kullanımı
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("StudentId", SqlDbType.Int).Value = SelectStudentId;

            var ReturnValue = sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar, 100);
            ReturnValue.Direction = ParameterDirection.Output;

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show(ReturnValue.Value.ToString());

            db.Close();

            StudentData();

            SelectStudentId = 0;
            UNameTxt.Clear();
            UsurnameTxt.Clear();
            UAgeNud.Value = 0;
            UStatusCb.Checked = false;
            SelectedIdLbl.Text = "0";
        }
    }
}
