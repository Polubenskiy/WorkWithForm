using System;
using System.Drawing;
using System.Windows.Forms;
using Working_with_form.Forms;

namespace Working_with_form
{
    public partial class PriceList : Form
    {
        public PriceList()
        {
            InitializeComponent();
        }

        // Получение нужной категори из другой формы
        public PriceList(string categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        ExcelHelper excelApplication = new ExcelHelper();
     
        ListView[] priceList;
        ListViewItem[] listViewItem;
        ImageList[] imageList;
        Random random = new Random();
                                                                                                                                                             
        Button[] buttonBuyProduct;
        Label[] labelCostProduct;

        TableLayoutPanel menu;
        TableLayoutPanel[] menuCells;

        string[] product;
        string[] description;

        int countProduct;
        string categoria;
        string[] categories;
        uint[] price;
        uint sum;

        private void PriceList_Load(object sender, EventArgs e)
        {
            sum = Convert.ToUInt32(random.Next(40000, 150000));
            labelSum.Text = sum.ToString() + " руб.";
            labelCategoria.Text = categoria;

            ExcelOpen();
            countProduct = excelApplication.LastRowCell(categoria);
            GetAccessExcel();
            CreateListView(countProduct);
            CreateTableLayoutPanel(countProduct);
            CreateTableLayoutPanelCells(countProduct);

            CreateButton(countProduct);
            CreateLabels(countProduct);
            for (int i = 0; i < countProduct; i++)
            {
                menu.Controls.Add(priceList[i], 0 , i);
                menu.Controls.Add(menuCells[i], 1, i);
                menuCells[i].Controls.Add(labelCostProduct[i], 1, 0);
                menuCells[i].Controls.Add(buttonBuyProduct[i], 1, 1);
            }
            panelMain.Controls.Add(menu);
        }

        public void ExcelOpen()
        {
            string path = Application.StartupPath + @"\Catalog.xlsx";
            excelApplication.OpenFile(path);
        }

        public void GetAccessExcel()
        {
            categories = new string[6];
            for (int i = 0; i < categories.Length; i++)
                categories[i] = excelApplication.ReadCell(1, i + 1, 1);
           
            // Определение последней строки и определение позиции нужной ячейки
            int nullCell = excelApplication.LastRowCell(categoria);
            product = new string[nullCell];
            description = new string[nullCell];
            // Считывает данные из excel
            for (int i = 0; i < product.Length; i++)
            {
                product[i] = excelApplication.ReadCell(categoria, i + 1, 1);
                description[i] = excelApplication.ReadCell(categoria, i + 1, 2);
            }
        }

        //
        // labelCost
        //
        public Label[] CreateLabels(int count)
        {
            labelCostProduct = new Label[count];
            price = new uint[count];
            for (int i = 0; i < count; i++)
            {
                labelCostProduct[i] = new Label();
                this.labelCostProduct[i].AutoSize = true;
                this.labelCostProduct[i].Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.labelCostProduct[i].Location = new Point(70+ i, 100 + i);
                this.labelCostProduct[i].Name = "label" + i.ToString();
                this.labelCostProduct[i].Size = new System.Drawing.Size(76, 25);
                this.labelCostProduct[i].TabIndex = 0;
                price[i] = Convert.ToUInt32(random.Next(30000, 120000));
                this.labelCostProduct[i].Text = "\t" + price[i].ToString();
                this.labelCostProduct[i].Dock = DockStyle.Fill;
                this.labelCostProduct[i].Anchor = AnchorStyles.None;
            }
            return labelCostProduct;
        }
        
        //
        // buttonBuy
        //
        public Button[] CreateButton(int count)
        {
            buttonBuyProduct = new Button[count];
            for (int i = 0;i < count;i++)
            {
                buttonBuyProduct[i] = new Button();
                this.buttonBuyProduct[i].Dock = System.Windows.Forms.DockStyle.None;
                this.buttonBuyProduct[i].FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
                this.buttonBuyProduct[i].FlatAppearance.BorderSize = 0;
                this.buttonBuyProduct[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.buttonBuyProduct[i].ForeColor = System.Drawing.SystemColors.Control;
                this.buttonBuyProduct[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 20f);
                this.buttonBuyProduct[i].Location = new System.Drawing.Point(481, 217);
                this.buttonBuyProduct[i].Name = "button" + i.ToString();
                this.buttonBuyProduct[i].Size = new System.Drawing.Size(200, 60);
                this.buttonBuyProduct[i].TabIndex = 12;
                this.buttonBuyProduct[i].Text = "Купить";
                this.buttonBuyProduct[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.buttonBuyProduct[i].UseVisualStyleBackColor = true;
                this.buttonBuyProduct[i].BackColor = System.Drawing.Color.Orange;
                this.buttonBuyProduct[i].Tag = i;
                this.buttonBuyProduct[i].Click += new System.EventHandler(buttonBuyProduct_Click);//подписываемся на событие
            }
            return buttonBuyProduct;
        }

        //обрабатываем событие
        private void buttonBuyProduct_Click(object sender, EventArgs e)
        {
            Button _button = sender as Button;
            int numberTag = Convert.ToInt32(_button.Tag);

            if (sum >= price[numberTag])
            {
                sum -= price[numberTag];
                labelSum.Text = sum.ToString();
                MessageBox.Show("Вы купили компьютер: " + product[numberTag] + " за " + price[numberTag] + "\n\n" + "Описание данного ПК: " + "\n" + description[numberTag] + "\n\n" + "Отслеживать отправление данного товара можно будет в Личном кабинете");
            }
            else { MessageBox.Show("Недостаточно средств для покупки данного пк."); }
        }

        // 
        // listViewPriceList
        // 
        public ListView[] CreateListView(int count)
        {
            priceList = new ListView[count];
            listViewItem = new ListViewItem[count];
            imageList = new ImageList[count];
            for (int i = 0; i < count; i++)
            {
                priceList[i] = new ListView();
                this.priceList[i].Location = new Point(60, 289);
                this.priceList[i].Name = "listView" + i.ToString();
                this.priceList[i].Size = new Size(650, 150);
                this.priceList[i].SmallImageList = this.imageList[i];
                this.priceList[i].UseCompatibleStateImageBehavior = false;
                this.priceList[i].View = View.Details;
                this.priceList[i].Dock = DockStyle.Fill;
                this.priceList[i].GridLines = false;
                this.priceList[i].HeaderStyle = ColumnHeaderStyle.Nonclickable;
                this.priceList[i].HideSelection = false;
                // Создание колонок ListView
                this.priceList[i].Columns.Add(new ColumnHeader());
                this.priceList[i].Columns[0].Text = "";
                this.priceList[i].Columns[0].Width = 100;
                this.priceList[i].Columns.Add(new ColumnHeader());
                this.priceList[i].Columns[1].Text = product[i];
                this.priceList[i].Columns[1].Width = 600;

                
                // Создание списоков изображений для строк listView
                imageList[i] = new ImageList();
                // устанавливаем размер изображений
                imageList[i].ImageSize = new Size(100, 100);
                // заполняем список изображениями
                try
                {
                    string pathToImage = Application.StartupPath + @"\PriceList" + @"\" + categoria + @"\" + product[i] + @".jpg";
                    imageList[i].Images.Add(new Bitmap(pathToImage));
                   
                }
                catch (Exception) { MessageBox.Show("Название файла картинки не совпадает с названием продукта"); }
                // устанавливаем в listView1 список изображений imageList
                priceList[i].SmallImageList = imageList[i];
                // добавляем строки в listView1
                for (int j = 0; j < 1; j++)
                {
                    // создадим объект ListViewItem (строку) для listView
                    listViewItem[i] = new ListViewItem();

                    listViewItem[i].SubItems.Add(description[i]);
                    // индекс изображения из imageList для данной строки listViewItem
                    listViewItem[i].ImageIndex = 0;

                    // добавляем созданный элемент listViewItem (строку) в listView1
                    priceList[i].Items.Add(listViewItem[i]);
                }
            }
            return priceList;
        }
            
        // 
        // tableLayoutPanel
        // 
        public TableLayoutPanel CreateTableLayoutPanel(int countRow)
        {
            menu = new TableLayoutPanel();
            this.menu.ColumnCount = 2;
            this.menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
            this.menu.Location = new Point(70, 150);
            this.menu.Name = "tableLayoutPanel";
            this.menu.RowCount = countRow;
            for (int i = 0; i < countRow; i++)
                this.menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 150f));     
            this.menu.Size = new Size(1000, 150 * countRow);
            this.menu.TabIndex = 0;
            this.menu.BackColor = Color.Transparent;
            return menu;
        }

        // 
        // tableLayoutPanelCells
        // 
        public TableLayoutPanel[] CreateTableLayoutPanelCells(int countRow)
        {
            menuCells = new TableLayoutPanel[countRow];
            for (int i = 0; i < countRow; i++)
            {
                menuCells[i] = new TableLayoutPanel();
                this.menuCells[i].ColumnCount = 1;
                this.menuCells[i].ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
                this.menuCells[i].Location = new Point(70, 150);
                this.menuCells[i].Name = "tableLayoutPanel";
                this.menuCells[i].RowCount = countRow;
                this.menuCells[i].RowStyles.Add(new RowStyle(SizeType.Absolute, 60f));
                this.menuCells[i].RowStyles.Add(new RowStyle(SizeType.Absolute, 90f));
                this.menuCells[i].TabIndex = 0;
                this.menuCells[i].BackColor = Color.Transparent;
                this.menuCells[i].Dock = DockStyle.Fill;
                this.menuCells[i].CellBorderStyle = (TableLayoutPanelCellBorderStyle)BorderStyle.None;
            }
            
            return menuCells;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalAccount account = new PersonalAccount();

            this.Hide();
            account.ShowDialog();
            this.Show();
        }
    }
}
