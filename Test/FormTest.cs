﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            controlComboBoxSelected.LoadEnumeration(typeof(TestEnum));
            controlListBox.LoadEnumeration(typeof(TestEnum));
            controlPhoneNumberCheck.setColor = Color.Red;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBoxSelected.SelectedIndex = 0;
        }

        private void controlComboBoxSelected1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {        
            MessageBox.Show(controlComboBoxSelected.SelectedText);
        }

        private void controlListBox1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlListBox.SelectedText);
        }

        private void controlPhoneNumberCheck_NumberWrite(object sender, EventArgs e)
        {
            controlPhoneNumberCheck.CheckNumber();
        }

        private void controlListOfValues_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlListOfValues.SelectedText);
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            controlListOfValues.SetMainLine = textBoxMainString.Text;
            Class1 cl = new Class1();
            controlListOfValues.GetPropertyValues(cl);
        }
    }
}
