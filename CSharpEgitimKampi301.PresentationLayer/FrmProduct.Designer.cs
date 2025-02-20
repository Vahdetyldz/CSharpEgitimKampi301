namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.txtId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.Label();
            this.txt12 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductDescription = new System.Windows.Forms.RichTextBox();
            this.btnList2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(28, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(54, 16);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "Ürün ID:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(21, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(61, 16);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Ürün Adı:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(88, 18);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(223, 22);
            this.txtProductId.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(88, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(223, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(88, 425);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(97, 44);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 651);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(88, 114);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(223, 22);
            this.txtProductPrice.TabIndex = 9;
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(88, 83);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(223, 22);
            this.txtProductStock.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(12, 114);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(70, 16);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "Ürün Fiyatı";
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Location = new System.Drawing.Point(10, 83);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(72, 16);
            this.txtStock.TabIndex = 6;
            this.txtStock.Text = "Ürün Stoku";
            // 
            // txt12
            // 
            this.txt12.AutoSize = true;
            this.txt12.Location = new System.Drawing.Point(18, 312);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(64, 16);
            this.txt12.TabIndex = 11;
            this.txt12.Text = "Kategory:";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(16, 163);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(66, 16);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "Açıklama:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 475);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 44);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 525);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 44);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(88, 575);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(223, 44);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(88, 625);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(223, 44);
            this.btnGetById.TabIndex = 17;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(88, 309);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(223, 24);
            this.cmbCategory.TabIndex = 18;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(88, 160);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(223, 118);
            this.txtProductDescription.TabIndex = 19;
            this.txtProductDescription.Text = "";
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(214, 425);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(97, 44);
            this.btnList2.TabIndex = 20;
            this.btnList2.Text = "Listele2";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 699);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Label txt12;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox txtProductDescription;
        private System.Windows.Forms.Button btnList2;
    }
}