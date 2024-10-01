namespace WinFormsApp2
{
    partial class MyButtonApp
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
            КНОПКА = new Button();
            SuspendLayout();
            // 
            // КНОПКА
            // 
            КНОПКА.BackColor = SystemColors.ActiveCaption;
            КНОПКА.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            КНОПКА.ForeColor = SystemColors.HotTrack;
            КНОПКА.Location = new Point(150, 108);
            КНОПКА.Name = "КНОПКА";
            КНОПКА.Size = new Size(129, 51);
            КНОПКА.TabIndex = 0;
            КНОПКА.Text = "КНОПКА";
            КНОПКА.UseVisualStyleBackColor = false;
            КНОПКА.Click += button1_Click;
            // 
            // MyButtonApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(КНОПКА);
            Name = "MyButtonApp";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button КНОПКА;
    }
}
