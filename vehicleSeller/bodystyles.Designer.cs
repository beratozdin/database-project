
namespace vehicleSeller
{
    partial class bodystyles
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
            this.bodyname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyname
            // 
            this.bodyname.Location = new System.Drawing.Point(165, 39);
            this.bodyname.Name = "bodyname";
            this.bodyname.Size = new System.Drawing.Size(172, 22);
            this.bodyname.TabIndex = 25;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(49, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(110, 17);
            this.name.TabIndex = 24;
            this.name.Text = "Bodystyle Name";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1033, 15);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 71);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(829, 15);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(198, 71);
            this.update.TabIndex = 22;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(625, 15);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(198, 71);
            this.add.TabIndex = 21;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(421, 15);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(198, 71);
            this.list.TabIndex = 20;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 395);
            this.dataGridView1.TabIndex = 19;
            // 
            // bodystyles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 572);
            this.Controls.Add(this.bodyname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bodystyles";
            this.Text = "bodystyles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bodyname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}