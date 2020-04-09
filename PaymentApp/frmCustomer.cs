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
  public partial class frmCustomer : Form
  {
    bool isDataSaved = true;

    public frmCustomer()
    {
      InitializeComponent();
    }

    private void frmCustomer_Load(object sender, EventArgs e)
    {
      cmbName.Items.Add("Jebeth Nitram");
      cmbName.Items.Add("Jame Holleth");
    }

    private void btnSelectPaymentMethod_Click(object sender, EventArgs e)
    {
      Form paymentFom = new frmPayment();
      DialogResult selectedButton = paymentFom.ShowDialog();
      if (selectedButton == DialogResult.OK)
      {
        lblPaymentMethod.Text = (string)paymentFom.Tag;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveData();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void DataChanged(object sender, EventArgs e)
    {
      if (isValidData())
      {
        isDataSaved = false;
      }
    }

    private void SaveData()
    {
      if (isValidData())
      {
        cmbName.SelectedIndex = -1;
        lblPaymentMethod.Text = "";
        isDataSaved = true;
        cmbName.Focus();
      }
    }

    private bool isValidData()
    {
      if(cmbName.SelectedIndex == -1)
      {
        MessageBox.Show("You must select a customer.", "Entry Error");
        cmbName.Focus();
        return (false);
      }
      if (String.IsNullOrWhiteSpace(lblPaymentMethod.Text))
      {
        MessageBox.Show("You must select a payment method.", "Entry Error");
        return (false);
      }
      return true;
    }

    private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (isDataSaved == false)
      {
        DialogResult save = MessageBox.Show("You have unsaved data. Would you like to save it?", "Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        if(save == DialogResult.Yes)
        {
          if (isValidData())
          {
            this.SaveData();
          }
          else
          {
            e.Cancel = true;
          }
        }
        if (save == DialogResult.Cancel)
        {
          e.Cancel = true;
        }

      }
    }
  }
}
