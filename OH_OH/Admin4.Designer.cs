
namespace OH_OH
{
    partial class FormAM4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAM4));
            this.dataHistoryAM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchhistory = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalnumbertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalcosttextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Typehistory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHistoryAM
            // 
            this.dataHistoryAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoryAM.Location = new System.Drawing.Point(66, 12);
            this.dataHistoryAM.Name = "dataHistoryAM";
            this.dataHistoryAM.Size = new System.Drawing.Size(853, 212);
            this.dataHistoryAM.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(487, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "ปริ้น";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Navy;
            this.Backbutton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Location = new System.Drawing.Point(936, 707);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(107, 40);
            this.Backbutton.TabIndex = 17;
            this.Backbutton.Text = "ย้อนกลับ";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(290, 262);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(328, 30);
            this.searchBox.TabIndex = 18;
            // 
            // searchhistory
            // 
            this.searchhistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchhistory.Font = new System.Drawing.Font("JasmineUPC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchhistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchhistory.Location = new System.Drawing.Point(653, 259);
            this.searchhistory.Name = "searchhistory";
            this.searchhistory.Size = new System.Drawing.Size(93, 44);
            this.searchhistory.TabIndex = 19;
            this.searchhistory.Text = "ค้นหา";
            this.searchhistory.UseVisualStyleBackColor = false;
            this.searchhistory.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dateTime1
            // 
            this.dateTime1.CustomFormat = "yyyy-MM-dd";
            this.dateTime1.Font = new System.Drawing.Font("JasmineUPC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime1.Location = new System.Drawing.Point(255, 320);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(208, 35);
            this.dateTime1.TabIndex = 23;
            // 
            // dateTime2
            // 
            this.dateTime2.CustomFormat = "yyyy-MM-dd";
            this.dateTime2.Font = new System.Drawing.Font("JasmineUPC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime2.Location = new System.Drawing.Point(609, 322);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(208, 35);
            this.dateTime2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "ตั้งแต่";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(498, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "สิ้นสุด";
            // 
            // TotalnumbertextBox
            // 
            this.TotalnumbertextBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalnumbertextBox.Location = new System.Drawing.Point(450, 456);
            this.TotalnumbertextBox.Multiline = true;
            this.TotalnumbertextBox.Name = "TotalnumbertextBox";
            this.TotalnumbertextBox.ReadOnly = true;
            this.TotalnumbertextBox.Size = new System.Drawing.Size(168, 41);
            this.TotalnumbertextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(204, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "จำนวนสินค้าทั้งหมด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(655, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "ชิ้น";
            // 
            // TotalcosttextBox
            // 
            this.TotalcosttextBox.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalcosttextBox.Location = new System.Drawing.Point(450, 545);
            this.TotalcosttextBox.Multiline = true;
            this.TotalcosttextBox.Name = "TotalcosttextBox";
            this.TotalcosttextBox.ReadOnly = true;
            this.TotalcosttextBox.Size = new System.Drawing.Size(168, 41);
            this.TotalcosttextBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(204, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 37);
            this.label5.TabIndex = 31;
            this.label5.Text = "ยอดทั้งสิ้น";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("JasmineUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(655, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 37);
            this.label6.TabIndex = 32;
            this.label6.Text = "บาท";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Yellow;
            this.button.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(925, 75);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(81, 30);
            this.button.TabIndex = 34;
            this.button.Text = "refresh";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(165, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 480);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Typehistory
            // 
            this.Typehistory.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typehistory.FormattingEnabled = true;
            this.Typehistory.Items.AddRange(new object[] {
            "สินค้าทั้งหมด",
            "สุขภัณฑ์ครัวเรือน",
            "เครื่องปรุง",
            "อาหารสำเร็จรูป",
            "อาหารว่าง",
            "เครื่องดื่ม"});
            this.Typehistory.Location = new System.Drawing.Point(450, 382);
            this.Typehistory.Name = "Typehistory";
            this.Typehistory.Size = new System.Drawing.Size(168, 35);
            this.Typehistory.TabIndex = 36;
            this.Typehistory.Text = "สินค้าทั้งหมด";
            // 
            // FormAM4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 749);
            this.ControlBox = false;
            this.Controls.Add(this.Typehistory);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalcosttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalnumbertextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.searchhistory);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataHistoryAM);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAM4";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.FormAM4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHistoryAM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchhistory;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalnumbertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalcosttextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Typehistory;
    }
}