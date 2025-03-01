using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class setServerNick : Form
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
    private Panel ServerPnl;
    private Panel panel18;
    private TextBox ServerIdTxt;
    private Panel NickPnl;
    private TextBox NickTxt;
    private RoundBtn SetNick;

    public setServerNick()
    {
      this.InitializeComponent();
      this.ModDesign();
      this.ChangeIDPnl();
      this.ChangeNickPnl();
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

    private void ChangeIDPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ServerPnl.Width, this.ServerPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ServerPnl.Region = new Region(path);
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

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      TokenSettings._NickForm = false;
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

    private void ServerIdTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.ServerIdTxt.Text == "Server ID"))
        return;
      this.ServerIdTxt.Text = "";
      this.ServerIdTxt.ForeColor = Color.White;
    }

    private void ServerIdTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.ServerIdTxt.Text == ""))
        return;
      this.ServerIdTxt.Text = "Server ID";
      this.ServerIdTxt.ForeColor = Color.Silver;
    }

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

    private void setServerNick_FormClosing(object sender, FormClosingEventArgs e) => TokenSettings._NickForm = false;

    private void SetNick_Click(object sender, EventArgs e)
    {
      if (this.ServerIdTxt.Text == "" || this.NickTxt.Text == "" || this.ServerIdTxt.Text == "Server ID" || this.NickTxt.Text == "Nick Name")
      {
        int num1 = (int) MessageBox.Show("Cant Set custom nick name", "Discord Raider");
      }
      else if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num2 = (int) MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              RaidAPI.Core.Profile.ChangeNick.ChangeUserNick(_Token, this.ServerIdTxt.Text, this.NickTxt.Text);
            }
            catch
            {
            }
          }
        }
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (setServerNick));
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
      this.ServerPnl = new Panel();
      this.panel18 = new Panel();
      this.ServerIdTxt = new TextBox();
      this.SetNick = new RoundBtn();
      this.NickPnl = new Panel();
      this.NickTxt = new TextBox();
      this.HeadLinePnlInf.SuspendLayout();
      this.ServerPnl.SuspendLayout();
      this.NickPnl.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1615, 133);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6308;
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
      this.HeadLinePnlInf.Size = new Size(344, 29);
      this.HeadLinePnlInf.TabIndex = 6307;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(14, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(312, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(318, -1);
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
      this.ServerPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.ServerPnl.Controls.Add((Control) this.panel18);
      this.ServerPnl.Controls.Add((Control) this.ServerIdTxt);
      this.ServerPnl.Controls.Add((Control) this.SetNick);
      this.ServerPnl.Location = new Point(14, 41);
      this.ServerPnl.Name = "ServerPnl";
      this.ServerPnl.Size = new Size(314, 32);
      this.ServerPnl.TabIndex = 6309;
      this.panel18.BackColor = Color.FromArgb(56, 56, 56);
      this.panel18.Location = new Point(216, 0);
      this.panel18.Name = "panel18";
      this.panel18.Size = new Size(3, 148);
      this.panel18.TabIndex = 6277;
      this.ServerIdTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.ServerIdTxt.BorderStyle = BorderStyle.None;
      this.ServerIdTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ServerIdTxt.ForeColor = Color.DarkGray;
      this.ServerIdTxt.Location = new Point(7, 7);
      this.ServerIdTxt.Name = "ServerIdTxt";
      this.ServerIdTxt.Size = new Size(202, 18);
      this.ServerIdTxt.TabIndex = 6153;
      this.ServerIdTxt.Text = "Server ID";
      this.ServerIdTxt.Enter += new EventHandler(this.ServerIdTxt_Enter);
      this.ServerIdTxt.Leave += new EventHandler(this.ServerIdTxt_Leave);
      this.SetNick.BorderColor = Color.FromArgb(105, 105, 205);
      this.SetNick.ButtonColor = Color.FromArgb(105, 105, 205);
      this.SetNick.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.SetNick.FlatAppearance.BorderSize = 0;
      this.SetNick.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.SetNick.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.SetNick.FlatStyle = FlatStyle.Flat;
      this.SetNick.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.SetNick.Location = new Point(224, 5);
      this.SetNick.Name = "SetNick";
      this.SetNick.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.SetNick.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.SetNick.OnHoverTextColor = Color.White;
      this.SetNick.Size = new Size(84, 22);
      this.SetNick.TabIndex = 6318;
      this.SetNick.Text = "SET NICK";
      this.SetNick.TextColor = Color.White;
      this.SetNick.UseVisualStyleBackColor = true;
      this.SetNick.Click += new EventHandler(this.SetNick_Click);
      this.NickPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.NickPnl.Controls.Add((Control) this.NickTxt);
      this.NickPnl.Location = new Point(14, 84);
      this.NickPnl.Name = "NickPnl";
      this.NickPnl.Size = new Size(314, 32);
      this.NickPnl.TabIndex = 6310;
      this.NickTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.NickTxt.BorderStyle = BorderStyle.None;
      this.NickTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.NickTxt.ForeColor = Color.DarkGray;
      this.NickTxt.Location = new Point(7, 7);
      this.NickTxt.Name = "NickTxt";
      this.NickTxt.Size = new Size(301, 18);
      this.NickTxt.TabIndex = 6153;
      this.NickTxt.Text = "Nick Name";
      this.NickTxt.Enter += new EventHandler(this.NickTxt_Enter);
      this.NickTxt.Leave += new EventHandler(this.NickTxt_Leave);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(344, 149);
      this.Controls.Add((Control) this.NickPnl);
      this.Controls.Add((Control) this.ServerPnl);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (setServerNick);
      this.Text = "Discord Raider | Change Nick";
      this.FormClosing += new FormClosingEventHandler(this.setServerNick_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.ServerPnl.ResumeLayout(false);
      this.ServerPnl.PerformLayout();
      this.NickPnl.ResumeLayout(false);
      this.NickPnl.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
