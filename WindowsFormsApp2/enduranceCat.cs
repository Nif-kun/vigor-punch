using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class enduranceCat : Form
    {
        int jj = 30;
        int jr = 30;
        int sqts = 30;
        int jog = 30;
        int mtclmb = 30;
        public enduranceCat()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void enduranceCat_Load(object sender, EventArgs e)
        {

        }

        private void btnJJDec_Click(object sender, EventArgs e)
        {
            if(jj == 0)
            {
                MessageBox.Show("Can't Input 0 Repetition");
            }
            else
            {
                jj--;
                txtJumpingJacks.Text = jj.ToString();

            }
            
        }

        private void btnJJInc_Click(object sender, EventArgs e)
        {
            jj++;
            txtJumpingJacks.Text = jj.ToString();

        }

        private void btnJRDec_Click(object sender, EventArgs e)
        {
            if (jr == 0)
            {
                MessageBox.Show("Can't Input 0 Repetition");
            }
            else
            {
                jr--;
                txtJumpRope.Text = jr.ToString();

            }

        }

        private void btnJRInc_Click(object sender, EventArgs e)
        {
            jr++;
            txtJumpRope.Text = jr.ToString();
        }

        private void btnSqtDec_Click(object sender, EventArgs e)
        {
            if (sqts == 0)
            {
                MessageBox.Show("Can't Input 0 Repetition");
            }
            else
            {
                sqts--;
                txtSquats.Text = sqts.ToString();

            }

        }

        private void btnSqtInc_Click(object sender, EventArgs e)
        {
            sqts++;
            txtSquats.Text = sqts.ToString();
        }

        private void btnJogDec_Click(object sender, EventArgs e)
        {
            if (jog == 0)
            {
                MessageBox.Show("Can't Input 0 Repetition");
            }
            else
            {
                jog--;
                txtJog.Text = jog.ToString();

            }


        }

        private void btnJogInc_Click(object sender, EventArgs e)
        {
            jog++;
            txtJog.Text = jog.ToString();
        }

        private void btnMTDec_Click(object sender, EventArgs e)
        {
            if (mtclmb == 0)
            {
                MessageBox.Show("Can't Input 0 Repetition");
            }
            else
            {
                mtclmb--;
                txtMTClimb.Text = mtclmb.ToString();

            }

        }

        private void btnMTInc_Click(object sender, EventArgs e)
        {
            mtclmb++;
            txtMTClimb.Text = mtclmb.ToString();

        }
    }
}
