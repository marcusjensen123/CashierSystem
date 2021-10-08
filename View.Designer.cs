
namespace KassaSystem
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Page = new System.Windows.Forms.TabControl();
            this.RegisterPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.minusOneInCart = new System.Windows.Forms.Button();
            this.dataGridCartList = new System.Windows.Forms.DataGridView();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.ProceedToCheckoutButton = new System.Windows.Forms.Button();
            this.ButtonAddToCart = new System.Windows.Forms.Button();
            this.dataGridViewRegister = new System.Windows.Forms.DataGridView();
            this.StockPage = new System.Windows.Forms.TabPage();
            this.UpdateAmountBox = new System.Windows.Forms.GroupBox();
            this.newAmountOfProd = new System.Windows.Forms.TextBox();
            this.updateAmountBtn = new System.Windows.Forms.Button();
            this.newAmountOfProdText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.DeleteProdGroup = new System.Windows.Forms.GroupBox();
            this.DeleteProductBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addNewProductBox = new System.Windows.Forms.GroupBox();
            this.AmountText = new System.Windows.Forms.Label();
            this.AmountOfProd = new System.Windows.Forms.NumericUpDown();
            this.ProdPlaytimeText = new System.Windows.Forms.Label();
            this.ProdPlaytime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdPlatform = new System.Windows.Forms.TextBox();
            this.clearProductFieldBtn = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProdLanguage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdFormat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdGenre = new System.Windows.Forms.TextBox();
            this.ProdAuthorText = new System.Windows.Forms.Label();
            this.ProdAuthor = new System.Windows.Forms.TextBox();
            this.ProdTypeText = new System.Windows.Forms.Label();
            this.ProdType = new System.Windows.Forms.TextBox();
            this.ProdPriceText = new System.Windows.Forms.Label();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdNameText = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.Page.SuspendLayout();
            this.RegisterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegister)).BeginInit();
            this.StockPage.SuspendLayout();
            this.UpdateAmountBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            this.DeleteProdGroup.SuspendLayout();
            this.addNewProductBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfProd)).BeginInit();
            this.SuspendLayout();
            // 
            // Page
            // 
            this.Page.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Page.Controls.Add(this.RegisterPage);
            this.Page.Controls.Add(this.StockPage);
            this.Page.Location = new System.Drawing.Point(12, 12);
            this.Page.Name = "Page";
            this.Page.SelectedIndex = 0;
            this.Page.Size = new System.Drawing.Size(990, 580);
            this.Page.TabIndex = 0;
            // 
            // RegisterPage
            // 
            this.RegisterPage.Controls.Add(this.button1);
            this.RegisterPage.Controls.Add(this.minusOneInCart);
            this.RegisterPage.Controls.Add(this.dataGridCartList);
            this.RegisterPage.Controls.Add(this.clearCartButton);
            this.RegisterPage.Controls.Add(this.ProceedToCheckoutButton);
            this.RegisterPage.Controls.Add(this.ButtonAddToCart);
            this.RegisterPage.Controls.Add(this.dataGridViewRegister);
            this.RegisterPage.Location = new System.Drawing.Point(4, 22);
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterPage.Size = new System.Drawing.Size(982, 554);
            this.RegisterPage.TabIndex = 0;
            this.RegisterPage.Text = "Register";
            this.RegisterPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(685, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IncrementProductInCart_Click);
            // 
            // minusOneInCart
            // 
            this.minusOneInCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusOneInCart.Location = new System.Drawing.Point(571, 384);
            this.minusOneInCart.Name = "minusOneInCart";
            this.minusOneInCart.Size = new System.Drawing.Size(108, 49);
            this.minusOneInCart.TabIndex = 9;
            this.minusOneInCart.Text = "-";
            this.minusOneInCart.UseVisualStyleBackColor = true;
            this.minusOneInCart.Click += new System.EventHandler(this.DecreaseProdInCart_Click);
            // 
            // dataGridCartList
            // 
            this.dataGridCartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCartList.Location = new System.Drawing.Point(571, 7);
            this.dataGridCartList.MultiSelect = false;
            this.dataGridCartList.Name = "dataGridCartList";
            this.dataGridCartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCartList.Size = new System.Drawing.Size(333, 371);
            this.dataGridCartList.TabIndex = 8;
            this.dataGridCartList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridCartList_DataBindingComplete);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(220, 439);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(227, 73);
            this.clearCartButton.TabIndex = 4;
            this.clearCartButton.Text = "Clear cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // ProceedToCheckoutButton
            // 
            this.ProceedToCheckoutButton.Location = new System.Drawing.Point(795, 384);
            this.ProceedToCheckoutButton.Name = "ProceedToCheckoutButton";
            this.ProceedToCheckoutButton.Size = new System.Drawing.Size(109, 49);
            this.ProceedToCheckoutButton.TabIndex = 3;
            this.ProceedToCheckoutButton.Text = "Proceed to checkout";
            this.ProceedToCheckoutButton.UseVisualStyleBackColor = true;
            this.ProceedToCheckoutButton.Click += new System.EventHandler(this.ProceedToCheckOutButton_Click);
            // 
            // ButtonAddToCart
            // 
            this.ButtonAddToCart.Location = new System.Drawing.Point(7, 439);
            this.ButtonAddToCart.Name = "ButtonAddToCart";
            this.ButtonAddToCart.Size = new System.Drawing.Size(207, 73);
            this.ButtonAddToCart.TabIndex = 2;
            this.ButtonAddToCart.Text = "Add to cart";
            this.ButtonAddToCart.UseVisualStyleBackColor = true;
            this.ButtonAddToCart.Click += new System.EventHandler(this.ButtonAddToCart_Click);
            // 
            // dataGridViewRegister
            // 
            this.dataGridViewRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegister.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewRegister.MultiSelect = false;
            this.dataGridViewRegister.Name = "dataGridViewRegister";
            this.dataGridViewRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegister.Size = new System.Drawing.Size(440, 426);
            this.dataGridViewRegister.TabIndex = 0;
            // 
            // StockPage
            // 
            this.StockPage.Controls.Add(this.UpdateAmountBox);
            this.StockPage.Controls.Add(this.dataGridStock);
            this.StockPage.Controls.Add(this.DeleteProdGroup);
            this.StockPage.Controls.Add(this.addNewProductBox);
            this.StockPage.Location = new System.Drawing.Point(4, 22);
            this.StockPage.Name = "StockPage";
            this.StockPage.Padding = new System.Windows.Forms.Padding(3);
            this.StockPage.Size = new System.Drawing.Size(982, 554);
            this.StockPage.TabIndex = 1;
            this.StockPage.Text = "Stock";
            this.StockPage.UseVisualStyleBackColor = true;
            // 
            // UpdateAmountBox
            // 
            this.UpdateAmountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAmountBox.Controls.Add(this.newAmountOfProd);
            this.UpdateAmountBox.Controls.Add(this.updateAmountBtn);
            this.UpdateAmountBox.Controls.Add(this.newAmountOfProdText);
            this.UpdateAmountBox.Controls.Add(this.label7);
            this.UpdateAmountBox.Location = new System.Drawing.Point(558, 418);
            this.UpdateAmountBox.Name = "UpdateAmountBox";
            this.UpdateAmountBox.Size = new System.Drawing.Size(418, 88);
            this.UpdateAmountBox.TabIndex = 4;
            this.UpdateAmountBox.TabStop = false;
            this.UpdateAmountBox.Text = "Update Product Amount";
            // 
            // newAmountOfProd
            // 
            this.newAmountOfProd.Location = new System.Drawing.Point(66, 51);
            this.newAmountOfProd.Name = "newAmountOfProd";
            this.newAmountOfProd.Size = new System.Drawing.Size(43, 20);
            this.newAmountOfProd.TabIndex = 27;
            // 
            // updateAmountBtn
            // 
            this.updateAmountBtn.Location = new System.Drawing.Point(127, 49);
            this.updateAmountBtn.Name = "updateAmountBtn";
            this.updateAmountBtn.Size = new System.Drawing.Size(88, 23);
            this.updateAmountBtn.TabIndex = 27;
            this.updateAmountBtn.Text = "Update";
            this.updateAmountBtn.UseVisualStyleBackColor = true;
            this.updateAmountBtn.Click += new System.EventHandler(this.updateAmountBtn_Click);
            // 
            // newAmountOfProdText
            // 
            this.newAmountOfProdText.AutoSize = true;
            this.newAmountOfProdText.Location = new System.Drawing.Point(10, 54);
            this.newAmountOfProdText.Name = "newAmountOfProdText";
            this.newAmountOfProdText.Size = new System.Drawing.Size(50, 13);
            this.newAmountOfProdText.TabIndex = 25;
            this.newAmountOfProdText.Text = "Amount*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Select the item in the list and update the amount below";
            // 
            // dataGridStock
            // 
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Location = new System.Drawing.Point(6, 6);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.Size = new System.Drawing.Size(546, 500);
            this.dataGridStock.TabIndex = 3;
            // 
            // DeleteProdGroup
            // 
            this.DeleteProdGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProdGroup.Controls.Add(this.DeleteProductBtn);
            this.DeleteProdGroup.Controls.Add(this.label4);
            this.DeleteProdGroup.Location = new System.Drawing.Point(558, 315);
            this.DeleteProdGroup.Name = "DeleteProdGroup";
            this.DeleteProdGroup.Size = new System.Drawing.Size(418, 97);
            this.DeleteProdGroup.TabIndex = 2;
            this.DeleteProdGroup.TabStop = false;
            this.DeleteProdGroup.Text = "Delete product";
            // 
            // DeleteProductBtn
            // 
            this.DeleteProductBtn.Location = new System.Drawing.Point(12, 46);
            this.DeleteProductBtn.Name = "DeleteProductBtn";
            this.DeleteProductBtn.Size = new System.Drawing.Size(88, 23);
            this.DeleteProductBtn.TabIndex = 26;
            this.DeleteProductBtn.Text = "Delete Product";
            this.DeleteProductBtn.UseVisualStyleBackColor = true;
            this.DeleteProductBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Please select which product you want to delete and press the button below";
            // 
            // addNewProductBox
            // 
            this.addNewProductBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewProductBox.Controls.Add(this.AmountText);
            this.addNewProductBox.Controls.Add(this.AmountOfProd);
            this.addNewProductBox.Controls.Add(this.ProdPlaytimeText);
            this.addNewProductBox.Controls.Add(this.ProdPlaytime);
            this.addNewProductBox.Controls.Add(this.label5);
            this.addNewProductBox.Controls.Add(this.ProdPlatform);
            this.addNewProductBox.Controls.Add(this.clearProductFieldBtn);
            this.addNewProductBox.Controls.Add(this.btnAddNewProduct);
            this.addNewProductBox.Controls.Add(this.label1);
            this.addNewProductBox.Controls.Add(this.ProdLanguage);
            this.addNewProductBox.Controls.Add(this.label2);
            this.addNewProductBox.Controls.Add(this.ProdFormat);
            this.addNewProductBox.Controls.Add(this.label3);
            this.addNewProductBox.Controls.Add(this.ProdGenre);
            this.addNewProductBox.Controls.Add(this.ProdAuthorText);
            this.addNewProductBox.Controls.Add(this.ProdAuthor);
            this.addNewProductBox.Controls.Add(this.ProdTypeText);
            this.addNewProductBox.Controls.Add(this.ProdType);
            this.addNewProductBox.Controls.Add(this.ProdPriceText);
            this.addNewProductBox.Controls.Add(this.ProdPrice);
            this.addNewProductBox.Controls.Add(this.ProdNameText);
            this.addNewProductBox.Controls.Add(this.ProdName);
            this.addNewProductBox.Location = new System.Drawing.Point(558, 6);
            this.addNewProductBox.Name = "addNewProductBox";
            this.addNewProductBox.Size = new System.Drawing.Size(424, 303);
            this.addNewProductBox.TabIndex = 1;
            this.addNewProductBox.TabStop = false;
            this.addNewProductBox.Text = "Add new product";
            // 
            // AmountText
            // 
            this.AmountText.AutoSize = true;
            this.AmountText.Location = new System.Drawing.Point(10, 270);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(50, 13);
            this.AmountText.TabIndex = 23;
            this.AmountText.Text = "Amount*:";
            // 
            // AmountOfProd
            // 
            this.AmountOfProd.Location = new System.Drawing.Point(77, 268);
            this.AmountOfProd.Name = "AmountOfProd";
            this.AmountOfProd.Size = new System.Drawing.Size(120, 20);
            this.AmountOfProd.TabIndex = 22;
            this.AmountOfProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountOfProd.ValueChanged += new System.EventHandler(this.AmountOfProd_ValueChanged);
            // 
            // ProdPlaytimeText
            // 
            this.ProdPlaytimeText.AutoSize = true;
            this.ProdPlaytimeText.Location = new System.Drawing.Point(10, 242);
            this.ProdPlaytimeText.Name = "ProdPlaytimeText";
            this.ProdPlaytimeText.Size = new System.Drawing.Size(49, 13);
            this.ProdPlaytimeText.TabIndex = 21;
            this.ProdPlaytimeText.Text = "Playtime:";
            // 
            // ProdPlaytime
            // 
            this.ProdPlaytime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdPlaytime.Location = new System.Drawing.Point(77, 239);
            this.ProdPlaytime.Name = "ProdPlaytime";
            this.ProdPlaytime.Size = new System.Drawing.Size(344, 20);
            this.ProdPlaytime.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Platform:";
            // 
            // ProdPlatform
            // 
            this.ProdPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdPlatform.Location = new System.Drawing.Point(77, 213);
            this.ProdPlatform.Name = "ProdPlatform";
            this.ProdPlatform.Size = new System.Drawing.Size(344, 20);
            this.ProdPlatform.TabIndex = 18;
            // 
            // clearProductFieldBtn
            // 
            this.clearProductFieldBtn.Location = new System.Drawing.Point(296, 268);
            this.clearProductFieldBtn.Name = "clearProductFieldBtn";
            this.clearProductFieldBtn.Size = new System.Drawing.Size(75, 23);
            this.clearProductFieldBtn.TabIndex = 17;
            this.clearProductFieldBtn.Text = "Clear";
            this.clearProductFieldBtn.UseVisualStyleBackColor = true;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(215, 268);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewProduct.TabIndex = 16;
            this.btnAddNewProduct.Text = "Add Product";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Language:";
            // 
            // ProdLanguage
            // 
            this.ProdLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdLanguage.Location = new System.Drawing.Point(77, 186);
            this.ProdLanguage.Name = "ProdLanguage";
            this.ProdLanguage.Size = new System.Drawing.Size(344, 20);
            this.ProdLanguage.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Format:";
            // 
            // ProdFormat
            // 
            this.ProdFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdFormat.Location = new System.Drawing.Point(77, 160);
            this.ProdFormat.Name = "ProdFormat";
            this.ProdFormat.Size = new System.Drawing.Size(344, 20);
            this.ProdFormat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genre:";
            // 
            // ProdGenre
            // 
            this.ProdGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdGenre.Location = new System.Drawing.Point(77, 134);
            this.ProdGenre.Name = "ProdGenre";
            this.ProdGenre.Size = new System.Drawing.Size(344, 20);
            this.ProdGenre.TabIndex = 10;
            // 
            // ProdAuthorText
            // 
            this.ProdAuthorText.AutoSize = true;
            this.ProdAuthorText.Location = new System.Drawing.Point(10, 110);
            this.ProdAuthorText.Name = "ProdAuthorText";
            this.ProdAuthorText.Size = new System.Drawing.Size(41, 13);
            this.ProdAuthorText.TabIndex = 9;
            this.ProdAuthorText.Text = "Author:";
            // 
            // ProdAuthor
            // 
            this.ProdAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdAuthor.Location = new System.Drawing.Point(77, 107);
            this.ProdAuthor.Name = "ProdAuthor";
            this.ProdAuthor.Size = new System.Drawing.Size(344, 20);
            this.ProdAuthor.TabIndex = 8;
            // 
            // ProdTypeText
            // 
            this.ProdTypeText.AutoSize = true;
            this.ProdTypeText.Location = new System.Drawing.Point(10, 84);
            this.ProdTypeText.Name = "ProdTypeText";
            this.ProdTypeText.Size = new System.Drawing.Size(38, 13);
            this.ProdTypeText.TabIndex = 7;
            this.ProdTypeText.Text = "Type*:";
            // 
            // ProdType
            // 
            this.ProdType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdType.Location = new System.Drawing.Point(77, 81);
            this.ProdType.Name = "ProdType";
            this.ProdType.Size = new System.Drawing.Size(344, 20);
            this.ProdType.TabIndex = 6;
            // 
            // ProdPriceText
            // 
            this.ProdPriceText.AutoSize = true;
            this.ProdPriceText.Location = new System.Drawing.Point(10, 55);
            this.ProdPriceText.Name = "ProdPriceText";
            this.ProdPriceText.Size = new System.Drawing.Size(38, 13);
            this.ProdPriceText.TabIndex = 5;
            this.ProdPriceText.Text = "Price*:";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdPrice.Location = new System.Drawing.Point(77, 55);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(344, 20);
            this.ProdPrice.TabIndex = 4;
            // 
            // ProdNameText
            // 
            this.ProdNameText.AutoSize = true;
            this.ProdNameText.Location = new System.Drawing.Point(10, 29);
            this.ProdNameText.Name = "ProdNameText";
            this.ProdNameText.Size = new System.Drawing.Size(42, 13);
            this.ProdNameText.TabIndex = 3;
            this.ProdNameText.Text = "Name*:";
            // 
            // ProdName
            // 
            this.ProdName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdName.Location = new System.Drawing.Point(77, 29);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(344, 20);
            this.ProdName.TabIndex = 2;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 604);
            this.Controls.Add(this.Page);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            this.Page.ResumeLayout(false);
            this.RegisterPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegister)).EndInit();
            this.StockPage.ResumeLayout(false);
            this.UpdateAmountBox.ResumeLayout(false);
            this.UpdateAmountBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            this.DeleteProdGroup.ResumeLayout(false);
            this.DeleteProdGroup.PerformLayout();
            this.addNewProductBox.ResumeLayout(false);
            this.addNewProductBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Page;
        private System.Windows.Forms.TabPage RegisterPage;
        private System.Windows.Forms.TabPage StockPage;
        private System.Windows.Forms.GroupBox addNewProductBox;
        private System.Windows.Forms.Label ProdAuthorText;
        private System.Windows.Forms.TextBox ProdAuthor;
        private System.Windows.Forms.Label ProdTypeText;
        private System.Windows.Forms.TextBox ProdType;
        private System.Windows.Forms.Label ProdPriceText;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label ProdNameText;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProdLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProdFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProdGenre;
        private System.Windows.Forms.GroupBox DeleteProdGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearProductFieldBtn;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label ProdPlaytimeText;
        private System.Windows.Forms.TextBox ProdPlaytime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProdPlatform;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.Label AmountText;
        private System.Windows.Forms.NumericUpDown AmountOfProd;
        private System.Windows.Forms.Button DeleteProductBtn;
        private System.Windows.Forms.GroupBox UpdateAmountBox;
        private System.Windows.Forms.Label newAmountOfProdText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateAmountBtn;
        private System.Windows.Forms.TextBox newAmountOfProd;
        private System.Windows.Forms.DataGridView dataGridViewRegister;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button ProceedToCheckoutButton;
        private System.Windows.Forms.Button ButtonAddToCart;
        private System.Windows.Forms.DataGridView dataGridCartList;
        private System.Windows.Forms.Button minusOneInCart;
        private System.Windows.Forms.Button button1;
    }
}

