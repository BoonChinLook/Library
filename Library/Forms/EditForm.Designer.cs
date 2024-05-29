﻿namespace Library
{
    partial class EditForm
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPublishedDate = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPublishedDate = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLibraryButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Teal;
            this.lblAuthor.Location = new System.Drawing.Point(106, 153);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(68, 22);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Teal;
            this.lblGenre.Location = new System.Drawing.Point(105, 224);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(65, 22);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Teal;
            this.lblDescription.Location = new System.Drawing.Point(595, 81);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(165, 25);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Book Description:";
            // 
            // lblPublishedDate
            // 
            this.lblPublishedDate.AutoSize = true;
            this.lblPublishedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublishedDate.ForeColor = System.Drawing.Color.Teal;
            this.lblPublishedDate.Location = new System.Drawing.Point(596, 155);
            this.lblPublishedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublishedDate.Name = "lblPublishedDate";
            this.lblPublishedDate.Size = new System.Drawing.Size(150, 25);
            this.lblPublishedDate.TabIndex = 8;
            this.lblPublishedDate.Text = "Date Published:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.Teal;
            this.lblPublisher.Location = new System.Drawing.Point(605, 226);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(99, 25);
            this.lblPublisher.TabIndex = 10;
            this.lblPublisher.Text = "Publisher:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(177, 147);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(340, 22);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(177, 222);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(340, 22);
            this.txtGenre.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(770, 81);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.Location = new System.Drawing.Point(770, 153);
            this.txtPublishedDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.Size = new System.Drawing.Size(340, 22);
            this.txtPublishedDate.TabIndex = 9;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(770, 222);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(340, 22);
            this.txtPublisher.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLibraryButton);
            this.panel1.Location = new System.Drawing.Point(-6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 54);
            this.panel1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(97, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLibraryButton
            // 
            this.btnLibraryButton.BackColor = System.Drawing.Color.Teal;
            this.btnLibraryButton.FlatAppearance.BorderSize = 0;
            this.btnLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibraryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLibraryButton.Location = new System.Drawing.Point(18, 9);
            this.btnLibraryButton.Name = "btnLibraryButton";
            this.btnLibraryButton.Size = new System.Drawing.Size(93, 39);
            this.btnLibraryButton.TabIndex = 0;
            this.btnLibraryButton.Text = "Library";
            this.btnLibraryButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblAuthor);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.txtPublisher);
            this.panel2.Controls.Add(this.lblGenre);
            this.panel2.Controls.Add(this.txtPublishedDate);
            this.panel2.Controls.Add(this.txtGenre);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.lblDescription);
            this.panel2.Controls.Add(this.lblPublishedDate);
            this.panel2.Controls.Add(this.lblPublisher);
            this.panel2.Location = new System.Drawing.Point(-6, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 483);
            this.panel2.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Teal;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.Location = new System.Drawing.Point(521, 327);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 45);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Apply changes";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(177, 85);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(340, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(105, 85);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPublishedDate;
        private System.Windows.Forms.Label lblPublisher;
        /*private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button OpenBtn;*/
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPublishedDate;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnLibraryButton;
        private System.Windows.Forms.Button button1;
    }
}
