﻿namespace P5_2_1214074
{
    partial class ChildForm
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(293, 32);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(169, 56);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(48, 56);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputGroupBox.Location = new System.Drawing.Point(46, 152);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(200, 104);
            this.OutputGroupBox.TabIndex = 3;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Choose Output";
            // 
            // TimeOption
            // 
            this.TimeOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TimeOption.Location = new System.Drawing.Point(12, 56);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(168, 24);
            this.TimeOption.TabIndex = 1;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current &Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.CheckedChanged += new System.EventHandler(this.TimeOption_CheckedChanged);
            // 
            // DateOption
            // 
            this.DateOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOption.Location = new System.Drawing.Point(12, 30);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(168, 24);
            this.DateOption.TabIndex = 0;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current D&ate";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.CheckedChanged += new System.EventHandler(this.DateOption_CheckedChanged);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 280);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.OutputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DateOption;
    }
}