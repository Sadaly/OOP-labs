namespace ConsoleApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerInteface = new System.Windows.Forms.GroupBox();
            this.PlayerHealthBar = new System.Windows.Forms.GroupBox();
            this.PlayerHealth = new System.Windows.Forms.ProgressBar();
            this.PlayerGold = new System.Windows.Forms.GroupBox();
            this.PlayerAttack = new System.Windows.Forms.GroupBox();
            this.PlayerLevel = new System.Windows.Forms.GroupBox();
            this.NPC2Picture = new System.Windows.Forms.PictureBox();
            this.NPC2Interface = new System.Windows.Forms.GroupBox();
            this.NPC2HealthBar = new System.Windows.Forms.GroupBox();
            this.NPC2Attack = new System.Windows.Forms.GroupBox();
            this.NPC2Level = new System.Windows.Forms.GroupBox();
            this.NPC2HP = new System.Windows.Forms.ProgressBar();
            this.AttackButton = new System.Windows.Forms.Button();
            this.SkipButton = new System.Windows.Forms.Button();
            this.DialogWindow = new System.Windows.Forms.GroupBox();
            this.NPC1Picture = new System.Windows.Forms.PictureBox();
            this.NPC1Interface = new System.Windows.Forms.GroupBox();
            this.NPC1HealthBar = new System.Windows.Forms.GroupBox();
            this.NPC1HP = new System.Windows.Forms.ProgressBar();
            this.NPC1Level = new System.Windows.Forms.GroupBox();
            this.NPC1Attack = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.StealButton = new System.Windows.Forms.Button();
            this.UseButton = new System.Windows.Forms.Button();
            this.Inventory6 = new System.Windows.Forms.PictureBox();
            this.Inventory3 = new System.Windows.Forms.PictureBox();
            this.Inventory5 = new System.Windows.Forms.PictureBox();
            this.Inventory4 = new System.Windows.Forms.PictureBox();
            this.Inventory2 = new System.Windows.Forms.PictureBox();
            this.Inventory1 = new System.Windows.Forms.PictureBox();
            this.TraderPicture = new System.Windows.Forms.PictureBox();
            this.TraderInteface = new System.Windows.Forms.GroupBox();
            this.TraderSell = new System.Windows.Forms.Button();
            this.TraderBuy = new System.Windows.Forms.Button();
            this.TraderGold = new System.Windows.Forms.GroupBox();
            this.TraderAttack = new System.Windows.Forms.GroupBox();
            this.TraderHealth = new System.Windows.Forms.GroupBox();
            this.TradeSlot6 = new System.Windows.Forms.PictureBox();
            this.TradeSlot3 = new System.Windows.Forms.PictureBox();
            this.TradeSlot5 = new System.Windows.Forms.PictureBox();
            this.TradeSlot4 = new System.Windows.Forms.PictureBox();
            this.TradeSlot2 = new System.Windows.Forms.PictureBox();
            this.TradeSlot1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PlayerInteface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPC2Picture)).BeginInit();
            this.NPC2Interface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPC1Picture)).BeginInit();
            this.NPC1Interface.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderPicture)).BeginInit();
            this.TraderInteface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ConsoleApp1.Properties.Resources.knight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 193);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerInteface
            // 
            this.PlayerInteface.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PlayerInteface.Controls.Add(this.PlayerHealthBar);
            this.PlayerInteface.Controls.Add(this.PlayerHealth);
            this.PlayerInteface.Controls.Add(this.PlayerGold);
            this.PlayerInteface.Controls.Add(this.PlayerAttack);
            this.PlayerInteface.Controls.Add(this.PlayerLevel);
            this.PlayerInteface.Location = new System.Drawing.Point(-4, 320);
            this.PlayerInteface.Name = "PlayerInteface";
            this.PlayerInteface.Size = new System.Drawing.Size(289, 193);
            this.PlayerInteface.TabIndex = 9;
            this.PlayerInteface.TabStop = false;
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.BackColor = System.Drawing.Color.DarkRed;
            this.PlayerHealthBar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHealthBar.Location = new System.Drawing.Point(175, -18);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(114, 58);
            this.PlayerHealthBar.TabIndex = 14;
            this.PlayerHealthBar.TabStop = false;
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.Location = new System.Drawing.Point(173, 0);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(116, 45);
            this.PlayerHealth.TabIndex = 16;
            this.PlayerHealth.Value = 100;
            // 
            // PlayerGold
            // 
            this.PlayerGold.BackColor = System.Drawing.Color.LemonChiffon;
            this.PlayerGold.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerGold.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayerGold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerGold.Location = new System.Drawing.Point(175, 126);
            this.PlayerGold.Name = "PlayerGold";
            this.PlayerGold.Size = new System.Drawing.Size(113, 67);
            this.PlayerGold.TabIndex = 8;
            this.PlayerGold.TabStop = false;
            // 
            // PlayerAttack
            // 
            this.PlayerAttack.BackColor = System.Drawing.Color.LemonChiffon;
            this.PlayerAttack.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerAttack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayerAttack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerAttack.Location = new System.Drawing.Point(176, 87);
            this.PlayerAttack.Name = "PlayerAttack";
            this.PlayerAttack.Size = new System.Drawing.Size(113, 33);
            this.PlayerAttack.TabIndex = 8;
            this.PlayerAttack.TabStop = false;
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.BackColor = System.Drawing.Color.LemonChiffon;
            this.PlayerLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerLevel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlayerLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerLevel.Location = new System.Drawing.Point(176, 51);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(113, 30);
            this.PlayerLevel.TabIndex = 8;
            this.PlayerLevel.TabStop = false;
            // 
            // NPC2Picture
            // 
            this.NPC2Picture.BackgroundImage = global::ConsoleApp1.Properties.Resources.knight;
            this.NPC2Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NPC2Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NPC2Picture.Image = global::ConsoleApp1.Properties.Resources.wolf1;
            this.NPC2Picture.Location = new System.Drawing.Point(104, 0);
            this.NPC2Picture.Name = "NPC2Picture";
            this.NPC2Picture.Size = new System.Drawing.Size(154, 171);
            this.NPC2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NPC2Picture.TabIndex = 10;
            this.NPC2Picture.TabStop = false;
            this.NPC2Picture.Click += new System.EventHandler(this.NPC2Picture_Click);
            // 
            // NPC2Interface
            // 
            this.NPC2Interface.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NPC2Interface.Controls.Add(this.NPC2HealthBar);
            this.NPC2Interface.Controls.Add(this.NPC2Attack);
            this.NPC2Interface.Controls.Add(this.NPC2Level);
            this.NPC2Interface.Controls.Add(this.NPC2HP);
            this.NPC2Interface.Controls.Add(this.NPC2Picture);
            this.NPC2Interface.Location = new System.Drawing.Point(539, 12);
            this.NPC2Interface.Name = "NPC2Interface";
            this.NPC2Interface.Size = new System.Drawing.Size(258, 171);
            this.NPC2Interface.TabIndex = 10;
            this.NPC2Interface.TabStop = false;
            // 
            // NPC2HealthBar
            // 
            this.NPC2HealthBar.BackColor = System.Drawing.Color.DarkRed;
            this.NPC2HealthBar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.NPC2HealthBar.Location = new System.Drawing.Point(0, -19);
            this.NPC2HealthBar.Name = "NPC2HealthBar";
            this.NPC2HealthBar.Size = new System.Drawing.Size(104, 56);
            this.NPC2HealthBar.TabIndex = 14;
            this.NPC2HealthBar.TabStop = false;
            // 
            // NPC2Attack
            // 
            this.NPC2Attack.BackColor = System.Drawing.Color.LemonChiffon;
            this.NPC2Attack.Cursor = System.Windows.Forms.Cursors.Default;
            this.NPC2Attack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPC2Attack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.NPC2Attack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NPC2Attack.Location = new System.Drawing.Point(0, 117);
            this.NPC2Attack.Name = "NPC2Attack";
            this.NPC2Attack.Size = new System.Drawing.Size(104, 37);
            this.NPC2Attack.TabIndex = 10;
            this.NPC2Attack.TabStop = false;
            // 
            // NPC2Level
            // 
            this.NPC2Level.BackColor = System.Drawing.Color.LemonChiffon;
            this.NPC2Level.Cursor = System.Windows.Forms.Cursors.Default;
            this.NPC2Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPC2Level.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.NPC2Level.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NPC2Level.Location = new System.Drawing.Point(0, 61);
            this.NPC2Level.Name = "NPC2Level";
            this.NPC2Level.Size = new System.Drawing.Size(104, 37);
            this.NPC2Level.TabIndex = 11;
            this.NPC2Level.TabStop = false;
            // 
            // NPC2HP
            // 
            this.NPC2HP.Location = new System.Drawing.Point(0, 7);
            this.NPC2HP.Name = "NPC2HP";
            this.NPC2HP.Size = new System.Drawing.Size(104, 37);
            this.NPC2HP.TabIndex = 16;
            this.NPC2HP.Value = 100;
            // 
            // AttackButton
            // 
            this.AttackButton.BackColor = System.Drawing.Color.Maroon;
            this.AttackButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.AttackButton.Location = new System.Drawing.Point(291, 464);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(144, 49);
            this.AttackButton.TabIndex = 11;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = false;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // SkipButton
            // 
            this.SkipButton.BackColor = System.Drawing.Color.Tan;
            this.SkipButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.SkipButton.Location = new System.Drawing.Point(438, 464);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(107, 49);
            this.SkipButton.TabIndex = 12;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = false;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // DialogWindow
            // 
            this.DialogWindow.BackColor = System.Drawing.Color.DarkKhaki;
            this.DialogWindow.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.DialogWindow.Location = new System.Drawing.Point(291, 320);
            this.DialogWindow.Name = "DialogWindow";
            this.DialogWindow.Size = new System.Drawing.Size(254, 138);
            this.DialogWindow.TabIndex = 13;
            this.DialogWindow.TabStop = false;
            // 
            // NPC1Picture
            // 
            this.NPC1Picture.BackgroundImage = global::ConsoleApp1.Properties.Resources.wolf31;
            this.NPC1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NPC1Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NPC1Picture.Image = global::ConsoleApp1.Properties.Resources.wolf3;
            this.NPC1Picture.Location = new System.Drawing.Point(0, 0);
            this.NPC1Picture.Name = "NPC1Picture";
            this.NPC1Picture.Size = new System.Drawing.Size(182, 171);
            this.NPC1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NPC1Picture.TabIndex = 14;
            this.NPC1Picture.TabStop = false;
            this.NPC1Picture.Click += new System.EventHandler(this.NPC1Picture_Click);
            // 
            // NPC1Interface
            // 
            this.NPC1Interface.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NPC1Interface.Controls.Add(this.NPC1HealthBar);
            this.NPC1Interface.Controls.Add(this.NPC1Picture);
            this.NPC1Interface.Controls.Add(this.NPC1HP);
            this.NPC1Interface.Controls.Add(this.NPC1Level);
            this.NPC1Interface.Controls.Add(this.NPC1Attack);
            this.NPC1Interface.Location = new System.Drawing.Point(17, 12);
            this.NPC1Interface.Name = "NPC1Interface";
            this.NPC1Interface.Size = new System.Drawing.Size(284, 171);
            this.NPC1Interface.TabIndex = 11;
            this.NPC1Interface.TabStop = false;
            // 
            // NPC1HealthBar
            // 
            this.NPC1HealthBar.BackColor = System.Drawing.Color.DarkRed;
            this.NPC1HealthBar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.NPC1HealthBar.Location = new System.Drawing.Point(179, -19);
            this.NPC1HealthBar.Name = "NPC1HealthBar";
            this.NPC1HealthBar.Size = new System.Drawing.Size(106, 56);
            this.NPC1HealthBar.TabIndex = 14;
            this.NPC1HealthBar.TabStop = false;
            // 
            // NPC1HP
            // 
            this.NPC1HP.Location = new System.Drawing.Point(179, 7);
            this.NPC1HP.Name = "NPC1HP";
            this.NPC1HP.Size = new System.Drawing.Size(106, 37);
            this.NPC1HP.TabIndex = 15;
            this.NPC1HP.Value = 100;
            // 
            // NPC1Level
            // 
            this.NPC1Level.BackColor = System.Drawing.Color.LemonChiffon;
            this.NPC1Level.Cursor = System.Windows.Forms.Cursors.Default;
            this.NPC1Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPC1Level.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.NPC1Level.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NPC1Level.Location = new System.Drawing.Point(181, 61);
            this.NPC1Level.Name = "NPC1Level";
            this.NPC1Level.Size = new System.Drawing.Size(104, 37);
            this.NPC1Level.TabIndex = 8;
            this.NPC1Level.TabStop = false;
            // 
            // NPC1Attack
            // 
            this.NPC1Attack.BackColor = System.Drawing.Color.LemonChiffon;
            this.NPC1Attack.Cursor = System.Windows.Forms.Cursors.Default;
            this.NPC1Attack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NPC1Attack.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.NPC1Attack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NPC1Attack.Location = new System.Drawing.Point(181, 117);
            this.NPC1Attack.Name = "NPC1Attack";
            this.NPC1Attack.Size = new System.Drawing.Size(104, 37);
            this.NPC1Attack.TabIndex = 8;
            this.NPC1Attack.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Black;
            this.groupBox6.Controls.Add(this.StealButton);
            this.groupBox6.Controls.Add(this.UseButton);
            this.groupBox6.Controls.Add(this.Inventory6);
            this.groupBox6.Controls.Add(this.Inventory3);
            this.groupBox6.Controls.Add(this.Inventory5);
            this.groupBox6.Controls.Add(this.Inventory4);
            this.groupBox6.Controls.Add(this.Inventory2);
            this.groupBox6.Controls.Add(this.Inventory1);
            this.groupBox6.Location = new System.Drawing.Point(551, 320);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 193);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // StealButton
            // 
            this.StealButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.StealButton.Location = new System.Drawing.Point(154, 144);
            this.StealButton.Name = "StealButton";
            this.StealButton.Size = new System.Drawing.Size(92, 49);
            this.StealButton.TabIndex = 4;
            this.StealButton.Text = "Steal";
            this.StealButton.UseVisualStyleBackColor = true;
            this.StealButton.Click += new System.EventHandler(this.StealButton_Click);
            // 
            // UseButton
            // 
            this.UseButton.BackColor = System.Drawing.Color.Orange;
            this.UseButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.UseButton.Location = new System.Drawing.Point(6, 144);
            this.UseButton.Name = "UseButton";
            this.UseButton.Size = new System.Drawing.Size(136, 49);
            this.UseButton.TabIndex = 3;
            this.UseButton.Text = "Use";
            this.UseButton.UseVisualStyleBackColor = false;
            this.UseButton.Click += new System.EventHandler(this.UseButton_Click);
            // 
            // Inventory6
            // 
            this.Inventory6.BackColor = System.Drawing.Color.White;
            this.Inventory6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inventory6.BackgroundImage")));
            this.Inventory6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory6.Location = new System.Drawing.Point(179, 78);
            this.Inventory6.Name = "Inventory6";
            this.Inventory6.Size = new System.Drawing.Size(61, 60);
            this.Inventory6.TabIndex = 2;
            this.Inventory6.TabStop = false;
            // 
            // Inventory3
            // 
            this.Inventory3.BackColor = System.Drawing.Color.White;
            this.Inventory3.BackgroundImage = global::ConsoleApp1.Properties.Resources.potion;
            this.Inventory3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory3.Location = new System.Drawing.Point(179, 11);
            this.Inventory3.Name = "Inventory3";
            this.Inventory3.Size = new System.Drawing.Size(61, 60);
            this.Inventory3.TabIndex = 2;
            this.Inventory3.TabStop = false;
            this.Inventory3.Click += new System.EventHandler(this.Inventory3_Click);
            // 
            // Inventory5
            // 
            this.Inventory5.BackColor = System.Drawing.Color.White;
            this.Inventory5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inventory5.BackgroundImage")));
            this.Inventory5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory5.Location = new System.Drawing.Point(92, 78);
            this.Inventory5.Name = "Inventory5";
            this.Inventory5.Size = new System.Drawing.Size(61, 60);
            this.Inventory5.TabIndex = 1;
            this.Inventory5.TabStop = false;
            // 
            // Inventory4
            // 
            this.Inventory4.BackColor = System.Drawing.Color.White;
            this.Inventory4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inventory4.BackgroundImage")));
            this.Inventory4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory4.Location = new System.Drawing.Point(6, 78);
            this.Inventory4.Name = "Inventory4";
            this.Inventory4.Size = new System.Drawing.Size(61, 60);
            this.Inventory4.TabIndex = 0;
            this.Inventory4.TabStop = false;
            // 
            // Inventory2
            // 
            this.Inventory2.BackColor = System.Drawing.Color.White;
            this.Inventory2.BackgroundImage = global::ConsoleApp1.Properties.Resources.torch;
            this.Inventory2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory2.Location = new System.Drawing.Point(92, 11);
            this.Inventory2.Name = "Inventory2";
            this.Inventory2.Size = new System.Drawing.Size(61, 60);
            this.Inventory2.TabIndex = 1;
            this.Inventory2.TabStop = false;
            this.Inventory2.Click += new System.EventHandler(this.Inventory2_Click);
            // 
            // Inventory1
            // 
            this.Inventory1.BackColor = System.Drawing.Color.Transparent;
            this.Inventory1.BackgroundImage = global::ConsoleApp1.Properties.Resources.sword1;
            this.Inventory1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inventory1.Location = new System.Drawing.Point(6, 11);
            this.Inventory1.Name = "Inventory1";
            this.Inventory1.Size = new System.Drawing.Size(61, 60);
            this.Inventory1.TabIndex = 0;
            this.Inventory1.TabStop = false;
            // 
            // TraderPicture
            // 
            this.TraderPicture.BackgroundImage = global::ConsoleApp1.Properties.Resources.trader;
            this.TraderPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TraderPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TraderPicture.Location = new System.Drawing.Point(255, 11);
            this.TraderPicture.Name = "TraderPicture";
            this.TraderPicture.Size = new System.Drawing.Size(114, 80);
            this.TraderPicture.TabIndex = 15;
            this.TraderPicture.TabStop = false;
            this.TraderPicture.Click += new System.EventHandler(this.TraderPicture_Click);
            // 
            // TraderInteface
            // 
            this.TraderInteface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TraderInteface.Controls.Add(this.TraderSell);
            this.TraderInteface.Controls.Add(this.TraderBuy);
            this.TraderInteface.Controls.Add(this.TraderGold);
            this.TraderInteface.Controls.Add(this.TraderAttack);
            this.TraderInteface.Controls.Add(this.TraderHealth);
            this.TraderInteface.Controls.Add(this.TraderPicture);
            this.TraderInteface.Controls.Add(this.TradeSlot6);
            this.TraderInteface.Controls.Add(this.TradeSlot3);
            this.TraderInteface.Controls.Add(this.TradeSlot5);
            this.TraderInteface.Controls.Add(this.TradeSlot4);
            this.TraderInteface.Controls.Add(this.TradeSlot2);
            this.TraderInteface.Controls.Add(this.TradeSlot1);
            this.TraderInteface.Location = new System.Drawing.Point(423, 12);
            this.TraderInteface.Name = "TraderInteface";
            this.TraderInteface.Size = new System.Drawing.Size(374, 193);
            this.TraderInteface.TabIndex = 14;
            this.TraderInteface.TabStop = false;
            // 
            // TraderSell
            // 
            this.TraderSell.BackColor = System.Drawing.Color.Maroon;
            this.TraderSell.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.TraderSell.Location = new System.Drawing.Point(132, 148);
            this.TraderSell.Name = "TraderSell";
            this.TraderSell.Size = new System.Drawing.Size(116, 36);
            this.TraderSell.TabIndex = 17;
            this.TraderSell.Text = "Sell";
            this.TraderSell.UseVisualStyleBackColor = false;
            this.TraderSell.Click += new System.EventHandler(this.TraderSell_Click);
            // 
            // TraderBuy
            // 
            this.TraderBuy.BackColor = System.Drawing.Color.Maroon;
            this.TraderBuy.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.TraderBuy.Location = new System.Drawing.Point(6, 148);
            this.TraderBuy.Name = "TraderBuy";
            this.TraderBuy.Size = new System.Drawing.Size(120, 36);
            this.TraderBuy.TabIndex = 16;
            this.TraderBuy.Text = "Buy";
            this.TraderBuy.UseVisualStyleBackColor = false;
            this.TraderBuy.Click += new System.EventHandler(this.TraderBuy_Click);
            // 
            // TraderGold
            // 
            this.TraderGold.BackColor = System.Drawing.Color.LemonChiffon;
            this.TraderGold.Cursor = System.Windows.Forms.Cursors.Default;
            this.TraderGold.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TraderGold.Location = new System.Drawing.Point(254, 161);
            this.TraderGold.Name = "TraderGold";
            this.TraderGold.Size = new System.Drawing.Size(115, 26);
            this.TraderGold.TabIndex = 12;
            this.TraderGold.TabStop = false;
            // 
            // TraderAttack
            // 
            this.TraderAttack.BackColor = System.Drawing.Color.LemonChiffon;
            this.TraderAttack.Cursor = System.Windows.Forms.Cursors.Default;
            this.TraderAttack.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TraderAttack.Location = new System.Drawing.Point(254, 129);
            this.TraderAttack.Name = "TraderAttack";
            this.TraderAttack.Size = new System.Drawing.Size(115, 26);
            this.TraderAttack.TabIndex = 12;
            this.TraderAttack.TabStop = false;
            // 
            // TraderHealth
            // 
            this.TraderHealth.BackColor = System.Drawing.Color.LemonChiffon;
            this.TraderHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.TraderHealth.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TraderHealth.Location = new System.Drawing.Point(254, 97);
            this.TraderHealth.Name = "TraderHealth";
            this.TraderHealth.Size = new System.Drawing.Size(115, 26);
            this.TraderHealth.TabIndex = 11;
            this.TraderHealth.TabStop = false;
            // 
            // TradeSlot6
            // 
            this.TradeSlot6.Image = ((System.Drawing.Image)(resources.GetObject("TradeSlot6.Image")));
            this.TradeSlot6.Location = new System.Drawing.Point(179, 78);
            this.TradeSlot6.Name = "TradeSlot6";
            this.TradeSlot6.Size = new System.Drawing.Size(61, 60);
            this.TradeSlot6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TradeSlot6.TabIndex = 2;
            this.TradeSlot6.TabStop = false;
            // 
            // TradeSlot3
            // 
            this.TradeSlot3.Image = ((System.Drawing.Image)(resources.GetObject("TradeSlot3.Image")));
            this.TradeSlot3.Location = new System.Drawing.Point(179, 11);
            this.TradeSlot3.Name = "TradeSlot3";
            this.TradeSlot3.Size = new System.Drawing.Size(61, 60);
            this.TradeSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TradeSlot3.TabIndex = 2;
            this.TradeSlot3.TabStop = false;
            // 
            // TradeSlot5
            // 
            this.TradeSlot5.Image = ((System.Drawing.Image)(resources.GetObject("TradeSlot5.Image")));
            this.TradeSlot5.Location = new System.Drawing.Point(92, 78);
            this.TradeSlot5.Name = "TradeSlot5";
            this.TradeSlot5.Size = new System.Drawing.Size(61, 60);
            this.TradeSlot5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TradeSlot5.TabIndex = 1;
            this.TradeSlot5.TabStop = false;
            // 
            // TradeSlot4
            // 
            this.TradeSlot4.Image = ((System.Drawing.Image)(resources.GetObject("TradeSlot4.Image")));
            this.TradeSlot4.Location = new System.Drawing.Point(6, 78);
            this.TradeSlot4.Name = "TradeSlot4";
            this.TradeSlot4.Size = new System.Drawing.Size(61, 60);
            this.TradeSlot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TradeSlot4.TabIndex = 0;
            this.TradeSlot4.TabStop = false;
            // 
            // TradeSlot2
            // 
            this.TradeSlot2.Image = ((System.Drawing.Image)(resources.GetObject("TradeSlot2.Image")));
            this.TradeSlot2.Location = new System.Drawing.Point(92, 11);
            this.TradeSlot2.Name = "TradeSlot2";
            this.TradeSlot2.Size = new System.Drawing.Size(61, 60);
            this.TradeSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TradeSlot2.TabIndex = 1;
            this.TradeSlot2.TabStop = false;
            // 
            // TradeSlot1
            // 
            this.TradeSlot1.Image = global::ConsoleApp1.Properties.Resources.potion;
            this.TradeSlot1.Location = new System.Drawing.Point(6, 11);
            this.TradeSlot1.Name = "TradeSlot1";
            this.TradeSlot1.Size = new System.Drawing.Size(61, 60);
            this.TradeSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TradeSlot1.TabIndex = 0;
            this.TradeSlot1.TabStop = false;
            this.TradeSlot1.Click += new System.EventHandler(this.TradeSlot1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApp1.Properties.Resources.dungeon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 515);
            this.Controls.Add(this.TraderInteface);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayerInteface);
            this.Controls.Add(this.NPC2Interface);
            this.Controls.Add(this.DialogWindow);
            this.Controls.Add(this.NPC1Interface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PlayerInteface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NPC2Picture)).EndInit();
            this.NPC2Interface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NPC1Picture)).EndInit();
            this.NPC1Interface.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Inventory6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraderPicture)).EndInit();
            this.TraderInteface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradeSlot1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PlayerInteface;
        private System.Windows.Forms.PictureBox NPC2Picture;
        private System.Windows.Forms.GroupBox NPC2Interface;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.GroupBox DialogWindow;
        private System.Windows.Forms.PictureBox NPC1Picture;
        private System.Windows.Forms.GroupBox NPC1Interface;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox Inventory6;
        private System.Windows.Forms.PictureBox Inventory3;
        private System.Windows.Forms.PictureBox Inventory5;
        private System.Windows.Forms.PictureBox Inventory4;
        private System.Windows.Forms.PictureBox Inventory2;
        private System.Windows.Forms.PictureBox Inventory1;
        private System.Windows.Forms.GroupBox NPC1Attack;
        private System.Windows.Forms.GroupBox NPC1Level;
        private System.Windows.Forms.ProgressBar NPC2HP;
        private System.Windows.Forms.ProgressBar NPC1HP;
        private System.Windows.Forms.GroupBox NPC2Attack;
        private System.Windows.Forms.GroupBox NPC2Level;
        private System.Windows.Forms.ProgressBar PlayerHealth;
        private System.Windows.Forms.PictureBox TraderPicture;
        private System.Windows.Forms.GroupBox TraderInteface;
        private System.Windows.Forms.PictureBox TradeSlot6;
        private System.Windows.Forms.PictureBox TradeSlot3;
        private System.Windows.Forms.PictureBox TradeSlot5;
        private System.Windows.Forms.PictureBox TradeSlot4;
        private System.Windows.Forms.PictureBox TradeSlot2;
        private System.Windows.Forms.PictureBox TradeSlot1;
        private System.Windows.Forms.Button StealButton;
        private System.Windows.Forms.Button UseButton;
        private System.Windows.Forms.Button TraderSell;
        private System.Windows.Forms.Button TraderBuy;
        private System.Windows.Forms.GroupBox TraderGold;
        private System.Windows.Forms.GroupBox TraderAttack;
        private System.Windows.Forms.GroupBox TraderHealth;
        private System.Windows.Forms.GroupBox PlayerGold;
        private System.Windows.Forms.GroupBox PlayerAttack;
        private System.Windows.Forms.GroupBox PlayerLevel;
        private System.Windows.Forms.GroupBox PlayerHealthBar;
        private System.Windows.Forms.GroupBox NPC2HealthBar;
        private System.Windows.Forms.GroupBox NPC1HealthBar;
    }
}