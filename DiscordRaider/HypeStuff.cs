using RaidAPI.HypeSquad;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class HypeStuff : Form
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
    private Button BalanceBtn;
    private Button BrillianceBtn;
    private Button BraveryBtn;
    private Button NoneBtn;
    private Panel panel49;
    private Panel panel1;
    private Panel panel3;
    private Panel panel2;
    private TextBox InfosFriendTxt;

    public HypeStuff()
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
      TokenSettings._HyperForm = false;
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

    private void NoneBtn_Click(object sender, EventArgs e)
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int) MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              Hype.GiveHypeSquad(_Token, "0");
            }
            catch
            {
            }
          }
        }
      }
    }

    private void BraveryBtn_Click(object sender, EventArgs e)
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int) MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              Hype.GiveHypeSquad(_Token, "1");
            }
            catch
            {
            }
          }
        }
      }
    }

    private void BrillianceBtn_Click(object sender, EventArgs e)
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int) MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              Hype.GiveHypeSquad(_Token, "2");
            }
            catch
            {
            }
          }
        }
      }
    }

    private void BalanceBtn_Click(object sender, EventArgs e)
    {
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
      {
        int num = (int) MessageBox.Show("You need to load first your Tokens", "Discord Raider");
      }
      else
      {
        using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
        {
          foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
          {
            try
            {
              Hype.GiveHypeSquad(_Token, "3");
            }
            catch
            {
            }
          }
        }
      }
    }

    private void HypeStuff_FormClosing(object sender, FormClosingEventArgs e) => TokenSettings._HyperForm = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HypeStuff));
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
      this.BalanceBtn = new Button();
      this.BrillianceBtn = new Button();
      this.BraveryBtn = new Button();
      this.NoneBtn = new Button();
      this.panel49 = new Panel();
      this.panel1 = new Panel();
      this.panel3 = new Panel();
      this.panel2 = new Panel();
      this.InfosFriendTxt = new TextBox();
      this.HeadLinePnlInf.SuspendLayout();
      this.panel49.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1501, (int) sbyte.MaxValue);
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
      this.HeadLinePnlInf.Size = new Size(347, 29);
      this.HeadLinePnlInf.TabIndex = 6307;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(12, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(320, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(321, -1);
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
      this.HeadServerLbl.Location = new Point(77, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(187, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "HYPESQUAD CHANGER";
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
      this.BalanceBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.BalanceBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.BalanceBtn.FlatAppearance.BorderSize = 0;
      this.BalanceBtn.FlatStyle = FlatStyle.Flat;
      this.BalanceBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BalanceBtn.ForeColor = Color.White;
      this.BalanceBtn.Location = new Point(5, 4);
      this.BalanceBtn.Name = "BalanceBtn";
      this.BalanceBtn.Size = new Size(146, 23);
      this.BalanceBtn.TabIndex = 6312;
      this.BalanceBtn.Text = "BALANCE";
      this.BalanceBtn.UseVisualStyleBackColor = false;
      this.BalanceBtn.Click += new EventHandler(this.BalanceBtn_Click);
      this.BrillianceBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.BrillianceBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.BrillianceBtn.FlatAppearance.BorderSize = 0;
      this.BrillianceBtn.FlatStyle = FlatStyle.Flat;
      this.BrillianceBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BrillianceBtn.ForeColor = Color.White;
      this.BrillianceBtn.Location = new Point(5, 4);
      this.BrillianceBtn.Name = "BrillianceBtn";
      this.BrillianceBtn.Size = new Size(146, 23);
      this.BrillianceBtn.TabIndex = 6311;
      this.BrillianceBtn.Text = "BRILLIANCE";
      this.BrillianceBtn.UseVisualStyleBackColor = false;
      this.BrillianceBtn.Click += new EventHandler(this.BrillianceBtn_Click);
      this.BraveryBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.BraveryBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.BraveryBtn.FlatAppearance.BorderSize = 0;
      this.BraveryBtn.FlatStyle = FlatStyle.Flat;
      this.BraveryBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BraveryBtn.ForeColor = Color.White;
      this.BraveryBtn.Location = new Point(5, 4);
      this.BraveryBtn.Name = "BraveryBtn";
      this.BraveryBtn.Size = new Size(146, 23);
      this.BraveryBtn.TabIndex = 6310;
      this.BraveryBtn.Text = "BRAVERY";
      this.BraveryBtn.UseVisualStyleBackColor = false;
      this.BraveryBtn.Click += new EventHandler(this.BraveryBtn_Click);
      this.NoneBtn.BackColor = Color.FromArgb(105, 105, 205);
      this.NoneBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.NoneBtn.FlatAppearance.BorderSize = 0;
      this.NoneBtn.FlatStyle = FlatStyle.Flat;
      this.NoneBtn.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.NoneBtn.ForeColor = Color.White;
      this.NoneBtn.Location = new Point(5, 4);
      this.NoneBtn.Name = "NoneBtn";
      this.NoneBtn.Size = new Size(146, 23);
      this.NoneBtn.TabIndex = 6309;
      this.NoneBtn.Text = "NONE";
      this.NoneBtn.UseVisualStyleBackColor = false;
      this.NoneBtn.Click += new EventHandler(this.NoneBtn_Click);
      this.panel49.BackColor = Color.FromArgb(49, 50, 55);
      this.panel49.Controls.Add((Control) this.NoneBtn);
      this.panel49.Location = new Point(12, 42);
      this.panel49.Name = "panel49";
      this.panel49.RightToLeft = RightToLeft.Yes;
      this.panel49.Size = new Size(157, 32);
      this.panel49.TabIndex = 6314;
      this.panel1.BackColor = Color.FromArgb(49, 50, 55);
      this.panel1.Controls.Add((Control) this.BraveryBtn);
      this.panel1.Location = new Point(177, 42);
      this.panel1.Name = "panel1";
      this.panel1.RightToLeft = RightToLeft.Yes;
      this.panel1.Size = new Size(157, 32);
      this.panel1.TabIndex = 6315;
      this.panel3.BackColor = Color.FromArgb(49, 50, 55);
      this.panel3.Controls.Add((Control) this.BrillianceBtn);
      this.panel3.Location = new Point(12, 80);
      this.panel3.Name = "panel3";
      this.panel3.RightToLeft = RightToLeft.Yes;
      this.panel3.Size = new Size(157, 32);
      this.panel3.TabIndex = 6316;
      this.panel2.BackColor = Color.FromArgb(49, 50, 55);
      this.panel2.Controls.Add((Control) this.BalanceBtn);
      this.panel2.Location = new Point(177, 80);
      this.panel2.Name = "panel2";
      this.panel2.RightToLeft = RightToLeft.Yes;
      this.panel2.Size = new Size(157, 32);
      this.panel2.TabIndex = 6317;
      this.InfosFriendTxt.BackColor = Color.FromArgb(33, 34, 38);
      this.InfosFriendTxt.BorderStyle = BorderStyle.None;
      this.InfosFriendTxt.Enabled = false;
      this.InfosFriendTxt.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfosFriendTxt.ForeColor = Color.Silver;
      this.InfosFriendTxt.Location = new Point(0, 130);
      this.InfosFriendTxt.Name = "InfosFriendTxt";
      this.InfosFriendTxt.Size = new Size(347, 16);
      this.InfosFriendTxt.TabIndex = 6318;
      this.InfosFriendTxt.Text = "It's a bit buggy... Sorry try to Patch it";
      this.InfosFriendTxt.TextAlign = HorizontalAlignment.Center;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(347, 145);
      this.Controls.Add((Control) this.InfosFriendTxt);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.panel49);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (HypeStuff);
      this.Text = nameof (HypeStuff);
      this.FormClosing += new FormClosingEventHandler(this.HypeStuff_FormClosing);
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.panel49.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
