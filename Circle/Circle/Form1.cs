using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        private Button openForm2Button;
        private bool dragging = false; // Флаг, указывающий, перетаскивается ли форма
        private Point dragCursorPoint; // Точка курсора
        private Point dragFormPoint; // Точка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // Здесь можно выполнить любые действия, которые нужно сделать при загрузке формы.
        }

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(400, 400); // Установка размеров формы
            this.Text = "Фиолетовый круг"; // Установка заголовка формы
            SetFormToCircle(); // Установка формы круглой
            this.Paint += new PaintEventHandler(MainForm_Paint); // Подписка на событие Paint

            // Подписка на события мыши для перетаскивания формы
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            openForm2Button = new Button();

            openForm2Button.Text = "Открыть вторую форму";
            openForm2Button.Click += OpenForm2Button_Click;
            openForm2Button.Dock = DockStyle.Bottom;

            this.Controls.Add(openForm2Button);
        }

    

        private void SetFormToCircle()
        {
            // Создаем круглую область (Region) для формы
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = Brushes.Violet; // Фиолетовая кисть
            int diameter = Math.Max(ClientSize.Width, ClientSize.Height);
            g.FillEllipse(brush, -1, -1, diameter + 2, diameter + 2); // Рисуем круг с учетом рамки
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Проверяем, нажата ли левая кнопка мыши
            {
                dragging = true; // Устанавливаем флаг перетаскивания
                dragCursorPoint = Cursor.Position; // Получаем текущую позицию курсора
                dragFormPoint = this.Location; // Получаем текущую позицию формы
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging) // Если форма перетаскивается
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint)); // Разница между текущей и начальной позицией курсора
                this.Location = Point.Add(dragFormPoint, new Size(dif)); // Устанавливаем новую позицию формы
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Проверяем, отпущена ли левая кнопка мыши
            {
                dragging = false; // Сбрасываем флаг перетаскивания
            }
        }
        private void OpenForm2Button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Открываем вторую форму
        }

    }
}
