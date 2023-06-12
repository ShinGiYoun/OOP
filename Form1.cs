using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // SQL 연동을 위한 using

namespace Exam0612
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_newmember_Click(object sender, EventArgs e)
        {
            Form3 showform3 = new Form3();
            showform3.ShowDialog();
 //           this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=cs-dept.esm.kr;Port=23306;Database=shingiyoun;Uid=shingiyoun;Pwd=sgy39270!;");
                connection.Open();

                int login_status = 0;

                string loginid = txtbox_id.Text;
                string loginpwd = txtbox_pwd.Text;

                string selectQuery = "SELECT * FROM account_info WHERE id = \'" + loginid + "\' ";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);

                MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                    {
                        login_status = 1;
                    }
                }
                connection.Close();

                if (login_status == 1)
                {
                    MessageBox.Show("로그인 완료");

                    Form5 form5 = new Form5();
                    form5.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("회원 정보를 확인해 주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public static implicit operator Form1(Form3 v)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
