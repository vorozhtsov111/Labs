using Employees;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmployeesView
{
    /// <summary>
    /// Форма поиска сотрудников
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Список сотрудников
        /// </summary>
        private readonly BindingList<Employee> employees;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="employees"></param>
        public SearchForm(BindingList<Employee> employees)
        {
            InitializeComponent();
            this.employees = employees;
        }

        /// <summary>
        /// Поиск сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            BindingList<Employee> tmp = new BindingList<Employee>();
            foreach (Employee emp in employees)
            {
                // Если выбран поиск по ФИО
                if (nameCheckBox.Checked)
                {
                    if (emp.Name != nameBox.Text)
                        continue;
                }
                // Если выбран поиск по должности
                if (positionCheckBox.Checked)
                {
                    if (emp.Position != positionBox.Text)
                        continue;
                }
                // Если выбран поиск по возрасту
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
