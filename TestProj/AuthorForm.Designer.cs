namespace TestProj
{
    partial class AuthorForm
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
            btn_Add = new Button();
            dataGridView = new DataGridView();
            btn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(29, 12);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(112, 33);
            btn_Add.TabIndex = 0;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(29, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(665, 334);
            dataGridView.TabIndex = 1;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(160, 12);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(112, 33);
            btn_Save.TabIndex = 2;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 423);
            Controls.Add(btn_Save);
            Controls.Add(dataGridView);
            Controls.Add(btn_Add);
            Name = "AuthorForm";
            Text = "AuthorForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Add;
        private DataGridView dataGridView;
        private Button btn_Save;
    }
}