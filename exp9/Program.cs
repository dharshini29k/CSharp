using System;
using System.Drawing;
using System.Windows.Forms;

class MainForm : Form
{
    MenuStrip menuStrip;
    ToolStripMenuItem fileMenu;
    ToolStripMenuItem newWindowMenu;
    ToolStripMenuItem customDialogMenu;
    ToolStripMenuItem exitMenu;
    ToolStripMenuItem departmentMenu;
    ToolStripMenuItem cseMenu;
    ToolStripMenuItem eceMenu;
    ToolStripMenuItem eeeMenu;
    ToolStripMenuItem studentMenu;
    ToolStripMenuItem aboutMenu;

    public MainForm()
    {
        Text = "College Management System";
        Width = 900;
        Height = 600;
        IsMdiContainer = true;

        menuStrip = new MenuStrip();

        fileMenu = new ToolStripMenuItem("File");
        newWindowMenu = new ToolStripMenuItem("New Window");
        customDialogMenu = new ToolStripMenuItem("Custom Dialog");
        exitMenu = new ToolStripMenuItem("Exit");

        departmentMenu = new ToolStripMenuItem("Department");
        cseMenu = new ToolStripMenuItem("CSE");
        eceMenu = new ToolStripMenuItem("ECE");
        eeeMenu = new ToolStripMenuItem("EEE");

        studentMenu = new ToolStripMenuItem("Student");
        aboutMenu = new ToolStripMenuItem("About");

        fileMenu.DropDownItems.Add(newWindowMenu);
        fileMenu.DropDownItems.Add(customDialogMenu);
        fileMenu.DropDownItems.Add(exitMenu);

        departmentMenu.DropDownItems.Add(cseMenu);
        departmentMenu.DropDownItems.Add(eceMenu);
        departmentMenu.DropDownItems.Add(eeeMenu);

        menuStrip.Items.Add(fileMenu);
        menuStrip.Items.Add(departmentMenu);
        menuStrip.Items.Add(studentMenu);
        menuStrip.Items.Add(aboutMenu);

        MainMenuStrip = menuStrip;
        Controls.Add(menuStrip);

        newWindowMenu.Click += NewWindowMenu_Click;
        customDialogMenu.Click += CustomDialogMenu_Click;
        exitMenu.Click += ExitMenu_Click;
        cseMenu.Click += Department_Click;
        eceMenu.Click += Department_Click;
        eeeMenu.Click += Department_Click;
        studentMenu.Click += StudentMenu_Click;
        aboutMenu.Click += AboutMenu_Click;
    }

    private void NewWindowMenu_Click(object? sender, EventArgs e)
    {
        Form child = new Form();
        child.Text = "Student Window";
        child.MdiParent = this;
        child.Width = 400;
        child.Height = 300;
        child.Show();
    }

    private void CustomDialogMenu_Click(object? sender, EventArgs e)
    {
        Form dialog = new Form();
        dialog.Text = "Custom Dialog";
        dialog.Width = 350;
        dialog.Height = 250;
        dialog.StartPosition = FormStartPosition.CenterParent;

        Label label = new Label();
        label.Text = "Enter Name:";
        label.Left = 30;
        label.Top = 40;

        TextBox textBox = new TextBox();
        textBox.Left = 120;
        textBox.Top = 40;
        textBox.Width = 150;

        Button button = new Button();
        button.Text = "OK";
        button.Left = 120;
        button.Top = 90;
        button.Click += (s, args) =>
        {
            MessageBox.Show("Hello " + textBox.Text);
            dialog.Close();
        };

        dialog.Controls.Add(label);
        dialog.Controls.Add(textBox);
        dialog.Controls.Add(button);

        dialog.ShowDialog();
    }

    private void ExitMenu_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void Department_Click(object? sender, EventArgs e)
    {
        ToolStripMenuItem item = (ToolStripMenuItem)sender!;
        MessageBox.Show("Selected Department: " + item.Text);
    }

    private void StudentMenu_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Student Details");
    }

    private void AboutMenu_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("College Management System");
    }

    static void Main()
    {
        Application.Run(new MainForm());
    }
}
