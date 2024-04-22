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
            this.AddButton = new System.Windows.Forms.Button();
            this.NumeratorTextBox = new System.Windows.Forms.TextBox();
            this.DenominatorTextBox = new System.Windows.Forms.TextBox();
            this.IntegerPartTextBox = new System.Windows.Forms.TextBox();
            this.SortCollection = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.DataGridView();
            this.IntegerPartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeratorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenominatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeletedBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.AddButton.Location = new System.Drawing.Point(181, 342);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 42);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // NumeratorTextBox
            // 
            this.NumeratorTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumeratorTextBox.Location = new System.Drawing.Point(123, 331);
            this.NumeratorTextBox.Name = "NumeratorTextBox";
            this.NumeratorTextBox.Size = new System.Drawing.Size(52, 32);
            this.NumeratorTextBox.TabIndex = 1;
            // 
            // DenominatorTextBox
            // 
            this.DenominatorTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.DenominatorTextBox.Location = new System.Drawing.Point(123, 370);
            this.DenominatorTextBox.Name = "DenominatorTextBox";
            this.DenominatorTextBox.Size = new System.Drawing.Size(52, 32);
            this.DenominatorTextBox.TabIndex = 2;
            // 
            // IntegerPartTextBox
            // 
            this.IntegerPartTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.75F);
            this.IntegerPartTextBox.Location = new System.Drawing.Point(70, 345);
            this.IntegerPartTextBox.Name = "IntegerPartTextBox";
            this.IntegerPartTextBox.Size = new System.Drawing.Size(47, 39);
            this.IntegerPartTextBox.TabIndex = 3;
            // 
            // SortCollection
            // 
            this.SortCollection.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.SortCollection.ForeColor = System.Drawing.Color.Red;
            this.SortCollection.Location = new System.Drawing.Point(518, 366);
            this.SortCollection.Name = "SortCollection";
            this.SortCollection.Size = new System.Drawing.Size(89, 34);
            this.SortCollection.TabIndex = 5;
            this.SortCollection.Text = "Запуск";
            this.SortCollection.UseVisualStyleBackColor = true;
            this.SortCollection.Click += new System.EventHandler(this.SortCollection_Click);
            // 
            // Output
            // 
            this.Output.BackgroundColor = System.Drawing.Color.Silver;
            this.Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntegerPartColumn,
            this.NumeratorColumn,
            this.DenominatorColumn});
            this.Output.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Output.Location = new System.Drawing.Point(65, 51);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(344, 265);
            this.Output.TabIndex = 0;
            // 
            // IntegerPartColumn
            // 
            this.IntegerPartColumn.HeaderText = "Целая часть";
            this.IntegerPartColumn.Name = "IntegerPartColumn";
            // 
            // NumeratorColumn
            // 
            this.NumeratorColumn.HeaderText = "Числитель";
            this.NumeratorColumn.Name = "NumeratorColumn";
            // 
            // DenominatorColumn
            // 
            this.DenominatorColumn.HeaderText = "Знаменатель";
            this.DenominatorColumn.Name = "DenominatorColumn";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(293, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 69);
            this.button3.TabIndex = 9;
            this.button3.Text = "Количества элементов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowAmount);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 377);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(415, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Напечатать непр. дроби";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ImproperFractionsPrint);
            // 
            // DeletedBox
            // 
            this.DeletedBox.BackColor = System.Drawing.SystemColors.Info;
            this.DeletedBox.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletedBox.Location = new System.Drawing.Point(415, 51);
            this.DeletedBox.Name = "DeletedBox";
            this.DeletedBox.Size = new System.Drawing.Size(189, 265);
            this.DeletedBox.TabIndex = 6;
            this.DeletedBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сериализацияToolStripMenuItem,
            this.десериализацияToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сериализацияToolStripMenuItem
            // 
            this.сериализацияToolStripMenuItem.Name = "сериализацияToolStripMenuItem";
            this.сериализацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сериализацияToolStripMenuItem.Text = "Сериализация";
            this.сериализацияToolStripMenuItem.Click += new System.EventHandler(this.сериализацияToolStripMenuItem_Click);
            // 
            // десериализацияToolStripMenuItem
            // 
            this.десериализацияToolStripMenuItem.Name = "десериализацияToolStripMenuItem";
            this.десериализацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.десериализацияToolStripMenuItem.Text = "Десериализация";
            this.десериализацияToolStripMenuItem.Click += new System.EventHandler(this.десериализацияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.разноцветные_математические_дроби_на_деревянном_фоне_или_столе_158531394;
            this.ClientSize = new System.Drawing.Size(671, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeletedBox);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.SortCollection);
            this.Controls.Add(this.IntegerPartTextBox);
            this.Controls.Add(this.DenominatorTextBox);
            this.Controls.Add(this.NumeratorTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "9 лаба";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NumeratorTextBox;
        private System.Windows.Forms.TextBox DenominatorTextBox;
        private System.Windows.Forms.TextBox IntegerPartTextBox;
        private System.Windows.Forms.Button SortCollection;
        private System.Windows.Forms.DataGridView Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegerPartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeratorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenominatorColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox DeletedBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сериализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десериализацияToolStripMenuItem;
    }
}

