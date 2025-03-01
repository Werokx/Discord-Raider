using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class LeaveText : Form
  {
    private IContainer components;
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
    private Panel MsgPnl;
    private TextBox LeaveMsgTxt;
    private Panel ChannelPnl;
    private Panel panel18;
    private TextBox ChannelIDTxt;
    private RoundBtn SpammerBtn;

    public LeaveText()
    {
      this.InitializeComponent();
      this.ModDesign();
      this.ModDesign2();
      this.ModDesign3();
      this.CheckLoad();
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

    private void ModDesign2()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ChannelPnl.Width, this.ChannelPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ChannelPnl.Region = new Region(path);
    }

    private void ModDesign3()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.MsgPnl.Width, this.MsgPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.MsgPnl.Region = new Region(path);
    }

    private void CheckLoad()
    {
      this.ChannelIDTxt.Text = SpamMain._LeaveChannel;
      this.LeaveMsgTxt.Text = SpamMain._LeaveMsg;
      if (SpamMain._enbableLeaveMsg)
        this.SpammerBtn.Text = "Disable Leave Text";
      else
        this.SpammerBtn.Text = "Enable Leave Text";
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      SpamMain._LeaveText = false;
      this.Close();
    }

    private void SpammerBtn_Click(object sender, EventArgs e)
    {
      if (this.ChannelIDTxt.Text == "" || this.ChannelIDTxt.Text == "Channel ID")
      {
        int num = (int) MessageBox.Show("You need to enter a Channel ID first", "Discord Raider");
      }
      else
      {
        switch (this.SpammerBtn.Text)
        {
          case "Enable Leave Text":
            this.SpammerBtn.Text = "Disable Leave Text";
            SpamMain._enbableLeaveMsg = true;
            SpamMain._LeaveMsg = this.LeaveMsgTxt.Text;
            SpamMain._LeaveChannel = this.ChannelIDTxt.Text;
            break;
          case "Disable Leave Text":
            SpamMain._enbableLeaveMsg = false;
            this.SpammerBtn.Text = "Enable Leave Text";
            break;
        }
      }
    }

    private void LeaveText_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._LeaveText = false;

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

    private void ChannelIDTxt_TextChanged(object sender, EventArgs e) => SpamMain._LeaveChannel = this.ChannelIDTxt.Text;

    private void LeaveMsgTxt_TextChanged(object sender, EventArgs e) => SpamMain._LeaveMsg = this.LeaveMsgTxt.Text;

    private void ChannelIDTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.ChannelIDTxt.Text == "Channel ID"))
        return;
      this.ChannelIDTxt.Text = "";
      this.ChannelIDTxt.ForeColor = Color.White;
    }

    private void ChannelIDTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.ChannelIDTxt.Text == ""))
        return;
      this.ChannelIDTxt.Text = "Channel ID";
      this.ChannelIDTxt.ForeColor = Color.Silver;
    }

    private void LeaveMsgTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.LeaveMsgTxt.Text == "Leave Message"))
        return;
      this.LeaveMsgTxt.Text = "";
      this.LeaveMsgTxt.ForeColor = Color.White;
    }

    private void LeaveMsgTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.LeaveMsgTxt.Text == ""))
        return;
      this.LeaveMsgTxt.Text = "Leave Message";
      this.LeaveMsgTxt.ForeColor = Color.Silver;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LeaveText));
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
      this.MsgPnl = new Panel();
      this.LeaveMsgTxt = new TextBox();
      this.ChannelPnl = new Panel();
      this.SpammerBtn = new RoundBtn();
      this.panel18 = new Panel();
      this.ChannelIDTxt = new TextBox();
      this.HeadLinePnlInf.SuspendLayout();
      this.MsgPnl.SuspendLayout();
      this.ChannelPnl.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1507, 154);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6299;
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
      this.HeadLinePnlInf.Size = new Size(323, 29);
      this.HeadLinePnlInf.TabIndex = 6298;
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
      this.CloseBtn.Location = new Point(297, -1);
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
      this.MsgPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.MsgPnl.Controls.Add((Control) this.LeaveMsgTxt);
      this.MsgPnl.Location = new Point(12, 81);
      this.MsgPnl.Name = "MsgPnl";
      this.MsgPnl.Size = new Size(298, 60);
      this.MsgPnl.TabIndex = 6304;
      this.LeaveMsgTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.LeaveMsgTxt.BorderStyle = BorderStyle.None;
      this.LeaveMsgTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.LeaveMsgTxt.ForeColor = Color.DarkGray;
      this.LeaveMsgTxt.Location = new Point(6, 7);
      this.LeaveMsgTxt.Multiline = true;
      this.LeaveMsgTxt.Name = "LeaveMsgTxt";
      this.LeaveMsgTxt.Size = new Size(284, 45);
      this.LeaveMsgTxt.TabIndex = 6153;
      this.LeaveMsgTxt.Text = "Leave Message";
      this.LeaveMsgTxt.TextChanged += new EventHandler(this.LeaveMsgTxt_TextChanged);
      this.LeaveMsgTxt.Enter += new EventHandler(this.LeaveMsgTxt_Enter);
      this.LeaveMsgTxt.Leave += new EventHandler(this.LeaveMsgTxt_Leave);
      this.ChannelPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.ChannelPnl.Controls.Add((Control) this.SpammerBtn);
      this.ChannelPnl.Controls.Add((Control) this.panel18);
      this.ChannelPnl.Controls.Add((Control) this.ChannelIDTxt);
      this.ChannelPnl.Location = new Point(12, 40);
      this.ChannelPnl.Name = "ChannelPnl";
      this.ChannelPnl.Size = new Size(298, 32);
      this.ChannelPnl.TabIndex = 6303;
      this.SpammerBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.SpammerBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.SpammerBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.SpammerBtn.FlatAppearance.BorderSize = 0;
      this.SpammerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.SpammerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.SpammerBtn.FlatStyle = FlatStyle.Flat;
      this.SpammerBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.SpammerBtn.Location = new Point(178, 5);
      this.SpammerBtn.Name = "SpammerBtn";
      this.SpammerBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.SpammerBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.SpammerBtn.OnHoverTextColor = Color.White;
      this.SpammerBtn.Size = new Size(114, 22);
      this.SpammerBtn.TabIndex = 6319;
      this.SpammerBtn.Text = "Enable Leave Text";
      this.SpammerBtn.TextColor = Color.White;
      this.SpammerBtn.UseVisualStyleBackColor = true;
      this.SpammerBtn.Click += new EventHandler(this.SpammerBtn_Click);
      this.panel18.BackColor = Color.FromArgb(56, 56, 56);
      this.panel18.Location = new Point(170, 0);
      this.panel18.Name = "panel18";
      this.panel18.Size = new Size(3, 148);
      this.panel18.TabIndex = 6277;
      this.ChannelIDTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.ChannelIDTxt.BorderStyle = BorderStyle.None;
      this.ChannelIDTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ChannelIDTxt.ForeColor = Color.DarkGray;
      this.ChannelIDTxt.Location = new Point(7, 7);
      this.ChannelIDTxt.Name = "ChannelIDTxt";
      this.ChannelIDTxt.Size = new Size(152, 18);
      this.ChannelIDTxt.TabIndex = 6153;
      this.ChannelIDTxt.Text = "Channel ID";
      this.ChannelIDTxt.TextChanged += new EventHandler(this.ChannelIDTxt_TextChanged);
      this.ChannelIDTxt.Enter += new EventHandler(this.ChannelIDTxt_Enter);
      this.ChannelIDTxt.Leave += new EventHandler(this.ChannelIDTxt_Leave);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(323, 170);
      this.Controls.Add((Control) this.MsgPnl);
      this.Controls.Add((Control) this.ChannelPnl);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(323, 170);
      this.Name = nameof (LeaveText);
      this.Text = "Discord Raider | Leave Text";
      this.FormClosing += new FormClosingEventHandler(this.LeaveText_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.MsgPnl.ResumeLayout(false);
      this.MsgPnl.PerformLayout();
      this.ChannelPnl.ResumeLayout(false);
      this.ChannelPnl.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
