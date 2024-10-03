using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProj
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void btn_Autheors_Click(object sender, EventArgs e)
        {
            var obj = new AuthorForm();
            //obj.Parent = this;
            obj.Show();

        }

        private void btn_Books_Click(object sender, EventArgs e)
        {
            var obj = new BooksForm();
            //obj.Parent = this;
            obj.Show();
        }

        private void btn_Borrowers_Click(object sender, EventArgs e)
        {
            var obj = new BorrowerForm();
            //obj.Parent = this;
            obj.Show();
        }

        private void btn_BookBorow_Click(object sender, EventArgs e)
        {
            var obj = new BookBorrowingForm();
            //obj.Parent = this;
            obj.Show();
        }
    }
}
