using Employees;
using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace EmployeesView
{
    /// <summary>
    /// Основная форма
    /// </summary>
    public partial class EmployeesForm : Form
    {
        /// <summary>
        /// Список сотрудников
        /// </summary>
        private BindingList<Employee> employees = new BindingList<Employee>();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeesForm()
        {
            InitializeComponent();
            // Связывание данных
            employeesGrid.DataSource = employees;
            // Добавление случайных данных в режиме Debug
            #if !DEBUG
                randomButton.Visible = false;
                randomButton.Enabled = false;
            #endif
        }

        /// <summary>
        /// Добавление сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, System.EventArgs e)
        {
            // Создание экземпляра формы добавления
            AddEmployeeForm aof = new AddEmployeeForm();
            // Если форма успешно отработала
            if (aof.ShowDialog() == DialogResult.OK)
                // Добавление сотрудника
                employees.Add(aof.GetEmployee());
        }

        /// <summary>
        /// Удаление сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, System.EventArgs e)
        {
            // Если строка некорректная
            if (employeesGrid.CurrentRow == null)
                // Выход
                return;
            // Удаление сотрудника из списка
            employees.RemoveAt(employeesGrid.CurrentRow.Index);
        }

        /// <summary>
        /// Создание 10 случайных сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randomButton_Click(object sender, System.EventArgs e)
        {
            Random r = new Random();
            // Цикл для создания 10 сотрудников
            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(0, 3);
                // Сотрудник с почасовой оплатой
                if (n == 0)
                    employees.Add(HourlyPayEmployee.RandomEmployee());
                // Сотрудник с оплатой по окладу
                else if (n == 1)
                    employees.Add(SalaryEmployee.RandomEmployee());
                // Сотрудник с оплатой по ставке
                else
                    employees.Add(RatePayEmployee.RandomEmployee());
                // Остановка потока для создания разных данных
                System.Threading.Thread.Sleep(r.Next(100));
            }
        }

        /// <summary>
        /// Поиск сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Вызов формы
            new SearchForm(employees).ShowDialog();
        }

        /// <summary>
        /// Сохранение данных в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Если диалоговое окно успешно завершилось
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Сериализация
                var writer = new XmlSerializer(typeof(BindingList<Employee>));
                using (var file = File.Create(sfd.FileName))
                {
                    writer.Serialize(file, employees);
                    file.Close();
                }
            }
        }

        /// <summary>
        /// Загрузка из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            // Если диалоговое окно успешно завершилось
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Десериализация
                var reader = new XmlSerializer(typeof(BindingList<Employee>));
                var file = new StreamReader(ofd.FileName);
                employeesGrid.DataSource = employees = 
                    (BindingList<Employee>)reader.Deserialize(file);
                file.Close();
            }
        }
    }
}
