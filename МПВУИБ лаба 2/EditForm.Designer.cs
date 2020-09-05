namespace МПВУИБ_лаба_2
{
    partial class EditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controlsUserControl = new МПВУИБ_лаба_2.ControlsUserControl();
            this.titleLabel = new System.Windows.Forms.Label();
            this.editDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatementText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saceChenjesButton = new System.Windows.Forms.Button();
            this.openStatementFileLabel = new System.Windows.Forms.Label();
            this.showDataModelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsUserControl
            // 
            this.controlsUserControl.Location = new System.Drawing.Point(847, -1);
            this.controlsUserControl.Name = "controlsUserControl";
            this.controlsUserControl.Size = new System.Drawing.Size(63, 38);
            this.controlsUserControl.TabIndex = 142;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.titleLabel.Location = new System.Drawing.Point(423, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(86, 23);
            this.titleLabel.TabIndex = 148;
            this.titleLabel.Text = "Редактор";
            // 
            // editDataGridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.editDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.editDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.editDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.editDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.saveClass,
            this.StatementText});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.editDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.editDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.editDataGridView.Location = new System.Drawing.Point(12, 68);
            this.editDataGridView.Name = "editDataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.editDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.editDataGridView.Size = new System.Drawing.Size(883, 466);
            this.editDataGridView.TabIndex = 149;
            // 
            // id
            // 
            this.id.HeaderText = "id признака";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // saveClass
            // 
            this.saveClass.HeaderText = "Класс защищённости признака";
            this.saveClass.Name = "saveClass";
            this.saveClass.Width = 90;
            // 
            // StatementText
            // 
            this.StatementText.HeaderText = "Удтверждение";
            this.StatementText.Name = "StatementText";
            this.StatementText.Width = 689;
            // 
            // saceChenjesButton
            // 
            this.saceChenjesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saceChenjesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saceChenjesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.saceChenjesButton.Location = new System.Drawing.Point(402, 554);
            this.saceChenjesButton.Name = "saceChenjesButton";
            this.saceChenjesButton.Size = new System.Drawing.Size(150, 39);
            this.saceChenjesButton.TabIndex = 150;
            this.saceChenjesButton.TabStop = false;
            this.saceChenjesButton.Text = "Сохранить";
            this.saceChenjesButton.UseVisualStyleBackColor = true;
            this.saceChenjesButton.Click += new System.EventHandler(this.saceChenjesButton_Click);
            // 
            // openStatementFileLabel
            // 
            this.openStatementFileLabel.AutoSize = true;
            this.openStatementFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openStatementFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openStatementFileLabel.Location = new System.Drawing.Point(741, 568);
            this.openStatementFileLabel.Name = "openStatementFileLabel";
            this.openStatementFileLabel.Size = new System.Drawing.Size(135, 13);
            this.openStatementFileLabel.TabIndex = 151;
            this.openStatementFileLabel.Text = "Открыть файл сданными";
            this.openStatementFileLabel.Click += new System.EventHandler(this.openStatementFileLabel_Click);
            // 
            // showDataModelLabel
            // 
            this.showDataModelLabel.AutoSize = true;
            this.showDataModelLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showDataModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDataModelLabel.Location = new System.Drawing.Point(22, 19);
            this.showDataModelLabel.Name = "showDataModelLabel";
            this.showDataModelLabel.Size = new System.Drawing.Size(120, 13);
            this.showDataModelLabel.TabIndex = 152;
            this.showDataModelLabel.Text = "Посмотреть признаки";
            this.showDataModelLabel.Visible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(907, 610);
            this.Controls.Add(this.showDataModelLabel);
            this.Controls.Add(this.openStatementFileLabel);
            this.Controls.Add(this.saceChenjesButton);
            this.Controls.Add(this.editDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.controlsUserControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.editDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsUserControl controlsUserControl;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView editDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatementText;
        private System.Windows.Forms.Button saceChenjesButton;
        private System.Windows.Forms.Label openStatementFileLabel;
        private System.Windows.Forms.Label showDataModelLabel;
    }
}