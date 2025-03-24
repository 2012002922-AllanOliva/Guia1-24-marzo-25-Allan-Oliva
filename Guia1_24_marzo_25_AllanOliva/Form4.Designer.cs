namespace Guia1_24_marzo_25_AllanOliva
{
    partial class Form4
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
            Vect1 = new DataGridViewTextBoxColumn();
            vect2 = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Vect1, vect2, total });
            dataGridView1.Location = new Point(83, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 200);
            dataGridView1.TabIndex = 0;
            // 
            // Vect1
            // 
            Vect1.HeaderText = "Vector 1";
            Vect1.Name = "Vect1";
            // 
            // vect2
            // 
            vect2.HeaderText = "Vector 2";
            vect2.Name = "vect2";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Vect1;
        private DataGridViewTextBoxColumn vect2;
        private DataGridViewTextBoxColumn total;
    }
}