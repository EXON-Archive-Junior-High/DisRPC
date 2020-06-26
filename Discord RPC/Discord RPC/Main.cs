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
			formText.Text += " Beta";

			MenuVisible("Main", true);
			MenuVisible("Info", false);
			MenuVisible("Setting", false);
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


		private void MenuVisible(string key, bool visible)
        {
			switch (key)
            {
				case "Main":

					if (visible)
					{
						label7.Text = "Main";
						label8.Text = "RPC";

						Main.Image = Image.FromFile("Image/mainRed.png");
						Info.Image = Image.FromFile("Image/info.png");
						Setting.Image = Image.FromFile("Image/settingWhite.png");
					}

					label1.Visible = visible;
					label2.Visible = visible;
					label3.Visible = visible;
					label4.Visible = visible;
					label5.Visible = visible;
					label6.Visible = visible;

					id.Visible = visible;
					details.Visible = visible;
					state.Visible = visible;
					largeImage.Visible = visible;
					smallImage.Visible = visible;
					imageText.Visible = visible;

					start.Visible = visible;
					stop.Visible = visible;
					break;

				case "Info":

					if (visible)
					{
						label7.Text = "Info";
						label8.Text = "";

						Main.Image = Image.FromFile("Image/main.png");
						Info.Image = Image.FromFile("Image/infoBlue.png");
						Setting.Image = Image.FromFile("Image/settingWhite.png");
					}



					break;

				case "Setting":

					if (visible)
					{
						label7.Text = "Setting";
						label8.Text = "";

						Main.Image = Image.FromFile("Image/main.png");
						Setting.Image = Image.FromFile("Image/settingRed.png");
						Info.Image = Image.FromFile("Image/info.png");
					}



					break;
			}
        }

        private void start_Click(object sender, EventArgs e)
        {
			Initialize();
		}

        private void Discord_RPC_FormClosing(object sender, FormClosingEventArgs e)
        {
			e.Cancel = true;
			this.Hide();

        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
				client.Dispose();
			}
			catch (Exception ex)
            {
				if (ex.Message == "개체 참조가 개체의 인스턴스로 설정되지 않았습니다.")
				{
					MessageBox.Show("먼저 시작을 해주세요");
				}
				else
				{
					MessageBox.Show(ex.Message);
				}
				Console.WriteLine(ex);
            }

		}

        private void Main_Click(object sender, EventArgs e)
        {
			MenuVisible("Main", true);
			MenuVisible("Info", false);
			MenuVisible("Setting", false);
		}

        private void Info_Click(object sender, EventArgs e)
        {
			MenuVisible("Main", false);
			MenuVisible("Info", true);
			MenuVisible("Setting", false);
		}

        private void Setting_Click(object sender, EventArgs e)
        {
			MenuVisible("Main", false);
			MenuVisible("Info", false);
			MenuVisible("Setting", true);
		}
    }
}
