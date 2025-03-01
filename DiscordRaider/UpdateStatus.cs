using RaidAPI.Core.Profile;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class UpdateStatus : Form
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
    private Panel panel1;
    private TextBox GameTxt;
    private Button UpdateGame;
    private Panel panel2;
    private Panel panel3;
    private Panel panel4;
    private TextBox TwitchTxt;
    private Button UpdateTwitch;
    private Panel panel5;

    public UpdateStatus()
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
      TokenSettings._UpdateStatus = false;
      this.Close();
    }

    private void UpdateGame_Click(object sender, EventArgs e)
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
              ClientSettings.SetGame(_Token, this.GameTxt.Text);
            }
            catch
            {
            }
          }
        }
      }
    }

    private void SetStream()
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
              ClientSettings.SetStream(_Token, this.TwitchTxt.Text);
            }
            catch
            {
            }
          }
        }
      }
    }

    private void UpdateTwitch_Click(object sender, EventArgs e) => this.SetStream();

    private void GameTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.GameTxt.Text == "Game Name"))
        return;
      this.GameTxt.Text = "";
      this.GameTxt.ForeColor = Color.White;
    }

    private void GameTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.GameTxt.Text == ""))
        return;
      this.GameTxt.Text = "Game Name";
      this.GameTxt.ForeColor = Color.Silver;
    }

    private void TwitchTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.TwitchTxt.Text == "Twitch Game"))
        return;
      this.TwitchTxt.Text = "";
      this.TwitchTxt.ForeColor = Color.White;
    }

    private void TwitchTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.TwitchTxt.Text == ""))
        return;
      this.TwitchTxt.Text = "Twitch Game";
      this.TwitchTxt.ForeColor = Color.Silver;
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

    private void UpdateStatus_FormClosing(object sender, FormClosingEventArgs e) => TokenSettings._UpdateStatus = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UpdateStatus));
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
      this.panel1 = new Panel();
      this.GameTxt = new TextBox();
      this.UpdateGame = new Button();
      this.panel2 = new Panel();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.TwitchTxt = new TextBox();
      this.UpdateTwitch = new Button();
      this.panel5 = new Panel();
      this.HeadLinePnlInf.SuspendLayout();
      this.panel22.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1690, 133);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6302;
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
      this.HeadLinePnlInf.Size = new Size(372, 29);
      this.HeadLinePnlInf.TabIndex = 6301;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(18, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(339, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(346, -1);
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
      this.HeadServerLbl.Location = new Point(91, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(181, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "UPDATE CLIENT GAME";
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
      this.panel22.BackColor = Color.FromArgb(49, 50, 55);
      this.panel22.Controls.Add((Control)this.panel1);
      this.panel22.Controls.Add((Control)this.GameTxt);
      this.panel22.Controls.Add((Control)this.UpdateGame);
      this.panel22.Controls.Add((Control)this.panel2);
      this.panel22.Location = new Point(18, 42);
      this.panel22.Name = "panel22";
      this.panel22.Size = new Size(339, 32);
      this.panel22.TabIndex = 6310;
      this.panel1.BackColor = Color.FromArgb(56, 56, 56);
      this.panel1.Location = new Point(217, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(3, 148);
      this.panel1.TabIndex = 6285;
      this.GameTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.GameTxt.BorderStyle = BorderStyle.None;
      this.GameTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.GameTxt.ForeColor = Color.DarkGray;
      this.GameTxt.Location = new Point(7, 7);
      this.GameTxt.Name = "GameTxt";
      this.GameTxt.Size = new Size(204, 18);
      this.GameTxt.TabIndex = 6280;
      this.GameTxt.Text = "Game Name";
      this.GameTxt.Enter += new EventHandler(this.GameTxt_Enter);
      this.GameTxt.Leave += new EventHandler(this.GameTxt_Leave);
      this.UpdateGame.BackColor = Color.FromArgb(105, 105, 205);
      this.UpdateGame.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.UpdateGame.FlatAppearance.BorderSize = 0;
      this.UpdateGame.FlatStyle = FlatStyle.Flat;
      this.UpdateGame.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.UpdateGame.ForeColor = Color.WhiteSmoke;
      this.UpdateGame.Location = new Point(225, 5);
      this.UpdateGame.Name = "UpdateGame";
      this.UpdateGame.Size = new Size(108, 22);
      this.UpdateGame.TabIndex = 6284;
      this.UpdateGame.Text = "UPDATE GAME";
      this.UpdateGame.UseVisualStyleBackColor = false;
      this.UpdateGame.Click += new EventHandler(this.UpdateGame_Click);
      this.panel2.BackColor = Color.FromArgb(56, 56, 56);
      this.panel2.Location = new Point(462, -5);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(3, 148);
      this.panel2.TabIndex = 6283;
      this.panel3.BackColor = Color.FromArgb(49, 50, 55);
      this.panel3.Controls.Add((Control)this.panel4);
      this.panel3.Controls.Add((Control)this.TwitchTxt);
      this.panel3.Controls.Add((Control)this.UpdateTwitch);
      this.panel3.Controls.Add((Control)this.panel5);
      this.panel3.Location = new Point(18, 85);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(339, 32);
      this.panel3.TabIndex = 6311;
      this.panel4.BackColor = Color.FromArgb(56, 56, 56);
      this.panel4.Location = new Point(217, -12);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(3, 148);
      this.panel4.TabIndex = 6285;
      this.TwitchTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.TwitchTxt.BorderStyle = BorderStyle.None;
      this.TwitchTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.TwitchTxt.ForeColor = Color.DarkGray;
      this.TwitchTxt.Location = new Point(7, 7);
      this.TwitchTxt.Name = "TwitchTxt";
      this.TwitchTxt.Size = new Size(204, 18);
      this.TwitchTxt.TabIndex = 6280;
      this.TwitchTxt.Text = "Twitch Game";
      this.TwitchTxt.Enter += new EventHandler(this.TwitchTxt_Enter);
      this.TwitchTxt.Leave += new EventHandler(this.TwitchTxt_Leave);
      this.UpdateTwitch.BackColor = Color.FromArgb(105, 105, 205);
      this.UpdateTwitch.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.UpdateTwitch.FlatAppearance.BorderSize = 0;
      this.UpdateTwitch.FlatStyle = FlatStyle.Flat;
      this.UpdateTwitch.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.UpdateTwitch.ForeColor = Color.WhiteSmoke;
      this.UpdateTwitch.Location = new Point(225, 5);
      this.UpdateTwitch.Name = "UpdateTwitch";
      this.UpdateTwitch.Size = new Size(108, 22);
      this.UpdateTwitch.TabIndex = 6284;
      this.UpdateTwitch.Text = "SET STREAM";
      this.UpdateTwitch.UseVisualStyleBackColor = false;
      this.UpdateTwitch.Click += new EventHandler(this.UpdateTwitch_Click);
      this.panel5.BackColor = Color.FromArgb(56, 56, 56);
      this.panel5.Location = new Point(462, -5);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(3, 148);
      this.panel5.TabIndex = 6283;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(372, 152);
      this.Controls.Add((Control)this.panel3);
      this.Controls.Add((Control)this.panel22);
      this.Controls.Add((Control)this.panel37);
      this.Controls.Add((Control)this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof(UpdateStatus);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Discord Raider | Update Status";
      this.FormClosing += new FormClosingEventHandler(this.UpdateStatus_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.panel22.ResumeLayout(false);
      this.panel22.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
