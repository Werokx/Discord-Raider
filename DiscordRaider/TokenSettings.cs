using RaidAPI.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class TokenSettings : Form
  {
    public static bool _NickForm;
    public static bool _HyperForm;
    public static bool _UpdateStatus;
    private bool HideToken;
    public static bool _TokenInfos;
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
    private Panel panel51;
    private Panel panel4;
    private Panel panel50;
    private Panel panel134;
    private Panel panel135;
    private Label InfoLbl2;
    private Button HideBtn;
    private DataGridView TokensGrid;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private TextBox InfoLbl;
    private ToolStripMenuItem ContextSendOnline;
    private ToolStripMenuItem ComtextCheckTokens;
    private ToolStripMenuItem ContextSetGame;
    internal ContextMenuStrip TokenMenu;
    private ToolStripMenuItem ContextHype;
    private ToolStripMenuItem ContextNick;

    public TokenSettings()
    {
      this.InitializeComponent();
      this.TokenMenu.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer((ProfessionalColorTable)new TokenSettings.MyColorTable());
      this.ModDesign();
      this.GetTokens();
      this.Check();
    }

    private void Check()
    {
      if (FormSettings._HideTokens)
      {
        this.TokensGrid.Rows.Clear();
        this.TokensGrid.Rows.Add(new object[1]
        {
          (object) "---HIDDEN---"
        });
        this.HideToken = true;
        this.HideBtn.Text = "Show Tokens";
      }
      else
      {
        this.TokensGrid.Rows.Clear();
        this.GetTokens();
        this.HideToken = false;
        this.HideBtn.Text = "Hide Tokens";
      }
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

    private void GetTokens()
    {
      this.TokensGrid.RowTemplate.Height = 25;
      this.TokensGrid.AllowUserToResizeRows = false;
      this.TokensGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
        return;
      using (StreamReader streamReader = new StreamReader(Path.Combine(SpamMain._TokenPath)))
      {
        if (streamReader.EndOfStream)
          return;
        label_4:
        string str;
        do
        {
          str = streamReader.ReadLine();
          if (str == null)
            goto label_10;
        }
        while (str == string.Empty);
        goto label_7;
      label_10:
        return;
      label_7:
        string[] strArray = str.Split(' ');
        int index1 = this.TokensGrid.Rows.Add();
        for (int index2 = 0; index2 < strArray.Length; ++index2)
        {
          this.TokensGrid.Rows[index1].Cells[index2].Value = (object)strArray[index2];
          this.InfoLbl2.Text = "Discord Tokens: " + this.TokensGrid.RowCount.ToString();
        }
        goto label_4;
      }
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      SpamMain._TokenSettings = false;
      this.Close();
    }

    private void SendOnline()
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int)MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              newClient.Login(_Token);
            }
            catch
            {
            }
          }
        }
      }
    }

    private void SendOffline()
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int)MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string str in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              newClient.LogoutClient();
            }
            catch
            {
            }
          }
        }
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

    private void HideBtn_Click(object sender, EventArgs e)
    {
      switch (this.HideBtn.Text)
      {
        case "Hide Tokens":
          this.TokensGrid.Rows.Clear();
          this.TokensGrid.Rows.Add(new object[1]
          {
            (object) "---HIDDEN---"
          });
          this.HideToken = true;
          this.HideBtn.Text = "Show Tokens";
          break;
        case "Show Tokens":
          this.TokensGrid.Rows.Clear();
          this.GetTokens();
          this.HideToken = false;
          this.HideBtn.Text = "Hide Tokens";
          break;
      }
    }

    private void TokenSettings_FormClosing(object sender, FormClosingEventArgs e) => SpamMain._TokenSettings = false;

    private void TokensGrid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.HideToken)
      {
        int num = (int)MessageBox.Show("You can only get the Infos when the Tokans are not Hidden", "Discord Raider");
      }
      else
      {
        try
        {
          if (TokenSettings._TokenInfos)
          {
            TokenInfos._Token = this.TokensGrid.Rows[this.TokensGrid.CurrentRow.Index].Cells[0].Value.ToString();
          }
          else
          {
            TokenSettings._TokenInfos = true;
            TokenInfos._Token = this.TokensGrid.Rows[this.TokensGrid.CurrentRow.Index].Cells[0].Value.ToString();
            new TokenInfos().Show();
          }
        }
        catch
        {
        }
      }
    }

    private void TokensGrid_MouseEnter(object sender, EventArgs e) => this.InfoLbl.Text = "Press on a Token to get the Profile Infos | Press right click for settings";

    private void TokensGrid_MouseLeave(object sender, EventArgs e) => this.InfoLbl.Text = "[info]";

    private void ContextSendOnline_Click(object sender, EventArgs e)
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int)MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              newClient.Login(_Token);
            }
            catch
            {
            }
          }
        }
      }
    }

    private void ContextSetGame_Click(object sender, EventArgs e)
    {
      if (TokenSettings._UpdateStatus)
        return;
      TokenSettings._UpdateStatus = true;
      new UpdateStatus().Show();
    }

    private void ComtextCheckTokens_Click(object sender, EventArgs e)
    {
      if (SpamMain._CheckTokenForm)
        return;
      SpamMain._CheckTokenForm = true;
      new CheckTokens().Show();
    }

    private void ContextSendOnline_MouseEnter(object sender, EventArgs e) => this.ContextSendOnline.ForeColor = Color.White;

    private void ContextSendOnline_MouseLeave(object sender, EventArgs e) => this.ContextSendOnline.ForeColor = Color.Silver;

    private void ComtextCheckTokens_MouseEnter(object sender, EventArgs e) => this.ComtextCheckTokens.ForeColor = Color.White;

    private void ComtextCheckTokens_MouseLeave(object sender, EventArgs e) => this.ComtextCheckTokens.ForeColor = Color.Silver;

    private void ContextSetGame_MouseEnter(object sender, EventArgs e) => this.ContextSetGame.ForeColor = Color.White;

    private void ContextSetGame_MouseLeave(object sender, EventArgs e) => this.ContextSetGame.ForeColor = Color.Silver;

    private void ContextHype_MouseEnter(object sender, EventArgs e) => this.ContextHype.ForeColor = Color.White;

    private void ContextHype_MouseLeave(object sender, EventArgs e) => this.ContextHype.ForeColor = Color.Silver;

    private void ContextHype_Click(object sender, EventArgs e)
    {
      if (TokenSettings._HyperForm)
        return;
      TokenSettings._HyperForm = true;
      new HypeStuff().Show();
    }

    private void ContextNick_Click(object sender, EventArgs e)
    {
      if (TokenSettings._NickForm)
        return;
      TokenSettings._NickForm = true;
      new setServerNick().Show();
    }

    private void ContextNick_MouseEnter(object sender, EventArgs e) => this.ContextNick.ForeColor = Color.White;

    private void ContextNick_MouseLeave(object sender, EventArgs e) => this.ContextNick.ForeColor = Color.Silver;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer)new System.ComponentModel.Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TokenSettings));
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
      this.panel51 = new Panel();
      this.panel4 = new Panel();
      this.panel50 = new Panel();
      this.panel134 = new Panel();
      this.panel135 = new Panel();
      this.InfoLbl2 = new Label();
      this.HideBtn = new Button();
      this.TokensGrid = new DataGridView();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.TokenMenu = new ContextMenuStrip(this.components);
      this.ContextSendOnline = new ToolStripMenuItem();
      this.ComtextCheckTokens = new ToolStripMenuItem();
      this.ContextSetGame = new ToolStripMenuItem();
      this.ContextHype = new ToolStripMenuItem();
      this.InfoLbl = new TextBox();
      this.ContextNick = new ToolStripMenuItem();
      this.HeadLinePnlInf.SuspendLayout();
      this.panel135.SuspendLayout();
      ((ISupportInitialize)this.TokensGrid).BeginInit();
      this.TokenMenu.SuspendLayout();
      this.SuspendLayout();
      this.HeadLinePnlInf.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnlInf.Controls.Add((Control)this.panel24);
      this.HeadLinePnlInf.Controls.Add((Control)this.CloseBtn);
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
      this.HeadLinePnlInf.Size = new Size(477, 29);
      this.HeadLinePnlInf.TabIndex = 6296;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(18, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(440, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(451, -1);
      this.CloseBtn.Name = "CloseBtn";
      this.CloseBtn.Size = new Size(26, 27);
      this.CloseBtn.TabIndex = 6167;
      this.CloseBtn.Text = "r";
      this.CloseBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseBtn.UseVisualStyleBackColor = false;
      this.CloseBtn.Click += new EventHandler(this.CloseBtn_Click);
      this.HeadServerLbl.AutoSize = true;
      this.HeadServerLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.HeadServerLbl.ForeColor = Color.White;
      this.HeadServerLbl.Location = new Point(169, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(132, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "TOKEN SETTING";
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
      this.textBox3.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
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
      this.button4.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
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
      this.panel37.Location = new Point(-1651, 223);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6300;
      this.panel51.BackColor = Color.FromArgb(33, 34, 38);
      this.panel51.Font = new Font("Segoe UI", 9f);
      this.panel51.Location = new Point(464, 41);
      this.panel51.Name = "panel51";
      this.panel51.Size = new Size(87, 177);
      this.panel51.TabIndex = 6307;
      this.panel4.BackColor = Color.FromArgb(51, 51, 51);
      this.panel4.Font = new Font("Segoe UI", 9f);
      this.panel4.Location = new Point(14, 207);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(450, 2);
      this.panel4.TabIndex = 6306;
      this.panel50.BackColor = Color.FromArgb(51, 51, 51);
      this.panel50.Font = new Font("Segoe UI", 9f);
      this.panel50.Location = new Point(12, 58);
      this.panel50.Name = "panel50";
      this.panel50.Size = new Size(2, 149);
      this.panel50.TabIndex = 6305;
      this.panel134.BackColor = Color.FromArgb(51, 51, 51);
      this.panel134.Font = new Font("Segoe UI", 9f);
      this.panel134.Location = new Point(462, 58);
      this.panel134.Name = "panel134";
      this.panel134.Size = new Size(2, 149);
      this.panel134.TabIndex = 6304;
      this.panel135.BackColor = Color.FromArgb(51, 51, 51);
      this.panel135.Controls.Add((Control)this.InfoLbl2);
      this.panel135.Controls.Add((Control)this.HideBtn);
      this.panel135.Font = new Font("Segoe UI", 9f);
      this.panel135.Location = new Point(12, 42);
      this.panel135.Name = "panel135";
      this.panel135.Size = new Size(452, 21);
      this.panel135.TabIndex = 6303;
      this.InfoLbl2.AutoSize = true;
      this.InfoLbl2.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.InfoLbl2.ForeColor = Color.Silver;
      this.InfoLbl2.Location = new Point(3, 3);
      this.InfoLbl2.Name = "InfoLbl2";
      this.InfoLbl2.Size = new Size(94, 15);
      this.InfoLbl2.TabIndex = 6140;
      this.InfoLbl2.Text = "Discord Tokens:";
      this.HideBtn.BackColor = Color.FromArgb(51, 51, 51);
      this.HideBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.HideBtn.FlatAppearance.BorderSize = 0;
      this.HideBtn.FlatStyle = FlatStyle.Flat;
      this.HideBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.HideBtn.ForeColor = Color.Silver;
      this.HideBtn.Location = new Point(365, -1);
      this.HideBtn.Name = "HideBtn";
      this.HideBtn.Size = new Size(85, 23);
      this.HideBtn.TabIndex = 6239;
      this.HideBtn.Text = "Hide Tokens";
      this.HideBtn.UseVisualStyleBackColor = false;
      this.HideBtn.Click += new EventHandler(this.HideBtn_Click);
      this.TokensGrid.AllowUserToAddRows = false;
      this.TokensGrid.AllowUserToDeleteRows = false;
      this.TokensGrid.AllowUserToResizeColumns = false;
      this.TokensGrid.AllowUserToResizeRows = false;
      gridViewCellStyle1.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      gridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 51);
      gridViewCellStyle1.SelectionForeColor = Color.White;
      this.TokensGrid.AlternatingRowsDefaultCellStyle = gridViewCellStyle1;
      this.TokensGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      this.TokensGrid.BackgroundColor = Color.FromArgb(33, 34, 38);
      this.TokensGrid.BorderStyle = BorderStyle.None;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 34, 38);
      gridViewCellStyle2.SelectionForeColor = Color.White;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.TokensGrid.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
      this.TokensGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.TokensGrid.Columns.AddRange((DataGridViewColumn)this.dataGridViewTextBoxColumn1);
      this.TokensGrid.ContextMenuStrip = this.TokenMenu;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle3.BackColor = SystemColors.Window;
      gridViewCellStyle3.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      gridViewCellStyle3.ForeColor = SystemColors.ControlText;
      gridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 51, 51);
      gridViewCellStyle3.SelectionForeColor = Color.White;
      gridViewCellStyle3.WrapMode = DataGridViewTriState.False;
      this.TokensGrid.DefaultCellStyle = gridViewCellStyle3;
      this.TokensGrid.GridColor = Color.White;
      this.TokensGrid.Location = new Point(12, 42);
      this.TokensGrid.MultiSelect = false;
      this.TokensGrid.Name = "TokensGrid";
      this.TokensGrid.ReadOnly = true;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle4.BackColor = SystemColors.Control;
      gridViewCellStyle4.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      gridViewCellStyle4.ForeColor = SystemColors.WindowText;
      gridViewCellStyle4.SelectionBackColor = Color.FromArgb(33, 34, 38);
      gridViewCellStyle4.SelectionForeColor = Color.White;
      gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
      this.TokensGrid.RowHeadersDefaultCellStyle = gridViewCellStyle4;
      this.TokensGrid.RowHeadersVisible = false;
      this.TokensGrid.ScrollBars = ScrollBars.Vertical;
      this.TokensGrid.Size = new Size(514, 165);
      this.TokensGrid.TabIndex = 6310;
      this.TokensGrid.CellClick += new DataGridViewCellEventHandler(this.TokensGrid_CellClick);
      this.TokensGrid.MouseEnter += new EventHandler(this.TokensGrid_MouseEnter);
      this.TokensGrid.MouseLeave += new EventHandler(this.TokensGrid_MouseLeave);
      this.dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      gridViewCellStyle5.BackColor = Color.FromArgb(33, 34, 38);
      gridViewCellStyle5.ForeColor = Color.Silver;
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = gridViewCellStyle5;
      this.dataGridViewTextBoxColumn1.HeaderText = "Tokens";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 25;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 560;
      this.TokenMenu.BackColor = Color.FromArgb(51, 51, 51);
      this.TokenMenu.BackgroundImageLayout = ImageLayout.None;
      this.TokenMenu.DropShadowEnabled = false;
      this.TokenMenu.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.ContextSendOnline,
        (ToolStripItem) this.ComtextCheckTokens,
        (ToolStripItem) this.ContextSetGame,
        (ToolStripItem) this.ContextHype,
        (ToolStripItem) this.ContextNick
      });
      this.TokenMenu.Name = "TokenMenu";
      this.TokenMenu.ShowImageMargin = false;
      this.TokenMenu.ShowItemToolTips = false;
      this.TokenMenu.Size = new Size(160, 136);
      this.TokenMenu.TabStop = true;
      this.ContextSendOnline.BackColor = Color.FromArgb(33, 34, 38);
      this.ContextSendOnline.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ContextSendOnline.ForeColor = Color.Silver;
      this.ContextSendOnline.ImageScaling = ToolStripItemImageScaling.None;
      this.ContextSendOnline.Name = "ContextSendOnline";
      this.ContextSendOnline.Size = new Size(159, 22);
      this.ContextSendOnline.Text = "Send Bots Online";
      this.ContextSendOnline.Click += new EventHandler(this.ContextSendOnline_Click);
      this.ContextSendOnline.MouseEnter += new EventHandler(this.ContextSendOnline_MouseEnter);
      this.ContextSendOnline.MouseLeave += new EventHandler(this.ContextSendOnline_MouseLeave);
      this.ComtextCheckTokens.BackColor = Color.FromArgb(33, 34, 38);
      this.ComtextCheckTokens.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.ComtextCheckTokens.ForeColor = Color.Silver;
      this.ComtextCheckTokens.Name = "ComtextCheckTokens";
      this.ComtextCheckTokens.Size = new Size(159, 22);
      this.ComtextCheckTokens.Text = "Check Tokens";
      this.ComtextCheckTokens.Click += new EventHandler(this.ComtextCheckTokens_Click);
      this.ComtextCheckTokens.MouseEnter += new EventHandler(this.ComtextCheckTokens_MouseEnter);
      this.ComtextCheckTokens.MouseLeave += new EventHandler(this.ComtextCheckTokens_MouseLeave);
      this.ContextSetGame.BackColor = Color.FromArgb(33, 34, 38);
      this.ContextSetGame.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.ContextSetGame.ForeColor = Color.Silver;
      this.ContextSetGame.Name = "ContextSetGame";
      this.ContextSetGame.Size = new Size(159, 22);
      this.ContextSetGame.Text = "Set Custom Game";
      this.ContextSetGame.Click += new EventHandler(this.ContextSetGame_Click);
      this.ContextSetGame.MouseEnter += new EventHandler(this.ContextSetGame_MouseEnter);
      this.ContextSetGame.MouseLeave += new EventHandler(this.ContextSetGame_MouseLeave);
      this.ContextHype.BackColor = Color.FromArgb(33, 34, 38);
      this.ContextHype.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.ContextHype.ForeColor = Color.Silver;
      this.ContextHype.Name = "ContextHype";
      this.ContextHype.Size = new Size(159, 22);
      this.ContextHype.Text = "Give Hypesquad";
      this.ContextHype.Click += new EventHandler(this.ContextHype_Click);
      this.ContextHype.MouseEnter += new EventHandler(this.ContextHype_MouseEnter);
      this.ContextHype.MouseLeave += new EventHandler(this.ContextHype_MouseLeave);
      this.InfoLbl.BackColor = Color.FromArgb(33, 34, 38);
      this.InfoLbl.BorderStyle = BorderStyle.None;
      this.InfoLbl.Enabled = false;
      this.InfoLbl.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfoLbl.ForeColor = Color.Silver;
      this.InfoLbl.Location = new Point(12, 228);
      this.InfoLbl.Name = "InfoLbl";
      this.InfoLbl.Size = new Size(450, 16);
      this.InfoLbl.TabIndex = 6311;
      this.InfoLbl.Text = "[info]";
      this.InfoLbl.TextAlign = HorizontalAlignment.Center;
      this.ContextNick.BackColor = Color.FromArgb(33, 34, 38);
      this.ContextNick.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
      this.ContextNick.ForeColor = Color.Silver;
      this.ContextNick.Name = "ContextNick";
      this.ContextNick.Size = new Size(159, 22);
      this.ContextNick.Text = "Change Server Nick";
      this.ContextNick.Click += new EventHandler(this.ContextNick_Click);
      this.ContextNick.MouseEnter += new EventHandler(this.ContextNick_MouseEnter);
      this.ContextNick.MouseLeave += new EventHandler(this.ContextNick_MouseLeave);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(477, 246);
      this.Controls.Add((Control)this.panel51);
      this.Controls.Add((Control)this.panel4);
      this.Controls.Add((Control)this.panel50);
      this.Controls.Add((Control)this.panel134);
      this.Controls.Add((Control)this.panel135);
      this.Controls.Add((Control)this.panel37);
      this.Controls.Add((Control)this.HeadLinePnlInf);
      this.Controls.Add((Control)this.TokensGrid);
      this.Controls.Add((Control)this.InfoLbl);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof(TokenSettings);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Token Settings";
      this.FormClosing += new FormClosingEventHandler(this.TokenSettings_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.panel135.ResumeLayout(false);
      this.panel135.PerformLayout();
      ((ISupportInitialize)this.TokensGrid).EndInit();
      this.TokenMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class MyColorTable : ProfessionalColorTable
    {
      public override Color ToolStripDropDownBackground => Color.FromArgb(105, 105, 205);

      public override Color ImageMarginGradientBegin => Color.FromArgb(105, 105, 205);

      public override Color ImageMarginGradientMiddle => Color.FromArgb(105, 105, 205);

      public override Color ImageMarginGradientEnd => Color.FromArgb(105, 105, 205);

      public override Color MenuBorder => Color.FromArgb(51, 51, 51);

      public override Color MenuItemBorder => Color.FromArgb(105, 105, 205);

      public override Color MenuItemSelected => Color.FromArgb(105, 105, 205);

      public override Color MenuStripGradientBegin => Color.FromArgb(105, 105, 205);

      public override Color MenuStripGradientEnd => Color.FromArgb(105, 105, 205);

      public override Color MenuItemSelectedGradientBegin => Color.FromArgb(105, 105, 205);

      public override Color MenuItemSelectedGradientEnd => Color.White;

      public override Color MenuItemPressedGradientBegin => Color.White;

      public override Color MenuItemPressedGradientEnd => Color.FromArgb(105, 105, 205);
    }
  }
}
