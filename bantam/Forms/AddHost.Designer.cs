﻿namespace bantam_php
{
    partial class AddHost
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxhostTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxArgName = new System.Windows.Forms.TextBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Method";
            // 
            // txtBoxhostTarget
            // 
            this.txtBoxhostTarget.Location = new System.Drawing.Point(15, 31);
            this.txtBoxhostTarget.Name = "txtBoxhostTarget";
            this.txtBoxhostTarget.Size = new System.Drawing.Size(386, 20);
            this.txtBoxhostTarget.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arg Name";
            // 
            // txtBoxArgName
            // 
            this.txtBoxArgName.Location = new System.Drawing.Point(19, 75);
            this.txtBoxArgName.Name = "txtBoxArgName";
            this.txtBoxArgName.Size = new System.Drawing.Size(167, 20);
            this.txtBoxArgName.TabIndex = 4;
            this.txtBoxArgName.Text = "command";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "cookie",
            "post",
            "request"});
            this.comboBoxMethod.Location = new System.Drawing.Point(217, 75);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(184, 21);
            this.comboBoxMethod.TabIndex = 5;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(15, 114);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(386, 37);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // AddHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 163);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.txtBoxArgName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxhostTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHost";
            this.Text = "Add Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxhostTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxArgName;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.Button btnAddClient;
    }
}