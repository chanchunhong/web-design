using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        SqlConnection m_con = new SqlConnection();
        SqlCommand m_cmd = new SqlCommand();
        SqlDataAdapter m_ada = new SqlDataAdapter();
        DataSet m_ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jiaohuDataSet.person”中。您可以根据需要移动或删除它。

            m_con.ConnectionString = @"Data Source=IORI-PC\SQLEXPRESS;Initial Catalog=jiaohu;Integrated Security=True;Pooling=False";        //构造连接字符串
            m_con.Open();                       //连接数据库

            m_cmd.Connection = m_con;
            m_cmd.CommandType = CommandType.Text;
            m_cmd.CommandText = "select * from person";

            m_ada = new SqlDataAdapter(m_cmd);

            m_ds = new DataSet();
            m_ada.Fill(m_ds);

            dgvResult.DataSource = m_ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_ds.Tables[0].Rows.Clear();        //清除原来表格中的数据

            m_cmd.CommandText = txtSQL.Text;    //执行新的命令
            m_cmd.ExecuteNonQuery();

            if (txtSQL.Text.IndexOf("select ")>-1)
            {
                m_cmd.CommandText = txtSQL.Text;
                m_ada = new SqlDataAdapter(m_cmd);
                m_ada.Fill(m_ds);
                dgvResult.DataSource = m_ds.Tables[0];
            }
            else
            {
                //返回最新数据库的内容
                m_cmd.CommandText = "select * from person";
                m_ada = new SqlDataAdapter(m_cmd);
                m_ada.Fill(m_ds);
                dgvResult.DataSource = m_ds.Tables[0];
            }

        }
    }
}
