namespace WindowsFormsApp2
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
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.ManufacturerText = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.GroupBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WasOpenedCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PriceText
            // 
            this.PriceText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceText.Location = new System.Drawing.Point(211, 153);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(129, 26);
            this.PriceText.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Цена: ";
            // 
            // ModelText
            // 
            this.ModelText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelText.Location = new System.Drawing.Point(211, 119);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(129, 26);
            this.ModelText.TabIndex = 19;
            // 
            // NameText
            // 
            this.NameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(211, 83);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(129, 26);
            this.NameText.TabIndex = 18;
            // 
            // ManufacturerText
            // 
            this.ManufacturerText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManufacturerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerText.Location = new System.Drawing.Point(211, 51);
            this.ManufacturerText.Name = "ManufacturerText";
            this.ManufacturerText.Size = new System.Drawing.Size(129, 26);
            this.ManufacturerText.TabIndex = 17;
            // 
            // MessageBox
            // 
            this.MessageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MessageBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageBox.Location = new System.Drawing.Point(356, 52);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(190, 244);
            this.MessageBox.TabIndex = 16;
            this.MessageBox.TabStop = false;
            this.MessageBox.Text = "Окно вывода";
            this.MessageBox.Enter += new System.EventHandler(this.MessageBox_Enter);
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EnterButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(52, 245);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(268, 51);
            this.EnterButton.TabIndex = 15;
            this.EnterButton.Text = "Добавить";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Модель: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Название: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Призводитель: ";
            // 
            // WasOpenedCheck
            // 
            this.WasOpenedCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WasOpenedCheck.AutoSize = true;
            this.WasOpenedCheck.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WasOpenedCheck.Location = new System.Drawing.Point(46, 191);
            this.WasOpenedCheck.Name = "WasOpenedCheck";
            this.WasOpenedCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WasOpenedCheck.Size = new System.Drawing.Size(63, 29);
            this.WasOpenedCheck.TabIndex = 11;
            this.WasOpenedCheck.Text = "Б/У";
            this.WasOpenedCheck.UseVisualStyleBackColor = true;
            this.WasOpenedCheck.CheckedChanged += new System.EventHandler(this.WasOpenedCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(601, 338);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ManufacturerText);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WasOpenedCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Форма для ввода данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox ManufacturerText;
        private System.Windows.Forms.GroupBox MessageBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WasOpenedCheck;
    }
}

