using DiscordRaider.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class FormSettings : Form
  {
    public static bool _SaveToken;
    public static bool _HideTokens;
    public static bool _Credits;
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
    private Panel TokenPnl;
    private RoundBtn SaveTokenBtn;
    private Panel panel54;
    private Label SavedLbl;
    private Panel CreditsPnl;
    private Label CreditsLbl;
    private RoundBtn CreditsBtn;
    private Panel panel2;
    private Panel HidePnl;
    private Label HideLbl;
    private RoundBtn HideTokensBtn;
    private Panel panel6;

    public FormSettings()
    {
      this.InitializeComponent();
      this.ChangeCorners();
      this.ChangeTokenPnl();
      this.ChangeHidePnl();
      this.ChangeCreditsPnl();
      this.LoadStuff();
    }

    private void LoadStuff()
    {
      if (Settings.Default._SaveTokens)
      {
        FormSettings._SaveToken = true;
        this.SavedLbl.Text = "ON";
      }
      else
      {
        FormSettings._SaveToken = false;
        this.SavedLbl.Text = "OFF";
      }
      if (Settings.Default._HideTokens)
      {
        FormSettings._HideTokens = true;
        this.HideLbl.Text = "ON";
      }
      else
      {
        FormSettings._HideTokens = false;
        this.HideLbl.Text = "OFF";
      }
      if (Settings.Default._GiveCredits)
      {
        FormSettings._Credits = true;
        this.CreditsLbl.Text = "ON";
      }
      else
      {
        FormSettings._Credits = false;
        this.CreditsLbl.Text = "OFF";
      }
    }

    public static void CheckStuff()
    {
      FormSettings._SaveToken = Settings.Default._SaveTokens;
      FormSettings._HideTokens = Settings.Default._HideTokens;
      if (Settings.Default._GiveCredits)
        FormSettings._Credits = true;
      else
        FormSettings._Credits = false;
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

    private void ChangeTokenPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.TokenPnl.Width, this.TokenPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.TokenPnl.Region = new Region(path);
    }

    private void ChangeHidePnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.HidePnl.Width, this.HidePnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.HidePnl.Region = new Region(path);
    }

    private void ChangeCreditsPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.CreditsPnl.Width, this.CreditsPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.CreditsPnl.Region = new Region(path);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      Main._SettingsForm = false;
      this.Close();
    }

    private void SaveTokenBtn_Click(object sender, EventArgs e)
    {
      if (FormSettings._SaveToken)
      {
        FormSettings._SaveToken = false;
        Settings.Default._SaveTokens = false;
        Settings.Default.Save();
        this.SavedLbl.Text = "OFF";
      }
      else
      {
        FormSettings._SaveToken = true;
        Settings.Default._SaveTokens = true;
        Settings.Default.Save();
        this.SavedLbl.Text = "ON";
      }
    }

    private void HideTokensBtn_Click(object sender, EventArgs e)
    {
      if (FormSettings._HideTokens)
      {
        FormSettings._HideTokens = false;
        Settings.Default._HideTokens = false;
        Settings.Default.Save();
        this.HideLbl.Text = "OFF";
      }
      else
      {
        FormSettings._HideTokens = true;
        Settings.Default._HideTokens = true;
        Settings.Default.Save();
        this.HideLbl.Text = "ON";
      }
    }

    private void CreditsBtn_Click(object sender, EventArgs e)
    {
      if (FormSettings._Credits)
      {
        FormSettings._Credits = false;
        Settings.Default._GiveCredits = false;
        Settings.Default.Save();
        this.CreditsLbl.Text = "OFF";
      }
      else
      {
        FormSettings._Credits = true;
        Settings.Default._GiveCredits = true;
        Settings.Default.Save();
        this.CreditsLbl.Text = "ON";
      }
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

    private void FormSettings_FormClosing(object sender, FormClosingEventArgs e) => Main._SettingsForm = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSettings));
      this.panel37 = new Panel();
      this.HeadLinePnlInf = new Panel();
      this.CloseBtn = new Button();
      this.panel24 = new Panel();
      this.HeadServerLbl = new Label();
      this.panel25 = new Panel();
      this.comboBox3 = new ComboBox();
      this.textBox3 = new TextBox();
      this.button4 = new Button();
      this.panel26 = new Panel();
      this.panel27 = new Panel();
      this.panel36 = new Panel();
      this.TokenPnl = new Panel();
      this.SavedLbl = new Label();
      this.SaveTokenBtn = new RoundBtn();
      this.panel54 = new Panel();
      this.CreditsPnl = new Panel();
      this.CreditsLbl = new Label();
      this.CreditsBtn = new RoundBtn();
      this.panel2 = new Panel();
      this.HidePnl = new Panel();
      this.HideLbl = new Label();
      this.HideTokensBtn = new RoundBtn();
      this.panel6 = new Panel();
      this.HeadLinePnlInf.SuspendLayout();
      this.TokenPnl.SuspendLayout();
      this.CreditsPnl.SuspendLayout();
      this.HidePnl.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1507, 174);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6303;
      this.HeadLinePnlInf.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnlInf.Controls.Add((Control) this.CloseBtn);
      this.HeadLinePnlInf.Controls.Add((Control) this.panel24);
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
      this.HeadLinePnlInf.Size = new Size(226, 29);
      this.HeadLinePnlInf.TabIndex = 6302;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(200, -1);
      this.CloseBtn.Name = "CloseBtn";
      this.CloseBtn.Size = new Size(26, 27);
      this.CloseBtn.TabIndex = 6167;
      this.CloseBtn.Text = "r";
      this.CloseBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseBtn.UseVisualStyleBackColor = false;
      this.CloseBtn.Click += new EventHandler(this.CloseBtn_Click);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(12, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(201, 2);
      this.panel24.TabIndex = 6222;
      this.HeadServerLbl.AutoSize = true;
      this.HeadServerLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.HeadServerLbl.ForeColor = Color.White;
      this.HeadServerLbl.Location = new Point(39, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(145, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "RAIDER SETTINGS";
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
      this.TokenPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.TokenPnl.Controls.Add((Control) this.SavedLbl);
      this.TokenPnl.Controls.Add((Control) this.SaveTokenBtn);
      this.TokenPnl.Controls.Add((Control) this.panel54);
      this.TokenPnl.Location = new Point(12, 41);
      this.TokenPnl.Name = "TokenPnl";
      this.TokenPnl.Size = new Size(201, 34);
      this.TokenPnl.TabIndex = 6304;
      this.SavedLbl.AutoSize = true;
      this.SavedLbl.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SavedLbl.ForeColor = Color.White;
      this.SavedLbl.Location = new Point(158, 6);
      this.SavedLbl.Name = "SavedLbl";
      this.SavedLbl.Size = new Size(38, 21);
      this.SavedLbl.TabIndex = 6318;
      this.SavedLbl.Text = "OFF";
      this.SaveTokenBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.SaveTokenBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.SaveTokenBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.SaveTokenBtn.FlatAppearance.BorderSize = 0;
      this.SaveTokenBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.SaveTokenBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.SaveTokenBtn.FlatStyle = FlatStyle.Flat;
      this.SaveTokenBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.SaveTokenBtn.Location = new Point(5, 6);
      this.SaveTokenBtn.Name = "SaveTokenBtn";
      this.SaveTokenBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.SaveTokenBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.SaveTokenBtn.OnHoverTextColor = Color.White;
      this.SaveTokenBtn.Size = new Size(138, 22);
      this.SaveTokenBtn.TabIndex = 6317;
      this.SaveTokenBtn.Text = " SAVE TOKENS";
      this.SaveTokenBtn.TextColor = Color.White;
      this.SaveTokenBtn.UseVisualStyleBackColor = true;
      this.SaveTokenBtn.Click += new EventHandler(this.SaveTokenBtn_Click);
      this.panel54.BackColor = Color.FromArgb(56, 56, 56);
      this.panel54.Location = new Point(149, -60);
      this.panel54.Name = "panel54";
      this.panel54.Size = new Size(3, 148);
      this.panel54.TabIndex = 6277;
      this.CreditsPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.CreditsPnl.Controls.Add((Control) this.CreditsLbl);
      this.CreditsPnl.Controls.Add((Control) this.CreditsBtn);
      this.CreditsPnl.Controls.Add((Control) this.panel2);
      this.CreditsPnl.Location = new Point(12, (int) sbyte.MaxValue);
      this.CreditsPnl.Name = "CreditsPnl";
      this.CreditsPnl.Size = new Size(201, 34);
      this.CreditsPnl.TabIndex = 6305;
      this.CreditsLbl.AutoSize = true;
      this.CreditsLbl.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.CreditsLbl.ForeColor = Color.White;
      this.CreditsLbl.Location = new Point(158, 6);
      this.CreditsLbl.Name = "CreditsLbl";
      this.CreditsLbl.Size = new Size(38, 21);
      this.CreditsLbl.TabIndex = 6318;
      this.CreditsLbl.Text = "OFF";
      this.CreditsBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.CreditsBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.CreditsBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.CreditsBtn.FlatAppearance.BorderSize = 0;
      this.CreditsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.CreditsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.CreditsBtn.FlatStyle = FlatStyle.Flat;
      this.CreditsBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.CreditsBtn.Location = new Point(5, 6);
      this.CreditsBtn.Name = "CreditsBtn";
      this.CreditsBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.CreditsBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.CreditsBtn.OnHoverTextColor = Color.White;
      this.CreditsBtn.Size = new Size(138, 22);
      this.CreditsBtn.TabIndex = 6317;
      this.CreditsBtn.Text = "GIVE CREDITS";
      this.CreditsBtn.TextColor = Color.White;
      this.CreditsBtn.UseVisualStyleBackColor = true;
      this.CreditsBtn.Click += new EventHandler(this.CreditsBtn_Click);
      this.panel2.BackColor = Color.FromArgb(56, 56, 56);
      this.panel2.Location = new Point(149, -60);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(3, 148);
      this.panel2.TabIndex = 6277;
      this.HidePnl.BackColor = Color.FromArgb(49, 50, 55);
      this.HidePnl.Controls.Add((Control) this.HideLbl);
      this.HidePnl.Controls.Add((Control) this.HideTokensBtn);
      this.HidePnl.Controls.Add((Control) this.panel6);
      this.HidePnl.Location = new Point(12, 84);
      this.HidePnl.Name = "HidePnl";
      this.HidePnl.Size = new Size(201, 34);
      this.HidePnl.TabIndex = 6307;
      this.HideLbl.AutoSize = true;
      this.HideLbl.Font = new Font("Segoe UI", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.HideLbl.ForeColor = Color.White;
      this.HideLbl.Location = new Point(158, 6);
      this.HideLbl.Name = "HideLbl";
      this.HideLbl.Size = new Size(38, 21);
      this.HideLbl.TabIndex = 6318;
      this.HideLbl.Text = "OFF";
      this.HideTokensBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.HideTokensBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.HideTokensBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.HideTokensBtn.FlatAppearance.BorderSize = 0;
      this.HideTokensBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.HideTokensBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.HideTokensBtn.FlatStyle = FlatStyle.Flat;
      this.HideTokensBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.HideTokensBtn.Location = new Point(5, 6);
      this.HideTokensBtn.Name = "HideTokensBtn";
      this.HideTokensBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.HideTokensBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.HideTokensBtn.OnHoverTextColor = Color.White;
      this.HideTokensBtn.Size = new Size(138, 22);
      this.HideTokensBtn.TabIndex = 6317;
      this.HideTokensBtn.Text = "HIDE TOKENS";
      this.HideTokensBtn.TextColor = Color.White;
      this.HideTokensBtn.UseVisualStyleBackColor = true;
      this.HideTokensBtn.Click += new EventHandler(this.HideTokensBtn_Click);
      this.panel6.BackColor = Color.FromArgb(56, 56, 56);
      this.panel6.Location = new Point(149, -60);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(3, 148);
      this.panel6.TabIndex = 6277;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(226, 190);
      this.Controls.Add((Control) this.HidePnl);
      this.Controls.Add((Control) this.CreditsPnl);
      this.Controls.Add((Control) this.TokenPnl);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (FormSettings);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Settings";
      this.FormClosing += new FormClosingEventHandler(this.FormSettings_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.TokenPnl.ResumeLayout(false);
      this.TokenPnl.PerformLayout();
      this.CreditsPnl.ResumeLayout(false);
      this.CreditsPnl.PerformLayout();
      this.HidePnl.ResumeLayout(false);
      this.HidePnl.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
