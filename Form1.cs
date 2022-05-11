

using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
namespace miproyecto3;
  
public partial class Form1 : Form
{
    
    public Form1()
    {
        InitializeComponent();
        btn1.Click += Btn1_Click;
        
    }
    async void  Btn1_Click(object sender, EventArgs e)
    {
          
        btn1.Text = "Clicked";
        searchEan ();
       
    }

void searchEan () 
{

    string reference = textBox1.Text;
    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=td2q2019;";
    // Seleccionar todo
    string query = "SELECT distinct europroducts.reference as ref, europroducts.libelleproduit AS description, europroducts.prixeuroht as prix , oemnumbers.legacyArticleId as legacy, articleean.eancode as ean ";
     query += "FROM `eurocrossref` INNER JOIN europroducts ON europroducts.reference=eurocrossref.REF_EURO inner join oemnumbers on oemnumbers.articleNumber=eurocrossref.REF_FRN ";
     query += "inner join articleean on articleean.legacyArticleId=oemnumbers.legacyArticleId WHERE REF_EURO='"+reference+"'";
             

    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
    commandDatabase.CommandTimeout = 60;
    MySqlDataReader reader;

    try
    {
        databaseConnection.Open();
        reader = commandDatabase.ExecuteReader();
         

        // Si se encontraron datos
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                //                   ID                              First name                  Last Name                    Address
                //Console.WriteLine(reader.GetString(0) + " - "  + reader.GetString(2) + " - " + reader.GetString(3)+ " -" + reader.GetString(4));
                GetCodes(reader.GetString(4));
                // Ejemplo para mostrar en el listView1 :
                //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                //var listViewItem = new ListViewItem(row);
                //listView1.Items.Add(listViewItem);
            }
        }
        else
        {
            Console.WriteLine("No se encontro nada");
        }

        databaseConnection.Close();
    }
    catch (Exception ex)
    {
        if (ex.Message is not null){
        Console.WriteLine(ex.Message);
        }
    }
     
}


async void GetCodes (string ean)
{ 
    //string ean=textBox1.Text;
        string api_key = "l1sb4dr7rnng4ftxp41smz54soubg2";
            //Define your baseUrl
            //string baseUrl = "http://pokeapi.co/api/v2/pokemon/";
            string baseUrl = "https://api.barcodelookup.com/v3/products?barcode="+ean+"&formatted=y&key="+api_key;
            //Have your using statements within a try/catch block
            try
            {
                //We will now define your HttpClient with your first using statement which will implements a IDisposable interface.
                using (HttpClient client = new HttpClient())
                {
                    //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                            var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.
                            if (content != null)
                            {
                                //Now log your data object in the console
                             
                              int length = 5;
                              // Console.WriteLine("Length: " + length);
                              for (int i = 0; i < length; i++)
                              {
                                //Console.WriteLine(data);
                                //JToken? jToken = JObject.Parse(data)["products"][0]["stores"][i]["price"];
                                
                               
                               JToken? jToken2 = JObject.Parse(data)["products"][0]["stores"][i];
                               String? country = jToken2["country"].ToString();
                               String? price = jToken2["price"].ToString();

                            
                            label1.Text +=country +"     " +JObject.Parse(data)["products"][0]["stores"][i]["name"]+"  "+price+"\n";
                               


                              //Console.WriteLine(JObject.Parse(data)["products"][0]["stores"][i]["name"]);
                               //Console.WriteLine(JObject.Parse(data)["products"][0]["stores"][i]["country"]);
                                //Console.Write(JObject.Parse(data)["products"][0]["stores"][i]["price"]);
                                 //Console.WriteLine( JObject.Parse(data)["products"][0]["stores"][i]["currency_symbol"]);
                              }
                              //Console.WriteLine("data------------{0}", data);

                             /*   JObject jsonObject = JObject.Parse(data);
//int userId = int.Parse(jsonObject["userId"].ToString());
//int id = int.Parse(jsonObject["id"].ToString());
//string title = jsonObject["title"].ToString();
//bool completed = bool.Parse(jsonObject["completed"].ToString());
                                 Console.WriteLine(jsonObject["results"][0]["description"].ToString());*/

                            }
                            else
                            {
                                Console.WriteLine("NO Data----------");
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                //Console.WriteLine("Exception Hit------------");
               // Console.WriteLine(exception);
            }
         }


}