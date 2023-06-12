using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam0612
{
    public partial class Form7 : Form
    {
        DataTable table = new DataTable();
        public Form7()
        {
            InitializeComponent();

           

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Count", typeof(string));
            table.Columns.Add("Total", typeof(string));

            dataGridView1.DataSource = table;
            numericUpDown1.Value = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                label6.Text = "Connected";
                label6.ForeColor = Color.Black;
            }
            else
            {
                label6.Text = "DisConnected";
                label6.ForeColor = Color.Red;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                //합계를 구하기 위해 품목명과 가격을 정의하고 total로 합침
                decimal price = decimal.Parse(textBox2.Text);
                decimal count = numericUpDown1.Value;
                decimal total = price * count;

                //text박스내의 정보를 표에 삽입
                table.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Value, total);
                dataGridView1.DataSource = table;

                //text박스의 정보 초기화
                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = 1;

                //합계
                decimal all = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                textBox3.Text = all.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //행 지우기
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            //합계창에 수정된 값 넣기
            decimal all = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }

            textBox3.Text = all.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DB연결 후 데이터 전송
            using (MySqlConnection conn = new MySqlConnection(""))
            {
                conn.Open();
                //각 행의 정보를 반복문으로 불러온다
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    String Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    String Price = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Count = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String Total = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    //INSERT INTO 쿼리문으로 받아온 정보를 DB에 전송한다. 
                    string sql = string.Format("INSERT INTO sales_tb(name,price,count,total,c_num) VALUES  ('{0}',{1},{2},{3},{4})", @Name, @Price, @Count, @Total, @i);

                    //DB전송을 진행하고 실패시 에러메세지 출력
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            MessageBox.Show("계산되었습니다.");

            //데이터 그리드뷰 초기화
            int rowCount = dataGridView1.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (dataGridView1.Rows[0].IsNewRow == false)
                    dataGridView1.Rows.RemoveAt(0);
            }

            //합계창 초기화
            textBox3.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 dlg = new Form6();
            dlg.ShowDialog();

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
