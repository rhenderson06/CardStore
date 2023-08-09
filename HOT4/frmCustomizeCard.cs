using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HOT4
{
    public partial class frmCustomizeCard : Form
    {
        public frmCustomizeCard()
        {
            InitializeComponent();
        }

        const decimal ENVELOPE   = 0.25m;
        const decimal STAMP      = 0.50m;
        const decimal CUSTOMMESS = 0.30m;

        decimal card = 0m;

        string[] Occasions =
        {
            "Thank you",
            "Happy birthday",
            "Get well soon"
        };

        string[] TYCards =
        {
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\TYSimple.jpeg", 
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\TYStars.png",    
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\TYFloral.png"
        };

        string[] HBDCards =
        {
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\HBDSimple.png",  
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\HBDGold.png",    
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\HBDBright.jpg"
        };

        string[] GWSCards =
        {
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\GWSBandage.png",
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\GWSCats.png",
            @"C:\Users\rebek\Desktop\AWD1100HOTs\HOT4\HOT4\HOT4\Images\GWSFloral.png"
        };

        

        private void frmCustomizeCard_Load(object sender, EventArgs e)
        {

            for (int o = 0; o < Occasions.Length; o++)
            {
                cmbOccasion.Items.Add(Occasions[o]);
            }
            cmbOccasion.SelectedIndex = 0;
            picCard.Image = System.Drawing.Image.FromFile(TYCards[0]);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal addon = 0m;
            decimal total = 0m;

            if (chkEnvelope.Checked)
            {
                addon += ENVELOPE;
            }

            if (chkStamp.Checked)
            {
                addon += STAMP;
            }

            if (chkMessage.Checked)
            {
                addon += CUSTOMMESS;
                txtMessage.Enabled = true;
            }
            else
            {
                txtMessage.Enabled = false;
            }

            total = card + addon;
            
            lblMessage.Text = txtMessage.Text;
            lblCost.Text = $"Cost: {total.ToString("c")}";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int st = cmbOccasion.SelectedIndex;

            switch (st)
            {
                case 0:
                    picCard.Image = System.Drawing.Image.FromFile(TYCards[st]);
                    cmbStyle.Items.Clear();
                    cmbStyle.Items.Add("Simple  ($1.00)");
                    cmbStyle.Items.Add("Stars   ($1.25)");
                    cmbStyle.Items.Add("Floral  ($1.50)");
                    cmbStyle.SelectedIndex = 0;
                    break;

                case 1:
                    picCard.Image = System.Drawing.Image.FromFile(HBDCards[st]);
                    cmbStyle.Items.Clear();
                    cmbStyle.Items.Add("Simple  ($1.00)");
                    cmbStyle.Items.Add("Gold    ($1.25)");
                    cmbStyle.Items.Add("Bright  ($1.50)");
                    cmbStyle.SelectedIndex = 0;
                    break;

                case 2:
                    picCard.Image = System.Drawing.Image.FromFile(GWSCards[st]);
                    cmbStyle.Items.Clear();
                    cmbStyle.Items.Add("Bandage ($1.00)");
                    cmbStyle.Items.Add("Cats    ($1.25)");
                    cmbStyle.Items.Add("Floral  ($1.50)");
                    cmbStyle.SelectedIndex = 0;
                    break;

                default:
                    break;
            }

            if (cmbStyle.SelectedIndex == 0)
            {
                card = 1.00m;
            }
            else if (cmbStyle.SelectedIndex == 1)
            {
                card = 1.25m;
            }
            else
            {
                card = 1.50m;
            }
            

        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pic = cmbStyle.SelectedIndex;

            switch (pic)
            {
                case 0:
                    picCard.Image = System.Drawing.Image.FromFile(TYCards[pic]);
                    break;
                case 1:
                    picCard.Image = System.Drawing.Image.FromFile(HBDCards[pic]);
                    break;
                case 2:
                    picCard.Image = System.Drawing.Image.FromFile(GWSCards[pic]);
                    break;
                default:
                    break;
            }
        }

        
    }
}