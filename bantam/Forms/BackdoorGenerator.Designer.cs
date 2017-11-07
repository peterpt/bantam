﻿namespace bantam_php
{
    partial class BackdoorGenerator
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
            this.chkbxDisableLogging = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblRequestVarName = new System.Windows.Forms.Label();
            this.txtBoxVarName = new System.Windows.Forms.TextBox();
            this.chkbxMinifyCode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbxDisableLogging
            // 
            this.chkbxDisableLogging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxDisableLogging.AutoSize = true;
            this.chkbxDisableLogging.Location = new System.Drawing.Point(318, 275);
            this.chkbxDisableLogging.Name = "chkbxDisableLogging";
            this.chkbxDisableLogging.Size = new System.Drawing.Size(127, 17);
            this.chkbxDisableLogging.TabIndex = 0;
            this.chkbxDisableLogging.Text = "Disable Error Logging";
            this.chkbxDisableLogging.UseVisualStyleBackColor = true;
            this.chkbxDisableLogging.CheckStateChanged += new System.EventHandler(this.chkbxDisableLogging_CheckStateChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 242);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "eval",
            "assert",
            "create_function",
            "native anonymous",
            "tmp include",
            "preg_replace"});
            this.comboBox1.Location = new System.Drawing.Point(80, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(9, 276);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(46, 13);
            this.lblMethod.TabIndex = 4;
            this.lblMethod.Text = "Method:";
            // 
            // lblRequestVarName
            // 
            this.lblRequestVarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRequestVarName.AutoSize = true;
            this.lblRequestVarName.Location = new System.Drawing.Point(9, 306);
            this.lblRequestVarName.Name = "lblRequestVarName";
            this.lblRequestVarName.Size = new System.Drawing.Size(57, 13);
            this.lblRequestVarName.TabIndex = 5;
            this.lblRequestVarName.Text = "Var Name:";
            // 
            // txtBoxVarName
            // 
            this.txtBoxVarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxVarName.Location = new System.Drawing.Point(80, 303);
            this.txtBoxVarName.Name = "txtBoxVarName";
            this.txtBoxVarName.Size = new System.Drawing.Size(123, 20);
            this.txtBoxVarName.TabIndex = 6;
            this.txtBoxVarName.Text = "command";
            this.txtBoxVarName.TextChanged += new System.EventHandler(this.txtBoxVarName_TextChanged);
            // 
            // chkbxMinifyCode
            // 
            this.chkbxMinifyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxMinifyCode.AutoSize = true;
            this.chkbxMinifyCode.Location = new System.Drawing.Point(318, 305);
            this.chkbxMinifyCode.Name = "chkbxMinifyCode";
            this.chkbxMinifyCode.Size = new System.Drawing.Size(81, 17);
            this.chkbxMinifyCode.TabIndex = 7;
            this.chkbxMinifyCode.Text = "Minify Code";
            this.chkbxMinifyCode.UseVisualStyleBackColor = true;
            this.chkbxMinifyCode.CheckedChanged += new System.EventHandler(this.chkbxMinifyCode_CheckedChanged);
            // 
            // BackdoorGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 365);
            this.Controls.Add(this.chkbxMinifyCode);
            this.Controls.Add(this.txtBoxVarName);
            this.Controls.Add(this.lblRequestVarName);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chkbxDisableLogging);
            this.Name = "BackdoorGenerator";
            this.Text = "PayloadGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbxDisableLogging;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblRequestVarName;
        private System.Windows.Forms.TextBox txtBoxVarName;
        private System.Windows.Forms.CheckBox chkbxMinifyCode;
    }
}