
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
            this.label5 = new System.Windows.Forms.Label();
            this.controlDatePicker1 = new KoP_9var_CL.ControlDatePicker();
            this.buttonBranchNew = new System.Windows.Forms.Button();
            this.buttonOldBranch = new System.Windows.Forms.Button();
            this.buttonNewRepresentation = new System.Windows.Forms.Button();
            this.buttonOldRepresentation = new System.Windows.Forms.Button();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 192);
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
            this.controlDatePicker1.Location = new System.Drawing.Point(121, 175);
            this.controlDatePicker1.Name = "controlDatePicker1";
            this.controlDatePicker1.Size = new System.Drawing.Size(150, 91);
            this.controlDatePicker1.TabIndex = 10;
            // 
            // buttonBranchNew
            // 
            this.buttonBranchNew.Location = new System.Drawing.Point(24, 283);
            this.buttonBranchNew.Name = "buttonBranchNew";
            this.buttonBranchNew.Size = new System.Drawing.Size(101, 24);
            this.buttonBranchNew.TabIndex = 11;
            this.buttonBranchNew.Text = "Новый филиал";
            this.buttonBranchNew.UseVisualStyleBackColor = true;
            this.buttonBranchNew.Click += new System.EventHandler(this.buttonBranchNew_Click);
            // 
            // buttonOldBranch
            // 
            this.buttonOldBranch.Location = new System.Drawing.Point(24, 313);
            this.buttonOldBranch.Name = "buttonOldBranch";
            this.buttonOldBranch.Size = new System.Drawing.Size(101, 25);
            this.buttonOldBranch.TabIndex = 12;
            this.buttonOldBranch.Text = "Старый филиал";
            this.buttonOldBranch.UseVisualStyleBackColor = true;
            this.buttonOldBranch.Click += new System.EventHandler(this.buttonOldBranch_Click);
            // 
            // buttonNewRepresentation
            // 
            this.buttonNewRepresentation.Location = new System.Drawing.Point(178, 283);
            this.buttonNewRepresentation.Name = "buttonNewRepresentation";
            this.buttonNewRepresentation.Size = new System.Drawing.Size(191, 25);
            this.buttonNewRepresentation.TabIndex = 13;
            this.buttonNewRepresentation.Text = "Новое представительство";
            this.buttonNewRepresentation.UseVisualStyleBackColor = true;
            this.buttonNewRepresentation.Click += new System.EventHandler(this.buttonNewRepresentation_Click);
            // 
            // buttonOldRepresentation
            // 
            this.buttonOldRepresentation.Location = new System.Drawing.Point(178, 315);
            this.buttonOldRepresentation.Name = "buttonOldRepresentation";
            this.buttonOldRepresentation.Size = new System.Drawing.Size(191, 23);
            this.buttonOldRepresentation.TabIndex = 14;
            this.buttonOldRepresentation.Text = "Старое представительство";
            this.buttonOldRepresentation.UseVisualStyleBackColor = true;
            this.buttonOldRepresentation.Click += new System.EventHandler(this.buttonOldRepresentation_Click);
            // 
            // FormCreateOraganizationUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 364);
            this.Controls.Add(this.buttonOldRepresentation);
            this.Controls.Add(this.buttonNewRepresentation);
            this.Controls.Add(this.buttonOldBranch);
            this.Controls.Add(this.buttonBranchNew);
            this.Controls.Add(this.controlDatePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatr);
            this.Controls.Add(this.textBoxSurename);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormCreateOraganizationUnit";
            this.Text = "FormCreateOraganizationUnit";
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
        private System.Windows.Forms.Label label5;
        private KoP_9var_CL.ControlDatePicker controlDatePicker1;
        private System.Windows.Forms.Button buttonBranchNew;
        private System.Windows.Forms.Button buttonOldBranch;
        private System.Windows.Forms.Button buttonNewRepresentation;
        private System.Windows.Forms.Button buttonOldRepresentation;
    }
}