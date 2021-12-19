
namespace vehicleSeller
{
    partial class stocks
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
            this.add = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(645, 10);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(198, 71);
            this.add.TabIndex = 33;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(143, 20);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(172, 22);
            this.stock.TabIndex = 32;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(44, 20);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(103, 17);
            this.namelabel.TabIndex = 31;
            this.namelabel.Text = "Stock(Number)";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1053, 10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 71);
            this.delete.TabIndex = 30;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(849, 10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(198, 71);
            this.update.TabIndex = 29;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(441, 10);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(198, 71);
            this.list.TabIndex = 28;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 395);
            this.dataGridView1.TabIndex = 27;
            // 
            // stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 563);
            this.Controls.Add(this.add);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stocks";
            this.Text = "stocks";
            this.Load += new System.EventHandler(this.stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}