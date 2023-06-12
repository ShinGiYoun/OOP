using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Exam0612
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_newmember_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=cs-dept.esm.kr;Port=23306;Database=shingiyoun;Uid=shingiyoun;Pwd=sgy39270!;");
                connection.Open();

                string insertQuery = "INSERT INTO account_info (name, id, pwd) VALUES ('" + txtbox_name.Text + "', '" + txtbox_id.Text + "', '" + txtbox_pwd.Text + "');";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtbox_name.Text + "님 회원가입 완료, 사용할 아이디는 " + txtbox_id.Text + "입니다.");
                    connection.Close();
                    
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("비정상 입력 정보, 재확인 요망");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}