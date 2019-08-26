namespace AMBEmpleados.Views
{
    partial class Add
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeLabel = new System.Windows.Forms.Label();
            this.completeNameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.hiringLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.salaryNumericBox = new System.Windows.Forms.NumericUpDown();
            this.hiringDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bornDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeLabel.Location = new System.Drawing.Point(72, 85);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(51, 16);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Código";
            // 
            // completeNameLabel
            // 
            this.completeNameLabel.AutoSize = true;
            this.completeNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.completeNameLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.completeNameLabel.Location = new System.Drawing.Point(72, 132);
            this.completeNameLabel.Name = "completeNameLabel";
            this.completeNameLabel.Size = new System.Drawing.Size(122, 16);
            this.completeNameLabel.TabIndex = 1;
            this.completeNameLabel.Text = "Nombre Completo";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.birthLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.birthLabel.Location = new System.Drawing.Point(72, 189);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(138, 16);
            this.birthLabel.TabIndex = 2;
            this.birthLabel.Text = "Fecha de Nacimiento";
            // 
            // hiringLabel
            // 
            this.hiringLabel.AutoSize = true;
            this.hiringLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hiringLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiringLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hiringLabel.Location = new System.Drawing.Point(72, 239);
            this.hiringLabel.Name = "hiringLabel";
            this.hiringLabel.Size = new System.Drawing.Size(114, 16);
            this.hiringLabel.TabIndex = 3;
            this.hiringLabel.Text = "Fecha de Ingreso";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salaryLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salaryLabel.Location = new System.Drawing.Point(72, 291);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(108, 16);
            this.salaryLabel.TabIndex = 4;
            this.salaryLabel.Text = "Salario por hora";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.nameTextBox.Location = new System.Drawing.Point(295, 131);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // codeNumericBox
            // 
            this.codeNumericBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.codeNumericBox.Location = new System.Drawing.Point(295, 85);
            this.codeNumericBox.Name = "codeNumericBox";
            this.codeNumericBox.Size = new System.Drawing.Size(172, 22);
            this.codeNumericBox.TabIndex = 7;
            // 
            // salaryNumericBox
            // 
            this.salaryNumericBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.salaryNumericBox.Location = new System.Drawing.Point(295, 291);
            this.salaryNumericBox.Name = "salaryNumericBox";
            this.salaryNumericBox.Size = new System.Drawing.Size(172, 22);
            this.salaryNumericBox.TabIndex = 8;
            // 
            // hiringDatePicker
            // 
            this.hiringDatePicker.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.hiringDatePicker.Location = new System.Drawing.Point(295, 235);
            this.hiringDatePicker.Name = "hiringDatePicker";
            this.hiringDatePicker.Size = new System.Drawing.Size(292, 22);
            this.hiringDatePicker.TabIndex = 9;
            // 
            // bornDatePicker
            // 
            this.bornDatePicker.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bornDatePicker.Location = new System.Drawing.Point(295, 185);
            this.bornDatePicker.Name = "bornDatePicker";
            this.bornDatePicker.Size = new System.Drawing.Size(292, 22);
            this.bornDatePicker.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.addButton.Location = new System.Drawing.Point(125, 368);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 33);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelAddButton
            // 
            this.cancelAddButton.BackColor = System.Drawing.Color.White;
            this.cancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelAddButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.cancelAddButton.Location = new System.Drawing.Point(470, 368);
            this.cancelAddButton.Name = "cancelAddButton";
            this.cancelAddButton.Size = new System.Drawing.Size(99, 33);
            this.cancelAddButton.TabIndex = 12;
            this.cancelAddButton.Text = "Cancelar";
            this.cancelAddButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Agregar Empleado";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.cancelAddButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bornDatePicker);
            this.Controls.Add(this.hiringDatePicker);
            this.Controls.Add(this.salaryNumericBox);
            this.Controls.Add(this.codeNumericBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.hiringLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.completeNameLabel);
            this.Controls.Add(this.codeLabel);
            this.Name = "Add";
            this.Size = new System.Drawing.Size(733, 456);
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label completeNameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label hiringLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown codeNumericBox;
        private System.Windows.Forms.NumericUpDown salaryNumericBox;
        private System.Windows.Forms.DateTimePicker hiringDatePicker;
        private System.Windows.Forms.DateTimePicker bornDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelAddButton;
        private System.Windows.Forms.Label label1;
    }
}
