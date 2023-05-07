using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClipLab.Notifications
{
    public partial class AlertDebug : Form
    {
        public AlertDebug()
        {
            InitializeComponent();
        }

        void AlertBox(Color backColor, Color color, string title, string text, Image icon)
        {
            AlertBox aRt = new AlertBox();
            aRt.BackColor = backColor;
            aRt.ColorAlertBox = color;
            aRt.TitleAlertBox = title;
            aRt.TextAlertBox = text;
            aRt.IconeAlertBox = icon;
            aRt.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Success_Click(object sender, EventArgs e)
        {
            AlertBox(Color.LightGray,Color.SeaGreen, "Успіх :)", "Операція виконана Успішно", Properties.Resources.Success_ICO30);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            AlertBox(Color.LightPink, Color.DarkRed, "Помилка :(", "Операція пошкодилася. Не Успішно.", Properties.Resources.Error_ICO30);

        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            AlertBox(Color.LightGoldenrodYellow, Color.SeaGreen, "Попередження :O", "Щось іде не так", Properties.Resources.Warning_ICO30);

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            AlertBox(Color.LightBlue, Color.DodgerBlue, "Підказка", "Натисніть туди що б сюди...", Properties.Resources.Hint_ICO30);

        }

        private void AlertDebug_Load(object sender, EventArgs e)
        {
            
        }
    }
}
