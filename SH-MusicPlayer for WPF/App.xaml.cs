using System;
using System.Windows;

namespace SH_MusicPlayer_for_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var icon = GetResourceStream(new Uri("icon.ico", UriKind.Relative)).Stream;
            var menu = new System.Windows.Forms.ContextMenuStrip();

            menu.Items.Add("Next", null, Next);
            menu.Items.Add("Back", null, Back);
            menu.Items.Add("Play/Pause", null, Pause_Play);

            menu.Items.Add("終了", null, Exit_Click);

            var notifyIcon = new System.Windows.Forms.NotifyIcon
            {
                Visible = true,
                Icon = new System.Drawing.Icon(icon),
                Text = "SH-MusicPlayer for WPF",
                ContextMenuStrip = menu
            };
            notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(NotifyIcon_Click);
        }

        private void NotifyIcon_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var wnd = new MainWindow();
                wnd.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void Next(object sender, EventArgs e)
        {

        }
        private void Back(object sender, EventArgs e)
        {

        }

        private void Pause_Play(object sender, EventArgs e)
        {

        }
    }
}
