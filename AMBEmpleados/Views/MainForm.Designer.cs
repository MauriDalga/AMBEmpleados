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
            this.addViewButton = new System.Windows.Forms.Button();
            this.modifyViewButton = new System.Windows.Forms.Button();
            this.listViewButton = new System.Windows.Forms.Button();
            this.homeViewButton = new System.Windows.Forms.Button();
            this.contentPane = new System.Windows.Forms.Panel();
            this.statusPane = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.TextBox();
            this.navigationPane.SuspendLayout();
            this.statusPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane
            // 
            this.navigationPane.BackColor = System.Drawing.Color.Black;
            this.navigationPane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.navigationPane.Controls.Add(this.addViewButton);
            this.navigationPane.Controls.Add(this.modifyViewButton);
            this.navigationPane.Controls.Add(this.listViewButton);
            this.navigationPane.Controls.Add(this.homeViewButton);
            this.navigationPane.Location = new System.Drawing.Point(-2, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.Size = new System.Drawing.Size(733, 124);
            this.navigationPane.TabIndex = 0;
            // 
            // addViewButton
            // 
            this.addViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addViewButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addViewButton.ForeColor = System.Drawing.Color.Aqua;
            this.addViewButton.Image = global::AMBEmpleados.Properties.Resources.adduser_añadir_3553;
            this.addViewButton.Location = new System.Drawing.Point(217, 0);
            this.addViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.addViewButton.Name = "addViewButton";
            this.addViewButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addViewButton.Size = new System.Drawing.Size(136, 120);
            this.addViewButton.TabIndex = 3;
            this.addViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addViewButton.UseCompatibleTextRendering = true;
            this.addViewButton.UseVisualStyleBackColor = false;
            this.addViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifyViewButton
            // 
            this.modifyViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modifyViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.modifyViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyViewButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyViewButton.ForeColor = System.Drawing.Color.Aqua;
            this.modifyViewButton.Image = global::AMBEmpleados.Properties.Resources.edit_icon_icons_com_66118;
            this.modifyViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyViewButton.Location = new System.Drawing.Point(400, -2);
            this.modifyViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.modifyViewButton.Name = "modifyViewButton";
            this.modifyViewButton.Size = new System.Drawing.Size(136, 123);
            this.modifyViewButton.TabIndex = 2;
            this.modifyViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modifyViewButton.UseCompatibleTextRendering = true;
            this.modifyViewButton.UseVisualStyleBackColor = false;
            this.modifyViewButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // listViewButton
            // 
            this.listViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listViewButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewButton.ForeColor = System.Drawing.Color.Aqua;
            this.listViewButton.Image = global::AMBEmpleados.Properties.Resources.to_do_list_icon_icons_com_76974;
            this.listViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listViewButton.Location = new System.Drawing.Point(580, 1);
            this.listViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.listViewButton.Name = "listViewButton";
            this.listViewButton.Size = new System.Drawing.Size(114, 119);
            this.listViewButton.TabIndex = 1;
            this.listViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.listViewButton.UseCompatibleTextRendering = true;
            this.listViewButton.UseVisualStyleBackColor = false;
            this.listViewButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // homeViewButton
            // 
            this.homeViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homeViewButton.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeViewButton.ForeColor = System.Drawing.Color.Aqua;
            this.homeViewButton.Image = global::AMBEmpleados.Properties.Resources.home_silhouette_on_black_square_background_icon_icons_com_70471;
            this.homeViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeViewButton.Location = new System.Drawing.Point(30, -1);
            this.homeViewButton.Margin = new System.Windows.Forms.Padding(0);
            this.homeViewButton.Name = "homeViewButton";
            this.homeViewButton.Size = new System.Drawing.Size(138, 122);
            this.homeViewButton.TabIndex = 0;
            this.homeViewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeViewButton.UseCompatibleTextRendering = true;
            this.homeViewButton.UseVisualStyleBackColor = false;
            this.homeViewButton.Click += new System.EventHandler(this.homeButton_Click);
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
        private System.Windows.Forms.Button listViewButton;
        private System.Windows.Forms.Button homeViewButton;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Button addViewButton;
        private System.Windows.Forms.Button modifyViewButton;
    }
}

