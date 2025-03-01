using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class TextStuff : Form
  {
    private IContainer components;
    private Panel HeadLinePnlInf;
    private Panel panel24;
    private Button CloseServerInfBtn;
    private Label HeadServerLbl;
    private Panel panel25;
    private ComboBox comboBox3;
    private TextBox textBox3;
    private Button button4;
    private Panel panel26;
    private Panel panel27;
    private Panel panel36;
    private Panel panel37;
    private Button GenCrashBtn;
    private Button CopyBtn;
    private Button GenBtn;
    private Panel panel50;
    private Panel panel51;
    private Panel panel52;
    private Panel panel53;
    private TextBox OutputText;
    private TextBox crashbox;

    public TextStuff()
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

    private void GenBtn_Click(object sender, EventArgs e)
    {
      this.OutputText.Text = "";
      int int32 = Convert.ToInt32(2000);
      string element = "" + "0123456789" + "~!@#$%^&*_-" + "ヅ⇝➤♀꧁꧂☣☠╭∩╮（︶︿︶）:̤̈ẅ̤̤̈d̤̈:龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘龘";
      Random _rnd = new Random();
      int count = int32;
      this.OutputText.Text = new string(Enumerable.Repeat<string>(element, count).Select<string, char>((Func<string, char>) (s => s[_rnd.Next(s.Length)])).ToArray<char>());
    }

    private void GenCrashBtn_Click(object sender, EventArgs e) => this.OutputText.Text = this.crashbox.Text;

    private void CopyBtn_Click(object sender, EventArgs e) => Clipboard.SetText(this.OutputText.Text);

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

    private void CloseServerInfBtn_Click(object sender, EventArgs e)
    {
      SpamMain._TextStuff = false;
      this.Close();
    }

    private void TextStuff_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._TextStuff = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (TextStuff));
      this.HeadLinePnlInf = new Panel();
      this.panel24 = new Panel();
      this.CloseServerInfBtn = new Button();
      this.HeadServerLbl = new Label();
      this.panel25 = new Panel();
      this.comboBox3 = new ComboBox();
      this.textBox3 = new TextBox();
      this.button4 = new Button();
      this.panel26 = new Panel();
      this.panel27 = new Panel();
      this.panel36 = new Panel();
      this.panel37 = new Panel();
      this.GenCrashBtn = new Button();
      this.CopyBtn = new Button();
      this.GenBtn = new Button();
      this.panel50 = new Panel();
      this.panel51 = new Panel();
      this.panel52 = new Panel();
      this.panel53 = new Panel();
      this.OutputText = new TextBox();
      this.crashbox = new TextBox();
      this.HeadLinePnlInf.SuspendLayout();
      this.SuspendLayout();
      this.HeadLinePnlInf.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel24);
      this.HeadLinePnlInf.Controls.Add((Control) this.CloseServerInfBtn);
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
      this.HeadLinePnlInf.Size = new Size(329, 29);
      this.HeadLinePnlInf.TabIndex = 6296;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(14, 25);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(296, 2);
      this.panel24.TabIndex = 6222;
      this.CloseServerInfBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseServerInfBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseServerInfBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseServerInfBtn.FlatAppearance.BorderSize = 0;
      this.CloseServerInfBtn.FlatStyle = FlatStyle.Flat;
      this.CloseServerInfBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseServerInfBtn.ForeColor = Color.White;
      this.CloseServerInfBtn.Location = new Point(304, -1);
      this.CloseServerInfBtn.Name = "CloseServerInfBtn";
      this.CloseServerInfBtn.Size = new Size(26, 27);
      this.CloseServerInfBtn.TabIndex = 6167;
      this.CloseServerInfBtn.Text = "r";
      this.CloseServerInfBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseServerInfBtn.UseVisualStyleBackColor = false;
      this.CloseServerInfBtn.Click += new EventHandler(this.CloseServerInfBtn_Click);
      this.HeadServerLbl.AutoSize = true;
      this.HeadServerLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.HeadServerLbl.ForeColor = Color.White;
      this.HeadServerLbl.Location = new Point(82, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(161, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "RANDOM TEXT GEN";
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
      this.panel37.Location = new Point(0, 207);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(387, 2);
      this.panel37.TabIndex = 6297;
      this.GenCrashBtn.BackColor = Color.FromArgb(56, 59, 63);
      this.GenCrashBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.GenCrashBtn.FlatAppearance.BorderSize = 0;
      this.GenCrashBtn.FlatStyle = FlatStyle.Flat;
      this.GenCrashBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.GenCrashBtn.ForeColor = Color.Silver;
      this.GenCrashBtn.Location = new Point(165, 39);
      this.GenCrashBtn.Name = "GenCrashBtn";
      this.GenCrashBtn.Size = new Size(150, 23);
      this.GenCrashBtn.TabIndex = 6305;
      this.GenCrashBtn.Text = "Create Crashtext";
      this.GenCrashBtn.UseVisualStyleBackColor = false;
      this.GenCrashBtn.Click += new EventHandler(this.GenCrashBtn_Click);
      this.CopyBtn.BackColor = Color.FromArgb(56, 59, 63);
      this.CopyBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.CopyBtn.FlatAppearance.BorderSize = 0;
      this.CopyBtn.FlatStyle = FlatStyle.Flat;
      this.CopyBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.CopyBtn.ForeColor = Color.Silver;
      this.CopyBtn.Location = new Point(14, 170);
      this.CopyBtn.Name = "CopyBtn";
      this.CopyBtn.Size = new Size(301, 23);
      this.CopyBtn.TabIndex = 6304;
      this.CopyBtn.Text = "Copy To Clipboard";
      this.CopyBtn.UseVisualStyleBackColor = false;
      this.CopyBtn.Click += new EventHandler(this.CopyBtn_Click);
      this.GenBtn.BackColor = Color.FromArgb(56, 59, 63);
      this.GenBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.GenBtn.FlatAppearance.BorderSize = 0;
      this.GenBtn.FlatStyle = FlatStyle.Flat;
      this.GenBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.GenBtn.ForeColor = Color.Silver;
      this.GenBtn.Location = new Point(13, 39);
      this.GenBtn.Name = "GenBtn";
      this.GenBtn.Size = new Size(146, 23);
      this.GenBtn.TabIndex = 6303;
      this.GenBtn.Text = "Generate";
      this.GenBtn.UseVisualStyleBackColor = false;
      this.GenBtn.Click += new EventHandler(this.GenBtn_Click);
      this.panel50.BackColor = Color.FromArgb(51, 51, 51);
      this.panel50.Font = new Font("Segoe UI", 9f);
      this.panel50.Location = new Point(14, 68);
      this.panel50.Name = "panel50";
      this.panel50.Size = new Size(2, 96);
      this.panel50.TabIndex = 6302;
      this.panel51.BackColor = Color.FromArgb(51, 51, 51);
      this.panel51.Font = new Font("Segoe UI", 9f);
      this.panel51.Location = new Point(313, 68);
      this.panel51.Name = "panel51";
      this.panel51.Size = new Size(2, 96);
      this.panel51.TabIndex = 6301;
      this.panel52.BackColor = Color.FromArgb(51, 51, 51);
      this.panel52.Font = new Font("Segoe UI", 9f);
      this.panel52.Location = new Point(16, 68);
      this.panel52.Name = "panel52";
      this.panel52.Size = new Size(298, 2);
      this.panel52.TabIndex = 6300;
      this.panel53.BackColor = Color.FromArgb(51, 51, 51);
      this.panel53.Font = new Font("Segoe UI", 9f);
      this.panel53.Location = new Point(16, 162);
      this.panel53.Name = "panel53";
      this.panel53.Size = new Size(299, 2);
      this.panel53.TabIndex = 6299;
      this.OutputText.BackColor = Color.FromArgb(33, 34, 38);
      this.OutputText.BorderStyle = BorderStyle.None;
      this.OutputText.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.OutputText.ForeColor = Color.Silver;
      this.OutputText.Location = new Point(16, 71);
      this.OutputText.Multiline = true;
      this.OutputText.Name = "OutputText";
      this.OutputText.Size = new Size(297, 90);
      this.OutputText.TabIndex = 6298;
      this.OutputText.Text = "Your Message";
      this.crashbox.BackColor = Color.FromArgb(25, 25, 25);
      this.crashbox.BorderStyle = BorderStyle.None;
      this.crashbox.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.crashbox.ForeColor = Color.Silver;
      this.crashbox.Location = new Point(305, 254);
      this.crashbox.Multiline = true;
      this.crashbox.Name = "crashbox";
      this.crashbox.Size = new Size(10, 28);
      this.crashbox.TabIndex = 6306;
      this.crashbox.Text = componentResourceManager.GetString("crashbox.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(329, 225);
      this.Controls.Add((Control) this.crashbox);
      this.Controls.Add((Control) this.GenCrashBtn);
      this.Controls.Add((Control) this.CopyBtn);
      this.Controls.Add((Control) this.GenBtn);
      this.Controls.Add((Control) this.panel50);
      this.Controls.Add((Control) this.panel51);
      this.Controls.Add((Control) this.panel52);
      this.Controls.Add((Control) this.panel53);
      this.Controls.Add((Control) this.OutputText);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (TextStuff);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Discord Raider | Text Stuff";
      this.FormClosing += new FormClosingEventHandler(this.TextStuff_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
