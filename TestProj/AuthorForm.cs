using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProj.Models;

namespace TestProj
{
    public partial class AuthorForm : Form
    {
        CommonClass cc;
        private List<AuthorModel> _authorList;

        public AuthorForm()
        {
            InitializeComponent();

            cc = new CommonClass();

            _authorList = cc.GetAuther();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = _authorList;

            dataGridView.Columns["Author_Id"].Visible = false;

            dataGridView.Columns["Birthdate"].HeaderText = "Birth Date";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AuthorModel blankAuthor = new AuthorModel
            {
                Author_Id = 0,  // Set default ID
                Name = string.Empty,  // Empty name
                Birthdate = string.Empty,  // Empty birthdate
                Nationality = string.Empty  // Empty nationality
            };

            _authorList.Add(blankAuthor);  // Add to the list

            // Refresh the DataGridView
            RefreshDataGridView();

            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<AuthorModel> authors = new List<AuthorModel>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Check if the row is not a new row
                if (!row.IsNewRow)
                {
                    // Safely handle possible null values in the cells
                    var authorIdValue = row.Cells["author_id"].Value;
                    var nameValue = row.Cells["Name"].Value;
                    var birthdateValue = row.Cells["BirthDate"].Value;
                    var nationalityValue = row.Cells["Nationality"].Value;

                    AuthorModel author = new AuthorModel
                    {
                        Author_Id = authorIdValue != null && int.TryParse(authorIdValue.ToString(), out int authorId) ? authorId : 0,
                        Name = nameValue?.ToString() ?? string.Empty,
                        Birthdate = birthdateValue?.ToString() ?? string.Empty,
                        Nationality = nationalityValue?.ToString() ?? string.Empty
                    };

                    authors.Add(author);
                }
            }
            _authorList = cc.InsertAuthor(authors);
            RefreshDataGridView();
        }
        private void RefreshDataGridView()
        {
            // Refresh the data grid by resetting the DataSource
            dataGridView.DataSource = null;
            dataGridView.DataSource = _authorList;

            dataGridView.Columns["Author_Id"].Visible = false;

            dataGridView.Columns["Birthdate"].HeaderText = "Birth Date";
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row and column indices are valid and the row is not new or invalid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView.Rows[e.RowIndex].IsNewRow)
            {
                // Get the edited row and safely update the _authorList
                var row = dataGridView.Rows[e.RowIndex];

                if (row.Cells["Name"].Value != null && row.Cells["BirthDate"].Value != null && row.Cells["Nationality"].Value != null)
                {
                    // Update the _authorList with new values
                    _authorList[e.RowIndex].Name = row.Cells["Name"].Value.ToString();
                    _authorList[e.RowIndex].Birthdate = row.Cells["BirthDate"].Value.ToString();
                    _authorList[e.RowIndex].Nationality = row.Cells["Nationality"].Value.ToString();
                }
            }
        }
    }
}
