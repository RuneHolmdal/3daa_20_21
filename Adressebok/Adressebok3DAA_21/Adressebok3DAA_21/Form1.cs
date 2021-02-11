using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressebok3DAA_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] personer = new string[5];
        int antPersoner = 0;

        private void btLagre_Click(object sender, EventArgs e)
        {
            if (antPersoner <= 4)
            {
                personer[antPersoner] = tbNavn.Text + ", " + tbTlf.Text;
                antPersoner++;
            }
        }
    }
}
