namespace IconDBD
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.resetIconsToDefaultButton = new System.Windows.Forms.Button();
            this.installSelectedIconPackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectedIconPackLabel = new System.Windows.Forms.Label();
            this.selectIconPackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(584, 520);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.resetIconsToDefaultButton);
            this.tabPage1.Controls.Add(this.installSelectedIconPackButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Icon Pack Installer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(545, 97);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // resetIconsToDefaultButton
            // 
            this.resetIconsToDefaultButton.Location = new System.Drawing.Point(20, 308);
            this.resetIconsToDefaultButton.Name = "resetIconsToDefaultButton";
            this.resetIconsToDefaultButton.Size = new System.Drawing.Size(541, 37);
            this.resetIconsToDefaultButton.TabIndex = 4;
            this.resetIconsToDefaultButton.Text = "Reset Icons to Default";
            this.resetIconsToDefaultButton.UseVisualStyleBackColor = true;
            this.resetIconsToDefaultButton.Click += new System.EventHandler(this.resetIconsToDefaultButton_Click);
            // 
            // installSelectedIconPackButton
            // 
            this.installSelectedIconPackButton.Location = new System.Drawing.Point(20, 255);
            this.installSelectedIconPackButton.Name = "installSelectedIconPackButton";
            this.installSelectedIconPackButton.Size = new System.Drawing.Size(541, 37);
            this.installSelectedIconPackButton.TabIndex = 3;
            this.installSelectedIconPackButton.Text = "Install Selected Icon Pack";
            this.installSelectedIconPackButton.UseVisualStyleBackColor = true;
            this.installSelectedIconPackButton.Click += new System.EventHandler(this.installSelectedIconPackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selectedIconPackLabel);
            this.groupBox1.Controls.Add(this.selectIconPackButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon Pack Selection";
            // 
            // selectedIconPackLabel
            // 
            this.selectedIconPackLabel.AutoEllipsis = true;
            this.selectedIconPackLabel.Location = new System.Drawing.Point(44, 149);
            this.selectedIconPackLabel.Name = "selectedIconPackLabel";
            this.selectedIconPackLabel.Size = new System.Drawing.Size(453, 21);
            this.selectedIconPackLabel.TabIndex = 2;
            this.selectedIconPackLabel.Text = "Selected icon pack: None";
            // 
            // selectIconPackButton
            // 
            this.selectIconPackButton.Location = new System.Drawing.Point(48, 91);
            this.selectIconPackButton.Name = "selectIconPackButton";
            this.selectIconPackButton.Size = new System.Drawing.Size(449, 37);
            this.selectIconPackButton.TabIndex = 1;
            this.selectIconPackButton.Text = "Select Icon Pack";
            this.selectIconPackButton.UseVisualStyleBackColor = true;
            this.selectIconPackButton.Click += new System.EventHandler(this.selectIconPackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "First, select the icon pack you wish to install. It must be a .zip file.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 520);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IconDBD";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectIconPackButton;
        private System.Windows.Forms.Label selectedIconPackLabel;
        private System.Windows.Forms.Button installSelectedIconPackButton;
        private System.Windows.Forms.Button resetIconsToDefaultButton;
        private System.Windows.Forms.Label label3;
    }
}

