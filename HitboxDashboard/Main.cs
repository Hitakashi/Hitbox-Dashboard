using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace HitboxDashboard
{
    public partial class HitboxForm : Form
    {
        private static int adCount;
        public String Channel;
        private Boolean GoodToPost;
        private Boolean isEditor;
        private Boolean isLogged;
        private Boolean isNewGame = true;
        private String LastGameSearch = "";
        public String Username;
        private WebSocketData ws;
        private Thread WSThread;

        public HitboxForm()
        {
            AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
            InitializeComponent();
            InitializeRun();
        }

        private String game { get; set; }

        private void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            if (WSThread != null)
                WSThread.Abort();
        }

        private void InitializeRun()
        {
            // Custom items for layout.
            // Hide Info and Dashboard tabs.
            tabControl.TabPages.Remove(dashboardTab);
        }

        private void aboutLabel_click(object sender, EventArgs e)
        {
            using (var box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private void hitboxSubmitLogin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (usernameTextBox.Text.Trim().Length != 0)
            {
                // They inputted a username. If they have a password auth them, if not connect as guest.
                if (passwordTextBox.Text.Trim().Length != 0)
                {
                    // Password found, Auth them.
                    errorProvider.Clear();
                    AuthenticateUser();
                }
                else
                {
                    errorProvider.SetError(passwordTextBox, "Missing Password.");
                }
            }
            else
            {
                errorProvider.SetError(usernameTextBox, "Missing Username.");
            }
        }

        private void AuthenticateUser()
        {
            if (String.IsNullOrEmpty(AuthToken) && !GetAuthToken())
            {
                return;
            }

            Username = usernameTextBox.Text;
            if (editorCheck.Checked && !isEditor)
            {
                isEditor = true;
                GetEditors(Username);
                return;
            }
            if (editorCheck.Checked && isEditor)
            {
                Channel = editorDropDown.Text;
            }
            else
            {
                Channel = usernameTextBox.Text;
            }

            // We have a valid Auth Token. Hide the login screen and proceed to the info page.
            tabControl.TabPages.Add(dashboardTab);
            tabControl.TabPages.Remove(loginTab);
            GetUserId();
            GetTitle();
            GetGame();
            GetHidden();
            isLogged = true;
            chatBox.Focus();
            Debug.WriteLine("Recording: " + GetRecordings());


            WSThread = new Thread(() =>
            {
                ws = new WebSocketData(this);
                ws.WebSocketMessage += ws_webSocketMessage;
                userListTimer.Tick += ws.timer_Tick;
            });
            WSThread.Start();
            userListTimer.Start();
        }

        private void HitboxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userListTimer.Stop();
            userListTimer.Dispose();
            if (WSThread != null)
                WSThread.Abort();
        }

        private void restartLabel_Click(object sender, EventArgs e)
        {
            // Restart Button
            Process.Start(Application.ExecutablePath); // to start new instance of application
            Application.Exit();
            Close(); //to turn off current app
        }
    }
}