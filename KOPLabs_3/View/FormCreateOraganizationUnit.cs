using MainLogic.BindingModel;
using MainLogic.DataBase.Models;
using MainLogic.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormCreateOraganizationUnit : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IOrganizationUnitLogic unitLogic;
        public FormCreateOraganizationUnit(IOrganizationUnitLogic unitLogic)
        {
            InitializeComponent();
            this.unitLogic = unitLogic;
            controlComboBoxSelected1.LoadEnumeration(typeof(TypeOrganization));
        }

        private void FormCreateOraganizationUnit_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                unitLogic.CreateOrUpdate(new OrganizationUnitBindingModel
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurename.Text,
                    Patronymic = textBoxPatr.Text,
                    typeOrganization = (TypeOrganization)controlComboBoxSelected1.SelectedIndex,
                    DateReport = controlDatePicker1.Date.Value
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
