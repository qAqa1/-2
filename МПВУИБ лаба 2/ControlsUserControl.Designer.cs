namespace Пасоиб_лаба_2
{
    partial class ControlsUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rollUpLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollUpLabel
            // 
            this.rollUpLabel.AutoSize = true;
            this.rollUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.rollUpLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollUpLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.rollUpLabel.Location = new System.Drawing.Point(2, 0);
            this.rollUpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rollUpLabel.Name = "rollUpLabel";
            this.rollUpLabel.Size = new System.Drawing.Size(29, 32);
            this.rollUpLabel.TabIndex = 37;
            this.rollUpLabel.Text = "_";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.closeLabel.Location = new System.Drawing.Point(35, 4);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(28, 28);
            this.closeLabel.TabIndex = 36;
            this.closeLabel.Text = "X";
            // 
            // ControlsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rollUpLabel);
            this.Controls.Add(this.closeLabel);
            this.Name = "ControlsUserControl";
            this.Size = new System.Drawing.Size(63, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rollUpLabel;
        private System.Windows.Forms.Label closeLabel;
    }
}
