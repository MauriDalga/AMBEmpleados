namespace AMBEmpleados.Views
{
    partial class Modify
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
            this.loadFieldsButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.bornDatePicker = new System.Windows.Forms.DateTimePicker();
            this.hiringDatePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryNumericBox = new System.Windows.Forms.NumericUpDown();
            this.codeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.hiringLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.completeNameLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.unsubscribeLabel = new System.Windows.Forms.Label();
            this.cancelModifyButton = new System.Windows.Forms.Button();
            this.unsubscribeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFieldsButton
            // 
            this.loadFieldsButton.BackColor = System.Drawing.Color.White;
            this.loadFieldsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadFieldsButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.loadFieldsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadFieldsButton.Location = new System.Drawing.Point(469, 74);
            this.loadFieldsButton.Name = "loadFieldsButton";
            this.loadFieldsButton.Size = new System.Drawing.Size(139, 30);
            this.loadFieldsButton.TabIndex = 25;
            this.loadFieldsButton.Text = "Cargar Campos";
            this.loadFieldsButton.UseVisualStyleBackColor = false;
            this.loadFieldsButton.Click += new System.EventHandler(this.cancelAddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton.Location = new System.Drawing.Point(150, 375);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 34);
            this.UpdateButton.TabIndex = 24;
            this.UpdateButton.Text = "Modificar";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bornDatePicker
            // 
            this.bornDatePicker.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bornDatePicker.CalendarMonthBackground = System.Drawing.Color.BlueViolet;
            this.bornDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bornDatePicker.CalendarTitleForeColor = System.Drawing.Color.Crimson;
            this.bornDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.bornDatePicker.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.bornDatePicker.Location = new System.Drawing.Point(316, 164);
            this.bornDatePicker.Name = "bornDatePicker";
            this.bornDatePicker.Size = new System.Drawing.Size(292, 22);
            this.bornDatePicker.TabIndex = 23;
            // 
            // hiringDatePicker
            // 
            this.hiringDatePicker.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hiringDatePicker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.hiringDatePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hiringDatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hiringDatePicker.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.hiringDatePicker.Location = new System.Drawing.Point(316, 214);
            this.hiringDatePicker.Name = "hiringDatePicker";
            this.hiringDatePicker.Size = new System.Drawing.Size(292, 22);
            this.hiringDatePicker.TabIndex = 22;
            // 
            // salaryNumericBox
            // 
            this.salaryNumericBox.BackColor = System.Drawing.Color.White;
            this.salaryNumericBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.salaryNumericBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salaryNumericBox.Location = new System.Drawing.Point(316, 269);
            this.salaryNumericBox.Name = "salaryNumericBox";
            this.salaryNumericBox.Size = new System.Drawing.Size(172, 22);
            this.salaryNumericBox.TabIndex = 21;
            // 
            // codeNumericBox
            // 
            this.codeNumericBox.BackColor = System.Drawing.Color.White;
            this.codeNumericBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.codeNumericBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.codeNumericBox.Location = new System.Drawing.Point(316, 79);
            this.codeNumericBox.Name = "codeNumericBox";
            this.codeNumericBox.Size = new System.Drawing.Size(120, 22);
            this.codeNumericBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameTextBox.Location = new System.Drawing.Point(316, 116);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 22);
            this.nameTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(95, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 18;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.salaryLabel.Location = new System.Drawing.Point(93, 271);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(108, 16);
            this.salaryLabel.TabIndex = 17;
            this.salaryLabel.Text = "Salario por hora";
            // 
            // hiringLabel
            // 
            this.hiringLabel.AutoSize = true;
            this.hiringLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiringLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hiringLabel.Location = new System.Drawing.Point(93, 219);
            this.hiringLabel.Name = "hiringLabel";
            this.hiringLabel.Size = new System.Drawing.Size(114, 16);
            this.hiringLabel.TabIndex = 16;
            this.hiringLabel.Text = "Fecha de Ingreso";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.birthLabel.Location = new System.Drawing.Point(93, 169);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(138, 16);
            this.birthLabel.TabIndex = 15;
            this.birthLabel.Text = "Fecha de Nacimiento";
            // 
            // completeNameLabel
            // 
            this.completeNameLabel.AutoSize = true;
            this.completeNameLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.completeNameLabel.Location = new System.Drawing.Point(93, 119);
            this.completeNameLabel.Name = "completeNameLabel";
            this.completeNameLabel.Size = new System.Drawing.Size(122, 16);
            this.completeNameLabel.TabIndex = 14;
            this.completeNameLabel.Text = "Nombre Completo";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeLabel.Location = new System.Drawing.Point(93, 81);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(51, 16);
            this.codeLabel.TabIndex = 13;
            this.codeLabel.Text = "Código";
            // 
            // unsubscribeLabel
            // 
            this.unsubscribeLabel.AutoSize = true;
            this.unsubscribeLabel.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.unsubscribeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.unsubscribeLabel.Location = new System.Drawing.Point(95, 321);
            this.unsubscribeLabel.Name = "unsubscribeLabel";
            this.unsubscribeLabel.Size = new System.Drawing.Size(74, 16);
            this.unsubscribeLabel.TabIndex = 26;
            this.unsubscribeLabel.Text = "Baja lógica";
            // 
            // cancelModifyButton
            // 
            this.cancelModifyButton.BackColor = System.Drawing.Color.White;
            this.cancelModifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelModifyButton.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.cancelModifyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelModifyButton.Location = new System.Drawing.Point(469, 375);
            this.cancelModifyButton.Name = "cancelModifyButton";
            this.cancelModifyButton.Size = new System.Drawing.Size(91, 34);
            this.cancelModifyButton.TabIndex = 27;
            this.cancelModifyButton.Text = "Cancelar";
            this.cancelModifyButton.UseVisualStyleBackColor = false;
            // 
            // unsubscribeCheck
            // 
            this.unsubscribeCheck.AutoSize = true;
            this.unsubscribeCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unsubscribeCheck.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.unsubscribeCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.unsubscribeCheck.Location = new System.Drawing.Point(316, 323);
            this.unsubscribeCheck.Name = "unsubscribeCheck";
            this.unsubscribeCheck.Size = new System.Drawing.Size(15, 14);
            this.unsubscribeCheck.TabIndex = 28;
            this.unsubscribeCheck.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(223, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modificar Empleado";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unsubscribeCheck);
            this.Controls.Add(this.cancelModifyButton);
            this.Controls.Add(this.unsubscribeLabel);
            this.Controls.Add(this.loadFieldsButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.bornDatePicker);
            this.Controls.Add(this.hiringDatePicker);
            this.Controls.Add(this.salaryNumericBox);
            this.Controls.Add(this.codeNumericBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.hiringLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.completeNameLabel);
            this.Controls.Add(this.codeLabel);
            this.Name = "Modify";
            this.Size = new System.Drawing.Size(733, 456);
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFieldsButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DateTimePicker bornDatePicker;
        private System.Windows.Forms.DateTimePicker hiringDatePicker;
        private System.Windows.Forms.NumericUpDown salaryNumericBox;
        private System.Windows.Forms.NumericUpDown codeNumericBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label hiringLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label completeNameLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label unsubscribeLabel;
        private System.Windows.Forms.Button cancelModifyButton;
        private System.Windows.Forms.CheckBox unsubscribeCheck;
        private System.Windows.Forms.Label label1;
    }
}
