using System;
using System.Numerics;
using System.Windows.Forms;
using DSA.Properties;

namespace DSA
{
    public partial class GeneratedKeysInfoForm : Form
    {
        public GeneratedKeysInfoForm(BigInteger P, BigInteger Q, BigInteger N, BigInteger fN, BigInteger E, BigInteger D)
        {
            InitializeComponent();
            textBox_P.Text = P.ToString();
            textBox_Q.Text = Q.ToString();
            textBox_N.Text = N.ToString();
            textBox_fN.Text = fN.ToString();
            textBox_E.Text = E.ToString();
            textBox_D.Text = D.ToString();
            
            textBox_P.ReadOnly = true;
            textBox_Q.ReadOnly = true;
            textBox_N.ReadOnly = true;
            textBox_fN.ReadOnly = true;
            textBox_E.ReadOnly = true;
            textBox_D.ReadOnly = true;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}