using Employees;
using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace EmployeesView
{
    public partial class EmployeesForm : Form
    {
        private BindingList<Employee> employees = new BindingList<Employee>();

        public EmployeesForm()
        {
            InitializeComponent();
            employeesGrid.DataSource = employees;
            #if !DEBUG
                randomButton.Visible = false;
                randomButton.Enabled = false;
            #endif
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            AddObjectForm aof = new AddObjectForm();
            if (aof.ShowDialog() == DialogResult.OK)
                employees.Add(aof.GetEmployee());
        }

        private void removeButton_Click(object sender, System.EventArgs e)
        {
            if (employeesGrid.CurrentRow == null)
                return;
            employees.RemoveAt(employeesGrid.CurrentRow.Index);
        }

        private void randomButton_Click(object sender, System.EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(0, 3);
                if (n == 0)
                    employees.Add(HourlyPayEmployee.RandomEmployee());
                else if (n == 1)
                    employees.Add(SalaryEmployee.RandomEmployee());
                else
                    employees.Add(RatePayEmployee.RandomEmployee());
                System.Threading.Thread.Sleep(r.Next(100));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            new SearchForm(employees).ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var writer = new XmlSerializer(typeof(BindingList<Employee>));
                using (var file = File.Create(sfd.FileName))
                {
                    writer.Serialize(file, employees);
                    file.Close();
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var reader = new XmlSerializer(typeof(BindingList<Employee>));
                var file = new StreamReader(ofd.FileName);
                employeesGrid.DataSource = employees = 
                    (BindingList<Employee>)reader.Deserialize(file);
                file.Close();
            }
        }
    }
}
