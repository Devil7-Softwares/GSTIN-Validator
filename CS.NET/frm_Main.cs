using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.NET
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void txt_GSTIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (GSTINValidator.IsValid(txt_GSTIN.Text))
                {
                    lbl_Result.ForeColor = Color.Green;
                    lbl_Result.Text = "Valid GSTIN.";
                }
                else
                {
                    lbl_Result.ForeColor = Color.Red;
                    lbl_Result.Text = "Invalid GSTIN!";
                }
            }
            catch (Exception ex)
            {
                lbl_Result.ForeColor = Color.Red;
                lbl_Result.Text = ex.Message;
            }
        }
    }
}
