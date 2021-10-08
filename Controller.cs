using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassaSystem
{
    public class Controller
    {
        //Skapar alla nödvänding kopplingar och BindingList
        Filhantering fh;
        BindingList<Product> productListInvetory = new BindingList<Product>();
        Random randomTal = new Random();

        public Controller(Filhantering filhantering)
        {
            fh = filhantering;
            fh.ControllerConnection(this);
        }

        public string generateIDNumber()
        {
            int idNumber = randomTal.Next(1, 100000);
            string idNumberString = idNumber.ToString();

            return idNumberString;
        }
       
        public BindingList<Product> GetProductList()
        {
            return productListInvetory;
        }

        /*Hämtar all data från filen och spilltar den med hjälp av Split(). Split tar emot all data och delar upp det med separatorn ",". Jag skapar
         * en ny instans av producten och använder den för att fylla den med data från filen. Att göra de "manuellt" rad för rad som jag gör nedan kan man
         * nog endast göra vid mindre filer så som den vi jobbar med i denna uppgift. Men har man t.ex. en stor fil och inte vet vilket index det olika värden
         * ligger på så får man lösa det på annat sätt. Inspiration från koden nedan hittade jag på https://stackoverflow.com/questions/5282999/reading-csv-file-and-storing-values-into-an-array
        */
        public void loadCsvFile(string data)
        {
           
            string[] newData = data.Split(',');
            Product newProduct = new Product();

            newProduct.ID = newData[0];
            newProduct.Amount = newData[1];
            newProduct.Name = newData[2];
            newProduct.Price = newData[3];
            newProduct.Type = newData[4];
            newProduct.Author = newData[5];
            newProduct.Format = newData[6];
            newProduct.Genre = newData[7];
            newProduct.Language = newData[8];
            newProduct.Platform = newData[9];
            newProduct.Playtime = newData[10];

            productListInvetory.Add(newProduct);
        }
        //Tar emot värden från View och skapar en instans samt fyller den med värdena. 
        //Lägger sedan in det i productList och skriver till filen
        public void NewProductToFile(string amount, string name, string price, string type, string genre, string format, string author, string language, string platform, string playtime)
        {

            string pAmount = amount;
            string pID = generateIDNumber();
            string pName = name;
            string pPrice = price;
            string pType = type;
            string pAuthor = author;
            string pGenre = genre;
            string pFormat = format;
            string pLanguage = language;
            string pPlatform = platform;
            string pPlaytime = playtime;

            Product product = new Product();

            product.Amount = pAmount;
            product.ID = pID;
            product.Name = pName;
            product.Price = pPrice;
            product.Type = pType;
            product.Genre = pGenre;
            product.Author = pAuthor;
            product.Format = pFormat;
            product.Language = pLanguage;
            product.Playtime = pPlaytime;
            product.Platform = pPlatform;

            productListInvetory.Add(product);
            fh.WriteToFile(productListInvetory);
        }
        //Uppdaterar amount samt skriver till filen.
        public void UpdateAmount(string idOfSelectedCell, int newAmount)
        {
            string idOfProduct = idOfSelectedCell;
            Product updateProd = productListInvetory.Single(prod => prod.ID == idOfProduct);
            updateProd.Amount = newAmount.ToString();
            fh.WriteToFile(productListInvetory);
        }
        //Funktion som anropas när användaren vill ta bort en produkt som är selected.
        public void DeleteProduct(string idOfSelectedCell)
        {
            string idOfProduct = idOfSelectedCell;
            Product prodToDelete = productListInvetory.Single(prod => prod.ID == idOfProduct);
            productListInvetory.Remove(prodToDelete);
            fh.WriteToFile(productListInvetory);
        }
    }
}




