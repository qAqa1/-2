using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пасоиб_лаба_2
{
    public partial class EditForm : Form
    {
        public EditForm(Action updateParenTable)
        {
            InitializeComponent();

            this.updateParenTable = updateParenTable;

            MouseDown += (object sender, MouseEventArgs e) =>
            {
                this.Capture = false;
                Message m = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref m);
            };

            string[] lines = File.ReadAllLines(SaveClassesForm.StatementFile, Encoding.Default);

            Array.ForEach(lines, line =>
            {
                if (line == string.Empty)
                {
                    return;
                }

                Statement statement = Statement.Parse(line);
                editDataGridView.Rows.Add(statement.CecurityCriterionId, statement.SaveClass, statement.Text);
            }
            );
        }

        Action updateParenTable;

        private void saceChenjesButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in editDataGridView.Rows)
            {
                string id = row.Cells["id"].Value?.ToString();

                if (id == null) return;

                string saveClass = row.Cells["saveClass"].Value.ToString();

                string StatementText = (string)row.Cells["StatementText"].Value;

                if (string.IsNullOrWhiteSpace(StatementText)) return;

                string border = "|";

                string addStr = Environment.NewLine + id + border + saveClass + border + StatementText;

                File.WriteAllText(SaveClassesForm.StatementFile, addStr, Encoding.Default);
            }
        }

        private void openStatementFileLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SaveClassesForm.StatementFile);
            }
            catch { }
        }
    }
}
