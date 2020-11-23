using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KoP_9var_CL
{
    public partial class ControlDatePicker : UserControl
    {
        private string _savedInput;
        DateTime? dateNull = null;
        public string Example { get; set; } = "Ex: 16/05/2001";
        private CultureInfo _ci = new CultureInfo("en-US");

        private bool isValid
        {
            get
            {
                try
                {
                    Convert.ToDateTime(textBoxDatePicker.Text);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public DateTime? Date
        {
            get { return isValid ? Convert.ToDateTime(textBoxDatePicker.Text) : (DateTime?)null; }
            set
            {
                textBoxDatePicker.Text = value.HasValue ? value.ToString() : null;
                if (value.HasValue)
                {
                    textBoxDatePicker.Text = value.ToString();

                }
                else
                {
                    textBoxDatePicker.Text = null;
                    checkBoxNull.Checked = true;
                }
            }
        }

        public bool isNull { get; set; } = false;

        public ControlDatePicker()
        {
            InitializeComponent();
            checkBoxNull.Checked = isNull;
            labelInfo.Text = Example;
        }

        private void checkBoxNull_CheckedChanged(object sender, EventArgs e)
        {
            isNull = checkBoxNull.Checked;
            textBoxDatePicker.Enabled = !isNull;
            if (isNull)
            {
                _savedInput = textBoxDatePicker.Text;
                Date = dateNull;
            }
            else
            {
                textBoxDatePicker.Text = "";
            }
        }

        private void textBoxDatePicker_TextChanged(object sender, EventArgs e)
        {
            if (!isValid)
            {
                labelInfo.Text = Example;

            }
            else
            {
                labelInfo.Text = "nice";
            }
        }
    }
}
