
namespace Advanced_Gym_Management_System
{
    partial class Mealplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mealplan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMealDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMealName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMealId = new System.Windows.Forms.TextBox();
            this.lblwname = new System.Windows.Forms.Label();
            this.lblwid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mealDGV = new System.Windows.Forms.DataGridView();
            this.mIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.slim_Lady_FitnessDataSet2 = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet2();
            this.mealTableAdapter = new Advanced_Gym_Management_System.Slim_Lady_FitnessDataSet2TableAdapters.MealTableAdapter();
            this.btnReload = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtMealDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMealName);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtMealId);
            this.groupBox1.Controls.Add(this.lblwname);
            this.groupBox1.Controls.Add(this.lblwid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(28, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 711);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEAL PLAN";
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
            this.btnClear.Location = new System.Drawing.Point(75, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 70);
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
            this.btnInsert.Location = new System.Drawing.Point(308, 535);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(197, 70);
            this.btnInsert.TabIndex = 81;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMealDesc
            // 
            this.txtMealDesc.BackColor = System.Drawing.Color.Black;
            this.txtMealDesc.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMealDesc.Location = new System.Drawing.Point(359, 219);
            this.txtMealDesc.Multiline = true;
            this.txtMealDesc.Name = "txtMealDesc";
            this.txtMealDesc.Size = new System.Drawing.Size(371, 278);
            this.txtMealDesc.TabIndex = 80;
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
            // txtMealName
            // 
            this.txtMealName.BackColor = System.Drawing.Color.Black;
            this.txtMealName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMealName.Location = new System.Drawing.Point(359, 138);
            this.txtMealName.Name = "txtMealName";
            this.txtMealName.Size = new System.Drawing.Size(371, 49);
            this.txtMealName.TabIndex = 78;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Location = new System.Drawing.Point(531, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 70);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMealId
            // 
            this.txtMealId.BackColor = System.Drawing.Color.Black;
            this.txtMealId.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMealId.Location = new System.Drawing.Point(359, 69);
            this.txtMealId.Name = "txtMealId";
            this.txtMealId.Size = new System.Drawing.Size(371, 49);
            this.txtMealId.TabIndex = 76;
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
            this.label4.Size = new System.Drawing.Size(150, 48);
            this.label4.TabIndex = 68;
            this.label4.Text = "MEAL ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // mealDGV
            // 
            this.mealDGV.AutoGenerateColumns = false;
            this.mealDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mealDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIdDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.mDescDataGridViewTextBoxColumn});
            this.mealDGV.DataSource = this.mealBindingSource;
            this.mealDGV.Location = new System.Drawing.Point(904, 144);
            this.mealDGV.Name = "mealDGV";
            this.mealDGV.RowHeadersWidth = 62;
            this.mealDGV.RowTemplate.Height = 28;
            this.mealDGV.Size = new System.Drawing.Size(772, 587);
            this.mealDGV.TabIndex = 76;
            // 
            // mIdDataGridViewTextBoxColumn
            // 
            this.mIdDataGridViewTextBoxColumn.DataPropertyName = "mId";
            this.mIdDataGridViewTextBoxColumn.HeaderText = "Meal ID";
            this.mIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mIdDataGridViewTextBoxColumn.Name = "mIdDataGridViewTextBoxColumn";
            this.mIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.mNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // mDescDataGridViewTextBoxColumn
            // 
            this.mDescDataGridViewTextBoxColumn.DataPropertyName = "mDesc";
            this.mDescDataGridViewTextBoxColumn.HeaderText = "Description";
            this.mDescDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mDescDataGridViewTextBoxColumn.Name = "mDescDataGridViewTextBoxColumn";
            this.mDescDataGridViewTextBoxColumn.Width = 450;
            // 
            // mealBindingSource
            // 
            this.mealBindingSource.DataMember = "Meal";
            this.mealBindingSource.DataSource = this.slim_Lady_FitnessDataSet2;
            // 
            // slim_Lady_FitnessDataSet2
            // 
            this.slim_Lady_FitnessDataSet2.DataSetName = "Slim_Lady_FitnessDataSet2";
            this.slim_Lady_FitnessDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mealTableAdapter
            // 
            this.mealTableAdapter.ClearBeforeFill = true;
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
            this.btnReload.Location = new System.Drawing.Point(834, 767);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(286, 70);
            this.btnReload.TabIndex = 86;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.button3.Location = new System.Drawing.Point(1458, 767);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 70);
            this.button3.TabIndex = 85;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Astrolab", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(716, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 55);
            this.label1.TabIndex = 130;
            this.label1.Text = "MEAL PLAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mealplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1688, 849);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mealDGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1710, 905);
            this.MinimumSize = new System.Drawing.Size(1710, 905);
            this.Name = "Mealplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mealplan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mealplan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slim_Lady_FitnessDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMealDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMealName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMealId;
        private System.Windows.Forms.Label lblwname;
        private System.Windows.Forms.Label lblwid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView mealDGV;
        private Slim_Lady_FitnessDataSet2 slim_Lady_FitnessDataSet2;
        private System.Windows.Forms.BindingSource mealBindingSource;
        private Slim_Lady_FitnessDataSet2TableAdapters.MealTableAdapter mealTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}