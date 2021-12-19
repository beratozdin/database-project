
namespace vehicleSeller
{
    partial class vehicles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.luggage = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tonnage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.c_brand = new System.Windows.Forms.ComboBox();
            this.c_model = new System.Windows.Forms.ComboBox();
            this.c_engine = new System.Windows.Forms.ComboBox();
            this.c_body = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(993, 33);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(260, 37);
            this.delete.TabIndex = 19;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(712, 33);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(260, 37);
            this.update.TabIndex = 18;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(430, 30);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(260, 40);
            this.list.TabIndex = 16;
            this.list.Text = "List All of Vehicles";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // luggage
            // 
            this.luggage.Location = new System.Drawing.Point(223, 203);
            this.luggage.Name = "luggage";
            this.luggage.Size = new System.Drawing.Size(157, 22);
            this.luggage.TabIndex = 21;
            this.luggage.TextChanged += new System.EventHandler(this.luggage_TextChanged);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(223, 87);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(157, 22);
            this.color.TabIndex = 23;
            this.color.TextChanged += new System.EventHandler(this.color_TextChanged);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(223, 175);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(157, 22);
            this.stock.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Engine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Stock";
            // 
            // tonnage
            // 
            this.tonnage.Location = new System.Drawing.Point(223, 231);
            this.tonnage.Name = "tonnage";
            this.tonnage.Size = new System.Drawing.Size(157, 22);
            this.tonnage.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tonnage(Commercial Vehicle)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Luggage(Passenger Vehicle)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // c_brand
            // 
            this.c_brand.FormattingEnabled = true;
            this.c_brand.Location = new System.Drawing.Point(223, 30);
            this.c_brand.Name = "c_brand";
            this.c_brand.Size = new System.Drawing.Size(156, 24);
            this.c_brand.TabIndex = 41;
            // 
            // c_model
            // 
            this.c_model.FormattingEnabled = true;
            this.c_model.Location = new System.Drawing.Point(223, 58);
            this.c_model.Name = "c_model";
            this.c_model.Size = new System.Drawing.Size(156, 24);
            this.c_model.TabIndex = 42;
            // 
            // c_engine
            // 
            this.c_engine.FormattingEnabled = true;
            this.c_engine.Location = new System.Drawing.Point(223, 117);
            this.c_engine.Name = "c_engine";
            this.c_engine.Size = new System.Drawing.Size(156, 24);
            this.c_engine.TabIndex = 43;
            // 
            // c_body
            // 
            this.c_body.FormattingEnabled = true;
            this.c_body.Location = new System.Drawing.Point(223, 147);
            this.c_body.Name = "c_body";
            this.c_body.Size = new System.Drawing.Size(156, 24);
            this.c_body.TabIndex = 44;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(430, 175);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(122, 46);
            this.add.TabIndex = 17;
            this.add.Text = "Add Passenger Vehicle";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add Commercial Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 46);
            this.button2.TabIndex = 47;
            this.button2.Text = "List Commercial Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 46);
            this.button3.TabIndex = 46;
            this.button3.Text = "List Passenger Vehicle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(537, 248);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(193, 22);
            this.search.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Searchbox:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(742, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 22);
            this.button4.TabIndex = 50;
            this.button4.Text = "\\/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 593);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_body);
            this.Controls.Add(this.c_engine);
            this.Controls.Add(this.c_model);
            this.Controls.Add(this.c_brand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tonnage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.color);
            this.Controls.Add(this.luggage);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "vehicles";
            this.Text = "passengervehicles";
            this.Load += new System.EventHandler(this.passengervehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.TextBox luggage;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tonnage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox c_brand;
        private System.Windows.Forms.ComboBox c_model;
        private System.Windows.Forms.ComboBox c_engine;
        private System.Windows.Forms.ComboBox c_body;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
    }
}