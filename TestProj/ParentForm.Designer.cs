namespace TestProj
{
    partial class ParentForm
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
            btn_Autheors = new Button();
            btn_Books = new Button();
            btn_Borrowers = new Button();
            btn_BookBorow = new Button();
            SuspendLayout();
            // 
            // btn_Autheors
            // 
            btn_Autheors.Location = new Point(12, 23);
            btn_Autheors.Name = "btn_Autheors";
            btn_Autheors.Size = new Size(124, 54);
            btn_Autheors.TabIndex = 0;
            btn_Autheors.Text = "Authors";
            btn_Autheors.UseVisualStyleBackColor = true;
            btn_Autheors.Click += btn_Autheors_Click;
            // 
            // btn_Books
            // 
            btn_Books.Location = new Point(163, 23);
            btn_Books.Name = "btn_Books";
            btn_Books.Size = new Size(125, 54);
            btn_Books.TabIndex = 1;
            btn_Books.Text = "Books";
            btn_Books.UseVisualStyleBackColor = true;
            btn_Books.Click += btn_Books_Click;
            // 
            // btn_Borrowers
            // 
            btn_Borrowers.Location = new Point(309, 23);
            btn_Borrowers.Name = "btn_Borrowers";
            btn_Borrowers.Size = new Size(117, 54);
            btn_Borrowers.TabIndex = 2;
            btn_Borrowers.Text = "Borrowers";
            btn_Borrowers.UseVisualStyleBackColor = true;
            btn_Borrowers.Click += btn_Borrowers_Click;
            // 
            // btn_BookBorow
            // 
            btn_BookBorow.Location = new Point(461, 23);
            btn_BookBorow.Name = "btn_BookBorow";
            btn_BookBorow.Size = new Size(127, 54);
            btn_BookBorow.TabIndex = 3;
            btn_BookBorow.Text = "Book Borrowing";
            btn_BookBorow.UseVisualStyleBackColor = true;
            btn_BookBorow.Click += btn_BookBorow_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 135);
            Controls.Add(btn_BookBorow);
            Controls.Add(btn_Borrowers);
            Controls.Add(btn_Books);
            Controls.Add(btn_Autheors);
            Name = "ParentForm";
            Text = "ParentForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Autheors;
        private Button btn_Books;
        private Button btn_Borrowers;
        private Button btn_BookBorow;
    }
}