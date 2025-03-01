using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class EmojiList : Form
  {
    private IContainer components;
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
    private Panel panel37;
    private Button EmojiBtn24;
    private Button EmojiBtn23;
    private Button EmojiBtn12;
    private Button EmojiBtn11;
    private Button EmojiBtn18;
    private Button EmojiBtn17;
    private Button EmojiBtn6;
    private Button EmojiBtn5;
    private Button EmojiBtn22;
    private Button EmojiBtn21;
    private Button EmojiBtn20;
    private Button EmojiBtn19;
    private Button EmojiBtn16;
    private Button EmojiBtn15;
    private Button EmojiBtn14;
    private Button EmojiBtn13;
    private Button EmojiBtn10;
    private Button EmojiBtn9;
    private Button EmojiBtn8;
    private Button EmojiBtn7;
    private Button EmojiBtn4;
    private Button EmojiBtn3;
    private Button EmojiBtn2;
    private Button EmojiBtn1;
    private Button MoreBtn;

    public EmojiList()
    {
      this.InitializeComponent();
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

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      SpamMain._EmojiList = false;
      this.Close();
    }

    private void EmojiBtn1_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn1.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn2_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn2.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn3_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn3.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn4_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn4.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn5_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn5.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn6_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn6.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn7_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn7.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn8_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn8.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn9_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn9.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn10_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn10.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn11_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn11.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn12_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn12.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn13_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn13.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn14_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn14.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn15_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn15.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn16_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn16.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn17_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn17.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn18_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn18.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn19_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn19.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn20_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn20.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn21_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn21.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn22_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn22.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn23_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn23.Text;
      SpamMain._getEmoji = false;
    }

    private void EmojiBtn24_Click(object sender, EventArgs e)
    {
      SpamMain._getEmoji = true;
      SpamMain.EmojiString = this.EmojiBtn24.Text;
      SpamMain._getEmoji = false;
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

    private void EmojiList_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._EmojiList = false;

    private void MoreBtn_Click(object sender, EventArgs e) => Process.Start("https://getemoji.com/");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (EmojiList));
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
      this.panel37 = new Panel();
      this.EmojiBtn24 = new Button();
      this.EmojiBtn23 = new Button();
      this.EmojiBtn12 = new Button();
      this.EmojiBtn11 = new Button();
      this.EmojiBtn18 = new Button();
      this.EmojiBtn17 = new Button();
      this.EmojiBtn6 = new Button();
      this.EmojiBtn5 = new Button();
      this.EmojiBtn22 = new Button();
      this.EmojiBtn21 = new Button();
      this.EmojiBtn20 = new Button();
      this.EmojiBtn19 = new Button();
      this.EmojiBtn16 = new Button();
      this.EmojiBtn15 = new Button();
      this.EmojiBtn14 = new Button();
      this.EmojiBtn13 = new Button();
      this.EmojiBtn10 = new Button();
      this.EmojiBtn9 = new Button();
      this.EmojiBtn8 = new Button();
      this.EmojiBtn7 = new Button();
      this.EmojiBtn4 = new Button();
      this.EmojiBtn3 = new Button();
      this.EmojiBtn2 = new Button();
      this.EmojiBtn1 = new Button();
      this.MoreBtn = new Button();
      this.HeadLinePnlInf.SuspendLayout();
      this.SuspendLayout();
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
      this.HeadLinePnlInf.Size = new Size(321, 29);
      this.HeadLinePnlInf.TabIndex = 6296;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(17, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(290, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(295, -1);
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
      this.HeadServerLbl.Location = new Point(108, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(102, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "EMOJIS LIST";
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
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-19, 212);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6297;
      this.EmojiBtn24.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn24.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn24.FlatAppearance.BorderSize = 0;
      this.EmojiBtn24.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn24.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn24.ForeColor = Color.Silver;
      this.EmojiBtn24.Location = new Point(269, 166);
      this.EmojiBtn24.Name = "EmojiBtn24";
      this.EmojiBtn24.Size = new Size(38, 32);
      this.EmojiBtn24.TabIndex = 6321;
      this.EmojiBtn24.Text = "\uD83D\uDC79";
      this.EmojiBtn24.UseVisualStyleBackColor = false;
      this.EmojiBtn24.Click += new EventHandler(this.EmojiBtn24_Click);
      this.EmojiBtn23.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn23.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn23.FlatAppearance.BorderSize = 0;
      this.EmojiBtn23.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn23.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn23.ForeColor = Color.Silver;
      this.EmojiBtn23.Location = new Point(217, 166);
      this.EmojiBtn23.Name = "EmojiBtn23";
      this.EmojiBtn23.Size = new Size(38, 32);
      this.EmojiBtn23.TabIndex = 6320;
      this.EmojiBtn23.Text = "\uD83E\uDD18\uD83C\uDFFC";
      this.EmojiBtn23.UseVisualStyleBackColor = false;
      this.EmojiBtn23.Click += new EventHandler(this.EmojiBtn23_Click);
      this.EmojiBtn12.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn12.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn12.FlatAppearance.BorderSize = 0;
      this.EmojiBtn12.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn12.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn12.ForeColor = Color.Silver;
      this.EmojiBtn12.Location = new Point(269, 82);
      this.EmojiBtn12.Name = "EmojiBtn12";
      this.EmojiBtn12.Size = new Size(38, 32);
      this.EmojiBtn12.TabIndex = 6319;
      this.EmojiBtn12.Text = "\uD83D\uDE4F\uD83C\uDFFD";
      this.EmojiBtn12.UseVisualStyleBackColor = false;
      this.EmojiBtn12.Click += new EventHandler(this.EmojiBtn12_Click);
      this.EmojiBtn11.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn11.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn11.FlatAppearance.BorderSize = 0;
      this.EmojiBtn11.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn11.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn11.ForeColor = Color.Silver;
      this.EmojiBtn11.Location = new Point(217, 82);
      this.EmojiBtn11.Name = "EmojiBtn11";
      this.EmojiBtn11.Size = new Size(38, 32);
      this.EmojiBtn11.TabIndex = 6318;
      this.EmojiBtn11.Text = "\uD83D\uDCAA\uD83C\uDFFF";
      this.EmojiBtn11.UseVisualStyleBackColor = false;
      this.EmojiBtn11.Click += new EventHandler(this.EmojiBtn11_Click);
      this.EmojiBtn18.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn18.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn18.FlatAppearance.BorderSize = 0;
      this.EmojiBtn18.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn18.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn18.ForeColor = Color.Silver;
      this.EmojiBtn18.Location = new Point(269, 124);
      this.EmojiBtn18.Name = "EmojiBtn18";
      this.EmojiBtn18.Size = new Size(38, 32);
      this.EmojiBtn18.TabIndex = 6317;
      this.EmojiBtn18.Text = "\uD83D\uDE48";
      this.EmojiBtn18.UseVisualStyleBackColor = false;
      this.EmojiBtn18.Click += new EventHandler(this.EmojiBtn18_Click);
      this.EmojiBtn17.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn17.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn17.FlatAppearance.BorderSize = 0;
      this.EmojiBtn17.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn17.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn17.ForeColor = Color.Silver;
      this.EmojiBtn17.Location = new Point(217, 124);
      this.EmojiBtn17.Name = "EmojiBtn17";
      this.EmojiBtn17.Size = new Size(38, 32);
      this.EmojiBtn17.TabIndex = 6316;
      this.EmojiBtn17.Text = "\uD83D\uDD1D";
      this.EmojiBtn17.UseVisualStyleBackColor = false;
      this.EmojiBtn17.Click += new EventHandler(this.EmojiBtn17_Click);
      this.EmojiBtn6.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn6.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn6.FlatAppearance.BorderSize = 0;
      this.EmojiBtn6.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn6.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn6.ForeColor = Color.Silver;
      this.EmojiBtn6.Location = new Point(269, 40);
      this.EmojiBtn6.Name = "EmojiBtn6";
      this.EmojiBtn6.Size = new Size(38, 32);
      this.EmojiBtn6.TabIndex = 6315;
      this.EmojiBtn6.Text = "✔️";
      this.EmojiBtn6.UseVisualStyleBackColor = false;
      this.EmojiBtn6.Click += new EventHandler(this.EmojiBtn6_Click);
      this.EmojiBtn5.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn5.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn5.FlatAppearance.BorderSize = 0;
      this.EmojiBtn5.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn5.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn5.ForeColor = Color.Silver;
      this.EmojiBtn5.Location = new Point(217, 40);
      this.EmojiBtn5.Name = "EmojiBtn5";
      this.EmojiBtn5.Size = new Size(38, 32);
      this.EmojiBtn5.TabIndex = 6314;
      this.EmojiBtn5.Text = "\uD83D\uDCAF";
      this.EmojiBtn5.UseVisualStyleBackColor = false;
      this.EmojiBtn5.Click += new EventHandler(this.EmojiBtn5_Click);
      this.EmojiBtn22.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn22.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn22.FlatAppearance.BorderSize = 0;
      this.EmojiBtn22.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn22.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn22.ForeColor = Color.Silver;
      this.EmojiBtn22.Location = new Point(167, 166);
      this.EmojiBtn22.Name = "EmojiBtn22";
      this.EmojiBtn22.Size = new Size(38, 32);
      this.EmojiBtn22.TabIndex = 6313;
      this.EmojiBtn22.Text = "\uD83D\uDC98";
      this.EmojiBtn22.UseVisualStyleBackColor = false;
      this.EmojiBtn22.Click += new EventHandler(this.EmojiBtn22_Click);
      this.EmojiBtn21.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn21.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn21.FlatAppearance.BorderSize = 0;
      this.EmojiBtn21.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn21.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn21.ForeColor = Color.Silver;
      this.EmojiBtn21.Location = new Point(115, 166);
      this.EmojiBtn21.Name = "EmojiBtn21";
      this.EmojiBtn21.Size = new Size(38, 32);
      this.EmojiBtn21.TabIndex = 6312;
      this.EmojiBtn21.Text = "❣️";
      this.EmojiBtn21.UseVisualStyleBackColor = false;
      this.EmojiBtn21.Click += new EventHandler(this.EmojiBtn21_Click);
      this.EmojiBtn20.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn20.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn20.FlatAppearance.BorderSize = 0;
      this.EmojiBtn20.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn20.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn20.ForeColor = Color.Silver;
      this.EmojiBtn20.Location = new Point(63, 166);
      this.EmojiBtn20.Name = "EmojiBtn20";
      this.EmojiBtn20.Size = new Size(38, 32);
      this.EmojiBtn20.TabIndex = 6311;
      this.EmojiBtn20.Text = "❤️";
      this.EmojiBtn20.UseVisualStyleBackColor = false;
      this.EmojiBtn20.Click += new EventHandler(this.EmojiBtn20_Click);
      this.EmojiBtn19.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn19.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn19.FlatAppearance.BorderSize = 0;
      this.EmojiBtn19.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn19.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn19.ForeColor = Color.Silver;
      this.EmojiBtn19.Location = new Point(11, 166);
      this.EmojiBtn19.Name = "EmojiBtn19";
      this.EmojiBtn19.Size = new Size(38, 32);
      this.EmojiBtn19.TabIndex = 6310;
      this.EmojiBtn19.Text = "\uD83C\uDF46";
      this.EmojiBtn19.UseVisualStyleBackColor = false;
      this.EmojiBtn19.Click += new EventHandler(this.EmojiBtn19_Click);
      this.EmojiBtn16.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn16.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn16.FlatAppearance.BorderSize = 0;
      this.EmojiBtn16.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn16.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn16.ForeColor = Color.Silver;
      this.EmojiBtn16.Location = new Point(167, 124);
      this.EmojiBtn16.Name = "EmojiBtn16";
      this.EmojiBtn16.Size = new Size(38, 32);
      this.EmojiBtn16.TabIndex = 6309;
      this.EmojiBtn16.Text = "\uD83D\uDD96\uD83C\uDFFB";
      this.EmojiBtn16.UseVisualStyleBackColor = false;
      this.EmojiBtn16.Click += new EventHandler(this.EmojiBtn16_Click);
      this.EmojiBtn15.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn15.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn15.FlatAppearance.BorderSize = 0;
      this.EmojiBtn15.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn15.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn15.ForeColor = Color.Silver;
      this.EmojiBtn15.Location = new Point(115, 124);
      this.EmojiBtn15.Name = "EmojiBtn15";
      this.EmojiBtn15.Size = new Size(38, 32);
      this.EmojiBtn15.TabIndex = 6308;
      this.EmojiBtn15.Text = "\uD83D\uDCAA\uD83C\uDFFB";
      this.EmojiBtn15.UseVisualStyleBackColor = false;
      this.EmojiBtn15.Click += new EventHandler(this.EmojiBtn15_Click);
      this.EmojiBtn14.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn14.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn14.FlatAppearance.BorderSize = 0;
      this.EmojiBtn14.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn14.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn14.ForeColor = Color.Silver;
      this.EmojiBtn14.Location = new Point(63, 124);
      this.EmojiBtn14.Name = "EmojiBtn14";
      this.EmojiBtn14.Size = new Size(38, 32);
      this.EmojiBtn14.TabIndex = 6307;
      this.EmojiBtn14.Text = "\uD83D\uDC4D\uD83C\uDFFB";
      this.EmojiBtn14.UseVisualStyleBackColor = false;
      this.EmojiBtn14.Click += new EventHandler(this.EmojiBtn14_Click);
      this.EmojiBtn13.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn13.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn13.FlatAppearance.BorderSize = 0;
      this.EmojiBtn13.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn13.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn13.ForeColor = Color.Silver;
      this.EmojiBtn13.Location = new Point(11, 124);
      this.EmojiBtn13.Name = "EmojiBtn13";
      this.EmojiBtn13.Size = new Size(38, 32);
      this.EmojiBtn13.TabIndex = 6306;
      this.EmojiBtn13.Text = "\uD83D\uDC4C\uD83C\uDFFB";
      this.EmojiBtn13.UseVisualStyleBackColor = false;
      this.EmojiBtn13.Click += new EventHandler(this.EmojiBtn13_Click);
      this.EmojiBtn10.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn10.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn10.FlatAppearance.BorderSize = 0;
      this.EmojiBtn10.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn10.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn10.ForeColor = Color.Silver;
      this.EmojiBtn10.Location = new Point(167, 82);
      this.EmojiBtn10.Name = "EmojiBtn10";
      this.EmojiBtn10.Size = new Size(38, 32);
      this.EmojiBtn10.TabIndex = 6305;
      this.EmojiBtn10.Text = "\uD83D\uDE33";
      this.EmojiBtn10.UseVisualStyleBackColor = false;
      this.EmojiBtn10.Click += new EventHandler(this.EmojiBtn10_Click);
      this.EmojiBtn9.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn9.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn9.FlatAppearance.BorderSize = 0;
      this.EmojiBtn9.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn9.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn9.ForeColor = Color.Silver;
      this.EmojiBtn9.Location = new Point(115, 82);
      this.EmojiBtn9.Name = "EmojiBtn9";
      this.EmojiBtn9.Size = new Size(38, 32);
      this.EmojiBtn9.TabIndex = 6304;
      this.EmojiBtn9.Text = "\uD83D\uDC80";
      this.EmojiBtn9.UseVisualStyleBackColor = false;
      this.EmojiBtn9.Click += new EventHandler(this.EmojiBtn9_Click);
      this.EmojiBtn8.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn8.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn8.FlatAppearance.BorderSize = 0;
      this.EmojiBtn8.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn8.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn8.ForeColor = Color.Silver;
      this.EmojiBtn8.Location = new Point(63, 82);
      this.EmojiBtn8.Name = "EmojiBtn8";
      this.EmojiBtn8.Size = new Size(38, 32);
      this.EmojiBtn8.TabIndex = 6303;
      this.EmojiBtn8.Text = "\uD83D\uDC7D";
      this.EmojiBtn8.UseVisualStyleBackColor = false;
      this.EmojiBtn8.Click += new EventHandler(this.EmojiBtn8_Click);
      this.EmojiBtn7.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn7.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn7.FlatAppearance.BorderSize = 0;
      this.EmojiBtn7.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn7.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn7.ForeColor = Color.Silver;
      this.EmojiBtn7.Location = new Point(11, 82);
      this.EmojiBtn7.Name = "EmojiBtn7";
      this.EmojiBtn7.Size = new Size(38, 32);
      this.EmojiBtn7.TabIndex = 6302;
      this.EmojiBtn7.Text = "\uD83D\uDE0E";
      this.EmojiBtn7.UseVisualStyleBackColor = false;
      this.EmojiBtn7.Click += new EventHandler(this.EmojiBtn7_Click);
      this.EmojiBtn4.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn4.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn4.FlatAppearance.BorderSize = 0;
      this.EmojiBtn4.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn4.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn4.ForeColor = Color.Silver;
      this.EmojiBtn4.Location = new Point(167, 40);
      this.EmojiBtn4.Name = "EmojiBtn4";
      this.EmojiBtn4.Size = new Size(38, 32);
      this.EmojiBtn4.TabIndex = 6301;
      this.EmojiBtn4.Text = "\uD83D\uDE05";
      this.EmojiBtn4.UseVisualStyleBackColor = false;
      this.EmojiBtn4.Click += new EventHandler(this.EmojiBtn4_Click);
      this.EmojiBtn3.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn3.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn3.FlatAppearance.BorderSize = 0;
      this.EmojiBtn3.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn3.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn3.ForeColor = Color.Silver;
      this.EmojiBtn3.Location = new Point(115, 40);
      this.EmojiBtn3.Name = "EmojiBtn3";
      this.EmojiBtn3.Size = new Size(38, 32);
      this.EmojiBtn3.TabIndex = 6300;
      this.EmojiBtn3.Text = "\uD83E\uDD23";
      this.EmojiBtn3.UseVisualStyleBackColor = false;
      this.EmojiBtn3.Click += new EventHandler(this.EmojiBtn3_Click);
      this.EmojiBtn2.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn2.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn2.FlatAppearance.BorderSize = 0;
      this.EmojiBtn2.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn2.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn2.ForeColor = Color.Silver;
      this.EmojiBtn2.Location = new Point(63, 40);
      this.EmojiBtn2.Name = "EmojiBtn2";
      this.EmojiBtn2.Size = new Size(38, 32);
      this.EmojiBtn2.TabIndex = 6299;
      this.EmojiBtn2.Text = "\uD83D\uDE02";
      this.EmojiBtn2.UseVisualStyleBackColor = false;
      this.EmojiBtn2.Click += new EventHandler(this.EmojiBtn2_Click);
      this.EmojiBtn1.BackColor = Color.FromArgb(56, 59, 63);
      this.EmojiBtn1.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn1.FlatAppearance.BorderSize = 0;
      this.EmojiBtn1.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn1.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.EmojiBtn1.ForeColor = Color.Silver;
      this.EmojiBtn1.Location = new Point(11, 40);
      this.EmojiBtn1.Name = "EmojiBtn1";
      this.EmojiBtn1.Size = new Size(38, 32);
      this.EmojiBtn1.TabIndex = 6298;
      this.EmojiBtn1.Text = "\uD83D\uDE00";
      this.EmojiBtn1.UseVisualStyleBackColor = false;
      this.EmojiBtn1.Click += new EventHandler(this.EmojiBtn1_Click);
      this.MoreBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.MoreBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.MoreBtn.FlatAppearance.BorderSize = 0;
      this.MoreBtn.FlatStyle = FlatStyle.Flat;
      this.MoreBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.MoreBtn.ForeColor = Color.Silver;
      this.MoreBtn.Location = new Point(241, 214);
      this.MoreBtn.Name = "MoreBtn";
      this.MoreBtn.Size = new Size(80, 22);
      this.MoreBtn.TabIndex = 6322;
      this.MoreBtn.Text = "More Emojis";
      this.MoreBtn.UseVisualStyleBackColor = false;
      this.MoreBtn.Click += new EventHandler(this.MoreBtn_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(321, 236);
      this.Controls.Add((Control) this.EmojiBtn24);
      this.Controls.Add((Control) this.EmojiBtn23);
      this.Controls.Add((Control) this.EmojiBtn12);
      this.Controls.Add((Control) this.EmojiBtn11);
      this.Controls.Add((Control) this.EmojiBtn18);
      this.Controls.Add((Control) this.EmojiBtn17);
      this.Controls.Add((Control) this.EmojiBtn6);
      this.Controls.Add((Control) this.EmojiBtn5);
      this.Controls.Add((Control) this.EmojiBtn22);
      this.Controls.Add((Control) this.EmojiBtn21);
      this.Controls.Add((Control) this.EmojiBtn20);
      this.Controls.Add((Control) this.EmojiBtn19);
      this.Controls.Add((Control) this.EmojiBtn16);
      this.Controls.Add((Control) this.EmojiBtn15);
      this.Controls.Add((Control) this.EmojiBtn14);
      this.Controls.Add((Control) this.EmojiBtn13);
      this.Controls.Add((Control) this.EmojiBtn10);
      this.Controls.Add((Control) this.EmojiBtn9);
      this.Controls.Add((Control) this.EmojiBtn8);
      this.Controls.Add((Control) this.EmojiBtn7);
      this.Controls.Add((Control) this.EmojiBtn4);
      this.Controls.Add((Control) this.EmojiBtn3);
      this.Controls.Add((Control) this.EmojiBtn2);
      this.Controls.Add((Control) this.EmojiBtn1);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.Controls.Add((Control) this.MoreBtn);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (EmojiList);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Discord Raider | Emojis";
      this.FormClosing += new FormClosingEventHandler(this.EmojiList_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
