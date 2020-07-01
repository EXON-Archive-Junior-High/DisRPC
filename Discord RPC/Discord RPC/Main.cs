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
			this.Text += " v1.0";
			formText.Text += " v1.0";

			shadow.SetShadowForm(this);

			MenuVisible("Main", true);
			MenuVisible("Info", false);
			MenuVisible("Setting", false);

			ChangeTema(true);
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
					MessageBox.Show("Start");
				};

				client.OnPresenceUpdate += (sender, e) =>
				{
					Console.WriteLine("Received Update! {0}", e.Presence);
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
            finally
            {


			}

		}

		private void ChangeTema(bool dark)
        {
			if (dark)
            {
				formText.ForeColor = Color.White;
				this.BackColor = Color.FromArgb(35, 30, 59);

				Bar.BackColor = Color.FromArgb(30, 24, 58);
				MenuBar.BackColor = Color.FromArgb(37, 35, 63);

				Main.BaseColor = Color.FromArgb(37, 35, 63);
				Info.BaseColor = Color.FromArgb(37, 35, 63);
				Setting.BaseColor = Color.FromArgb(37, 35, 63);

				Main.OnHoverBaseColor = Color.FromArgb(30, 24, 58);
				Info.OnHoverBaseColor = Color.FromArgb(30, 24, 58);
				Setting.OnHoverBaseColor = Color.FromArgb(30, 24, 58);

				start.BaseColor1 = Color.FromArgb(30, 24, 58);
				start.BaseColor2 = Color.FromArgb(30, 24, 58);

				stop.BaseColor1 = Color.FromArgb(30, 24, 58);
				stop.BaseColor2 = Color.FromArgb(30, 24, 58);

				start.OnHoverBaseColor1 = Color.FromArgb(30, 24, 58);
				start.OnHoverBaseColor2 = Color.FromArgb(37, 35, 63);

				stop.OnHoverBaseColor1 = Color.FromArgb(30, 24, 58);
				stop.OnHoverBaseColor2 = Color.FromArgb(37, 35, 63);

				label1.ForeColor = Color.White;
				label2.ForeColor = Color.White;
				label3.ForeColor = Color.White;
				label4.ForeColor = Color.White;
				label5.ForeColor = Color.White;
				label6.ForeColor = Color.White;
				label7.ForeColor = Color.White;
				label8.ForeColor = Color.White;
				label9.ForeColor = Color.White;
				label10.ForeColor = Color.White;
				label11.ForeColor = Color.White;

			}
			else if (!dark)
            {
				formText.ForeColor = Color.Black;
				this.BackColor = Color.White;

				Bar.BackColor = Color.FromArgb(241, 239, 241);
				MenuBar.BackColor = Color.FromArgb(160, 159, 160);

				Main.BaseColor = Color.FromArgb(160, 159, 160);
				Info.BaseColor = Color.FromArgb(160, 159, 160);
				Setting.BaseColor = Color.FromArgb(160, 159, 160);

				Main.OnHoverBaseColor = Color.LightGray;
				Info.OnHoverBaseColor = Color.LightGray;
				Setting.OnHoverBaseColor = Color.LightGray;

				start.BaseColor1 = Color.FromArgb(160, 159, 160);
				start.BaseColor2 = Color.FromArgb(160, 159, 160);

				stop.BaseColor1 = Color.FromArgb(160, 159, 160);
				stop.BaseColor2 = Color.FromArgb(160, 159, 160);

				start.OnHoverBaseColor1 = Color.Gray;
				start.OnHoverBaseColor2 = Color.Gray;

				stop.OnHoverBaseColor1 = Color.Gray;
				stop.OnHoverBaseColor2 = Color.Gray;

				label1.ForeColor = Color.Black;
				label2.ForeColor = Color.Black;
				label3.ForeColor = Color.Black;
				label4.ForeColor = Color.Black;
				label5.ForeColor = Color.Black;
				label6.ForeColor = Color.Black;
				label7.ForeColor = Color.Black;
				label8.ForeColor = Color.Black;
				label9.ForeColor = Color.Black;
				label10.ForeColor = Color.Black;
				label11.ForeColor = Color.Black;
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
						label9.Text = "";
						label10.Text = "";
						label11.Text = "";

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
						label8.Text = "Program";
						label9.Text = "DisRPC 는 학생 개발자 엑슨이 개발한 커스텀 디스코드 rpc 프로그램입니다.";
						label10.Text = "Developer";
						label11.Text = "엑슨(EXON) 은 디자인과 프로그래밍을 좋아하는 학생입니다.\n\n" 
							+ "Contact\n"
							+ "Discord : EXON#0062\n"
							+ "Mail : exon.indiv@gmail.com\n";

						Main.Image = Image.FromFile("Image/main.png");
						Info.Image = Image.FromFile("Image/infoBlue.png");
						Setting.Image = Image.FromFile("Image/settingWhite.png");
					}



					break;

				case "Setting":

					if (visible)
					{
						label7.Text = "Setting";
						label8.Text = "Thema";
						label9.Text = "Dark Thema";
						label10.Text = "";
						label11.Text = "";

						Main.Image = Image.FromFile("Image/main.png");
						Setting.Image = Image.FromFile("Image/settingGreen.png");
						Info.Image = Image.FromFile("Image/info.png");
					}
					darkThema.Visible = visible;


					break;

				case "Preview":

					if (visible)
					{
						label7.Text = "Preview";
						label8.Text = "";
						label9.Text = "";
						label10.Text = "";
						label11.Text = "";

						Main.Image = Image.FromFile("Image/main.png");
						Setting.Image = Image.FromFile("Image/settingWhite.png");
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

        private void darkThema_CheckedChanged(object sender, EventArgs e)
        {
			if (darkThema.Checked) {
				ChangeTema(true);
			}
            else
            {
				ChangeTema(false);
			}
        }
    }
}
