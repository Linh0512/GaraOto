using System.Drawing;
using System.Windows.Forms;

public class TransparentButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        // Draw only the text, without any border
        TextRenderer.DrawText(
            pevent.Graphics,
            this.Text,
            this.Font,
            this.ClientRectangle,
            this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Skip the background painting to make it transparent
    }
}
