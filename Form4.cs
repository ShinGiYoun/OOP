using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam0612
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label1.Parent = this;
            Font ft = new Font(label1.Font.Name, 100);
            label1.Font = ft;
           


        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 showform1 = new Form1();
            showform1.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 showform3 = new Form3();
            showform3.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("종료하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // 프로그램 종료
                Application.Exit();
            }
            // 그대로 실행
        }
    }
}
