
namespace EmployeesView
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeesBox = new System.Windows.Forms.GroupBox();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.employeesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesBox
            // 
            this.employeesBox.Controls.Add(this.employeesGrid);
            this.employeesBox.Location = new System.Drawing.Point(13, 13);
            this.employeesBox.Name = "employeesBox";
            this.employeesBox.Size = new System.Drawing.Size(609, 370);
            this.employeesBox.TabIndex = 0;
            this.employeesBox.TabStop = false;
            this.employeesBox.Text = "Список сотрудников";
            // 
            // employeesGrid
            // 
            this.employeesGrid.AllowUserToAddRows = false;
            this.employeesGrid.AllowUserToDeleteRows = false;
            this.employeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesGrid.Location = new System.Drawing.Point(3, 18);
            this.employeesGrid.MultiSelect = false;
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.RowHeadersWidth = 51;
            this.employeesGrid.RowTemplate.Height = 24;
            this.employeesGrid.Size = new System.Drawing.Size(603, 349);
            this.employeesGrid.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(274, 389);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 30);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(450, 389);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(170, 30);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Удалить сотрудника";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(99, 389);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(169, 30);
            this.randomButton.TabIndex = 3;
            this.randomButton.Text = "Добавить случайных";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(450, 425);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(169, 30);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск сотрудников";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(275, 425);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить в файл";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(99, 425);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(169, 30);
            this.loadButton.TabIndex = 6;
            this.loadButton.Text = "Загрузить из файла";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "Employees files|*.empl";
            // 
            // sfd
            // 
            this.sfd.Filter = "Employees files|*.empl";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 470);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeesForm";
            this.Text = "База данных о сотрудниках";
            this.employeesBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeesBox;
        private System.Windows.Forms.DataGridView employeesGrid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

