 using Newtonsoft.Json.Linq; 
namespace miproyecto3;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
  
   async  private void SearchCurrency()
    {  
      
            //Define your baseUrl
            
            string baseUrl = "https://v6.exchangerate-api.com/v6/b1c79e722136aa3fa32e5909/latest/EUR";
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
                              JToken jToken = JObject.Parse(data)["conversion_rates"];
                              int length = jToken.Count();
                             
                              //for (int i = 0; i < length; i++)
                              //{
                                
                                
                               
                               //JToken jToken2 = JObject.Parse(data)["products"][0]["stores"][i];
                               String EUR = jToken["EUR"].ToString();
                               String GBP = jToken["GBP"].ToString();
                                 float f1 = float. Parse(EUR);
                                 label4.Text = "Currency \n\n";
                                 label4.Text += "1 EUR: "+f1.ToString()+"€\n";
                                 label4.Text += "1 GBP: "+GBP+"€\n";


                             
                             // }
             

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

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Text = "Form1";

        Font font = new Font("Arial", 12);
        
        btn1 = new Button();
        btn1.Text = "Search";
        btn1.Name = "btn1";
        btn1.Location = new Point(10, 80);
        btn1.Size = new Size(100, 30);

        
        textBox1 = new TextBox();
        textBox1.Location = new Point(10,50);
        textBox1.Size = new Size(120,20);
        textBox1.Name = "textBox1";
        textBox1.Text = "PCV1020";
      

        richTextBox1 = new RichTextBox();
        richTextBox1.Location = new Point(250,50);
        richTextBox1.Size = new Size(400,400);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Text = "";
        richTextBox1.Multiline = true;
        
        richTextBox1.AcceptsTab = true;  
        richTextBox1.WordWrap = true;
        richTextBox1.Font =font;



        label2 = new Label();
        label2.Text = "Enter Euro4x4parts reference number:";
        label2.Location = new Point(10, 20);
        label2.Size = new Size(200, 20);
        label2.Name = "label2";
        
       

        label3 = new Label();
        
        label3.Location = new Point(250, 20);
        label3.Size = new Size(300, 20);
        label3.Name = "label3";


        label4 = new Label();
        
        label4.Location = new Point(10, 200);
        label4.Size = new Size(200, 200);
        label4.Name = "label4";
        label4.BackColor = Color.Blue;
        label4.ForeColor = Color.White;
        
        label4.Font =font;



        
       
        this.Controls.Add(btn1);
        this.Controls.Add(textBox1);
        this.Controls.Add(label2);
        this.Controls.Add(label3);
        this.Controls.Add(label4);
        this.Controls.Add(richTextBox1);
    }

    private Button btn1;
    private TextBox textBox1;
    private Label label2;
    private Label label3;
    private Label label4;
    private RichTextBox richTextBox1;
    #endregion
}
