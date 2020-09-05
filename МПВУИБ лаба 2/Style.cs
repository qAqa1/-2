using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МПВУИБ_лаба_2
{
    static class Style
    {
        static public ToolTip CreateColorsToolTip()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.BackColor = Color.FromArgb(30, 30, 30);
            toolTip.ForeColor = Color.FromArgb(212, 212, 212);

            toolTip.OwnerDraw = true;
            toolTip.Draw += (object sender, DrawToolTipEventArgs e) =>
            {
                e.DrawBackground();
                e.DrawBorder();
                e.DrawText();
            };

            return toolTip;
        }

        static public void LikeButtonHoverStyle(this Label label)
        {
            label.MouseEnter += (object sender, EventArgs e) => label.BorderStyle = BorderStyle.Fixed3D;
            label.MouseLeave += (object sender, EventArgs e) => label.BorderStyle = BorderStyle.None;
        }
    }
}
