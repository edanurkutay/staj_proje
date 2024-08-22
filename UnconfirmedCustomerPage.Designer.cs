namespace staj_proje
{
    partial class UnconfirmedCustomerPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.customerAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "PASİF MÜŞTERİLER LİSTESİ";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteCustomerButton.Location = new System.Drawing.Point(723, 247);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(124, 66);
            this.deleteCustomerButton.TabIndex = 15;
            this.deleteCustomerButton.Text = "Müşteri Sil";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PeachPuff;
            this.backButton.Location = new System.Drawing.Point(723, 319);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(124, 66);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(51, 152);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(603, 253);
            this.customerGridView.TabIndex = 13;
            this.customerGridView.SelectionChanged += new System.EventHandler(this.customerGridView_SelectionChanged);
            // 
            // customerAccept
            // 
            this.customerAccept.BackColor = System.Drawing.Color.PeachPuff;
            this.customerAccept.Location = new System.Drawing.Point(723, 175);
            this.customerAccept.Name = "customerAccept";
            this.customerAccept.Size = new System.Drawing.Size(124, 66);
            this.customerAccept.TabIndex = 17;
            this.customerAccept.Text = "Müşteri Onayla";
            this.customerAccept.UseVisualStyleBackColor = false;
            this.customerAccept.Click += new System.EventHandler(this.customerAccept_Click);
            // 
            // UnconfirmedCustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.customerAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.customerGridView);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UnconfirmedCustomerPage";
            this.Text = "Onay Bekleyen Müşteri";
            this.Load += new System.EventHandler(this.UnconfirmedCustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Button customerAccept;
    }
}