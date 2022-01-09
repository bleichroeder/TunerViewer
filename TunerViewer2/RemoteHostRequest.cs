using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TunerViewer2
{
    public partial class RemoteHostRequest : Form
    {
        public string HostName { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public RemoteHostRequest()
        {
            InitializeComponent();
        }

        private void RemoteHostRequestConfirmButton_Click(object sender, EventArgs e)
        {
            HostName = RemoteHostRequestHostTextBox.Text;
            User = RemoteHostRequestUserTextBox.Text;
            Password = RemoteHostRequestPasswordTextBox.Text;
        }

        private async void InputWatcher()
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(RemoteHostRequestHostTextBox.Text) && !string.IsNullOrEmpty(RemoteHostRequestUserTextBox.Text) && !string.IsNullOrEmpty(RemoteHostRequestPasswordTextBox.Text))
                {
                    RemoteHostRequestConfirmButton.Enabled = true;
                }
                else
                {
                    RemoteHostRequestConfirmButton.Enabled = false;
                }

                await Task.Delay(10);
            }
        }

        private void RemoteHostRequest_Load(object sender, EventArgs e)
        {
            InputWatcher();
        }
    }
}
