using System;
using System.ComponentModel;

using System.Linq;
using System.Windows.Forms;

namespace KassaSystem
{
    public partial class View : Form
    {
        //Skapar alla nödvänding kopplingar och BindingList
        Filhantering fh;
        Controller co;
        BindingList<Product> cartList = new BindingList<Product>();
        BindingList<Product> productListRegister = new BindingList<Product>();

        //Konstruktor
        public View(Controller c, Filhantering f)
        {
            fh = f;
            co = c;
            InitializeComponent();
            dataGridStock.DataSource = co.GetProductList();
            dataGridCartList.DataSource = getCartList();
            FillList();
        }
        public BindingList<Product> getCartList()
        {
            return cartList;
        }
        public void FillList()
        {
            productListRegister = co.GetProductList();
            dataGridViewRegister.DataSource = productListRegister;
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            double num;
            string name = ProdName.Text;
            string price = ProdPrice.Text;
            string type = ProdType.Text;
            string author = ProdAuthor.Text;
            string genre = ProdGenre.Text;
            string format = ProdFormat.Text;
            string language = ProdLanguage.Text;
            string platform = ProdPlatform.Text;
            string playtime = ProdPlaytime.Text;
            string amount = AmountOfProd.Text;
            bool checkForNumPrice = double.TryParse(price, out num);
            bool checkForNumPlaytime = double.TryParse(playtime, out num);
            const string title = "Warning!";

            //Kontroller för textfält som användaren fyller i. Är allt okej så anropar jag NewProductToFile i controller.
            try
            {
                if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(type) || String.IsNullOrEmpty(price))
                {
                    MessageBox.Show("Name, type and price cannot be blank", title);
                    return;
                }
                else if (!checkForNumPrice)
                {
                    MessageBox.Show("You can only enter digits in price and playtime field", title);
                }
                else if (!String.IsNullOrEmpty(playtime))
                {
                    if (!checkForNumPlaytime)
                    {
                        MessageBox.Show("You can only enter digits in price and playtime field", title);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (Convert.ToInt32(price) < 1)
                {
                    MessageBox.Show("Price needs to be above 0", title);
                }
                else
                {
                    co.NewProductToFile(amount, name, price, type, genre, format, author, language, playtime, platform);
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //Läser från filen när användaren startar programmet
        private void View_Load(object sender, EventArgs e)
        {
            fh.ReadFromFile();
        }
        //Kollar så att amount-snurren värdet inte blir mindre än noll när användaren skriver in tal. 
        //Denna kontroll kan vara onödig då jag har satt minimum-värde till "0"
        private void AmountOfProd_ValueChanged(object sender, EventArgs e)
        {
            double number = Convert.ToInt32(Math.Round(AmountOfProd.Value, 0));
            if (number < 0)
            {
                DialogResult result = MessageBox.Show("Amount cannot be less than 1", "Warnig!", MessageBoxButtons.OK);
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            /*Här tittar jag vilken rad som är selectad(highlightad i UI) av användaren. Ifall användaren inte har valt en rad så 
            får användaren ett felmeddelande. Inspiration har jag fått från Microsoft Dokumenatation. Koden använder jag flera gånger i mitt program.
            https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewelementstates?view=net-5.0
            */
            DataGridViewRow newColumn =
            dataGridStock.Rows.GetRowCount(
            DataGridViewElementStates.Selected) == 1 ?
            dataGridStock.SelectedRows[0] : null;

            if (newColumn == null)
            {
                MessageBox.Show("You need to choose one column to delete the product.",
                    "Warning", MessageBoxButtons.OK);
            }
            if(newColumn.Cells["Amount"].Value.ToString() == "0")
            {
                string idOfCell = newColumn.Cells["ID"].Value.ToString();
                co.DeleteProduct(idOfCell);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?.",
                    "Warning", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    /*
                     * Jag bestämde mig tidigt i arbetet att försöka komma åt de raderna som användaren klickar på då jag antog att det skulle
                     * vara lättast. Här går jag igenom varje Row i en foreach och sparar det som en row. Därefter tittar om raden är selected 
                     * med hjälp av row.Selected == true.
                     * Inspiration ifrån foreach-loopen fick jag från StackOverFlow.
                     * https://stackoverflow.com/questions/5280655/get-the-selected-rows-from-a-datagridview
                     */
                    foreach (DataGridViewRow row in dataGridStock.Rows)
                    {
                        if (row.Selected == true)
                        {
                            //Hämtar ut ID av den valda cellen. Detta gör jag för att kunna använda den i senare funktion.
                            string idOfSelectedCell = row.Cells["ID"].Value.ToString();
                            co.DeleteProduct(idOfSelectedCell);
                        }
                    }
                }
            }
        }
        //Funktion för att uppdatera antalet i lagervyn.
        private void updateAmountBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newColumn =
            dataGridStock.Rows.GetRowCount(
            DataGridViewElementStates.Selected) == 1 ?
            dataGridStock.SelectedRows[0] : null;

            if (newColumn == null)
            {
                MessageBox.Show("You need to choose one column to update the amount.",
                                "Warning", MessageBoxButtons.OK);
            }
            else
            {
                foreach (DataGridViewRow row in dataGridStock.Rows)
                {
                    if (row.Selected == true)
                    {
                        //Deklarerar nödvändiga variablar för att kunna skicka med till co.UpdateAmount.
                        try
                        {
                            int inputAmount = Convert.ToInt32(newAmountOfProd.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Only digits is allowed here");
                        }
                        
                    }
                }
            }
        }
        //Funktion som lägger till en produkt i CartListView.
        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRegister.SelectedRows)
            {
                string pAmount = row.Cells["Amount"].Value.ToString();
                string pID = row.Cells["ID"].Value.ToString();
                string pName = row.Cells["Name"].Value.ToString();
                string pPrice = row.Cells["Price"].Value.ToString();
                string pType = row.Cells["Type"].Value.ToString();
                string pAuthor = row.Cells["Author"].Value.ToString();
                string pGenre = row.Cells["Genre"].Value.ToString();
                string pFormat = row.Cells["Format"].Value.ToString();
                string pLanguage = row.Cells["Language"].Value.ToString();
                string pPlatform = row.Cells["Platform"].Value.ToString();
                string pPlaytime = row.Cells["Playtime"].Value.ToString();

                int checkForZero = Convert.ToInt32(pAmount);
                int checkForSameProduct = Convert.ToInt32(pID);

                /*Här använder jag mig av en Lambda expression för att kunna söka ut producten i CartBindingList. Lambda funktionen
                * tittar igenom CartBindingList för att hitta matchande produktID (som jag skickade med som parameter). Jag använder mig av Lambda-Expression flera gånger.
                *Jag läste om Lambda på https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions 
                *Single metoden använder jag för att endast få tillbaka en product. Här läste jag om Single:
                *https://www.dotnetperls.com/single
                *https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.single?view=net-5.0
                */
                Product checkProdInCart;
                Product checkProdInRegister;
                foreach (Product product in cartList)
                {
                    checkProdInCart = cartList.Single(p => p.ID == product.ID);
                    checkProdInRegister = productListRegister.Single(p => p.ID == product.ID);
                    if (checkProdInCart.ID == checkProdInRegister.ID)
                    {
                        MessageBox.Show("You already have this cart in item. Press on the '+' button if you wan to increase amount", "Warning!");
                        return;
                    }
                }
                {

                }
                if (checkForZero == 0)
                {
                    MessageBox.Show("This item is out of stock");
                }
                else
                {
                    //Anropar addToCart och skickar med nödvändiga variablar.
                    AddToCart(pAmount, pID, pName, pPrice, pType, pAuthor, pGenre, pFormat, pLanguage, pPlatform, pPlaytime);
                }
            }
        }
        public void AddToCart(string pAmount, string pID, string pName, string pPrice, string pType, string pAuthor, string pGenre, string pFormat, string pLanguage, string pPlatform, string pPlaytime)
        {
            //Skapar en instans av klassen Product och ger den de 
            //variablar som skickades med i ButtonAddToCart_Click() funktionen.
            //Input är så att amount visar en etta i CartListView

            int input = 1;
            Product productInCart = new Product();

            productInCart.Amount = input.ToString();
            productInCart.ID = pID;
            productInCart.Name = pName;
            productInCart.Price = pPrice;
            productInCart.Type = pType;
            productInCart.Author = pAuthor;
            productInCart.Genre = pGenre;
            productInCart.Format = pFormat;
            productInCart.Language = pLanguage;
            productInCart.Platform = pPlatform;
            productInCart.Playtime = pPlaytime;

            cartList.Add(productInCart);
            UpdateView();
        }
        //Rensar carten och anropar UpdateView()
        private void clearCartButton_Click(object sender, EventArgs e)
        {
            dataGridCartList.DataSource = null;
            cartList.Clear();
            dataGridCartList.Columns.Clear();
            UpdateView();
        }
        //Söker ut ID till vald produkt och anropar RemoveOneAmount() samt UpdateView()
        private void DecreaseProdInCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCartList.SelectedRows)
            {
                string pID = row.Cells["ID"].Value.ToString();
                RemoveOneAmount(pID);
                UpdateView();
                
            }
        }
        private void ProceedToCheckOutButton_Click(object sender, EventArgs e)
        {
            if (cartList.Count == 0)
            {
                MessageBox.Show("Your cart is empty");
            }
            else
            {
                FinishPurchase(cartList, productListRegister);
            }
        }
        //Söker ut ID till vald produkt och anropar AddOneAmount() samt UpdateView().
        private void IncrementProductInCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRegister.SelectedRows)
            {
                string oldvalue = row.Cells["Amount"].Value.ToString();
                int oldValue = Convert.ToInt32(oldvalue);

                foreach (DataGridViewRow row1 in dataGridCartList.SelectedRows)
                {
                    string pID = row1.Cells["ID"].Value.ToString();
                    string pAmount = row1.Cells["Amount"].Value.ToString();
                    int newValue = Convert.ToInt32(pAmount);

                    if (newValue == oldValue)
                    {
                        MessageBox.Show("There are no more of this product in stock");
                        return;
                    }
                    else
                    {
                        AddOneAmount(pID);
                        UpdateView();
                    }
                }
            }
        }
        //Tar bort ett antal från produkten i CartListView. Hämtar produkt ID från CartListView och ändrar amount.
        public void RemoveOneAmount(string idOfSelectedCell)
        {
            string idOfProduct = idOfSelectedCell;
            /*Här använder jag mig av en Lambda expression för att kunna söka ut producten i CartBindingList. Lambda funktionen
             * tittar igenom CartBindingList för att hitta matchande produktID (som jag skickade med som parameter).
             *Jag läste om Lambda på https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions 
             *Single metoden använder jag för att endast få tillbaka en product. Här läste jag om Single:
             *https://www.dotnetperls.com/single
             *https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.single?view=net-5.0
             *Här är en stackoverflow tråd som jag drog nytta av. Specifikt det sista svaret skriver av användaren John Wu.
             *https://stackoverflow.com/questions/42561849/use-lambda-expression-to-find-all-objects-with-matching-id
            */
            Product updateProd = cartList.Single(prod => prod.ID == idOfProduct);
            int oldAmount = Convert.ToInt32(updateProd.Amount);
            int newAmount = oldAmount - 1;
           
            if (newAmount == 0)
            {
                RemoveItemFromCart(idOfProduct);
            }
            else
            {
                MessageBox.Show("Remove the item instead", "Warning!", MessageBoxButtons.OK);
            }
        }
        //Ökar antalet med 1 i vald produkt som är selectad i CartListView. 
        //Hämtar produkt ID från getCartList och ändrar amount.
        public void AddOneAmount(string idOfSelectedCell)
        {
            string idOfProduct = idOfSelectedCell;
            Product updateProd = cartList.Single(prod => prod.ID == idOfProduct);
            int oldAmount = Convert.ToInt32(updateProd.Amount);
            int newAmount = oldAmount + 1;
            updateProd.Amount = newAmount.ToString();
        }
        //Tar port product som matchar med inkommnade ID.
        public void RemoveItemFromCart(string idOfProduct)
        {
            Product productToDelete = cartList.Single(prod => prod.ID == idOfProduct);
            cartList.Remove(productToDelete);
        }
        //Anropas varje gång de sker en ändring i Product så att de även syns i vyn.
        public void UpdateView()
        {
            dataGridCartList.DataSource = null;
            dataGridViewRegister.DataSource = productListRegister;
            dataGridCartList.DataSource = getCartList();
        }
        private void dataGridCartList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Gömmer de kolumner som inte är viktiga i CartListView.
            dataGridCartList.Columns["Genre"].Visible = false;
            dataGridCartList.Columns["Author"].Visible = false;
            dataGridCartList.Columns["Format"].Visible = false;
            dataGridCartList.Columns["Language"].Visible = false;
            dataGridCartList.Columns["Platform"].Visible = false;
            dataGridCartList.Columns["Playtime"].Visible = false;
            dataGridCartList.AutoResizeColumns();
        }
        //Tar emot båda listorna som en parameter. Skapar två stycken instanser av Product för att 
        //kunna jämför ID på båda produkterna för att se vilken produkt som blivit "köpt". Denna funktion
        //tar inte bort exakt bort produkten, utan sätter amount till noll.
        public void FinishPurchase(BindingList<Product> cartList, BindingList<Product> productListRegister)
        {
            Product deleteProduct;
            int oldAmount1, oldAmount2, newAmount;

            foreach (Product product in cartList)
            {
                deleteProduct = cartList.Single(p => p.ID == product.ID);
                oldAmount1 = Convert.ToInt32(deleteProduct.Amount);
                Product prod = productListRegister.Single(p => p.ID == product.ID);
                oldAmount2 = Convert.ToInt32(deleteProduct.Amount);
                newAmount = oldAmount1 - oldAmount2;
                prod.Amount = newAmount.ToString();
            }
            cartList.Clear();
            fh.WriteToFile(productListRegister);
        }
    }
}

