namespace Discord_RPC
{
    partial class Discord_RPC
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discord_RPC));
            this.start = new Guna.UI2.WinForms.Guna2Button();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.details = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.state = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.smallImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.largeImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BorderRadius = 15;
            this.start.CheckedState.Parent = this.start;
            this.start.CustomImages.Parent = this.start;
            this.start.FillColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.start, "start");
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.HoverState.Parent = this.start;
            this.start.Name = "start";
            this.start.PressedColor = System.Drawing.Color.DarkGray;
            this.start.ShadowDecoration.Parent = this.start;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // id
            // 
            this.id.BorderRadius = 15;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.DefaultText = "";
            this.id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.DisabledState.Parent = this.id;
            this.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.FocusedState.Parent = this.id;
            resources.ApplyResources(this.id, "id");
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.HoverState.Parent = this.id;
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderText = "";
            this.id.SelectedText = "";
            this.id.ShadowDecoration.Parent = this.id;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // details
            // 
            this.details.BorderRadius = 15;
            this.details.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.details.DefaultText = "";
            this.details.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.details.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.details.DisabledState.Parent = this.details;
            this.details.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.details.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.details.FocusedState.Parent = this.details;
            resources.ApplyResources(this.details, "details");
            this.details.ForeColor = System.Drawing.Color.Black;
            this.details.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.details.HoverState.Parent = this.details;
            this.details.Name = "details";
            this.details.PasswordChar = '\0';
            this.details.PlaceholderText = "";
            this.details.SelectedText = "";
            this.details.ShadowDecoration.Parent = this.details;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // state
            // 
            this.state.BorderRadius = 15;
            this.state.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.state.DefaultText = "";
            this.state.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.state.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.state.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.state.DisabledState.Parent = this.state;
            this.state.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.state.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.state.FocusedState.Parent = this.state;
            resources.ApplyResources(this.state, "state");
            this.state.ForeColor = System.Drawing.Color.Black;
            this.state.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.state.HoverState.Parent = this.state;
            this.state.Name = "state";
            this.state.PasswordChar = '\0';
            this.state.PlaceholderText = "";
            this.state.SelectedText = "";
            this.state.ShadowDecoration.Parent = this.state;
            this.state.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // smallImage
            // 
            this.smallImage.BorderRadius = 15;
            this.smallImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.smallImage.DefaultText = "";
            this.smallImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.smallImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.smallImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.smallImage.DisabledState.Parent = this.smallImage;
            this.smallImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.smallImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.smallImage.FocusedState.Parent = this.smallImage;
            resources.ApplyResources(this.smallImage, "smallImage");
            this.smallImage.ForeColor = System.Drawing.Color.Black;
            this.smallImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.smallImage.HoverState.Parent = this.smallImage;
            this.smallImage.Name = "smallImage";
            this.smallImage.PasswordChar = '\0';
            this.smallImage.PlaceholderText = "";
            this.smallImage.SelectedText = "";
            this.smallImage.ShadowDecoration.Parent = this.smallImage;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // largeImage
            // 
            this.largeImage.BorderRadius = 15;
            this.largeImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.largeImage.DefaultText = "";
            this.largeImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.largeImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.largeImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.largeImage.DisabledState.Parent = this.largeImage;
            this.largeImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.largeImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.largeImage.FocusedState.Parent = this.largeImage;
            resources.ApplyResources(this.largeImage, "largeImage");
            this.largeImage.ForeColor = System.Drawing.Color.Black;
            this.largeImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.largeImage.HoverState.Parent = this.largeImage;
            this.largeImage.Name = "largeImage";
            this.largeImage.PasswordChar = '\0';
            this.largeImage.PlaceholderText = "";
            this.largeImage.SelectedText = "";
            this.largeImage.ShadowDecoration.Parent = this.largeImage;
            this.largeImage.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // imageText
            // 
            this.imageText.BorderRadius = 15;
            this.imageText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imageText.DefaultText = "";
            this.imageText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.imageText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.imageText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imageText.DisabledState.Parent = this.imageText;
            this.imageText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.imageText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imageText.FocusedState.Parent = this.imageText;
            resources.ApplyResources(this.imageText, "imageText");
            this.imageText.ForeColor = System.Drawing.Color.Black;
            this.imageText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.imageText.HoverState.Parent = this.imageText;
            this.imageText.Name = "imageText";
            this.imageText.PasswordChar = '\0';
            this.imageText.PlaceholderText = "";
            this.imageText.SelectedText = "";
            this.imageText.ShadowDecoration.Parent = this.imageText;
            // 
            // Discord_RPC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imageText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.smallImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.largeImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.details);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.start);
            this.Name = "Discord_RPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Discord_RPC_FormClosing);
            this.Load += new System.EventHandler(this.Discord_RPC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button start;
        private Guna.UI2.WinForms.Guna2TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox details;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox state;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox smallImage;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox largeImage;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox imageText;
    }
}

