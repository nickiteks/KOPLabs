using MainLogic.BindingModel;
using MainLogic.DataBase.Models;
using MainLogic.Logic;
using Patterns.FabricClasses;
using Patterns.FactoryClasses;
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
        }

        private void buttonBranchNew_Click(object sender, EventArgs e)
        {
            BranchNewOrganizationUnit unit = new BranchNewOrganizationUnit();
            AddOraganizationUnit(unit);
        }

        private void buttonOldBranch_Click(object sender, EventArgs e)
        {
            BranchOldOrganizationUnit unit = new BranchOldOrganizationUnit();
            AddOraganizationUnit(unit);
        }

        private void buttonNewRepresentation_Click(object sender, EventArgs e)
        {
            RepresentationNewOrganizationUnit unit = new RepresentationNewOrganizationUnit();
            AddOraganizationUnit(unit);
        }

        private void buttonOldRepresentation_Click(object sender, EventArgs e)
        {
            RepresentationOldUnit unit = new RepresentationOldUnit();
            AddOraganizationUnit(unit);
        }

        public void AddOraganizationUnit(UnitFactory unit)
        {
            try
            {
                unitLogic.CreateOrUpdate(new OrganizationUnitBindingModel
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurename.Text,
                    Patronymic = textBoxPatr.Text,
                    DateReport = controlDatePicker1.Date.Value,
                    noveltyUnit = unit.CreateNovelty().SetNovelty(),
                    typeOrganization = unit.CreateType().SetType()
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
