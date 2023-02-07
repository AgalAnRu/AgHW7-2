namespace AgHW7_2
{
    partial class FormTables
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
            this.panelTables = new System.Windows.Forms.Panel();
            this.buttonAddNewTable = new System.Windows.Forms.Button();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.groupBoxScale = new System.Windows.Forms.GroupBox();
            this.radioButtonScale2 = new System.Windows.Forms.RadioButton();
            this.radioButtonScale1 = new System.Windows.Forms.RadioButton();
            this.radioButtonScale05 = new System.Windows.Forms.RadioButton();
            this.checkBoxAxis = new System.Windows.Forms.CheckBox();
            this.comboBoxTablesName = new System.Windows.Forms.ComboBox();
            this.buttonDeleteSelectedTable = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.groupBoxScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTables
            // 
            this.panelTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTables.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTables.Location = new System.Drawing.Point(100, 122);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(800, 400);
            this.panelTables.TabIndex = 0;
            this.panelTables.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTables_Paint);
            this.panelTables.Resize += new System.EventHandler(this.panelTables_Resize);
            // 
            // buttonAddNewTable
            // 
            this.buttonAddNewTable.Location = new System.Drawing.Point(100, 12);
            this.buttonAddNewTable.Name = "buttonAddNewTable";
            this.buttonAddNewTable.Size = new System.Drawing.Size(64, 51);
            this.buttonAddNewTable.TabIndex = 1;
            this.buttonAddNewTable.Text = "Add  new Table";
            this.buttonAddNewTable.UseVisualStyleBackColor = true;
            this.buttonAddNewTable.Click += new System.EventHandler(this.buttonAddNewTable_Click);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Checked = true;
            this.checkBoxGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrid.Location = new System.Drawing.Point(13, 122);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(51, 17);
            this.checkBoxGrid.TabIndex = 2;
            this.checkBoxGrid.Text = "Gride";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.Controls.Add(this.radioButtonScale2);
            this.groupBoxScale.Controls.Add(this.radioButtonScale1);
            this.groupBoxScale.Controls.Add(this.radioButtonScale05);
            this.groupBoxScale.Location = new System.Drawing.Point(1, 191);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(80, 96);
            this.groupBoxScale.TabIndex = 3;
            this.groupBoxScale.TabStop = false;
            this.groupBoxScale.Text = "Scale";
            // 
            // radioButtonScale2
            // 
            this.radioButtonScale2.AutoSize = true;
            this.radioButtonScale2.Location = new System.Drawing.Point(6, 66);
            this.radioButtonScale2.Name = "radioButtonScale2";
            this.radioButtonScale2.Size = new System.Drawing.Size(48, 17);
            this.radioButtonScale2.TabIndex = 0;
            this.radioButtonScale2.Text = "x 2.0";
            this.radioButtonScale2.UseVisualStyleBackColor = true;
            this.radioButtonScale2.CheckedChanged += new System.EventHandler(this.radioButtonScale_CheckedChanged);
            // 
            // radioButtonScale1
            // 
            this.radioButtonScale1.AutoSize = true;
            this.radioButtonScale1.Checked = true;
            this.radioButtonScale1.Location = new System.Drawing.Point(6, 43);
            this.radioButtonScale1.Name = "radioButtonScale1";
            this.radioButtonScale1.Size = new System.Drawing.Size(48, 17);
            this.radioButtonScale1.TabIndex = 0;
            this.radioButtonScale1.TabStop = true;
            this.radioButtonScale1.Text = "x 1.0";
            this.radioButtonScale1.UseVisualStyleBackColor = true;
            this.radioButtonScale1.CheckedChanged += new System.EventHandler(this.radioButtonScale_CheckedChanged);
            // 
            // radioButtonScale05
            // 
            this.radioButtonScale05.AutoSize = true;
            this.radioButtonScale05.Location = new System.Drawing.Point(7, 20);
            this.radioButtonScale05.Name = "radioButtonScale05";
            this.radioButtonScale05.Size = new System.Drawing.Size(48, 17);
            this.radioButtonScale05.TabIndex = 0;
            this.radioButtonScale05.Text = "x 0.5";
            this.radioButtonScale05.UseVisualStyleBackColor = true;
            this.radioButtonScale05.CheckedChanged += new System.EventHandler(this.radioButtonScale_CheckedChanged);
            // 
            // checkBoxAxis
            // 
            this.checkBoxAxis.AutoSize = true;
            this.checkBoxAxis.Checked = true;
            this.checkBoxAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAxis.Location = new System.Drawing.Point(12, 145);
            this.checkBoxAxis.Name = "checkBoxAxis";
            this.checkBoxAxis.Size = new System.Drawing.Size(45, 17);
            this.checkBoxAxis.TabIndex = 2;
            this.checkBoxAxis.Text = "Axis";
            this.checkBoxAxis.UseVisualStyleBackColor = true;
            this.checkBoxAxis.CheckedChanged += new System.EventHandler(this.checkBoxAxis_CheckedChanged);
            // 
            // comboBoxTablesName
            // 
            this.comboBoxTablesName.FormattingEnabled = true;
            this.comboBoxTablesName.Location = new System.Drawing.Point(210, 12);
            this.comboBoxTablesName.Name = "comboBoxTablesName";
            this.comboBoxTablesName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTablesName.TabIndex = 5;
            this.comboBoxTablesName.Text = "Empty";
            this.comboBoxTablesName.Visible = false;
            this.comboBoxTablesName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTablesName_SelectedIndexChanged);
            // 
            // buttonDeleteSelectedTable
            // 
            this.buttonDeleteSelectedTable.Location = new System.Drawing.Point(401, 12);
            this.buttonDeleteSelectedTable.Name = "buttonDeleteSelectedTable";
            this.buttonDeleteSelectedTable.Size = new System.Drawing.Size(92, 51);
            this.buttonDeleteSelectedTable.TabIndex = 6;
            this.buttonDeleteSelectedTable.Text = "Delete Selected Table";
            this.buttonDeleteSelectedTable.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedTable.Visible = false;
            this.buttonDeleteSelectedTable.Click += new System.EventHandler(this.buttonDeleteSelectedTable_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.Location = new System.Drawing.Point(523, 26);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateLeft.TabIndex = 7;
            this.buttonRotateLeft.Text = "RotateLeft";
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Visible = false;
            this.buttonRotateLeft.Click += new System.EventHandler(this.buttonRotateLeft_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.Location = new System.Drawing.Point(523, 55);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateRight.TabIndex = 7;
            this.buttonRotateRight.Text = "RotateRight";
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Visible = false;
            this.buttonRotateRight.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 530);
            this.Controls.Add(this.buttonRotateRight);
            this.Controls.Add(this.buttonRotateLeft);
            this.Controls.Add(this.buttonDeleteSelectedTable);
            this.Controls.Add(this.comboBoxTablesName);
            this.Controls.Add(this.groupBoxScale);
            this.Controls.Add(this.checkBoxAxis);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.buttonAddNewTable);
            this.Controls.Add(this.panelTables);
            this.Name = "FormTables";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormTables";
            this.groupBoxScale.ResumeLayout(false);
            this.groupBoxScale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.Button buttonAddNewTable;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.GroupBox groupBoxScale;
        private System.Windows.Forms.RadioButton radioButtonScale2;
        private System.Windows.Forms.RadioButton radioButtonScale1;
        private System.Windows.Forms.RadioButton radioButtonScale05;
        private System.Windows.Forms.CheckBox checkBoxAxis;
        private System.Windows.Forms.ComboBox comboBoxTablesName;
        private System.Windows.Forms.Button buttonDeleteSelectedTable;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonRotateRight;
    }
}