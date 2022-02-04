using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_with_form
{
    public partial class PersonalAccount : Form
    {
        public PersonalAccount()
        {
            InitializeComponent();
        }

        //public PersonalAccount(string product, string description, uint price, Image image)
        //{
        //    InitializeComponent();
        //    this.product = product;
        //    this.description = description;
        //    this.price = price;
        //    //this.imageList = image;
        //}


        //ListView[] priceList;
        //ListViewItem[] listViewItem;
        //ImageList[] imageList;
        //Random random = new Random();

        //Button[] buttonBuyProduct;
        //Label[] labelCostProduct;

        //TableLayoutPanel menu;
        //TableLayoutPanel[] menuCells;

        //string[] product;
        //string[] description;

        //int countProduct;
        //string categoria;
        //string[] categories;
        //uint price;
        //uint sum;
        private void buttonReturnAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonalAccount_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(816, 439);
        }

        DialogResult dialogResult;

        private void PersonalAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            dialogResult = MessageBox.Show("Выйти из личного кабинета?", "На главную страницу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        ////
        //// labelCost
        ////
        //public Label[] CreateLabels(int count)
        //{
        //    labelCostProduct = new Label[count];
        //    price = new uint[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        labelCostProduct[i] = new Label();
        //        this.labelCostProduct[i].AutoSize = true;
        //        this.labelCostProduct[i].Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        //        this.labelCostProduct[i].Location = new Point(70 + i, 100 + i);
        //        this.labelCostProduct[i].Name = "label" + i.ToString();
        //        this.labelCostProduct[i].Size = new System.Drawing.Size(76, 25);
        //        this.labelCostProduct[i].TabIndex = 0;
        //        price[i] = Convert.ToUInt32(random.Next(30000, 120000));
        //        this.labelCostProduct[i].Text = "\t" + price[i].ToString();
        //        this.labelCostProduct[i].Dock = DockStyle.Fill;
        //        this.labelCostProduct[i].Anchor = AnchorStyles.None;
        //    }
        //    return labelCostProduct;
        //}

        //// 
        //// listViewPriceList
        //// 
        //public ListView[] CreateListView(int count)
        //{
        //    priceList = new ListView[count];
        //    listViewItem = new ListViewItem[count];
        //    imageList = new ImageList[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        priceList[i] = new ListView();
        //        this.priceList[i].Location = new Point(60, 289);
        //        this.priceList[i].Name = "listView" + i.ToString();
        //        this.priceList[i].Size = new Size(650, 150);
        //        this.priceList[i].SmallImageList = this.imageList[i];
        //        this.priceList[i].UseCompatibleStateImageBehavior = false;
        //        this.priceList[i].View = View.Details;
        //        this.priceList[i].Dock = DockStyle.Fill;
        //        this.priceList[i].GridLines = false;
        //        this.priceList[i].HeaderStyle = ColumnHeaderStyle.Nonclickable;
        //        this.priceList[i].HideSelection = false;
        //        // Создание колонок ListView
        //        this.priceList[i].Columns.Add(new ColumnHeader());
        //        this.priceList[i].Columns[0].Text = "";
        //        this.priceList[i].Columns[0].Width = 100;
        //        this.priceList[i].Columns.Add(new ColumnHeader());
        //        this.priceList[i].Columns[1].Text = product[i];
        //        this.priceList[i].Columns[1].Width = 600;


        //        // Создание списоков изображений для строк listView
        //        imageList[i] = new ImageList();
        //        // устанавливаем размер изображений
        //        imageList[i].ImageSize = new Size(100, 100);
        //        // заполняем список изображениями
        //        try
        //        {
        //            string pathToImage = Application.StartupPath + @"\PriceList" + @"\" + categoria + @"\" + product[i] + @".jpg";
        //            imageList[i].Images.Add(new Bitmap(pathToImage));

        //        }
        //        catch (Exception) { MessageBox.Show("Название файла картинки не совпадает с названием продукта"); }
        //        // устанавливаем в listView1 список изображений imageList
        //        priceList[i].SmallImageList = imageList[i];
        //        // добавляем строки в listView1
        //        for (int j = 0; j < 1; j++)
        //        {
        //            // создадим объект ListViewItem (строку) для listView
        //            listViewItem[i] = new ListViewItem();

        //            listViewItem[i].SubItems.Add(description[i]);
        //            // индекс изображения из imageList для данной строки listViewItem
        //            listViewItem[i].ImageIndex = 0;

        //            // добавляем созданный элемент listViewItem (строку) в listView1
        //            priceList[i].Items.Add(listViewItem[i]);
        //        }
        //    }
        //    return priceList;
        //}

        //// 
        //// tableLayoutPanel
        //// 
        //public TableLayoutPanel CreateTableLayoutPanel(int countRow)
        //{
        //    menu = new TableLayoutPanel();
        //    this.menu.ColumnCount = 2;
        //    this.menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
        //    this.menu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
        //    this.menu.Location = new Point(70, 150);
        //    this.menu.Name = "tableLayoutPanel";
        //    this.menu.RowCount = countRow;
        //    for (int i = 0; i < countRow; i++)
        //        this.menu.RowStyles.Add(new RowStyle(SizeType.Absolute, 150f));
        //    this.menu.Size = new Size(1000, 150 * countRow);
        //    this.menu.TabIndex = 0;
        //    this.menu.BackColor = Color.Transparent;
        //    return menu;
        //}
    }
}
