using Employees;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmployeesView
{
    public partial class SearchForm : Form
    {
        private readonly BindingList<Employee> employees;

        public SearchForm(BindingList<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            BindingList<Employee> tmp = new BindingList<Employee>();
            foreach (Employee emp in employees)
            {
                if (nameCheckBox.Checked)
                {
                    if (emp.Name != nameBox.Text)
                        continue;
                }
                if (positionCheckBox.Checked)
                {
                    if (emp.Position != positionBox.Text)
                        continue;
                }
                if (ageCheckBox.Checked)
                {
                    if (emp.Age != ageBox.Value)
                        continue;
                }
                tmp.Add(emp);
            }
            employeesGrid.DataSource = tmp;
        }
    }
}
