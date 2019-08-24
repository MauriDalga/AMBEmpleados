namespace AMBEmpleados.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navigationPane = new System.Windows.Forms.Panel();
            this.contentPane = new System.Windows.Forms.Panel();
            this.statusPane = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.navigationPane.SuspendLayout();
            this.statusPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane
            // 
            this.navigationPane.BackColor = System.Drawing.Color.Black;
            this.navigationPane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.navigationPane.Controls.Add(this.button1);
            this.navigationPane.Controls.Add(this.modifyButton);
            this.navigationPane.Controls.Add(this.listButton);
            this.navigationPane.Controls.Add(this.homeButton);
            this.navigationPane.Location = new System.Drawing.Point(-2, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.Size = new System.Drawing.Size(733, 124);
            this.navigationPane.TabIndex = 0;
            // 
            // contentPane
            // 
            this.contentPane.BackColor = System.Drawing.Color.Black;
            this.contentPane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contentPane.Location = new System.Drawing.Point(-2, 122);
            this.contentPane.Name = "contentPane";
            this.contentPane.Size = new System.Drawing.Size(733, 456);
            this.contentPane.TabIndex = 1;
            // 
            // statusPane
            // 
            this.statusPane.BackColor = System.Drawing.Color.Silver;
            this.statusPane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusPane.Controls.Add(this.statusText);
            this.statusPane.Location = new System.Drawing.Point(12, 584);
            this.statusPane.Name = "statusPane";
            this.statusPane.Size = new System.Drawing.Size(704, 60);
            this.statusPane.TabIndex = 2;
            // 
            // statusText
            // 
            this.statusText.Enabled = false;
            this.statusText.Location = new System.Drawing.Point(3, 3);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(694, 49);
            this.statusText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Image = global::AMBEmpleados.Properties.Resources.adduser_añadir_3553;
            this.button1.Location = new System.Drawing.Point(204, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(136, 120);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.ForeColor = System.Drawing.Color.Aqua;
            this.modifyButton.Image = global::AMBEmpleados.Properties.Resources.edit_icon_icons_com_66118;
            this.modifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyButton.Location = new System.Drawing.Point(387, 1);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(136, 119);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyButton.UseCompatibleTextRendering = true;
            this.modifyButton.UseVisualStyleBackColor = false;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listButton.ForeColor = System.Drawing.Color.Aqua;
            this.listButton.Image = global::AMBEmpleados.Properties.Resources.to_do_list_icon_icons_com_76974;
            this.listButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listButton.Location = new System.Drawing.Point(562, 1);
            this.listButton.Margin = new System.Windows.Forms.Padding(0);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(114, 119);
            this.listButton.TabIndex = 1;
            this.listButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listButton.UseCompatibleTextRendering = true;
            this.listButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.Aqua;
            this.homeButton.Image = global::AMBEmpleados.Properties.Resources.home_silhouette_on_black_square_background_icon_icons_com_70471;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(17, 0);
            this.homeButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(138, 122);
            this.homeButton.TabIndex = 0;
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.UseCompatibleTextRendering = true;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(728, 650);
            this.Controls.Add(this.statusPane);
            this.Controls.Add(this.contentPane);
            this.Controls.Add(this.navigationPane);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AMB Empleados";
            this.navigationPane.ResumeLayout(false);
            this.statusPane.ResumeLayout(false);
            this.statusPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationPane;
        private System.Windows.Forms.Panel contentPane;
        private System.Windows.Forms.Panel statusPane;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button modifyButton;
    }
}

