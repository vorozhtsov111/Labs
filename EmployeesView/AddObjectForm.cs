using Employees;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmployeesView
{
    /// <summary>
    /// Форма добавления сотрудника
    /// </summary>
    public partial class AddObjectForm : Form
    {
        /// <summary>
        /// Добавляемый сотрудник
        /// </summary>
        private Employee employee;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AddObjectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возврат сотрудника
        /// </summary>
        /// <returns>Сотрудник</returns>
        public Employee GetEmployee()
        {
            return employee;
        }

        /// <summary>
        /// Обработчик нажатия кнопки ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            // Сотрудник с почасовой оплатой
            if (hourlyButton.Checked)
                employee = new HourlyPayEmployee(nameBox.Text, positionBox.Text,
                    (int)ageBox.Value, double.Parse(hourlyPayBox.Text),
                    double.Parse(hoursBox.Text));
            // Сотрудник с оплатой по окладу
            else if (salaryButton.Checked)
                employee = new SalaryEmployee(nameBox.Text, positionBox.Text,
                    (int)ageBox.Value, double.Parse(salaryBox.Text),
                    (int)workingDaysBox.Value, (int)actualDaysBox.Value);
            // Сотрудник с оплатой по ставке
            else
                employee = new RatePayEmployee(nameBox.Text, positionBox.Text,
                    (int)ageBox.Value, double.Parse(salaryBox.Text), 
                    double.Parse(rateBox.Text));
        }

        /// <summary>
        /// Выбор почасовой оплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hourlyButton_Click(object sender, EventArgs e)
        {
            // Доступны оплата в час и количество часов
            hourlyPayLabel.Enabled = true;
            hourlyPayBox.Enabled = true;
            hoursLabel.Enabled = true;
            hoursBox.Enabled = true;

            // Остальное недоступно
            salaryLabel.Enabled = false;
            salaryBox.Enabled = false;
            rateLabel.Enabled = false;
            workingDaysLabel.Enabled = false;
            workingDaysBox.Enabled = false;
            actualDaysLabel.Enabled = false;
            actualDaysBox.Enabled = false;
            rateLabel.Enabled = false;
            rateBox.Enabled = false;
        }

        /// <summary>
        /// Выбор оплаты по окладу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryButton_Click(object sender, EventArgs e)
        {
            // Недоступны оплата в час и количество часов
            hourlyPayLabel.Enabled = false;
            hourlyPayBox.Enabled = false;
            hoursLabel.Enabled = false;
            hoursBox.Enabled = false;

            // Доступны оклад, количества рабочих дней
            salaryLabel.Enabled = true;
            salaryBox.Enabled = true;
            workingDaysLabel.Enabled = true;
            workingDaysBox.Enabled = true;
            actualDaysLabel.Enabled = true;
            actualDaysBox.Enabled = true;

            // Ставка недоступна
            rateLabel.Enabled = false;
            rateBox.Enabled = false;
        }

        /// <summary>
        /// Оплата по ставке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rateButton_Click(object sender, EventArgs e)
        {
            // Недоступны оплата в час и количество часов
            hourlyPayLabel.Enabled = false;
            hourlyPayBox.Enabled = false;
            hoursLabel.Enabled = false;
            hoursBox.Enabled = false;

            // Оклад доступен
            salaryLabel.Enabled = true;
            salaryBox.Enabled = true;

            // Количества рабочих дней недоступны
            workingDaysLabel.Enabled = false;
            workingDaysBox.Enabled = false;
            actualDaysLabel.Enabled = false;
            actualDaysBox.Enabled = false;

            // Ставка доступна
            rateLabel.Enabled = true;
            rateBox.Enabled = true;
        }

        /// <summary>
        /// Валидация ФИО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text))
                MessageBox.Show("Имя не может быть пустым значением!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        /// <summary>
        /// Валидация должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void positionBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(positionBox.Text))
                MessageBox.Show("Должность не может быть пустым значением!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Валидация оплаты в час
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hourlyPayBox_Validating(object sender, CancelEventArgs e)
        {
            double hourlyPay;
            if (double.TryParse(hourlyPayBox.Text, out hourlyPay))
            {
                if (hourlyPay < 0)
                    MessageBox.Show("Оплата в час не может быть отрицательным числом!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Оплата в час не является числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Валидация количества часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hoursBox_Validating(object sender, CancelEventArgs e)
        {
            double hours;
            if (double.TryParse(hoursBox.Text, out hours))
            {
                if (hours < 0)
                    MessageBox.Show("Количество часов не может быть отрицательным числом!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Количество часов не является числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Валидация оклада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaryBox_Validating(object sender, CancelEventArgs e)
        {
            double salary;
            if (double.TryParse(salaryBox.Text, out salary))
            {
                if (salary < 0)
                    MessageBox.Show("Оклад не может быть отрицательным числом!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Оклад не является числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Валидация ставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rateBox_Validating(object sender, CancelEventArgs e)
        {
            double rate;
            if (double.TryParse(rateBox.Text, out rate))
            {
                if (rate < 0 || rate > 1.5)
                    MessageBox.Show("Ставка не может быть отрицательным числом" +
                        "или больше 1.5!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ставка не является числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Обработка строковых полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = string.IsNullOrEmpty(nameBox.Text) 
                || string.IsNullOrEmpty(positionBox.Text)
                || !double.TryParse(hourlyPayBox.Text, out double hourlyPay)
                || !double.TryParse(hoursBox.Text, out double hours)
                || !double.TryParse(salaryBox.Text, out double salary)
                || !double.TryParse(rateBox.Text, out double rate)
                || (hourlyPay < 0) || (hours < 0)
                || (salary < 0) || (rate < 0) || (rate > 1.5);
        }

        /// <summary>
        /// Обработка численных полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hourlyPayBox_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox mtb = sender as MaskedTextBox;
            if (string.IsNullOrEmpty(mtb.Text) || 
                !double.TryParse(mtb.Text.Replace('.', ','), out double _))
                    mtb.Text = "0";
        }
    }
}