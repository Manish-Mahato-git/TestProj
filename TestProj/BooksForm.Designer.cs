namespace TestProj
{
    partial class BooksForm
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
            btn_Save = new Button();
            dataGridView = new DataGridView();
            txt_BookName = new TextBox();
            cmbo_Author = new ComboBox();
            txt_BublishedYr = new TextBox();
            txt_Genra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(572, 20);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 33);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(15, 61);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(553, 334);
            dataGridView.TabIndex = 4;
            // 
            // txt_BookName
            // 
            txt_BookName.Location = new Point(15, 29);
            txt_BookName.Name = "txt_BookName";
            txt_BookName.Size = new Size(179, 27);
            txt_BookName.TabIndex = 6;
            // 
            // cmbo_Author
            // 
            cmbo_Author.FormattingEnabled = true;
            cmbo_Author.Location = new Point(200, 25);
            cmbo_Author.Name = "cmbo_Author";
            cmbo_Author.Size = new Size(151, 28);
            cmbo_Author.TabIndex = 7;
            // 
            // txt_BublishedYr
            // 
            txt_BublishedYr.Location = new Point(450, 26);
            txt_BublishedYr.Name = "txt_BublishedYr";
            txt_BublishedYr.Size = new Size(118, 27);
            txt_BublishedYr.TabIndex = 8;
            // 
            // txt_Genra
            // 
            txt_Genra.Location = new Point(357, 26);
            txt_Genra.Name = "txt_Genra";
            txt_Genra.Size = new Size(87, 27);
            txt_Genra.TabIndex = 9;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 411);
            Controls.Add(txt_Genra);
            Controls.Add(txt_BublishedYr);
            Controls.Add(cmbo_Author);
            Controls.Add(txt_BookName);
            Controls.Add(btn_Save);
            Controls.Add(dataGridView);
            Name = "BooksForm";
            Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Save;
        private DataGridView dataGridView;
        private TextBox txt_BookName;
        private ComboBox cmbo_Author;
        private TextBox txt_BublishedYr;
        private TextBox txt_Genra;
    }
}