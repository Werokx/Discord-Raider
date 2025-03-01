using RaidAPI.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class ServerInfo : Form
  {
    private IContainer components;
    private TextBox Servernametxt;
    private Label OnlineMemberLbl;
    private Label label8;
    private Label Memberslbl;
    private Label label11;
    private Label VeriLabl;
    private Label label4;
    private Label ServerIDlbl;
    private Label label7;
    private Label ServerNameLbl;
    private Label label10;
    private Panel panel37;
    private Panel panel36;
    private Panel panel27;
    private Panel panel26;
    private Button button4;
    private TextBox textBox3;
    private ComboBox comboBox3;
    private Panel panel25;
    private Label HeadServerLbl;
    private Button CloseServerInfBtn;
    private Panel panel24;
    private Panel HeadLinePnlInf;

    public ServerInfo()
    {
      this.InitializeComponent();
      ServerInfos._Token = "NjkxMzA1ODcxNjY1NTI4OTAz.XneDtw.LITcm1SkPKbqltwvMUGyByZz3Uk";
      this.GetTheInfos(SpamMain._Invite);
      this.ModDesign();
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

    private void GetTheInfos(string MyInvite)
    {
      if (MyInvite == "" || MyInvite == "Discord Invite")
      {
        int num = (int)MessageBox.Show("Enter first a Invite", "Discord Raider");
        SpamMain._Invite = "";
        this.Close();
      }
      else
      {
        string _Invite = MyInvite.Replace("https://discord.gg/", "");
        if (_Invite == "")
        {
          ServerInfos.Servername = "";
          ServerInfos.Serverid = "";
          ServerInfos.Verification = "";
          ServerInfos.MembersCurrent = "";
          ServerInfos.MembersOnline = "";
          this.ServerIDlbl.Text = "N/A";
          this.Memberslbl.Text = "N/A";
          this.Servernametxt.Text = "N/A";
          this.VeriLabl.Text = "N/A";
          this.OnlineMemberLbl.Text = "N/A";
        }
        else
        {
          ServerInfos.StartGetInfos(_Invite);
          this.Servernametxt.Text = ServerInfos.Servername;
          this.ServerIDlbl.Text = ServerInfos.Serverid;
          this.VeriLabl.Text = ServerInfos.Verification;
          this.Memberslbl.Text = ServerInfos.MembersCurrent;
          this.OnlineMemberLbl.Text = ServerInfos.MembersOnline;
        }
      }
    }

    private void CloseServerInfBtn_Click(object sender, EventArgs e)
    {
      SpamMain._ServerInfos = false;
      SpamMain._Invite = "";
      this.Close();
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

    private void ServerInfo_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._ServerInfos = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ServerInfo));
      this.Servernametxt = new TextBox();
      this.OnlineMemberLbl = new Label();
      this.label8 = new Label();
      this.Memberslbl = new Label();
      this.label11 = new Label();
      this.VeriLabl = new Label();
      this.label4 = new Label();
      this.ServerIDlbl = new Label();
      this.label7 = new Label();
      this.ServerNameLbl = new Label();
      this.label10 = new Label();
      this.panel37 = new Panel();
      this.panel36 = new Panel();
      this.panel27 = new Panel();
      this.panel26 = new Panel();
      this.button4 = new Button();
      this.textBox3 = new TextBox();
      this.comboBox3 = new ComboBox();
      this.panel25 = new Panel();
      this.HeadServerLbl = new Label();
      this.CloseServerInfBtn = new Button();
      this.panel24 = new Panel();
      this.HeadLinePnlInf = new Panel();
      this.HeadLinePnlInf.SuspendLayout();
      this.SuspendLayout();
      this.Servernametxt.BackColor = Color.FromArgb(33, 34, 38);
      this.Servernametxt.BorderStyle = BorderStyle.None;
      this.Servernametxt.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.Servernametxt.ForeColor = Color.White;
      this.Servernametxt.Location = new Point(16, 56);
      this.Servernametxt.Name = "Servernametxt";
      this.Servernametxt.Size = new Size(103, 16);
      this.Servernametxt.TabIndex = 6307;
      this.Servernametxt.Text = "N/A";
      this.OnlineMemberLbl.AutoSize = true;
      this.OnlineMemberLbl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.OnlineMemberLbl.ForeColor = Color.White;
      this.OnlineMemberLbl.Location = new Point(15, 139);
      this.OnlineMemberLbl.Name = "OnlineMemberLbl";
      this.OnlineMemberLbl.Size = new Size(29, 15);
      this.OnlineMemberLbl.TabIndex = 6306;
      this.OnlineMemberLbl.Text = "N/A";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label8.ForeColor = Color.Silver;
      this.label8.Location = new Point(15, 122);
      this.label8.Name = "label8";
      this.label8.Size = new Size(46, 15);
      this.label8.TabIndex = 6305;
      this.label8.Text = "Online:";
      this.Memberslbl.AutoSize = true;
      this.Memberslbl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.Memberslbl.ForeColor = Color.White;
      this.Memberslbl.Location = new Point((int)sbyte.MaxValue, 97);
      this.Memberslbl.Name = "Memberslbl";
      this.Memberslbl.Size = new Size(29, 15);
      this.Memberslbl.TabIndex = 6304;
      this.Memberslbl.Text = "N/A";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label11.ForeColor = Color.Silver;
      this.label11.Location = new Point((int)sbyte.MaxValue, 80);
      this.label11.Name = "label11";
      this.label11.Size = new Size(63, 15);
      this.label11.TabIndex = 6303;
      this.label11.Text = "Members:";
      this.VeriLabl.AutoSize = true;
      this.VeriLabl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.VeriLabl.ForeColor = Color.White;
      this.VeriLabl.Location = new Point(15, 97);
      this.VeriLabl.Name = "VeriLabl";
      this.VeriLabl.Size = new Size(29, 15);
      this.VeriLabl.TabIndex = 6302;
      this.VeriLabl.Text = "N/A";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label4.ForeColor = Color.Silver;
      this.label4.Location = new Point(15, 80);
      this.label4.Name = "label4";
      this.label4.Size = new Size(74, 15);
      this.label4.TabIndex = 6301;
      this.label4.Text = "Verification:";
      this.ServerIDlbl.AutoSize = true;
      this.ServerIDlbl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ServerIDlbl.ForeColor = Color.White;
      this.ServerIDlbl.Location = new Point((int)sbyte.MaxValue, 56);
      this.ServerIDlbl.Name = "ServerIDlbl";
      this.ServerIDlbl.Size = new Size(29, 15);
      this.ServerIDlbl.TabIndex = 6300;
      this.ServerIDlbl.Text = "N/A";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label7.ForeColor = Color.Silver;
      this.label7.Location = new Point((int)sbyte.MaxValue, 39);
      this.label7.Name = "label7";
      this.label7.Size = new Size(64, 15);
      this.label7.TabIndex = 6299;
      this.label7.Text = "Server ID:";
      this.ServerNameLbl.AutoSize = true;
      this.ServerNameLbl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ServerNameLbl.ForeColor = Color.White;
      this.ServerNameLbl.Location = new Point(15, 56);
      this.ServerNameLbl.Name = "ServerNameLbl";
      this.ServerNameLbl.Size = new Size(29, 15);
      this.ServerNameLbl.TabIndex = 6298;
      this.ServerNameLbl.Text = "N/A";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label10.ForeColor = Color.Silver;
      this.label10.Location = new Point(15, 39);
      this.label10.Name = "label10";
      this.label10.Size = new Size(84, 15);
      this.label10.TabIndex = 6297;
      this.label10.Text = "Server Name:";
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-7, 164);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(387, 2);
      this.panel37.TabIndex = 6296;
      this.panel36.BackColor = Color.FromArgb(51, 51, 51);
      this.panel36.Font = new Font("Segoe UI", 9f);
      this.panel36.Location = new Point(617, -44);
      this.panel36.Name = "panel36";
      this.panel36.Size = new Size(2, 25);
      this.panel36.TabIndex = 6159;
      this.panel27.BackColor = Color.FromArgb(51, 51, 51);
      this.panel27.Font = new Font("Segoe UI", 9f);
      this.panel27.Location = new Point(364, -44);
      this.panel27.Name = "panel27";
      this.panel27.Size = new Size(254, 2);
      this.panel27.TabIndex = 6158;
      this.panel26.BackColor = Color.FromArgb(51, 51, 51);
      this.panel26.Font = new Font("Segoe UI", 9f);
      this.panel26.Location = new Point(364, -21);
      this.panel26.Name = "panel26";
      this.panel26.Size = new Size(254, 2);
      this.panel26.TabIndex = 6157;
      this.button4.BackColor = Color.FromArgb(25, 25, 25);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
      this.button4.ForeColor = Color.Silver;
      this.button4.Location = new Point(594, -43);
      this.button4.Name = "button4";
      this.button4.Size = new Size(25, 22);
      this.button4.TabIndex = 6155;
      this.button4.Text = "6";
      this.button4.UseVisualStyleBackColor = false;
      this.textBox3.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox3.BorderStyle = BorderStyle.None;
      this.textBox3.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.textBox3.ForeColor = Color.White;
      this.textBox3.Location = new Point(364, -42);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(231, 21);
      this.textBox3.TabIndex = 6156;
      this.textBox3.Text = " Voice Channel";
      this.comboBox3.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox3.ForeColor = Color.Silver;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new Point(364, -44);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new Size(254, 25);
      this.comboBox3.TabIndex = 6154;
      this.panel25.BackColor = Color.FromArgb(51, 51, 51);
      this.panel25.Font = new Font("Segoe UI", 9f);
      this.panel25.Location = new Point(362, -44);
      this.panel25.Name = "panel25";
      this.panel25.Size = new Size(2, 25);
      this.panel25.TabIndex = 6160;
      this.HeadServerLbl.AutoSize = true;
      this.HeadServerLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.HeadServerLbl.ForeColor = Color.White;
      this.HeadServerLbl.Location = new Point(73, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(119, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "SERVER INFOS";
      this.HeadServerLbl.MouseDown += new MouseEventHandler(this.HeadServerLbl_MouseDown);
      this.HeadServerLbl.MouseMove += new MouseEventHandler(this.HeadServerLbl_MouseMove);
      this.CloseServerInfBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseServerInfBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseServerInfBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseServerInfBtn.FlatAppearance.BorderSize = 0;
      this.CloseServerInfBtn.FlatStyle = FlatStyle.Flat;
      this.CloseServerInfBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.CloseServerInfBtn.ForeColor = Color.White;
      this.CloseServerInfBtn.Location = new Point(245, -1);
      this.CloseServerInfBtn.Name = "CloseServerInfBtn";
      this.CloseServerInfBtn.Size = new Size(26, 27);
      this.CloseServerInfBtn.TabIndex = 6167;
      this.CloseServerInfBtn.Text = "r";
      this.CloseServerInfBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseServerInfBtn.UseVisualStyleBackColor = false;
      this.CloseServerInfBtn.Click += new EventHandler(this.CloseServerInfBtn_Click);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(18, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(220, 2);
      this.panel24.TabIndex = 6222;
      this.HeadLinePnlInf.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnlInf.Controls.Add((Control)this.panel24);
      this.HeadLinePnlInf.Controls.Add((Control)this.CloseServerInfBtn);
      this.HeadLinePnlInf.Controls.Add((Control)this.HeadServerLbl);
      this.HeadLinePnlInf.Controls.Add((Control)this.panel25);
      this.HeadLinePnlInf.Controls.Add((Control)this.comboBox3);
      this.HeadLinePnlInf.Controls.Add((Control)this.textBox3);
      this.HeadLinePnlInf.Controls.Add((Control)this.button4);
      this.HeadLinePnlInf.Controls.Add((Control)this.panel26);
      this.HeadLinePnlInf.Controls.Add((Control)this.panel27);
      this.HeadLinePnlInf.Controls.Add((Control)this.panel36);
      this.HeadLinePnlInf.Dock = DockStyle.Top;
      this.HeadLinePnlInf.Location = new Point(0, 0);
      this.HeadLinePnlInf.Name = "HeadLinePnlInf";
      this.HeadLinePnlInf.Size = new Size(271, 29);
      this.HeadLinePnlInf.TabIndex = 6295;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(271, 180);
      this.Controls.Add((Control)this.HeadLinePnlInf);
      this.Controls.Add((Control)this.Servernametxt);
      this.Controls.Add((Control)this.OnlineMemberLbl);
      this.Controls.Add((Control)this.label8);
      this.Controls.Add((Control)this.Memberslbl);
      this.Controls.Add((Control)this.label11);
      this.Controls.Add((Control)this.VeriLabl);
      this.Controls.Add((Control)this.label4);
      this.Controls.Add((Control)this.ServerIDlbl);
      this.Controls.Add((Control)this.label7);
      this.Controls.Add((Control)this.ServerNameLbl);
      this.Controls.Add((Control)this.label10);
      this.Controls.Add((Control)this.panel37);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof(ServerInfo);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Discord Raider | Server Infos";
      this.FormClosing += new FormClosingEventHandler(this.ServerInfo_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
