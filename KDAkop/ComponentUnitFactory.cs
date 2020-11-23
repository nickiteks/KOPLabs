using MainLogic.BindingModel;
using MainLogic.Logic;
using Patterns.FabricClasses;
using Patterns.FactoryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDAkop
{
    public partial class ComponentUnitFactory : Component
    {
        public ComponentUnitFactory()
        {
            InitializeComponent();
        }

        public ComponentUnitFactory(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateBranchNew(IOrganizationUnitLogic unitLogic, string name, string surname, string patronymic, DateTime date)
        {
            BranchNewOrganizationUnit unit = new BranchNewOrganizationUnit();
            AddOraganizationUnit(unit,unitLogic,name,surname,patronymic,date);
        }

        public void CreateBranchOld(IOrganizationUnitLogic unitLogic, string name, string surname, string patronymic, DateTime date)
        {
            BranchOldOrganizationUnit unit = new BranchOldOrganizationUnit();
            AddOraganizationUnit(unit, unitLogic, name, surname, patronymic, date);
        }

        public void CreateRepresentationNew(IOrganizationUnitLogic unitLogic, string name, string surname, string patronymic, DateTime date)
        {
            RepresentationNewOrganizationUnit unit = new RepresentationNewOrganizationUnit();
            AddOraganizationUnit(unit, unitLogic, name, surname, patronymic, date);
        }

        public void CreateRepresentationOld(IOrganizationUnitLogic unitLogic, string name, string surname, string patronymic, DateTime date)
        {
            RepresentationOldUnit unit = new RepresentationOldUnit();
            AddOraganizationUnit(unit, unitLogic, name, surname, patronymic, date);
        }

        public void AddOraganizationUnit(UnitFactory unit, IOrganizationUnitLogic unitLogic, string name, string surname, string patronymic, DateTime date )
        {
            try
            {
                unitLogic.CreateOrUpdate(new OrganizationUnitBindingModel
                {
                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    DateReport = date,
                    noveltyUnit = unit.CreateNovelty().SetNovelty(),
                    typeOrganization = unit.CreateType().SetType()
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
