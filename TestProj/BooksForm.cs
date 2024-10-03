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
    public partial class BooksForm : Form
    {
        CommonClass cc;
        private List<BooksModel> _bookList;
        private string _id;
        public BooksForm()
        {
            InitializeComponent();

            cc = new CommonClass();

            _bookList = cc.GetBooks();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = _bookList;

            dataGridView.Columns["Book_Id"].Visible = false;
            dataGridView.Columns["AuthorId"].Visible = false;
            dataGridView.Columns["Name"].HeaderText = "Author";

            //dataGridView.Columns["Name"].Visible = false;

            var authorList = cc.GetAuther();

            cmbo_Author.DataSource = authorList;
            cmbo_Author.DisplayMember = "Name";
            cmbo_Author.ValueMember = "Author_Id";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            BooksModel model = new BooksModel
            {
                Book_Id=int.Parse(_id??"0"),
                Title=txt_BookName.Text,
                AuthorId=int.Parse(cmbo_Author.SelectedValue.ToString()),
                Genre=txt_Genra.Text,
                Published_Year=int.Parse(txt_BublishedYr.Text.Trim()),
            };
            _bookList.Add(model);
            _bookList= cc.InsertBooks(_bookList);

            dataGridView.DataSource= _bookList;
        }
    }
}
