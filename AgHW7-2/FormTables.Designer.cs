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
            this.SuspendLayout();
            // 
            // panelTables
            // 
            this.panelTables.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTables.Location = new System.Drawing.Point(100, 122);
            this.panelTables.Name = "panelTables";
            this.panelTables.Size = new System.Drawing.Size(800, 400);
            this.panelTables.TabIndex = 0;
            this.panelTables.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTables_Paint);
            // 
            // buttonAddNewTable
            // 
            this.buttonAddNewTable.Location = new System.Drawing.Point(100, 12);
            this.buttonAddNewTable.Name = "buttonAddNewTable";
            this.buttonAddNewTable.Size = new System.Drawing.Size(102, 30);
            this.buttonAddNewTable.TabIndex = 1;
            this.buttonAddNewTable.Text = "Add  new Table";
            this.buttonAddNewTable.UseVisualStyleBackColor = true;
            this.buttonAddNewTable.Click += new System.EventHandler(this.buttonAddNewTable_Click);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Location = new System.Drawing.Point(13, 122);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(56, 17);
            this.checkBoxGrid.TabIndex = 2;
            this.checkBoxGrid.Text = "Сетка";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.buttonAddNewTable);
            this.Controls.Add(this.panelTables);
            this.Name = "FormTables";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormTables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTables;
        private System.Windows.Forms.Button buttonAddNewTable;
        private System.Windows.Forms.CheckBox checkBoxGrid;
    }
}