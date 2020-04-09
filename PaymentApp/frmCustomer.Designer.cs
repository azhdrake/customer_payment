namespace PaymentApp
{
  partial class frmCustomer
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnSelectPaymentMethod = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.cmbName = new System.Windows.Forms.ComboBox();
      this.lblPaymentMethod = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(172, 25);
      this.label1.TabIndex = 10;
      this.label1.Text = "Customer Name:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblPaymentMethod);
      this.groupBox1.Controls.Add(this.btnSelectPaymentMethod);
      this.groupBox1.Location = new System.Drawing.Point(29, 75);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(343, 193);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Payment Method:";
      // 
      // btnSelectPaymentMethod
      // 
      this.btnSelectPaymentMethod.Location = new System.Drawing.Point(235, 0);
      this.btnSelectPaymentMethod.Name = "btnSelectPaymentMethod";
      this.btnSelectPaymentMethod.Size = new System.Drawing.Size(108, 37);
      this.btnSelectPaymentMethod.TabIndex = 1;
      this.btnSelectPaymentMethod.Text = "Select";
      this.btnSelectPaymentMethod.UseVisualStyleBackColor = true;
      this.btnSelectPaymentMethod.Click += new System.EventHandler(this.btnSelectPaymentMethod_Click);
      // 
      // btnExit
      // 
      this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnExit.Location = new System.Drawing.Point(264, 291);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(108, 37);
      this.btnExit.TabIndex = 8;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(29, 291);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(108, 37);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // cmbName
      // 
      this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbName.FormattingEnabled = true;
      this.cmbName.Location = new System.Drawing.Point(196, 21);
      this.cmbName.Name = "cmbName";
      this.cmbName.Size = new System.Drawing.Size(176, 33);
      this.cmbName.TabIndex = 6;
      this.cmbName.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
      // 
      // lblPaymentMethod
      // 
      this.lblPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblPaymentMethod.Location = new System.Drawing.Point(7, 31);
      this.lblPaymentMethod.Name = "lblPaymentMethod";
      this.lblPaymentMethod.Size = new System.Drawing.Size(330, 159);
      this.lblPaymentMethod.TabIndex = 2;
      this.lblPaymentMethod.TextChanged += new System.EventHandler(this.DataChanged);
      // 
      // frmCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnExit;
      this.ClientSize = new System.Drawing.Size(399, 355);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.cmbName);
      this.Name = "frmCustomer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Customer";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
      this.Load += new System.EventHandler(this.frmCustomer_Load);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectPaymentMethod;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblPaymentMethod;
    }
}

