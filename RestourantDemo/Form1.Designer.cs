namespace RestourantDemo
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblVegetarian = new System.Windows.Forms.Label();
            this.lblVegan = new System.Windows.Forms.Label();
            this.lblGlutenFree = new System.Windows.Forms.Label();
            this.lblKosher = new System.Windows.Forms.Label();
            this.chkIsVegetarian = new System.Windows.Forms.CheckBox();
            this.chkIsVegan = new System.Windows.Forms.CheckBox();
            this.chkIsGlutenFree = new System.Windows.Forms.CheckBox();
            this.chkIsKosher = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 121);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(113, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(83, 170);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(293, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 173);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(23, 215);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(36, 13);
            this.lblImage.TabIndex = 6;
            this.lblImage.Text = "Image";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(93, 206);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(81, 36);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblVegetarian
            // 
            this.lblVegetarian.AutoSize = true;
            this.lblVegetarian.Location = new System.Drawing.Point(14, 263);
            this.lblVegetarian.Name = "lblVegetarian";
            this.lblVegetarian.Size = new System.Drawing.Size(58, 13);
            this.lblVegetarian.TabIndex = 9;
            this.lblVegetarian.Text = "Vegetarian";
            // 
            // lblVegan
            // 
            this.lblVegan.AutoSize = true;
            this.lblVegan.Location = new System.Drawing.Point(21, 300);
            this.lblVegan.Name = "lblVegan";
            this.lblVegan.Size = new System.Drawing.Size(38, 13);
            this.lblVegan.TabIndex = 10;
            this.lblVegan.Text = "Vegan";
            // 
            // lblGlutenFree
            // 
            this.lblGlutenFree.AutoSize = true;
            this.lblGlutenFree.Location = new System.Drawing.Point(14, 342);
            this.lblGlutenFree.Name = "lblGlutenFree";
            this.lblGlutenFree.Size = new System.Drawing.Size(62, 13);
            this.lblGlutenFree.TabIndex = 11;
            this.lblGlutenFree.Text = "Gluten Free";
            // 
            // lblKosher
            // 
            this.lblKosher.AutoSize = true;
            this.lblKosher.Location = new System.Drawing.Point(23, 378);
            this.lblKosher.Name = "lblKosher";
            this.lblKosher.Size = new System.Drawing.Size(40, 13);
            this.lblKosher.TabIndex = 12;
            this.lblKosher.Text = "Kosher";
            // 
            // chkIsVegetarian
            // 
            this.chkIsVegetarian.AutoSize = true;
            this.chkIsVegetarian.Location = new System.Drawing.Point(112, 263);
            this.chkIsVegetarian.Name = "chkIsVegetarian";
            this.chkIsVegetarian.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegetarian.TabIndex = 13;
            this.chkIsVegetarian.UseVisualStyleBackColor = true;
            // 
            // chkIsVegan
            // 
            this.chkIsVegan.AutoSize = true;
            this.chkIsVegan.Location = new System.Drawing.Point(112, 299);
            this.chkIsVegan.Name = "chkIsVegan";
            this.chkIsVegan.Size = new System.Drawing.Size(15, 14);
            this.chkIsVegan.TabIndex = 14;
            this.chkIsVegan.UseVisualStyleBackColor = true;
            // 
            // chkIsGlutenFree
            // 
            this.chkIsGlutenFree.AutoSize = true;
            this.chkIsGlutenFree.Location = new System.Drawing.Point(112, 342);
            this.chkIsGlutenFree.Name = "chkIsGlutenFree";
            this.chkIsGlutenFree.Size = new System.Drawing.Size(15, 14);
            this.chkIsGlutenFree.TabIndex = 15;
            this.chkIsGlutenFree.UseVisualStyleBackColor = true;
            // 
            // chkIsKosher
            // 
            this.chkIsKosher.AutoSize = true;
            this.chkIsKosher.Location = new System.Drawing.Point(112, 378);
            this.chkIsKosher.Name = "chkIsKosher";
            this.chkIsKosher.Size = new System.Drawing.Size(15, 14);
            this.chkIsKosher.TabIndex = 16;
            this.chkIsKosher.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(24, 469);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(129, 41);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 469);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 41);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 41);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 416);
            this.dataGridView1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(199, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 213);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(199, 469);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(135, 41);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 597);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.chkIsKosher);
            this.Controls.Add(this.chkIsGlutenFree);
            this.Controls.Add(this.chkIsVegan);
            this.Controls.Add(this.chkIsVegetarian);
            this.Controls.Add(this.lblKosher);
            this.Controls.Add(this.lblGlutenFree);
            this.Controls.Add(this.lblVegan);
            this.Controls.Add(this.lblVegetarian);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblVegetarian;
        private System.Windows.Forms.Label lblVegan;
        private System.Windows.Forms.Label lblGlutenFree;
        private System.Windows.Forms.Label lblKosher;
        private System.Windows.Forms.CheckBox chkIsVegetarian;
        private System.Windows.Forms.CheckBox chkIsVegan;
        private System.Windows.Forms.CheckBox chkIsGlutenFree;
        private System.Windows.Forms.CheckBox chkIsKosher;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}

