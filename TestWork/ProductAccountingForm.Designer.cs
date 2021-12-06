
namespace TestWork
{
    partial class ProductAccountingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.beginButton = new System.Windows.Forms.Button();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.multiplterTextBox = new System.Windows.Forms.TextBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.truckOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.truckTwoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productAOneLabel = new System.Windows.Forms.Label();
            this.productCOneLabel = new System.Windows.Forms.Label();
            this.productBOneLabel = new System.Windows.Forms.Label();
            this.productCTwoLabel = new System.Windows.Forms.Label();
            this.productBTwoLabel = new System.Windows.Forms.Label();
            this.productATwoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckOneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTwoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(160, 229);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(75, 23);
            this.beginButton.TabIndex = 0;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(12, 35);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(71, 20);
            this.capacityTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input store multiplier";
            // 
            // multiplterTextBox
            // 
            this.multiplterTextBox.Location = new System.Drawing.Point(12, 84);
            this.multiplterTextBox.Name = "multiplterTextBox";
            this.multiplterTextBox.Size = new System.Drawing.Size(71, 20);
            this.multiplterTextBox.TabIndex = 4;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(118, 35);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(216, 146);
            this.productDataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Factory";
            this.Column2.HeaderText = "Factory";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Count";
            this.Column3.HeaderText = "Count";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(396, 229);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TruckTwo delivering";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TruckOne delivering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ProductC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ProductB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ProductA:";
            // 
            // productAOneLabel
            // 
            this.productAOneLabel.AutoSize = true;
            this.productAOneLabel.Location = new System.Drawing.Point(421, 57);
            this.productAOneLabel.Name = "productAOneLabel";
            this.productAOneLabel.Size = new System.Drawing.Size(21, 13);
            this.productAOneLabel.TabIndex = 14;
            this.productAOneLabel.Text = "##";
            // 
            // productCOneLabel
            // 
            this.productCOneLabel.AutoSize = true;
            this.productCOneLabel.Location = new System.Drawing.Point(421, 109);
            this.productCOneLabel.Name = "productCOneLabel";
            this.productCOneLabel.Size = new System.Drawing.Size(21, 13);
            this.productCOneLabel.TabIndex = 15;
            this.productCOneLabel.Text = "##";
            // 
            // productBOneLabel
            // 
            this.productBOneLabel.AutoSize = true;
            this.productBOneLabel.Location = new System.Drawing.Point(421, 84);
            this.productBOneLabel.Name = "productBOneLabel";
            this.productBOneLabel.Size = new System.Drawing.Size(21, 13);
            this.productBOneLabel.TabIndex = 16;
            this.productBOneLabel.Text = "##";
            // 
            // productCTwoLabel
            // 
            this.productCTwoLabel.AutoSize = true;
            this.productCTwoLabel.Location = new System.Drawing.Point(529, 109);
            this.productCTwoLabel.Name = "productCTwoLabel";
            this.productCTwoLabel.Size = new System.Drawing.Size(21, 13);
            this.productCTwoLabel.TabIndex = 17;
            this.productCTwoLabel.Text = "##";
            // 
            // productBTwoLabel
            // 
            this.productBTwoLabel.AutoSize = true;
            this.productBTwoLabel.Location = new System.Drawing.Point(529, 84);
            this.productBTwoLabel.Name = "productBTwoLabel";
            this.productBTwoLabel.Size = new System.Drawing.Size(21, 13);
            this.productBTwoLabel.TabIndex = 18;
            this.productBTwoLabel.Text = "##";
            // 
            // productATwoLabel
            // 
            this.productATwoLabel.AutoSize = true;
            this.productATwoLabel.Location = new System.Drawing.Point(529, 57);
            this.productATwoLabel.Name = "productATwoLabel";
            this.productATwoLabel.Size = new System.Drawing.Size(21, 13);
            this.productATwoLabel.TabIndex = 19;
            this.productATwoLabel.Text = "##";
            // 
            // ProductAccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 276);
            this.Controls.Add(this.productATwoLabel);
            this.Controls.Add(this.productBTwoLabel);
            this.Controls.Add(this.productCTwoLabel);
            this.Controls.Add(this.productBOneLabel);
            this.Controls.Add(this.productCOneLabel);
            this.Controls.Add(this.productAOneLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.multiplterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.beginButton);
            this.Name = "ProductAccountingForm";
            this.Text = "ProductAccountingForm";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckOneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTwoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox multiplterTextBox;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.BindingSource truckOneBindingSource;
        private System.Windows.Forms.BindingSource truckTwoBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label productAOneLabel;
        private System.Windows.Forms.Label productCOneLabel;
        private System.Windows.Forms.Label productBOneLabel;
        private System.Windows.Forms.Label productCTwoLabel;
        private System.Windows.Forms.Label productBTwoLabel;
        private System.Windows.Forms.Label productATwoLabel;
    }
}

