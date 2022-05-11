  
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
  
            

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        btn1 = new Button();
        btn1.Text = "Search";
        btn1.Name = "btn1";
        btn1.Location = new Point(10, 60);
        btn1.Size = new Size(100, 30);

        /*ListView1 = new ListView();
       
        ListView1.Name = "ListView1";
        ListView1.Location = new Point(200, 10);
        ListView1.Size = new Size(600, 400);*/
        textBox1 = new TextBox();
        textBox1.Location = new Point(10,30);
        textBox1.Size = new Size(120,20);
        textBox1.Name = "textBox1";
        textBox1.Text = "5050063181944";
        /*textBox1.Multiline = true;
        textBox1.ScrollBars = ScrollBars.Vertical;
        textBox1.AcceptsReturn = true;
    // Allow the TAB key to be entered in the TextBox control.
        textBox1.AcceptsTab = true;
    // Set WordWrap to true to allow text to wrap to the next line.
        textBox1.WordWrap = true;*/


        label2 = new Label();
        label2.Text = "Enter Euro4x4parts reference number:";
        label2.Location = new Point(10, 10);
        label2.Size = new Size(200, 20);
        label2.Name = "label2";
        
        
        
        label1 = new Label();
        //label1.Text = "Enter Euro4x4parts reference number:";
        label1.Location = new Point(250, 20);
        label1.Size = new Size(300, 200);
        label1.Name = "label1";



        
       // btn1.Click += new EventHandler(GetPokemon());
        this.Controls.Add(btn1);
        //this.Controls.Add(ListView1);
        this.Controls.Add(textBox1);
        this.Controls.Add(label1);
        this.Controls.Add(label2);
    }

    private Button btn1;
    //private ListView ListView1;

    private TextBox textBox1;

    private Label label1;
    private Label label2;

    #endregion
}
