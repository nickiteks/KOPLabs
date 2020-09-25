using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ClassLibraryControlSelected
{
    public partial class ControlListOfValues : UserControl
    {
        private string mainLine;

        private event EventHandler _listBoxSelectedElementChange;

        public string SetMainLine
        {
            set 
            { 
                mainLine = value; 
            }
        }

        public void GetPropertyValues(Object obj)
        {
            listBoxValues.Items.Clear();
            string _work=null;
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            string[] numbers = Regex.Split(mainLine , @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    if (props[i-1].GetIndexParameters().Length == 0)
                    {
                        _work = "{" + props[i-1].Name + "}" + "(" + props[i-1].PropertyType.Name + "): " + "{" + props[i-1].GetValue(obj) + "}";
                        listBoxValues.Items.Add(_work);
                    }
                    else
                        Console.WriteLine("   {0} ({1}): <Indexed>", props[i-1].Name,
                                          props[1].PropertyType.Name);
                }
            }           
        }

        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText
        {
            get { return listBoxValues.Text; }
        }

        public void SetValue()
        {


        }

        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ListBoxSelectedElementChange
        {
            add { _listBoxSelectedElementChange += value; }
            remove { _listBoxSelectedElementChange -= value; }
        }

        public ControlListOfValues()
        {
            InitializeComponent();
            listBoxValues.SelectedIndexChanged += (sender, e) => {
                _listBoxSelectedElementChange?.Invoke(sender, e);
            };
        }
    }
}
