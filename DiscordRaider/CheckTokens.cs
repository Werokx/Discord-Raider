using RaidAPI.TokenSettings;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class CheckTokens : Form
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
    private Panel panel22;
    private RichTextBox VerifiedTextBox;
    private Panel panel1;
    private Button VerifiedBtn;
    private Panel panel3;
    private Button UnverifiedBtn;
    private Panel panel18;
    private Label VerifiedLbl;
    private TabControl TokenTab;
    private TabPage VerifiedPage;
    private TabPage UnverifiedPage;
    private Label UnverifiedLbl;
    private Panel panel2;
    private RichTextBox UnverifiedTextBox;
    private TabPage InvalidPage;
    private Label Invalidlbl;
    private Panel panel4;
    private RichTextBox InvalidTextBox;
    private Panel panel5;
    private Button InvalidBtn;
    private Panel panel60;
    private Panel panel6;
    private Panel panel7;
    private Panel panel9;
    private Panel panel8;
    private Panel panel58;
    private Panel panel59;
    private Panel panel10;
    private Panel panel11;
    private Panel panel13;
    private Panel panel12;
    private Panel panel57;
    private Panel panel14;
    private Panel panel15;
    private Panel panel16;
    private Panel panel17;

    public CheckTokens()
    {
      this.InitializeComponent();
      this.CheckTokensByAPI();
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

    private void CheckTokensByAPI()
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int) MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        CkeckToken.TokenPath = SpamMain._TokenPath;
        CkeckToken.StartCheck();
        this.VerifiedLbl.Text = "VERIFIED TOKENS: " + Convert.ToString(CkeckToken._Verified);
        this.VerifiedTextBox.AppendText(File.ReadAllText("Verified.txt"));
        this.UnverifiedLbl.Text = "UNVERIFIED TOKENS: " + Convert.ToString(CkeckToken._UnVerified);
        this.UnverifiedTextBox.AppendText(File.ReadAllText("Unverified.txt"));
        this.Invalidlbl.Text = "INVALID TOKENS: " + Convert.ToString(CkeckToken._Invalid);
        this.InvalidTextBox.AppendText(File.ReadAllText("Invalid.txt"));
      }
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      SpamMain._CheckTokenForm = false;
      this.Close();
    }

    private void VerifiedBtn_Click(object sender, EventArgs e)
    {
      this.VerifiedLbl.Text = "";
      this.TokenTab.SelectedTab = this.VerifiedPage;
      this.VerifiedLbl.Text = "VERIFIED TOKENS: " + Convert.ToString(CkeckToken._Verified);
      this.VerifiedTextBox.AppendText(File.ReadAllText("Verified.txt"));
      CkeckToken.StartCheck();
    }

    private void UnverifiedBtn_Click(object sender, EventArgs e)
    {
      this.UnverifiedLbl.Text = "";
      this.TokenTab.SelectedTab = this.UnverifiedPage;
      this.UnverifiedLbl.Text = "UNVERIFIED TOKENS: " + Convert.ToString(CkeckToken._UnVerified);
      this.UnverifiedTextBox.AppendText(File.ReadAllText("Unverified.txt"));
      CkeckToken.StartCheck();
    }

    private void InvalidBtn_Click(object sender, EventArgs e)
    {
      this.Invalidlbl.Text = "";
      this.TokenTab.SelectedTab = this.InvalidPage;
      this.Invalidlbl.Text = "INVALID TOKENS: " + Convert.ToString(CkeckToken._Invalid);
      this.InvalidTextBox.AppendText(File.ReadAllText("Invalid.txt"));
      CkeckToken.StartCheck();
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

    private void CheckTokens_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._CheckTokenForm = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CheckTokens));
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
      this.panel22 = new Panel();
      this.VerifiedTextBox = new RichTextBox();
      this.panel1 = new Panel();
      this.panel5 = new Panel();
      this.panel3 = new Panel();
      this.InvalidBtn = new Button();
      this.UnverifiedBtn = new Button();
      this.panel18 = new Panel();
      this.VerifiedBtn = new Button();
      this.VerifiedLbl = new Label();
      this.TokenTab = new TabControl();
      this.VerifiedPage = new TabPage();
      this.UnverifiedPage = new TabPage();
      this.UnverifiedLbl = new Label();
      this.panel2 = new Panel();
      this.UnverifiedTextBox = new RichTextBox();
      this.InvalidPage = new TabPage();
      this.Invalidlbl = new Label();
      this.panel4 = new Panel();
      this.InvalidTextBox = new RichTextBox();
      this.panel60 = new Panel();
      this.panel6 = new Panel();
      this.panel7 = new Panel();
      this.panel58 = new Panel();
      this.panel8 = new Panel();
      this.panel9 = new Panel();
      this.panel59 = new Panel();
      this.panel10 = new Panel();
      this.panel11 = new Panel();
      this.panel57 = new Panel();
      this.panel12 = new Panel();
      this.panel13 = new Panel();
      this.panel14 = new Panel();
      this.panel15 = new Panel();
      this.panel16 = new Panel();
      this.panel17 = new Panel();
      this.HeadLinePnlInf.SuspendLayout();
      this.panel22.SuspendLayout();
      this.panel1.SuspendLayout();
      this.TokenTab.SuspendLayout();
      this.VerifiedPage.SuspendLayout();
      this.UnverifiedPage.SuspendLayout();
      this.panel2.SuspendLayout();
      this.InvalidPage.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel14.SuspendLayout();
      this.panel16.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1603, 238);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6304;
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
      this.HeadLinePnlInf.Size = new Size(523, 29);
      this.HeadLinePnlInf.TabIndex = 6303;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(18, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(496, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(497, -1);
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
      this.HeadServerLbl.Location = new Point(150, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(201, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "CHECK DISCORD TOKENS";
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
      this.panel22.BackColor = Color.FromArgb(49, 50, 55);
      this.panel22.Controls.Add((Control) this.panel13);
      this.panel22.Controls.Add((Control) this.panel59);
      this.panel22.Controls.Add((Control) this.panel9);
      this.panel22.Controls.Add((Control) this.panel60);
      this.panel22.Controls.Add((Control) this.VerifiedTextBox);
      this.panel22.Location = new Point(14, 28);
      this.panel22.Name = "panel22";
      this.panel22.Size = new Size(496, 121);
      this.panel22.TabIndex = 6311;
      this.VerifiedTextBox.BackColor = Color.FromArgb(33, 34, 38);
      this.VerifiedTextBox.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.VerifiedTextBox.ForeColor = Color.Silver;
      this.VerifiedTextBox.Location = new Point(-2, -2);
      this.VerifiedTextBox.Name = "VerifiedTextBox";
      this.VerifiedTextBox.Size = new Size(573, 156);
      this.VerifiedTextBox.TabIndex = 6284;
      this.VerifiedTextBox.Text = "";
      this.panel1.BackColor = Color.FromArgb(49, 50, 55);
      this.panel1.Controls.Add((Control) this.panel5);
      this.panel1.Controls.Add((Control) this.panel3);
      this.panel1.Controls.Add((Control) this.InvalidBtn);
      this.panel1.Controls.Add((Control) this.UnverifiedBtn);
      this.panel1.Controls.Add((Control) this.panel18);
      this.panel1.Controls.Add((Control) this.VerifiedBtn);
      this.panel1.Location = new Point(14, 193);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(496, 33);
      this.panel1.TabIndex = 6312;
      this.panel5.BackColor = Color.FromArgb(56, 56, 56);
      this.panel5.Location = new Point(499, -58);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(3, 148);
      this.panel5.TabIndex = 6288;
      this.panel3.BackColor = Color.FromArgb(56, 56, 56);
      this.panel3.Location = new Point(340, -12);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(3, 148);
      this.panel3.TabIndex = 6283;
      this.InvalidBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.InvalidBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.InvalidBtn.FlatAppearance.BorderSize = 0;
      this.InvalidBtn.FlatStyle = FlatStyle.Flat;
      this.InvalidBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.InvalidBtn.ForeColor = Color.WhiteSmoke;
      this.InvalidBtn.Location = new Point(349, 5);
      this.InvalidBtn.Name = "InvalidBtn";
      this.InvalidBtn.Size = new Size(140, 22);
      this.InvalidBtn.TabIndex = 6287;
      this.InvalidBtn.Text = "GET INVALID TOKENS";
      this.InvalidBtn.UseVisualStyleBackColor = false;
      this.InvalidBtn.Click += new EventHandler(this.InvalidBtn_Click);
      this.UnverifiedBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.UnverifiedBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.UnverifiedBtn.FlatAppearance.BorderSize = 0;
      this.UnverifiedBtn.FlatStyle = FlatStyle.Flat;
      this.UnverifiedBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.UnverifiedBtn.ForeColor = Color.WhiteSmoke;
      this.UnverifiedBtn.Location = new Point(168, 5);
      this.UnverifiedBtn.Name = "UnverifiedBtn";
      this.UnverifiedBtn.Size = new Size(168, 22);
      this.UnverifiedBtn.TabIndex = 6286;
      this.UnverifiedBtn.Text = "GET UNVERIFIED TOKENS";
      this.UnverifiedBtn.UseVisualStyleBackColor = false;
      this.UnverifiedBtn.Click += new EventHandler(this.UnverifiedBtn_Click);
      this.panel18.BackColor = Color.FromArgb(56, 56, 56);
      this.panel18.Location = new Point(160, -58);
      this.panel18.Name = "panel18";
      this.panel18.Size = new Size(3, 148);
      this.panel18.TabIndex = 6285;
      this.VerifiedBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.VerifiedBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.VerifiedBtn.FlatAppearance.BorderSize = 0;
      this.VerifiedBtn.FlatStyle = FlatStyle.Flat;
      this.VerifiedBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.VerifiedBtn.ForeColor = Color.WhiteSmoke;
      this.VerifiedBtn.Location = new Point(6, 5);
      this.VerifiedBtn.Name = "VerifiedBtn";
      this.VerifiedBtn.Size = new Size(148, 22);
      this.VerifiedBtn.TabIndex = 6284;
      this.VerifiedBtn.Text = "GET VERIFIED TOKENS";
      this.VerifiedBtn.UseVisualStyleBackColor = false;
      this.VerifiedBtn.Click += new EventHandler(this.VerifiedBtn_Click);
      this.VerifiedLbl.AutoSize = true;
      this.VerifiedLbl.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.VerifiedLbl.ForeColor = Color.White;
      this.VerifiedLbl.Location = new Point(15, 9);
      this.VerifiedLbl.Name = "VerifiedLbl";
      this.VerifiedLbl.Size = new Size(122, 16);
      this.VerifiedLbl.TabIndex = 6313;
      this.VerifiedLbl.Text = "VERIFIED TOKENS:";
      this.TokenTab.Controls.Add((Control) this.VerifiedPage);
      this.TokenTab.Controls.Add((Control) this.UnverifiedPage);
      this.TokenTab.Controls.Add((Control) this.InvalidPage);
      this.TokenTab.Location = new Point(-4, 7);
      this.TokenTab.Name = "TokenTab";
      this.TokenTab.SelectedIndex = 0;
      this.TokenTab.Size = new Size(548, 190);
      this.TokenTab.TabIndex = 6314;
      this.VerifiedPage.BackColor = Color.FromArgb(33, 34, 38);
      this.VerifiedPage.Controls.Add((Control) this.VerifiedLbl);
      this.VerifiedPage.Controls.Add((Control) this.panel22);
      this.VerifiedPage.Location = new Point(4, 22);
      this.VerifiedPage.Name = "VerifiedPage";
      this.VerifiedPage.Padding = new Padding(3);
      this.VerifiedPage.Size = new Size(540, 164);
      this.VerifiedPage.TabIndex = 0;
      this.VerifiedPage.Text = "workingtokens";
      this.UnverifiedPage.BackColor = Color.FromArgb(33, 34, 38);
      this.UnverifiedPage.Controls.Add((Control) this.UnverifiedLbl);
      this.UnverifiedPage.Controls.Add((Control) this.panel2);
      this.UnverifiedPage.Location = new Point(4, 22);
      this.UnverifiedPage.Name = "UnverifiedPage";
      this.UnverifiedPage.Padding = new Padding(3);
      this.UnverifiedPage.Size = new Size(540, 164);
      this.UnverifiedPage.TabIndex = 1;
      this.UnverifiedPage.Text = "verifiedtokens";
      this.UnverifiedLbl.AutoSize = true;
      this.UnverifiedLbl.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.UnverifiedLbl.ForeColor = Color.White;
      this.UnverifiedLbl.Location = new Point(15, 9);
      this.UnverifiedLbl.Name = "UnverifiedLbl";
      this.UnverifiedLbl.Size = new Size(141, 16);
      this.UnverifiedLbl.TabIndex = 6315;
      this.UnverifiedLbl.Text = "UNVERIFIED TOKENS:";
      this.panel2.BackColor = Color.FromArgb(49, 50, 55);
      this.panel2.Controls.Add((Control) this.panel12);
      this.panel2.Controls.Add((Control) this.panel10);
      this.panel2.Controls.Add((Control) this.panel8);
      this.panel2.Controls.Add((Control) this.panel6);
      this.panel2.Controls.Add((Control) this.UnverifiedTextBox);
      this.panel2.Location = new Point(14, 28);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(496, 121);
      this.panel2.TabIndex = 6314;
      this.UnverifiedTextBox.BackColor = Color.FromArgb(33, 34, 38);
      this.UnverifiedTextBox.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.UnverifiedTextBox.ForeColor = Color.Silver;
      this.UnverifiedTextBox.Location = new Point(-2, -2);
      this.UnverifiedTextBox.Name = "UnverifiedTextBox";
      this.UnverifiedTextBox.Size = new Size(650, 156);
      this.UnverifiedTextBox.TabIndex = 6284;
      this.UnverifiedTextBox.Text = "";
      this.InvalidPage.BackColor = Color.FromArgb(33, 34, 38);
      this.InvalidPage.Controls.Add((Control) this.Invalidlbl);
      this.InvalidPage.Controls.Add((Control) this.panel4);
      this.InvalidPage.Location = new Point(4, 22);
      this.InvalidPage.Name = "InvalidPage";
      this.InvalidPage.Size = new Size(540, 164);
      this.InvalidPage.TabIndex = 2;
      this.InvalidPage.Text = "emailverified";
      this.Invalidlbl.AutoSize = true;
      this.Invalidlbl.Font = new Font("Microsoft Tai Le", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Invalidlbl.ForeColor = Color.White;
      this.Invalidlbl.Location = new Point(15, 9);
      this.Invalidlbl.Name = "Invalidlbl";
      this.Invalidlbl.Size = new Size(119, 16);
      this.Invalidlbl.TabIndex = 6317;
      this.Invalidlbl.Text = "INVALID TOKENS:";
      this.panel4.BackColor = Color.FromArgb(49, 50, 55);
      this.panel4.Controls.Add((Control) this.panel57);
      this.panel4.Controls.Add((Control) this.panel11);
      this.panel4.Controls.Add((Control) this.panel58);
      this.panel4.Controls.Add((Control) this.panel7);
      this.panel4.Controls.Add((Control) this.InvalidTextBox);
      this.panel4.Location = new Point(14, 28);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(496, 121);
      this.panel4.TabIndex = 6316;
      this.InvalidTextBox.BackColor = Color.FromArgb(33, 34, 38);
      this.InvalidTextBox.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.InvalidTextBox.ForeColor = Color.Silver;
      this.InvalidTextBox.Location = new Point(-2, -2);
      this.InvalidTextBox.Name = "InvalidTextBox";
      this.InvalidTextBox.Size = new Size(611, 156);
      this.InvalidTextBox.TabIndex = 6284;
      this.InvalidTextBox.Text = "";
      this.panel60.BackColor = Color.FromArgb(56, 56, 56);
      this.panel60.Dock = DockStyle.Top;
      this.panel60.Location = new Point(0, 0);
      this.panel60.Name = "panel60";
      this.panel60.Size = new Size(496, 2);
      this.panel60.TabIndex = 6287;
      this.panel6.BackColor = Color.FromArgb(56, 56, 56);
      this.panel6.Dock = DockStyle.Top;
      this.panel6.Location = new Point(0, 0);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(496, 2);
      this.panel6.TabIndex = 6288;
      this.panel7.BackColor = Color.FromArgb(56, 56, 56);
      this.panel7.Dock = DockStyle.Top;
      this.panel7.Location = new Point(0, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(496, 2);
      this.panel7.TabIndex = 6288;
      this.panel58.BackColor = Color.FromArgb(56, 56, 56);
      this.panel58.Dock = DockStyle.Left;
      this.panel58.Location = new Point(0, 2);
      this.panel58.Name = "panel58";
      this.panel58.Size = new Size(2, 119);
      this.panel58.TabIndex = 6289;
      this.panel8.BackColor = Color.FromArgb(56, 56, 56);
      this.panel8.Dock = DockStyle.Left;
      this.panel8.Location = new Point(0, 2);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(2, 119);
      this.panel8.TabIndex = 6290;
      this.panel9.BackColor = Color.FromArgb(56, 56, 56);
      this.panel9.Dock = DockStyle.Left;
      this.panel9.Location = new Point(0, 2);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(2, 119);
      this.panel9.TabIndex = 6290;
      this.panel59.BackColor = Color.FromArgb(56, 56, 56);
      this.panel59.Dock = DockStyle.Bottom;
      this.panel59.Location = new Point(2, 119);
      this.panel59.Name = "panel59";
      this.panel59.Size = new Size(494, 2);
      this.panel59.TabIndex = 6291;
      this.panel10.BackColor = Color.FromArgb(56, 56, 56);
      this.panel10.Dock = DockStyle.Bottom;
      this.panel10.Location = new Point(2, 119);
      this.panel10.Name = "panel10";
      this.panel10.Size = new Size(494, 2);
      this.panel10.TabIndex = 6292;
      this.panel11.BackColor = Color.FromArgb(56, 56, 56);
      this.panel11.Dock = DockStyle.Bottom;
      this.panel11.Location = new Point(2, 119);
      this.panel11.Name = "panel11";
      this.panel11.Size = new Size(494, 2);
      this.panel11.TabIndex = 6292;
      this.panel57.BackColor = Color.FromArgb(56, 56, 56);
      this.panel57.Dock = DockStyle.Right;
      this.panel57.Location = new Point(494, 2);
      this.panel57.Name = "panel57";
      this.panel57.Size = new Size(2, 117);
      this.panel57.TabIndex = 6293;
      this.panel12.BackColor = Color.FromArgb(56, 56, 56);
      this.panel12.Dock = DockStyle.Right;
      this.panel12.Location = new Point(494, 2);
      this.panel12.Name = "panel12";
      this.panel12.Size = new Size(2, 117);
      this.panel12.TabIndex = 6294;
      this.panel13.BackColor = Color.FromArgb(56, 56, 56);
      this.panel13.Dock = DockStyle.Right;
      this.panel13.Location = new Point(494, 2);
      this.panel13.Name = "panel13";
      this.panel13.Size = new Size(2, 117);
      this.panel13.TabIndex = 6294;
      this.panel14.BackColor = Color.FromArgb(33, 34, 38);
      this.panel14.Controls.Add((Control) this.panel15);
      this.panel14.Location = new Point(-14, 192);
      this.panel14.Name = "panel14";
      this.panel14.Size = new Size(28, 33);
      this.panel14.TabIndex = 6315;
      this.panel15.BackColor = Color.FromArgb(56, 56, 56);
      this.panel15.Location = new Point(499, -58);
      this.panel15.Name = "panel15";
      this.panel15.Size = new Size(3, 148);
      this.panel15.TabIndex = 6288;
      this.panel16.BackColor = Color.FromArgb(33, 34, 38);
      this.panel16.Controls.Add((Control) this.panel17);
      this.panel16.Location = new Point(510, 191);
      this.panel16.Name = "panel16";
      this.panel16.Size = new Size(28, 33);
      this.panel16.TabIndex = 6316;
      this.panel17.BackColor = Color.FromArgb(56, 56, 56);
      this.panel17.Location = new Point(499, -58);
      this.panel17.Name = "panel17";
      this.panel17.Size = new Size(3, 148);
      this.panel17.TabIndex = 6288;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(523, 259);
      this.Controls.Add((Control) this.panel16);
      this.Controls.Add((Control) this.panel14);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.Controls.Add((Control) this.TokenTab);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (CheckTokens);
      this.Text = "Discord Raider | Check Tokens";
      this.FormClosing += new FormClosingEventHandler(this.CheckTokens_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.panel22.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.TokenTab.ResumeLayout(false);
      this.VerifiedPage.ResumeLayout(false);
      this.VerifiedPage.PerformLayout();
      this.UnverifiedPage.ResumeLayout(false);
      this.UnverifiedPage.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.InvalidPage.ResumeLayout(false);
      this.InvalidPage.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel14.ResumeLayout(false);
      this.panel16.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
