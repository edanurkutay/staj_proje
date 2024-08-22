namespace staj_proje
{
    partial class ViewCustumorPage
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
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AllowUserToDeleteRows = false;
            this.customerGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(12, 148);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.ReadOnly = true;
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(603, 253);
            this.customerGridView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PeachPuff;
            this.backButton.Location = new System.Drawing.Point(686, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(124, 66);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Geri";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteCustomerButton.Location = new System.Drawing.Point(686, 208);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(124, 66);
            this.deleteCustomerButton.TabIndex = 11;
            this.deleteCustomerButton.Text = "Müşteri Sil";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "AKTİF MÜŞTERİLER LİSTESİ";
            // 
            // ViewCustumorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.customerGridView);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewCustumorPage";
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.ViewCustumorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Label label1;
    }
}