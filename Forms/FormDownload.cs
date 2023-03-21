using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.Forms
{
    public partial class FormDownload : Form
    {
        public FormDownload()
        {
            InitializeComponent();
        }
        private void FormDownload_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn=(Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
                labelHelpInput.ForeColor = ThemeColor.SecondaryColor;
                labelDownloadTip.ForeColor = ThemeColor.PrimaryColor;
            }
        }

        private void panelDownloadBase_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
