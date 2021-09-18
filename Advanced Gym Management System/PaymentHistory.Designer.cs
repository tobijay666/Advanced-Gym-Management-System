
namespace Advanced_Gym_Management_System
{
    partial class PaymentHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistory));
            this.PayDGV = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slim_Lady_FitnessDataSet4 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet4();
            this.Searchbut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentTableAdapter = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet4TableAdapters.PaymentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PayDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PayDGV
            // 
            this.PayDGV.AutoGenerateColumns = false;
            this.PayDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pDateDataGridViewTextBoxColumn,
            this.cIdDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn});
            this.PayDGV.DataSource = this.paymentBindingSource;
            this.PayDGV.Location = new System.Drawing.Point(466, 188);
            this.PayDGV.Name = "PayDGV";
            this.PayDGV.RowHeadersWidth = 62;
            this.PayDGV.RowTemplate.Height = 28;
            this.PayDGV.Size = new System.Drawing.Size(1057, 631);
            this.PayDGV.TabIndex = 123;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "Payment ID";
            this.pIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pDateDataGridViewTextBoxColumn
            // 
            this.pDateDataGridViewTextBoxColumn.DataPropertyName = "pDate";
            this.pDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.pDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pDateDataGridViewTextBoxColumn.Name = "pDateDataGridViewTextBoxColumn";
            this.pDateDataGridViewTextBoxColumn.Width = 250;
            // 
            // cIdDataGridViewTextBoxColumn
            // 
            this.cIdDataGridViewTextBoxColumn.DataPropertyName = "cId";
            this.cIdDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.cIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cIdDataGridViewTextBoxColumn.Name = "cIdDataGridViewTextBoxColumn";
            this.cIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "pAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.pAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.Width = 350;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.slim_Lady_FitnessDataSet4;
            // 
            // slim_Lady_FitnessDataSet4
            // 
            this.slim_Lady_FitnessDataSet4.DataSetName = "Slim_Lady_FitnessDataSet4";
            this.slim_Lady_FitnessDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Searchbut
            // 
            this.Searchbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Searchbut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Searchbut.FlatAppearance.BorderSize = 0;
            this.Searchbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Searchbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbut.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Searchbut.Location = new System.Drawing.Point(40, 359);
            this.Searchbut.Name = "Searchbut";
            this.Searchbut.Size = new System.Drawing.Size(211, 70);
            this.Searchbut.TabIndex = 122;
            this.Searchbut.Text = "SHOW DATA";
            this.Searchbut.UseVisualStyleBackColor = false;
            this.Searchbut.Click += new System.EventHandler(this.Searchbut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(40, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 70);
            this.button1.TabIndex = 124;
            this.button1.Text = "ADD NEW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(40, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 70);
            this.button2.TabIndex = 125;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Astrolab", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(422, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1024, 55);
            this.label3.TabIndex = 131;
            this.label3.Text = "CUSTOMER PAYMENT DETAILS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1688, 849);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PayDGV);
            this.Controls.Add(this.Searchbut);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1710, 905);
            this.MinimumSize = new System.Drawing.Size(1710, 905);
            this.Name = "PaymentHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PayDGV;
        private System.Windows.Forms.Button Searchbut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private Slim_Lady_FitnessDataSet4 slim_Lady_FitnessDataSet4;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Slim_Lady_FitnessDataSet4TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}