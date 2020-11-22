
namespace View
{
    partial class FormCreateOraganizationUnit
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurename = new System.Windows.Forms.TextBox();
            this.textBoxPatr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.controlComboBoxSelected1 = new ClassLibraryControlSelected.ControlComboBoxSelected();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.controlDatePicker1 = new KoP_9var_CL.ControlDatePicker();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(119, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurename
            // 
            this.textBoxSurename.Location = new System.Drawing.Point(120, 67);
            this.textBoxSurename.Name = "textBoxSurename";
            this.textBoxSurename.Size = new System.Drawing.Size(162, 20);
            this.textBoxSurename.TabIndex = 1;
            // 
            // textBoxPatr
            // 
            this.textBoxPatr.Location = new System.Drawing.Point(121, 105);
            this.textBoxPatr.Name = "textBoxPatr";
            this.textBoxPatr.Size = new System.Drawing.Size(161, 20);
            this.textBoxPatr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчетсво";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип организации";
            // 
            // controlComboBoxSelected1
            // 
            this.controlComboBoxSelected1.Location = new System.Drawing.Point(121, 131);
            this.controlComboBoxSelected1.Name = "controlComboBoxSelected1";
            this.controlComboBoxSelected1.SelectedIndex = 0;
            this.controlComboBoxSelected1.Size = new System.Drawing.Size(161, 79);
            this.controlComboBoxSelected1.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(315, 316);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 25);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата";
            // 
            // controlDatePicker1
            // 
            this.controlDatePicker1.Date = null;
            this.controlDatePicker1.Example = "Ex: 16/05/2001";
            this.controlDatePicker1.isNull = false;
            this.controlDatePicker1.Location = new System.Drawing.Point(119, 216);
            this.controlDatePicker1.Name = "controlDatePicker1";
            this.controlDatePicker1.Size = new System.Drawing.Size(150, 91);
            this.controlDatePicker1.TabIndex = 10;
            // 
            // FormCreateOraganizationUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 373);
            this.Controls.Add(this.controlDatePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.controlComboBoxSelected1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatr);
            this.Controls.Add(this.textBoxSurename);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormCreateOraganizationUnit";
            this.Text = "FormCreateOraganizationUnit";
            this.Load += new System.EventHandler(this.FormCreateOraganizationUnit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurename;
        private System.Windows.Forms.TextBox textBoxPatr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ClassLibraryControlSelected.ControlComboBoxSelected controlComboBoxSelected1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private KoP_9var_CL.ControlDatePicker controlDatePicker1;
    }
}