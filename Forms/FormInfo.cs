using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ClipLab.Forms
{
    public partial class FormInfo : Form
    {
        
        public FormInfo()
        {
            InitializeComponent();
           
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            LoadTheme();
            
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            // label1.ForeColor = ThemeColor.SecondaryColor;
           // label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {

            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "chrome";
            process.StartInfo.Arguments = "https://github.com/booby1545/ClipLab";
            process.Start();


        }
    }
}
