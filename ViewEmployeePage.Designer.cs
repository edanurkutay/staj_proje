namespace staj_proje
{
    partial class ViewEmployeePage
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
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.editLabel = new System.Windows.Forms.Label();
            this.editRoleTextBox = new System.Windows.Forms.TextBox();
            this.editJobTextBox = new System.Windows.Forms.TextBox();
            this.editUnitTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGridView
            // 
            this.employeeGridView.AllowUserToAddRows = false;
            this.employeeGridView.AllowUserToDeleteRows = false;
            this.employeeGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(14, 14);
            this.employeeGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.ReadOnly = true;
            this.employeeGridView.RowHeadersWidth = 51;
            this.employeeGridView.RowTemplate.Height = 24;
            this.employeeGridView.Size = new System.Drawing.Size(873, 241);
            this.employeeGridView.TabIndex = 0;
            this.employeeGridView.SelectionChanged += new System.EventHandler(this.employeeGridView_SelectionChanged);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteEmployeeButton.Location = new System.Drawing.Point(409, 331);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(124, 66);
            this.deleteEmployeeButton.TabIndex = 8;
            this.deleteEmployeeButton.Text = "Çalışan Sil";
            this.deleteEmployeeButton.UseVisualStyleBackColor = false;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PeachPuff;
            this.backButton.Location = new System.Drawing.Point(409, 429);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(124, 66);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(49, 356);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(0, 19);
            this.selectedLabel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.editLabel);
            this.panel1.Controls.Add(this.editRoleTextBox);
            this.panel1.Controls.Add(this.editJobTextBox);
            this.panel1.Controls.Add(this.editUnitTextBox);
            this.panel1.Location = new System.Drawing.Point(107, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 239);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rol";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "İş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Birim";
            this.label1.Visible = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PeachPuff;
            this.editButton.Location = new System.Drawing.Point(66, 164);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 45);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Kaydet";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(65, 19);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(125, 19);
            this.editLabel.TabIndex = 4;
            this.editLabel.Text = "Bilgileri Güncelle";
            // 
            // editRoleTextBox
            // 
            this.editRoleTextBox.Location = new System.Drawing.Point(69, 120);
            this.editRoleTextBox.Name = "editRoleTextBox";
            this.editRoleTextBox.Size = new System.Drawing.Size(118, 26);
            this.editRoleTextBox.TabIndex = 2;
            this.editRoleTextBox.Visible = false;
            // 
            // editJobTextBox
            // 
            this.editJobTextBox.Location = new System.Drawing.Point(69, 88);
            this.editJobTextBox.Name = "editJobTextBox";
            this.editJobTextBox.Size = new System.Drawing.Size(118, 26);
            this.editJobTextBox.TabIndex = 1;
            // 
            // editUnitTextBox
            // 
            this.editUnitTextBox.Location = new System.Drawing.Point(69, 56);
            this.editUnitTextBox.Name = "editUnitTextBox";
            this.editUnitTextBox.Size = new System.Drawing.Size(118, 26);
            this.editUnitTextBox.TabIndex = 0;
            this.editUnitTextBox.Visible = false;
            // 
            // ViewEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.employeeGridView);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewEmployeePage";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.ViewEmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox editRoleTextBox;
        private System.Windows.Forms.TextBox editJobTextBox;
        private System.Windows.Forms.TextBox editUnitTextBox;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}