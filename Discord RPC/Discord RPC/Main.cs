using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;

namespace Discord_RPC
{
    public partial class Discord_RPC : Form
    {
        public Discord_RPC()
        {
            InitializeComponent();
        }

		public DiscordRpcClient client;

		private void Discord_RPC_Load(object sender, EventArgs e)
		{
			this.Text += " Beta";
		}

		void Initialize()
		{
			try
            {
				client = new DiscordRpcClient(id.Text);

				//Subscribe to events
				client.OnReady += (sender, e) =>
				{
					Console.WriteLine("Received Ready from user {0}", e.User.Username);
					MessageBox.Show("실행");
				};

				client.OnPresenceUpdate += (sender, e) =>
				{
					Console.WriteLine("Received Update! {0}", e.Presence);
					MessageBox.Show("업데이트");
				};

				client.Initialize();
				client.SetPresence(new RichPresence()
				{
					Details = details.Text,
					State = state.Text,
					Timestamps = new Timestamps(),
					Assets = new Assets()
					{
						LargeImageKey = largeImage.Text,
						LargeImageText = imageText.Text,
						SmallImageKey = smallImage.Text
					}
				}) ;




			}
			catch (Exception e)
            {
				MessageBox.Show(e.Message);
            }

		}

        private void start_Click(object sender, EventArgs e)
        {
			Initialize();
		}

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Discord_RPC_FormClosing(object sender, FormClosingEventArgs e)
        {
			e.Cancel = true;
			this.Hide();

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
			client.Dispose();
		}

    }
}
