using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пасоиб_лаба_2
{
    public partial class ControlsUserControl : UserControl
    {
        public enum ClosingMod { Programm, Form};

        public ClosingMod closingMod = ClosingMod.Programm;

        public ControlsUserControl()
        {
            InitializeComponent();

            ToolTip toolTip = Style.CreateColorsToolTip();

            toolTip.SetToolTip(closeLabel, "Закрыть");
            toolTip.SetToolTip(rollUpLabel, "Свернуть");

            closeLabel.Click += (object _sender, EventArgs _e) =>
            {
                switch (closingMod)
                {
                    case ClosingMod.Programm:
                        Environment.Exit(0);
                        break;
                    case ClosingMod.Form:
                        parentForm.Close();
                        break;
                };

            };

            rollUpLabel.Click += (object _sender, EventArgs _e) => ParentForm.WindowState = FormWindowState.Minimized;
            closeLabel.LikeButtonHoverStyle();
            rollUpLabel.LikeButtonHoverStyle();
        }

        public Form parentForm;
    }
}
