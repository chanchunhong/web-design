using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinF20170614
{
    public partial class frmadd : Form
    {
        public string strName="";
        public string strSex = "";
        public int iAge = 0;
        public string strAdress = "";
        public string strInterest = "";


        public frmadd()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            strName = textname.Text;
            strSex = textsex.Text;
            iAge = int.Parse(texage.Text);
            strAdress = textagress.Text;
            strInterest = textins.Text;
            this.Close();

        }
    }
}
