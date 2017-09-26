using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF20170614
{
    public partial class Form1 : Form
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cad = new SqlCommand();
        public SqlDataAdapter ada = new SqlDataAdapter();
        public DataSet dS = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            //完成数据库连接
           
            con.ConnectionString = @"Data Source=LAPTOP-VDLSTAPB\SQLEXPRESS;Initial Catalog=student;Integrated Security=True";
            con.Open();
            //对数据库进行查询，采取数据
           
            cad.Connection = con;
            cad.CommandType = CommandType.Text;
            cad.CommandText = "select * from person";
            //创建SqlDataAdapter类的实例
            ada = new SqlDataAdapter(cad);
            //获取相应的数据，放到数据集
            
            ada.Fill(dS);
            //绑定控件
            dataGridView1.DataSource = dS.Tables[0];



        }

        private void button1_Click(object sender, EventArgs e)//修改
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(ada);
            ada.Update(dS);
            
        }

        private void btn2_Click(object sender, EventArgs e)//执行
        {
            dS.Tables[0].Rows.Clear();
            cad.CommandText = textBox1.Text;
            cad.ExecuteNonQuery();
            if(textBox1.Text.IndexOf("select")>-1)
            {
                cad.CommandText = textBox1.Text;
                ada = new SqlDataAdapter(cad);
                ada.Fill(dS);
                dataGridView1.DataSource = dS.Tables[0];

            }
            else
            {
                cad.CommandText = "select * from person";
                ada = new SqlDataAdapter(cad);
                ada.Fill(dS);
                dataGridView1.DataSource = dS.Tables[0];

            }
            

            

        }

        private void btntian_Click(object sender, EventArgs e)//添加
        {
            this.TopMost = false;
            frmadd frm2 = new frmadd();
            frm2.ShowDialog();
            this.TopMost = true;
            

            cad.CommandText = "insert into person values('" + frm2.strName + "','" + frm2.strSex + "'," + frm2.iAge.ToString() + ",'" + frm2.strAdress + "','" + frm2.strInterest + "')";
            cad.ExecuteNonQuery();

            dS.Tables[0].Rows.Clear();
            cad.CommandText = "select * from person";
            ada = new SqlDataAdapter(cad);
            ada.Fill(dS);
            dataGridView1.DataSource = dS.Tables[0];



        }

        private void btndel_Click(object sender, EventArgs e)
        {
            cad.CommandText = "delete from person where name = '"+dataGridView1.Rows[ dataGridView1.CurrentRow.Index].Cells[0].Value+"'";
            if(cad.ExecuteNonQuery()>0)
            {
                MessageBox.Show("您所选的数据已删除");
            }
            else
            {
                MessageBox.Show("删除失败");
            }

            dS.Tables[0].Rows.Clear();
            cad.CommandText = "select * from person";
            ada = new SqlDataAdapter(cad);
            ada.Fill(dS);
            dataGridView1.DataSource = dS.Tables[0];
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
