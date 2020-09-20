namespace Stack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pushButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.elementsTextBox = new System.Windows.Forms.RichTextBox();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushButton
            // 
            this.pushButton.BackColor = System.Drawing.Color.Black;
            this.pushButton.FlatAppearance.BorderSize = 0;
            this.pushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pushButton.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pushButton.ForeColor = System.Drawing.Color.Transparent;
            this.pushButton.Location = new System.Drawing.Point(34, 146);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(222, 30);
            this.pushButton.TabIndex = 0;
            this.pushButton.Text = "Добавить элемент";
            this.pushButton.UseVisualStyleBackColor = false;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // popButton
            // 
            this.popButton.BackColor = System.Drawing.Color.Black;
            this.popButton.FlatAppearance.BorderSize = 0;
            this.popButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.popButton.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popButton.ForeColor = System.Drawing.Color.Transparent;
            this.popButton.Location = new System.Drawing.Point(339, 146);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(196, 30);
            this.popButton.TabIndex = 1;
            this.popButton.Text = "Удалить элемент";
            this.popButton.UseVisualStyleBackColor = false;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // elementsTextBox
            // 
            this.elementsTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.elementsTextBox.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementsTextBox.Location = new System.Drawing.Point(673, 122);
            this.elementsTextBox.Name = "elementsTextBox";
            this.elementsTextBox.Size = new System.Drawing.Size(416, 343);
            this.elementsTextBox.TabIndex = 2;
            this.elementsTextBox.Text = "";
            // 
            // elementTextBox
            // 
            this.elementTextBox.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementTextBox.Location = new System.Drawing.Point(34, 103);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(222, 28);
            this.elementTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите элемент:";
            // 
            // textTop
            // 
            this.textTop.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTop.Location = new System.Drawing.Point(339, 103);
            this.textTop.Name = "textTop";
            this.textTop.Size = new System.Drawing.Size(196, 28);
            this.textTop.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Верхушка стека:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(347, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Реализация работы со стеком";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(669, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Содержимое стека:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.elementsTextBox);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.pushButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stack for Sanych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.RichTextBox elementsTextBox;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

