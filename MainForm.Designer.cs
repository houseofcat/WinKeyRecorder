﻿namespace WinKeyRecorder
{
    partial class MainForm
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
            this.KeyBufferTbx = new System.Windows.Forms.TextBox();
            this.RecordButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShowKBBufferCbx = new System.Windows.Forms.CheckBox();
            this.LogBufferTbx = new System.Windows.Forms.TextBox();
            this.ShowLogBufferCbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TimeSyncCbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // KeyBufferTbx
            // 
            this.KeyBufferTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KeyBufferTbx.Location = new System.Drawing.Point(12, 101);
            this.KeyBufferTbx.Multiline = true;
            this.KeyBufferTbx.Name = "KeyBufferTbx";
            this.KeyBufferTbx.ReadOnly = true;
            this.KeyBufferTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeyBufferTbx.Size = new System.Drawing.Size(257, 280);
            this.KeyBufferTbx.TabIndex = 5;
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(12, 10);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(196, 23);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.Text = "&Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.ButtonEventHandler);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(12, 39);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(196, 23);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "&Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.ButtonEventHandler);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(214, 10);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(48, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ButtonEventHandler);
            // 
            // ShowKBBufferCbx
            // 
            this.ShowKBBufferCbx.AutoSize = true;
            this.ShowKBBufferCbx.Checked = true;
            this.ShowKBBufferCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowKBBufferCbx.Location = new System.Drawing.Point(12, 78);
            this.ShowKBBufferCbx.Name = "ShowKBBufferCbx";
            this.ShowKBBufferCbx.Size = new System.Drawing.Size(132, 17);
            this.ShowKBBufferCbx.TabIndex = 6;
            this.ShowKBBufferCbx.Text = "Show Keyboard Buffer";
            this.ShowKBBufferCbx.UseVisualStyleBackColor = true;
            // 
            // LogBufferTbx
            // 
            this.LogBufferTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBufferTbx.Location = new System.Drawing.Point(275, 101);
            this.LogBufferTbx.Multiline = true;
            this.LogBufferTbx.Name = "LogBufferTbx";
            this.LogBufferTbx.ReadOnly = true;
            this.LogBufferTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBufferTbx.Size = new System.Drawing.Size(373, 280);
            this.LogBufferTbx.TabIndex = 7;
            // 
            // ShowLogBufferCbx
            // 
            this.ShowLogBufferCbx.AutoSize = true;
            this.ShowLogBufferCbx.Checked = true;
            this.ShowLogBufferCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLogBufferCbx.Location = new System.Drawing.Point(577, 78);
            this.ShowLogBufferCbx.Name = "ShowLogBufferCbx";
            this.ShowLogBufferCbx.Size = new System.Drawing.Size(74, 17);
            this.ShowLogBufferCbx.TabIndex = 8;
            this.ShowLogBufferCbx.Text = "Show Log";
            this.ShowLogBufferCbx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "v0,01";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(574, 392);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HouseofCat.io";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // TimeSyncCbx
            // 
            this.TimeSyncCbx.AutoSize = true;
            this.TimeSyncCbx.Checked = true;
            this.TimeSyncCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TimeSyncCbx.Location = new System.Drawing.Point(214, 43);
            this.TimeSyncCbx.Name = "TimeSyncCbx";
            this.TimeSyncCbx.Size = new System.Drawing.Size(116, 17);
            this.TimeSyncCbx.TabIndex = 11;
            this.TimeSyncCbx.Text = "Enforce Time Sync";
            this.TimeSyncCbx.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 414);
            this.Controls.Add(this.TimeSyncCbx);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowLogBufferCbx);
            this.Controls.Add(this.LogBufferTbx);
            this.Controls.Add(this.ShowKBBufferCbx);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.KeyBufferTbx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "WinKeyRecorder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeyBufferTbx;
        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox ShowKBBufferCbx;
        private System.Windows.Forms.TextBox LogBufferTbx;
        private System.Windows.Forms.CheckBox ShowLogBufferCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox TimeSyncCbx;
    }
}

