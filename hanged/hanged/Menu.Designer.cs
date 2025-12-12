namespace hanged
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.Button();
            this.Animals = new System.Windows.Forms.Button();
            this.Hobby = new System.Windows.Forms.Button();
            this.label_win = new System.Windows.Forms.Label();
            this.Flora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Темы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Food
            // 
            this.Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Food.Location = new System.Drawing.Point(291, 100);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(157, 53);
            this.Food.TabIndex = 1;
            this.Food.Text = "Еда";
            this.Food.UseVisualStyleBackColor = true;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // Animals
            // 
            this.Animals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Animals.Location = new System.Drawing.Point(291, 175);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(157, 51);
            this.Animals.TabIndex = 2;
            this.Animals.Text = "Животные";
            this.Animals.UseVisualStyleBackColor = true;
            this.Animals.Click += new System.EventHandler(this.Animals_Click);
            // 
            // Hobby
            // 
            this.Hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hobby.Location = new System.Drawing.Point(291, 244);
            this.Hobby.Name = "Hobby";
            this.Hobby.Size = new System.Drawing.Size(157, 51);
            this.Hobby.TabIndex = 3;
            this.Hobby.Text = "Хобби";
            this.Hobby.UseVisualStyleBackColor = true;
            this.Hobby.Click += new System.EventHandler(this.Hobby_Click);
            // 
            // label_win
            // 
            this.label_win.AutoSize = true;
            this.label_win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_win.Location = new System.Drawing.Point(183, 44);
            this.label_win.Name = "label_win";
            this.label_win.Size = new System.Drawing.Size(383, 25);
            this.label_win.TabIndex = 4;
            this.label_win.Text = "ПОЗДРАВЛЯЕМ, ВЫ ПРОШЛИ ИГРУ!";
            this.label_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_win.Visible = false;
            // 
            // Flora
            // 
            this.Flora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Flora.Location = new System.Drawing.Point(291, 318);
            this.Flora.Name = "Flora";
            this.Flora.Size = new System.Drawing.Size(157, 51);
            this.Flora.TabIndex = 5;
            this.Flora.Text = "Растения";
            this.Flora.UseVisualStyleBackColor = true;
            this.Flora.Click += new System.EventHandler(this.Flora_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.Flora);
            this.Controls.Add(this.label_win);
            this.Controls.Add(this.Hobby);
            this.Controls.Add(this.Animals);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Animals;
        private System.Windows.Forms.Button Hobby;
        private System.Windows.Forms.Label label_win;
        private System.Windows.Forms.Button Flora;
    }
}