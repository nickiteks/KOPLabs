﻿using MainLogic.DataBase.Models;
using MainLogic.Logic;
using MainLogic.ViewModel;
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
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IOrganizationUnitLogic unitLogic;
        public FormMain(IOrganizationUnitLogic unitLogic)
        {
            InitializeComponent();
            this.unitLogic = unitLogic;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            var unit = unitLogic.Read(null);
            userControlListOutput.SetOrder(new string[] { "Name", "DateReport", "typeOrganization"});
            userControlListOutput.AddAll(unit);
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {

            var units = unitLogic.Read(null);
            List<List<String>> data = new List<List<String>>();
            List<String> dateHelp1 = new List<String>();
            List<String> dateHelp2 = new List<String>();
            foreach (var unit in units)
            {
                dateHelp1.Add(unit.Name);
                dateHelp2.Add(unit.typeOrganization.ToString());
            }
            data.Add(dateHelp1);
            data.Add(dateHelp2);
            componentWordSummary.SetData(data);
            componentWordSummary.rowCount = units.Count;
            componentWordSummary.columnCount = 2;
            SaveFileDialog sf = new SaveFileDialog();
            if(sf.ShowDialog() == DialogResult.OK)
            {
                componentWordSummary.CreateTable(new string[] { "Начальник подразделения", "тип подразделения" }, null, sf.FileName); ;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);
            backupComponent.saveData<OrganizanionUnitViewModel>("D:/1/2",units.ToArray());
            MessageBox.Show("Бекап создан!");
        }

        private void buttonWordDiagramm_Click(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);
            List<string> months = new List<string>
            {
                "January", 
                "February",
                "March",  
                "April", 
                "May",
                "June",
                "July",
                "August", 
                "September",
                "October", 
                "November",
                "December",
            };
            List<int> monthCount = new List<int>()
            {
                0,0,0,0,0,0,0,0,0,0,0,0
            };
            foreach (var unit in units)
            {
                int month = unit.DateReport.Value.Month;
                monthCount[month - 1] += 1;
            }
            wordDiagram.CreateDiagramInWord(months,monthCount, "D:/1/digramm.docx");
            MessageBox.Show("Диаграмма создана");
        }

        private void добавитьОгрганизациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOraganizationUnit>();
            form.ShowDialog();
            var unit = unitLogic.Read(null);
            userControlListOutput.SetOrder(new string[] { "Name", "DateReport", "typeOrganization" });
            userControlListOutput.AddAll(unit);
        }
    }
}
