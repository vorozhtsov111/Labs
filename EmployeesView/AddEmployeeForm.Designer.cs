
namespace EmployeesView
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dataBox = new System.Windows.Forms.GroupBox();
            this.addLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rateBox = new System.Windows.Forms.MaskedTextBox();
            this.salaryBox = new System.Windows.Forms.MaskedTextBox();
            this.hoursBox = new System.Windows.Forms.MaskedTextBox();
            this.hourlyPayBox = new System.Windows.Forms.MaskedTextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.actualDaysLabel = new System.Windows.Forms.Label();
            this.workingDaysLabel = new System.Windows.Forms.Label();
            this.hourlyPayLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.workingDaysBox = new System.Windows.Forms.NumericUpDown();
            this.actualDaysBox = new System.Windows.Forms.NumericUpDown();
            this.paymentBox = new System.Windows.Forms.GroupBox();
            this.rateButton = new System.Windows.Forms.RadioButton();
            this.hourlyButton = new System.Windows.Forms.RadioButton();
            this.salaryButton = new System.Windows.Forms.RadioButton();
            this.baseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.positionBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.MaskedTextBox();
            this.dataBox.SuspendLayout();
            this.addLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingDaysBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualDaysBox)).BeginInit();
            this.paymentBox.SuspendLayout();
            this.baseLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(323, 370);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(86, 32);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(415, 370);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // dataBox
            // 
            this.dataBox.Controls.Add(this.addLayout);
            this.dataBox.Controls.Add(this.paymentBox);
            this.dataBox.Controls.Add(this.baseLayout);
            this.dataBox.Location = new System.Drawing.Point(12, 6);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(487, 351);
            this.dataBox.TabIndex = 2;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Сотрудник";
            // 
            // addLayout
            // 
            this.addLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.addLayout.ColumnCount = 2;
            this.addLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.4902F));
            this.addLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5098F));
            this.addLayout.Controls.Add(this.rateBox, 1, 5);
            this.addLayout.Controls.Add(this.salaryBox, 1, 2);
            this.addLayout.Controls.Add(this.hoursBox, 1, 1);
            this.addLayout.Controls.Add(this.hourlyPayBox, 1, 0);
            this.addLayout.Controls.Add(this.rateLabel, 0, 5);
            this.addLayout.Controls.Add(this.actualDaysLabel, 0, 4);
            this.addLayout.Controls.Add(this.workingDaysLabel, 0, 3);
            this.addLayout.Controls.Add(this.hourlyPayLabel, 0, 0);
            this.addLayout.Controls.Add(this.hoursLabel, 0, 1);
            this.addLayout.Controls.Add(this.salaryLabel, 0, 2);
            this.addLayout.Controls.Add(this.workingDaysBox, 1, 3);
            this.addLayout.Controls.Add(this.actualDaysBox, 1, 4);
            this.addLayout.Location = new System.Drawing.Point(234, 154);
            this.addLayout.Name = "addLayout";
            this.addLayout.RowCount = 6;
            this.addLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.addLayout.Size = new System.Drawing.Size(235, 180);
            this.addLayout.TabIndex = 2;
            // 
            // rateBox
            // 
            this.rateBox.Enabled = false;
            this.rateBox.Location = new System.Drawing.Point(156, 149);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(60, 22);
            this.rateBox.TabIndex = 14;
            this.rateBox.Text = "0";
            this.rateBox.TextChanged += new System.EventHandler(this.hourlyPayBox_TextChanged);
            this.rateBox.Validating += new System.ComponentModel.CancelEventHandler(this.rateBox_Validating);
            // 
            // salaryBox
            // 
            this.salaryBox.Enabled = false;
            this.salaryBox.Location = new System.Drawing.Point(156, 62);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(60, 22);
            this.salaryBox.TabIndex = 13;
            this.salaryBox.Text = "0";
            this.salaryBox.TextChanged += new System.EventHandler(this.hourlyPayBox_TextChanged);
            this.salaryBox.Validating += new System.ComponentModel.CancelEventHandler(this.salaryBox_Validating);
            // 
            // hoursBox
            // 
            this.hoursBox.Location = new System.Drawing.Point(156, 33);
            this.hoursBox.Name = "hoursBox";
            this.hoursBox.Size = new System.Drawing.Size(60, 22);
            this.hoursBox.TabIndex = 12;
            this.hoursBox.Text = "0";
            this.hoursBox.TextChanged += new System.EventHandler(this.hourlyPayBox_TextChanged);
            this.hoursBox.Validating += new System.ComponentModel.CancelEventHandler(this.hoursBox_Validating);
            // 
            // hourlyPayBox
            // 
            this.hourlyPayBox.Location = new System.Drawing.Point(156, 4);
            this.hourlyPayBox.Name = "hourlyPayBox";
            this.hourlyPayBox.Size = new System.Drawing.Size(60, 22);
            this.hourlyPayBox.TabIndex = 11;
            this.hourlyPayBox.Text = "0";
            this.hourlyPayBox.TextChanged += new System.EventHandler(this.hourlyPayBox_TextChanged);
            this.hourlyPayBox.Validating += new System.ComponentModel.CancelEventHandler(this.hourlyPayBox_Validating);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Enabled = false;
            this.rateLabel.Location = new System.Drawing.Point(4, 146);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(54, 17);
            this.rateLabel.TabIndex = 8;
            this.rateLabel.Text = "Ставка";
            // 
            // actualDaysLabel
            // 
            this.actualDaysLabel.AutoSize = true;
            this.actualDaysLabel.Enabled = false;
            this.actualDaysLabel.Location = new System.Drawing.Point(4, 117);
            this.actualDaysLabel.Name = "actualDaysLabel";
            this.actualDaysLabel.Size = new System.Drawing.Size(135, 17);
            this.actualDaysLabel.TabIndex = 7;
            this.actualDaysLabel.Text = "Отработанные дни";
            // 
            // workingDaysLabel
            // 
            this.workingDaysLabel.AutoSize = true;
            this.workingDaysLabel.Enabled = false;
            this.workingDaysLabel.Location = new System.Drawing.Point(4, 88);
            this.workingDaysLabel.Name = "workingDaysLabel";
            this.workingDaysLabel.Size = new System.Drawing.Size(93, 17);
            this.workingDaysLabel.TabIndex = 6;
            this.workingDaysLabel.Text = "Рабочие дни";
            // 
            // hourlyPayLabel
            // 
            this.hourlyPayLabel.AutoSize = true;
            this.hourlyPayLabel.Location = new System.Drawing.Point(4, 1);
            this.hourlyPayLabel.Name = "hourlyPayLabel";
            this.hourlyPayLabel.Size = new System.Drawing.Size(96, 17);
            this.hourlyPayLabel.TabIndex = 0;
            this.hourlyPayLabel.Text = "Оплата в час";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(4, 30);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(128, 17);
            this.hoursLabel.TabIndex = 1;
            this.hoursLabel.Text = "Количество часов";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Enabled = false;
            this.salaryLabel.Location = new System.Drawing.Point(4, 59);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(50, 17);
            this.salaryLabel.TabIndex = 2;
            this.salaryLabel.Text = "Оклад";
            // 
            // workingDaysBox
            // 
            this.workingDaysBox.Enabled = false;
            this.workingDaysBox.Location = new System.Drawing.Point(156, 91);
            this.workingDaysBox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.workingDaysBox.Name = "workingDaysBox";
            this.workingDaysBox.Size = new System.Drawing.Size(50, 22);
            this.workingDaysBox.TabIndex = 9;
            this.workingDaysBox.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // actualDaysBox
            // 
            this.actualDaysBox.Enabled = false;
            this.actualDaysBox.Location = new System.Drawing.Point(156, 120);
            this.actualDaysBox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.actualDaysBox.Name = "actualDaysBox";
            this.actualDaysBox.Size = new System.Drawing.Size(50, 22);
            this.actualDaysBox.TabIndex = 10;
            this.actualDaysBox.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // paymentBox
            // 
            this.paymentBox.Controls.Add(this.rateButton);
            this.paymentBox.Controls.Add(this.hourlyButton);
            this.paymentBox.Controls.Add(this.salaryButton);
            this.paymentBox.Location = new System.Drawing.Point(18, 145);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(200, 109);
            this.paymentBox.TabIndex = 1;
            this.paymentBox.TabStop = false;
            this.paymentBox.Text = "Вид оплаты";
            // 
            // rateButton
            // 
            this.rateButton.AutoSize = true;
            this.rateButton.Location = new System.Drawing.Point(21, 72);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(144, 21);
            this.rateButton.TabIndex = 0;
            this.rateButton.Text = "Оплата по ставке";
            this.rateButton.UseVisualStyleBackColor = true;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // hourlyButton
            // 
            this.hourlyButton.AutoSize = true;
            this.hourlyButton.Checked = true;
            this.hourlyButton.Location = new System.Drawing.Point(21, 22);
            this.hourlyButton.Name = "hourlyButton";
            this.hourlyButton.Size = new System.Drawing.Size(149, 21);
            this.hourlyButton.TabIndex = 0;
            this.hourlyButton.TabStop = true;
            this.hourlyButton.Text = "Почасовая оплата";
            this.hourlyButton.UseVisualStyleBackColor = true;
            this.hourlyButton.Click += new System.EventHandler(this.hourlyButton_Click);
            // 
            // salaryButton
            // 
            this.salaryButton.AutoSize = true;
            this.salaryButton.Location = new System.Drawing.Point(21, 47);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(146, 21);
            this.salaryButton.TabIndex = 0;
            this.salaryButton.Text = "Оплата по окладу";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // baseLayout
            // 
            this.baseLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.baseLayout.ColumnCount = 2;
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74522F));
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.25478F));
            this.baseLayout.Controls.Add(this.positionBox, 1, 1);
            this.baseLayout.Controls.Add(this.nameLabel, 0, 0);
            this.baseLayout.Controls.Add(this.positionLabel, 0, 1);
            this.baseLayout.Controls.Add(this.ageLabel, 0, 2);
            this.baseLayout.Controls.Add(this.ageBox, 1, 2);
            this.baseLayout.Controls.Add(this.nameBox, 1, 0);
            this.baseLayout.Location = new System.Drawing.Point(18, 35);
            this.baseLayout.Name = "baseLayout";
            this.baseLayout.RowCount = 3;
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseLayout.Size = new System.Drawing.Size(451, 100);
            this.baseLayout.TabIndex = 0;
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(93, 37);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(354, 22);
            this.positionBox.TabIndex = 7;
            this.positionBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.positionBox.Validating += new System.ComponentModel.CancelEventHandler(this.positionBox_Validating);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 1);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "ФИО";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(4, 34);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(81, 17);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Должность";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(4, 67);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 17);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Возраст";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(93, 70);
            this.ageBox.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ageBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(50, 22);
            this.ageBox.TabIndex = 5;
            this.ageBox.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(93, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(354, 22);
            this.nameBox.TabIndex = 6;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameBox_Validating);
            // 
            // AddObjectForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(513, 413);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddObjectForm";
            this.Text = "Добавление сотрудника";
            this.dataBox.ResumeLayout(false);
            this.addLayout.ResumeLayout(false);
            this.addLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingDaysBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualDaysBox)).EndInit();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.baseLayout.ResumeLayout(false);
            this.baseLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.GroupBox paymentBox;
        private System.Windows.Forms.RadioButton hourlyButton;
        private System.Windows.Forms.TableLayoutPanel baseLayout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.RadioButton rateButton;
        private System.Windows.Forms.RadioButton salaryButton;
        private System.Windows.Forms.TableLayoutPanel addLayout;
        private System.Windows.Forms.Label hourlyPayLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label workingDaysLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label actualDaysLabel;
        private System.Windows.Forms.NumericUpDown workingDaysBox;
        private System.Windows.Forms.NumericUpDown actualDaysBox;
        private System.Windows.Forms.MaskedTextBox rateBox;
        private System.Windows.Forms.MaskedTextBox salaryBox;
        private System.Windows.Forms.MaskedTextBox hoursBox;
        private System.Windows.Forms.MaskedTextBox hourlyPayBox;
        private System.Windows.Forms.MaskedTextBox positionBox;
        private System.Windows.Forms.MaskedTextBox nameBox;
    }
}