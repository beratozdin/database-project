
namespace vehicleSeller
{
    partial class departments
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
            this.department = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(625, 10);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(198, 71);
            this.add.TabIndex = 40;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // department
            // 
            this.department.Location = new System.Drawing.Point(143, 18);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(172, 22);
            this.department.TabIndex = 39;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(14, 23);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(123, 17);
            this.namelabel.TabIndex = 38;
            this.namelabel.Text = "Department Name";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1033, 10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 71);
            this.delete.TabIndex = 37;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(829, 10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(198, 71);
            this.update.TabIndex = 36;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(421, 10);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(198, 71);
            this.list.TabIndex = 35;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 395);
            this.dataGridView1.TabIndex = 34;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(143, 59);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(172, 22);
            this.salary.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Salary";
            // 
            // departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.add);
            this.Controls.Add(this.department);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.list);
            this.Controls.Add(this.dataGridView1);
            this.Name = "departments";
            this.Text = "departments";
            this.Load += new System.EventHandler(this.departments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label1;
    }
}