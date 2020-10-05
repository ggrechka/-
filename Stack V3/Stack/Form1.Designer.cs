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
            this.label5 = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textMulti = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBottom = new System.Windows.Forms.TextBox();
            this.buttonSearchMin = new System.Windows.Forms.Button();
            this.buttonSearchMax = new System.Windows.Forms.Button();
            this.buttonSearchSum = new System.Windows.Forms.Button();
            this.buttonSearchMulti = new System.Windows.Forms.Button();
            this.PopBot = new System.Windows.Forms.Button();
            this.PushBot = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textmodstack = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextS2 = new System.Windows.Forms.TextBox();
            this.PushPop = new System.Windows.Forms.Button();
            this.PopTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pushButton
            // 
            this.pushButton.BackColor = System.Drawing.Color.Black;
            this.pushButton.FlatAppearance.BorderSize = 0;
            this.pushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pushButton.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pushButton.ForeColor = System.Drawing.Color.Transparent;
            this.pushButton.Location = new System.Drawing.Point(23, 149);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(292, 41);
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
            this.popButton.Location = new System.Drawing.Point(350, 149);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(292, 41);
            this.popButton.TabIndex = 1;
            this.popButton.Text = "Удалить элемент";
            this.popButton.UseVisualStyleBackColor = false;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // elementsTextBox
            // 
            this.elementsTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.elementsTextBox.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementsTextBox.Location = new System.Drawing.Point(715, 100);
            this.elementsTextBox.Name = "elementsTextBox";
            this.elementsTextBox.Size = new System.Drawing.Size(770, 90);
            this.elementsTextBox.TabIndex = 2;
            this.elementsTextBox.Text = "";
            // 
            // elementTextBox
            // 
            this.elementTextBox.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elementTextBox.Location = new System.Drawing.Point(23, 103);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(619, 28);
            this.elementTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите элемент:";
            // 
            // textTop
            // 
            this.textTop.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTop.Location = new System.Drawing.Point(947, 202);
            this.textTop.Name = "textTop";
            this.textTop.Size = new System.Drawing.Size(190, 28);
            this.textTop.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(711, 205);
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
            this.label3.Location = new System.Drawing.Point(511, 23);
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
            this.label4.Location = new System.Drawing.Point(711, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Содержимое стека:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Минимальный";
            // 
            // textMin
            // 
            this.textMin.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMin.Location = new System.Drawing.Point(27, 239);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(222, 28);
            this.textMin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(350, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Максимальный";
            // 
            // textMax
            // 
            this.textMax.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMax.Location = new System.Drawing.Point(350, 239);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(218, 28);
            this.textMax.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сумма";
            // 
            // textSum
            // 
            this.textSum.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSum.Location = new System.Drawing.Point(27, 355);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(222, 28);
            this.textSum.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(350, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Произведение";
            // 
            // textMulti
            // 
            this.textMulti.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMulti.Location = new System.Drawing.Point(350, 355);
            this.textMulti.Name = "textMulti";
            this.textMulti.Size = new System.Drawing.Size(218, 28);
            this.textMulti.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1143, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дно стека";
            // 
            // textBottom
            // 
            this.textBottom.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBottom.Location = new System.Drawing.Point(1291, 202);
            this.textBottom.Name = "textBottom";
            this.textBottom.Size = new System.Drawing.Size(194, 28);
            this.textBottom.TabIndex = 17;
            // 
            // buttonSearchMin
            // 
            this.buttonSearchMin.BackColor = System.Drawing.Color.Black;
            this.buttonSearchMin.FlatAppearance.BorderSize = 0;
            this.buttonSearchMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMin.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchMin.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchMin.Location = new System.Drawing.Point(27, 284);
            this.buttonSearchMin.Name = "buttonSearchMin";
            this.buttonSearchMin.Size = new System.Drawing.Size(222, 30);
            this.buttonSearchMin.TabIndex = 21;
            this.buttonSearchMin.Text = "Поиск";
            this.buttonSearchMin.UseVisualStyleBackColor = false;
            this.buttonSearchMin.Click += new System.EventHandler(this.buttonSearchMin_Click);
            // 
            // buttonSearchMax
            // 
            this.buttonSearchMax.BackColor = System.Drawing.Color.Black;
            this.buttonSearchMax.FlatAppearance.BorderSize = 0;
            this.buttonSearchMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMax.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchMax.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchMax.Location = new System.Drawing.Point(350, 284);
            this.buttonSearchMax.Name = "buttonSearchMax";
            this.buttonSearchMax.Size = new System.Drawing.Size(218, 30);
            this.buttonSearchMax.TabIndex = 22;
            this.buttonSearchMax.Text = "Поиск";
            this.buttonSearchMax.UseVisualStyleBackColor = false;
            this.buttonSearchMax.Click += new System.EventHandler(this.buttonSearchMax_Click);
            // 
            // buttonSearchSum
            // 
            this.buttonSearchSum.BackColor = System.Drawing.Color.Black;
            this.buttonSearchSum.FlatAppearance.BorderSize = 0;
            this.buttonSearchSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSum.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchSum.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchSum.Location = new System.Drawing.Point(27, 403);
            this.buttonSearchSum.Name = "buttonSearchSum";
            this.buttonSearchSum.Size = new System.Drawing.Size(222, 30);
            this.buttonSearchSum.TabIndex = 23;
            this.buttonSearchSum.Text = "Поиск";
            this.buttonSearchSum.UseVisualStyleBackColor = false;
            this.buttonSearchSum.Click += new System.EventHandler(this.buttonSearchSum_Click);
            // 
            // buttonSearchMulti
            // 
            this.buttonSearchMulti.BackColor = System.Drawing.Color.Black;
            this.buttonSearchMulti.FlatAppearance.BorderSize = 0;
            this.buttonSearchMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMulti.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchMulti.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearchMulti.Location = new System.Drawing.Point(350, 403);
            this.buttonSearchMulti.Name = "buttonSearchMulti";
            this.buttonSearchMulti.Size = new System.Drawing.Size(222, 30);
            this.buttonSearchMulti.TabIndex = 24;
            this.buttonSearchMulti.Text = "Поиск";
            this.buttonSearchMulti.UseVisualStyleBackColor = false;
            this.buttonSearchMulti.Click += new System.EventHandler(this.buttonSearchMulti_Click);
            // 
            // PopBot
            // 
            this.PopBot.BackColor = System.Drawing.Color.Black;
            this.PopBot.FlatAppearance.BorderSize = 0;
            this.PopBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopBot.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopBot.ForeColor = System.Drawing.Color.Transparent;
            this.PopBot.Location = new System.Drawing.Point(354, 620);
            this.PopBot.Name = "PopBot";
            this.PopBot.Size = new System.Drawing.Size(292, 41);
            this.PopBot.TabIndex = 26;
            this.PopBot.Text = "Удалить элемент снизу";
            this.PopBot.UseVisualStyleBackColor = false;
            this.PopBot.Click += new System.EventHandler(this.PopBottom_Click);
            // 
            // PushBot
            // 
            this.PushBot.BackColor = System.Drawing.Color.Black;
            this.PushBot.FlatAppearance.BorderSize = 0;
            this.PushBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PushBot.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PushBot.ForeColor = System.Drawing.Color.Transparent;
            this.PushBot.Location = new System.Drawing.Point(354, 573);
            this.PushBot.Name = "PushBot";
            this.PushBot.Size = new System.Drawing.Size(292, 41);
            this.PushBot.TabIndex = 25;
            this.PushBot.Text = "Добавить элемент снизу";
            this.PushBot.UseVisualStyleBackColor = false;
            this.PushBot.Click += new System.EventHandler(this.PushBottom_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(711, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(414, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Содержимое модификации стека";
            // 
            // textmodstack
            // 
            this.textmodstack.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textmodstack.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textmodstack.Location = new System.Drawing.Point(715, 524);
            this.textmodstack.Name = "textmodstack";
            this.textmodstack.Size = new System.Drawing.Size(770, 90);
            this.textmodstack.TabIndex = 27;
            this.textmodstack.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Druk Text Wide Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(556, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Введите элемент в модифицированный стек:";
            // 
            // TextS2
            // 
            this.TextS2.Font = new System.Drawing.Font("Druk Text Wide Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextS2.Location = new System.Drawing.Point(27, 524);
            this.TextS2.Name = "TextS2";
            this.TextS2.Size = new System.Drawing.Size(619, 28);
            this.TextS2.TabIndex = 29;
            // 
            // PushPop
            // 
            this.PushPop.BackColor = System.Drawing.Color.Black;
            this.PushPop.FlatAppearance.BorderSize = 0;
            this.PushPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PushPop.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PushPop.ForeColor = System.Drawing.Color.Transparent;
            this.PushPop.Location = new System.Drawing.Point(27, 573);
            this.PushPop.Name = "PushPop";
            this.PushPop.Size = new System.Drawing.Size(292, 41);
            this.PushPop.TabIndex = 32;
            this.PushPop.Text = "Добавить элемент сверху";
            this.PushPop.UseVisualStyleBackColor = false;
            this.PushPop.Click += new System.EventHandler(this.PushPop_Click);
            // 
            // PopTop
            // 
            this.PopTop.BackColor = System.Drawing.Color.Black;
            this.PopTop.FlatAppearance.BorderSize = 0;
            this.PopTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopTop.Font = new System.Drawing.Font("Druk Text Wide Bold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PopTop.ForeColor = System.Drawing.Color.Transparent;
            this.PopTop.Location = new System.Drawing.Point(27, 620);
            this.PopTop.Name = "PopTop";
            this.PopTop.Size = new System.Drawing.Size(292, 41);
            this.PopTop.TabIndex = 31;
            this.PopTop.Text = "Удалить элемент сверху";
            this.PopTop.UseVisualStyleBackColor = false;
            this.PopTop.Click += new System.EventHandler(this.PopTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1497, 729);
            this.Controls.Add(this.PushPop);
            this.Controls.Add(this.PopTop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TextS2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textmodstack);
            this.Controls.Add(this.PopBot);
            this.Controls.Add(this.PushBot);
            this.Controls.Add(this.buttonSearchMulti);
            this.Controls.Add(this.buttonSearchSum);
            this.Controls.Add(this.buttonSearchMax);
            this.Controls.Add(this.buttonSearchMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBottom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textMulti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMin);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textMulti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBottom;
        private System.Windows.Forms.Button buttonSearchMin;
        private System.Windows.Forms.Button buttonSearchMax;
        private System.Windows.Forms.Button buttonSearchSum;
        private System.Windows.Forms.Button buttonSearchMulti;
        private System.Windows.Forms.Button PopBot;
        private System.Windows.Forms.Button PushBot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox textmodstack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextS2;
        private System.Windows.Forms.Button PushPop;
        private System.Windows.Forms.Button PopTop;
    }
}

