
namespace EmployeesView
{
    partial class SearchForm
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
            this.baseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.positionBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.MaskedTextBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.positionCheckBox = new System.Windows.Forms.CheckBox();
            this.ageCheckBox = new System.Windows.Forms.CheckBox();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            this.baseLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // baseLayout
            // 
            this.baseLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.baseLayout.ColumnCount = 3;
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62791F));
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.37209F));
            this.baseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.baseLayout.Controls.Add(this.positionBox, 1, 1);
            this.baseLayout.Controls.Add(this.nameLabel, 0, 0);
            this.baseLayout.Controls.Add(this.positionLabel, 0, 1);
            this.baseLayout.Controls.Add(this.ageLabel, 0, 2);
            this.baseLayout.Controls.Add(this.ageBox, 1, 2);
            this.baseLayout.Controls.Add(this.nameBox, 1, 0);
            this.baseLayout.Controls.Add(this.nameCheckBox, 2, 0);
            this.baseLayout.Controls.Add(this.positionCheckBox, 2, 1);
            this.baseLayout.Controls.Add(this.ageCheckBox, 2, 2);
            this.baseLayout.Location = new System.Drawing.Point(12, 12);
            this.baseLayout.Name = "baseLayout";
            this.baseLayout.RowCount = 3;
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.baseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.baseLayout.Size = new System.Drawing.Size(459, 100);
            this.baseLayout.TabIndex = 1;
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(98, 37);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(333, 22);
            this.positionBox.TabIndex = 7;
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
            this.ageBox.Location = new System.Drawing.Point(98, 70);
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
            this.nameBox.Location = new System.Drawing.Point(98, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(333, 22);
            this.nameBox.TabIndex = 6;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(438, 4);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(17, 21);
            this.nameCheckBox.TabIndex = 8;
            this.nameCheckBox.Text = "checkBox1";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // positionCheckBox
            // 
            this.positionCheckBox.AutoSize = true;
            this.positionCheckBox.Location = new System.Drawing.Point(438, 37);
            this.positionCheckBox.Name = "positionCheckBox";
            this.positionCheckBox.Size = new System.Drawing.Size(17, 21);
            this.positionCheckBox.TabIndex = 9;
            this.positionCheckBox.Text = "checkBox2";
            this.positionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageCheckBox
            // 
            this.ageCheckBox.AutoSize = true;
            this.ageCheckBox.Location = new System.Drawing.Point(438, 70);
            this.ageCheckBox.Name = "ageCheckBox";
            this.ageCheckBox.Size = new System.Drawing.Size(17, 21);
            this.ageCheckBox.TabIndex = 10;
            this.ageCheckBox.Text = "checkBox3";
            this.ageCheckBox.UseVisualStyleBackColor = true;
            // 
            // employeesGrid
            // 
            this.employeesGrid.AllowUserToAddRows = false;
            this.employeesGrid.AllowUserToDeleteRows = false;
            this.employeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesGrid.Location = new System.Drawing.Point(12, 123);
            this.employeesGrid.MultiSelect = false;
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.RowHeadersWidth = 51;
            this.employeesGrid.RowTemplate.Height = 24;
            this.employeesGrid.Size = new System.Drawing.Size(603, 252);
            this.employeesGrid.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(529, 80);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(86, 32);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Поиск";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 389);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.employeesGrid);
            this.Controls.Add(this.baseLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Поиск сотрудников";
            this.baseLayout.ResumeLayout(false);
            this.baseLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseLayout;
        private System.Windows.Forms.MaskedTextBox positionBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.MaskedTextBox nameBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox positionCheckBox;
        private System.Windows.Forms.CheckBox ageCheckBox;
        private System.Windows.Forms.DataGridView employeesGrid;
        private System.Windows.Forms.Button okButton;
    }
}