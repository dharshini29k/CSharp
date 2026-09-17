using System;
using System.Windows.Forms;

class MyForm : Form
{
    Label label1;
    Label label2;
    TextBox textBox1;
    TextBox textBox2;
    Button addButton;
    Label resultLabel;

    public MyForm()
    {
        Text = "Addition of Two Numbers";
        Width = 400;
        Height = 300;

        label1 = new Label();
        label1.Text = "Enter First Number:";
        label1.Left = 30;
        label1.Top = 40;
        label1.Width = 130;

        textBox1 = new TextBox();
        textBox1.Left = 170;
        textBox1.Top = 40;
        textBox1.Width = 150;

        label2 = new Label();
        label2.Text = "Enter Second Number:";
        label2.Left = 30;
        label2.Top = 80;
        label2.Width = 130;

        textBox2 = new TextBox();
        textBox2.Left = 170;
        textBox2.Top = 80;
        textBox2.Width = 150;

        addButton = new Button();
        addButton.Text = "Add";
        addButton.Left = 150;
        addButton.Top = 130;
        addButton.Click += AddButton_Click;

        resultLabel = new Label();
        resultLabel.Text = "Result:";
        resultLabel.Left = 100;
        resultLabel.Top = 190;
        resultLabel.Width = 200;

        Controls.Add(label1);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(textBox2);
        Controls.Add(addButton);
        Controls.Add(resultLabel);
    }

    private void AddButton_Click(object? sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(textBox1.Text);
        int num2 = Convert.ToInt32(textBox2.Text);
        int result = num1 + num2;

        resultLabel.Text = "Result: " + result;
    }

    static void Main()
    {
        Application.Run(new MyForm());
    }
}