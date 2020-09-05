using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МПВУИБ_лаба_2
{
    public partial class SaveClassesForm : Form
    {
        public const string StatementFile = "bd.txt",
                    SecurityModelFileName = "security_model.txt";

        public SaveClassesForm()
        {
        https://fstec.ru/component/attachments/download/297

            InitializeComponent();

            MouseDown += (object sender, MouseEventArgs e) =>
            {
                this.Capture = false;
                Message m = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref m);
            };

            controlsUserControl.parentForm = this;
            controlsUserControl.closingMod = ControlsUserControl.ClosingMod.Programm;

            ToolTip toolTip = Style.CreateColorsToolTip();

            toolTip.SetToolTip(getResultPictureBox, "Получить результат");
            toolTip.SetToolTip(addLabel, "Добавить данные");
            toolTip.SetToolTip(updatePictureBox, "Обновить таблицу");

            updateAction = UpdateTable;
            UpdateTable();
        }

        void UpdateTable()
        {
            outputTextBox.ScrollBars = ScrollBars.None;
            outputTextBox.Clear();
            statementDataGridView.Rows.Clear();

            if (!File.Exists(StatementFile)) File.Create(StatementFile);

            string[] lines = File.ReadAllLines(StatementFile, Encoding.Default);

            Array.ForEach(lines, line =>
            {
                if (line == string.Empty) return;

                Statement statement = Statement.Parse(line);
                statementDataGridView.Rows.Add(statement.CecurityCriterionId, statement.Text, false, statement.SaveClass);
            }
            );

            if (!File.Exists(SecurityModelFileName)) File.Create(SecurityModelFileName);
            securityModel = SecurityModel.FromFile(SecurityModelFileName);
        }

        Action updateAction;

        SecurityModel securityModel;

        public void Output(string text) => outputTextBox.Text += (text + Environment.NewLine);

        private void clearLabel_Click(object sender, EventArgs e)
        {
            outputTextBox.ScrollBars = ScrollBars.None;
            outputTextBox.Clear();
        }

        private void updatePictureBox_Click(object sender, EventArgs e) => UpdateTable();

        private void addLabel_Click(object sender, EventArgs e) => new EditForm(updateAction).ShowDialog();

        private void getResultPictureBox_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();

            statementDataGridView.EndEdit();

            foreach (DataGridViewRow row in statementDataGridView.Rows)
            {
                if ((bool)row.Cells["YesOrNo"].Value)
                {
                    securityModel[(int)row.Cells["id"].Value].Value -= 
                        7 - (int)row.Cells["saveClass"].Value;

                    // колличество баллов за признак вычисляется как:
                    // текущее колличесво баллов - (7 - класс защищённости признака(второй столбец в security_model.txt)
                }
            }

            Console.WriteLine("__________________________________________");
            Console.WriteLine(securityModel.DebugDesription);

            Output(securityModel.ExpertResult());

            outputTextBox.SelectionStart = outputTextBox.TextLength;
            //scroll to the caret
            outputTextBox.ScrollToCaret();
            outputTextBox.ScrollBars = ScrollBars.Vertical;
        }
    }
}
