namespace Test
{
    partial class FormTest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChange = new System.Windows.Forms.Button();
            this.controlPhoneNumberCheck = new ClassLibraryControlSelected.ControlPhoneNumberCheck();
            this.controlListBox = new ClassLibraryControlSelected.ControlListBox();
            this.controlComboBoxSelected = new ClassLibraryControlSelected.ControlComboBoxSelected();
            this.controlListOfValues = new ClassLibraryControlSelected.ControlListOfValues();
            this.textBoxMainString = new System.Windows.Forms.TextBox();
            this.buttonWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(29, 130);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Сменить номер";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // controlPhoneNumberCheck
            // 
            this.controlPhoneNumberCheck.Location = new System.Drawing.Point(465, 22);
            this.controlPhoneNumberCheck.Name = "controlPhoneNumberCheck";
            this.controlPhoneNumberCheck.Size = new System.Drawing.Size(255, 117);
            this.controlPhoneNumberCheck.TabIndex = 3;
            this.controlPhoneNumberCheck.NumberWrite += new System.EventHandler(this.controlPhoneNumberCheck_NumberWrite);
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(240, 12);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIndex = 0;
            this.controlListBox.Size = new System.Drawing.Size(244, 174);
            this.controlListBox.TabIndex = 2;
            this.controlListBox.ListBoxSelectedElementChange += new System.EventHandler(this.controlListBox1_ComboBoxSelectedElementChange);
            // 
            // controlComboBoxSelected
            // 
            this.controlComboBoxSelected.Location = new System.Drawing.Point(29, 12);
            this.controlComboBoxSelected.Name = "controlComboBoxSelected";
            this.controlComboBoxSelected.SelectedIndex = 0;
            this.controlComboBoxSelected.Size = new System.Drawing.Size(150, 150);
            this.controlComboBoxSelected.TabIndex = 0;
            this.controlComboBoxSelected.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected1_ComboBoxSelectedElementChange);
            // 
            // controlListOfValues
            // 
            this.controlListOfValues.Location = new System.Drawing.Point(754, 12);
            this.controlListOfValues.Name = "controlListOfValues";
            this.controlListOfValues.Size = new System.Drawing.Size(189, 165);
            this.controlListOfValues.TabIndex = 5;
            this.controlListOfValues.ListBoxSelectedElementChange += new System.EventHandler(this.controlListOfValues_ListBoxSelectedElementChange);
            // 
            // textBoxMainString
            // 
            this.textBoxMainString.Location = new System.Drawing.Point(837, 166);
            this.textBoxMainString.Name = "textBoxMainString";
            this.textBoxMainString.Size = new System.Drawing.Size(149, 20);
            this.textBoxMainString.TabIndex = 6;
            this.textBoxMainString.Text = "выводить свойства {2 1}";
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(719, 221);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(193, 24);
            this.buttonWork.TabIndex = 7;
            this.buttonWork.Text = "Добавить свойства";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 282);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.textBoxMainString);
            this.Controls.Add(this.controlListOfValues);
            this.Controls.Add(this.controlPhoneNumberCheck);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.controlComboBoxSelected);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibraryControlSelected.ControlComboBoxSelected controlComboBoxSelected;
        private System.Windows.Forms.Button buttonChange;
        private ClassLibraryControlSelected.ControlListBox controlListBox;
        private ClassLibraryControlSelected.ControlPhoneNumberCheck controlPhoneNumberCheck;
        private ClassLibraryControlSelected.ControlListOfValues controlListOfValues;
        private System.Windows.Forms.TextBox textBoxMainString;
        private System.Windows.Forms.Button buttonWork;
    }
}

