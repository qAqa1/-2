namespace МПВУИБ_лаба_2
{
    partial class SaveClassesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveClassesForm));
            this.statementDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatementText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YesOrNo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.outputTitleLabel = new System.Windows.Forms.Label();
            this.tableTitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.addLabel = new System.Windows.Forms.Label();
            this.updatePictureBox = new System.Windows.Forms.PictureBox();
            this.getResultPictureBox = new System.Windows.Forms.PictureBox();
            this.controlsUserControl = new МПВУИБ_лаба_2.ControlsUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.statementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statementDataGridView
            // 
            this.statementDataGridView.AllowUserToAddRows = false;
            this.statementDataGridView.AllowUserToDeleteRows = false;
            this.statementDataGridView.AllowUserToResizeColumns = false;
            this.statementDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.statementDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.statementDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.statementDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statementDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.statementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statementDataGridView.ColumnHeadersVisible = false;
            this.statementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.StatementText,
            this.YesOrNo,
            this.saveClass});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statementDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.statementDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.statementDataGridView.Location = new System.Drawing.Point(12, 63);
            this.statementDataGridView.MultiSelect = false;
            this.statementDataGridView.Name = "statementDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statementDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.statementDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.statementDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.statementDataGridView.Size = new System.Drawing.Size(888, 316);
            this.statementDataGridView.TabIndex = 140;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 30;
            // 
            // StatementText
            // 
            this.StatementText.HeaderText = "Удтверждение";
            this.StatementText.Name = "StatementText";
            this.StatementText.ReadOnly = true;
            this.StatementText.Width = 818;
            // 
            // YesOrNo
            // 
            this.YesOrNo.HeaderText = "Да/Нет";
            this.YesOrNo.Name = "YesOrNo";
            this.YesOrNo.Width = 50;
            // 
            // saveClass
            // 
            this.saveClass.HeaderText = "Класс защищённости";
            this.saveClass.Name = "saveClass";
            this.saveClass.Visible = false;
            this.saveClass.Width = 30;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.outputTextBox.Location = new System.Drawing.Point(11, 460);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(889, 189);
            this.outputTextBox.TabIndex = 142;
            this.outputTextBox.TabStop = false;
            // 
            // outputTitleLabel
            // 
            this.outputTitleLabel.AutoSize = true;
            this.outputTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputTitleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.outputTitleLabel.Location = new System.Drawing.Point(8, 438);
            this.outputTitleLabel.Name = "outputTitleLabel";
            this.outputTitleLabel.Size = new System.Drawing.Size(59, 19);
            this.outputTitleLabel.TabIndex = 144;
            this.outputTitleLabel.Text = "Вывод:";
            // 
            // tableTitleLabel
            // 
            this.tableTitleLabel.AutoSize = true;
            this.tableTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableTitleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.tableTitleLabel.Location = new System.Drawing.Point(7, 41);
            this.tableTitleLabel.Name = "tableTitleLabel";
            this.tableTitleLabel.Size = new System.Drawing.Size(377, 19);
            this.tableTitleLabel.TabIndex = 146;
            this.tableTitleLabel.Text = "Выберете верные удтверждения для вашй системы:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.titleLabel.Location = new System.Drawing.Point(299, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(374, 19);
            this.titleLabel.TabIndex = 147;
            this.titleLabel.Text = "6 классов защищённости 1992 год гос тех комиссия";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLabel.Location = new System.Drawing.Point(846, 442);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(54, 13);
            this.clearLabel.TabIndex = 148;
            this.clearLabel.Text = "Очистить";
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.BackColor = System.Drawing.Color.Transparent;
            this.addLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.addLabel.Location = new System.Drawing.Point(11, 5);
            this.addLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(32, 36);
            this.addLabel.TabIndex = 149;
            this.addLabel.Text = "+";
            this.addLabel.Click += new System.EventHandler(this.addLabel_Click);
            // 
            // updatePictureBox
            // 
            this.updatePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("updatePictureBox.Image")));
            this.updatePictureBox.Location = new System.Drawing.Point(60, 12);
            this.updatePictureBox.Name = "updatePictureBox";
            this.updatePictureBox.Size = new System.Drawing.Size(28, 28);
            this.updatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatePictureBox.TabIndex = 150;
            this.updatePictureBox.TabStop = false;
            this.updatePictureBox.Click += new System.EventHandler(this.updatePictureBox_Click);
            // 
            // getResultPictureBox
            // 
            this.getResultPictureBox.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.getResultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("getResultPictureBox.Image")));
            this.getResultPictureBox.Location = new System.Drawing.Point(450, 385);
            this.getResultPictureBox.Name = "getResultPictureBox";
            this.getResultPictureBox.Size = new System.Drawing.Size(60, 60);
            this.getResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.getResultPictureBox.TabIndex = 145;
            this.getResultPictureBox.TabStop = false;
            this.getResultPictureBox.Click += new System.EventHandler(this.getResultPictureBox_Click);
            // 
            // controlsUserControl
            // 
            this.controlsUserControl.Location = new System.Drawing.Point(851, -4);
            this.controlsUserControl.Name = "controlsUserControl";
            this.controlsUserControl.Size = new System.Drawing.Size(63, 38);
            this.controlsUserControl.TabIndex = 141;
            // 
            // SaveClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(912, 674);
            this.Controls.Add(this.updatePictureBox);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.tableTitleLabel);
            this.Controls.Add(this.getResultPictureBox);
            this.Controls.Add(this.outputTitleLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.controlsUserControl);
            this.Controls.Add(this.statementDataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveClassesForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6 классов защищённости 1992 год гос тех комиссия";
            ((System.ComponentModel.ISupportInitialize)(this.statementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getResultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statementDataGridView;
        private ControlsUserControl controlsUserControl;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label outputTitleLabel;
        private System.Windows.Forms.PictureBox getResultPictureBox;
        private System.Windows.Forms.Label tableTitleLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatementText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YesOrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveClass;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.PictureBox updatePictureBox;
    }
}

