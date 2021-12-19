
namespace vehicleSeller
{
    partial class customers
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
            this.phone = new System.Windows.Forms.TextBox();
            this.psurname = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.list_p = new System.Windows.Forms.Button();
            this.list_c = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(480, 44);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(188, 22);
            this.phone.TabIndex = 0;
            // 
            // psurname
            // 
            this.psurname.Location = new System.Drawing.Point(255, 197);
            this.psurname.Name = "psurname";
            this.psurname.Size = new System.Drawing.Size(188, 22);
            this.psurname.TabIndex = 1;
            this.psurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(253, 131);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(190, 22);
            this.pname.TabIndex = 3;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(48, 131);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(189, 22);
            this.cname.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Company Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Person Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(928, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(928, 24);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(380, 38);
            this.list.TabIndex = 8;
            this.list.Text = "List All of Customers";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(928, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(380, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete Customer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone(Enter with no zero)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Surname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 310);
            this.dataGridView1.TabIndex = 15;
            // 
            // list_p
            // 
            this.list_p.Location = new System.Drawing.Point(1119, 71);
            this.list_p.Name = "list_p";
            this.list_p.Size = new System.Drawing.Size(189, 38);
            this.list_p.TabIndex = 16;
            this.list_p.Text = "List Person Customers";
            this.list_p.UseVisualStyleBackColor = true;
            this.list_p.Click += new System.EventHandler(this.list_p_Click);
            // 
            // list_c
            // 
            this.list_c.Location = new System.Drawing.Point(928, 71);
            this.list_c.Name = "list_c";
            this.list_c.Size = new System.Drawing.Size(185, 38);
            this.list_c.TabIndex = 17;
            this.list_c.Text = "List Company Customers";
            this.list_c.UseVisualStyleBackColor = true;
            this.list_c.Click += new System.EventHandler(this.list_c_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(480, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(329, 133);
            this.dataGridView2.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1195, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 22);
            this.button4.TabIndex = 53;
            this.button4.Text = "\\/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(880, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Searchbox:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(990, 229);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(193, 22);
            this.search.TabIndex = 51;
            // 
            // customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 605);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.list_c);
            this.Controls.Add(this.list_p);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.psurname);
            this.Controls.Add(this.phone);
            this.Name = "customers";
            this.Text = "customers";
            this.Load += new System.EventHandler(this.customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox psurname;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button list_p;
        private System.Windows.Forms.Button list_c;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox search;
    }
}