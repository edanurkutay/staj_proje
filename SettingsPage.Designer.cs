namespace staj_proje
{
    partial class SettingsPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.editLabel = new System.Windows.Forms.Label();
            this.editUsernameTextBox = new System.Windows.Forms.TextBox();
            this.editAddressTextBox = new System.Windows.Forms.TextBox();
            this.editTelTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 114);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::staj_proje.Properties.Resources.settingicon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.editLabel);
            this.panel1.Controls.Add(this.editUsernameTextBox);
            this.panel1.Controls.Add(this.editAddressTextBox);
            this.panel1.Controls.Add(this.editTelTextBox);
            this.panel1.Location = new System.Drawing.Point(138, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 263);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tel";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PeachPuff;
            this.editButton.Location = new System.Drawing.Point(69, 192);
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
            // editUsernameTextBox
            // 
            this.editUsernameTextBox.Location = new System.Drawing.Point(115, 120);
            this.editUsernameTextBox.Name = "editUsernameTextBox";
            this.editUsernameTextBox.Size = new System.Drawing.Size(118, 26);
            this.editUsernameTextBox.TabIndex = 2;
            // 
            // editAddressTextBox
            // 
            this.editAddressTextBox.Location = new System.Drawing.Point(115, 88);
            this.editAddressTextBox.Name = "editAddressTextBox";
            this.editAddressTextBox.Size = new System.Drawing.Size(118, 26);
            this.editAddressTextBox.TabIndex = 1;
            // 
            // editTelTextBox
            // 
            this.editTelTextBox.Location = new System.Drawing.Point(115, 56);
            this.editTelTextBox.Name = "editTelTextBox";
            this.editTelTextBox.Size = new System.Drawing.Size(118, 26);
            this.editTelTextBox.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PeachPuff;
            this.backButton.Location = new System.Drawing.Point(487, 377);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(124, 66);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsPage";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.TextBox editUsernameTextBox;
        private System.Windows.Forms.TextBox editAddressTextBox;
        private System.Windows.Forms.TextBox editTelTextBox;
        private System.Windows.Forms.Button backButton;
    }
}