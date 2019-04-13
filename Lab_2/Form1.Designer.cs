namespace Lab_2
{
    partial class AnotherMaterial
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
            this.Length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfRoom = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.kitchen = new System.Windows.Forms.CheckBox();
            this.bath = new System.Windows.Forms.CheckBox();
            this.toilet = new System.Windows.Forms.CheckBox();
            this.basement = new System.Windows.Forms.CheckBox();
            this.balcony = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Clear_House = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberOfHouse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.apartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.TreeMaterial = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.BlockMaterial = new System.Windows.Forms.RadioButton();
            this.AnotherM = new System.Windows.Forms.RadioButton();
            this.FloatNumber = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.about = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(17, 112);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(181, 22);
            this.Length.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Квартира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "метраж";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кол-во комнат";
            // 
            // NumberOfRoom
            // 
            this.NumberOfRoom.Location = new System.Drawing.Point(17, 165);
            this.NumberOfRoom.Name = "NumberOfRoom";
            this.NumberOfRoom.Size = new System.Drawing.Size(181, 22);
            this.NumberOfRoom.TabIndex = 4;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(84, 428);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(156, 42);
            this.go.TabIndex = 5;
            this.go.Text = "Add to file of house";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.Go_Click);
            // 
            // kitchen
            // 
            this.kitchen.AutoSize = true;
            this.kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kitchen.Location = new System.Drawing.Point(42, 258);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(78, 24);
            this.kitchen.TabIndex = 6;
            this.kitchen.Text = "Кухня";
            this.kitchen.UseVisualStyleBackColor = true;
            // 
            // bath
            // 
            this.bath.AutoSize = true;
            this.bath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bath.Location = new System.Drawing.Point(42, 285);
            this.bath.Name = "bath";
            this.bath.Size = new System.Drawing.Size(169, 24);
            this.bath.TabIndex = 7;
            this.bath.Text = "Ванная комната";
            this.bath.UseVisualStyleBackColor = true;
            // 
            // toilet
            // 
            this.toilet.AutoSize = true;
            this.toilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toilet.Location = new System.Drawing.Point(42, 312);
            this.toilet.Name = "toilet";
            this.toilet.Size = new System.Drawing.Size(89, 24);
            this.toilet.TabIndex = 8;
            this.toilet.Text = "Туалет";
            this.toilet.UseVisualStyleBackColor = true;
            // 
            // basement
            // 
            this.basement.AutoSize = true;
            this.basement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basement.Location = new System.Drawing.Point(42, 339);
            this.basement.Name = "basement";
            this.basement.Size = new System.Drawing.Size(96, 24);
            this.basement.TabIndex = 9;
            this.basement.Text = "Подвал";
            this.basement.UseVisualStyleBackColor = true;
            // 
            // balcony
            // 
            this.balcony.AutoSize = true;
            this.balcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balcony.Location = new System.Drawing.Point(42, 366);
            this.balcony.Name = "balcony";
            this.balcony.Size = new System.Drawing.Size(92, 24);
            this.balcony.TabIndex = 10;
            this.balcony.Text = "Балкон";
            this.balcony.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Комнаты";
            // 
            // Clear_House
            // 
            this.Clear_House.Location = new System.Drawing.Point(380, 428);
            this.Clear_House.Name = "Clear_House";
            this.Clear_House.Size = new System.Drawing.Size(156, 42);
            this.Clear_House.TabIndex = 12;
            this.Clear_House.Text = "Clear list";
            this.Clear_House.UseVisualStyleBackColor = true;
            this.Clear_House.Click += new System.EventHandler(this.Clear_House_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(496, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = "Адресс";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(521, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Страна";
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(481, 112);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(181, 22);
            this.Country.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(521, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Город";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(481, 165);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(181, 22);
            this.City.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(521, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "улица";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(481, 218);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(181, 22);
            this.street.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(498, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Номер дома";
            // 
            // NumberOfHouse
            // 
            this.NumberOfHouse.Location = new System.Drawing.Point(481, 271);
            this.NumberOfHouse.Name = "NumberOfHouse";
            this.NumberOfHouse.Size = new System.Drawing.Size(181, 22);
            this.NumberOfHouse.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(498, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 24;
            this.label10.Text = "Квартира";
            // 
            // apartment
            // 
            this.apartment.Location = new System.Drawing.Point(481, 324);
            this.apartment.Name = "apartment";
            this.apartment.Size = new System.Drawing.Size(181, 22);
            this.apartment.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(265, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Год постройки";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(248, 112);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(181, 22);
            this.Year.TabIndex = 27;
            // 
            // TreeMaterial
            // 
            this.TreeMaterial.AutoSize = true;
            this.TreeMaterial.Checked = true;
            this.TreeMaterial.Location = new System.Drawing.Point(270, 177);
            this.TreeMaterial.Name = "TreeMaterial";
            this.TreeMaterial.Size = new System.Drawing.Size(79, 21);
            this.TreeMaterial.TabIndex = 28;
            this.TreeMaterial.TabStop = true;
            this.TreeMaterial.Text = "Дерево";
            this.TreeMaterial.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(265, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Тип материала";
            // 
            // BlockMaterial
            // 
            this.BlockMaterial.AutoSize = true;
            this.BlockMaterial.Location = new System.Drawing.Point(270, 204);
            this.BlockMaterial.Name = "BlockMaterial";
            this.BlockMaterial.Size = new System.Drawing.Size(61, 21);
            this.BlockMaterial.TabIndex = 30;
            this.BlockMaterial.Text = "Блок";
            this.BlockMaterial.UseVisualStyleBackColor = true;
            // 
            // AnotherM
            // 
            this.AnotherM.AutoSize = true;
            this.AnotherM.Location = new System.Drawing.Point(270, 231);
            this.AnotherM.Name = "AnotherM";
            this.AnotherM.Size = new System.Drawing.Size(76, 21);
            this.AnotherM.TabIndex = 31;
            this.AnotherM.Text = "Другое";
            this.AnotherM.UseVisualStyleBackColor = true;
            // 
            // FloatNumber
            // 
            this.FloatNumber.FormattingEnabled = true;
            this.FloatNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.FloatNumber.Location = new System.Drawing.Point(259, 313);
            this.FloatNumber.Name = "FloatNumber";
            this.FloatNumber.Size = new System.Drawing.Size(161, 24);
            this.FloatNumber.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(270, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 25);
            this.label13.TabIndex = 33;
            this.label13.Text = "Этаж";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(691, 27);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // about
            // 
            this.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.about.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(54, 24);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(42, 489);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(180, 64);
            this.Search.TabIndex = 37;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sort
            // 
            this.Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort.Location = new System.Drawing.Point(310, 489);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(180, 64);
            this.Sort.TabIndex = 38;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // AnotherMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 736);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FloatNumber);
            this.Controls.Add(this.AnotherM);
            this.Controls.Add(this.BlockMaterial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TreeMaterial);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.apartment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumberOfHouse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.street);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clear_House);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.balcony);
            this.Controls.Add(this.basement);
            this.Controls.Add(this.toilet);
            this.Controls.Add(this.bath);
            this.Controls.Add(this.kitchen);
            this.Controls.Add(this.go);
            this.Controls.Add(this.NumberOfRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Length);
            this.Name = "AnotherMaterial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberOfRoom;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.CheckBox kitchen;
        private System.Windows.Forms.CheckBox bath;
        private System.Windows.Forms.CheckBox toilet;
        private System.Windows.Forms.CheckBox basement;
        private System.Windows.Forms.CheckBox balcony;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Button Clear_House;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox NumberOfHouse;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox apartment;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.RadioButton TreeMaterial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton BlockMaterial;
        private System.Windows.Forms.RadioButton AnotherM;
        private System.Windows.Forms.ComboBox FloatNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton about;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Sort;
    }
}

