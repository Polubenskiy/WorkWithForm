using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Working_with_form.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Working_with_form
{
    public partial class MenuManagement : Form
    {
        public MenuManagement()
        {
            InitializeComponent();
        }
   
        PersonalAccount personalAccount = new PersonalAccount();
        Catalog catalog = new Catalog();
        Editor editor;
        Exit exit = new Exit();

        string filePath;
        public ExcelHelper excelApp;

        string str;  

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            Hide();
            catalog.ShowDialog();
            Show();
        }

        private void buttonProductCatalog_Click(object sender, EventArgs e)
        {
            editor = new Editor(excelApp);
            StreamReader shadow = new StreamReader("key.txt");
            string password = shadow.ReadLine();
            
            str = Interaction.InputBox("Введите пароль", "Ввод пароля");
            if (str == password)
            {
                MessageBox.Show("Пароль верный");
                Hide();
                editor.ShowDialog();
                Show();
                shadow.Close();

            }
            else
            {
                MessageBox.Show("Пароль неверный");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exit.ShowDialog();
            if (exit.condition == true)
                Show();
        }

        private void MenuManagement_Load(object sender, EventArgs e)
        {
         

            this.MinimumSize = new Size(917, 579);
            // Путь к файлу excel
            string path = Application.StartupPath;
            filePath = path + @"\Catalog.xlsx";
            // Создание объекта 
            excelApp = new ExcelHelper();
            // Отображение приложения
            ExcelHelper.application.Visible = false;
            //Отключить отображение окон с сообщениями
            ExcelHelper.application.DisplayAlerts = true;
            // Открытие существующего файла
            excelApp.OpenFile(filePath);
        }

        private void buttonPersonalAccount_Click(object sender, EventArgs e)
        {
            Hide();
            personalAccount.ShowDialog();
            Show();
        }

        private void MenuManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            excelApp.Dispose();
        }
    }
}
