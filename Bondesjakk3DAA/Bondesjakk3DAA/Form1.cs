using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondesjakk3DAA
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        bool spiller1 = true;
        const int maksAntallTrekk = 9;
        int antallTrekk = 0;

        private bool Vinner(string s){
            bool v = (b11.Text == s && b12.Text == s && b13.Text == s) ||
                    (b21.Text == s && b22.Text == s && b23.Text == s) ||
                    (b31.Text == s && b32.Text == s && b33.Text == s) ||
                    (b11.Text == s && b21.Text == s && b31.Text == s) ||
                    (b12.Text == s && b22.Text == s && b32.Text == s) ||
                    (b13.Text == s && b23.Text == s && b33.Text == s) ||
                    (b11.Text == s && b22.Text == s && b33.Text == s) ||
                    (b13.Text == s && b22.Text == s && b31.Text == s);
            return v;
        }
        private void SjekkVinner(){
            if (Vinner("X")){
                label1.Text = "X er vinner";
                KontrollerSpillflate(false);
            }
            else if (Vinner("O")){
                label1.Text = "O er vinner";
                KontrollerSpillflate(false);
            }
            else if (antallTrekk == maksAntallTrekk)
                label1.Text = "Uavgjordt!";
        }

        private void KontrollerSpillflate(bool k){
            b11.Enabled = k;
            b12.Enabled = k;
            b13.Enabled = k;
            b21.Enabled = k;
            b22.Enabled = k;
            b23.Enabled = k;
            b31.Enabled = k;
            b32.Enabled = k;
            b33.Enabled = k;
        }
        private void NyttSpill(){
            b11.Text = "";
            b12.Text = "";
            b13.Text = "";
            b21.Text = "";
            b22.Text = "";
            b23.Text = "";
            b31.Text = "";
            b32.Text = "";
            b33.Text = "";
            antallTrekk = 0;
            KontrollerSpillflate(true);
        }

        private void bNyttSpill_Click(object sender, EventArgs e){
            NyttSpill();
        }

        private void Spiller_Click(object sender, EventArgs e){
            Button b = sender as Button;

            if (b.Text != "X" && b.Text != "O"){
                if (spiller1)
                    b.Text = "X";
                else
                    b.Text = "O";
                spiller1 = !spiller1;
                antallTrekk = antallTrekk + 1;
                SjekkVinner();
            }
        }
    }
}
