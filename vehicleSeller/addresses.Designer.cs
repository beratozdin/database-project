
namespace vehicleSeller
{
    partial class addresses
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.a_delete = new System.Windows.Forms.Button();
            this.a_update = new System.Windows.Forms.Button();
            this.a_add = new System.Windows.Forms.Button();
            this.a_list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(148, 187);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // a_delete
            // 
            this.a_delete.Location = new System.Drawing.Point(142, 426);
            this.a_delete.Name = "a_delete";
            this.a_delete.Size = new System.Drawing.Size(136, 40);
            this.a_delete.TabIndex = 30;
            this.a_delete.Text = "Address Delete";
            this.a_delete.UseVisualStyleBackColor = true;
            this.a_delete.Click += new System.EventHandler(this.a_delete_Click);
            // 
            // a_update
            // 
            this.a_update.Location = new System.Drawing.Point(142, 371);
            this.a_update.Name = "a_update";
            this.a_update.Size = new System.Drawing.Size(136, 40);
            this.a_update.TabIndex = 29;
            this.a_update.Text = "Address Update";
            this.a_update.UseVisualStyleBackColor = true;
            this.a_update.Click += new System.EventHandler(this.a_update_Click);
            // 
            // a_add
            // 
            this.a_add.Location = new System.Drawing.Point(142, 325);
            this.a_add.Name = "a_add";
            this.a_add.Size = new System.Drawing.Size(136, 40);
            this.a_add.TabIndex = 28;
            this.a_add.Text = "Address Add";
            this.a_add.UseVisualStyleBackColor = true;
            this.a_add.Click += new System.EventHandler(this.button6_Click);
            // 
            // a_list
            // 
            this.a_list.Location = new System.Drawing.Point(142, 279);
            this.a_list.Name = "a_list";
            this.a_list.Size = new System.Drawing.Size(136, 40);
            this.a_list.TabIndex = 27;
            this.a_list.Text = "Address List";
            this.a_list.UseVisualStyleBackColor = true;
            this.a_list.Click += new System.EventHandler(this.a_list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 502);
            this.dataGridView1.TabIndex = 25;
            // 
            // addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 590);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.a_delete);
            this.Controls.Add(this.a_update);
            this.Controls.Add(this.a_add);
            this.Controls.Add(this.a_list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "addresses";
            this.Text = "adresses";
            this.Load += new System.EventHandler(this.addresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button a_delete;
        private System.Windows.Forms.Button a_update;
        private System.Windows.Forms.Button a_add;
        private System.Windows.Forms.Button a_list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}