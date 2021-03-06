﻿namespace ContactManager.UI
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.components = new System.ComponentModel.Container();
            this.OnSave = new System.Windows.Forms.Button();
            this.OnCancel = new System.Windows.Forms.Button();
            this._txtName = new System.Windows.Forms.TextBox();
            this._txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // OnSave
            // 
            this.OnSave.Location = new System.Drawing.Point(55, 257);
            this.OnSave.Name = "OnSave";
            this.OnSave.Size = new System.Drawing.Size(75, 23);
            this.OnSave.TabIndex = 0;
            this.OnSave.Text = "Save";
            this.OnSave.UseVisualStyleBackColor = true;
            this.OnSave.Click += new System.EventHandler(this.OnSave_Click);
            // 
            // OnCancel
            // 
            this.OnCancel.Location = new System.Drawing.Point(207, 257);
            this.OnCancel.Name = "OnCancel";
            this.OnCancel.Size = new System.Drawing.Size(75, 23);
            this.OnCancel.TabIndex = 1;
            this.OnCancel.Text = "Cancel";
            this.OnCancel.UseVisualStyleBackColor = true;
            this.OnCancel.Click += new System.EventHandler(this.OnCancel_Click);
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(182, 43);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 20);
            this._txtName.TabIndex = 2;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // _txtEmailAddress
            // 
            this._txtEmailAddress.Location = new System.Drawing.Point(182, 125);
            this._txtEmailAddress.Name = "_txtEmailAddress";
            this._txtEmailAddress.Size = new System.Drawing.Size(100, 20);
            this._txtEmailAddress.TabIndex = 3;
            this._txtEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateEmailAddress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "EmailAddress";
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtEmailAddress);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.OnCancel);
            this.Controls.Add(this.OnSave);
            this.Name = "ContactForm";
            this.Text = "ContactManager";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnSave;
        private System.Windows.Forms.Button OnCancel;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.TextBox _txtEmailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}