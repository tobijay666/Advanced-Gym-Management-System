
namespace Advanced_Gym_Management_System
{
    partial class Workoutplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workoutplan));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtWorkDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.wupdatebut = new System.Windows.Forms.Button();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            this.lblwname = new System.Windows.Forms.Label();
            this.lblwid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workDGV = new System.Windows.Forms.DataGridView();
            this.wIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slim_Lady_FitnessDataSet1 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet1();
            this.workoutTableAdapter = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet1TableAdapters.WorkoutTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(30, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 48);
            this.label5.TabIndex = 70;
            this.label5.Text = "NAME:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(30, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 48);
            this.label4.TabIndex = 68;
            this.label4.Text = "WORKOUT ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtWorkDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWorkName);
            this.groupBox1.Controls.Add(this.wupdatebut);
            this.groupBox1.Controls.Add(this.txtWorkId);
            this.groupBox1.Controls.Add(this.lblwname);
            this.groupBox1.Controls.Add(this.lblwid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Unispace", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(28, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 605);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WORKOUT PLAN";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(38, 525);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(286, 70);
            this.btnClear.TabIndex = 82;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Location = new System.Drawing.Point(444, 432);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(286, 70);
            this.btnInsert.TabIndex = 81;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtWorkDesc
            // 
            this.txtWorkDesc.BackColor = System.Drawing.Color.Black;
            this.txtWorkDesc.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtWorkDesc.Location = new System.Drawing.Point(359, 219);
            this.txtWorkDesc.Multiline = true;
            this.txtWorkDesc.Name = "txtWorkDesc";
            this.txtWorkDesc.Size = new System.Drawing.Size(371, 186);
            this.txtWorkDesc.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(30, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 48);
            this.label2.TabIndex = 79;
            this.label2.Text = "DESCRIPTION:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkName
            // 
            this.txtWorkName.BackColor = System.Drawing.Color.Black;
            this.txtWorkName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtWorkName.Location = new System.Drawing.Point(359, 138);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(371, 49);
            this.txtWorkName.TabIndex = 78;
            // 
            // wupdatebut
            // 
            this.wupdatebut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wupdatebut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.wupdatebut.FlatAppearance.BorderSize = 0;
            this.wupdatebut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.wupdatebut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wupdatebut.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wupdatebut.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wupdatebut.Location = new System.Drawing.Point(444, 525);
            this.wupdatebut.Name = "wupdatebut";
            this.wupdatebut.Size = new System.Drawing.Size(286, 70);
            this.wupdatebut.TabIndex = 77;
            this.wupdatebut.Text = "UPDATE";
            this.wupdatebut.UseVisualStyleBackColor = false;
            this.wupdatebut.Click += new System.EventHandler(this.wupdatebut_Click);
            // 
            // txtWorkId
            // 
            this.txtWorkId.BackColor = System.Drawing.Color.Black;
            this.txtWorkId.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtWorkId.Location = new System.Drawing.Point(359, 69);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.Size = new System.Drawing.Size(371, 49);
            this.txtWorkId.TabIndex = 76;
            // 
            // lblwname
            // 
            this.lblwname.AutoSize = true;
            this.lblwname.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwname.Location = new System.Drawing.Point(317, 138);
            this.lblwname.Name = "lblwname";
            this.lblwname.Size = new System.Drawing.Size(0, 37);
            this.lblwname.TabIndex = 73;
            // 
            // lblwid
            // 
            this.lblwid.AutoSize = true;
            this.lblwid.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwid.Location = new System.Drawing.Point(317, 74);
            this.lblwid.Name = "lblwid";
            this.lblwid.Size = new System.Drawing.Size(0, 37);
            this.lblwid.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(570, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 48);
            this.label1.TabIndex = 70;
            this.label1.Text = "ADVANCED GYM MANAGEMENT SYSTEM";
            // 
            // workDGV
            // 
            this.workDGV.AutoGenerateColumns = false;
            this.workDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.workDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wIdDataGridViewTextBoxColumn,
            this.wNameDataGridViewTextBoxColumn,
            this.wDescDataGridViewTextBoxColumn});
            this.workDGV.DataSource = this.workoutBindingSource;
            this.workDGV.Location = new System.Drawing.Point(904, 144);
            this.workDGV.Name = "workDGV";
            this.workDGV.RowHeadersWidth = 62;
            this.workDGV.RowTemplate.Height = 28;
            this.workDGV.Size = new System.Drawing.Size(772, 587);
            this.workDGV.TabIndex = 73;
            // 
            // wIdDataGridViewTextBoxColumn
            // 
            this.wIdDataGridViewTextBoxColumn.DataPropertyName = "wId";
            this.wIdDataGridViewTextBoxColumn.HeaderText = "wId";
            this.wIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wIdDataGridViewTextBoxColumn.Name = "wIdDataGridViewTextBoxColumn";
            this.wIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // wNameDataGridViewTextBoxColumn
            // 
            this.wNameDataGridViewTextBoxColumn.DataPropertyName = "wName";
            this.wNameDataGridViewTextBoxColumn.HeaderText = "wName";
            this.wNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wNameDataGridViewTextBoxColumn.Name = "wNameDataGridViewTextBoxColumn";
            this.wNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // wDescDataGridViewTextBoxColumn
            // 
            this.wDescDataGridViewTextBoxColumn.DataPropertyName = "wDesc";
            this.wDescDataGridViewTextBoxColumn.HeaderText = "wDesc";
            this.wDescDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wDescDataGridViewTextBoxColumn.Name = "wDescDataGridViewTextBoxColumn";
            this.wDescDataGridViewTextBoxColumn.Width = 150;
            // 
            // workoutBindingSource
            // 
            this.workoutBindingSource.DataMember = "Workout";
            this.workoutBindingSource.DataSource = this.slim_Lady_FitnessDataSet1;
            // 
            // slim_Lady_FitnessDataSet1
            // 
            this.slim_Lady_FitnessDataSet1.DataSetName = "Slim_Lady_FitnessDataSet1";
            this.slim_Lady_FitnessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutTableAdapter
            // 
            this.workoutTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(271, 767);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 70);
            this.button3.TabIndex = 83;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReload.Location = new System.Drawing.Point(904, 767);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(286, 70);
            this.btnReload.TabIndex = 84;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // Workoutplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1688, 849);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.workDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1710, 905);
            this.MinimumSize = new System.Drawing.Size(1710, 905);
            this.Name = "Workoutplan";
            this.Text = "WorkoutPlan";
            this.Load += new System.EventHandler(this.Mealplan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblwname;
        private System.Windows.Forms.Label lblwid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wupdatebut;
        private System.Windows.Forms.TextBox txtWorkId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtWorkDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkName;
        private System.Windows.Forms.DataGridView workDGV;
        private Slim_Lady_FitnessDataSet1 slim_Lady_FitnessDataSet1;
        private System.Windows.Forms.BindingSource workoutBindingSource;
        private Slim_Lady_FitnessDataSet1TableAdapters.WorkoutTableAdapter workoutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReload;
    }
}