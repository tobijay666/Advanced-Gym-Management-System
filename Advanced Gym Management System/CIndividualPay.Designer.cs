
namespace Advanced_Gym_Management_System
{
    partial class CIndividualPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slim_Lady_FitnessDataSet2 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet2();
            this.paymentTableAdapter = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet2TableAdapters.PaymentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.viewBtn2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvcIndCusPay = new System.Windows.Forms.DataGridView();
            this.pIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.slim_Lady_FitnessDataSet5 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet5();
            this.paymentTableAdapter1 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet5TableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcIndCusPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Advanced_Gym_Management_System.Properties.Resources.whiteLogo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Individual Customer Payments";
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.slim_Lady_FitnessDataSet2;
            // 
            // slim_Lady_FitnessDataSet2
            // 
            this.slim_Lady_FitnessDataSet2.DataSetName = "Slim_Lady_FitnessDataSet2";
            this.slim_Lady_FitnessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Customer Id";
            // 
            // txtCId
            // 
            this.txtCId.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCId.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCId.Location = new System.Drawing.Point(50, 268);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(102, 35);
            this.txtCId.TabIndex = 16;
            this.txtCId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCId.TextChanged += new System.EventHandler(this.txtCId_TextChanged);
            // 
            // viewBtn2
            // 
            this.viewBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.viewBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewBtn2.Location = new System.Drawing.Point(50, 317);
            this.viewBtn2.Name = "viewBtn2";
            this.viewBtn2.Size = new System.Drawing.Size(102, 36);
            this.viewBtn2.TabIndex = 17;
            this.viewBtn2.Text = "View ";
            this.viewBtn2.UseVisualStyleBackColor = true;
            this.viewBtn2.Click += new System.EventHandler(this.viewBtn2_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(1028, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 50;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvcIndCusPay
            // 
            this.dgvcIndCusPay.AutoGenerateColumns = false;
            this.dgvcIndCusPay.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvcIndCusPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcIndCusPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcIndCusPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcIndCusPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIdDataGridViewTextBoxColumn,
            this.pDateDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn});
            this.dgvcIndCusPay.DataSource = this.paymentBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcIndCusPay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcIndCusPay.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvcIndCusPay.Location = new System.Drawing.Point(317, 232);
            this.dgvcIndCusPay.Name = "dgvcIndCusPay";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcIndCusPay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcIndCusPay.Size = new System.Drawing.Size(642, 150);
            this.dgvcIndCusPay.TabIndex = 51;
            // 
            // pIdDataGridViewTextBoxColumn
            // 
            this.pIdDataGridViewTextBoxColumn.DataPropertyName = "pId";
            this.pIdDataGridViewTextBoxColumn.HeaderText = "Payment Id";
            this.pIdDataGridViewTextBoxColumn.Name = "pIdDataGridViewTextBoxColumn";
            this.pIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // pDateDataGridViewTextBoxColumn
            // 
            this.pDateDataGridViewTextBoxColumn.DataPropertyName = "pDate";
            this.pDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.pDateDataGridViewTextBoxColumn.Name = "pDateDataGridViewTextBoxColumn";
            this.pDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "pAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.slim_Lady_FitnessDataSet5;
            // 
            // slim_Lady_FitnessDataSet5
            // 
            this.slim_Lady_FitnessDataSet5.DataSetName = "Slim_Lady_FitnessDataSet5";
            this.slim_Lady_FitnessDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // CIndividualPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.dgvcIndCusPay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.viewBtn2);
            this.Controls.Add(this.txtCId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1171, 726);
            this.MinimumSize = new System.Drawing.Size(1171, 726);
            this.Name = "CIndividualPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIndividualPay";
            this.Load += new System.EventHandler(this.CIndividualPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcIndCusPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Slim_Lady_FitnessDataSet2 slim_Lady_FitnessDataSet2;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Slim_Lady_FitnessDataSet2TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.Button viewBtn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvcIndCusPay;
        private Slim_Lady_FitnessDataSet5 slim_Lady_FitnessDataSet5;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private Slim_Lady_FitnessDataSet5TableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
    }
}