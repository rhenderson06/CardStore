using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOT4
{
    public partial class frmCardStoreHome : Form
    {
        public frmCardStoreHome()
        {
            InitializeComponent();
        }

        private void btnCustomizeCard_Click(object sender, EventArgs e)
        {
            frmCustomizeCard customizeCard = new frmCustomizeCard();
            frmCardStoreHome home = new frmCardStoreHome();

            customizeCard.Show();
            home.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            DialogResult dialog = MessageBox.Show(
               "Do you really want to exit?",
               "Exit Now",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
