
namespace ContactsViewer
{
    partial class frmViewer
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnOpenCSVFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvContactView = new System.Windows.Forms.DataGridView();
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.btnId = new System.Windows.Forms.Button();
            this.gbxViewer = new System.Windows.Forms.GroupBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactView)).BeginInit();
            this.gbxViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(33, 34);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(887, 22);
            this.txtFile.TabIndex = 0;
            // 
            // btnOpenCSVFile
            // 
            this.btnOpenCSVFile.Location = new System.Drawing.Point(978, 29);
            this.btnOpenCSVFile.Name = "btnOpenCSVFile";
            this.btnOpenCSVFile.Size = new System.Drawing.Size(131, 46);
            this.btnOpenCSVFile.TabIndex = 1;
            this.btnOpenCSVFile.Text = "Open CSV File";
            this.btnOpenCSVFile.UseVisualStyleBackColor = true;
            this.btnOpenCSVFile.Click += new System.EventHandler(this.btnOpenCSVFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvContactView
            // 
            this.dgvContactView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactView.Location = new System.Drawing.Point(26, 176);
            this.dgvContactView.Name = "dgvContactView";
            this.dgvContactView.RowHeadersWidth = 51;
            this.dgvContactView.RowTemplate.Height = 24;
            this.dgvContactView.Size = new System.Drawing.Size(970, 374);
            this.dgvContactView.TabIndex = 2;
            // 
            // txtSearchField
            // 
            this.txtSearchField.Location = new System.Drawing.Point(300, 43);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(303, 22);
            this.txtSearchField.TabIndex = 3;
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(698, 42);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(136, 23);
            this.btnId.TabIndex = 4;
            this.btnId.Text = "Search";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // gbxViewer
            // 
            this.gbxViewer.Controls.Add(this.cboType);
            this.gbxViewer.Controls.Add(this.dgvContactView);
            this.gbxViewer.Controls.Add(this.btnId);
            this.gbxViewer.Controls.Add(this.txtSearchField);
            this.gbxViewer.Location = new System.Drawing.Point(33, 114);
            this.gbxViewer.Name = "gbxViewer";
            this.gbxViewer.Size = new System.Drawing.Size(1031, 600);
            this.gbxViewer.TabIndex = 6;
            this.gbxViewer.TabStop = false;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(89, 41);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(135, 24);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1193, 856);
            this.Controls.Add(this.btnOpenCSVFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.gbxViewer);
            this.Name = "frmViewer";
            this.Text = "Contact Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactView)).EndInit();
            this.gbxViewer.ResumeLayout(false);
            this.gbxViewer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnOpenCSVFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvContactView;
        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.GroupBox gbxViewer;
        private System.Windows.Forms.ComboBox cboType;
    }
}