namespace Tamagochi_IlyaProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Person = new System.Windows.Forms.ComboBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.add_Eat = new System.Windows.Forms.Button();
            this.add_Water = new System.Windows.Forms.Button();
            this.add_Health = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Person
            // 
            this.Person.FormattingEnabled = true;
            this.Person.Location = new System.Drawing.Point(12, 3);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(174, 21);
            this.Person.TabIndex = 0;
            this.Person.Text = "Выбор персонажа";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(192, 3);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(129, 21);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Tamagochi_IlyaProject.Properties.Resources.bird;
            this.pictureBox.Location = new System.Drawing.Point(12, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(174, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 239);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 19);
            this.label.TabIndex = 3;
            this.label.Text = "Имя:";
            // 
            // label_name
            // 
            this.label_name.Location = new System.Drawing.Point(55, 239);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(131, 19);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Неизвестно";
            // 
            // add_Eat
            // 
            this.add_Eat.Location = new System.Drawing.Point(192, 68);
            this.add_Eat.Name = "add_Eat";
            this.add_Eat.Size = new System.Drawing.Size(129, 23);
            this.add_Eat.TabIndex = 1;
            this.add_Eat.Text = "Покормить";
            this.add_Eat.UseVisualStyleBackColor = true;
            this.add_Eat.Click += new System.EventHandler(this.add_Eat_Click);
            // 
            // add_Water
            // 
            this.add_Water.Location = new System.Drawing.Point(192, 140);
            this.add_Water.Name = "add_Water";
            this.add_Water.Size = new System.Drawing.Size(129, 25);
            this.add_Water.TabIndex = 1;
            this.add_Water.Text = "Напоить";
            this.add_Water.UseVisualStyleBackColor = true;
            this.add_Water.Click += new System.EventHandler(this.add_Water_Click);
            // 
            // add_Health
            // 
            this.add_Health.Location = new System.Drawing.Point(192, 213);
            this.add_Health.Name = "add_Health";
            this.add_Health.Size = new System.Drawing.Size(129, 23);
            this.add_Health.TabIndex = 1;
            this.add_Health.Text = "Лечить";
            this.add_Health.UseVisualStyleBackColor = true;
            this.add_Health.Click += new System.EventHandler(this.add_Health_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(327, 140);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(301, 25);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 100;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(327, 213);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(301, 23);
            this.progressBar3.TabIndex = 7;
            this.progressBar3.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(629, 300);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(127, 30);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 30);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(174, 20);
            this.textBox_name.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 342);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.add_Health);
            this.Controls.Add(this.add_Water);
            this.Controls.Add(this.add_Eat);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.Person);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Person;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button add_Eat;
        private System.Windows.Forms.Button add_Water;
        private System.Windows.Forms.Button add_Health;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox_name;
    }
}

