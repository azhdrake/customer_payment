using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentApp
{
  public partial class frmPayment : Form
  {
    public frmPayment()
    {
      InitializeComponent();
    }

    private void frmPayment_Load(object sender, EventArgs e)
    {
      // Setting up all the defaults.
      lstCardType.Items.Add("Visa");
      lstCardType.Items.Add("Mastercard");
      lstCardType.Items.Add("American Express");
      lstCardType.SelectedIndex = 0;

      // Why the book didn't use the AddRange method for this I do not understand.
      string[] months = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
      cmbMonth.Items.AddRange(months);
      cmbMonth.SelectedIndex = -1;

      int year = DateTime.Today.Year;

      // Why the book didn't use a for loop for this I do not understand.
      for(int i = year; i < year + 8; i++)
      {
        cmbYear.Items.Add(i);
      }
    }

    private void btnOkay_Click(object sender, EventArgs e)
    {
      if (isDataValid())
      {
        this.saveData();
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void rbBillCustomer_CheckedChanged(object sender, EventArgs e)
    {
      toggleControls(rbCreditCard.Checked);
    }

    private void toggleControls(bool enabled)
    {
      // thought having a single method for this with an argument made a lot more sense then messing around with two methods and an if statement.
      lstCardType.Enabled = enabled;
      txtCardNumber.Enabled = enabled;
      cmbMonth.Enabled = enabled;
      cmbYear.Enabled = enabled;
    }

    private bool isDataValid()
    {
      if (rbCreditCard.Checked)
      {
        if (lstCardType.SelectedIndex == -1)
        {
          MessageBox.Show("You must select a credit card type.", "Entry Error");
          lstCardType.Focus();
          return false;
        }
        if (String.IsNullOrWhiteSpace(txtCardNumber.Text))
        {
          MessageBox.Show("You must input a card number.", "Entry Error");
          return false;
        }
        if (cmbMonth.SelectedIndex == -1)
        {
          MessageBox.Show("You must select a month.", "Entry Error");
          return false;
        }
        if (cmbYear.SelectedIndex == -1)
        {
          MessageBox.Show("You must select a year.", "Entry Error");
          return false;
        }
      }
      return true;
    }
    private void saveData()
    {
      string message = null;
      if(rbCreditCard.Checked == true)
      {
        // again, the book did this using way more lines of code and typing then seemed nessisary to me.
         message = $"Charged to credit card.\nCard type: {lstCardType.SelectedItem.ToString()}\nCard number: {txtCardNumber.Text}\nExpiration date: {cmbMonth.Text} {cmbYear.Text}";
      }
      else
      {
        message = "Send bill to customer";
      }
      if (cbDefault.Checked)
      {
        // I didn't like the look of "Default billing: true" hense this. 
        message += "\nThis is the customer's default billing method.";
      }
      // send that stuff back to the other form.
      this.Tag = message;
      this.DialogResult = DialogResult.OK;
    }
  }
}
