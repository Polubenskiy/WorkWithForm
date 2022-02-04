using System;
using System.Windows.Forms;

namespace Working_with_form.Forms
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        DialogResult dialogResult;
        uint sum;
        Random rand = new Random();
        public string categoria;

        private void PriceList_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            dialogResult = MessageBox.Show("Выйти из католога товаров", "На главную страницу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            //MinimumSize = new Size(816, 439);
            sum = (uint)rand.Next(20000, 140000);
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPC_MouseLeave(object sender, EventArgs e)
        {
            Button _button = sender as Button;
            switch (_button.Tag)
            {
                case "1": this.buttonOffice.ForeColor = System.Drawing.Color.Black; break;
                case "2": this.buttonHome.ForeColor = System.Drawing.Color.Black; break;
                case "3": this.buttonDesign.ForeColor = System.Drawing.Color.Black; break;
                case "4": this.buttonGame.ForeColor = System.Drawing.Color.Black; break;
                case "5": this.buttonNotebook.ForeColor = System.Drawing.Color.Black; break;
                case "6": this.buttonServer.ForeColor = System.Drawing.Color.Black; break;
                default: break;
            }
        }

        private void buttonPC_MouseEnter(object sender, EventArgs e)
        {
            Button _button = sender as Button;
            switch (_button.Tag)
            {
                case "1": this.buttonOffice.ForeColor = System.Drawing.Color.Orange; break;
                case "2": this.buttonHome.ForeColor = System.Drawing.Color.Orange; break;
                case "3": this.buttonDesign.ForeColor = System.Drawing.Color.Orange; break;
                case "4": this.buttonGame.ForeColor = System.Drawing.Color.Orange; break;
                case "5": this.buttonNotebook.ForeColor = System.Drawing.Color.Orange; break;
                case "6" +
                "":
                    this.buttonServer.ForeColor = System.Drawing.Color.Orange; break;
                default: break;
            }
        }

        private void buttonCrossingPriceListr_Click(object sender, EventArgs e)
        {
            Button _button = sender as Button;
            switch (_button.Tag)
            {
                case "1": categoria = "Офисный"; break;
                case "2": categoria = "Домашний"; break;
                case "3": categoria = "Дизайнерский"; break;
                case "4": categoria = "Игровой"; break;
                case "5": categoria = "Ноутбук"; break;
                case "6": categoria = "Серверный"; break;
                default: break;
            }

            PriceList priceList = new PriceList(categoria);
            Hide();
            priceList.ShowDialog();
            Show();
        }

        private void buttonReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
