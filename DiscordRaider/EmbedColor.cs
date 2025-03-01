using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class EmbedColor : Form
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
    private Panel panel49;
    private Button ColorBtn1;
    private Panel panel1;
    private Button ColorBtn2;
    private Panel panel2;
    private Button ColorBtn3;
    private Panel panel3;
    private Button ColorBtn4;
    private Panel panel4;
    private Button ColorBtn8;
    private Panel panel5;
    private Button ColorBtn7;
    private Panel panel6;
    private Button ColorBtn6;
    private Panel panel7;
    private Button ColorBtn5;
    private NotifyIcon WinInfo;

    public EmbedColor()
    {
      this.InitializeComponent();
      this.ChangeCorners();
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

    private void Set()
    {
      this.WinInfo.Visible = true;
      this.WinInfo.BalloonTipText = "Embed Color Set!";
      this.WinInfo.ShowBalloonTip(700);
    }

    private void ColorBtn1_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 12745742;
      this.Set();
    }

    private void ColorBtn2_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 15105570;
      this.Set();
    }

    private void ColorBtn3_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 15158332;
      this.Set();
    }

    private void ColorBtn4_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 3066993;
      this.Set();
    }

    private void ColorBtn5_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 7419530;
      this.Set();
    }

    private void ColorBtn6_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 2899536;
      this.Set();
    }

    private void ColorBtn7_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 12320855;
      this.Set();
    }

    private void ColorBtn8_Click(object sender, EventArgs e)
    {
      SpamMain._ColorUsed = true;
      SpamMain._EmbedColor = 9807270;
      this.Set();
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      SpamMain._EmbedColorForm = false;
      this.Close();
    }

    private void EmbedColor_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._EmbedColorForm = false;

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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EmbedColor));
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
      this.panel49 = new Panel();
      this.ColorBtn1 = new Button();
      this.panel1 = new Panel();
      this.ColorBtn2 = new Button();
      this.panel2 = new Panel();
      this.ColorBtn3 = new Button();
      this.panel3 = new Panel();
      this.ColorBtn4 = new Button();
      this.panel4 = new Panel();
      this.ColorBtn8 = new Button();
      this.panel5 = new Panel();
      this.ColorBtn7 = new Button();
      this.panel6 = new Panel();
      this.ColorBtn6 = new Button();
      this.panel7 = new Panel();
      this.ColorBtn5 = new Button();
      this.WinInfo = new NotifyIcon(this.components);
      this.HeadLinePnlInf.SuspendLayout();
      this.panel49.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel7.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1623, 210);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6301;
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
      this.HeadLinePnlInf.Size = new Size(324, 29);
      this.HeadLinePnlInf.TabIndex = 6300;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(12, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(300, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(298, -1);
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
      this.HeadServerLbl.Location = new Point(100, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(130, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "CHOOSE COLOR";
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
      this.panel49.BackColor = Color.FromArgb(49, 50, 55);
      this.panel49.Controls.Add((Control) this.ColorBtn1);
      this.panel49.Location = new Point(12, 41);
      this.panel49.Name = "panel49";
      this.panel49.Size = new Size(145, 32);
      this.panel49.TabIndex = 6310;
      this.ColorBtn1.BackColor = Color.FromArgb(194, 124, 14);
      this.ColorBtn1.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn1.FlatAppearance.BorderSize = 0;
      this.ColorBtn1.FlatStyle = FlatStyle.Flat;
      this.ColorBtn1.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn1.ForeColor = Color.WhiteSmoke;
      this.ColorBtn1.Location = new Point(5, 5);
      this.ColorBtn1.Name = "ColorBtn1";
      this.ColorBtn1.Size = new Size(135, 22);
      this.ColorBtn1.TabIndex = 6279;
      this.ColorBtn1.UseVisualStyleBackColor = false;
      this.ColorBtn1.Click += new EventHandler(this.ColorBtn1_Click);
      this.panel1.BackColor = Color.FromArgb(49, 50, 55);
      this.panel1.Controls.Add((Control) this.ColorBtn2);
      this.panel1.Location = new Point(12, 82);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(145, 32);
      this.panel1.TabIndex = 6311;
      this.ColorBtn2.BackColor = Color.FromArgb(230, 126, 34);
      this.ColorBtn2.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn2.FlatAppearance.BorderSize = 0;
      this.ColorBtn2.FlatStyle = FlatStyle.Flat;
      this.ColorBtn2.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn2.ForeColor = Color.WhiteSmoke;
      this.ColorBtn2.Location = new Point(5, 5);
      this.ColorBtn2.Name = "ColorBtn2";
      this.ColorBtn2.Size = new Size(135, 22);
      this.ColorBtn2.TabIndex = 6279;
      this.ColorBtn2.UseVisualStyleBackColor = false;
      this.ColorBtn2.Click += new EventHandler(this.ColorBtn2_Click);
      this.panel2.BackColor = Color.FromArgb(49, 50, 55);
      this.panel2.Controls.Add((Control) this.ColorBtn3);
      this.panel2.Location = new Point(12, 123);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(145, 32);
      this.panel2.TabIndex = 6312;
      this.ColorBtn3.BackColor = Color.FromArgb(231, 76, 60);
      this.ColorBtn3.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn3.FlatAppearance.BorderSize = 0;
      this.ColorBtn3.FlatStyle = FlatStyle.Flat;
      this.ColorBtn3.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn3.ForeColor = Color.WhiteSmoke;
      this.ColorBtn3.Location = new Point(5, 5);
      this.ColorBtn3.Name = "ColorBtn3";
      this.ColorBtn3.Size = new Size(135, 22);
      this.ColorBtn3.TabIndex = 6279;
      this.ColorBtn3.UseVisualStyleBackColor = false;
      this.ColorBtn3.Click += new EventHandler(this.ColorBtn3_Click);
      this.panel3.BackColor = Color.FromArgb(49, 50, 55);
      this.panel3.Controls.Add((Control) this.ColorBtn4);
      this.panel3.Location = new Point(12, 164);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(145, 32);
      this.panel3.TabIndex = 6313;
      this.ColorBtn4.BackColor = Color.FromArgb(46, 204, 113);
      this.ColorBtn4.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn4.FlatAppearance.BorderSize = 0;
      this.ColorBtn4.FlatStyle = FlatStyle.Flat;
      this.ColorBtn4.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn4.ForeColor = Color.WhiteSmoke;
      this.ColorBtn4.Location = new Point(5, 5);
      this.ColorBtn4.Name = "ColorBtn4";
      this.ColorBtn4.Size = new Size(135, 22);
      this.ColorBtn4.TabIndex = 6279;
      this.ColorBtn4.UseVisualStyleBackColor = false;
      this.ColorBtn4.Click += new EventHandler(this.ColorBtn4_Click);
      this.panel4.BackColor = Color.FromArgb(49, 50, 55);
      this.panel4.Controls.Add((Control) this.ColorBtn8);
      this.panel4.Location = new Point(167, 164);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(145, 32);
      this.panel4.TabIndex = 6317;
      this.ColorBtn8.BackColor = Color.FromArgb(149, 165, 166);
      this.ColorBtn8.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn8.FlatAppearance.BorderSize = 0;
      this.ColorBtn8.FlatStyle = FlatStyle.Flat;
      this.ColorBtn8.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn8.ForeColor = Color.WhiteSmoke;
      this.ColorBtn8.Location = new Point(5, 5);
      this.ColorBtn8.Name = "ColorBtn8";
      this.ColorBtn8.Size = new Size(135, 22);
      this.ColorBtn8.TabIndex = 6279;
      this.ColorBtn8.UseVisualStyleBackColor = false;
      this.ColorBtn8.Click += new EventHandler(this.ColorBtn8_Click);
      this.panel5.BackColor = Color.FromArgb(49, 50, 55);
      this.panel5.Controls.Add((Control) this.ColorBtn7);
      this.panel5.Location = new Point(167, 123);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(145, 32);
      this.panel5.TabIndex = 6316;
      this.ColorBtn7.BackColor = Color.FromArgb(188, 0, 87);
      this.ColorBtn7.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn7.FlatAppearance.BorderSize = 0;
      this.ColorBtn7.FlatStyle = FlatStyle.Flat;
      this.ColorBtn7.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn7.ForeColor = Color.WhiteSmoke;
      this.ColorBtn7.Location = new Point(5, 5);
      this.ColorBtn7.Name = "ColorBtn7";
      this.ColorBtn7.Size = new Size(135, 22);
      this.ColorBtn7.TabIndex = 6279;
      this.ColorBtn7.UseVisualStyleBackColor = false;
      this.ColorBtn7.Click += new EventHandler(this.ColorBtn7_Click);
      this.panel6.BackColor = Color.FromArgb(49, 50, 55);
      this.panel6.Controls.Add((Control) this.ColorBtn6);
      this.panel6.Location = new Point(167, 82);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(145, 32);
      this.panel6.TabIndex = 6315;
      this.ColorBtn6.BackColor = Color.FromArgb(44, 62, 80);
      this.ColorBtn6.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn6.FlatAppearance.BorderSize = 0;
      this.ColorBtn6.FlatStyle = FlatStyle.Flat;
      this.ColorBtn6.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn6.ForeColor = Color.WhiteSmoke;
      this.ColorBtn6.Location = new Point(5, 5);
      this.ColorBtn6.Name = "ColorBtn6";
      this.ColorBtn6.Size = new Size(135, 22);
      this.ColorBtn6.TabIndex = 6279;
      this.ColorBtn6.UseVisualStyleBackColor = false;
      this.ColorBtn6.Click += new EventHandler(this.ColorBtn6_Click);
      this.panel7.BackColor = Color.FromArgb(49, 50, 55);
      this.panel7.Controls.Add((Control) this.ColorBtn5);
      this.panel7.Location = new Point(167, 41);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(145, 32);
      this.panel7.TabIndex = 6314;
      this.ColorBtn5.BackColor = Color.FromArgb(113, 54, 138);
      this.ColorBtn5.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ColorBtn5.FlatAppearance.BorderSize = 0;
      this.ColorBtn5.FlatStyle = FlatStyle.Flat;
      this.ColorBtn5.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ColorBtn5.ForeColor = Color.WhiteSmoke;
      this.ColorBtn5.Location = new Point(5, 5);
      this.ColorBtn5.Name = "ColorBtn5";
      this.ColorBtn5.Size = new Size(135, 22);
      this.ColorBtn5.TabIndex = 6279;
      this.ColorBtn5.UseVisualStyleBackColor = false;
      this.ColorBtn5.Click += new EventHandler(this.ColorBtn5_Click);
      this.WinInfo.BalloonTipTitle = "Discord Raider";
      this.WinInfo.Icon = (Icon) componentResourceManager.GetObject("WinInfo.Icon");
      this.WinInfo.Visible = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(324, 229);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.panel5);
      this.Controls.Add((Control) this.panel6);
      this.Controls.Add((Control) this.panel7);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel49);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (EmbedColor);
      this.Text = "Discord Raider | Embed Color";
      this.FormClosing += new FormClosingEventHandler(this.EmbedColor_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.panel49.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
