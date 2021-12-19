
namespace vehicleSeller
{
    partial class engines
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
            this.enginename = new System.Windows.Forms.TextBox();
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
            this.add.Location = new System.Drawing.Point(643, 8);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(198, 71);
            this.add.TabIndex = 26;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // enginename
            // 
            this.enginename.Location = new System.Drawing.Point(141, 18);
            this.enginename.Name = "enginename";
            this.enginename.Size = new System.Drawing.Size(172, 22);
            this.enginename.TabIndex = 25;
            this.enginename.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(42, 18);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(93, 17);
            this.namelabel.TabIndex = 24;
            this.namelabel.Text = "Engine Name";
            this.namelabel.Click += new System.EventHandler(this.brandname_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1051, 8);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 71);
            this.delete.TabIndex = 23;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(847, 8);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(198, 71);
            this.update.TabIndex = 22;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(439, 8);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(198, 71);
            this.list.TabIndex = 21;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 395);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // engines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 558);
            this.Controls.Add(this.add);
            this.Controls.Add(this.enginename);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "engines";
            this.Text = "engines";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox enginename;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}