using RaidAPI.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class ChangeNick : Form
  {
    private IContainer components;
    private Panel NickPnl;
    private Panel panel18;
    private TextBox NickTxt;
    private Panel panel37;
    private Panel HeadLinePnlInf;
    private Panel panel24;
    private Button CloseBtn;
    private Label HeadServerLbl;
    private Panel panel25;
    private ComboBox comboBox3;
    private TextBox textBox3;
    private Button button4;
    private Panel panel26;
    private Panel panel27;
    private Panel panel36;
    private Button Icon1;
    private Button Icon2;
    private Button Icon3;
    private Button Icon6;
    private Button Icon5;
    private Button Icon4;
    private Button Icon8;
    private Button Icon7;
    private NotifyIcon WinInfo;
    private RoundBtn SetNickBtn;

    public ChangeNick()
    {
      this.InitializeComponent();
      this.ModDesign();
      this.ChangeNickPnl();
      this.NickTxt.Text = SpamMain._NickTxt;
      ServerInfos._Token = "NTYyMzUyMDkwOTU0MDcyMDk4.XKJhaw._fUZ2Dq5V9_Jwn4L-tvY3H-4Oio";
      this.GetServerID(SpamMain._Invite);
    }

    private void GetServerID(string MyInvite)
    {
      try
      {
        if (MyInvite == "" || MyInvite == "Discord Invite")
        {
          int num = (int) MessageBox.Show("Enter first a Invite", "Discord Raider");
          SpamMain._Invite = "";
          this.Close();
        }
        else
        {
          string _Invite = MyInvite.Replace("https://discord.gg/", "");
          if (_Invite == "")
          {
            ServerInfos.Serverid = "";
          }
          else
          {
            ServerInfos.StartGetInfos(_Invite);
            SpamMain._ServerIDByJoin = ServerInfos.Serverid;
          }
        }
      }
      catch
      {
      }
    }

    private void ChangeNickPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.NickPnl.Width, this.NickPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.NickPnl.Region = new Region(path);
    }

    private void ModDesign()
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

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      SpamMain._ChangeNick = false;
      this.Close();
    }

    private void Icon1_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon1.Text;

    private void Icon2_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon2.Text;

    private void Icon3_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon3.Text;

    private void Icon4_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon4.Text;

    private void Icon5_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon5.Text;

    private void Icon6_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon6.Text;

    private void Icon7_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon7.Text;

    private void Icon8_Click(object sender, EventArgs e) => this.NickTxt.Text = this.NickTxt.Text + " " + this.Icon8.Text;

    private void SetNickBtn_Click(object sender, EventArgs e)
    {
      SpamMain._NickTxt = this.NickTxt.Text;
      SpamMain._NewNick = this.NickTxt.Text;
      SpamMain._ChangeNickByJoin = true;
      this.WinInfo.Visible = true;
      this.WinInfo.BalloonTipText = "New Nick Set!";
      this.WinInfo.ShowBalloonTip(1000);
    }

    private void HeadServerLbl_MouseDown(object sender, MouseEventArgs e)
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

    private void HeadServerLbl_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void HeadLinePnlInf_MouseDown(object sender, MouseEventArgs e)
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

    private void HeadLinePnlInf_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void ChangeNick_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._ChangeNick = false;

    private void NickTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.NickTxt.Text == "Nick Name"))
        return;
      this.NickTxt.Text = "";
      this.NickTxt.ForeColor = Color.White;
    }

    private void NickTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.NickTxt.Text == ""))
        return;
      this.NickTxt.Text = "Nick Name";
      this.NickTxt.ForeColor = Color.Silver;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ChangeNick));
      this.NickPnl = new Panel();
      this.panel18 = new Panel();
      this.NickTxt = new TextBox();
      this.SetNickBtn = new RoundBtn();
      this.panel37 = new Panel();
      this.HeadLinePnlInf = new Panel();
      this.panel24 = new Panel();
      this.CloseBtn = new Button();
      this.HeadServerLbl = new Label();
      this.panel25 = new Panel();
      this.comboBox3 = new ComboBox();
      this.textBox3 = new TextBox();
      this.button4 = new Button();
      this.panel26 = new Panel();
      this.panel27 = new Panel();
      this.panel36 = new Panel();
      this.Icon1 = new Button();
      this.Icon2 = new Button();
      this.Icon3 = new Button();
      this.Icon6 = new Button();
      this.Icon5 = new Button();
      this.Icon4 = new Button();
      this.Icon8 = new Button();
      this.Icon7 = new Button();
      this.WinInfo = new NotifyIcon(this.components);
      this.NickPnl.SuspendLayout();
      this.HeadLinePnlInf.SuspendLayout();
      this.SuspendLayout();
      this.NickPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.NickPnl.Controls.Add((Control) this.panel18);
      this.NickPnl.Controls.Add((Control) this.NickTxt);
      this.NickPnl.Controls.Add((Control) this.SetNickBtn);
      this.NickPnl.Location = new Point(12, 45);
      this.NickPnl.Name = "NickPnl";
      this.NickPnl.Size = new Size(314, 32);
      this.NickPnl.TabIndex = 6307;
      this.panel18.BackColor = Color.FromArgb(56, 56, 56);
      this.panel18.Location = new Point(216, 0);
      this.panel18.Name = "panel18";
      this.panel18.Size = new Size(3, 148);
      this.panel18.TabIndex = 6277;
      this.NickTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.NickTxt.BorderStyle = BorderStyle.None;
      this.NickTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.NickTxt.ForeColor = Color.DarkGray;
      this.NickTxt.Location = new Point(7, 7);
      this.NickTxt.Name = "NickTxt";
      this.NickTxt.Size = new Size(202, 18);
      this.NickTxt.TabIndex = 6153;
      this.NickTxt.Text = "Nick Name";
      this.NickTxt.Enter += new EventHandler(this.NickTxt_Enter);
      this.NickTxt.Leave += new EventHandler(this.NickTxt_Leave);
      this.SetNickBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.SetNickBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.SetNickBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.SetNickBtn.FlatAppearance.BorderSize = 0;
      this.SetNickBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.SetNickBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.SetNickBtn.FlatStyle = FlatStyle.Flat;
      this.SetNickBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.SetNickBtn.Location = new Point(224, 5);
      this.SetNickBtn.Name = "SetNickBtn";
      this.SetNickBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.SetNickBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.SetNickBtn.OnHoverTextColor = Color.White;
      this.SetNickBtn.Size = new Size(84, 22);
      this.SetNickBtn.TabIndex = 6318;
      this.SetNickBtn.Text = "SET NICK";
      this.SetNickBtn.TextColor = Color.White;
      this.SetNickBtn.UseVisualStyleBackColor = true;
      this.SetNickBtn.Click += new EventHandler(this.SetNickBtn_Click);
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1507, 133);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6306;
      this.HeadLinePnlInf.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel24);
      this.HeadLinePnlInf.Controls.Add((Control) this.CloseBtn);
      this.HeadLinePnlInf.Controls.Add((Control) this.HeadServerLbl);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel25);
      this.HeadLinePnlInf.Controls.Add((Control) this.comboBox3);
      this.HeadLinePnlInf.Controls.Add((Control) this.textBox3);
      this.HeadLinePnlInf.Controls.Add((Control) this.button4);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel26);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel27);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel36);
      this.HeadLinePnlInf.Dock = DockStyle.Top;
      this.HeadLinePnlInf.Location = new Point(0, 0);
      this.HeadLinePnlInf.Name = "HeadLinePnlInf";
      this.HeadLinePnlInf.Size = new Size(338, 29);
      this.HeadLinePnlInf.TabIndex = 6305;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(12, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(298, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(312, -1);
      this.CloseBtn.Name = "CloseBtn";
      this.CloseBtn.Size = new Size(26, 27);
      this.CloseBtn.TabIndex = 6167;
      this.CloseBtn.Text = "r";
      this.CloseBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseBtn.UseVisualStyleBackColor = false;
      this.CloseBtn.Click += new EventHandler(this.CloseBtn_Click);
      this.HeadServerLbl.AutoSize = true;
      this.HeadServerLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.HeadServerLbl.ForeColor = Color.White;
      this.HeadServerLbl.Location = new Point(95, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(135, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "LEAVE MESSAGE";
      this.HeadServerLbl.MouseDown += new MouseEventHandler(this.HeadServerLbl_MouseDown);
      this.HeadServerLbl.MouseMove += new MouseEventHandler(this.HeadServerLbl_MouseMove);
      this.panel25.BackColor = Color.FromArgb(51, 51, 51);
      this.panel25.Font = new Font("Segoe UI", 9f);
      this.panel25.Location = new Point(362, -44);
      this.panel25.Name = "panel25";
      this.panel25.Size = new Size(2, 25);
      this.panel25.TabIndex = 6160;
      this.comboBox3.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox3.ForeColor = Color.Silver;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(364, -44);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(254, 25);
      this.comboBox3.TabIndex = 6154;
      this.textBox3.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox3.BorderStyle = BorderStyle.None;
      this.textBox3.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textBox3.ForeColor = Color.White;
      this.textBox3.Location = new Point(364, -42);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(231, 21);
      this.textBox3.TabIndex = 6156;
      this.textBox3.Text = " Voice Channel";
      this.button4.BackColor = Color.FromArgb(25, 25, 25);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 2);
      this.button4.ForeColor = Color.Silver;
      this.button4.Location = new Point(594, -43);
      this.button4.Name = "button4";
      this.button4.Size = new Size(25, 22);
      this.button4.TabIndex = 6155;
      this.button4.Text = "6";
      this.button4.UseVisualStyleBackColor = false;
      this.panel26.BackColor = Color.FromArgb(51, 51, 51);
      this.panel26.Font = new Font("Segoe UI", 9f);
      this.panel26.Location = new Point(364, -21);
      this.panel26.Name = "panel26";
      this.panel26.Size = new Size(254, 2);
      this.panel26.TabIndex = 6157;
      this.panel27.BackColor = Color.FromArgb(51, 51, 51);
      this.panel27.Font = new Font("Segoe UI", 9f);
      this.panel27.Location = new Point(364, -44);
      this.panel27.Name = "panel27";
      this.panel27.Size = new Size(254, 2);
      this.panel27.TabIndex = 6158;
      this.panel36.BackColor = Color.FromArgb(51, 51, 51);
      this.panel36.Font = new Font("Segoe UI", 9f);
      this.panel36.Location = new Point(617, -44);
      this.panel36.Name = "panel36";
      this.panel36.Size = new Size(2, 25);
      this.panel36.TabIndex = 6159;
      this.Icon1.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon1.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon1.FlatAppearance.BorderSize = 0;
      this.Icon1.FlatStyle = FlatStyle.Flat;
      this.Icon1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon1.ForeColor = Color.WhiteSmoke;
      this.Icon1.Location = new Point(12, 88);
      this.Icon1.Name = "Icon1";
      this.Icon1.Size = new Size(34, 28);
      this.Icon1.TabIndex = 6280;
      this.Icon1.Text = "⚠️";
      this.Icon1.UseVisualStyleBackColor = false;
      this.Icon1.Click += new EventHandler(this.Icon1_Click);
      this.Icon2.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon2.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon2.FlatAppearance.BorderSize = 0;
      this.Icon2.FlatStyle = FlatStyle.Flat;
      this.Icon2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon2.ForeColor = Color.WhiteSmoke;
      this.Icon2.Location = new Point(52, 88);
      this.Icon2.Name = "Icon2";
      this.Icon2.Size = new Size(34, 28);
      this.Icon2.TabIndex = 6308;
      this.Icon2.Text = "☣";
      this.Icon2.UseVisualStyleBackColor = false;
      this.Icon2.Click += new EventHandler(this.Icon2_Click);
      this.Icon3.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon3.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon3.FlatAppearance.BorderSize = 0;
      this.Icon3.FlatStyle = FlatStyle.Flat;
      this.Icon3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon3.ForeColor = Color.WhiteSmoke;
      this.Icon3.Location = new Point(92, 88);
      this.Icon3.Name = "Icon3";
      this.Icon3.Size = new Size(34, 28);
      this.Icon3.TabIndex = 6309;
      this.Icon3.Text = "╭∩╮";
      this.Icon3.UseVisualStyleBackColor = false;
      this.Icon3.Click += new EventHandler(this.Icon3_Click);
      this.Icon6.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon6.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon6.FlatAppearance.BorderSize = 0;
      this.Icon6.FlatStyle = FlatStyle.Flat;
      this.Icon6.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon6.ForeColor = Color.WhiteSmoke;
      this.Icon6.Location = new Point(212, 88);
      this.Icon6.Name = "Icon6";
      this.Icon6.Size = new Size(34, 28);
      this.Icon6.TabIndex = 6312;
      this.Icon6.Text = "㋛";
      this.Icon6.UseVisualStyleBackColor = false;
      this.Icon6.Click += new EventHandler(this.Icon6_Click);
      this.Icon5.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon5.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon5.FlatAppearance.BorderSize = 0;
      this.Icon5.FlatStyle = FlatStyle.Flat;
      this.Icon5.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon5.ForeColor = Color.WhiteSmoke;
      this.Icon5.Location = new Point(172, 88);
      this.Icon5.Name = "Icon5";
      this.Icon5.Size = new Size(34, 28);
      this.Icon5.TabIndex = 6311;
      this.Icon5.Text = "▓░";
      this.Icon5.UseVisualStyleBackColor = false;
      this.Icon5.Click += new EventHandler(this.Icon5_Click);
      this.Icon4.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon4.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon4.FlatAppearance.BorderSize = 0;
      this.Icon4.FlatStyle = FlatStyle.Flat;
      this.Icon4.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon4.ForeColor = Color.WhiteSmoke;
      this.Icon4.Location = new Point(132, 88);
      this.Icon4.Name = "Icon4";
      this.Icon4.Size = new Size(34, 28);
      this.Icon4.TabIndex = 6310;
      this.Icon4.Text = "\uD83C\uDFAE";
      this.Icon4.UseVisualStyleBackColor = false;
      this.Icon4.Click += new EventHandler(this.Icon4_Click);
      this.Icon8.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon8.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon8.FlatAppearance.BorderSize = 0;
      this.Icon8.FlatStyle = FlatStyle.Flat;
      this.Icon8.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon8.ForeColor = Color.WhiteSmoke;
      this.Icon8.Location = new Point(292, 88);
      this.Icon8.Name = "Icon8";
      this.Icon8.Size = new Size(34, 28);
      this.Icon8.TabIndex = 6314;
      this.Icon8.Text = "☣";
      this.Icon8.UseVisualStyleBackColor = false;
      this.Icon8.Click += new EventHandler(this.Icon8_Click);
      this.Icon7.BackColor = Color.FromArgb(56, 59, 63);
      this.Icon7.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.Icon7.FlatAppearance.BorderSize = 0;
      this.Icon7.FlatStyle = FlatStyle.Flat;
      this.Icon7.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Icon7.ForeColor = Color.WhiteSmoke;
      this.Icon7.Location = new Point(252, 88);
      this.Icon7.Name = "Icon7";
      this.Icon7.Size = new Size(34, 28);
      this.Icon7.TabIndex = 6313;
      this.Icon7.Text = "ヅ";
      this.Icon7.UseVisualStyleBackColor = false;
      this.Icon7.Click += new EventHandler(this.Icon7_Click);
      this.WinInfo.BalloonTipTitle = "Discord Raider";
      this.WinInfo.Icon = (Icon) componentResourceManager.GetObject("WinInfo.Icon");
      this.WinInfo.Visible = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(338, 150);
      this.Controls.Add((Control) this.Icon8);
      this.Controls.Add((Control) this.Icon7);
      this.Controls.Add((Control) this.Icon6);
      this.Controls.Add((Control) this.Icon5);
      this.Controls.Add((Control) this.Icon4);
      this.Controls.Add((Control) this.Icon3);
      this.Controls.Add((Control) this.Icon2);
      this.Controls.Add((Control) this.Icon1);
      this.Controls.Add((Control) this.NickPnl);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (ChangeNick);
      this.Text = "Discord Raider | Change Nick";
      this.FormClosing += new FormClosingEventHandler(this.ChangeNick_FormClosing);
      this.NickPnl.ResumeLayout(false);
      this.NickPnl.PerformLayout();
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
