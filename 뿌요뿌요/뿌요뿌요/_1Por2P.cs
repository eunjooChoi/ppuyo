using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 뿌요뿌요
{
    public partial class _1Por2P : Form
    {
        public _1Por2P()
        {
            InitializeComponent();
        }

        private void player1_Click(object sender, EventArgs e)
        {
            You u = new You();
            u.Show();
        }

        private void player2_Click(object sender, EventArgs e)
        {
            You u = new You();
            u.Show();
        }
    }
}
