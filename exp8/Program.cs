using System;
using System.Drawing;
using System.Windows.Forms;

class MyForm : Form
{
    Label nameLabel;
    Label departmentLabel;
    Label genderLabel;
    Label skillsLabel;
    TextBox nameTextBox;
    ComboBox departmentComboBox;
    RadioButton maleRadioButton;
    RadioButton femaleRadioButton;
    CheckBox csharpCheckBox;
    CheckBox javaCheckBox;
    CheckBox pythonCheckBox;
    Button submitButton;

    public MyForm()
    {
        Text = "Student Details";
        Width = 450;
        Height = 450;
        BackColor = Color.LightBlue;

        nameLabel = new Label();
        nameLabel.Text = "Name:";
        nameLabel.Left = 30;
        nameLabel.Top = 40;

        nameTextBox = new TextBox();
        nameTextBox.Left = 150;
        nameTextBox.Top = 40;
        nameTextBox.Width = 200;

        departmentLabel = new Label();
        departmentLabel.Text = "Department:";
        departmentLabel.Left = 30;
        departmentLabel.Top = 90;

        departmentComboBox = new ComboBox();
        departmentComboBox.Left = 150;
        departmentComboBox.Top = 90;
        departmentComboBox.Width = 200;
        departmentComboBox.Items.Add("CSE");
        departmentComboBox.Items.Add("ECE");
        departmentComboBox.Items.Add("EEE");
        departmentComboBox.Items.Add("MECH");

        genderLabel = new Label();
        genderLabel.Text = "Gender:";
        genderLabel.Left = 30;
        genderLabel.Top = 140;

        maleRadioButton = new RadioButton();
        maleRadioButton.Text = "Male";
        maleRadioButton.Left = 150;
        maleRadioButton.Top = 140;

        femaleRadioButton = new RadioButton();
        femaleRadioButton.Text = "Female";
        femaleRadioButton.Left = 220;
        femaleRadioButton.Top = 140;

        skillsLabel = new Label();
        skillsLabel.Text = "Skills:";
        skillsLabel.Left = 30;
        skillsLabel.Top = 190;

        csharpCheckBox = new CheckBox();
        csharpCheckBox.Text = "C#";
        csharpCheckBox.Left = 150;
        csharpCheckBox.Top = 190;

        javaCheckBox = new CheckBox();
        javaCheckBox.Text = "Java";
        javaCheckBox.Left = 210;
        javaCheckBox.Top = 190;

        pythonCheckBox = new CheckBox();
        pythonCheckBox.Text = "Python";
        pythonCheckBox.Left = 280;
        pythonCheckBox.Top = 190;

        submitButton = new Button();
        submitButton.Text = "Submit";
        submitButton.Left = 150;
        submitButton.Top = 250;
        submitButton.Click += SubmitButton_Click;

        Controls.Add(nameLabel);
        Controls.Add(nameTextBox);
        Controls.Add(departmentLabel);
        Controls.Add(departmentComboBox);
        Controls.Add(genderLabel);
        Controls.Add(maleRadioButton);
        Controls.Add(femaleRadioButton);
        Controls.Add(skillsLabel);
        Controls.Add(csharpCheckBox);
        Controls.Add(javaCheckBox);
        Controls.Add(pythonCheckBox);
        Controls.Add(submitButton);
    }

    private void SubmitButton_Click(object? sender, EventArgs e)
    {
        string gender = "";

        if (maleRadioButton.Checked)
            gender = "Male";
        else if (femaleRadioButton.Checked)
            gender = "Female";

        string skills = "";

        if (csharpCheckBox.Checked)
            skills += "C# ";

        if (javaCheckBox.Checked)
            skills += "Java ";

        if (pythonCheckBox.Checked)
            skills += "Python";

        MessageBox.Show(
            "Name: " + nameTextBox.Text +
            "\nDepartment: " + departmentComboBox.Text +
            "\nGender: " + gender +
            "\nSkills: " + skills
        );
    }

    static void Main()
    {
        Application.Run(new MyForm());
    }
}