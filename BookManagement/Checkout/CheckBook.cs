using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmCheckBook : Form
    {
        public frmCheckBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main showMain = new Main();
            showMain.Show();
        }

        private void CheckBook_Load(object sender, EventArgs e)
        {

        }
    }
}
