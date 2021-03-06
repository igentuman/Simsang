﻿namespace Simsang.ARPScan.SystemFingerprint
{
  partial class SystemFingerprint
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemFingerprint));
      this.GB_Fingerprint = new System.Windows.Forms.GroupBox();
      this.TB_Note = new System.Windows.Forms.TextBox();
      this.L_Note = new System.Windows.Forms.Label();
      this.TB_ScanDate = new System.Windows.Forms.TextBox();
      this.L_ScanDate = new System.Windows.Forms.Label();
      this.TB_OSGuess = new System.Windows.Forms.TextBox();
      this.TB_OpenPorts = new System.Windows.Forms.TextBox();
      this.TB_HWVendor = new System.Windows.Forms.TextBox();
      this.TB_MAC = new System.Windows.Forms.TextBox();
      this.L_OpenPorts = new System.Windows.Forms.Label();
      this.L_OSGuess = new System.Windows.Forms.Label();
      this.L_HWVendor = new System.Windows.Forms.Label();
      this.L_MACAddr = new System.Windows.Forms.Label();
      this.GB_Fingerprint.SuspendLayout();
      this.SuspendLayout();
      // 
      // GB_Fingerprint
      // 
      this.GB_Fingerprint.Controls.Add(this.TB_Note);
      this.GB_Fingerprint.Controls.Add(this.L_Note);
      this.GB_Fingerprint.Controls.Add(this.TB_ScanDate);
      this.GB_Fingerprint.Controls.Add(this.L_ScanDate);
      this.GB_Fingerprint.Controls.Add(this.TB_OSGuess);
      this.GB_Fingerprint.Controls.Add(this.TB_OpenPorts);
      this.GB_Fingerprint.Controls.Add(this.TB_HWVendor);
      this.GB_Fingerprint.Controls.Add(this.TB_MAC);
      this.GB_Fingerprint.Controls.Add(this.L_OpenPorts);
      this.GB_Fingerprint.Controls.Add(this.L_OSGuess);
      this.GB_Fingerprint.Controls.Add(this.L_HWVendor);
      this.GB_Fingerprint.Controls.Add(this.L_MACAddr);
      this.GB_Fingerprint.Location = new System.Drawing.Point(13, 13);
      this.GB_Fingerprint.Name = "GB_Fingerprint";
      this.GB_Fingerprint.Size = new System.Drawing.Size(615, 246);
      this.GB_Fingerprint.TabIndex = 0;
      this.GB_Fingerprint.TabStop = false;
      // 
      // TB_Note
      // 
      this.TB_Note.Location = new System.Drawing.Point(406, 50);
      this.TB_Note.Name = "TB_Note";
      this.TB_Note.Size = new System.Drawing.Size(186, 20);
      this.TB_Note.TabIndex = 11;
      // 
      // L_Note
      // 
      this.L_Note.AutoSize = true;
      this.L_Note.Location = new System.Drawing.Point(330, 51);
      this.L_Note.Name = "L_Note";
      this.L_Note.Size = new System.Drawing.Size(30, 13);
      this.L_Note.TabIndex = 10;
      this.L_Note.Text = "Note";
      // 
      // TB_ScanDate
      // 
      this.TB_ScanDate.Location = new System.Drawing.Point(86, 51);
      this.TB_ScanDate.Name = "TB_ScanDate";
      this.TB_ScanDate.ReadOnly = true;
      this.TB_ScanDate.Size = new System.Drawing.Size(234, 20);
      this.TB_ScanDate.TabIndex = 9;
      // 
      // L_ScanDate
      // 
      this.L_ScanDate.AutoSize = true;
      this.L_ScanDate.Location = new System.Drawing.Point(18, 54);
      this.L_ScanDate.Name = "L_ScanDate";
      this.L_ScanDate.Size = new System.Drawing.Size(56, 13);
      this.L_ScanDate.TabIndex = 8;
      this.L_ScanDate.Text = "Scan date";
      // 
      // TB_OSGuess
      // 
      this.TB_OSGuess.Location = new System.Drawing.Point(21, 99);
      this.TB_OSGuess.Multiline = true;
      this.TB_OSGuess.Name = "TB_OSGuess";
      this.TB_OSGuess.ReadOnly = true;
      this.TB_OSGuess.Size = new System.Drawing.Size(299, 131);
      this.TB_OSGuess.TabIndex = 7;
      // 
      // TB_OpenPorts
      // 
      this.TB_OpenPorts.Location = new System.Drawing.Point(333, 99);
      this.TB_OpenPorts.Margin = new System.Windows.Forms.Padding(10);
      this.TB_OpenPorts.Multiline = true;
      this.TB_OpenPorts.Name = "TB_OpenPorts";
      this.TB_OpenPorts.ReadOnly = true;
      this.TB_OpenPorts.Size = new System.Drawing.Size(259, 131);
      this.TB_OpenPorts.TabIndex = 6;
      // 
      // TB_HWVendor
      // 
      this.TB_HWVendor.Location = new System.Drawing.Point(86, 19);
      this.TB_HWVendor.Name = "TB_HWVendor";
      this.TB_HWVendor.ReadOnly = true;
      this.TB_HWVendor.Size = new System.Drawing.Size(234, 20);
      this.TB_HWVendor.TabIndex = 5;
      // 
      // TB_MAC
      // 
      this.TB_MAC.Location = new System.Drawing.Point(406, 19);
      this.TB_MAC.Name = "TB_MAC";
      this.TB_MAC.ReadOnly = true;
      this.TB_MAC.Size = new System.Drawing.Size(186, 20);
      this.TB_MAC.TabIndex = 4;
      // 
      // L_OpenPorts
      // 
      this.L_OpenPorts.AutoSize = true;
      this.L_OpenPorts.Location = new System.Drawing.Point(332, 80);
      this.L_OpenPorts.Name = "L_OpenPorts";
      this.L_OpenPorts.Size = new System.Drawing.Size(59, 13);
      this.L_OpenPorts.TabIndex = 3;
      this.L_OpenPorts.Text = "Open ports";
      // 
      // L_OSGuess
      // 
      this.L_OSGuess.AutoSize = true;
      this.L_OSGuess.Location = new System.Drawing.Point(18, 81);
      this.L_OSGuess.Name = "L_OSGuess";
      this.L_OSGuess.Size = new System.Drawing.Size(53, 13);
      this.L_OSGuess.TabIndex = 2;
      this.L_OSGuess.Text = "OS guess";
      // 
      // L_HWVendor
      // 
      this.L_HWVendor.AutoSize = true;
      this.L_HWVendor.Location = new System.Drawing.Point(18, 22);
      this.L_HWVendor.Name = "L_HWVendor";
      this.L_HWVendor.Size = new System.Drawing.Size(62, 13);
      this.L_HWVendor.TabIndex = 1;
      this.L_HWVendor.Text = "HW vendor";
      // 
      // L_MACAddr
      // 
      this.L_MACAddr.AutoSize = true;
      this.L_MACAddr.Location = new System.Drawing.Point(330, 22);
      this.L_MACAddr.Name = "L_MACAddr";
      this.L_MACAddr.Size = new System.Drawing.Size(70, 13);
      this.L_MACAddr.TabIndex = 0;
      this.L_MACAddr.Text = "MAC address";
      // 
      // SystemFingerprint
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 274);
      this.Controls.Add(this.GB_Fingerprint);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SystemFingerprint";
      this.Text = "System fingerprint";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SystemFingerprint_FormClosing);
      this.GB_Fingerprint.ResumeLayout(false);
      this.GB_Fingerprint.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox GB_Fingerprint;
    private System.Windows.Forms.Label L_HWVendor;
    private System.Windows.Forms.Label L_MACAddr;
    private System.Windows.Forms.Label L_OpenPorts;
    private System.Windows.Forms.Label L_OSGuess;
    private System.Windows.Forms.TextBox TB_HWVendor;
    private System.Windows.Forms.TextBox TB_MAC;
    private System.Windows.Forms.TextBox TB_OpenPorts;
    private System.Windows.Forms.TextBox TB_OSGuess;
    private System.Windows.Forms.TextBox TB_ScanDate;
    private System.Windows.Forms.Label L_ScanDate;
    private System.Windows.Forms.TextBox TB_Note;
    private System.Windows.Forms.Label L_Note;
  }
}