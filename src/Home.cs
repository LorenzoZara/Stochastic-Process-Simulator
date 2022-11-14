using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StochasticProcessSimulator
{
    public partial class Home : Form
    {
        private readonly List<Label> labels = new List<Label>();
        private readonly FontFamily fontFamily;
        private readonly Font font, fontSelected;
        private readonly Color coral = Color.Coral;
        private readonly Color white = Color.White;
        private PictureBox previousPic;

        public Home()
        {
            InitializeComponent();
            previousPic = A13_pictureBox;

            fontFamily = new FontFamily("Calibri Light");
            font = new Font(fontFamily, 13, FontStyle.Regular, GraphicsUnit.Point);
            fontSelected = new Font(fontFamily, 15, FontStyle.Bold, GraphicsUnit.Point);

            foreach (Label label in labels)
            {
                label.Font = font;
            }
            
        }

        private void A13_button_Click(object sender, EventArgs e)
        {
            A13_Form A13 = new A13_Form();
            A13.ShowDialog();
        }

        private void A15_button_Click(object sender, EventArgs e)
        {
            A15_Form A15 = new A15_Form();
            A15.ShowDialog();
        }

        private void A16_button_Click(object sender, EventArgs e)
        {
            A16_Form A16 = new A16_Form();
            A16.ShowDialog();
        }

        private void A18_button_Click(object sender, EventArgs e)
        {
            A18_Form A18 = new A18_Form();
            A18.ShowDialog();
        }

        private void A20_button_Click(object sender, EventArgs e)
        {
            A20_Form A20 = new A20_Form();
            A20.ShowDialog();
        }
        private void A22GBM_button_Click(object sender, EventArgs e)
        {
            A22GBM_Form A22GBM = new A22GBM_Form();
            A22GBM.ShowDialog();
        }

        private void A22V_button_Click(object sender, EventArgs e)
        {
            A22V_Form A22V = new A22V_Form();
            A22V.ShowDialog();
        }

        private void ACIR_button_Click(object sender, EventArgs e)
        {
            ACIR AC = new ACIR();
            AC.ShowDialog();
        }

        private void AFinal_button_Click(object sender, EventArgs e)
        {
            AFinal_Form AF = new AFinal_Form();
            AF.ShowDialog();
        }

        private void A13_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A13_label.ForeColor = coral;
            A13_label.Font = fontSelected;
            A13_pictureBox.Visible = true;
            previousPic = A13_pictureBox;
        }

        private void A15_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A15_label.ForeColor = coral;
            A15_label.Font = fontSelected;
            A15_pictureBox.Visible = true;
            previousPic = A15_pictureBox;
        }

        private void A16_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A16_label.ForeColor = coral;
            A16_label.Font = fontSelected;
            A16_pictureBox.Visible = true;
            previousPic = A16_pictureBox;
        }

        private void A18_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A18_label.ForeColor = coral;
            A18_label.Font = fontSelected;
            A18_pictureBox.Visible = true;
            previousPic = A18_pictureBox;
        }

        private void A20_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A20_label.ForeColor = coral;
            A20_label.Font = fontSelected;
            A20_pictureBox.Visible = true;
            previousPic = A20_pictureBox;
        }

        private void A22GBM_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A22GBM_label.ForeColor = coral;
            A22GBM_label.Font = fontSelected;
            A22GBM_pictureBox.Visible = true;
            previousPic = A22GBM_pictureBox;
        }

        private void A22V_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            A22V_label.ForeColor = coral;
            A22V_label.Font = fontSelected;
            A22V_pictureBox.Visible = true;
            previousPic = A22V_pictureBox;
        }

        private void ACIR_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            ACIR_label.ForeColor = coral;
            ACIR_label.Font = fontSelected;
            ACIR_pictureBox.Visible = true;
            previousPic = ACIR_pictureBox;
        }

        private void AFinal_label_MouseEnter(object sender, EventArgs e)
        {
            previousPic.Visible = false;
            AFinal_label.ForeColor = coral;
            AFinal_label.Font = fontSelected;
            AFinal_pictureBox.Visible = true;
            previousPic = AFinal_pictureBox;
        }

        private void A13_label_MouseLeave(object sender, EventArgs e)
        {
            A13_label.ForeColor = white;
            A13_label.Font = font;
        }        

        private void A15_label_MouseLeave(object sender, EventArgs e)
        {
            A15_label.ForeColor = white;
            A15_label.Font = font;
        }        

        private void A16_label_MouseLeave(object sender, EventArgs e)
        {
            A16_label.ForeColor = white;
            A16_label.Font = font;
        }

        private void A18_label_MouseLeave(object sender, EventArgs e)
        {
            A18_label.ForeColor = white;
            A18_label.Font = font;
        }

        private void A20_label_MouseLeave(object sender, EventArgs e)
        {
            A20_label.ForeColor = white;
            A20_label.Font = font;
        }

        private void A22GBM_label_MouseLeave(object sender, EventArgs e)
        {
            A22GBM_label.ForeColor = white;
            A22GBM_label.Font = font;
        }

        private void A22V_label_MouseLeave(object sender, EventArgs e)
        {
            A22V_label.ForeColor = white;
            A22V_label.Font = font;
        }        

        private void ACIR_label_MouseLeave(object sender, EventArgs e)
        {
            ACIR_label.ForeColor = white;
            ACIR_label.Font = font;
        }

        private void AFinal_label_MouseLeave(object sender, EventArgs e)
        {
            AFinal_label.ForeColor = white;
            AFinal_label.Font = font;
        }
    }
}
