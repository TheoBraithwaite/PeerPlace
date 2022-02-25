namespace WindowsFormsPeerPlace
{
    partial class Main
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
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeGrid
            // 
            this.employeeGrid.AllowUserToAddRows = false;
            this.employeeGrid.AllowUserToDeleteRows = false;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Location = new System.Drawing.Point(12, 89);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.ReadOnly = true;
            this.employeeGrid.RowTemplate.Height = 25;
            this.employeeGrid.Size = new System.Drawing.Size(905, 447);
            this.employeeGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "PeerPlace";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(564, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(817, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(648, 32);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(775, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "for";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResults.Location = new System.Drawing.Point(648, 65);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(89, 15);
            this.labelResults.TabIndex = 8;
            this.labelResults.Text = "Results found: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(929, 571);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PeerPlace - Management Console";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView employeeGrid;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private Label label2;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSearch;
        private Label label3;
        private Button buttonSearch;
        private Label label4;
        private Label labelResults;
    }
}