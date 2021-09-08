using System;

using System.Data;

using System.Windows.Forms;

namespace ContactsViewer
{
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
            dgvContactView.AllowUserToAddRows = false;
            dgvContactView.AllowUserToDeleteRows = false;
            dgvContactView.AllowUserToOrderColumns = true;
            dgvContactView.ReadOnly = true;
            dgvContactView.Visible = false;
            dgvContactView.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            initcboType();
            dgvContactView.MultiSelect = false;
            gbxViewer.Visible = false;

        }

        private void initcboType()
        {
            cboType.Items.Add("");
            cboType.Items.Add("Id");
            cboType.Items.Add("Name");
            cboType.Items.Add("Address");
            cboType.Items.Add("City");
            cboType.Items.Add("State");
            cboType.Items.Add("ZIP");

            cboType.EndUpdate();
            cboType.SelectedIndex = 0;
            
        }
        private void btnOpenCSVFile_Click(object sender, EventArgs e)
        {
                openFileDialog1.Filter = "CSV files(*.csv)|*.csv";
                openFileDialog1.Title = "Browse CSV File";
                 openFileDialog1.FileName = "";
                 openFileDialog1.DefaultExt = ".csv";
            try
            {
                openFileDialog1.ShowDialog();

                txtFile.Text = openFileDialog1.FileName;
            }
            catch  (Exception ex)
            
            {
                MessageBox.Show("Error:" +ex.Message);
            
            }
           
                dgvContactView.DataSource= BindData(txtFile.Text);
           
        }
        private   DataTable BindData(string filePath) {
            Boolean flgError = false;
            DataTable dt = new DataTable();
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
            
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
             
                
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }

                    dt.Rows.Add(dr);
                    
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flgError = true;
            }
            if (flgError)
            {
                dgvContactView.Visible = false;
                gbxViewer.Visible = false;
            }
            else
            {
                dgvContactView.Visible = true;
                gbxViewer.Visible = true;
            }
            return dt;
           
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            string strSearch = txtSearchField.Text.Trim();
            switch (cboType.SelectedIndex)
            {
                case 0:
                    filter("", "");
                    break;
                case 1:
                filter(strSearch, "Id");
                break;
                case 2:
                    filter(strSearch, "Name");
                    break;
                case 3:
                    filter(strSearch, "Address");
                    break;
                case 4:
                    filter(strSearch, "City");
                    break;
                case 5:
                    filter(strSearch, "State");
                    break;
                case 6:
                    filter(strSearch, "ZIP");
                    break;

            }

        }
        private void filter(string  txtSearch,string txtType)
        {
            DataTable dt = new DataTable();
            dt= BindData(txtFile.Text);
            if (dt.Rows.Count > 0)
            {
                DataView dv = dt.DefaultView;
                if(txtType!="")
                dv.RowFilter = string.Format( txtType + " like '%{0}%'", txtSearch);
                dgvContactView.DataSource = dv.ToTable();
            }
                
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
                txtSearchField.Text = "";
        }
        private void cboType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }
        private void cboType_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            return;
        }
    }
}
