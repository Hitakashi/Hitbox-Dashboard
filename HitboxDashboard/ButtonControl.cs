using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HitboxDashboard
{
    public partial class HitboxForm
    {
        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hitboxSubmitLogin.PerformClick();
            }
        }
        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hitboxSubmitLogin.PerformClick();
            }
        }
        private void gameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Debug.WriteLine("Selection Changed");
            GoodToPost = true;
        }
        private void adPlusButton_Click(object sender, EventArgs e)
        {
            if (adCount < 10)
                adCount++;
            adButton.Text = Regex.Replace(adButton.Text, @"[0-9]{1,2}", adCount.ToString());
        }
        private void adMinusButton_Click(object sender, EventArgs e)
        {
            if (adCount > 0)
                adCount--;
            adButton.Text = Regex.Replace(adButton.Text, @"[0-9]{1,2}", adCount.ToString());
        }
        private void adButton_Click(object sender, EventArgs e)
        {
            if (adCount > 0)
            {
                // Enough Ads to run.
                var json = new JavaScriptSerializer().Serialize(new
                {
                    authToken = AuthToken,
                });

                API.PostAync(String.Format("{0}/ws/combreak/{1}/{2}", API.BaseApi, Channel, adCount), json);
                ws.GuiMessage(Username, "SYSTEM: Sent commercial command.", "000000");
            }
        }
        private void visibleButton_Click(object sender, EventArgs e)
        {
            PostHidden(false);
        }
        private void hiddenButton_Click(object sender, EventArgs e)
        {
            PostHidden(true);

        }
        private void gameComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            game = gameComboBox.Text;
            Debug.WriteLine("Game: " + game);


            if (e.KeyCode == Keys.Enter && GoodToPost && !isNewGame)
            {
                PostGame(gameComboBox.Text);
                GoodToPost = false;
                isNewGame = false;
                LastGameSearch = game;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(game) && isNewGame && !LastGameSearch.Equals(game))
                {
                    SearchGames(gameComboBox.Text);
                    isNewGame = false;
                    LastGameSearch = game;
                    gameComboBox.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                isNewGame = true;
                GoodToPost = false;
            }
        }
        private void chatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ws.SendChat(chatBox.Text);
                chatBox.Clear();
                chatBox.Multiline = false;
                chatBox.Multiline = true;
            }
        }
        private void streamTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PostTitle(streamTitle.Text);
            }
        }
        private void allUsersList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (allUsersList.FocusedItem.Bounds.Contains(e.Location))
                {
                    if (allUsersList.FocusedItem.Text.StartsWith("[B]") ||
                        allUsersList.FocusedItem.Text.StartsWith("[E]") ||
                        allUsersList.FocusedItem.Text.StartsWith("[S]") ||
                        allUsersList.FocusedItem.Text.StartsWith("[A]"))
                    {
                        BroadcasterList_Context();
                    }
                    else if (allUsersList.FocusedItem.Text.StartsWith("[M]"))
                    {
                        ModList_Context();
                    }
                    else
                    {
                        viewerList_Context();
                    }
                    allContextMenu.Show(Cursor.Position);
                }
            }
        }
        private void modUsersList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (modUsersList.FocusedItem.Bounds.Contains(e.Location))
                {
                    if (modUsersList.FocusedItem.Text.StartsWith("[B]") ||
                        modUsersList.FocusedItem.Text.StartsWith("[E]") ||
                        modUsersList.FocusedItem.Text.StartsWith("[S]") ||
                        modUsersList.FocusedItem.Text.StartsWith("[A]"))
                    {
                        BroadcasterList_Context();
                    }
                    else if (modUsersList.FocusedItem.Text.StartsWith("[M]"))
                    {
                        ModList_Context();
                    }
                    modContextMenu.Show(Cursor.Position);
                }
            }
        }
        private void viewerUsersList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (viewerUsersList.FocusedItem.Bounds.Contains(e.Location))
                {
                    viewerList_Context();
                }
                viewerContextMenu.Show(Cursor.Position);
            }
        }
        private void banUserList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (banUserList.FocusedItem.Bounds.Contains(e.Location))
                {
                    BanList_Context();
                }
                bannedContextMenu.Show(Cursor.Position);
            }
        }
        private void viewerList_Context()
        {
            allContextMenu.Items.Clear();
            allContextMenu.Items.Add("Mention");
            allContextMenu.Items.Add("Timeout");
            allContextMenu.Items.Add("Ban");
            allContextMenu.Items.Add("Mod");
        }
        private void ModList_Context()
        {
            modContextMenu.Items.Clear();
            modContextMenu.Items.Add("Mention");
            modContextMenu.Items.Add("Timeout");
            modContextMenu.Items.Add("Ban");
            modContextMenu.Items.Add("Unmod");
        }
        private void BroadcasterList_Context()
        {
            modContextMenu.Items.Clear();
            modContextMenu.Items.Add("Mention");
        }
        private void BanList_Context()
        {
            bannedContextMenu.Items.Clear();
            bannedContextMenu.Items.Add("Unban");
        }
        private void modContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String user = Regex.Replace(modUsersList.FocusedItem.Text, @"(\[(A|S|B|E|M|Ban|Sub)\]\s)", "");
            switch (e.ClickedItem.Text)
            {
                case "Mention":
                    if (chatBox.TextLength > 0)
                    {
                        chatBox.AppendText(" @" + user + " ");
                    }
                    else
                    {
                        chatBox.AppendText("@" + user + " ");
                    }
                    break;
                case "Timeout":
                    ws.SendTimeout(user);
                    break;
                case "Ban":
                    ws.SendBan(user);
                    break;
                case "Unban":
                    ws.SendUnBan(user);
                    break;
            }
        }
        private void viewerContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String user = Regex.Replace(viewerUsersList.FocusedItem.Text, @"(\[(A|S|B|E|M|Ban|Sub)\]\s)", "");

            switch (e.ClickedItem.Text)
            {
                case "Mention":
                    if (chatBox.TextLength > 0)
                    {
                        chatBox.AppendText(" @" + user + " ");
                    }
                    else
                    {
                        chatBox.AppendText("@" + user + " ");
                    }
                    break;
                case "Timeout":
                    ws.SendTimeout(user);
                    break;
                case "Ban":
                    ws.SendBan(user);
                    break;
                case "Unban":
                    ws.SendUnBan(user);
                    break;
            }
        }
        private void bannedContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String user = Regex.Replace(banUserList.FocusedItem.Text, @"(\[(A|S|B|E|M|Ban|Sub)\]\s)", "");

            switch (e.ClickedItem.Text)
            {
                case "Mention":
                    if (chatBox.TextLength > 0)
                    {
                        chatBox.AppendText(" @" + user + " ");
                    }
                    else
                    {
                        chatBox.AppendText("@" + user + " ");
                    }
                    break;
                case "Timeout":
                    ws.SendTimeout(user);
                    break;
                case "Ban":
                    ws.SendBan(user);
                    break;
                case "Unban":
                    ws.SendUnBan(user);
                    break;
            }
        }
        private void allContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String user = Regex.Replace(allUsersList.FocusedItem.Text, @"(\[(A|S|B|E|M|Ban|Sub)\]\s)", "");

            switch (e.ClickedItem.Text)
            {
                case "Mention":
                    if (chatBox.TextLength > 0)
                    {
                        chatBox.AppendText(" @" + user + " ");
                    }
                    else
                    {
                        chatBox.AppendText("@" + user + " ");
                    }
                    break;
                case "Timeout":
                    ws.SendTimeout(user);
                    break;
                case "Ban":
                    ws.SendBan(user);
                    break;
                case "Unban":
                    ws.SendUnBan(user);
                    break;
            }
        }
    }
}
