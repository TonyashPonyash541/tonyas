using System;
using System.Windows.Forms;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
        this.Text = "Вторая форма"; // Заголовок второй формы

        Button backButton = new Button();
        backButton.Text = "Назад";
        backButton.Click += BackButton_Click;
        backButton.Dock = DockStyle.Fill;

        this.Controls.Add(backButton);
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        this.Close(); // Закрываем вторую форму
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(871, 496);
            this.Name = "Form2";
            this.ResumeLayout(false);

    }
}
