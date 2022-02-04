using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Working_with_form.Forms
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        ExcelHelper excelApp;
        public Editor(ExcelHelper excelApp)
        {
            InitializeComponent();
            this.excelApp = excelApp;
        }

        DialogResult dialogResult;
        ImageList imageList;
        Image tempImage;
        ListViewItem listViewItem;
        string categoria;
        string[] categories;
        string[] product;
        string[] description;
 
        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            dialogResult = MessageBox.Show("Выйти из режима редактирования", "На главную страницу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            ExcelHelper.application.Visible = false;

            MinimumSize = new Size(727, 820);
            MaximumSize = new Size(727, 820);

            // заполенение comboBoxCategories
            comboBoxCategories.Items.Clear();
            categories = new string[6];
            for (int i = 0; i < categories.Length; i++)
                categories[i] = excelApp.ReadCell(1, i + 1, 1);
            try
            {
                comboBoxCategories.Items.AddRange(categories);
                comboBoxCategories.Text = comboBoxCategories.Items[0].ToString();
            }
            catch (Exception) { MessageBox.Show("ComboBox, value is nul!"); }


            DefinitionProduct();
            WriteListView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(textBoxProduct.Text) || string.IsNullOrEmpty(textBoxDescription.Text))
                return;

   
            categoria = comboBoxCategories.SelectedItem.ToString();

            int nullCell = excelApp.LastRowCell(categoria); 

            if (nullCell == 1  && excelApp.ReadCell(categoria, 1, 1) == " ")
                nullCell = excelApp.LastRowCell(categoria);
            else
                nullCell++;

            excelApp.WriteCell(categoria, nullCell, 1, textBoxProduct.Text);
            excelApp.WriteCell(categoria, nullCell, 2, textBoxDescription.Text);
            excelApp.Save();

            DefinitionProduct();
            WriteListView();

            textBoxProduct.Clear();
            textBoxDescription.Clear();
            pictureBoxImage.Image = null;
            textBoxProduct.Focus();
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int removeCell = excelApp.LastRowCell(categoria);
            try
            {
                //listView.Items.Coun
                if (removeCell >= 0)
                {
                    listView.Items.Remove(listView.Items[removeCell - 1]);

                    categoria = comboBoxCategories.SelectedItem.ToString();

                    excelApp.WriteCell(categoria, removeCell, 1, Type.Missing);
                    excelApp.WriteCell(categoria, removeCell, 2, Type.Missing);
                    excelApp.Save();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пустое значение");
            }
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefinitionProduct();    
            WriteListView();
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Bitmap temp = new Bitmap(openFileDialog.FileName); //Картинка изображения
                imageList.Images.Add(new Bitmap(temp));
                pictureBoxImage.Image = temp;
            }
        }

        public void WriteListView()
        {
            listView.Items.Clear();

            // Создание списоков изображений для строк listView
            imageList = new ImageList();
            // устанавливаем размер изображений
            imageList.ImageSize = new Size(100, 100);

            // заполняем список изображениями
            try
            {
                for (int i = 0; i < product.Length; i++)
                {
                    string pathToImage = Application.StartupPath + @"\PriceList" + @"\" + categoria + @"\" + product[i] + ".jpg";
                    imageList.Images.Add(new Bitmap(pathToImage));
                }
            }
            catch (Exception) { MessageBox.Show("Название файла картинки не совпадает с названием продукта"); }
           
            // устанавливаем в listView список изображений imageList
            listView.SmallImageList = imageList;
            // добавляем строки в listView1
            for (int i = 0; i < product.Length; i++)
            {
                // создадим объект ListViewItem (строку) для listView
                listViewItem = new ListViewItem(new string[] { "", product[i], description[i] });

                // индекс изображения из imageList для данной строки listViewItem
                listViewItem.ImageIndex = i;

                // добавляем созданный элемент listViewItem (строку) в listView1
                listView.Items.Add(listViewItem);
            }
        }

        public void DefinitionProduct()
        {
            // Определение последней строки и определение позиции нужной ячейки
            categoria = comboBoxCategories.SelectedItem.ToString();
            int nullCell = excelApp.LastRowCell(categoria);
            product = new string[nullCell];
            description = new string[nullCell];

            // Считывает данные из excel
            for (int i = 0; i < product.Length; i++)
            {
                product[i] = excelApp.ReadCell(categoria, i + 1, 1);
                description[i] = excelApp.ReadCell(categoria, i + 1, 2);
            }
        }
    }
}
