namespace Lab_2
{
    partial class Form2
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
            this.Length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F2_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Number_Of_Room = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(223, 89);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(142, 22);
            this.Length.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Метраж";
            // 
            // F2_Search
            // 
            this.F2_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.F2_Search.Location = new System.Drawing.Point(137, 214);
            this.F2_Search.Name = "F2_Search";
            this.F2_Search.Size = new System.Drawing.Size(147, 49);
            this.F2_Search.TabIndex = 2;
            this.F2_Search.Text = "Search";
            this.F2_Search.UseVisualStyleBackColor = true;
            this.F2_Search.Click += new System.EventHandler(this.F2_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество комнат";
            // 
            // Number_Of_Room
            // 
            this.Number_Of_Room.Location = new System.Drawing.Point(223, 126);
            this.Number_Of_Room.Name = "Number_Of_Room";
            this.Number_Of_Room.Size = new System.Drawing.Size(142, 22);
            this.Number_Of_Room.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Этаж";
            // 
            // Floor
            // 
            this.Floor.Location = new System.Drawing.Point(223, 159);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(142, 22);
            this.Floor.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 533);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Number_Of_Room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F2_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Length);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F2_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Number_Of_Room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Floor;
    }
}