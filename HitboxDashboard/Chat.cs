using System;
using System.Drawing;
using System.Web;
using System.Windows.Forms;

namespace HitboxDashboard
{
    public partial class HitboxForm
    {
        #region ChatMessages

        private void ws_webSocketMessage(object sender, WebSocketMessageEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                if (!e.Message.StartsWith("SYSTEM:") && !e.Message.StartsWith("Info:"))
                {
                    var hextorgb = ColorTranslator.FromHtml("#" + e.Color);
                    var userColor = Color.FromArgb(hextorgb.R, hextorgb.G, hextorgb.B);
                    chatTextBox.AppendText(e.UserName, userColor);
                    chatTextBox.AppendText(": ");
                    chatTextBox.AppendText(HttpUtility.HtmlDecode(e.Message));
                }
                else
                {
                    chatTextBox.AppendText(String.Format("{0}", e.Message));
                }
                chatTextBox.AppendText(Environment.NewLine);
            });
        }

        #endregion
    }
}