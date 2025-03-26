namespace Guia1_24_marzo_25_AllanOliva
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            mat1 = new DataGridViewTextBoxColumn();
            mat2 = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mat1, mat2, total });
            dataGridView1.Location = new Point(36, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 245);
            dataGridView1.TabIndex = 0;
            // 
            // mat1
            // 
            mat1.HeaderText = "Matriz1";
            mat1.Name = "mat1";
            // 
            // mat2
            // 
            mat2.HeaderText = "Matriz2";
            mat2.Name = "mat2";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // button1
            // 
            button1.Location = new Point(164, 56);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 1;
            button1.Text = "Ver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 469);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Matriz1;
        private DataGridViewTextBoxColumn Matriz2;
        private Button button1;
        private DataGridViewTextBoxColumn mat1;
        private DataGridViewTextBoxColumn mat2;
        private DataGridViewTextBoxColumn total;
    }
}