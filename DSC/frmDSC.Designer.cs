
namespace DSC
{
    partial class frmDSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSC));
            this.panelDSC = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolderLoc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectDSC = new System.Windows.Forms.Label();
            this.btnSelectDSC = new System.Windows.Forms.Button();
            this.cmbDSC = new System.Windows.Forms.ComboBox();
            this.dlgFld = new System.Windows.Forms.FolderBrowserDialog();
            this.panelDSC.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDSC
            // 
            this.panelDSC.Controls.Add(this.toolStrip1);
            this.panelDSC.Controls.Add(this.groupBox4);
            this.panelDSC.Controls.Add(this.groupBox3);
            this.panelDSC.Controls.Add(this.groupBox2);
            this.panelDSC.Controls.Add(this.groupBox1);
            this.panelDSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDSC.Location = new System.Drawing.Point(0, 0);
            this.panelDSC.Name = "panelDSC";
            this.panelDSC.Size = new System.Drawing.Size(737, 469);
            this.panelDSC.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 442);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDisplay);
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnSign);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(737, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(7, 22);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(661, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(560, 13);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(73, 31);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "&Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstFiles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files ";
            // 
            // lstFiles
            // 
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.ForeColor = System.Drawing.Color.Black;
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.GridLines = true;
            this.lstFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(3, 16);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(731, 201);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Number";
            this.columnHeader1.Width = 726;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSelectFolder);
            this.groupBox2.Controls.Add(this.txtFolderLoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Folder ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder Location : ";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(505, 39);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(61, 21);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolderLoc
            // 
            this.txtFolderLoc.Enabled = false;
            this.txtFolderLoc.Location = new System.Drawing.Point(163, 39);
            this.txtFolderLoc.Name = "txtFolderLoc";
            this.txtFolderLoc.Size = new System.Drawing.Size(322, 20);
            this.txtFolderLoc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectDSC);
            this.groupBox1.Controls.Add(this.btnSelectDSC);
            this.groupBox1.Controls.Add(this.cmbDSC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select DSC : ";
            // 
            // lblSelectDSC
            // 
            this.lblSelectDSC.AutoSize = true;
            this.lblSelectDSC.Location = new System.Drawing.Point(115, 31);
            this.lblSelectDSC.Name = "lblSelectDSC";
            this.lblSelectDSC.Size = new System.Drawing.Size(110, 13);
            this.lblSelectDSC.TabIndex = 0;
            this.lblSelectDSC.Text = "Chosse Proper DSC : ";
            // 
            // btnSelectDSC
            // 
            this.btnSelectDSC.Location = new System.Drawing.Point(505, 28);
            this.btnSelectDSC.Name = "btnSelectDSC";
            this.btnSelectDSC.Size = new System.Drawing.Size(61, 21);
            this.btnSelectDSC.TabIndex = 1;
            this.btnSelectDSC.Text = "...";
            this.btnSelectDSC.UseVisualStyleBackColor = true;
            this.btnSelectDSC.Click += new System.EventHandler(this.btnSelectDSC_Click);
            // 
            // cmbDSC
            // 
            this.cmbDSC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDSC.FormattingEnabled = true;
            this.cmbDSC.Location = new System.Drawing.Point(233, 28);
            this.cmbDSC.Name = "cmbDSC";
            this.cmbDSC.Size = new System.Drawing.Size(247, 21);
            this.cmbDSC.TabIndex = 0;
            this.cmbDSC.Leave += new System.EventHandler(this.cmbDSC_Leave);
            // 
            // frmDSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 469);
            this.Controls.Add(this.panelDSC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Batch DSC";
            this.Load += new System.EventHandler(this.frmDSC_Load);
            this.panelDSC.ResumeLayout(false);
            this.panelDSC.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDSC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cmbDSC;
        private System.Windows.Forms.Button btnSelectDSC;
        private System.Windows.Forms.Label lblSelectDSC;
        private System.Windows.Forms.FolderBrowserDialog dlgFld;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderLoc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

