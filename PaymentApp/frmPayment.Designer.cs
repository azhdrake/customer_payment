namespace PaymentApp
{
  partial class frmPayment
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbBillCustomer = new System.Windows.Forms.RadioButton();
      this.rbCreditCard = new System.Windows.Forms.RadioButton();
      this.lstCardType = new System.Windows.Forms.ListBox();
      this.txtCardNumber = new System.Windows.Forms.TextBox();
      this.cmbMonth = new System.Windows.Forms.ComboBox();
      this.cmbYear = new System.Windows.Forms.ComboBox();
      this.cbDefault = new System.Windows.Forms.CheckBox();
      this.btnOkay = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbBillCustomer);
      this.groupBox1.Controls.Add(this.rbCreditCard);
      this.groupBox1.Location = new System.Drawing.Point(13, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(396, 68);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Billing";
      // 
      // rbBillCustomer
      // 
      this.rbBillCustomer.AutoSize = true;
      this.rbBillCustomer.Location = new System.Drawing.Point(225, 33);
      this.rbBillCustomer.Name = "rbBillCustomer";
      this.rbBillCustomer.Size = new System.Drawing.Size(170, 29);
      this.rbBillCustomer.TabIndex = 1;
      this.rbBillCustomer.Text = "Bill Customer";
      this.rbBillCustomer.UseVisualStyleBackColor = true;
      this.rbBillCustomer.CheckedChanged += new System.EventHandler(this.rbBillCustomer_CheckedChanged);
      // 
      // rbCreditCard
      // 
      this.rbCreditCard.AutoSize = true;
      this.rbCreditCard.Checked = true;
      this.rbCreditCard.Location = new System.Drawing.Point(7, 33);
      this.rbCreditCard.Name = "rbCreditCard";
      this.rbCreditCard.Size = new System.Drawing.Size(152, 29);
      this.rbCreditCard.TabIndex = 0;
      this.rbCreditCard.TabStop = true;
      this.rbCreditCard.Text = "Credit Card";
      this.rbCreditCard.UseVisualStyleBackColor = true;
      // 
      // lstCardType
      // 
      this.lstCardType.FormattingEnabled = true;
      this.lstCardType.ItemHeight = 25;
      this.lstCardType.Location = new System.Drawing.Point(176, 83);
      this.lstCardType.Name = "lstCardType";
      this.lstCardType.Size = new System.Drawing.Size(233, 129);
      this.lstCardType.TabIndex = 1;
      // 
      // txtCardNumber
      // 
      this.txtCardNumber.Location = new System.Drawing.Point(176, 224);
      this.txtCardNumber.Name = "txtCardNumber";
      this.txtCardNumber.Size = new System.Drawing.Size(233, 31);
      this.txtCardNumber.TabIndex = 2;
      // 
      // cmbMonth
      // 
      this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMonth.FormattingEnabled = true;
      this.cmbMonth.Location = new System.Drawing.Point(176, 267);
      this.cmbMonth.Name = "cmbMonth";
      this.cmbMonth.Size = new System.Drawing.Size(116, 33);
      this.cmbMonth.TabIndex = 3;
      // 
      // cmbYear
      // 
      this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbYear.FormattingEnabled = true;
      this.cmbYear.Location = new System.Drawing.Point(293, 267);
      this.cmbYear.Name = "cmbYear";
      this.cmbYear.Size = new System.Drawing.Size(116, 33);
      this.cmbYear.TabIndex = 4;
      // 
      // cbDefault
      // 
      this.cbDefault.AutoSize = true;
      this.cbDefault.Checked = true;
      this.cbDefault.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbDefault.Location = new System.Drawing.Point(12, 316);
      this.cbDefault.Name = "cbDefault";
      this.cbDefault.Size = new System.Drawing.Size(315, 29);
      this.cbDefault.TabIndex = 5;
      this.cbDefault.Text = "Set as default billing method";
      this.cbDefault.UseVisualStyleBackColor = true;
      // 
      // btnOkay
      // 
      this.btnOkay.Location = new System.Drawing.Point(13, 352);
      this.btnOkay.Name = "btnOkay";
      this.btnOkay.Size = new System.Drawing.Size(107, 40);
      this.btnOkay.TabIndex = 6;
      this.btnOkay.Text = "Okay";
      this.btnOkay.UseVisualStyleBackColor = true;
      this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(302, 351);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(107, 40);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 227);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(145, 25);
      this.label1.TabIndex = 8;
      this.label1.Text = "Card Number:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 270);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(165, 25);
      this.label2.TabIndex = 9;
      this.label2.Text = "Expiration Date:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(118, 25);
      this.label3.TabIndex = 10;
      this.label3.Text = "Card Type:";
      // 
      // frmPayment
      // 
      this.AcceptButton = this.btnOkay;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(436, 438);
      this.ControlBox = false;
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOkay);
      this.Controls.Add(this.cbDefault);
      this.Controls.Add(this.cmbYear);
      this.Controls.Add(this.cmbMonth);
      this.Controls.Add(this.txtCardNumber);
      this.Controls.Add(this.lstCardType);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "frmPayment";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Payment";
      this.Load += new System.EventHandler(this.frmPayment_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBillCustomer;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.ListBox lstCardType;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.CheckBox cbDefault;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}