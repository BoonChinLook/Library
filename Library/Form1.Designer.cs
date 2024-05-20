namespace Library
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.lblNumber5 = new System.Windows.Forms.Label();
            this.lblNumber6 = new System.Windows.Forms.Label();
            this.lblNumber7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtNumber4 = new System.Windows.Forms.TextBox();
            this.txtNumber5 = new System.Windows.Forms.TextBox();
            this.txtNumber6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(34, 40);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(66, 13);
            this.lblNumber1.TabIndex = 0;
            this.lblNumber1.Text = "Book Library";
            this.lblNumber1.Click += new System.EventHandler(this.lblNumber1_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(34, 68);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(58, 13);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Book Title:";
            // 
            // lblNumber3
            // 
            this.lblNumber3.AutoSize = true;
            this.lblNumber3.Location = new System.Drawing.Point(34, 94);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(41, 13);
            this.lblNumber3.TabIndex = 3;
            this.lblNumber3.Text = "Author:";
            // 
            // lblNumber4
            // 
            this.lblNumber4.AutoSize = true;
            this.lblNumber4.Location = new System.Drawing.Point(34, 119);
            this.lblNumber4.Name = "lblNumber4";
            this.lblNumber4.Size = new System.Drawing.Size(39, 13);
            this.lblNumber4.TabIndex = 2;
            this.lblNumber4.Text = "Genre:";
            // 
            // lblNumber5
            // 
            this.lblNumber5.AutoSize = true;
            this.lblNumber5.Location = new System.Drawing.Point(34, 148);
            this.lblNumber5.Name = "lblNumber5";
            this.lblNumber5.Size = new System.Drawing.Size(91, 13);
            this.lblNumber5.TabIndex = 5;
            this.lblNumber5.Text = "Book Description:";
            // 
            // lblNumber6
            // 
            this.lblNumber6.AutoSize = true;
            this.lblNumber6.Location = new System.Drawing.Point(34, 178);
            this.lblNumber6.Name = "lblNumber6";
            this.lblNumber6.Size = new System.Drawing.Size(82, 13);
            this.lblNumber6.TabIndex = 4;
            this.lblNumber6.Text = "Date Published:";
            this.lblNumber6.Click += new System.EventHandler(this.lblNumber6_Click);
            // 
            // lblNumber7
            // 
            this.lblNumber7.AutoSize = true;
            this.lblNumber7.Location = new System.Drawing.Point(38, 209);
            this.lblNumber7.Name = "lblNumber7";
            this.lblNumber7.Size = new System.Drawing.Size(53, 13);
            this.lblNumber7.TabIndex = 6;
            this.lblNumber7.Text = "Publisher:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 261);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(274, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(355, 261);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(143, 65);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(256, 20);
            this.txtNumber1.TabIndex = 12;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(143, 94);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(256, 20);
            this.txtNumber2.TabIndex = 13;
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(143, 120);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(256, 20);
            this.txtNumber3.TabIndex = 14;
            // 
            // txtNumber4
            // 
            this.txtNumber4.Location = new System.Drawing.Point(143, 149);
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Size = new System.Drawing.Size(256, 20);
            this.txtNumber4.TabIndex = 15;
            // 
            // txtNumber5
            // 
            this.txtNumber5.Location = new System.Drawing.Point(143, 178);
            this.txtNumber5.Name = "txtNumber5";
            this.txtNumber5.Size = new System.Drawing.Size(256, 20);
            this.txtNumber5.TabIndex = 16;
            // 
            // txtNumber6
            // 
            this.txtNumber6.Location = new System.Drawing.Point(143, 204);
            this.txtNumber6.Name = "txtNumber6";
            this.txtNumber6.Size = new System.Drawing.Size(256, 20);
            this.txtNumber6.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 392);
            this.Controls.Add(this.txtNumber6);
            this.Controls.Add(this.txtNumber5);
            this.Controls.Add(this.txtNumber4);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumber7);
            this.Controls.Add(this.lblNumber5);
            this.Controls.Add(this.lblNumber6);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.lblNumber4);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber4;
        private System.Windows.Forms.Label lblNumber5;
        private System.Windows.Forms.Label lblNumber6;
        private System.Windows.Forms.Label lblNumber7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtNumber4;
        private System.Windows.Forms.TextBox txtNumber5;
        private System.Windows.Forms.TextBox txtNumber6;
    }
}

