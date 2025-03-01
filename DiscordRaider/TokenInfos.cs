using RaidAPI.Core.Profile;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class TokenInfos : Form
  {
    public static string _Token;
    private string Token;
    private IContainer components;
    private Panel panel11;
    private Label TitleLbl;
    private Button CloseBtn;
    private Panel NamePnl;
    private Label NameLbl;
    private TextBox NameTxt;
    private Panel HashtagPnl;
    private TextBox HashtagTxt;
    private Label HashTagLbl;
    private Panel EmailPnl;
    private TextBox EmailTxt;
    private Label EmailLbl;
    private Panel IdPnl;
    private TextBox IdTxt;
    private Label IdLbl;
    private Panel TypePnl;
    private TextBox TypeTxt;
    private Label TypeLbl;
    private Panel VerifidPnl;
    private TextBox VerifidTxt;
    private Label VerifidLbl;
    private Panel panel16;
    private Timer GetToken;

    public TokenInfos()
    {
      this.InitializeComponent();
      this.ChangeCorners();
      this.Token = TokenInfos._Token;
      ClientInfos.GetInfos(TokenInfos._Token);
      this.GetInfos();
      this.GetToken.Start();
    }

    private void CloseBtn_MouseLeave(object sender, EventArgs e) => this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);

    private void CloseBtn_MouseEnter(object sender, EventArgs e) => this.CloseBtn.BackColor = Color.FromArgb(243, 72, 75);

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

    private void NamePnl_MouseEnter(object sender, EventArgs e) => this.NamePnl.BackColor = Color.FromArgb(57, 60, 69);

    private void NamePnl_MouseLeave(object sender, EventArgs e) => this.NamePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void NameLbl_MouseEnter(object sender, EventArgs e) => this.NamePnl.BackColor = Color.FromArgb(57, 60, 69);

    private void NameLbl_MouseLeave(object sender, EventArgs e) => this.NamePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void NameTxt_MouseEnter(object sender, EventArgs e) => this.NamePnl.BackColor = Color.FromArgb(57, 60, 69);

    private void NameTxt_MouseLeave(object sender, EventArgs e) => this.NamePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void HashTagLbl_MouseEnter(object sender, EventArgs e) => this.HashtagPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void HashTagLbl_MouseLeave(object sender, EventArgs e) => this.HashtagPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void HashtagTxt_MouseEnter(object sender, EventArgs e) => this.HashtagPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void HashtagTxt_MouseLeave(object sender, EventArgs e) => this.HashtagPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void HashtagPnl_MouseEnter(object sender, EventArgs e) => this.HashtagPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void HashtagPnl_MouseLeave(object sender, EventArgs e) => this.HashtagPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void EmailPnl_MouseEnter(object sender, EventArgs e) => this.EmailPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void EmailPnl_MouseLeave(object sender, EventArgs e) => this.EmailPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void EmailLbl_MouseEnter(object sender, EventArgs e) => this.EmailPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void EmailLbl_MouseLeave(object sender, EventArgs e) => this.EmailPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void EmailTxt_MouseEnter(object sender, EventArgs e) => this.EmailPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void EmailTxt_MouseLeave(object sender, EventArgs e) => this.EmailPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void IdPnl_MouseEnter(object sender, EventArgs e) => this.IdPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void IdPnl_MouseLeave(object sender, EventArgs e) => this.IdPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void IdLbl_MouseEnter(object sender, EventArgs e) => this.IdPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void IdLbl_MouseLeave(object sender, EventArgs e) => this.IdPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void IdTxt_MouseEnter(object sender, EventArgs e) => this.IdPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void IdTxt_MouseLeave(object sender, EventArgs e) => this.IdPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void TypePnl_MouseEnter(object sender, EventArgs e) => this.TypePnl.BackColor = Color.FromArgb(57, 60, 69);

    private void TypePnl_MouseLeave(object sender, EventArgs e) => this.TypePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void TypeLbl_MouseEnter(object sender, EventArgs e) => this.TypePnl.BackColor = Color.FromArgb(57, 60, 69);

    private void TypeLbl_MouseLeave(object sender, EventArgs e) => this.TypePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void TypeTxt_MouseEnter(object sender, EventArgs e) => this.TypePnl.BackColor = Color.FromArgb(57, 60, 69);

    private void TypeTxt_MouseLeave(object sender, EventArgs e) => this.TypePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void VerifidPnl_MouseEnter(object sender, EventArgs e) => this.VerifidPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void VerifidPnl_MouseLeave(object sender, EventArgs e) => this.VerifidPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void VerifidLbl_MouseEnter(object sender, EventArgs e) => this.VerifidPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void VerifidLbl_MouseLeave(object sender, EventArgs e) => this.VerifidPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void VerifidTxt_MouseEnter(object sender, EventArgs e) => this.VerifidPnl.BackColor = Color.FromArgb(57, 60, 69);

    private void VerifidTxt_MouseLeave(object sender, EventArgs e) => this.VerifidPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void TokenInfosForm_MouseDown(object sender, MouseEventArgs e)
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

    private void TokenInfosForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void TitleLbl_MouseDown(object sender, MouseEventArgs e)
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

    private void TitleLbl_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void GetToken_Tick(object sender, EventArgs e) => this.GetInfos();

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      TokenSettings._TokenInfos = false;
      this.Close();
    }

    private void TokenInfos_FormClosing(object sender, FormClosingEventArgs e) => TokenSettings._TokenInfos = false;

    public void GetInfos()
    {
      if (TokenInfos._Token == this.Token)
        return;
      try
      {
        ClientInfos.GetInfos(TokenInfos._Token);
        this.Token = TokenInfos._Token;
        this.EmailTxt.Text = ClientInfos._Email;
        this.NameTxt.Text = ClientInfos._Name;
        this.IdTxt.Text = ClientInfos._UserId;
        this.HashtagTxt.Text = ClientInfos._Hashtag;
        this.VerifidTxt.Text = ClientInfos._Verified;
        this.TypeTxt.Text = ClientInfos._AccType;
      }
      catch
      {
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TokenInfos));
      this.panel11 = new Panel();
      this.TitleLbl = new Label();
      this.CloseBtn = new Button();
      this.NamePnl = new Panel();
      this.NameTxt = new TextBox();
      this.NameLbl = new Label();
      this.HashtagPnl = new Panel();
      this.HashtagTxt = new TextBox();
      this.HashTagLbl = new Label();
      this.EmailPnl = new Panel();
      this.EmailTxt = new TextBox();
      this.EmailLbl = new Label();
      this.IdPnl = new Panel();
      this.IdTxt = new TextBox();
      this.IdLbl = new Label();
      this.TypePnl = new Panel();
      this.TypeTxt = new TextBox();
      this.TypeLbl = new Label();
      this.VerifidPnl = new Panel();
      this.VerifidTxt = new TextBox();
      this.VerifidLbl = new Label();
      this.panel16 = new Panel();
      this.GetToken = new Timer(this.components);
      this.NamePnl.SuspendLayout();
      this.HashtagPnl.SuspendLayout();
      this.EmailPnl.SuspendLayout();
      this.IdPnl.SuspendLayout();
      this.TypePnl.SuspendLayout();
      this.VerifidPnl.SuspendLayout();
      this.SuspendLayout();
      this.panel11.BackColor = Color.FromArgb(51, 51, 51);
      this.panel11.Location = new Point(17, 28);
      this.panel11.Name = "panel11";
      this.panel11.Size = new Size(372, 2);
      this.panel11.TabIndex = 6222;
      this.TitleLbl.AutoSize = true;
      this.TitleLbl.Font = new Font("Myanmar Text", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TitleLbl.ForeColor = Color.White;
      this.TitleLbl.Location = new Point((int) sbyte.MaxValue, 4);
      this.TitleLbl.Name = "TitleLbl";
      this.TitleLbl.Size = new Size(141, 29);
      this.TitleLbl.TabIndex = 6221;
      this.TitleLbl.Text = "ACCOUNT INFOS";
      this.TitleLbl.MouseDown += new MouseEventHandler(this.TitleLbl_MouseDown);
      this.TitleLbl.MouseMove += new MouseEventHandler(this.TitleLbl_MouseMove);
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(382, -2);
      this.CloseBtn.Name = "CloseBtn";
      this.CloseBtn.Size = new Size(26, 26);
      this.CloseBtn.TabIndex = 6223;
      this.CloseBtn.Text = "r";
      this.CloseBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseBtn.UseVisualStyleBackColor = false;
      this.CloseBtn.Click += new EventHandler(this.CloseBtn_Click);
      this.CloseBtn.MouseEnter += new EventHandler(this.CloseBtn_MouseEnter);
      this.CloseBtn.MouseLeave += new EventHandler(this.CloseBtn_MouseLeave);
      this.NamePnl.BackColor = Color.FromArgb(49, 50, 55);
      this.NamePnl.Controls.Add((Control) this.NameTxt);
      this.NamePnl.Controls.Add((Control) this.NameLbl);
      this.NamePnl.Location = new Point(16, 44);
      this.NamePnl.Name = "NamePnl";
      this.NamePnl.Size = new Size(182, 52);
      this.NamePnl.TabIndex = 6224;
      this.NamePnl.MouseEnter += new EventHandler(this.NamePnl_MouseEnter);
      this.NamePnl.MouseLeave += new EventHandler(this.NamePnl_MouseLeave);
      this.NameTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.NameTxt.BorderStyle = BorderStyle.None;
      this.NameTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.NameTxt.ForeColor = Color.DarkGray;
      this.NameTxt.Location = new Point(9, 27);
      this.NameTxt.Name = "NameTxt";
      this.NameTxt.Size = new Size(159, 18);
      this.NameTxt.TabIndex = 6226;
      this.NameTxt.Text = "N/A";
      this.NameTxt.MouseEnter += new EventHandler(this.NameTxt_MouseEnter);
      this.NameTxt.MouseLeave += new EventHandler(this.NameTxt_MouseLeave);
      this.NameLbl.AutoSize = true;
      this.NameLbl.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.NameLbl.ForeColor = Color.DarkGray;
      this.NameLbl.Location = new Point(7, 7);
      this.NameLbl.Name = "NameLbl";
      this.NameLbl.Size = new Size(102, 17);
      this.NameLbl.TabIndex = 6225;
      this.NameLbl.Text = "Account Name:";
      this.NameLbl.MouseEnter += new EventHandler(this.NameLbl_MouseEnter);
      this.NameLbl.MouseLeave += new EventHandler(this.NameLbl_MouseLeave);
      this.HashtagPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.HashtagPnl.Controls.Add((Control) this.HashtagTxt);
      this.HashtagPnl.Controls.Add((Control) this.HashTagLbl);
      this.HashtagPnl.Location = new Point(207, 44);
      this.HashtagPnl.Name = "HashtagPnl";
      this.HashtagPnl.Size = new Size(182, 52);
      this.HashtagPnl.TabIndex = 6225;
      this.HashtagPnl.MouseEnter += new EventHandler(this.HashtagPnl_MouseEnter);
      this.HashtagPnl.MouseLeave += new EventHandler(this.HashtagPnl_MouseLeave);
      this.HashtagTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.HashtagTxt.BorderStyle = BorderStyle.None;
      this.HashtagTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.HashtagTxt.ForeColor = Color.DarkGray;
      this.HashtagTxt.Location = new Point(9, 27);
      this.HashtagTxt.Name = "HashtagTxt";
      this.HashtagTxt.Size = new Size(159, 18);
      this.HashtagTxt.TabIndex = 6226;
      this.HashtagTxt.Text = "N/A";
      this.HashtagTxt.MouseEnter += new EventHandler(this.HashtagTxt_MouseEnter);
      this.HashtagTxt.MouseLeave += new EventHandler(this.HashtagTxt_MouseLeave);
      this.HashTagLbl.AutoSize = true;
      this.HashTagLbl.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.HashTagLbl.ForeColor = Color.DarkGray;
      this.HashTagLbl.Location = new Point(7, 7);
      this.HashTagLbl.Name = "HashTagLbl";
      this.HashTagLbl.Size = new Size(117, 17);
      this.HashTagLbl.TabIndex = 6225;
      this.HashTagLbl.Text = "Account Hashtag:";
      this.HashTagLbl.MouseEnter += new EventHandler(this.HashTagLbl_MouseEnter);
      this.HashTagLbl.MouseLeave += new EventHandler(this.HashTagLbl_MouseLeave);
      this.EmailPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.EmailPnl.Controls.Add((Control) this.EmailTxt);
      this.EmailPnl.Controls.Add((Control) this.EmailLbl);
      this.EmailPnl.Location = new Point(16, 105);
      this.EmailPnl.Name = "EmailPnl";
      this.EmailPnl.Size = new Size(182, 52);
      this.EmailPnl.TabIndex = 6226;
      this.EmailPnl.MouseEnter += new EventHandler(this.EmailPnl_MouseEnter);
      this.EmailPnl.MouseLeave += new EventHandler(this.EmailPnl_MouseLeave);
      this.EmailTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.EmailTxt.BorderStyle = BorderStyle.None;
      this.EmailTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmailTxt.ForeColor = Color.DarkGray;
      this.EmailTxt.Location = new Point(9, 27);
      this.EmailTxt.Name = "EmailTxt";
      this.EmailTxt.Size = new Size(159, 18);
      this.EmailTxt.TabIndex = 6226;
      this.EmailTxt.Text = "N/A";
      this.EmailTxt.MouseEnter += new EventHandler(this.EmailTxt_MouseEnter);
      this.EmailTxt.MouseLeave += new EventHandler(this.EmailTxt_MouseLeave);
      this.EmailLbl.AutoSize = true;
      this.EmailLbl.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.EmailLbl.ForeColor = Color.DarkGray;
      this.EmailLbl.Location = new Point(7, 7);
      this.EmailLbl.Name = "EmailLbl";
      this.EmailLbl.Size = new Size(100, 17);
      this.EmailLbl.TabIndex = 6225;
      this.EmailLbl.Text = "Account Email:";
      this.EmailLbl.MouseEnter += new EventHandler(this.EmailLbl_MouseEnter);
      this.EmailLbl.MouseLeave += new EventHandler(this.EmailLbl_MouseLeave);
      this.IdPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.IdPnl.Controls.Add((Control) this.IdTxt);
      this.IdPnl.Controls.Add((Control) this.IdLbl);
      this.IdPnl.Location = new Point(207, 105);
      this.IdPnl.Name = "IdPnl";
      this.IdPnl.Size = new Size(182, 52);
      this.IdPnl.TabIndex = 6227;
      this.IdPnl.MouseEnter += new EventHandler(this.IdPnl_MouseEnter);
      this.IdPnl.MouseLeave += new EventHandler(this.IdPnl_MouseLeave);
      this.IdTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.IdTxt.BorderStyle = BorderStyle.None;
      this.IdTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.IdTxt.ForeColor = Color.DarkGray;
      this.IdTxt.Location = new Point(9, 27);
      this.IdTxt.Name = "IdTxt";
      this.IdTxt.Size = new Size(159, 18);
      this.IdTxt.TabIndex = 6226;
      this.IdTxt.Text = "N/A";
      this.IdTxt.MouseEnter += new EventHandler(this.IdTxt_MouseEnter);
      this.IdTxt.MouseLeave += new EventHandler(this.IdTxt_MouseLeave);
      this.IdLbl.AutoSize = true;
      this.IdLbl.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.IdLbl.ForeColor = Color.DarkGray;
      this.IdLbl.Location = new Point(7, 7);
      this.IdLbl.Name = "IdLbl";
      this.IdLbl.Size = new Size(80, 17);
      this.IdLbl.TabIndex = 6225;
      this.IdLbl.Text = "Account ID:";
      this.IdLbl.MouseEnter += new EventHandler(this.IdLbl_MouseEnter);
      this.IdLbl.MouseLeave += new EventHandler(this.IdLbl_MouseLeave);
      this.TypePnl.BackColor = Color.FromArgb(49, 50, 55);
      this.TypePnl.Controls.Add((Control) this.TypeTxt);
      this.TypePnl.Controls.Add((Control) this.TypeLbl);
      this.TypePnl.Location = new Point(16, 166);
      this.TypePnl.Name = "TypePnl";
      this.TypePnl.Size = new Size(182, 52);
      this.TypePnl.TabIndex = 6228;
      this.TypePnl.MouseEnter += new EventHandler(this.TypePnl_MouseEnter);
      this.TypePnl.MouseLeave += new EventHandler(this.TypePnl_MouseLeave);
      this.TypeTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.TypeTxt.BorderStyle = BorderStyle.None;
      this.TypeTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TypeTxt.ForeColor = Color.DarkGray;
      this.TypeTxt.Location = new Point(9, 27);
      this.TypeTxt.Name = "TypeTxt";
      this.TypeTxt.Size = new Size(159, 18);
      this.TypeTxt.TabIndex = 6226;
      this.TypeTxt.Text = "N/A";
      this.TypeTxt.MouseEnter += new EventHandler(this.TypeTxt_MouseEnter);
      this.TypeTxt.MouseLeave += new EventHandler(this.TypeTxt_MouseLeave);
      this.TypeLbl.AutoSize = true;
      this.TypeLbl.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.TypeLbl.ForeColor = Color.DarkGray;
      this.TypeLbl.Location = new Point(7, 7);
      this.TypeLbl.Name = "TypeLbl";
      this.TypeLbl.Size = new Size(95, 17);
      this.TypeLbl.TabIndex = 6225;
      this.TypeLbl.Text = "Account Type:";
      this.TypeLbl.MouseEnter += new EventHandler(this.TypeLbl_MouseEnter);
      this.TypeLbl.MouseLeave += new EventHandler(this.TypeLbl_MouseLeave);
      this.VerifidPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.VerifidPnl.Controls.Add((Control) this.VerifidTxt);
      this.VerifidPnl.Controls.Add((Control) this.VerifidLbl);
      this.VerifidPnl.Location = new Point(207, 166);
      this.VerifidPnl.Name = "VerifidPnl";
      this.VerifidPnl.Size = new Size(182, 52);
      this.VerifidPnl.TabIndex = 6229;
      this.VerifidPnl.MouseEnter += new EventHandler(this.VerifidPnl_MouseEnter);
      this.VerifidPnl.MouseLeave += new EventHandler(this.VerifidPnl_MouseLeave);
      this.VerifidTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.VerifidTxt.BorderStyle = BorderStyle.None;
      this.VerifidTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.VerifidTxt.ForeColor = Color.DarkGray;
      this.VerifidTxt.Location = new Point(9, 27);
      this.VerifidTxt.Name = "VerifidTxt";
      this.VerifidTxt.Size = new Size(159, 18);
      this.VerifidTxt.TabIndex = 6226;
      this.VerifidTxt.Text = "N/A";
      this.VerifidTxt.MouseEnter += new EventHandler(this.VerifidTxt_MouseEnter);
      this.VerifidTxt.MouseLeave += new EventHandler(this.VerifidTxt_MouseLeave);
      this.VerifidLbl.AutoSize = true;
      this.VerifidLbl.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.VerifidLbl.ForeColor = Color.DarkGray;
      this.VerifidLbl.Location = new Point(7, 7);
      this.VerifidLbl.Name = "VerifidLbl";
      this.VerifidLbl.Size = new Size(107, 17);
      this.VerifidLbl.TabIndex = 6225;
      this.VerifidLbl.Text = "Account Verifid:";
      this.VerifidLbl.MouseEnter += new EventHandler(this.VerifidLbl_MouseEnter);
      this.VerifidLbl.MouseLeave += new EventHandler(this.VerifidLbl_MouseLeave);
      this.panel16.BackColor = Color.FromArgb(51, 51, 51);
      this.panel16.Location = new Point(-3, 233);
      this.panel16.Name = "panel16";
      this.panel16.Size = new Size(978, 2);
      this.panel16.TabIndex = 6230;
      this.GetToken.Tick += new EventHandler(this.GetToken_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(406, 251);
      this.Controls.Add((Control) this.panel16);
      this.Controls.Add((Control) this.VerifidPnl);
      this.Controls.Add((Control) this.TypePnl);
      this.Controls.Add((Control) this.IdPnl);
      this.Controls.Add((Control) this.EmailPnl);
      this.Controls.Add((Control) this.HashtagPnl);
      this.Controls.Add((Control) this.NamePnl);
      this.Controls.Add((Control) this.CloseBtn);
      this.Controls.Add((Control) this.panel11);
      this.Controls.Add((Control) this.TitleLbl);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (TokenInfos);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Discord Raider";
      this.FormClosing += new FormClosingEventHandler(this.TokenInfos_FormClosing);
      this.MouseDown += new MouseEventHandler(this.TokenInfosForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.TokenInfosForm_MouseMove);
      this.NamePnl.ResumeLayout(false);
      this.NamePnl.PerformLayout();
      this.HashtagPnl.ResumeLayout(false);
      this.HashtagPnl.PerformLayout();
      this.EmailPnl.ResumeLayout(false);
      this.EmailPnl.PerformLayout();
      this.IdPnl.ResumeLayout(false);
      this.IdPnl.PerformLayout();
      this.TypePnl.ResumeLayout(false);
      this.TypePnl.PerformLayout();
      this.VerifidPnl.ResumeLayout(false);
      this.VerifidPnl.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
