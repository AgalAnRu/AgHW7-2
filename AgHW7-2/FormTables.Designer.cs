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
            this.buttonDeleteSelectedTable = new System.Windows.Forms.Button();
            this.buttonRotateLeft = new System.Windows.Forms.Button();
            this.buttonRotateRight = new System.Windows.Forms.Button();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.groupBoxScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTables
            // 
            this.panelTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTables.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTables.Location = new System.Drawing.Point(214, 58);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(558, 491);
            this.panelTables.TabIndex = 0;
            this.panelTables.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTables_Paint);
            this.panelTables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelTables_MouseClick);
            this.panelTables.Resize += new System.EventHandler(this.PanelTables_Resize);
            // 
            // buttonAddNewTable
            // 
            this.buttonAddNewTable.Location = new System.Drawing.Point(12, 58);
            this.buttonAddNewTable.Name = "buttonAddNewTable";
            this.buttonAddNewTable.Size = new System.Drawing.Size(92, 59);
            this.buttonAddNewTable.TabIndex = 1;
            this.buttonAddNewTable.Text = "Add  new Table";
            this.buttonAddNewTable.UseVisualStyleBackColor = true;
            this.buttonAddNewTable.Click += new System.EventHandler(this.ButtonAddNewTable_Click);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Checked = true;
            this.checkBoxGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrid.Location = new System.Drawing.Point(228, 12);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(51, 17);
            this.checkBoxGrid.TabIndex = 2;
            this.checkBoxGrid.Text = "Gride";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.CheckBoxGrid_CheckedChanged);
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.Controls.Add(this.radioButtonScale2);
            this.groupBoxScale.Controls.Add(this.radioButtonScale1);
            this.groupBoxScale.Controls.Add(this.radioButtonScale05);
            this.groupBoxScale.Location = new System.Drawing.Point(313, 3);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(264, 49);
            this.groupBoxScale.TabIndex = 3;
            this.groupBoxScale.TabStop = false;
            this.groupBoxScale.Text = "Scale";
            // 
            // radioButtonScale2
            // 
            this.radioButtonScale2.AutoSize = true;
            this.radioButtonScale2.Location = new System.Drawing.Point(166, 20);
            this.radioButtonScale2.Name = "radioButtonScale2";
            this.radioButtonScale2.Size = new System.Drawing.Size(48, 17);
            this.radioButtonScale2.TabIndex = 0;
            this.radioButtonScale2.Text = "x 2.0";
            this.radioButtonScale2.UseVisualStyleBackColor = true;
            this.radioButtonScale2.CheckedChanged += new System.EventHandler(this.RadioButtonScale_CheckedChanged);
            // 
            // radioButtonScale1
            // 
            this.radioButtonScale1.AutoSize = true;
            this.radioButtonScale1.Checked = true;
            this.radioButtonScale1.Location = new System.Drawing.Point(84, 19);
            this.radioButtonScale1.Name = "radioButtonScale1";
            this.radioButtonScale1.Size = new System.Drawing.Size(48, 17);
            this.radioButtonScale1.TabIndex = 0;
            this.radioButtonScale1.TabStop = true;
            this.radioButtonScale1.Text = "x 1.0";
            this.radioButtonScale1.UseVisualStyleBackColor = true;
            this.radioButtonScale1.CheckedChanged += new System.EventHandler(this.RadioButtonScale_CheckedChanged);
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
            this.radioButtonScale05.CheckedChanged += new System.EventHandler(this.RadioButtonScale_CheckedChanged);
            // 
            // checkBoxAxis
            // 
            this.checkBoxAxis.AutoSize = true;
            this.checkBoxAxis.Checked = true;
            this.checkBoxAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAxis.Location = new System.Drawing.Point(227, 35);
            this.checkBoxAxis.Name = "checkBoxAxis";
            this.checkBoxAxis.Size = new System.Drawing.Size(45, 17);
            this.checkBoxAxis.TabIndex = 2;
            this.checkBoxAxis.Text = "Axis";
            this.checkBoxAxis.UseVisualStyleBackColor = true;
            this.checkBoxAxis.CheckedChanged += new System.EventHandler(this.CheckBoxAxis_CheckedChanged);
            // 
            // buttonDeleteSelectedTable
            // 
            this.buttonDeleteSelectedTable.Enabled = false;
            this.buttonDeleteSelectedTable.Location = new System.Drawing.Point(12, 133);
            this.buttonDeleteSelectedTable.Name = "buttonDeleteSelectedTable";
            this.buttonDeleteSelectedTable.Size = new System.Drawing.Size(92, 59);
            this.buttonDeleteSelectedTable.TabIndex = 6;
            this.buttonDeleteSelectedTable.Text = "Delete Selected";
            this.buttonDeleteSelectedTable.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedTable.Visible = false;
            this.buttonDeleteSelectedTable.Click += new System.EventHandler(this.ButtonDeleteSelectedTable_Click);
            // 
            // buttonRotateLeft
            // 
            this.buttonRotateLeft.Enabled = false;
            this.buttonRotateLeft.Location = new System.Drawing.Point(13, 240);
            this.buttonRotateLeft.Name = "buttonRotateLeft";
            this.buttonRotateLeft.Size = new System.Drawing.Size(91, 51);
            this.buttonRotateLeft.TabIndex = 7;
            this.buttonRotateLeft.Text = "Rotate Selected Left";
            this.buttonRotateLeft.UseVisualStyleBackColor = true;
            this.buttonRotateLeft.Visible = false;
            this.buttonRotateLeft.Click += new System.EventHandler(this.ButtonRotateLeft_Click);
            // 
            // buttonRotateRight
            // 
            this.buttonRotateRight.Enabled = false;
            this.buttonRotateRight.Location = new System.Drawing.Point(110, 240);
            this.buttonRotateRight.Name = "buttonRotateRight";
            this.buttonRotateRight.Size = new System.Drawing.Size(91, 51);
            this.buttonRotateRight.TabIndex = 7;
            this.buttonRotateRight.Text = "Rotate Selected Right";
            this.buttonRotateRight.UseVisualStyleBackColor = true;
            this.buttonRotateRight.Visible = false;
            this.buttonRotateRight.Click += new System.EventHandler(this.ButtonRotateRight_Click);
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.Location = new System.Drawing.Point(110, 58);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTables.Size = new System.Drawing.Size(91, 134);
            this.listBoxTables.TabIndex = 8;
            this.listBoxTables.Visible = false;
            this.listBoxTables.SelectedIndexChanged += new System.EventHandler(this.ListBoxTables_SelectedIndexChanged);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(110, 199);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(91, 23);
            this.buttonSelectAll.TabIndex = 9;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Visible = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.listBoxTables);
            this.Controls.Add(this.buttonRotateRight);
            this.Controls.Add(this.buttonRotateLeft);
            this.Controls.Add(this.buttonDeleteSelectedTable);
            this.Controls.Add(this.groupBoxScale);
            this.Controls.Add(this.checkBoxAxis);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.buttonAddNewTable);
            this.Controls.Add(this.panelTables);
            this.MinimumSize = new System.Drawing.Size(600, 350);
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
        private System.Windows.Forms.Button buttonDeleteSelectedTable;
        private System.Windows.Forms.Button buttonRotateLeft;
        private System.Windows.Forms.Button buttonRotateRight;
        private System.Windows.Forms.ListBox listBoxTables;
        private System.Windows.Forms.Button buttonSelectAll;
    }
}