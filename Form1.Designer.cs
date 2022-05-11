  
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
        this.ClientSize = new System.Drawing.Size(800, 500);
        this.Text = "Form1";

        btn1 = new Button();
        btn1.Text = "Search";
        btn1.Name = "btn1";
        btn1.Location = new Point(10, 60);
        btn1.Size = new Size(100, 30);

        
        textBox1 = new TextBox();
        textBox1.Location = new Point(10,30);
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




        label2 = new Label();
        label2.Text = "Enter Euro4x4parts reference number:";
        label2.Location = new Point(10, 10);
        label2.Size = new Size(200, 20);
        label2.Name = "label2";
        
       

        label3 = new Label();
        
        label3.Location = new Point(250, 20);
        label3.Size = new Size(300, 20);
        label3.Name = "label3";



        
       
        this.Controls.Add(btn1);
        this.Controls.Add(textBox1);
        this.Controls.Add(label2);
        this.Controls.Add(label3);
        this.Controls.Add(richTextBox1);
    }

    private Button btn1;
    private TextBox textBox1;
    private Label label2;
    private Label label3;
    private RichTextBox richTextBox1;
    #endregion
}
