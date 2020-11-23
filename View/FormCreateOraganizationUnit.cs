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
            componentUnitFactory.CreateBranchNew(unitLogic, textBoxName.Text, textBoxSurename.Text, textBoxPatr.Text, controlDatePicker1.Date.Value);
            Close();
        }

        private void buttonOldBranch_Click(object sender, EventArgs e)
        {
            componentUnitFactory.CreateBranchOld(unitLogic, textBoxName.Text, textBoxSurename.Text, textBoxPatr.Text, controlDatePicker1.Date.Value);
            Close();
        }

        private void buttonNewRepresentation_Click(object sender, EventArgs e)
        {
            componentUnitFactory.CreateRepresentationNew(unitLogic, textBoxName.Text, textBoxSurename.Text, textBoxPatr.Text, controlDatePicker1.Date.Value);
            Close();
        }

        private void buttonOldRepresentation_Click(object sender, EventArgs e)
        {
            componentUnitFactory.CreateRepresentationOld(unitLogic, textBoxName.Text, textBoxSurename.Text, textBoxPatr.Text, controlDatePicker1.Date.Value);
            Close();
        }
    }
}
