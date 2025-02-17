using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lstBCC.Items.Clear();
            int so = Convert.ToInt32(txtBang.Text);
           
            for (int i = 1; i <= 10; i++)
            {
                lstBCC.Items.Add(so + " x " + i + " = " + so * i);
            }
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            int tbso;

            for (int i = 2; i <= 10; i++)
            {

                for (tbso = 1; tbso <= 10; tbso++)
                {
                    lstToanBo.Items.Add(i + " x " + tbso + " = " + tbso * i);
                }
            }
        }
    }
}
