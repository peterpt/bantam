﻿namespace bantam_php
{
    partial class ModifyShell
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
            this.txtBoxShellUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxArgName = new System.Windows.Forms.TextBox();
            this.btnUpdateShell = new System.Windows.Forms.Button();
            this.comboBoxVarType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddShell = new System.Windows.Forms.Button();
            this.checkBoxResponseEncryption = new System.Windows.Forms.CheckBox();
            this.comboBoxEncryptionMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shell URL";
            // 
            // txtBoxShellUrl
            // 
            this.txtBoxShellUrl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxShellUrl.Location = new System.Drawing.Point(22, 34);
            this.txtBoxShellUrl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtBoxShellUrl.Name = "txtBoxShellUrl";
            this.txtBoxShellUrl.Size = new System.Drawing.Size(461, 23);
            this.txtBoxShellUrl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Var Name:";
            // 
            // txtBoxArgName
            // 
            this.txtBoxArgName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxArgName.Location = new System.Drawing.Point(340, 92);
            this.txtBoxArgName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtBoxArgName.Name = "txtBoxArgName";
            this.txtBoxArgName.Size = new System.Drawing.Size(143, 23);
            this.txtBoxArgName.TabIndex = 4;
            this.txtBoxArgName.Text = "command";
            // 
            // btnUpdateShell
            // 
            this.btnUpdateShell.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShell.Location = new System.Drawing.Point(356, 135);
            this.btnUpdateShell.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdateShell.Name = "btnUpdateShell";
            this.btnUpdateShell.Size = new System.Drawing.Size(127, 32);
            this.btnUpdateShell.TabIndex = 6;
            this.btnUpdateShell.Text = "Update Shell";
            this.btnUpdateShell.UseVisualStyleBackColor = true;
            this.btnUpdateShell.Visible = false;
            this.btnUpdateShell.Click += new System.EventHandler(this.btnUpdateShell_Click);
            // 
            // comboBoxVarType
            // 
            this.comboBoxVarType.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVarType.FormattingEnabled = true;
            this.comboBoxVarType.Location = new System.Drawing.Point(92, 91);
            this.comboBoxVarType.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxVarType.Name = "comboBoxVarType";
            this.comboBoxVarType.Size = new System.Drawing.Size(143, 24);
            this.comboBoxVarType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Var Type:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(462, 2);
            this.label5.TabIndex = 9;
            // 
            // btnAddShell
            // 
            this.btnAddShell.Location = new System.Drawing.Point(356, 135);
            this.btnAddShell.Name = "btnAddShell";
            this.btnAddShell.Size = new System.Drawing.Size(127, 32);
            this.btnAddShell.TabIndex = 10;
            this.btnAddShell.Text = "Add Shell";
            this.btnAddShell.UseVisualStyleBackColor = true;
            this.btnAddShell.Click += new System.EventHandler(this.btnAddShell_Click);
            // 
            // checkBoxResponseEncryption
            // 
            this.checkBoxResponseEncryption.AutoSize = true;
            this.checkBoxResponseEncryption.Checked = true;
            this.checkBoxResponseEncryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxResponseEncryption.Location = new System.Drawing.Point(22, 142);
            this.checkBoxResponseEncryption.Name = "checkBoxResponseEncryption";
            this.checkBoxResponseEncryption.Size = new System.Drawing.Size(137, 20);
            this.checkBoxResponseEncryption.TabIndex = 11;
            this.checkBoxResponseEncryption.Text = "Response Encryption";
            this.checkBoxResponseEncryption.UseVisualStyleBackColor = true;
            // 
            // comboBoxEncryptionMode
            // 
            this.comboBoxEncryptionMode.FormattingEnabled = true;
            this.comboBoxEncryptionMode.Location = new System.Drawing.Point(178, 140);
            this.comboBoxEncryptionMode.Name = "comboBoxEncryptionMode";
            this.comboBoxEncryptionMode.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEncryptionMode.TabIndex = 12;
            // 
            // AddHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 193);
            this.Controls.Add(this.comboBoxEncryptionMode);
            this.Controls.Add(this.checkBoxResponseEncryption);
            this.Controls.Add(this.btnAddShell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxVarType);
            this.Controls.Add(this.btnUpdateShell);
            this.Controls.Add(this.txtBoxArgName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxShellUrl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHost";
            this.ShowIcon = false;
            this.Text = "Add Shell";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddHost_FormClosed);
            this.Shown += new System.EventHandler(this.AddHost_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxShellUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxArgName;
        private System.Windows.Forms.Button btnUpdateShell;
        private System.Windows.Forms.ComboBox comboBoxVarType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddShell;
        private System.Windows.Forms.CheckBox checkBoxResponseEncryption;
        private System.Windows.Forms.ComboBox comboBoxEncryptionMode;
    }
}