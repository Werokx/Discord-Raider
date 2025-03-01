using DiscordRaider.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class Main : Form
  {
    public static bool _SettingsForm;
    public static bool _StealerForm;
    public static bool _SpamForm;
    public static bool _Show;
    private IContainer components;
    private Panel panel14;
    private Panel HeadLinePnl;
    private PictureBox HeadPic;
    private Button ReloadBtn;
    private Button btnClose;
    private Button btnMini;
    private Panel panel2;
    private ComboBox comboBox1;
    private TextBox textBox1;
    private Button button1;
    private Panel panel3;
    private Panel panel5;
    private Panel panel6;
    private PictureBox pictureBox1;
    private Panel InfoPnl;
    private Label label2;
    private Label label5;
    private Panel panel40;
    private Panel HeadExtraPnl;
    private Panel panel42;
    private Label HeadExtraLbl;
    private Panel panel43;
    private ComboBox comboBox6;
    private TextBox textBox9;
    private Button button7;
    private Panel panel44;
    private Panel panel45;
    private Panel panel46;
    private Label InviteLbl;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label1;
    private Label label3;
    private Panel ChoosePnl;
    private Panel panel11;
    private Panel SpamPnl;
    private Panel panel235;
    private Label JoinLeaveLbl;
    private TextBox InfoLbl;
    private Panel panel16;
    private Label ModsHeadline;
    private Panel StealerPnl;
    private Panel panel12;
    private Label TextReactorLbl;
    private Panel RaidPnl;
    private Panel panel1;
    private Label SpammingLbl;
    private Panel SettingsPnl;
    private Panel panel7;
    private Label label9;
    private RoundBtn OpenSettingsBtn;
    private RoundBtn OpenSpamBtn;
    private RoundBtn OpenStealerBtn;
    private RoundBtn OpenRaidBtn;
    private Timer HideUnhide;

    public Main()
    {
      this.InitializeComponent();
      FormSettings.CheckStuff();
      this.ChangeSettingsCorners();
      this.ChangeCorners();
      this.ChangeChoosePnl();
      this.ChangeInfoPnl();
      this.ChangeStealerPnl();
      this.ChangeSpamPnl();
      this.ChangeRaidPnl();
    }

    private void ChangeSpamPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.SpamPnl.Width, this.SpamPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.SpamPnl.Region = new Region(path);
    }

    private void ChangeRaidPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.RaidPnl.Width, this.RaidPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.RaidPnl.Region = new Region(path);
    }

    private void ChangeStealerPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.StealerPnl.Width, this.StealerPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.StealerPnl.Region = new Region(path);
    }

    private void ChangeCorners()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.Region = new Region(path);
    }

    private void ChangeSettingsCorners()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.SettingsPnl.Width, this.SettingsPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.SettingsPnl.Region = new Region(path);
    }

    private void ChangeChoosePnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ChoosePnl.Width, this.ChoosePnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ChoosePnl.Region = new Region(path);
    }

    private void ChangeInfoPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.InfoPnl.Width, this.InfoPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.InfoPnl.Region = new Region(path);
    }

    private void btnClose_Click(object sender, EventArgs e) => Environment.Exit(0);

    private void btnMini_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void ReloadBtn_Click(object sender, EventArgs e) => Application.Restart();

    private void HeadLinePnl_MouseDown(object sender, MouseEventArgs e)
    {
      Point point1 = Control.MousePosition;
      int x1 = point1.X;
      point1 = this.Location;
      int x2 = point1.X;
      Mouse.x = x1 - x2;
      Point point2 = Control.MousePosition;
      int y1 = point2.Y;
      point2 = this.Location;
      int y2 = point2.Y;
      Mouse.y = y1 - y2;
    }

    private void HeadLinePnl_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void HeadPic_MouseDown(object sender, MouseEventArgs e)
    {
      Point point1 = Control.MousePosition;
      int x1 = point1.X;
      point1 = this.Location;
      int x2 = point1.X;
      Mouse.x = x1 - x2;
      Point point2 = Control.MousePosition;
      int y1 = point2.Y;
      point2 = this.Location;
      int y2 = point2.Y;
      Mouse.y = y1 - y2;
    }

    private void HeadPic_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void btnClose_MouseEnter(object sender, EventArgs e) => this.btnClose.BackColor = Color.FromArgb(243, 72, 75);

    private void btnClose_MouseLeave(object sender, EventArgs e) => this.btnClose.BackColor = Color.FromArgb(33, 34, 38);

    private void OpenSpamBtn_Click(object sender, EventArgs e)
    {
      if (Main._SpamForm)
        return;
      Main._SpamForm = true;
      this.HideUnhide.Start();
      this.Hide();
      new SpamMain().Show();
    }

    private void OpenRaidBtn_Click(object sender, EventArgs e)
    {
      int num = (int)MessageBox.Show("Comming in v3.0", "Discord Raider");
    }

    private void OpenStealerBtn_Click(object sender, EventArgs e)
    {
      if (Main._StealerForm)
        return;
      Main._StealerForm = true;
      this.HideUnhide.Start();
      this.Hide();
      new StealerForm().Show();
    }

    private void OpenSettingsBtn_Click(object sender, EventArgs e)
    {
      if (Main._SettingsForm)
        return;
      Main._SettingsForm = true;
      new FormSettings().Show();
    }

    private void SpamPnl_MouseEnter(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "Here you can find everything about Spamming";
      this.SpamPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void SpamPnl_MouseLeave(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "[info]";
      this.SpamPnl.BackColor = Color.FromArgb(49, 50, 55);
    }

    private void RaidPnl_MouseEnter(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "Login into a Bot to Raid some Servers";
      this.RaidPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void RaidPnl_MouseLeave(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "[info]";
      this.RaidPnl.BackColor = Color.FromArgb(49, 50, 55);
    }

    private void StealerPnl_MouseEnter(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "Create a Exe with an Token Stealer";
      this.StealerPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void StealerPnl_MouseLeave(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "[info]";
      this.StealerPnl.BackColor = Color.FromArgb(49, 50, 55);
    }

    private void JoinLeaveLbl_MouseEnter(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "Here you can find everything about Spamming";
      this.SpamPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void JoinLeaveLbl_MouseLeave(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "[info]";
      this.SpamPnl.BackColor = Color.FromArgb(49, 50, 55);
    }

    private void SpammingLbl_MouseEnter(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "Login into a Bot to Raid some Servers";
      this.RaidPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void SpammingLbl_MouseLeave(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "[info]";
      this.RaidPnl.BackColor = Color.FromArgb(49, 50, 55);
    }

    private void TextReactorLbl_MouseEnter(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "Create a Exe with an Token Stealer";
      this.StealerPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void TextReactorLbl_MouseLeave(object sender, EventArgs e)
    {
      this.InfoLbl.Text = "[info]";
      this.StealerPnl.BackColor = Color.FromArgb(49, 50, 55);
    }

    private void InviteLbl_MouseEnter(object sender, EventArgs e) => this.InviteLbl.ForeColor = Color.FromArgb(105, 105, 205);

    private void InviteLbl_MouseLeave(object sender, EventArgs e) => this.InviteLbl.ForeColor = Color.White;

    private void InviteLbl_Click(object sender, EventArgs e) => Process.Start("https://discord.gg/csharp");

    private void HideUnhide_Tick(object sender, EventArgs e)
    {
      if (!Main._Show)
        return;
      this.Show();
      Main._Show = false;
      this.HideUnhide.Stop();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer)new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
      this.panel14 = new Panel();
      this.HeadLinePnl = new Panel();
      this.HeadPic = new PictureBox();
      this.ReloadBtn = new Button();
      this.btnClose = new Button();
      this.btnMini = new Button();
      this.panel2 = new Panel();
      this.comboBox1 = new ComboBox();
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.panel3 = new Panel();
      this.panel5 = new Panel();
      this.panel6 = new Panel();
      this.InfoPnl = new Panel();
      this.InviteLbl = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.label1 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label5 = new Label();
      this.panel40 = new Panel();
      this.HeadExtraPnl = new Panel();
      this.panel42 = new Panel();
      this.HeadExtraLbl = new Label();
      this.panel43 = new Panel();
      this.comboBox6 = new ComboBox();
      this.textBox9 = new TextBox();
      this.button7 = new Button();
      this.panel44 = new Panel();
      this.panel45 = new Panel();
      this.panel46 = new Panel();
      this.ChoosePnl = new Panel();
      this.panel11 = new Panel();
      this.SpamPnl = new Panel();
      this.OpenSpamBtn = new RoundBtn();
      this.panel235 = new Panel();
      this.JoinLeaveLbl = new Label();
      this.InfoLbl = new TextBox();
      this.panel16 = new Panel();
      this.ModsHeadline = new Label();
      this.StealerPnl = new Panel();
      this.OpenStealerBtn = new RoundBtn();
      this.panel12 = new Panel();
      this.TextReactorLbl = new Label();
      this.RaidPnl = new Panel();
      this.OpenRaidBtn = new RoundBtn();
      this.panel1 = new Panel();
      this.SpammingLbl = new Label();
      this.SettingsPnl = new Panel();
      this.panel7 = new Panel();
      this.label9 = new Label();
      this.OpenSettingsBtn = new RoundBtn();
      this.pictureBox1 = new PictureBox();
      this.HideUnhide = new Timer(this.components);
      this.HeadLinePnl.SuspendLayout();
      ((ISupportInitialize)this.HeadPic).BeginInit();
      this.InfoPnl.SuspendLayout();
      this.HeadExtraPnl.SuspendLayout();
      this.ChoosePnl.SuspendLayout();
      this.SpamPnl.SuspendLayout();
      this.StealerPnl.SuspendLayout();
      this.RaidPnl.SuspendLayout();
      this.SettingsPnl.SuspendLayout();
      ((ISupportInitialize)this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.panel14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.panel14.BackColor = Color.FromArgb(33, 34, 38);
      this.panel14.Location = new Point(-1506, 257);
      this.panel14.Name = "panel14";
      this.panel14.Size = new Size(3813, 2);
      this.panel14.TabIndex = 6302;
      this.HeadLinePnl.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnl.Controls.Add((Control)this.HeadPic);
      this.HeadLinePnl.Controls.Add((Control)this.ReloadBtn);
      this.HeadLinePnl.Controls.Add((Control)this.btnClose);
      this.HeadLinePnl.Controls.Add((Control)this.btnMini);
      this.HeadLinePnl.Controls.Add((Control)this.panel2);
      this.HeadLinePnl.Controls.Add((Control)this.comboBox1);
      this.HeadLinePnl.Controls.Add((Control)this.textBox1);
      this.HeadLinePnl.Controls.Add((Control)this.button1);
      this.HeadLinePnl.Controls.Add((Control)this.panel3);
      this.HeadLinePnl.Controls.Add((Control)this.panel5);
      this.HeadLinePnl.Controls.Add((Control)this.panel6);
      this.HeadLinePnl.Dock = DockStyle.Top;
      this.HeadLinePnl.Location = new Point(0, 0);
      this.HeadLinePnl.Name = "HeadLinePnl";
      this.HeadLinePnl.Size = new Size(569, 21);
      this.HeadLinePnl.TabIndex = 6301;
      this.HeadLinePnl.MouseDown += new MouseEventHandler(this.HeadLinePnl_MouseDown);
      this.HeadLinePnl.MouseMove += new MouseEventHandler(this.HeadLinePnl_MouseMove);
      this.HeadPic.Image = (Image)Resources.DiscordRaider;
      this.HeadPic.Location = new Point(4, 1);
      this.HeadPic.Name = "HeadPic";
      this.HeadPic.Size = new Size(106, 19);
      this.HeadPic.SizeMode = PictureBoxSizeMode.Zoom;
      this.HeadPic.TabIndex = 6190;
      this.HeadPic.TabStop = false;
      this.HeadPic.MouseDown += new MouseEventHandler(this.HeadPic_MouseDown);
      this.HeadPic.MouseMove += new MouseEventHandler(this.HeadPic_MouseMove);
      this.ReloadBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.ReloadBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.ReloadBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.ReloadBtn.FlatAppearance.BorderSize = 0;
      this.ReloadBtn.FlatStyle = FlatStyle.Flat;
      this.ReloadBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.ReloadBtn.ForeColor = Color.White;
      this.ReloadBtn.Location = new Point(493, -2);
      this.ReloadBtn.Name = "ReloadBtn";
      this.ReloadBtn.Size = new Size(26, 27);
      this.ReloadBtn.TabIndex = 6165;
      this.ReloadBtn.Text = "q";
      this.ReloadBtn.TextAlign = ContentAlignment.TopCenter;
      this.ReloadBtn.UseVisualStyleBackColor = false;
      this.ReloadBtn.Click += new EventHandler(this.ReloadBtn_Click);
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnClose.BackColor = Color.FromArgb(33, 34, 38);
      this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = FlatStyle.Flat;
      this.btnClose.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.btnClose.ForeColor = Color.White;
      this.btnClose.Location = new Point(544, -3);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(26, 27);
      this.btnClose.TabIndex = 6162;
      this.btnClose.Text = "r";
      this.btnClose.TextAlign = ContentAlignment.TopCenter;
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnClose.MouseEnter += new EventHandler(this.btnClose_MouseEnter);
      this.btnClose.MouseLeave += new EventHandler(this.btnClose_MouseLeave);
      this.btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnMini.BackColor = Color.FromArgb(33, 34, 38);
      this.btnMini.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.btnMini.FlatAppearance.BorderSize = 0;
      this.btnMini.FlatStyle = FlatStyle.Flat;
      this.btnMini.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.btnMini.ForeColor = Color.White;
      this.btnMini.Location = new Point(518, -3);
      this.btnMini.Name = "btnMini";
      this.btnMini.Size = new Size(26, 27);
      this.btnMini.TabIndex = 6161;
      this.btnMini.Text = "0";
      this.btnMini.TextAlign = ContentAlignment.TopCenter;
      this.btnMini.UseVisualStyleBackColor = false;
      this.btnMini.Click += new EventHandler(this.btnMini_Click);
      this.panel2.BackColor = Color.FromArgb(51, 51, 51);
      this.panel2.Font = new Font("Segoe UI", 9f);
      this.panel2.Location = new Point(362, -44);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(2, 25);
      this.panel2.TabIndex = 6160;
      this.comboBox1.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox1.ForeColor = Color.Silver;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(364, -44);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(254, 25);
      this.comboBox1.TabIndex = 6154;
      this.textBox1.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.textBox1.ForeColor = Color.White;
      this.textBox1.Location = new Point(364, -42);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(231, 21);
      this.textBox1.TabIndex = 6156;
      this.textBox1.Text = " Voice Channel";
      this.button1.BackColor = Color.FromArgb(25, 25, 25);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
      this.button1.ForeColor = Color.Silver;
      this.button1.Location = new Point(594, -43);
      this.button1.Name = "button1";
      this.button1.Size = new Size(25, 22);
      this.button1.TabIndex = 6155;
      this.button1.Text = "6";
      this.button1.UseVisualStyleBackColor = false;
      this.panel3.BackColor = Color.FromArgb(51, 51, 51);
      this.panel3.Font = new Font("Segoe UI", 9f);
      this.panel3.Location = new Point(364, -21);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(254, 2);
      this.panel3.TabIndex = 6157;
      this.panel5.BackColor = Color.FromArgb(51, 51, 51);
      this.panel5.Font = new Font("Segoe UI", 9f);
      this.panel5.Location = new Point(364, -44);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(254, 2);
      this.panel5.TabIndex = 6158;
      this.panel6.BackColor = Color.FromArgb(51, 51, 51);
      this.panel6.Font = new Font("Segoe UI", 9f);
      this.panel6.Location = new Point(617, -44);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(2, 25);
      this.panel6.TabIndex = 6159;
      this.InfoPnl.BackColor = Color.FromArgb(35, 36, 41);
      this.InfoPnl.Controls.Add((Control)this.InviteLbl);
      this.InfoPnl.Controls.Add((Control)this.label6);
      this.InfoPnl.Controls.Add((Control)this.label7);
      this.InfoPnl.Controls.Add((Control)this.label8);
      this.InfoPnl.Controls.Add((Control)this.label1);
      this.InfoPnl.Controls.Add((Control)this.label3);
      this.InfoPnl.Controls.Add((Control)this.label2);
      this.InfoPnl.Controls.Add((Control)this.label5);
      this.InfoPnl.Controls.Add((Control)this.panel40);
      this.InfoPnl.Controls.Add((Control)this.HeadExtraPnl);
      this.InfoPnl.Location = new Point(305, 35);
      this.InfoPnl.Name = "InfoPnl";
      this.InfoPnl.Size = new Size(250, 157);
      this.InfoPnl.TabIndex = 6305;
      this.InviteLbl.AutoSize = true;
      this.InviteLbl.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.InviteLbl.ForeColor = Color.White;
      this.InviteLbl.Location = new Point(151, 102);
      this.InviteLbl.Name = "InviteLbl";
      this.InviteLbl.Size = new Size(76, 17);
      this.InviteLbl.TabIndex = 6291;
      this.InviteLbl.Text = "PRESS ME";
      this.InviteLbl.Click += new EventHandler(this.InviteLbl_Click);
      this.InviteLbl.MouseEnter += new EventHandler(this.InviteLbl_MouseEnter);
      this.InviteLbl.MouseLeave += new EventHandler(this.InviteLbl_MouseLeave);
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label6.ForeColor = Color.Silver;
      this.label6.Location = new Point(151, 85);
      this.label6.Name = "label6";
      this.label6.Size = new Size(77, 17);
      this.label6.TabIndex = 6290;
      this.label6.Text = "Get Source:";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label7.ForeColor = Color.White;
      this.label7.Location = new Point(12, 102);
      this.label7.Name = "label7";
      this.label7.Size = new Size(98, 17);
      this.label7.TabIndex = 6289;
      this.label7.Text = "Pretty, Chavo";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label8.ForeColor = Color.Silver;
      this.label8.Location = new Point(12, 85);
      this.label8.Name = "label8";
      this.label8.Size = new Size(104, 17);
      this.label8.TabIndex = 6288;
      this.label8.Text = "Creator Friends:";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(151, 60);
      this.label1.Name = "label1";
      this.label1.Size = new Size(73, 17);
      this.label1.TabIndex = 6287;
      this.label1.Text = "Unknown";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label3.ForeColor = Color.Silver;
      this.label3.Location = new Point(151, 43);
      this.label3.Name = "label3";
      this.label3.Size = new Size(86, 17);
      this.label3.TabIndex = 6286;
      this.label3.Text = "Tool Creator:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(12, 60);
      this.label2.Name = "label2";
      this.label2.Size = new Size(111, 17);
      this.label2.TabIndex = 6285;
      this.label2.Text = "2.4";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label5.ForeColor = Color.Silver;
      this.label5.Location = new Point(12, 43);
      this.label5.Name = "label5";
      this.label5.Size = new Size(105, 17);
      this.label5.TabIndex = 6284;
      this.label5.Text = "Current Version:";
      this.panel40.BackColor = Color.FromArgb(51, 51, 51);
      this.panel40.Location = new Point(-1, 137);
      this.panel40.Name = "panel40";
      this.panel40.Size = new Size(387, 2);
      this.panel40.TabIndex = 6283;
      this.HeadExtraPnl.BackColor = Color.FromArgb(35, 36, 41);
      this.HeadExtraPnl.Controls.Add((Control)this.panel42);
      this.HeadExtraPnl.Controls.Add((Control)this.HeadExtraLbl);
      this.HeadExtraPnl.Controls.Add((Control)this.panel43);
      this.HeadExtraPnl.Controls.Add((Control)this.comboBox6);
      this.HeadExtraPnl.Controls.Add((Control)this.textBox9);
      this.HeadExtraPnl.Controls.Add((Control)this.button7);
      this.HeadExtraPnl.Controls.Add((Control)this.panel44);
      this.HeadExtraPnl.Controls.Add((Control)this.panel45);
      this.HeadExtraPnl.Controls.Add((Control)this.panel46);
      this.HeadExtraPnl.Dock = DockStyle.Top;
      this.HeadExtraPnl.Location = new Point(0, 0);
      this.HeadExtraPnl.Name = "HeadExtraPnl";
      this.HeadExtraPnl.Size = new Size(250, 29);
      this.HeadExtraPnl.TabIndex = 6282;
      this.panel42.BackColor = Color.FromArgb(51, 51, 51);
      this.panel42.Location = new Point(15, 24);
      this.panel42.Name = "panel42";
      this.panel42.Size = new Size(222, 2);
      this.panel42.TabIndex = 6222;
      this.HeadExtraLbl.AutoSize = true;
      this.HeadExtraLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.HeadExtraLbl.ForeColor = Color.White;
      this.HeadExtraLbl.Location = new Point(66, 3);
      this.HeadExtraLbl.Name = "HeadExtraLbl";
      this.HeadExtraLbl.Size = new Size(118, 21);
      this.HeadExtraLbl.TabIndex = 6166;
      this.HeadExtraLbl.Text = "RAIDER INFOS";
      this.panel43.BackColor = Color.FromArgb(51, 51, 51);
      this.panel43.Font = new Font("Segoe UI", 9f);
      this.panel43.Location = new Point(362, -44);
      this.panel43.Name = "panel43";
      this.panel43.Size = new Size(2, 25);
      this.panel43.TabIndex = 6160;
      this.comboBox6.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox6.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox6.ForeColor = Color.Silver;
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Location = new Point(364, -44);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(254, 25);
      this.comboBox6.TabIndex = 6154;
      this.textBox9.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox9.BorderStyle = BorderStyle.None;
      this.textBox9.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.textBox9.ForeColor = Color.White;
      this.textBox9.Location = new Point(364, -42);
      this.textBox9.Multiline = true;
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(231, 21);
      this.textBox9.TabIndex = 6156;
      this.textBox9.Text = " Voice Channel";
      this.button7.BackColor = Color.FromArgb(25, 25, 25);
      this.button7.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
      this.button7.ForeColor = Color.Silver;
      this.button7.Location = new Point(594, -43);
      this.button7.Name = "button7";
      this.button7.Size = new Size(25, 22);
      this.button7.TabIndex = 6155;
      this.button7.Text = "6";
      this.button7.UseVisualStyleBackColor = false;
      this.panel44.BackColor = Color.FromArgb(51, 51, 51);
      this.panel44.Font = new Font("Segoe UI", 9f);
      this.panel44.Location = new Point(364, -21);
      this.panel44.Name = "panel44";
      this.panel44.Size = new Size(254, 2);
      this.panel44.TabIndex = 6157;
      this.panel45.BackColor = Color.FromArgb(51, 51, 51);
      this.panel45.Font = new Font("Segoe UI", 9f);
      this.panel45.Location = new Point(364, -44);
      this.panel45.Name = "panel45";
      this.panel45.Size = new Size(254, 2);
      this.panel45.TabIndex = 6158;
      this.panel46.BackColor = Color.FromArgb(51, 51, 51);
      this.panel46.Font = new Font("Segoe UI", 9f);
      this.panel46.Location = new Point(617, -44);
      this.panel46.Name = "panel46";
      this.panel46.Size = new Size(2, 25);
      this.panel46.TabIndex = 6159;
      this.ChoosePnl.BackColor = Color.FromArgb(33, 34, 38);
      this.ChoosePnl.Controls.Add((Control)this.panel11);
      this.ChoosePnl.Controls.Add((Control)this.SpamPnl);
      this.ChoosePnl.Controls.Add((Control)this.InfoLbl);
      this.ChoosePnl.Controls.Add((Control)this.panel16);
      this.ChoosePnl.Controls.Add((Control)this.ModsHeadline);
      this.ChoosePnl.Controls.Add((Control)this.StealerPnl);
      this.ChoosePnl.Controls.Add((Control)this.RaidPnl);
      this.ChoosePnl.Location = new Point(13, 35);
      this.ChoosePnl.Name = "ChoosePnl";
      this.ChoosePnl.Size = new Size(276, 207);
      this.ChoosePnl.TabIndex = 6306;
      this.panel11.BackColor = Color.FromArgb(51, 51, 51);
      this.panel11.Location = new Point(13, 28);
      this.panel11.Name = "panel11";
      this.panel11.Size = new Size(249, 2);
      this.panel11.TabIndex = 6220;
      this.SpamPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.SpamPnl.Controls.Add((Control)this.OpenSpamBtn);
      this.SpamPnl.Controls.Add((Control)this.panel235);
      this.SpamPnl.Controls.Add((Control)this.JoinLeaveLbl);
      this.SpamPnl.Location = new Point(13, 42);
      this.SpamPnl.Name = "SpamPnl";
      this.SpamPnl.Size = new Size(249, 36);
      this.SpamPnl.TabIndex = 6167;
      this.SpamPnl.MouseEnter += new EventHandler(this.SpamPnl_MouseEnter);
      this.SpamPnl.MouseLeave += new EventHandler(this.SpamPnl_MouseLeave);
      this.OpenSpamBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenSpamBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenSpamBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenSpamBtn.FlatAppearance.BorderSize = 0;
      this.OpenSpamBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenSpamBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenSpamBtn.FlatStyle = FlatStyle.Flat;
      this.OpenSpamBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenSpamBtn.Location = new Point(161, 6);
      this.OpenSpamBtn.Name = "OpenSpamBtn";
      this.OpenSpamBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenSpamBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenSpamBtn.OnHoverTextColor = Color.White;
      this.OpenSpamBtn.Size = new Size(81, 24);
      this.OpenSpamBtn.TabIndex = 6313;
      this.OpenSpamBtn.Text = "OPEN";
      this.OpenSpamBtn.TextColor = Color.White;
      this.OpenSpamBtn.UseVisualStyleBackColor = true;
      this.OpenSpamBtn.Click += new EventHandler(this.OpenSpamBtn_Click);
      this.panel235.BackColor = Color.FromArgb(56, 56, 56);
      this.panel235.Location = new Point(153, 0);
      this.panel235.Name = "panel235";
      this.panel235.Size = new Size(3, 148);
      this.panel235.TabIndex = 6276;
      this.JoinLeaveLbl.AutoSize = true;
      this.JoinLeaveLbl.BackColor = Color.Transparent;
      this.JoinLeaveLbl.Font = new Font("Impact", 11.25f);
      this.JoinLeaveLbl.ForeColor = Color.Silver;
      this.JoinLeaveLbl.Location = new Point(9, 8);
      this.JoinLeaveLbl.Name = "JoinLeaveLbl";
      this.JoinLeaveLbl.Size = new Size(85, 19);
      this.JoinLeaveLbl.TabIndex = 6275;
      this.JoinLeaveLbl.Text = "SPAM CLIENT";
      this.JoinLeaveLbl.MouseEnter += new EventHandler(this.JoinLeaveLbl_MouseEnter);
      this.JoinLeaveLbl.MouseLeave += new EventHandler(this.JoinLeaveLbl_MouseLeave);
      this.InfoLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.InfoLbl.BackColor = Color.FromArgb(33, 34, 38);
      this.InfoLbl.BorderStyle = BorderStyle.None;
      this.InfoLbl.Enabled = false;
      this.InfoLbl.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfoLbl.ForeColor = Color.Silver;
      this.InfoLbl.Location = new Point(0, 187);
      this.InfoLbl.Name = "InfoLbl";
      this.InfoLbl.Size = new Size(273, 16);
      this.InfoLbl.TabIndex = 6219;
      this.InfoLbl.Text = "[info]";
      this.InfoLbl.TextAlign = HorizontalAlignment.Center;
      this.panel16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.panel16.BackColor = Color.FromArgb(51, 51, 51);
      this.panel16.Location = new Point(-3, 182);
      this.panel16.Name = "panel16";
      this.panel16.Size = new Size(278, 2);
      this.panel16.TabIndex = 6173;
      this.ModsHeadline.AutoSize = true;
      this.ModsHeadline.Font = new Font("Myanmar Text", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ModsHeadline.ForeColor = Color.White;
      this.ModsHeadline.Location = new Point(57, 4);
      this.ModsHeadline.Name = "ModsHeadline";
      this.ModsHeadline.Size = new Size(170, 29);
      this.ModsHeadline.TabIndex = 6165;
      this.ModsHeadline.Text = "CHOOSE YOUR TOOL";
      this.StealerPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.StealerPnl.Controls.Add((Control)this.OpenStealerBtn);
      this.StealerPnl.Controls.Add((Control)this.panel12);
      this.StealerPnl.Controls.Add((Control)this.TextReactorLbl);
      this.StealerPnl.Location = new Point(13, 132);
      this.StealerPnl.Name = "StealerPnl";
      this.StealerPnl.Size = new Size(249, 36);
      this.StealerPnl.TabIndex = 6169;
      this.StealerPnl.MouseEnter += new EventHandler(this.StealerPnl_MouseEnter);
      this.StealerPnl.MouseLeave += new EventHandler(this.StealerPnl_MouseLeave);
      this.OpenStealerBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenStealerBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenStealerBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenStealerBtn.FlatAppearance.BorderSize = 0;
      this.OpenStealerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenStealerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenStealerBtn.FlatStyle = FlatStyle.Flat;
      this.OpenStealerBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenStealerBtn.Location = new Point(161, 6);
      this.OpenStealerBtn.Name = "OpenStealerBtn";
      this.OpenStealerBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenStealerBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenStealerBtn.OnHoverTextColor = Color.White;
      this.OpenStealerBtn.Size = new Size(81, 24);
      this.OpenStealerBtn.TabIndex = 6311;
      this.OpenStealerBtn.Text = "OPEN";
      this.OpenStealerBtn.TextColor = Color.White;
      this.OpenStealerBtn.UseVisualStyleBackColor = true;
      this.OpenStealerBtn.Click += new EventHandler(this.OpenStealerBtn_Click);
      this.panel12.BackColor = Color.FromArgb(56, 56, 56);
      this.panel12.Location = new Point(153, 0);
      this.panel12.Name = "panel12";
      this.panel12.Size = new Size(3, 148);
      this.panel12.TabIndex = 6277;
      this.TextReactorLbl.AutoSize = true;
      this.TextReactorLbl.BackColor = Color.Transparent;
      this.TextReactorLbl.Font = new Font("Impact", 11.25f);
      this.TextReactorLbl.ForeColor = Color.Silver;
      this.TextReactorLbl.Location = new Point(9, 8);
      this.TextReactorLbl.Name = "TextReactorLbl";
      this.TextReactorLbl.Size = new Size(97, 19);
      this.TextReactorLbl.TabIndex = 6276;
      this.TextReactorLbl.Text = "TOKEN STEALER";
      this.TextReactorLbl.MouseEnter += new EventHandler(this.TextReactorLbl_MouseEnter);
      this.TextReactorLbl.MouseLeave += new EventHandler(this.TextReactorLbl_MouseLeave);
      this.RaidPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.RaidPnl.Controls.Add((Control)this.OpenRaidBtn);
      this.RaidPnl.Controls.Add((Control)this.panel1);
      this.RaidPnl.Controls.Add((Control)this.SpammingLbl);
      this.RaidPnl.Location = new Point(13, 87);
      this.RaidPnl.Name = "RaidPnl";
      this.RaidPnl.Size = new Size(249, 36);
      this.RaidPnl.TabIndex = 6168;
      this.RaidPnl.MouseEnter += new EventHandler(this.RaidPnl_MouseEnter);
      this.RaidPnl.MouseLeave += new EventHandler(this.RaidPnl_MouseLeave);
      this.OpenRaidBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenRaidBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenRaidBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenRaidBtn.FlatAppearance.BorderSize = 0;
      this.OpenRaidBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenRaidBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenRaidBtn.FlatStyle = FlatStyle.Flat;
      this.OpenRaidBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenRaidBtn.Location = new Point(161, 6);
      this.OpenRaidBtn.Name = "OpenRaidBtn";
      this.OpenRaidBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenRaidBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenRaidBtn.OnHoverTextColor = Color.White;
      this.OpenRaidBtn.Size = new Size(81, 24);
      this.OpenRaidBtn.TabIndex = 6312;
      this.OpenRaidBtn.Text = "OPEN";
      this.OpenRaidBtn.TextColor = Color.White;
      this.OpenRaidBtn.UseVisualStyleBackColor = true;
      this.OpenRaidBtn.Click += new EventHandler(this.OpenRaidBtn_Click);
      this.panel1.BackColor = Color.FromArgb(56, 56, 56);
      this.panel1.Location = new Point(153, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(3, 148);
      this.panel1.TabIndex = 6277;
      this.SpammingLbl.AutoSize = true;
      this.SpammingLbl.BackColor = Color.Transparent;
      this.SpammingLbl.Font = new Font("Impact", 11.25f);
      this.SpammingLbl.ForeColor = Color.Silver;
      this.SpammingLbl.Location = new Point(9, 8);
      this.SpammingLbl.Name = "SpammingLbl";
      this.SpammingLbl.Size = new Size(78, 19);
      this.SpammingLbl.TabIndex = 6276;
      this.SpammingLbl.Text = "RAID CLIENT";
      this.SpammingLbl.MouseEnter += new EventHandler(this.SpammingLbl_MouseEnter);
      this.SpammingLbl.MouseLeave += new EventHandler(this.SpammingLbl_MouseLeave);
      this.SettingsPnl.BackColor = Color.FromArgb(35, 36, 41);
      this.SettingsPnl.Controls.Add((Control)this.panel7);
      this.SettingsPnl.Controls.Add((Control)this.label9);
      this.SettingsPnl.Controls.Add((Control)this.OpenSettingsBtn);
      this.SettingsPnl.Location = new Point(304, 206);
      this.SettingsPnl.Name = "SettingsPnl";
      this.SettingsPnl.Size = new Size(251, 36);
      this.SettingsPnl.TabIndex = 6307;
      this.panel7.BackColor = Color.FromArgb(56, 56, 56);
      this.panel7.Location = new Point(153, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(3, 148);
      this.panel7.TabIndex = 6276;
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Impact", 11.25f);
      this.label9.ForeColor = Color.Silver;
      this.label9.Location = new Point(9, 8);
      this.label9.Name = "label9";
      this.label9.Size = new Size(107, 19);
      this.label9.TabIndex = 6275;
      this.label9.Text = "CLIENT SETTINGS";
      this.OpenSettingsBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenSettingsBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenSettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 41);
      this.OpenSettingsBtn.FlatAppearance.BorderSize = 0;
      this.OpenSettingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 36, 41);
      this.OpenSettingsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 36, 41);
      this.OpenSettingsBtn.FlatStyle = FlatStyle.Flat;
      this.OpenSettingsBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenSettingsBtn.Location = new Point(161, 6);
      this.OpenSettingsBtn.Name = "OpenSettingsBtn";
      this.OpenSettingsBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenSettingsBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenSettingsBtn.OnHoverTextColor = Color.White;
      this.OpenSettingsBtn.Size = new Size(81, 23);
      this.OpenSettingsBtn.TabIndex = 6310;
      this.OpenSettingsBtn.Text = "OPEN";
      this.OpenSettingsBtn.TextColor = Color.White;
      this.OpenSettingsBtn.UseVisualStyleBackColor = true;
      this.OpenSettingsBtn.Click += new EventHandler(this.OpenSettingsBtn_Click);
      this.pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.pictureBox1.Image = (Image)Resources.PoweredByByteTools;
      this.pictureBox1.Location = new Point(420, 259);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(147, 19);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6304;
      this.pictureBox1.TabStop = false;
      this.HideUnhide.Tick += new EventHandler(this.HideUnhide_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(25, 25, 25);
      this.ClientSize = new Size(569, 277);
      this.Controls.Add((Control)this.SettingsPnl);
      this.Controls.Add((Control)this.ChoosePnl);
      this.Controls.Add((Control)this.InfoPnl);
      this.Controls.Add((Control)this.pictureBox1);
      this.Controls.Add((Control)this.panel14);
      this.Controls.Add((Control)this.HeadLinePnl);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof(Main);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Discord Raider";
      this.HeadLinePnl.ResumeLayout(false);
      this.HeadLinePnl.PerformLayout();
      ((ISupportInitialize)this.HeadPic).EndInit();
      this.InfoPnl.ResumeLayout(false);
      this.InfoPnl.PerformLayout();
      this.HeadExtraPnl.ResumeLayout(false);
      this.HeadExtraPnl.PerformLayout();
      this.ChoosePnl.ResumeLayout(false);
      this.ChoosePnl.PerformLayout();
      this.SpamPnl.ResumeLayout(false);
      this.SpamPnl.PerformLayout();
      this.StealerPnl.ResumeLayout(false);
      this.StealerPnl.PerformLayout();
      this.RaidPnl.ResumeLayout(false);
      this.RaidPnl.PerformLayout();
      this.SettingsPnl.ResumeLayout(false);
      this.SettingsPnl.PerformLayout();
      ((ISupportInitialize)this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
