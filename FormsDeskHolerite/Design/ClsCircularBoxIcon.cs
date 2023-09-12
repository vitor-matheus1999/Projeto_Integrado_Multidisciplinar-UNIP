using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome;
using FontAwesome.Sharp;

namespace FormsDeskHolerite.Design
{
    internal class ClsCircularBoxIcon:IconButton
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grPath = new GraphicsPath();
            Form form = new Form();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pe);   
        }
    }
}
