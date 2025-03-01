using DiscordRaider.Properties;
using RaidAPI.Core;
using RaidAPI.Core.Friend;
using RaidAPI.Core.Join;
using RaidAPI.Core.Leave;
using RaidAPI.Core.Message;
using RaidAPI.Core.Message.EmbedFunctions;
using RaidAPI.Core.Profile;
using RaidAPI.Core.Reaction;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DiscordRaider
{
  public class SpamMain : Form
  {
    public static bool _CheckTokenForm = false;
    public static string _NickTxt = "Nick Name";
    public static bool _ChangeNickByJoin = false;
    public static string _ServerIDByJoin;
    public bool _EmbedTyping;
    public static bool _ColorUsed = false;
    public static int _EmbedColor;
    public static string _NewNick = "";
    public static string _TokenPath;
    public static bool _enbableLeaveMsg = false;
    public static string _LeaveMsg = "Leave Message";
    public static string _LeaveChannel = "Channel ID";
    public static bool _RndmColor = false;
    public static bool _EmbedBuilderForm = false;
    public static bool _EmbedColorForm = false;
    public static bool _TokenSettings = false;
    public static bool _ChangeNick = false;
    public static bool _LeaveText = false;
    public static bool _EmojiList = false;
    public static bool _ServerInfos = false;
    public static bool _TextStuff = false;
    public static string EmojiString = "Reaction Emoji";
    public static bool _getEmoji = false;
    public static string _Invite;
    public static bool HideShow = false;
    private string TokenPath;
    private bool TokenLoaded;
    private bool ChannelEmbedSpam;
    private bool DmEmbedSpam;
    private bool DMS;
    private bool DMSPAMMER;
    private bool DmSpammer;
    private bool CHS;
    private IContainer components;
    private Panel HeadLinePnl;
    private PictureBox HeadPic;
    private Button ReloadBtn;
    private Button btnClose;
    private Button btnMini;
    private Panel panel2;
    private ComboBox comboBox1;
    private TextBox textBox1;
    private Button button1;
    private Panel panel3;
    private Panel panel5;
    private Panel panel6;
    private Panel RaiderPnl;
    private Panel panel11;
    private Panel JoinLeavePnl;
    private Panel panel235;
    private Label JoinLeaveLbl;
    private TextBox InfoLbl;
    private Panel panel16;
    private Label ModsHeadline;
    private Panel AddTokensPnl;
    private Panel panel15;
    private Label AddTokensLbl;
    private Panel FriendPnl;
    private Panel panel13;
    private Label FriendLbl;
    private Panel ReactorPnl;
    private Panel panel12;
    private Label TextReactorLbl;
    private Panel SpammingPnl;
    private Panel panel1;
    private Label SpammingLbl;
    private Panel FunctionPnl;
    private Panel HeadLineFunc;
    private Panel panel4;
    private Button CloseFuncBtn;
    private Panel panel7;
    private ComboBox comboBox2;
    private TextBox textBox2;
    private Button button2;
    private Panel panel8;
    private Panel panel9;
    private Panel panel10;
    private Panel panel14;
    private Panel InfosLbl;
    private Panel panel40;
    private Panel HeadExtraPnl;
    private Panel panel42;
    private Label HeadExtraLbl;
    private Panel panel43;
    private ComboBox comboBox6;
    private TextBox textBox9;
    private Button button7;
    private Panel panel44;
    private Panel panel45;
    private Panel panel46;
    private Label JoinLbl;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label4;
    private Label label7;
    private Label label1;
    private Label label3;
    private Label label2;
    private Label label5;
    private PictureBox pictureBox1;
    private TextBox ModsHdlLbl;
    private System.Windows.Forms.Timer GetEmojiTimer;
    private NotifyIcon WinInfo;
    private TabControl ModsControl;
    private TabPage SpammingPage;
    private Panel EmbedPnl;
    private Panel EmbedDescPnl;
    private TextBox EmbedDescTxt;
    private Panel EmbedTitlePnl;
    private TextBox EmbedTitleTxt;
    private Panel EmbedChannelPnl;
    private Panel panel33;
    private TextBox EmbedChannelIdTxt;
    public Button EmbedBtn;
    private Label EmbedLbl;
    private Button OpenDMBtn;
    private Panel panel38;
    private Panel ChannelSpPnl;
    private Panel panel18;
    private TextBox ChannelIDTxt;
    private Button DmSpammingBtn;
    private Button OpenExtraStuffBtn;
    private Panel SpamPnl;
    private TextBox MessageSpTxt;
    private Panel EmbedPnl2;
    private Label label17;
    public Button RndColorBtn;
    private Label label19;
    public Button EmbedTypingBtn;
    private Button ChooseColorBtn;
    private Panel SettingsPnl;
    private Label label8;
    public Button TypingBtn;
    private Label label12;
    private Label label13;
    public Button UnderlinedBtn;
    public Button BlockTxt;
    private TabPage ReactPage;
    private Panel MsgReactPnl;
    private TextBox ReactMessageIdTxt;
    private Panel EmojiReactPnl;
    public TextBox ReactEmojiTxt;
    private Panel panel23;
    private Button EmojiBtn;
    private Panel ReactIdPnl;
    private TextBox ReactChannelIdTxt;
    private TabPage FriendPage;
    private Panel panel55;
    private TextBox InfosFriendTxt;
    private Panel RmvPanel;
    private Panel panel52;
    private TextBox RmvUserTxt;
    private Panel AddPnl;
    private Panel panel54;
    private TextBox AddUserText;
    private TabPage TokensPage;
    private Button TokenSettingsBtn;
    private Panel panel71;
    private Panel panel60;
    private Panel panel59;
    private Panel panel58;
    private Panel panel57;
    private RichTextBox LoadedTokens;
    private TextBox InfoAddTokensTxt;
    private Panel panel56;
    private Panel TokensPnl;
    private Panel panel53;
    private TextBox TokensTxt;
    private TabPage ErrorPage;
    private Panel panel83;
    private Panel ErrorPnl;
    private Label label6;
    private Label label14;
    private TabPage JoinPage;
    private Panel panel21;
    private TextBox InfosJoinLeave;
    private Panel LeaveID;
    private Panel panel27;
    private Panel panel26;
    private Panel panel25;
    private Panel panel24;
    private Panel panel20;
    private TextBox LeaveServerTxt;
    private Button LeaveSettingBtn;
    private Panel InvitePnl;
    private Panel panel28;
    private Panel panel29;
    private Panel panel30;
    private Panel panel31;
    private Button JoinSettingsBtn;
    private Panel panel19;
    private TextBox JoinTxt;
    private Button GetInfosBtn;
    private RoundBtn StartEmbedSpammer;
    private RoundBtn SpammerBtn;
    private RoundBtn JoinServerBtn;
    private RoundBtn LeaveBtn;
    private RoundBtn SendReBtn;
    private RoundBtn RemoveReBtn;
    private RoundBtn RemoveReactionBtn;
    private RoundBtn AddReactionBtn;
    private RoundBtn AddTokensBtn;
    private RoundBtn OpenJoinerBtn;
    private RoundBtn OpenTokenAddBtn;
    private RoundBtn OpenFriendBtn;
    private RoundBtn OpenReactorBtn;
    private RoundBtn OpenSpammerBtn;

    public SpamMain()
    {
      this.InitializeComponent();
      this.TokensTxt.AllowDrop = true;
      this.ChangeCornersForm(509, 358);
      this.ChangeCornersRaid();
      this.ChnageInfoPnl();
      this.ChnageCornersSpam(298, 83);
      this.ChangeEmojiPnl();
      this.ChangeMesgReactPnl();
      this.ChangeReactIdPnl();
      this.ChangeRmvPanel();
      this.ChangeAddPnl();
      this.ChangeErrorPnl();
      this.ChangeLeavePnl();
      this.ChangeInvitePnl();
      this.ChnageChannelPnl();
      this.ChnageEmbedStuff3();
      this.ChnageEmbedStuff2();
      this.ChnageEmbedStuff1();
      this.ChnageAddTokensPnl();
      this.ChnageFriendPnl();
      this.ChnageReactorPnl();
      this.ChnageSpammingPnl();
      this.ChnageJoinLeavePnl();
      this.ChnageTokensPnl();
      this.Check();
    }

    private void Credits()
    {
      if (!FormSettings._Credits)
        return;
      if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
        return;
      using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
      {
        foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
        {
          try
          {
            newClient.Login(_Token);
            ClientSettings.SetStream(_Token, "https://discord.gg/pGkkBCe");
          }
          catch
          {
          }
        }
      }
    }

    private void Check()
    {
      if (!FormSettings._SaveToken)
        return;
      if (!File.Exists(Path.Combine(Settings.Default._TokenPath)))
        return;
      this.TokensTxt.Text = Settings.Default._TokenPath;
      string[] _Path = File.ReadAllLines(Settings.Default._TokenPath);
      SpamMain._TokenPath = Settings.Default._TokenPath;
      Tokens.LoadTokens(_Path);
      this.TokenLoaded = true;
      this.WinInfo.Visible = true;
      this.WinInfo.BalloonTipText = "Tokens automatically add!";
      this.WinInfo.ShowBalloonTip(1000);
      this.Credits();
      if (FormSettings._HideTokens)
        this.LoadedTokens.Text = "{Hidden}";
      else
        this.LoadedTokens.Text = File.ReadAllText(Settings.Default._TokenPath);
    }

    private void SpamMain_FormClosing(object sender, FormClosingEventArgs e) => Main._SpamForm = false;

    private void JoinLbl_Click(object sender, EventArgs e) => Process.Start(this.JoinLbl.Text);

    private void BtnClose_MouseEnter(object sender, EventArgs e) => this.btnClose.BackColor = Color.FromArgb(243, 72, 75);

    private void BtnClose_MouseLeave(object sender, EventArgs e) => this.btnClose.BackColor = Color.FromArgb(33, 34, 38);

    private void ShowErrorPage()
    {
      this.ModsHdlLbl.Text = "NO TOKENS FOUND";
      this.FunctionPnl.Size = new Size(295, 126);
      this.Size = new Size(318, 188);
      this.ModsControl.SelectedTab = this.ErrorPage;
      this.ChnageCornersFunction(295, 126);
    }

    private void ChnageTokensPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.TokensPnl.Width, this.TokensPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.TokensPnl.Region = new Region(path);
    }

    private void ChnageJoinLeavePnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.JoinLeavePnl.Width, this.JoinLeavePnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.JoinLeavePnl.Region = new Region(path);
    }

    private void ChnageSpammingPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.SpammingPnl.Width, this.SpammingPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.SpammingPnl.Region = new Region(path);
    }

    private void ChnageReactorPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ReactorPnl.Width, this.ReactorPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ReactorPnl.Region = new Region(path);
    }

    private void ChnageFriendPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.FriendPnl.Width, this.FriendPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.FriendPnl.Region = new Region(path);
    }

    private void ChnageAddTokensPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.AddTokensPnl.Width, this.AddTokensPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.AddTokensPnl.Region = new Region(path);
    }

    private void ChnageEmbedStuff1()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.EmbedChannelPnl.Width, this.EmbedChannelPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.EmbedChannelPnl.Region = new Region(path);
    }

    private void ChnageEmbedStuff2()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.EmbedTitlePnl.Width, this.EmbedTitlePnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.EmbedTitlePnl.Region = new Region(path);
    }

    private void ChnageEmbedStuff3()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.EmbedDescPnl.Width, this.EmbedDescPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.EmbedDescPnl.Region = new Region(path);
    }

    private void ChnageChannelPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ChannelSpPnl.Width, this.ChannelSpPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ChannelSpPnl.Region = new Region(path);
    }

    private void ChangeInvitePnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.InvitePnl.Width, this.InvitePnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.InvitePnl.Region = new Region(path);
    }

    private void ChangeLeavePnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.LeaveID.Width, this.LeaveID.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.LeaveID.Region = new Region(path);
    }

    private void ChangeErrorPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ErrorPnl.Width, this.ErrorPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ErrorPnl.Region = new Region(path);
    }

    private void ChangeAddPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.AddPnl.Width, this.AddPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.AddPnl.Region = new Region(path);
    }

    private void ChangeRmvPanel()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.RmvPanel.Width, this.RmvPanel.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.RmvPanel.Region = new Region(path);
    }

    private void ChangeReactIdPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.ReactIdPnl.Width, this.ReactIdPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.ReactIdPnl.Region = new Region(path);
    }

    private void ChangeMesgReactPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.MsgReactPnl.Width, this.MsgReactPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.MsgReactPnl.Region = new Region(path);
    }

    private void ChangeEmojiPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.EmojiReactPnl.Width, this.EmojiReactPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.EmojiReactPnl.Region = new Region(path);
    }

    private void ChnageCornersSpam(int x, int y)
    {
      Rectangle rectangle = new Rectangle(0, 0, this.SpamPnl.Width, this.SpamPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.SpamPnl.Region = new Region(path);
    }

    private void ChnageCornersFunction(int x, int y)
    {
      Rectangle rectangle = new Rectangle(0, 0, this.FunctionPnl.Width, this.FunctionPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.FunctionPnl.Region = new Region(path);
    }

    private void ChangeCornersForm(int x, int y)
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

    private void ChnageInfoPnl()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.InfosLbl.Width, this.InfosLbl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.InfosLbl.Region = new Region(path);
    }

    private void ChangeCornersRaid()
    {
      Rectangle rectangle = new Rectangle(0, 0, this.RaiderPnl.Width, this.RaiderPnl.Height);
      GraphicsPath path = new GraphicsPath();
      int num = 20;
      path.AddArc(rectangle.X, rectangle.Y, num, num, 180f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y, num, num, 270f, 90f);
      path.AddArc(rectangle.X + rectangle.Width - num, rectangle.Y + rectangle.Height - num, num, num, 0.0f, 90f);
      path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - num, num, num, 90f, 90f);
      this.RaiderPnl.Region = new Region(path);
    }

    private void HeadLinePnl_MouseDown(object sender, MouseEventArgs e)
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

    private void HeadLinePnl_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void HeadPic_MouseDown(object sender, MouseEventArgs e)
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

    private void HeadPic_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Mouse.newpoint = Control.MousePosition;
      Mouse.newpoint.X -= Mouse.x;
      Mouse.newpoint.Y -= Mouse.y;
      this.Location = Mouse.newpoint;
    }

    private void BtnMini_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Main._Show = true;
      Main._SpamForm = false;
      this.Close();
    }

    private void ReloadBtn_Click(object sender, EventArgs e) => Application.Restart();

    private void UpdateInfoLbl(string _Text) => this.InfoLbl.Text = _Text;

    private void OpenJoinerBtn_Click(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = false;
      this.Size = new Size(400, 203);
      this.ChnageCornersFunction(373, 142);
      this.FunctionPnl.Size = new Size(373, 142);
      this.ModsHdlLbl.Text = "JOINER / LEAVER";
      this.ModsControl.SelectedTab = this.JoinPage;
      this.FunctionPnl.Visible = true;
      this.RaiderPnl.Visible = false;
      this.ChnageCornersFunction(373, 142);
      this.ChangeCornersForm(400, 203);
    }

    private void OpenSpammerBtn_Click(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = false;
      this.Size = new Size(477, (int)byte.MaxValue);
      this.ChnageCornersFunction(450, 196);
      this.FunctionPnl.Size = new Size(450, 196);
      this.ModsHdlLbl.Text = "MESSAGE SPAMMER";
      this.ModsControl.SelectedTab = this.SpammingPage;
      this.FunctionPnl.Visible = true;
      this.RaiderPnl.Visible = false;
      this.ChnageCornersFunction(450, 196);
      this.ChangeCornersForm(477, (int)byte.MaxValue);
    }

    private void OpenReactorBtn_Click(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = false;
      this.Size = new Size(400, 238);
      this.ChnageCornersFunction(373, 176);
      this.FunctionPnl.Size = new Size(373, 176);
      this.ModsHdlLbl.Text = "MESSAGE REACTOR";
      this.ModsControl.SelectedTab = this.ReactPage;
      this.FunctionPnl.Visible = true;
      this.RaiderPnl.Visible = false;
      this.ChnageCornersFunction(373, 176);
      this.ChangeCornersForm(400, 238);
    }

    private void OpenFriendBtn_Click(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = false;
      this.Size = new Size(400, 203);
      this.ChnageCornersFunction(373, 142);
      this.FunctionPnl.Size = new Size(373, 142);
      this.ModsHdlLbl.Text = "FRIEND PAGE";
      this.ModsControl.SelectedTab = this.FriendPage;
      this.FunctionPnl.Visible = true;
      this.RaiderPnl.Visible = false;
      this.ChnageCornersFunction(373, 142);
      this.ChangeCornersForm(400, 203);
    }

    private void OpenTokenAddBtn_Click_1(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = false;
      this.Size = new Size(474, 239);
      this.ChnageCornersFunction(450, 176);
      this.FunctionPnl.Size = new Size(450, 176);
      this.ModsHdlLbl.Text = "ADD TOKENS";
      this.ModsControl.SelectedTab = this.TokensPage;
      this.FunctionPnl.Visible = true;
      this.RaiderPnl.Visible = false;
      this.ChnageCornersFunction(450, 176);
      this.ChangeCornersForm(450, 176);
    }

    private void OpenTokenAddBtn_Click(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = false;
      this.Size = new Size(474, 239);
      this.ChnageCornersFunction(450, 176);
      this.FunctionPnl.Size = new Size(450, 176);
      this.ModsHdlLbl.Text = "ADD TOKENS";
      this.ModsControl.SelectedTab = this.TokensPage;
      this.FunctionPnl.Visible = true;
      this.RaiderPnl.Visible = false;
      this.ChnageCornersFunction(450, 176);
      this.ChangeCornersForm(450, 176);
    }

    private void JoinLeaveLbl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page for joining and leaving Servers");
      this.JoinLeavePnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void JoinLeaveLbl_MouseLeave(object sender, EventArgs e) => this.JoinLeavePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void SpammingLbl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page to Spam Servers and your Firends");
      this.SpammingPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void SpammingLbl_MouseLeave(object sender, EventArgs e) => this.SpammingPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void TextReactorLbl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page for reacting to a Message");
      this.ReactorPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void TextReactorLbl_MouseLeave(object sender, EventArgs e) => this.ReactorPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void FriendLbl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page to Spam friend request");
      this.FriendPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void FriendLbl_MouseLeave(object sender, EventArgs e) => this.FriendPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void AddTokensLbl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page to add Tokens");
      this.AddTokensPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void AddTokensLbl_MouseLeave(object sender, EventArgs e) => this.AddTokensPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void JoinLeavePnl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page for joining and leaving Servers");
      this.JoinLeavePnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void JoinLeavePnl_MouseLeave(object sender, EventArgs e) => this.JoinLeavePnl.BackColor = Color.FromArgb(49, 50, 55);

    private void SpammingPnl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page to Spam Servers and your Firends");
      this.SpammingPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void SpammingPnl_MouseLeave(object sender, EventArgs e) => this.SpammingPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void ReactorPnl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page for reacting to a Message");
      this.ReactorPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void ReactorPnl_MouseLeave(object sender, EventArgs e) => this.ReactorPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void FriendPnl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page to spam friend request");
      this.FriendPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void FriendPnl_MouseLeave(object sender, EventArgs e) => this.FriendPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void AddTokensPnl_MouseEnter(object sender, EventArgs e)
    {
      this.UpdateInfoLbl("Page to add Tokens");
      this.AddTokensPnl.BackColor = Color.FromArgb(57, 60, 69);
    }

    private void AddTokensPnl_MouseLeave(object sender, EventArgs e) => this.AddTokensPnl.BackColor = Color.FromArgb(49, 50, 55);

    private void ReactEmojiTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.ReactEmojiTxt.Text == "Reaction Emoji"))
        return;
      this.ReactEmojiTxt.Text = "";
      this.ReactEmojiTxt.ForeColor = Color.White;
    }

    private void ReactEmojiTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.ReactEmojiTxt.Text == ""))
        return;
      this.ReactEmojiTxt.Text = "Reaction Emoji";
      this.ReactEmojiTxt.ForeColor = Color.Silver;
    }

    private void StartJoin(string invite)
    {
      invite = invite.Replace("https://discord.gg/", "");
      if (!(invite == "VJhh67w") && !(invite == "zZXBBMD") && !(invite == "pGkkBCe"))
      {
        if (!(invite == "Cgsdmqp"))
        {
          try
          {
            JoinServer.StartJoining(invite);
            return;
          }
          catch
          {
            return;
          }
        }
      }
      int num = (int)MessageBox.Show("You cant Raid this Server", "Discord Raider");
    }

    private void JoinServerBtn_Click_1(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        if (this.JoinTxt.Text == "" || this.JoinTxt.Text == "Discord Invite")
        {
          int num1 = (int)MessageBox.Show("You need to enter an Invite first", "Discord Raider");
        }
        else if (SpamMain._ChangeNickByJoin)
        {
          try
          {
            this.StartJoin(this.JoinTxt.Text);
            this.WinInfo.Visible = true;
            this.WinInfo.BalloonTipText = "Server Joined!";
            this.WinInfo.ShowBalloonTip(1000);
            if (!File.Exists(Path.Combine(SpamMain._TokenPath)))
            {
              int num2 = (int)MessageBox.Show("You need to load first your Tokens", "Discord Raider");
            }
            else
            {
              using (StreamReader streamReader = File.OpenText(Path.Combine(SpamMain._TokenPath)))
              {
                foreach (string _Token in streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                {
                  try
                  {
                    RaidAPI.Core.Profile.ChangeNick.ChangeUserNick(_Token, SpamMain._ServerIDByJoin, SpamMain._NewNick);
                  }
                  catch
                  {
                  }
                }
              }
            }
          }
          catch
          {
          }
        }
        else
        {
          this.StartJoin(this.JoinTxt.Text);
          this.WinInfo.Visible = true;
          this.WinInfo.BalloonTipText = "Server Joined!";
          this.WinInfo.ShowBalloonTip(1000);
        }
      }
      else
        this.ShowErrorPage();
    }

    private void JoinServerBtn_Click(object sender, EventArgs e)
    {
    }

    private void StartLeave(string ID)
    {
      try
      {
        LeaveServer.StartLeaving(ID);
      }
      catch
      {
      }
    }

    private void LeaveBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        if (SpamMain._enbableLeaveMsg)
        {
          if (!(this.LeaveServerTxt.Text == ""))
          {
            if (!(this.LeaveServerTxt.Text == "Server ID"))
            {
              try
              {
                ChannelFunction.ChannelSpammer(SpamMain._LeaveChannel, SpamMain._LeaveMsg);
                this.StartLeave(this.LeaveServerTxt.Text);
                this.WinInfo.Visible = true;
                this.WinInfo.BalloonTipText = "Server Leaved!";
                this.WinInfo.ShowBalloonTip(1000);
                return;
              }
              catch
              {
                return;
              }
            }
          }
          int num = (int)MessageBox.Show("You need to enter a Server ID first", "Discord Raider");
        }
        else if (this.LeaveServerTxt.Text == "" || this.LeaveServerTxt.Text == "Server ID")
        {
          int num1 = (int)MessageBox.Show("You need to enter a Server ID first", "Discord Raider");
        }
        else
        {
          this.StartLeave(this.LeaveServerTxt.Text);
          this.WinInfo.Visible = true;
          this.WinInfo.BalloonTipText = "Server Leaved!";
          this.WinInfo.ShowBalloonTip(1000);
        }
      }
      else
        this.ShowErrorPage();
    }

    private void GetInfosBtn_Click(object sender, EventArgs e)
    {
      if (this.JoinTxt.Text == "" || this.JoinTxt.Text == "Discord Invite")
      {
        int num = (int)MessageBox.Show("You need to enter an Invite first", "Discord Raider");
      }
      else
      {
        if (SpamMain._ServerInfos)
          return;
        SpamMain._ServerInfos = true;
        SpamMain._Invite = this.JoinTxt.Text;
        new ServerInfo().Show();
      }
    }

    private void JoinTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.JoinTxt.Text == "Discord Invite"))
        return;
      this.JoinTxt.Text = "";
      this.JoinTxt.ForeColor = Color.White;
    }

    private void JoinTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.JoinTxt.Text == ""))
        return;
      this.JoinTxt.Text = "Discord Invite";
      this.JoinTxt.ForeColor = Color.Silver;
    }

    private void LeaveServerTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.LeaveServerTxt.Text == "Server ID"))
        return;
      this.LeaveServerTxt.Text = "";
      this.LeaveServerTxt.ForeColor = Color.White;
    }

    private void LeaveServerTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.LeaveServerTxt.Text == ""))
        return;
      this.LeaveServerTxt.Text = "Server ID";
      this.LeaveServerTxt.ForeColor = Color.Silver;
    }

    private void JoinTxt_MouseEnter(object sender, EventArgs e) => this.InfosJoinLeave.Text = "Paste an Invite to let your Bots join the Server";

    private void JoinTxt_MouseLeave(object sender, EventArgs e) => this.InfosJoinLeave.Text = "[info]";

    private void LeaveServerTxt_MouseEnter(object sender, EventArgs e) => this.InfosJoinLeave.Text = "Paste a Server ID to let your Bots leave the Server";

    private void LeaveServerTxt_MouseLeave(object sender, EventArgs e) => this.InfosJoinLeave.Text = "[info]";

    private void StartSpammer()
    {
      this.DMSPAMMER = true;
      new Thread((ThreadStart)(() =>
      {
        if (!this.DMSPAMMER)
          return;
        while (this.DMSPAMMER)
        {
          try
          {
            if (this.BlockTxt.BackColor == Color.FromArgb(105, 105, 205))
              DMFunction.StartSpam(this.ChannelIDTxt.Text, "```" + this.MessageSpTxt.Text + "```");
            if (this.UnderlinedBtn.BackColor == Color.FromArgb(105, 105, 205))
              DMFunction.StartSpam(this.ChannelIDTxt.Text, "__**" + this.MessageSpTxt.Text + "**__");
            if (!(this.UnderlinedBtn.BackColor == Color.FromArgb(105, 105, 205)) && !(this.BlockTxt.BackColor == Color.FromArgb(105, 105, 205)))
              DMFunction.StartSpam(this.ChannelIDTxt.Text, this.MessageSpTxt.Text);
            if (this.TypingBtn.BackColor == Color.FromArgb(105, 105, 205))
              DMFunction.StartSpam(this.ChannelIDTxt.Text, this.MessageSpTxt.Text);
          }
          catch
          {
          }
        }
      })).Start();
    }

    private void StartChannelSp()
    {
      this.CHS = true;
      new Thread((ThreadStart)(() =>
      {
        if (!this.CHS)
          return;
        while (this.CHS)
        {
          try
          {
            if (this.BlockTxt.BackColor == Color.FromArgb(105, 105, 205))
              ChannelFunction.ChannelSpammer(this.ChannelIDTxt.Text, "```" + this.MessageSpTxt.Text + "```");
            if (this.UnderlinedBtn.BackColor == Color.FromArgb(105, 105, 205))
              ChannelFunction.ChannelSpammer(this.ChannelIDTxt.Text, "__**" + this.MessageSpTxt.Text + "**__");
            if (!(this.UnderlinedBtn.BackColor == Color.FromArgb(105, 105, 205)) && !(this.BlockTxt.BackColor == Color.FromArgb(105, 105, 205)))
              ChannelFunction.ChannelSpammer(this.ChannelIDTxt.Text, this.MessageSpTxt.Text);
            if (this.TypingBtn.BackColor == Color.FromArgb(105, 105, 205))
              TypingFunc.TriggerUserTyping(this.ChannelIDTxt.Text);
          }
          catch
          {
          }
        }
      })).Start();
    }

    private void SpammerBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        if (this.DmSpammer)
        {
          switch (this.SpammerBtn.Text)
          {
            case "Start Spammer":
              this.SpammerBtn.Text = "Stop Spammer";
              this.StartSpammer();
              this.WinInfo.Visible = true;
              this.WinInfo.BalloonTipText = "DM Spammer started!";
              this.WinInfo.ShowBalloonTip(1000);
              break;
            case "Stop Spammer":
              this.DMS = false;
              this.DMSPAMMER = false;
              this.WinInfo.Visible = true;
              this.WinInfo.BalloonTipText = "DM Spammer stopped!";
              this.WinInfo.ShowBalloonTip(1000);
              this.SpammerBtn.Text = "Start Spammer";
              break;
          }
        }
        else
        {
          switch (this.SpammerBtn.Text)
          {
            case "Start Spammer":
              this.SpammerBtn.Text = "Stop Spammer";
              this.WinInfo.Visible = true;
              this.WinInfo.BalloonTipText = "Channel Spammer started!";
              this.WinInfo.ShowBalloonTip(1000);
              this.StartChannelSp();
              break;
            case "Stop Spammer":
              this.CHS = false;
              this.WinInfo.Visible = true;
              this.WinInfo.BalloonTipText = "Channel Spammer stopped!";
              this.WinInfo.ShowBalloonTip(1000);
              this.SpammerBtn.Text = "Start Spammer";
              break;
          }
        }
      }
      else
        this.ShowErrorPage();
    }

    private void DmSpammingBtn_Click(object sender, EventArgs e)
    {
      switch (this.DmSpammingBtn.Text)
      {
        case "Open DM Spammer":
          this.ModsHdlLbl.Text = "MESSAGE SPAMMER | DM SPAMMER";
          this.ChannelIDTxt.Text = "User ID";
          this.EmbedChannelIdTxt.Text = "User ID";
          this.DmSpammingBtn.Text = "Open Channel Spammer";
          this.EmbedChannelIdTxt.ForeColor = Color.DarkGray;
          this.ChannelIDTxt.ForeColor = Color.DarkGray;
          this.CHS = false;
          this.DmSpammer = true;
          break;
        case "Open Channel Spammer":
          this.ModsHdlLbl.Text = "MESSAGE SPAMMER | CHANNEL SPAMMER";
          this.ChannelIDTxt.Text = "Channel ID";
          this.EmbedChannelIdTxt.Text = "Channel ID";
          this.DmSpammer = false;
          this.DMS = false;
          this.DMSPAMMER = false;
          this.DmSpammingBtn.Text = "Open DM Spammer";
          this.EmbedChannelIdTxt.ForeColor = Color.DarkGray;
          this.ChannelIDTxt.ForeColor = Color.DarkGray;
          break;
      }
    }

    private void OpenExtraStuffBtn_Click(object sender, EventArgs e)
    {
      if (SpamMain._TextStuff)
        return;
      SpamMain._TextStuff = true;
      new TextStuff().Show();
    }

    private void ChannelIDTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.ChannelIDTxt.Text == "Channel ID") && !(this.ChannelIDTxt.Text == "User ID"))
        return;
      this.ChannelIDTxt.Text = "";
      this.ChannelIDTxt.ForeColor = Color.White;
    }

    private void ChannelIDTxt_Leave(object sender, EventArgs e)
    {
      if (this.DmSpammer)
      {
        if (!(this.ChannelIDTxt.Text == ""))
          return;
        this.ChannelIDTxt.Text = "User ID";
        this.ChannelIDTxt.ForeColor = Color.Silver;
      }
      else
      {
        if (!(this.ChannelIDTxt.Text == ""))
          return;
        this.ChannelIDTxt.Text = "Channel ID";
        this.ChannelIDTxt.ForeColor = Color.Silver;
      }
    }

    private void MessageSpTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.MessageSpTxt.Text == "Your Message"))
        return;
      this.MessageSpTxt.Text = "";
      this.MessageSpTxt.ForeColor = Color.White;
    }

    private void MessageSpTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.MessageSpTxt.Text == ""))
        return;
      this.MessageSpTxt.Text = "Your Message";
      this.MessageSpTxt.ForeColor = Color.Silver;
    }

    private void ReactChannelIdTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.ReactChannelIdTxt.Text == "Channel ID"))
        return;
      this.ReactChannelIdTxt.Text = "";
      this.ReactChannelIdTxt.ForeColor = Color.White;
    }

    private void ReactChannelIdTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.ReactChannelIdTxt.Text == ""))
        return;
      this.ReactChannelIdTxt.Text = "Channel ID";
      this.ReactChannelIdTxt.ForeColor = Color.Silver;
    }

    private void ReactMessageIdTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.ReactMessageIdTxt.Text == "Message ID"))
        return;
      this.ReactMessageIdTxt.Text = "";
      this.ReactMessageIdTxt.ForeColor = Color.White;
    }

    private void ReactMessageIdTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.ReactMessageIdTxt.Text == ""))
        return;
      this.ReactMessageIdTxt.Text = "Message ID";
      this.ReactMessageIdTxt.ForeColor = Color.Silver;
    }

    private void AddReactionBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        try
        {
          Reactions.StartAdd(this.ReactChannelIdTxt.Text, this.ReactMessageIdTxt.Text, this.ReactEmojiTxt.Text);
          this.WinInfo.Visible = true;
          this.WinInfo.BalloonTipText = "Reaction " + this.ReactEmojiTxt.Text + " add!";
          this.WinInfo.ShowBalloonTip(1000);
        }
        catch
        {
        }
      }
      else
        this.ShowErrorPage();
    }

    private void RemoveReactionBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        try
        {
          Reactions.StartRemove(this.ReactChannelIdTxt.Text, this.ReactMessageIdTxt.Text, this.ReactEmojiTxt.Text);
          this.WinInfo.Visible = true;
          this.WinInfo.BalloonTipText = "Reaction " + this.ReactEmojiTxt.Text + " removed!";
          this.WinInfo.ShowBalloonTip(1000);
        }
        catch
        {
        }
      }
      else
        this.ShowErrorPage();
    }

    private void AddUserText_MouseEnter(object sender, EventArgs e) => this.InfosFriendTxt.Text = "Paste the Discord Username + Hashtag (User1337#0081)";

    private void RmvUserTxt_MouseEnter(object sender, EventArgs e) => this.InfosFriendTxt.Text = "Just paste the User ID";

    private void AddUserText_Enter(object sender, EventArgs e)
    {
      if (!(this.AddUserText.Text == "Name + Hashtag"))
        return;
      this.AddUserText.Text = "";
      this.AddUserText.ForeColor = Color.White;
    }

    private void AddUserText_Leave(object sender, EventArgs e)
    {
      if (!(this.AddUserText.Text == ""))
        return;
      this.AddUserText.Text = "Name + Hashtag";
      this.AddUserText.ForeColor = Color.Silver;
    }

    private void RmvUserTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.RmvUserTxt.Text == "User ID"))
        return;
      this.RmvUserTxt.Text = "";
      this.RmvUserTxt.ForeColor = Color.White;
    }

    private void RmvUserTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.RmvUserTxt.Text == ""))
        return;
      this.RmvUserTxt.Text = "User ID";
      this.RmvUserTxt.ForeColor = Color.Silver;
    }

    private void SendReBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        try
        {
          string[] strArray = this.AddUserText.Text.Split("#".ToCharArray());
          SendFriend.StartFriend(strArray[0], Convert.ToInt32(strArray[1]));
          this.WinInfo.Visible = true;
          this.WinInfo.BalloonTipText = "Friend request send!";
          this.WinInfo.ShowBalloonTip(1000);
        }
        catch
        {
        }
      }
      else
        this.ShowErrorPage();
    }

    private void RemoveReBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        try
        {
          RmvFriend.StartFriend(this.RmvUserTxt.Text);
          this.WinInfo.Visible = true;
          this.WinInfo.BalloonTipText = "Friend request deleted!";
          this.WinInfo.ShowBalloonTip(1000);
        }
        catch
        {
        }
      }
      else
        this.ShowErrorPage();
    }

    private void TokensTxt_MouseEnter(object sender, EventArgs e) => this.InfoAddTokensTxt.Text = "Just drag your text file with your tokens in here";

    private void TokensTxt_MouseLeave(object sender, EventArgs e) => this.InfoAddTokensTxt.Text = "[info]";

    private void TokensTxt_DragDrop(object sender, DragEventArgs e)
    {
      foreach (string str in (Array)e.Data.GetData(DataFormats.FileDrop, false))
      {
        this.TokensTxt.Text = "";
        this.TokensTxt.Text += str;
        this.TokenPath = this.TokensTxt.Text;
        SpamMain._TokenPath = this.TokenPath;
        Tokens.LoadTokens(File.ReadAllLines(this.TokenPath));
        this.LoadedTokens.Text = File.ReadAllText(this.TokensTxt.Text);
        Tokens._RaidTokens = this.LoadedTokens.Lines;
        this.TokenLoaded = true;
        Settings.Default._TokenPath = this.TokenPath;
        Settings.Default.Save();
        this.Credits();
        this.WinInfo.Visible = true;
        this.WinInfo.BalloonTipText = "Tokens add!";
        this.WinInfo.ShowBalloonTip(1000);
      }
    }

    private void TokensTxt_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }

    private void CloseFuncBtn_Click(object sender, EventArgs e)
    {
      this.InfosLbl.Visible = true;
      this.Size = new Size(509, 358);
      this.FunctionPnl.Visible = false;
      this.RaiderPnl.Visible = true;
      this.ChangeCornersForm(509, 358);
    }

    private void BlockTxt_Click(object sender, EventArgs e)
    {
      if (this.BlockTxt.BackColor == Color.FromArgb(105, 105, 205))
        this.BlockTxt.BackColor = Color.FromArgb(33, 34, 38);
      else
        this.BlockTxt.BackColor = Color.FromArgb(105, 105, 205);
    }

    private void TypingBtn_Click(object sender, EventArgs e)
    {
      if (this.TypingBtn.BackColor == Color.FromArgb(105, 105, 205))
        this.TypingBtn.BackColor = Color.FromArgb(33, 34, 38);
      else
        this.TypingBtn.BackColor = Color.FromArgb(105, 105, 205);
    }

    private void UnderlinedBtn_Click(object sender, EventArgs e)
    {
      if (this.UnderlinedBtn.BackColor == Color.FromArgb(105, 105, 205))
        this.UnderlinedBtn.BackColor = Color.FromArgb(33, 34, 38);
      else
        this.UnderlinedBtn.BackColor = Color.FromArgb(105, 105, 205);
    }

    private void AddTokensBtn_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text|*.txt|All|*.*";
      openFileDialog.Title = "Select a text file with your Tokens";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.TokensTxt.Text = openFileDialog.FileName;
      this.TokenPath = this.TokensTxt.Text;
      SpamMain._TokenPath = this.TokenPath;
      Tokens.LoadTokens(File.ReadAllLines(this.TokenPath));
      this.LoadedTokens.Text = File.ReadAllText(this.TokensTxt.Text);
      Tokens._RaidTokens = this.LoadedTokens.Lines;
      Settings.Default._TokenPath = this.TokenPath;
      Settings.Default.Save();
      this.TokenLoaded = true;
      this.Credits();
      this.WinInfo.Visible = true;
      this.WinInfo.BalloonTipText = "Tokens add!";
      this.WinInfo.ShowBalloonTip(1000);
    }

    private void EmojiBtn_Click(object sender, EventArgs e)
    {
      if (SpamMain._EmojiList)
        return;
      SpamMain._EmojiList = true;
      new EmojiList().Show();
      this.GetEmojiTimer.Start();
    }

    private void GetEmojiTimer_Tick(object sender, EventArgs e)
    {
      if (SpamMain._EmojiList)
        this.ReactEmojiTxt.Text = SpamMain.EmojiString;
      else
        this.GetEmojiTimer.Stop();
    }

    private void JoinSettingsBtn_Click(object sender, EventArgs e)
    {
      if (SpamMain._ChangeNick)
        return;
      if (this.JoinTxt.Text == "" || this.JoinTxt.Text == "Discord Invite")
      {
        int num = (int)MessageBox.Show("You need to paste a Invite first!", "Discord Raider");
      }
      else
      {
        SpamMain._Invite = this.JoinTxt.Text;
        SpamMain._ChangeNick = true;
        new ChangeNick().Show();
      }
    }

    private void LeaveSettingBtn_Click(object sender, EventArgs e)
    {
      if (SpamMain._LeaveText)
        return;
      SpamMain._LeaveText = true;
      new LeaveText().Show();
    }

    private void ChooseColorBtn_Click(object sender, EventArgs e)
    {
      if (SpamMain._EmbedColorForm)
        return;
      SpamMain._EmbedColorForm = true;
      new EmbedColor().Show();
    }

    private void StartChannelEmbedSpam()
    {
      this.WinInfo.Visible = true;
      this.WinInfo.BalloonTipText = "Channel Embed Spammer started!";
      this.WinInfo.ShowBalloonTip(1000);
      this.ChannelEmbedSpam = true;
      new Thread((ThreadStart)(() =>
      {
        if (!this.ChannelEmbedSpam)
          return;
        while (this.ChannelEmbedSpam)
        {
          try
          {
            if (SpamMain._RndmColor)
            {
              if (this._EmbedTyping)
              {
                int _Color = new Random().Next(1, 32500);
                TypingFunc.TriggerUserTyping(this.EmbedChannelIdTxt.Text);
                EmbedChannel.EasyChannelSpammer(this.EmbedChannelIdTxt.Text, "", this.EmbedTitleTxt.Text, this.EmbedDescTxt.Text, _Color);
              }
              else
                EmbedChannel.EasyChannelSpammer(this.EmbedChannelIdTxt.Text, "", this.EmbedTitleTxt.Text, this.EmbedDescTxt.Text, new Random().Next(1, 32500));
            }
            else if (SpamMain._ColorUsed)
            {
              if (this._EmbedTyping)
              {
                TypingFunc.TriggerUserTyping(this.EmbedChannelIdTxt.Text);
                EmbedChannel.EasyChannelSpammer(this.EmbedChannelIdTxt.Text, "", this.EmbedTitleTxt.Text, this.EmbedDescTxt.Text, SpamMain._EmbedColor);
              }
              else
                EmbedChannel.EasyChannelSpammer(this.EmbedChannelIdTxt.Text, "", this.EmbedTitleTxt.Text, this.EmbedDescTxt.Text, SpamMain._EmbedColor);
            }
            else
            {
              this.StartEmbedSpammer.Text = "Start Spammer";
              int num = (int)MessageBox.Show("You need to choose a Color first\nPress on the Button Choose Color", "Discord Raider");
              this.ChannelEmbedSpam = false;
            }
          }
          catch
          {
          }
        }
      })).Start();
    }

    private void StartEmbedSpamDM()
    {
      this.WinInfo.Visible = true;
      this.WinInfo.BalloonTipText = "DM Embed Spammer started!";
      this.WinInfo.ShowBalloonTip(1000);
      this.DmEmbedSpam = true;
      new Thread((ThreadStart)(() =>
      {
        if (!this.DmEmbedSpam)
          return;
        while (this.DmEmbedSpam)
        {
          try
          {
            if (SpamMain._RndmColor)
              EmbedDM.SendEmbedDM(this.EmbedChannelIdTxt.Text, "", this.EmbedTitleTxt.Text, this.EmbedDescTxt.Text, new Random().Next(1, 32500));
            else if (SpamMain._ColorUsed)
            {
              EmbedDM.SendEmbedDM(this.EmbedChannelIdTxt.Text, "", this.EmbedTitleTxt.Text, this.EmbedDescTxt.Text, SpamMain._EmbedColor);
            }
            else
            {
              this.StartEmbedSpammer.Text = "Start Spammer";
              int num = (int)MessageBox.Show("You need to choose a Color first\nPress on the Button Choose Color", "Discord Raider");
              this.DmEmbedSpam = false;
            }
          }
          catch
          {
          }
        }
      })).Start();
    }

    private void StartEmbedSpammer_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        if (this.DmSpammer)
        {
          switch (this.StartEmbedSpammer.Text)
          {
            case "Start Spammer":
              this.StartEmbedSpammer.Text = "Stop Spammer";
              this.StartEmbedSpamDM();
              break;
            case "Stop Spammer":
              this.DmEmbedSpam = false;
              this.WinInfo.Visible = true;
              this.WinInfo.BalloonTipText = "DM Embed Spammer stopped!";
              this.WinInfo.ShowBalloonTip(1000);
              this.StartEmbedSpammer.Text = "Start Spammer";
              break;
          }
        }
        else
        {
          switch (this.StartEmbedSpammer.Text)
          {
            case "Start Spammer":
              this.StartEmbedSpammer.Text = "Stop Spammer";
              this.StartChannelEmbedSpam();
              break;
            case "Stop Spammer":
              this.ChannelEmbedSpam = false;
              this.WinInfo.Visible = true;
              this.WinInfo.BalloonTipText = "Channel Embed Spammer stopped!";
              this.WinInfo.ShowBalloonTip(1000);
              this.StartEmbedSpammer.Text = "Start Spammer";
              break;
          }
        }
      }
      else
        this.ShowErrorPage();
    }

    private void RndColorBtn_Click(object sender, EventArgs e)
    {
      if (this.RndColorBtn.BackColor == Color.FromArgb(105, 105, 205))
      {
        this.RndColorBtn.BackColor = Color.FromArgb(33, 34, 38);
        SpamMain._RndmColor = false;
      }
      else
      {
        this.RndColorBtn.BackColor = Color.FromArgb(105, 105, 205);
        SpamMain._RndmColor = true;
      }
    }

    private void EmbedChannelIdTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.EmbedChannelIdTxt.Text == "Channel ID") && !(this.EmbedChannelIdTxt.Text == "User ID"))
        return;
      this.EmbedChannelIdTxt.Text = "";
      this.EmbedChannelIdTxt.ForeColor = Color.White;
    }

    private void EmbedChannelIdTxt_Leave(object sender, EventArgs e)
    {
      if (this.DmSpammer)
      {
        if (!(this.EmbedChannelIdTxt.Text == ""))
          return;
        this.EmbedChannelIdTxt.Text = "User ID";
        this.EmbedChannelIdTxt.ForeColor = Color.Silver;
      }
      else
      {
        if (!(this.EmbedChannelIdTxt.Text == ""))
          return;
        this.EmbedChannelIdTxt.Text = "Channel ID";
        this.EmbedChannelIdTxt.ForeColor = Color.Silver;
      }
    }

    private void EmbedTitleTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.EmbedTitleTxt.Text == "Embed Title"))
        return;
      this.EmbedTitleTxt.Text = "";
      this.EmbedTitleTxt.ForeColor = Color.White;
    }

    private void EmbedTitleTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.EmbedTitleTxt.Text == ""))
        return;
      this.EmbedTitleTxt.Text = "Embed Title";
      this.EmbedTitleTxt.ForeColor = Color.Silver;
    }

    private void EmbedDescTxt_Enter(object sender, EventArgs e)
    {
      if (!(this.EmbedDescTxt.Text == "Embed Description"))
        return;
      this.EmbedDescTxt.Text = "";
      this.EmbedDescTxt.ForeColor = Color.White;
    }

    private void EmbedDescTxt_Leave(object sender, EventArgs e)
    {
      if (!(this.EmbedDescTxt.Text == ""))
        return;
      this.EmbedDescTxt.Text = "Embed Description";
      this.EmbedDescTxt.ForeColor = Color.Silver;
    }

    private void EmbedTypingBtn_Click(object sender, EventArgs e)
    {
      if (this.EmbedTypingBtn.BackColor == Color.FromArgb(105, 105, 205))
      {
        this.EmbedTypingBtn.BackColor = Color.FromArgb(33, 34, 38);
        this._EmbedTyping = false;
      }
      else
      {
        this.EmbedTypingBtn.BackColor = Color.FromArgb(105, 105, 205);
        this._EmbedTyping = true;
      }
    }

    private void TokenSettingsBtn_Click(object sender, EventArgs e)
    {
      if (this.TokenLoaded)
      {
        if (SpamMain._TokenSettings)
          return;
        SpamMain._TokenSettings = true;
        new TokenSettings().Show();
      }
      else
        this.ShowErrorPage();
    }

    private void JoinLbl_MouseEnter(object sender, EventArgs e) => this.JoinLbl.ForeColor = Color.FromArgb(105, 105, 205);

    private void JoinLbl_MouseLeave(object sender, EventArgs e) => this.JoinLbl.ForeColor = Color.White;

    private void EmbedBtn_Click(object sender, EventArgs e)
    {
      if (this.EmbedBtn.BackColor == Color.FromArgb(105, 105, 205))
      {
        this.EmbedBtn.BackColor = Color.FromArgb(33, 34, 38);
        this.EmbedPnl.Visible = false;
        this.SettingsPnl.Visible = true;
        this.EmbedPnl2.Visible = false;
      }
      else
      {
        this.EmbedBtn.BackColor = Color.FromArgb(105, 105, 205);
        this.EmbedPnl.Visible = true;
        this.SettingsPnl.Visible = false;
        this.EmbedPnl2.Visible = true;
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
      this.components = (IContainer)new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SpamMain));
      this.HeadLinePnl = new Panel();
      this.HeadPic = new PictureBox();
      this.ReloadBtn = new Button();
      this.btnClose = new Button();
      this.btnMini = new Button();
      this.panel2 = new Panel();
      this.comboBox1 = new ComboBox();
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.panel3 = new Panel();
      this.panel5 = new Panel();
      this.panel6 = new Panel();
      this.RaiderPnl = new Panel();
      this.panel11 = new Panel();
      this.JoinLeavePnl = new Panel();
      this.panel235 = new Panel();
      this.JoinLeaveLbl = new Label();
      this.InfoLbl = new TextBox();
      this.panel16 = new Panel();
      this.ModsHeadline = new Label();
      this.AddTokensPnl = new Panel();
      this.panel15 = new Panel();
      this.AddTokensLbl = new Label();
      this.FriendPnl = new Panel();
      this.panel13 = new Panel();
      this.FriendLbl = new Label();
      this.ReactorPnl = new Panel();
      this.panel12 = new Panel();
      this.TextReactorLbl = new Label();
      this.SpammingPnl = new Panel();
      this.panel1 = new Panel();
      this.SpammingLbl = new Label();
      this.FunctionPnl = new Panel();
      this.HeadLineFunc = new Panel();
      this.ModsHdlLbl = new TextBox();
      this.panel4 = new Panel();
      this.CloseFuncBtn = new Button();
      this.panel7 = new Panel();
      this.comboBox2 = new ComboBox();
      this.textBox2 = new TextBox();
      this.button2 = new Button();
      this.panel8 = new Panel();
      this.panel9 = new Panel();
      this.panel10 = new Panel();
      this.ModsControl = new TabControl();
      this.ReactPage = new TabPage();
      this.MsgReactPnl = new Panel();
      this.ReactMessageIdTxt = new TextBox();
      this.EmojiReactPnl = new Panel();
      this.ReactEmojiTxt = new TextBox();
      this.panel23 = new Panel();
      this.EmojiBtn = new Button();
      this.ReactIdPnl = new Panel();
      this.ReactChannelIdTxt = new TextBox();
      this.FriendPage = new TabPage();
      this.panel55 = new Panel();
      this.InfosFriendTxt = new TextBox();
      this.RmvPanel = new Panel();
      this.panel52 = new Panel();
      this.RmvUserTxt = new TextBox();
      this.AddPnl = new Panel();
      this.panel54 = new Panel();
      this.AddUserText = new TextBox();
      this.TokensPage = new TabPage();
      this.TokenSettingsBtn = new Button();
      this.panel71 = new Panel();
      this.panel60 = new Panel();
      this.panel59 = new Panel();
      this.panel58 = new Panel();
      this.panel57 = new Panel();
      this.LoadedTokens = new RichTextBox();
      this.InfoAddTokensTxt = new TextBox();
      this.panel56 = new Panel();
      this.TokensPnl = new Panel();
      this.panel53 = new Panel();
      this.TokensTxt = new TextBox();
      this.ErrorPage = new TabPage();
      this.panel83 = new Panel();
      this.ErrorPnl = new Panel();
      this.label6 = new Label();
      this.label14 = new Label();
      this.JoinPage = new TabPage();
      this.panel21 = new Panel();
      this.InfosJoinLeave = new TextBox();
      this.LeaveID = new Panel();
      this.panel27 = new Panel();
      this.panel26 = new Panel();
      this.panel25 = new Panel();
      this.panel24 = new Panel();
      this.panel20 = new Panel();
      this.LeaveServerTxt = new TextBox();
      this.LeaveSettingBtn = new Button();
      this.InvitePnl = new Panel();
      this.panel28 = new Panel();
      this.panel29 = new Panel();
      this.panel30 = new Panel();
      this.panel31 = new Panel();
      this.JoinSettingsBtn = new Button();
      this.panel19 = new Panel();
      this.JoinTxt = new TextBox();
      this.GetInfosBtn = new Button();
      this.SpammingPage = new TabPage();
      this.EmbedPnl = new Panel();
      this.EmbedDescPnl = new Panel();
      this.EmbedDescTxt = new TextBox();
      this.EmbedTitlePnl = new Panel();
      this.EmbedTitleTxt = new TextBox();
      this.EmbedChannelPnl = new Panel();
      this.panel33 = new Panel();
      this.EmbedChannelIdTxt = new TextBox();
      this.EmbedBtn = new Button();
      this.EmbedLbl = new Label();
      this.OpenDMBtn = new Button();
      this.panel38 = new Panel();
      this.ChannelSpPnl = new Panel();
      this.panel18 = new Panel();
      this.ChannelIDTxt = new TextBox();
      this.DmSpammingBtn = new Button();
      this.OpenExtraStuffBtn = new Button();
      this.SpamPnl = new Panel();
      this.MessageSpTxt = new TextBox();
      this.EmbedPnl2 = new Panel();
      this.label17 = new Label();
      this.RndColorBtn = new Button();
      this.label19 = new Label();
      this.EmbedTypingBtn = new Button();
      this.ChooseColorBtn = new Button();
      this.SettingsPnl = new Panel();
      this.label8 = new Label();
      this.TypingBtn = new Button();
      this.label12 = new Label();
      this.label13 = new Label();
      this.UnderlinedBtn = new Button();
      this.BlockTxt = new Button();
      this.panel14 = new Panel();
      this.InfosLbl = new Panel();
      this.JoinLbl = new Label();
      this.label9 = new Label();
      this.label10 = new Label();
      this.label11 = new Label();
      this.label4 = new Label();
      this.label7 = new Label();
      this.label1 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.label5 = new Label();
      this.panel40 = new Panel();
      this.HeadExtraPnl = new Panel();
      this.panel42 = new Panel();
      this.HeadExtraLbl = new Label();
      this.panel43 = new Panel();
      this.comboBox6 = new ComboBox();
      this.textBox9 = new TextBox();
      this.button7 = new Button();
      this.panel44 = new Panel();
      this.panel45 = new Panel();
      this.panel46 = new Panel();
      this.GetEmojiTimer = new System.Windows.Forms.Timer(this.components);
      this.WinInfo = new NotifyIcon(this.components);
      this.pictureBox1 = new PictureBox();
      this.RemoveReactionBtn = new RoundBtn();
      this.AddReactionBtn = new RoundBtn();
      this.RemoveReBtn = new RoundBtn();
      this.SendReBtn = new RoundBtn();
      this.AddTokensBtn = new RoundBtn();
      this.LeaveBtn = new RoundBtn();
      this.JoinServerBtn = new RoundBtn();
      this.StartEmbedSpammer = new RoundBtn();
      this.SpammerBtn = new RoundBtn();
      this.OpenJoinerBtn = new RoundBtn();
      this.OpenTokenAddBtn = new RoundBtn();
      this.OpenFriendBtn = new RoundBtn();
      this.OpenReactorBtn = new RoundBtn();
      this.OpenSpammerBtn = new RoundBtn();
      this.HeadLinePnl.SuspendLayout();
      ((ISupportInitialize)this.HeadPic).BeginInit();
      this.RaiderPnl.SuspendLayout();
      this.JoinLeavePnl.SuspendLayout();
      this.AddTokensPnl.SuspendLayout();
      this.FriendPnl.SuspendLayout();
      this.ReactorPnl.SuspendLayout();
      this.SpammingPnl.SuspendLayout();
      this.FunctionPnl.SuspendLayout();
      this.HeadLineFunc.SuspendLayout();
      this.ModsControl.SuspendLayout();
      this.ReactPage.SuspendLayout();
      this.MsgReactPnl.SuspendLayout();
      this.EmojiReactPnl.SuspendLayout();
      this.ReactIdPnl.SuspendLayout();
      this.FriendPage.SuspendLayout();
      this.RmvPanel.SuspendLayout();
      this.AddPnl.SuspendLayout();
      this.TokensPage.SuspendLayout();
      this.TokensPnl.SuspendLayout();
      this.ErrorPage.SuspendLayout();
      this.ErrorPnl.SuspendLayout();
      this.JoinPage.SuspendLayout();
      this.LeaveID.SuspendLayout();
      this.InvitePnl.SuspendLayout();
      this.SpammingPage.SuspendLayout();
      this.EmbedPnl.SuspendLayout();
      this.EmbedDescPnl.SuspendLayout();
      this.EmbedTitlePnl.SuspendLayout();
      this.EmbedChannelPnl.SuspendLayout();
      this.ChannelSpPnl.SuspendLayout();
      this.SpamPnl.SuspendLayout();
      this.EmbedPnl2.SuspendLayout();
      this.SettingsPnl.SuspendLayout();
      this.InfosLbl.SuspendLayout();
      this.HeadExtraPnl.SuspendLayout();
      ((ISupportInitialize)this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.HeadLinePnl.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLinePnl.Controls.Add((Control)this.HeadPic);
      this.HeadLinePnl.Controls.Add((Control)this.ReloadBtn);
      this.HeadLinePnl.Controls.Add((Control)this.btnClose);
      this.HeadLinePnl.Controls.Add((Control)this.btnMini);
      this.HeadLinePnl.Controls.Add((Control)this.panel2);
      this.HeadLinePnl.Controls.Add((Control)this.comboBox1);
      this.HeadLinePnl.Controls.Add((Control)this.textBox1);
      this.HeadLinePnl.Controls.Add((Control)this.button1);
      this.HeadLinePnl.Controls.Add((Control)this.panel3);
      this.HeadLinePnl.Controls.Add((Control)this.panel5);
      this.HeadLinePnl.Controls.Add((Control)this.panel6);
      this.HeadLinePnl.Dock = DockStyle.Top;
      this.HeadLinePnl.Location = new Point(0, 0);
      this.HeadLinePnl.Name = "HeadLinePnl";
      this.HeadLinePnl.Size = new Size(509, 21);
      this.HeadLinePnl.TabIndex = 6229;
      this.HeadLinePnl.MouseDown += new MouseEventHandler(this.HeadLinePnl_MouseDown);
      this.HeadLinePnl.MouseMove += new MouseEventHandler(this.HeadLinePnl_MouseMove);
      this.HeadPic.Image = (Image)Resources.DiscordRaider;
      this.HeadPic.Location = new Point(4, 1);
      this.HeadPic.Name = "HeadPic";
      this.HeadPic.Size = new Size(106, 19);
      this.HeadPic.SizeMode = PictureBoxSizeMode.Zoom;
      this.HeadPic.TabIndex = 6190;
      this.HeadPic.TabStop = false;
      this.HeadPic.MouseDown += new MouseEventHandler(this.HeadPic_MouseDown);
      this.HeadPic.MouseMove += new MouseEventHandler(this.HeadPic_MouseMove);
      this.ReloadBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.ReloadBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.ReloadBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.ReloadBtn.FlatAppearance.BorderSize = 0;
      this.ReloadBtn.FlatStyle = FlatStyle.Flat;
      this.ReloadBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.ReloadBtn.ForeColor = Color.White;
      this.ReloadBtn.Location = new Point(433, -2);
      this.ReloadBtn.Name = "ReloadBtn";
      this.ReloadBtn.Size = new Size(26, 27);
      this.ReloadBtn.TabIndex = 6165;
      this.ReloadBtn.Text = "q";
      this.ReloadBtn.TextAlign = ContentAlignment.TopCenter;
      this.ReloadBtn.UseVisualStyleBackColor = false;
      this.ReloadBtn.Click += new EventHandler(this.ReloadBtn_Click);
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnClose.BackColor = Color.FromArgb(33, 34, 38);
      this.btnClose.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.btnClose.FlatAppearance.BorderSize = 0;
      this.btnClose.FlatStyle = FlatStyle.Flat;
      this.btnClose.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.btnClose.ForeColor = Color.White;
      this.btnClose.Location = new Point(484, -3);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(26, 27);
      this.btnClose.TabIndex = 6162;
      this.btnClose.Text = "r";
      this.btnClose.TextAlign = ContentAlignment.TopCenter;
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new EventHandler(this.BtnClose_Click);
      this.btnClose.MouseEnter += new EventHandler(this.BtnClose_MouseEnter);
      this.btnClose.MouseLeave += new EventHandler(this.BtnClose_MouseLeave);
      this.btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnMini.BackColor = Color.FromArgb(33, 34, 38);
      this.btnMini.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.btnMini.FlatAppearance.BorderSize = 0;
      this.btnMini.FlatStyle = FlatStyle.Flat;
      this.btnMini.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.btnMini.ForeColor = Color.White;
      this.btnMini.Location = new Point(458, -3);
      this.btnMini.Name = "btnMini";
      this.btnMini.Size = new Size(26, 27);
      this.btnMini.TabIndex = 6161;
      this.btnMini.Text = "0";
      this.btnMini.TextAlign = ContentAlignment.TopCenter;
      this.btnMini.UseVisualStyleBackColor = false;
      this.btnMini.Click += new EventHandler(this.BtnMini_Click);
      this.panel2.BackColor = Color.FromArgb(51, 51, 51);
      this.panel2.Font = new Font("Segoe UI", 9f);
      this.panel2.Location = new Point(362, -44);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(2, 25);
      this.panel2.TabIndex = 6160;
      this.comboBox1.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox1.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox1.ForeColor = Color.Silver;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(364, -44);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(254, 25);
      this.comboBox1.TabIndex = 6154;
      this.textBox1.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.textBox1.ForeColor = Color.White;
      this.textBox1.Location = new Point(364, -42);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(231, 21);
      this.textBox1.TabIndex = 6156;
      this.textBox1.Text = " Voice Channel";
      this.button1.BackColor = Color.FromArgb(25, 25, 25);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
      this.button1.ForeColor = Color.Silver;
      this.button1.Location = new Point(594, -43);
      this.button1.Name = "button1";
      this.button1.Size = new Size(25, 22);
      this.button1.TabIndex = 6155;
      this.button1.Text = "6";
      this.button1.UseVisualStyleBackColor = false;
      this.panel3.BackColor = Color.FromArgb(51, 51, 51);
      this.panel3.Font = new Font("Segoe UI", 9f);
      this.panel3.Location = new Point(364, -21);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(254, 2);
      this.panel3.TabIndex = 6157;
      this.panel5.BackColor = Color.FromArgb(51, 51, 51);
      this.panel5.Font = new Font("Segoe UI", 9f);
      this.panel5.Location = new Point(364, -44);
      this.panel5.Name = "panel5";
      this.panel5.Size = new Size(254, 2);
      this.panel5.TabIndex = 6158;
      this.panel6.BackColor = Color.FromArgb(51, 51, 51);
      this.panel6.Font = new Font("Segoe UI", 9f);
      this.panel6.Location = new Point(617, -44);
      this.panel6.Name = "panel6";
      this.panel6.Size = new Size(2, 25);
      this.panel6.TabIndex = 6159;
      this.RaiderPnl.BackColor = Color.FromArgb(33, 34, 38);
      this.RaiderPnl.Controls.Add((Control)this.panel11);
      this.RaiderPnl.Controls.Add((Control)this.JoinLeavePnl);
      this.RaiderPnl.Controls.Add((Control)this.InfoLbl);
      this.RaiderPnl.Controls.Add((Control)this.panel16);
      this.RaiderPnl.Controls.Add((Control)this.ModsHeadline);
      this.RaiderPnl.Controls.Add((Control)this.AddTokensPnl);
      this.RaiderPnl.Controls.Add((Control)this.FriendPnl);
      this.RaiderPnl.Controls.Add((Control)this.ReactorPnl);
      this.RaiderPnl.Controls.Add((Control)this.SpammingPnl);
      this.RaiderPnl.Location = new Point(10, 32);
      this.RaiderPnl.Name = "RaiderPnl";
      this.RaiderPnl.Size = new Size(279, 295);
      this.RaiderPnl.TabIndex = 6296;
      this.panel11.BackColor = Color.FromArgb(51, 51, 51);
      this.panel11.Location = new Point(16, 28);
      this.panel11.Name = "panel11";
      this.panel11.Size = new Size(249, 2);
      this.panel11.TabIndex = 6220;
      this.JoinLeavePnl.BackColor = Color.FromArgb(49, 50, 55);
      this.JoinLeavePnl.Controls.Add((Control)this.panel235);
      this.JoinLeavePnl.Controls.Add((Control)this.JoinLeaveLbl);
      this.JoinLeavePnl.Controls.Add((Control)this.OpenJoinerBtn);
      this.JoinLeavePnl.Location = new Point(16, 42);
      this.JoinLeavePnl.Name = "JoinLeavePnl";
      this.JoinLeavePnl.Size = new Size(249, 36);
      this.JoinLeavePnl.TabIndex = 6167;
      this.JoinLeavePnl.MouseEnter += new EventHandler(this.JoinLeavePnl_MouseEnter);
      this.JoinLeavePnl.MouseLeave += new EventHandler(this.JoinLeavePnl_MouseLeave);
      this.panel235.BackColor = Color.FromArgb(56, 56, 56);
      this.panel235.Location = new Point(153, 0);
      this.panel235.Name = "panel235";
      this.panel235.Size = new Size(3, 148);
      this.panel235.TabIndex = 6276;
      this.JoinLeaveLbl.AutoSize = true;
      this.JoinLeaveLbl.Font = new Font("Impact", 11.25f);
      this.JoinLeaveLbl.ForeColor = Color.Silver;
      this.JoinLeaveLbl.Location = new Point(9, 8);
      this.JoinLeaveLbl.Name = "JoinLeaveLbl";
      this.JoinLeaveLbl.Size = new Size(99, 19);
      this.JoinLeaveLbl.TabIndex = 6275;
      this.JoinLeaveLbl.Text = "Joiner | Leaver";
      this.JoinLeaveLbl.MouseEnter += new EventHandler(this.JoinLeaveLbl_MouseEnter);
      this.JoinLeaveLbl.MouseLeave += new EventHandler(this.JoinLeaveLbl_MouseLeave);
      this.InfoLbl.BackColor = Color.FromArgb(33, 34, 38);
      this.InfoLbl.BorderStyle = BorderStyle.None;
      this.InfoLbl.Enabled = false;
      this.InfoLbl.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfoLbl.ForeColor = Color.Silver;
      this.InfoLbl.Location = new Point(3, 275);
      this.InfoLbl.Name = "InfoLbl";
      this.InfoLbl.Size = new Size(273, 16);
      this.InfoLbl.TabIndex = 6219;
      this.InfoLbl.Text = "[info]";
      this.InfoLbl.TextAlign = HorizontalAlignment.Center;
      this.panel16.BackColor = Color.FromArgb(51, 51, 51);
      this.panel16.Location = new Point(0, 270);
      this.panel16.Name = "panel16";
      this.panel16.Size = new Size(278, 2);
      this.panel16.TabIndex = 6173;
      this.ModsHeadline.AutoSize = true;
      this.ModsHeadline.Font = new Font("Myanmar Text", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ModsHeadline.ForeColor = Color.White;
      this.ModsHeadline.Location = new Point(48, 4);
      this.ModsHeadline.Name = "ModsHeadline";
      this.ModsHeadline.Size = new Size(177, 29);
      this.ModsHeadline.TabIndex = 6165;
      this.ModsHeadline.Text = "CHOOSE YOUR MODS";
      this.AddTokensPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.AddTokensPnl.Controls.Add((Control)this.OpenTokenAddBtn);
      this.AddTokensPnl.Controls.Add((Control)this.panel15);
      this.AddTokensPnl.Controls.Add((Control)this.AddTokensLbl);
      this.AddTokensPnl.Location = new Point(16, 222);
      this.AddTokensPnl.Name = "AddTokensPnl";
      this.AddTokensPnl.Size = new Size(249, 36);
      this.AddTokensPnl.TabIndex = 6172;
      this.AddTokensPnl.MouseEnter += new EventHandler(this.AddTokensPnl_MouseEnter);
      this.AddTokensPnl.MouseLeave += new EventHandler(this.AddTokensPnl_MouseLeave);
      this.panel15.BackColor = Color.FromArgb(56, 56, 56);
      this.panel15.Location = new Point(153, 0);
      this.panel15.Name = "panel15";
      this.panel15.Size = new Size(3, 148);
      this.panel15.TabIndex = 6277;
      this.AddTokensLbl.AutoSize = true;
      this.AddTokensLbl.Font = new Font("Impact", 11.25f);
      this.AddTokensLbl.ForeColor = Color.Silver;
      this.AddTokensLbl.Location = new Point(9, 8);
      this.AddTokensLbl.Name = "AddTokensLbl";
      this.AddTokensLbl.Size = new Size(80, 19);
      this.AddTokensLbl.TabIndex = 6276;
      this.AddTokensLbl.Text = "ADD TOKENS";
      this.AddTokensLbl.MouseEnter += new EventHandler(this.AddTokensLbl_MouseEnter);
      this.AddTokensLbl.MouseLeave += new EventHandler(this.AddTokensLbl_MouseLeave);
      this.FriendPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.FriendPnl.Controls.Add((Control)this.OpenFriendBtn);
      this.FriendPnl.Controls.Add((Control)this.panel13);
      this.FriendPnl.Controls.Add((Control)this.FriendLbl);
      this.FriendPnl.Location = new Point(16, 177);
      this.FriendPnl.Name = "FriendPnl";
      this.FriendPnl.Size = new Size(249, 36);
      this.FriendPnl.TabIndex = 6170;
      this.FriendPnl.MouseEnter += new EventHandler(this.FriendPnl_MouseEnter);
      this.FriendPnl.MouseLeave += new EventHandler(this.FriendPnl_MouseLeave);
      this.panel13.BackColor = Color.FromArgb(56, 56, 56);
      this.panel13.Location = new Point(153, 0);
      this.panel13.Name = "panel13";
      this.panel13.Size = new Size(3, 148);
      this.panel13.TabIndex = 6277;
      this.FriendLbl.AutoSize = true;
      this.FriendLbl.Font = new Font("Impact", 11.25f);
      this.FriendLbl.ForeColor = Color.Silver;
      this.FriendLbl.Location = new Point(9, 8);
      this.FriendLbl.Name = "FriendLbl";
      this.FriendLbl.Size = new Size(87, 19);
      this.FriendLbl.TabIndex = 6276;
      this.FriendLbl.Text = "FRIEND STUFF";
      this.FriendLbl.MouseEnter += new EventHandler(this.FriendLbl_MouseEnter);
      this.FriendLbl.MouseLeave += new EventHandler(this.FriendLbl_MouseLeave);
      this.ReactorPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.ReactorPnl.Controls.Add((Control)this.OpenReactorBtn);
      this.ReactorPnl.Controls.Add((Control)this.panel12);
      this.ReactorPnl.Controls.Add((Control)this.TextReactorLbl);
      this.ReactorPnl.Location = new Point(16, 132);
      this.ReactorPnl.Name = "ReactorPnl";
      this.ReactorPnl.Size = new Size(249, 36);
      this.ReactorPnl.TabIndex = 6169;
      this.ReactorPnl.MouseEnter += new EventHandler(this.ReactorPnl_MouseEnter);
      this.ReactorPnl.MouseLeave += new EventHandler(this.ReactorPnl_MouseLeave);
      this.panel12.BackColor = Color.FromArgb(56, 56, 56);
      this.panel12.Location = new Point(153, 0);
      this.panel12.Name = "panel12";
      this.panel12.Size = new Size(3, 148);
      this.panel12.TabIndex = 6277;
      this.TextReactorLbl.AutoSize = true;
      this.TextReactorLbl.Font = new Font("Impact", 11.25f);
      this.TextReactorLbl.ForeColor = Color.Silver;
      this.TextReactorLbl.Location = new Point(9, 8);
      this.TextReactorLbl.Name = "TextReactorLbl";
      this.TextReactorLbl.Size = new Size(91, 19);
      this.TextReactorLbl.TabIndex = 6276;
      this.TextReactorLbl.Text = "TEXT REACTOR";
      this.TextReactorLbl.MouseEnter += new EventHandler(this.TextReactorLbl_MouseEnter);
      this.TextReactorLbl.MouseLeave += new EventHandler(this.TextReactorLbl_MouseLeave);
      this.SpammingPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.SpammingPnl.Controls.Add((Control)this.OpenSpammerBtn);
      this.SpammingPnl.Controls.Add((Control)this.panel1);
      this.SpammingPnl.Controls.Add((Control)this.SpammingLbl);
      this.SpammingPnl.Location = new Point(16, 87);
      this.SpammingPnl.Name = "SpammingPnl";
      this.SpammingPnl.Size = new Size(249, 36);
      this.SpammingPnl.TabIndex = 6168;
      this.SpammingPnl.MouseEnter += new EventHandler(this.SpammingPnl_MouseEnter);
      this.SpammingPnl.MouseLeave += new EventHandler(this.SpammingPnl_MouseLeave);
      this.panel1.BackColor = Color.FromArgb(56, 56, 56);
      this.panel1.Location = new Point(153, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(3, 148);
      this.panel1.TabIndex = 6277;
      this.SpammingLbl.AutoSize = true;
      this.SpammingLbl.Font = new Font("Impact", 11.25f);
      this.SpammingLbl.ForeColor = Color.Silver;
      this.SpammingLbl.Location = new Point(9, 8);
      this.SpammingLbl.Name = "SpammingLbl";
      this.SpammingLbl.Size = new Size(112, 19);
      this.SpammingLbl.TabIndex = 6276;
      this.SpammingLbl.Text = "SPAMMING STUFF";
      this.SpammingLbl.MouseEnter += new EventHandler(this.SpammingLbl_MouseEnter);
      this.SpammingLbl.MouseLeave += new EventHandler(this.SpammingLbl_MouseLeave);
      this.FunctionPnl.BackColor = Color.FromArgb(33, 34, 38);
      this.FunctionPnl.Controls.Add((Control)this.HeadLineFunc);
      this.FunctionPnl.Controls.Add((Control)this.ModsControl);
      this.FunctionPnl.Location = new Point(12, 32);
      this.FunctionPnl.Name = "FunctionPnl";
      this.FunctionPnl.Size = new Size(450, 196);
      this.FunctionPnl.TabIndex = 6299;
      this.FunctionPnl.Visible = false;
      this.HeadLineFunc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.HeadLineFunc.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadLineFunc.Controls.Add((Control)this.ModsHdlLbl);
      this.HeadLineFunc.Controls.Add((Control)this.panel4);
      this.HeadLineFunc.Controls.Add((Control)this.CloseFuncBtn);
      this.HeadLineFunc.Controls.Add((Control)this.panel7);
      this.HeadLineFunc.Controls.Add((Control)this.comboBox2);
      this.HeadLineFunc.Controls.Add((Control)this.textBox2);
      this.HeadLineFunc.Controls.Add((Control)this.button2);
      this.HeadLineFunc.Controls.Add((Control)this.panel8);
      this.HeadLineFunc.Controls.Add((Control)this.panel9);
      this.HeadLineFunc.Controls.Add((Control)this.panel10);
      this.HeadLineFunc.Location = new Point(0, 0);
      this.HeadLineFunc.Name = "HeadLineFunc";
      this.HeadLineFunc.Size = new Size(450, 29);
      this.HeadLineFunc.TabIndex = 6282;
      this.ModsHdlLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.ModsHdlLbl.BackColor = Color.FromArgb(33, 34, 38);
      this.ModsHdlLbl.BorderStyle = BorderStyle.None;
      this.ModsHdlLbl.Enabled = false;
      this.ModsHdlLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold);
      this.ModsHdlLbl.ForeColor = Color.White;
      this.ModsHdlLbl.Location = new Point(32, 4);
      this.ModsHdlLbl.Name = "ModsHdlLbl";
      this.ModsHdlLbl.Size = new Size(382, 21);
      this.ModsHdlLbl.TabIndex = 6223;
      this.ModsHdlLbl.Text = "Headline";
      this.ModsHdlLbl.TextAlign = HorizontalAlignment.Center;
      this.panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.panel4.BackColor = Color.FromArgb(51, 51, 51);
      this.panel4.Location = new Point(14, 26);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(424, 2);
      this.panel4.TabIndex = 6222;
      this.CloseFuncBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.CloseFuncBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.CloseFuncBtn.FlatAppearance.BorderColor = Color.FromArgb(51, 110, 123);
      this.CloseFuncBtn.FlatAppearance.BorderSize = 0;
      this.CloseFuncBtn.FlatStyle = FlatStyle.Flat;
      this.CloseFuncBtn.Font = new Font("Webdings", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)2);
      this.CloseFuncBtn.ForeColor = Color.White;
      this.CloseFuncBtn.Location = new Point(424, -1);
      this.CloseFuncBtn.Name = "CloseFuncBtn";
      this.CloseFuncBtn.Size = new Size(26, 25);
      this.CloseFuncBtn.TabIndex = 6167;
      this.CloseFuncBtn.Text = "r";
      this.CloseFuncBtn.TextAlign = ContentAlignment.TopCenter;
      this.CloseFuncBtn.UseVisualStyleBackColor = false;
      this.CloseFuncBtn.Click += new EventHandler(this.CloseFuncBtn_Click);
      this.panel7.BackColor = Color.FromArgb(51, 51, 51);
      this.panel7.Font = new Font("Segoe UI", 9f);
      this.panel7.Location = new Point(362, -44);
      this.panel7.Name = "panel7";
      this.panel7.Size = new Size(2, 25);
      this.panel7.TabIndex = 6160;
      this.comboBox2.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox2.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox2.ForeColor = Color.Silver;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new Point(364, -44);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new Size(254, 25);
      this.comboBox2.TabIndex = 6154;
      this.textBox2.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox2.BorderStyle = BorderStyle.None;
      this.textBox2.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.textBox2.ForeColor = Color.White;
      this.textBox2.Location = new Point(364, -42);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(231, 21);
      this.textBox2.TabIndex = 6156;
      this.textBox2.Text = " Voice Channel";
      this.button2.BackColor = Color.FromArgb(25, 25, 25);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
      this.button2.ForeColor = Color.Silver;
      this.button2.Location = new Point(594, -43);
      this.button2.Name = "button2";
      this.button2.Size = new Size(25, 22);
      this.button2.TabIndex = 6155;
      this.button2.Text = "6";
      this.button2.UseVisualStyleBackColor = false;
      this.panel8.BackColor = Color.FromArgb(51, 51, 51);
      this.panel8.Font = new Font("Segoe UI", 9f);
      this.panel8.Location = new Point(364, -21);
      this.panel8.Name = "panel8";
      this.panel8.Size = new Size(254, 2);
      this.panel8.TabIndex = 6157;
      this.panel9.BackColor = Color.FromArgb(51, 51, 51);
      this.panel9.Font = new Font("Segoe UI", 9f);
      this.panel9.Location = new Point(364, -44);
      this.panel9.Name = "panel9";
      this.panel9.Size = new Size(254, 2);
      this.panel9.TabIndex = 6158;
      this.panel10.BackColor = Color.FromArgb(51, 51, 51);
      this.panel10.Font = new Font("Segoe UI", 9f);
      this.panel10.Location = new Point(617, -44);
      this.panel10.Name = "panel10";
      this.panel10.Size = new Size(2, 25);
      this.panel10.TabIndex = 6159;
      this.ModsControl.Controls.Add((Control)this.ReactPage);
      this.ModsControl.Controls.Add((Control)this.FriendPage);
      this.ModsControl.Controls.Add((Control)this.TokensPage);
      this.ModsControl.Controls.Add((Control)this.ErrorPage);
      this.ModsControl.Controls.Add((Control)this.JoinPage);
      this.ModsControl.Controls.Add((Control)this.SpammingPage);
      this.ModsControl.Location = new Point(-14, 2);
      this.ModsControl.Name = "ModsControl";
      this.ModsControl.SelectedIndex = 0;
      this.ModsControl.Size = new Size(480, 336);
      this.ModsControl.TabIndex = 0;
      this.ReactPage.BackColor = Color.FromArgb(33, 34, 38);
      this.ReactPage.Controls.Add((Control)this.RemoveReactionBtn);
      this.ReactPage.Controls.Add((Control)this.AddReactionBtn);
      this.ReactPage.Controls.Add((Control)this.MsgReactPnl);
      this.ReactPage.Controls.Add((Control)this.EmojiReactPnl);
      this.ReactPage.Controls.Add((Control)this.panel23);
      this.ReactPage.Controls.Add((Control)this.EmojiBtn);
      this.ReactPage.Controls.Add((Control)this.ReactIdPnl);
      this.ReactPage.Location = new Point(4, 22);
      this.ReactPage.Name = "ReactPage";
      this.ReactPage.Size = new Size(472, 310);
      this.ReactPage.TabIndex = 2;
      this.ReactPage.Text = "Reactor";
      this.MsgReactPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.MsgReactPnl.Controls.Add((Control)this.ReactMessageIdTxt);
      this.MsgReactPnl.Location = new Point(200, 14);
      this.MsgReactPnl.Name = "MsgReactPnl";
      this.MsgReactPnl.Size = new Size(174, 32);
      this.MsgReactPnl.TabIndex = 6232;
      this.ReactMessageIdTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.ReactMessageIdTxt.BorderStyle = BorderStyle.None;
      this.ReactMessageIdTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ReactMessageIdTxt.ForeColor = Color.DarkGray;
      this.ReactMessageIdTxt.Location = new Point(8, 7);
      this.ReactMessageIdTxt.Name = "ReactMessageIdTxt";
      this.ReactMessageIdTxt.Size = new Size(159, 18);
      this.ReactMessageIdTxt.TabIndex = 6155;
      this.ReactMessageIdTxt.Text = "Message ID";
      this.ReactMessageIdTxt.Enter += new EventHandler(this.ReactMessageIdTxt_Enter);
      this.ReactMessageIdTxt.Leave += new EventHandler(this.ReactMessageIdTxt_Leave);
      this.EmojiReactPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.EmojiReactPnl.Controls.Add((Control)this.ReactEmojiTxt);
      this.EmojiReactPnl.Location = new Point(20, 53);
      this.EmojiReactPnl.Name = "EmojiReactPnl";
      this.EmojiReactPnl.Size = new Size(354, 32);
      this.EmojiReactPnl.TabIndex = 6231;
      this.ReactEmojiTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.ReactEmojiTxt.BorderStyle = BorderStyle.None;
      this.ReactEmojiTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ReactEmojiTxt.ForeColor = Color.DarkGray;
      this.ReactEmojiTxt.Location = new Point(8, 7);
      this.ReactEmojiTxt.Name = "ReactEmojiTxt";
      this.ReactEmojiTxt.Size = new Size(339, 18);
      this.ReactEmojiTxt.TabIndex = 6157;
      this.ReactEmojiTxt.Text = "Reaction Emoji";
      this.ReactEmojiTxt.Enter += new EventHandler(this.ReactEmojiTxt_Enter);
      this.ReactEmojiTxt.Leave += new EventHandler(this.ReactEmojiTxt_Leave);
      this.panel23.BackColor = Color.FromArgb(51, 51, 51);
      this.panel23.Location = new Point(11, (int)sbyte.MaxValue);
      this.panel23.Name = "panel23";
      this.panel23.Size = new Size(387, 2);
      this.panel23.TabIndex = 6229;
      this.EmojiBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.EmojiBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmojiBtn.FlatAppearance.BorderSize = 0;
      this.EmojiBtn.FlatStyle = FlatStyle.Flat;
      this.EmojiBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.EmojiBtn.ForeColor = Color.Silver;
      this.EmojiBtn.Location = new Point(249, 130);
      this.EmojiBtn.Name = "EmojiBtn";
      this.EmojiBtn.Size = new Size(134, 22);
      this.EmojiBtn.TabIndex = 6228;
      this.EmojiBtn.Text = "Open Emojis List";
      this.EmojiBtn.UseVisualStyleBackColor = false;
      this.EmojiBtn.Click += new EventHandler(this.EmojiBtn_Click);
      this.ReactIdPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.ReactIdPnl.Controls.Add((Control)this.ReactChannelIdTxt);
      this.ReactIdPnl.Location = new Point(20, 14);
      this.ReactIdPnl.Name = "ReactIdPnl";
      this.ReactIdPnl.Size = new Size(174, 32);
      this.ReactIdPnl.TabIndex = 6226;
      this.ReactChannelIdTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.ReactChannelIdTxt.BorderStyle = BorderStyle.None;
      this.ReactChannelIdTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ReactChannelIdTxt.ForeColor = Color.DarkGray;
      this.ReactChannelIdTxt.Location = new Point(8, 7);
      this.ReactChannelIdTxt.Name = "ReactChannelIdTxt";
      this.ReactChannelIdTxt.Size = new Size(159, 18);
      this.ReactChannelIdTxt.TabIndex = 6154;
      this.ReactChannelIdTxt.Text = "Channel ID";
      this.ReactChannelIdTxt.Enter += new EventHandler(this.ReactChannelIdTxt_Enter);
      this.ReactChannelIdTxt.Leave += new EventHandler(this.ReactChannelIdTxt_Leave);
      this.FriendPage.BackColor = Color.FromArgb(33, 34, 38);
      this.FriendPage.Controls.Add((Control)this.panel55);
      this.FriendPage.Controls.Add((Control)this.InfosFriendTxt);
      this.FriendPage.Controls.Add((Control)this.RmvPanel);
      this.FriendPage.Controls.Add((Control)this.AddPnl);
      this.FriendPage.Location = new Point(4, 22);
      this.FriendPage.Name = "FriendPage";
      this.FriendPage.Size = new Size(472, 310);
      this.FriendPage.TabIndex = 3;
      this.FriendPage.Text = "FriendStuff";
      this.panel55.BackColor = Color.FromArgb(51, 51, 51);
      this.panel55.Location = new Point(10, 95);
      this.panel55.Name = "panel55";
      this.panel55.Size = new Size(387, 2);
      this.panel55.TabIndex = 6223;
      this.InfosFriendTxt.BackColor = Color.FromArgb(33, 34, 38);
      this.InfosFriendTxt.BorderStyle = BorderStyle.None;
      this.InfosFriendTxt.Enabled = false;
      this.InfosFriendTxt.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfosFriendTxt.ForeColor = Color.Silver;
      this.InfosFriendTxt.Location = new Point(18, 100);
      this.InfosFriendTxt.Name = "InfosFriendTxt";
      this.InfosFriendTxt.Size = new Size(353, 16);
      this.InfosFriendTxt.TabIndex = 6222;
      this.InfosFriendTxt.Text = "[info]";
      this.RmvPanel.BackColor = Color.FromArgb(49, 50, 55);
      this.RmvPanel.Controls.Add((Control)this.panel52);
      this.RmvPanel.Controls.Add((Control)this.RmvUserTxt);
      this.RmvPanel.Controls.Add((Control)this.RemoveReBtn);
      this.RmvPanel.Location = new Point(24, 53);
      this.RmvPanel.Name = "RmvPanel";
      this.RmvPanel.Size = new Size(347, 32);
      this.RmvPanel.TabIndex = 6171;
      this.panel52.BackColor = Color.FromArgb(56, 56, 56);
      this.panel52.Location = new Point(219, -60);
      this.panel52.Name = "panel52";
      this.panel52.Size = new Size(3, 148);
      this.panel52.TabIndex = 6277;
      this.RmvUserTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.RmvUserTxt.BorderStyle = BorderStyle.None;
      this.RmvUserTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.RmvUserTxt.ForeColor = Color.DarkGray;
      this.RmvUserTxt.Location = new Point(6, 7);
      this.RmvUserTxt.Name = "RmvUserTxt";
      this.RmvUserTxt.Size = new Size(207, 18);
      this.RmvUserTxt.TabIndex = 6153;
      this.RmvUserTxt.Text = "User ID";
      this.RmvUserTxt.Enter += new EventHandler(this.RmvUserTxt_Enter);
      this.RmvUserTxt.Leave += new EventHandler(this.RmvUserTxt_Leave);
      this.RmvUserTxt.MouseEnter += new EventHandler(this.RmvUserTxt_MouseEnter);
      this.AddPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.AddPnl.Controls.Add((Control)this.SendReBtn);
      this.AddPnl.Controls.Add((Control)this.panel54);
      this.AddPnl.Controls.Add((Control)this.AddUserText);
      this.AddPnl.Location = new Point(24, 11);
      this.AddPnl.Name = "AddPnl";
      this.AddPnl.Size = new Size(347, 32);
      this.AddPnl.TabIndex = 6170;
      this.panel54.BackColor = Color.FromArgb(56, 56, 56);
      this.panel54.Location = new Point(227, -60);
      this.panel54.Name = "panel54";
      this.panel54.Size = new Size(3, 148);
      this.panel54.TabIndex = 6277;
      this.AddUserText.BackColor = Color.FromArgb(49, 50, 55);
      this.AddUserText.BorderStyle = BorderStyle.None;
      this.AddUserText.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.AddUserText.ForeColor = Color.DarkGray;
      this.AddUserText.Location = new Point(5, 7);
      this.AddUserText.Name = "AddUserText";
      this.AddUserText.Size = new Size(216, 18);
      this.AddUserText.TabIndex = 6153;
      this.AddUserText.Text = "Name + Hashtag";
      this.AddUserText.Enter += new EventHandler(this.AddUserText_Enter);
      this.AddUserText.Leave += new EventHandler(this.AddUserText_Leave);
      this.AddUserText.MouseEnter += new EventHandler(this.AddUserText_MouseEnter);
      this.TokensPage.BackColor = Color.FromArgb(33, 34, 38);
      this.TokensPage.Controls.Add((Control)this.TokenSettingsBtn);
      this.TokensPage.Controls.Add((Control)this.panel71);
      this.TokensPage.Controls.Add((Control)this.panel60);
      this.TokensPage.Controls.Add((Control)this.panel59);
      this.TokensPage.Controls.Add((Control)this.panel58);
      this.TokensPage.Controls.Add((Control)this.panel57);
      this.TokensPage.Controls.Add((Control)this.LoadedTokens);
      this.TokensPage.Controls.Add((Control)this.InfoAddTokensTxt);
      this.TokensPage.Controls.Add((Control)this.panel56);
      this.TokensPage.Controls.Add((Control)this.TokensPnl);
      this.TokensPage.Location = new Point(4, 22);
      this.TokensPage.Name = "TokensPage";
      this.TokensPage.Size = new Size(472, 310);
      this.TokensPage.TabIndex = 5;
      this.TokensPage.Text = "AddToken";
      this.TokenSettingsBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.TokenSettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.TokenSettingsBtn.FlatAppearance.BorderSize = 0;
      this.TokenSettingsBtn.FlatStyle = FlatStyle.Flat;
      this.TokenSettingsBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.TokenSettingsBtn.ForeColor = Color.Silver;
      this.TokenSettingsBtn.Location = new Point(326, 130);
      this.TokenSettingsBtn.Name = "TokenSettingsBtn";
      this.TokenSettingsBtn.Size = new Size(134, 22);
      this.TokenSettingsBtn.TabIndex = 6288;
      this.TokenSettingsBtn.Text = "Token Settings";
      this.TokenSettingsBtn.UseVisualStyleBackColor = false;
      this.TokenSettingsBtn.Click += new EventHandler(this.TokenSettingsBtn_Click);
      this.panel71.BackColor = Color.FromArgb(33, 34, 38);
      this.panel71.Location = new Point(445, 51);
      this.panel71.Name = "panel71";
      this.panel71.Size = new Size(31, 71);
      this.panel71.TabIndex = 6287;
      this.panel60.BackColor = Color.FromArgb(56, 56, 56);
      this.panel60.Location = new Point(23, 54);
      this.panel60.Name = "panel60";
      this.panel60.Size = new Size(422, 2);
      this.panel60.TabIndex = 6286;
      this.panel59.BackColor = Color.FromArgb(56, 56, 56);
      this.panel59.Location = new Point(23, 116);
      this.panel59.Name = "panel59";
      this.panel59.Size = new Size(422, 2);
      this.panel59.TabIndex = 6285;
      this.panel58.BackColor = Color.FromArgb(56, 56, 56);
      this.panel58.Location = new Point(23, 56);
      this.panel58.Name = "panel58";
      this.panel58.Size = new Size(2, 60);
      this.panel58.TabIndex = 6284;
      this.panel57.BackColor = Color.FromArgb(56, 56, 56);
      this.panel57.Location = new Point(443, 56);
      this.panel57.Name = "panel57";
      this.panel57.Size = new Size(2, 60);
      this.panel57.TabIndex = 6283;
      this.LoadedTokens.BackColor = Color.FromArgb(33, 34, 38);
      this.LoadedTokens.BorderStyle = BorderStyle.None;
      this.LoadedTokens.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.LoadedTokens.ForeColor = Color.Silver;
      this.LoadedTokens.HideSelection = false;
      this.LoadedTokens.Location = new Point(27, 56);
      this.LoadedTokens.Name = "LoadedTokens";
      this.LoadedTokens.Size = new Size(445, 60);
      this.LoadedTokens.TabIndex = 6282;
      this.LoadedTokens.Text = "";
      this.InfoAddTokensTxt.BackColor = Color.FromArgb(33, 34, 38);
      this.InfoAddTokensTxt.BorderStyle = BorderStyle.None;
      this.InfoAddTokensTxt.Enabled = false;
      this.InfoAddTokensTxt.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfoAddTokensTxt.ForeColor = Color.Silver;
      this.InfoAddTokensTxt.Location = new Point(19, 133);
      this.InfoAddTokensTxt.Name = "InfoAddTokensTxt";
      this.InfoAddTokensTxt.Size = new Size(288, 16);
      this.InfoAddTokensTxt.TabIndex = 6280;
      this.InfoAddTokensTxt.Text = "[info]";
      this.panel56.BackColor = Color.FromArgb(51, 51, 51);
      this.panel56.Location = new Point(11, 128);
      this.panel56.Name = "panel56";
      this.panel56.Size = new Size(900, 2);
      this.panel56.TabIndex = 6281;
      this.TokensPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.TokensPnl.Controls.Add((Control)this.AddTokensBtn);
      this.TokensPnl.Controls.Add((Control)this.panel53);
      this.TokensPnl.Controls.Add((Control)this.TokensTxt);
      this.TokensPnl.Location = new Point(23, 14);
      this.TokensPnl.Name = "TokensPnl";
      this.TokensPnl.Size = new Size(422, 32);
      this.TokensPnl.TabIndex = 6279;
      this.panel53.BackColor = Color.FromArgb(56, 56, 56);
      this.panel53.Location = new Point(302, -60);
      this.panel53.Name = "panel53";
      this.panel53.Size = new Size(3, 148);
      this.panel53.TabIndex = 6277;
      this.TokensTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.TokensTxt.BorderStyle = BorderStyle.None;
      this.TokensTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.TokensTxt.ForeColor = Color.DarkGray;
      this.TokensTxt.Location = new Point(5, 7);
      this.TokensTxt.Name = "TokensTxt";
      this.TokensTxt.Size = new Size(291, 18);
      this.TokensTxt.TabIndex = 6153;
      this.TokensTxt.Text = "Drag Txt File here";
      this.TokensTxt.DragDrop += new DragEventHandler(this.TokensTxt_DragDrop);
      this.TokensTxt.DragEnter += new DragEventHandler(this.TokensTxt_DragEnter);
      this.TokensTxt.MouseEnter += new EventHandler(this.TokensTxt_MouseEnter);
      this.TokensTxt.MouseLeave += new EventHandler(this.TokensTxt_MouseLeave);
      this.ErrorPage.BackColor = Color.FromArgb(33, 34, 38);
      this.ErrorPage.Controls.Add((Control)this.panel83);
      this.ErrorPage.Controls.Add((Control)this.ErrorPnl);
      this.ErrorPage.Location = new Point(4, 22);
      this.ErrorPage.Name = "ErrorPage";
      this.ErrorPage.Size = new Size(472, 310);
      this.ErrorPage.TabIndex = 6;
      this.ErrorPage.Text = "Error";
      this.panel83.BackColor = Color.FromArgb(51, 51, 51);
      this.panel83.Location = new Point(5, 85);
      this.panel83.Name = "panel83";
      this.panel83.Size = new Size(387, 2);
      this.panel83.TabIndex = 6222;
      this.ErrorPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.ErrorPnl.Controls.Add((Control)this.label6);
      this.ErrorPnl.Controls.Add((Control)this.label14);
      this.ErrorPnl.Location = new Point(23, 14);
      this.ErrorPnl.Name = "ErrorPnl";
      this.ErrorPnl.Size = new Size(268, 60);
      this.ErrorPnl.TabIndex = 6169;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Impact", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label6.ForeColor = Color.Silver;
      this.label6.Location = new Point(5, 32);
      this.label6.Name = "label6";
      this.label6.Size = new Size(259, 21);
      this.label6.TabIndex = 6277;
      this.label6.Text = "CLOSE THIS WINDOW AND ADD TOKENS";
      this.label14.AutoSize = true;
      this.label14.Font = new Font("Impact", 12.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label14.ForeColor = Color.Silver;
      this.label14.Location = new Point(5, 6);
      this.label14.Name = "label14";
      this.label14.Size = new Size(260, 21);
      this.label14.TabIndex = 6276;
      this.label14.Text = "YOU NEED TO LOAD YOUR TOKENS FIRST";
      this.JoinPage.BackColor = Color.FromArgb(33, 34, 38);
      this.JoinPage.Controls.Add((Control)this.panel21);
      this.JoinPage.Controls.Add((Control)this.InfosJoinLeave);
      this.JoinPage.Controls.Add((Control)this.LeaveID);
      this.JoinPage.Controls.Add((Control)this.InvitePnl);
      this.JoinPage.Controls.Add((Control)this.GetInfosBtn);
      this.JoinPage.Location = new Point(4, 22);
      this.JoinPage.Name = "JoinPage";
      this.JoinPage.Padding = new Padding(3);
      this.JoinPage.Size = new Size(472, 310);
      this.JoinPage.TabIndex = 0;
      this.JoinPage.Text = "JoinerLeaver";
      this.panel21.BackColor = Color.FromArgb(51, 51, 51);
      this.panel21.Location = new Point(10, 95);
      this.panel21.Name = "panel21";
      this.panel21.Size = new Size(387, 2);
      this.panel21.TabIndex = 6221;
      this.InfosJoinLeave.BackColor = Color.FromArgb(33, 34, 38);
      this.InfosJoinLeave.BorderStyle = BorderStyle.None;
      this.InfosJoinLeave.Enabled = false;
      this.InfosJoinLeave.Font = new Font("Microsoft Tai Le", 9f, FontStyle.Bold);
      this.InfosJoinLeave.ForeColor = Color.Silver;
      this.InfosJoinLeave.Location = new Point(18, 100);
      this.InfosJoinLeave.Name = "InfosJoinLeave";
      this.InfosJoinLeave.Size = new Size(262, 16);
      this.InfosJoinLeave.TabIndex = 6220;
      this.InfosJoinLeave.Text = "[info]";
      this.LeaveID.BackColor = Color.FromArgb(49, 50, 55);
      this.LeaveID.Controls.Add((Control)this.LeaveBtn);
      this.LeaveID.Controls.Add((Control)this.panel27);
      this.LeaveID.Controls.Add((Control)this.panel26);
      this.LeaveID.Controls.Add((Control)this.panel25);
      this.LeaveID.Controls.Add((Control)this.panel24);
      this.LeaveID.Controls.Add((Control)this.panel20);
      this.LeaveID.Controls.Add((Control)this.LeaveServerTxt);
      this.LeaveID.Controls.Add((Control)this.LeaveSettingBtn);
      this.LeaveID.Location = new Point(24, 53);
      this.LeaveID.Name = "LeaveID";
      this.LeaveID.Size = new Size(347, 32);
      this.LeaveID.TabIndex = 6169;
      this.panel27.BackColor = Color.FromArgb(49, 50, 55);
      this.panel27.Location = new Point(315, 0);
      this.panel27.Name = "panel27";
      this.panel27.Size = new Size(4, 34);
      this.panel27.TabIndex = 6282;
      this.panel26.BackColor = Color.FromArgb(49, 50, 55);
      this.panel26.Location = new Point(342, 0);
      this.panel26.Name = "panel26";
      this.panel26.Size = new Size(44, 32);
      this.panel26.TabIndex = 6281;
      this.panel25.BackColor = Color.FromArgb(49, 50, 55);
      this.panel25.Location = new Point((int)byte.MaxValue, -5);
      this.panel25.Name = "panel25";
      this.panel25.Size = new Size(100, 10);
      this.panel25.TabIndex = 6280;
      this.panel24.BackColor = Color.FromArgb(49, 50, 55);
      this.panel24.Location = new Point(318, 27);
      this.panel24.Name = "panel24";
      this.panel24.Size = new Size(41, 148);
      this.panel24.TabIndex = 6278;
      this.panel20.BackColor = Color.FromArgb(56, 56, 56);
      this.panel20.Location = new Point(227, -60);
      this.panel20.Name = "panel20";
      this.panel20.Size = new Size(3, 148);
      this.panel20.TabIndex = 6277;
      this.LeaveServerTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.LeaveServerTxt.BorderStyle = BorderStyle.None;
      this.LeaveServerTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.LeaveServerTxt.ForeColor = Color.DarkGray;
      this.LeaveServerTxt.Location = new Point(5, 7);
      this.LeaveServerTxt.Name = "LeaveServerTxt";
      this.LeaveServerTxt.Size = new Size(217, 18);
      this.LeaveServerTxt.TabIndex = 6153;
      this.LeaveServerTxt.Text = "Server ID";
      this.LeaveServerTxt.Enter += new EventHandler(this.LeaveServerTxt_Enter);
      this.LeaveServerTxt.Leave += new EventHandler(this.LeaveServerTxt_Leave);
      this.LeaveServerTxt.MouseEnter += new EventHandler(this.LeaveServerTxt_MouseEnter);
      this.LeaveServerTxt.MouseLeave += new EventHandler(this.LeaveServerTxt_MouseLeave);
      this.LeaveSettingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.LeaveSettingBtn.BackColor = Color.FromArgb(49, 50, 55);
      this.LeaveSettingBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.LeaveSettingBtn.FlatAppearance.BorderSize = 0;
      this.LeaveSettingBtn.FlatStyle = FlatStyle.Flat;
      this.LeaveSettingBtn.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.LeaveSettingBtn.ForeColor = Color.WhiteSmoke;
      this.LeaveSettingBtn.Location = new Point(320, -1);
      this.LeaveSettingBtn.Name = "LeaveSettingBtn";
      this.LeaveSettingBtn.Size = new Size(27, 32);
      this.LeaveSettingBtn.TabIndex = 6279;
      this.LeaveSettingBtn.Text = "⚙";
      this.LeaveSettingBtn.UseVisualStyleBackColor = false;
      this.LeaveSettingBtn.Click += new EventHandler(this.LeaveSettingBtn_Click);
      this.InvitePnl.BackColor = Color.FromArgb(49, 50, 55);
      this.InvitePnl.Controls.Add((Control)this.JoinServerBtn);
      this.InvitePnl.Controls.Add((Control)this.panel28);
      this.InvitePnl.Controls.Add((Control)this.panel29);
      this.InvitePnl.Controls.Add((Control)this.panel30);
      this.InvitePnl.Controls.Add((Control)this.panel31);
      this.InvitePnl.Controls.Add((Control)this.JoinSettingsBtn);
      this.InvitePnl.Controls.Add((Control)this.panel19);
      this.InvitePnl.Controls.Add((Control)this.JoinTxt);
      this.InvitePnl.Location = new Point(24, 11);
      this.InvitePnl.Name = "InvitePnl";
      this.InvitePnl.Size = new Size(347, 32);
      this.InvitePnl.TabIndex = 6168;
      this.panel28.BackColor = Color.FromArgb(49, 50, 55);
      this.panel28.Location = new Point(317, 1);
      this.panel28.Name = "panel28";
      this.panel28.Size = new Size(4, 34);
      this.panel28.TabIndex = 6287;
      this.panel29.BackColor = Color.FromArgb(49, 50, 55);
      this.panel29.Location = new Point(344, 1);
      this.panel29.Name = "panel29";
      this.panel29.Size = new Size(44, 32);
      this.panel29.TabIndex = 6286;
      this.panel30.BackColor = Color.FromArgb(49, 50, 55);
      this.panel30.Location = new Point(257, -4);
      this.panel30.Name = "panel30";
      this.panel30.Size = new Size(100, 10);
      this.panel30.TabIndex = 6285;
      this.panel31.BackColor = Color.FromArgb(49, 50, 55);
      this.panel31.Location = new Point(320, 27);
      this.panel31.Name = "panel31";
      this.panel31.Size = new Size(41, 148);
      this.panel31.TabIndex = 6283;
      this.JoinSettingsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.JoinSettingsBtn.BackColor = Color.FromArgb(49, 50, 55);
      this.JoinSettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.JoinSettingsBtn.FlatAppearance.BorderSize = 0;
      this.JoinSettingsBtn.FlatStyle = FlatStyle.Flat;
      this.JoinSettingsBtn.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.JoinSettingsBtn.ForeColor = Color.WhiteSmoke;
      this.JoinSettingsBtn.Location = new Point(320, -1);
      this.JoinSettingsBtn.Name = "JoinSettingsBtn";
      this.JoinSettingsBtn.Size = new Size(27, 32);
      this.JoinSettingsBtn.TabIndex = 6284;
      this.JoinSettingsBtn.Text = "⚙";
      this.JoinSettingsBtn.UseVisualStyleBackColor = false;
      this.JoinSettingsBtn.Click += new EventHandler(this.JoinSettingsBtn_Click);
      this.panel19.BackColor = Color.FromArgb(56, 56, 56);
      this.panel19.Location = new Point(227, -12);
      this.panel19.Name = "panel19";
      this.panel19.Size = new Size(3, 148);
      this.panel19.TabIndex = 6277;
      this.JoinTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.JoinTxt.BorderStyle = BorderStyle.None;
      this.JoinTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.JoinTxt.ForeColor = Color.DarkGray;
      this.JoinTxt.Location = new Point(5, 7);
      this.JoinTxt.Name = "JoinTxt";
      this.JoinTxt.Size = new Size(217, 18);
      this.JoinTxt.TabIndex = 6153;
      this.JoinTxt.Text = "Discord Invite";
      this.JoinTxt.Enter += new EventHandler(this.JoinTxt_Enter);
      this.JoinTxt.Leave += new EventHandler(this.JoinTxt_Leave);
      this.JoinTxt.MouseEnter += new EventHandler(this.JoinTxt_MouseEnter);
      this.JoinTxt.MouseLeave += new EventHandler(this.JoinTxt_MouseLeave);
      this.GetInfosBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.GetInfosBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.GetInfosBtn.FlatAppearance.BorderSize = 0;
      this.GetInfosBtn.FlatStyle = FlatStyle.Flat;
      this.GetInfosBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.GetInfosBtn.ForeColor = Color.Silver;
      this.GetInfosBtn.Location = new Point(281, 96);
      this.GetInfosBtn.Name = "GetInfosBtn";
      this.GetInfosBtn.Size = new Size(104, 22);
      this.GetInfosBtn.TabIndex = 6192;
      this.GetInfosBtn.Text = "Get Server Infos";
      this.GetInfosBtn.UseVisualStyleBackColor = false;
      this.GetInfosBtn.Click += new EventHandler(this.GetInfosBtn_Click);
      this.SpammingPage.BackColor = Color.FromArgb(33, 34, 38);
      this.SpammingPage.Controls.Add((Control)this.EmbedPnl);
      this.SpammingPage.Controls.Add((Control)this.EmbedBtn);
      this.SpammingPage.Controls.Add((Control)this.EmbedLbl);
      this.SpammingPage.Controls.Add((Control)this.OpenDMBtn);
      this.SpammingPage.Controls.Add((Control)this.panel38);
      this.SpammingPage.Controls.Add((Control)this.ChannelSpPnl);
      this.SpammingPage.Controls.Add((Control)this.DmSpammingBtn);
      this.SpammingPage.Controls.Add((Control)this.OpenExtraStuffBtn);
      this.SpammingPage.Controls.Add((Control)this.SpamPnl);
      this.SpammingPage.Controls.Add((Control)this.EmbedPnl2);
      this.SpammingPage.Controls.Add((Control)this.SettingsPnl);
      this.SpammingPage.Location = new Point(4, 22);
      this.SpammingPage.Name = "SpammingPage";
      this.SpammingPage.Padding = new Padding(3);
      this.SpammingPage.Size = new Size(472, 310);
      this.SpammingPage.TabIndex = 1;
      this.SpammingPage.Text = "Spamming";
      this.EmbedPnl.BackColor = Color.FromArgb(33, 34, 38);
      this.EmbedPnl.Controls.Add((Control)this.EmbedDescPnl);
      this.EmbedPnl.Controls.Add((Control)this.EmbedTitlePnl);
      this.EmbedPnl.Controls.Add((Control)this.EmbedChannelPnl);
      this.EmbedPnl.Location = new Point(13, 6);
      this.EmbedPnl.Name = "EmbedPnl";
      this.EmbedPnl.Size = new Size(313, 142);
      this.EmbedPnl.TabIndex = 6294;
      this.EmbedPnl.Visible = false;
      this.EmbedDescPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedDescPnl.Controls.Add((Control)this.EmbedDescTxt);
      this.EmbedDescPnl.Location = new Point(6, 100);
      this.EmbedDescPnl.Name = "EmbedDescPnl";
      this.EmbedDescPnl.Size = new Size(298, 32);
      this.EmbedDescPnl.TabIndex = 6173;
      this.EmbedDescTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedDescTxt.BorderStyle = BorderStyle.None;
      this.EmbedDescTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.EmbedDescTxt.ForeColor = Color.DarkGray;
      this.EmbedDescTxt.Location = new Point(7, 7);
      this.EmbedDescTxt.Name = "EmbedDescTxt";
      this.EmbedDescTxt.Size = new Size(285, 18);
      this.EmbedDescTxt.TabIndex = 6153;
      this.EmbedDescTxt.Text = "Embed Description";
      this.EmbedDescTxt.Enter += new EventHandler(this.EmbedDescTxt_Enter);
      this.EmbedDescTxt.Leave += new EventHandler(this.EmbedDescTxt_Leave);
      this.EmbedTitlePnl.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedTitlePnl.Controls.Add((Control)this.EmbedTitleTxt);
      this.EmbedTitlePnl.Location = new Point(7, 55);
      this.EmbedTitlePnl.Name = "EmbedTitlePnl";
      this.EmbedTitlePnl.Size = new Size(298, 32);
      this.EmbedTitlePnl.TabIndex = 6172;
      this.EmbedTitleTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedTitleTxt.BorderStyle = BorderStyle.None;
      this.EmbedTitleTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.EmbedTitleTxt.ForeColor = Color.DarkGray;
      this.EmbedTitleTxt.Location = new Point(7, 7);
      this.EmbedTitleTxt.Name = "EmbedTitleTxt";
      this.EmbedTitleTxt.Size = new Size(285, 18);
      this.EmbedTitleTxt.TabIndex = 6153;
      this.EmbedTitleTxt.Text = "Embed Title";
      this.EmbedTitleTxt.Enter += new EventHandler(this.EmbedTitleTxt_Enter);
      this.EmbedTitleTxt.Leave += new EventHandler(this.EmbedTitleTxt_Leave);
      this.EmbedChannelPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedChannelPnl.Controls.Add((Control)this.StartEmbedSpammer);
      this.EmbedChannelPnl.Controls.Add((Control)this.panel33);
      this.EmbedChannelPnl.Controls.Add((Control)this.EmbedChannelIdTxt);
      this.EmbedChannelPnl.Location = new Point(7, 10);
      this.EmbedChannelPnl.Name = "EmbedChannelPnl";
      this.EmbedChannelPnl.Size = new Size(298, 32);
      this.EmbedChannelPnl.TabIndex = 6171;
      this.panel33.BackColor = Color.FromArgb(56, 56, 56);
      this.panel33.Location = new Point(170, 0);
      this.panel33.Name = "panel33";
      this.panel33.Size = new Size(3, 148);
      this.panel33.TabIndex = 6277;
      this.EmbedChannelIdTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedChannelIdTxt.BorderStyle = BorderStyle.None;
      this.EmbedChannelIdTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.EmbedChannelIdTxt.ForeColor = Color.DarkGray;
      this.EmbedChannelIdTxt.Location = new Point(7, 7);
      this.EmbedChannelIdTxt.Name = "EmbedChannelIdTxt";
      this.EmbedChannelIdTxt.Size = new Size(152, 18);
      this.EmbedChannelIdTxt.TabIndex = 6153;
      this.EmbedChannelIdTxt.Text = "Channel ID";
      this.EmbedChannelIdTxt.Enter += new EventHandler(this.EmbedChannelIdTxt_Enter);
      this.EmbedChannelIdTxt.Leave += new EventHandler(this.EmbedChannelIdTxt_Leave);
      this.EmbedBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.EmbedBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmbedBtn.FlatAppearance.BorderSize = 0;
      this.EmbedBtn.FlatStyle = FlatStyle.Flat;
      this.EmbedBtn.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.EmbedBtn.ForeColor = Color.White;
      this.EmbedBtn.Location = new Point(420, 110);
      this.EmbedBtn.Name = "EmbedBtn";
      this.EmbedBtn.Size = new Size(20, 20);
      this.EmbedBtn.TabIndex = 6292;
      this.EmbedBtn.UseVisualStyleBackColor = false;
      this.EmbedBtn.Click += new EventHandler(this.EmbedBtn_Click);
      this.EmbedLbl.AutoSize = true;
      this.EmbedLbl.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedLbl.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.EmbedLbl.ForeColor = Color.Silver;
      this.EmbedLbl.Location = new Point(332, 109);
      this.EmbedLbl.Name = "EmbedLbl";
      this.EmbedLbl.Size = new Size(85, 20);
      this.EmbedLbl.TabIndex = 6293;
      this.EmbedLbl.Text = "Embed Msg:";
      this.OpenDMBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.OpenDMBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.OpenDMBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.OpenDMBtn.FlatAppearance.BorderSize = 0;
      this.OpenDMBtn.FlatStyle = FlatStyle.Flat;
      this.OpenDMBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.OpenDMBtn.ForeColor = Color.Silver;
      this.OpenDMBtn.Location = new Point(-219, 130);
      this.OpenDMBtn.Name = "OpenDMBtn";
      this.OpenDMBtn.Size = new Size(134, 22);
      this.OpenDMBtn.TabIndex = 6225;
      this.OpenDMBtn.Text = "Open DM Spammer";
      this.OpenDMBtn.UseVisualStyleBackColor = false;
      this.panel38.BackColor = Color.FromArgb(51, 51, 51);
      this.panel38.Location = new Point(4, 149);
      this.panel38.Name = "panel38";
      this.panel38.Size = new Size(1387, 2);
      this.panel38.TabIndex = 6224;
      this.ChannelSpPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.ChannelSpPnl.Controls.Add((Control)this.SpammerBtn);
      this.ChannelSpPnl.Controls.Add((Control)this.panel18);
      this.ChannelSpPnl.Controls.Add((Control)this.ChannelIDTxt);
      this.ChannelSpPnl.Location = new Point(19, 15);
      this.ChannelSpPnl.Name = "ChannelSpPnl";
      this.ChannelSpPnl.Size = new Size(298, 32);
      this.ChannelSpPnl.TabIndex = 6170;
      this.panel18.BackColor = Color.FromArgb(56, 56, 56);
      this.panel18.Location = new Point(170, 0);
      this.panel18.Name = "panel18";
      this.panel18.Size = new Size(3, 148);
      this.panel18.TabIndex = 6277;
      this.ChannelIDTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.ChannelIDTxt.BorderStyle = BorderStyle.None;
      this.ChannelIDTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ChannelIDTxt.ForeColor = Color.DarkGray;
      this.ChannelIDTxt.Location = new Point(7, 7);
      this.ChannelIDTxt.Name = "ChannelIDTxt";
      this.ChannelIDTxt.Size = new Size(152, 18);
      this.ChannelIDTxt.TabIndex = 6153;
      this.ChannelIDTxt.Text = "Channel ID";
      this.ChannelIDTxt.Enter += new EventHandler(this.ChannelIDTxt_Enter);
      this.ChannelIDTxt.Leave += new EventHandler(this.ChannelIDTxt_Leave);
      this.DmSpammingBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.DmSpammingBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.DmSpammingBtn.FlatAppearance.BorderSize = 0;
      this.DmSpammingBtn.FlatStyle = FlatStyle.Flat;
      this.DmSpammingBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.DmSpammingBtn.ForeColor = Color.Silver;
      this.DmSpammingBtn.Location = new Point(10, 151);
      this.DmSpammingBtn.Name = "DmSpammingBtn";
      this.DmSpammingBtn.Size = new Size(144, 22);
      this.DmSpammingBtn.TabIndex = 6226;
      this.DmSpammingBtn.Text = "Open DM Spammer";
      this.DmSpammingBtn.UseVisualStyleBackColor = false;
      this.DmSpammingBtn.Click += new EventHandler(this.DmSpammingBtn_Click);
      this.OpenExtraStuffBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.OpenExtraStuffBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.OpenExtraStuffBtn.FlatAppearance.BorderSize = 0;
      this.OpenExtraStuffBtn.FlatStyle = FlatStyle.Flat;
      this.OpenExtraStuffBtn.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.OpenExtraStuffBtn.ForeColor = Color.Silver;
      this.OpenExtraStuffBtn.Location = new Point(364, 151);
      this.OpenExtraStuffBtn.Name = "OpenExtraStuffBtn";
      this.OpenExtraStuffBtn.Size = new Size(99, 22);
      this.OpenExtraStuffBtn.TabIndex = 6222;
      this.OpenExtraStuffBtn.Text = "Open Text Gen";
      this.OpenExtraStuffBtn.UseVisualStyleBackColor = false;
      this.OpenExtraStuffBtn.Click += new EventHandler(this.OpenExtraStuffBtn_Click);
      this.SpamPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.SpamPnl.Controls.Add((Control)this.MessageSpTxt);
      this.SpamPnl.Location = new Point(19, 56);
      this.SpamPnl.Name = "SpamPnl";
      this.SpamPnl.Size = new Size(298, 83);
      this.SpamPnl.TabIndex = 6171;
      this.MessageSpTxt.BackColor = Color.FromArgb(49, 50, 55);
      this.MessageSpTxt.BorderStyle = BorderStyle.None;
      this.MessageSpTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.MessageSpTxt.ForeColor = Color.DarkGray;
      this.MessageSpTxt.Location = new Point(6, 7);
      this.MessageSpTxt.Multiline = true;
      this.MessageSpTxt.Name = "MessageSpTxt";
      this.MessageSpTxt.Size = new Size(284, 68);
      this.MessageSpTxt.TabIndex = 6153;
      this.MessageSpTxt.Text = "Your Message";
      this.MessageSpTxt.Enter += new EventHandler(this.MessageSpTxt_Enter);
      this.MessageSpTxt.Leave += new EventHandler(this.MessageSpTxt_Leave);
      this.EmbedPnl2.BackColor = Color.FromArgb(49, 50, 55);
      this.EmbedPnl2.Controls.Add((Control)this.label17);
      this.EmbedPnl2.Controls.Add((Control)this.RndColorBtn);
      this.EmbedPnl2.Controls.Add((Control)this.label19);
      this.EmbedPnl2.Controls.Add((Control)this.EmbedTypingBtn);
      this.EmbedPnl2.Controls.Add((Control)this.ChooseColorBtn);
      this.EmbedPnl2.Location = new Point(325, 15);
      this.EmbedPnl2.Name = "EmbedPnl2";
      this.EmbedPnl2.Size = new Size(123, 124);
      this.EmbedPnl2.TabIndex = 6295;
      this.EmbedPnl2.Visible = false;
      this.label17.AutoSize = true;
      this.label17.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label17.ForeColor = Color.Silver;
      this.label17.Location = new Point(7, 37);
      this.label17.Name = "label17";
      this.label17.Size = new Size(88, 20);
      this.label17.TabIndex = 6289;
      this.label17.Text = "User Typing:";
      this.RndColorBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.RndColorBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.RndColorBtn.FlatAppearance.BorderSize = 0;
      this.RndColorBtn.FlatStyle = FlatStyle.Flat;
      this.RndColorBtn.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.RndColorBtn.ForeColor = Color.White;
      this.RndColorBtn.Location = new Point(95, 67);
      this.RndColorBtn.Name = "RndColorBtn";
      this.RndColorBtn.Size = new Size(20, 20);
      this.RndColorBtn.TabIndex = 6290;
      this.RndColorBtn.UseVisualStyleBackColor = false;
      this.RndColorBtn.Click += new EventHandler(this.RndColorBtn_Click);
      this.label19.AutoSize = true;
      this.label19.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label19.ForeColor = Color.Silver;
      this.label19.Location = new Point(7, 66);
      this.label19.Name = "label19";
      this.label19.Size = new Size(87, 20);
      this.label19.TabIndex = 6291;
      this.label19.Text = "Rndm Color:";
      this.EmbedTypingBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.EmbedTypingBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.EmbedTypingBtn.FlatAppearance.BorderSize = 0;
      this.EmbedTypingBtn.FlatStyle = FlatStyle.Flat;
      this.EmbedTypingBtn.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.EmbedTypingBtn.ForeColor = Color.White;
      this.EmbedTypingBtn.Location = new Point(95, 38);
      this.EmbedTypingBtn.Name = "EmbedTypingBtn";
      this.EmbedTypingBtn.Size = new Size(20, 20);
      this.EmbedTypingBtn.TabIndex = 6288;
      this.EmbedTypingBtn.UseVisualStyleBackColor = false;
      this.EmbedTypingBtn.Click += new EventHandler(this.EmbedTypingBtn_Click);
      this.ChooseColorBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.ChooseColorBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.ChooseColorBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.ChooseColorBtn.FlatAppearance.BorderSize = 0;
      this.ChooseColorBtn.FlatStyle = FlatStyle.Flat;
      this.ChooseColorBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.ChooseColorBtn.ForeColor = Color.Silver;
      this.ChooseColorBtn.Location = new Point(8, 8);
      this.ChooseColorBtn.Name = "ChooseColorBtn";
      this.ChooseColorBtn.Size = new Size(107, 22);
      this.ChooseColorBtn.TabIndex = 6306;
      this.ChooseColorBtn.Text = "CHOOSE COLOR";
      this.ChooseColorBtn.UseVisualStyleBackColor = false;
      this.ChooseColorBtn.Click += new EventHandler(this.ChooseColorBtn_Click);
      this.SettingsPnl.BackColor = Color.FromArgb(49, 50, 55);
      this.SettingsPnl.Controls.Add((Control)this.label8);
      this.SettingsPnl.Controls.Add((Control)this.TypingBtn);
      this.SettingsPnl.Controls.Add((Control)this.label12);
      this.SettingsPnl.Controls.Add((Control)this.label13);
      this.SettingsPnl.Controls.Add((Control)this.UnderlinedBtn);
      this.SettingsPnl.Controls.Add((Control)this.BlockTxt);
      this.SettingsPnl.Location = new Point(326, 15);
      this.SettingsPnl.Name = "SettingsPnl";
      this.SettingsPnl.Size = new Size(123, 124);
      this.SettingsPnl.TabIndex = 6292;
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label8.ForeColor = Color.Silver;
      this.label8.Location = new Point(7, 37);
      this.label8.Name = "label8";
      this.label8.Size = new Size(77, 20);
      this.label8.TabIndex = 6289;
      this.label8.Text = "Block Text:";
      this.TypingBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.TypingBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.TypingBtn.FlatAppearance.BorderSize = 0;
      this.TypingBtn.FlatStyle = FlatStyle.Flat;
      this.TypingBtn.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.TypingBtn.ForeColor = Color.White;
      this.TypingBtn.Location = new Point(95, 66);
      this.TypingBtn.Name = "TypingBtn";
      this.TypingBtn.Size = new Size(20, 20);
      this.TypingBtn.TabIndex = 6290;
      this.TypingBtn.UseVisualStyleBackColor = false;
      this.TypingBtn.Click += new EventHandler(this.TypingBtn_Click);
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label12.ForeColor = Color.Silver;
      this.label12.Location = new Point(7, 9);
      this.label12.Name = "label12";
      this.label12.Size = new Size(83, 20);
      this.label12.TabIndex = 6287;
      this.label12.Text = "Underlined:";
      this.label13.AutoSize = true;
      this.label13.Font = new Font("Impact", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label13.ForeColor = Color.Silver;
      this.label13.Location = new Point(7, 65);
      this.label13.Name = "label13";
      this.label13.Size = new Size(88, 20);
      this.label13.TabIndex = 6291;
      this.label13.Text = "User Typing:";
      this.UnderlinedBtn.BackColor = Color.FromArgb(33, 34, 38);
      this.UnderlinedBtn.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.UnderlinedBtn.FlatAppearance.BorderSize = 0;
      this.UnderlinedBtn.FlatStyle = FlatStyle.Flat;
      this.UnderlinedBtn.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.UnderlinedBtn.ForeColor = Color.White;
      this.UnderlinedBtn.Location = new Point(95, 10);
      this.UnderlinedBtn.Name = "UnderlinedBtn";
      this.UnderlinedBtn.Size = new Size(20, 20);
      this.UnderlinedBtn.TabIndex = 6286;
      this.UnderlinedBtn.UseVisualStyleBackColor = false;
      this.UnderlinedBtn.Click += new EventHandler(this.UnderlinedBtn_Click);
      this.BlockTxt.BackColor = Color.FromArgb(33, 34, 38);
      this.BlockTxt.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.BlockTxt.FlatAppearance.BorderSize = 0;
      this.BlockTxt.FlatStyle = FlatStyle.Flat;
      this.BlockTxt.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.BlockTxt.ForeColor = Color.White;
      this.BlockTxt.Location = new Point(95, 38);
      this.BlockTxt.Name = "BlockTxt";
      this.BlockTxt.Size = new Size(20, 20);
      this.BlockTxt.TabIndex = 6288;
      this.BlockTxt.UseVisualStyleBackColor = false;
      this.BlockTxt.Click += new EventHandler(this.BlockTxt_Click);
      this.panel14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.panel14.BackColor = Color.FromArgb(33, 34, 38);
      this.panel14.Location = new Point(0, 339);
      this.panel14.Name = "panel14";
      this.panel14.Size = new Size(3813, 2);
      this.panel14.TabIndex = 6300;
      this.InfosLbl.BackColor = Color.FromArgb(33, 34, 38);
      this.InfosLbl.Controls.Add((Control)this.JoinLbl);
      this.InfosLbl.Controls.Add((Control)this.label9);
      this.InfosLbl.Controls.Add((Control)this.label10);
      this.InfosLbl.Controls.Add((Control)this.label11);
      this.InfosLbl.Controls.Add((Control)this.label4);
      this.InfosLbl.Controls.Add((Control)this.label7);
      this.InfosLbl.Controls.Add((Control)this.label1);
      this.InfosLbl.Controls.Add((Control)this.label3);
      this.InfosLbl.Controls.Add((Control)this.label2);
      this.InfosLbl.Controls.Add((Control)this.label5);
      this.InfosLbl.Controls.Add((Control)this.panel40);
      this.InfosLbl.Controls.Add((Control)this.HeadExtraPnl);
      this.InfosLbl.Location = new Point(301, 32);
      this.InfosLbl.Name = "InfosLbl";
      this.InfosLbl.Size = new Size(195, 295);
      this.InfosLbl.TabIndex = 6302;
      this.JoinLbl.AutoSize = true;
      this.JoinLbl.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.JoinLbl.ForeColor = Color.White;
      this.JoinLbl.Location = new Point(12, 233);
      this.JoinLbl.Name = "JoinLbl";
      this.JoinLbl.Size = new Size(175, 17);
      this.JoinLbl.TabIndex = 6293;
      this.JoinLbl.Text = "https://github.com/";
      this.JoinLbl.Click += new EventHandler(this.JoinLbl_Click);
      this.JoinLbl.MouseEnter += new EventHandler(this.JoinLbl_MouseEnter);
      this.JoinLbl.MouseLeave += new EventHandler(this.JoinLbl_MouseLeave);
      this.label9.AutoSize = true;
      this.label9.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label9.ForeColor = Color.Silver;
      this.label9.Location = new Point(12, 216);
      this.label9.Name = "label9";
      this.label9.Size = new Size(117, 17);
      this.label9.TabIndex = 6292;
      this.label9.Text = "Download Source:";
      this.label10.AutoSize = true;
      this.label10.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label10.ForeColor = Color.White;
      this.label10.Location = new Point(12, 189);
      this.label10.Name = "label10";
      this.label10.Size = new Size(54, 17);
      this.label10.TabIndex = 6291;
      this.label10.Text = "Pretty, Chavo";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label11.ForeColor = Color.Silver;
      this.label11.Location = new Point(12, 172);
      this.label11.Name = "label11";
      this.label11.Size = new Size(49, 17);
      this.label11.TabIndex = 6290;
      this.label11.Text = "Friend:";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label4.ForeColor = Color.White;
      this.label4.Location = new Point(12, 146);
      this.label4.Name = "label4";
      this.label4.Size = new Size(73, 17);
      this.label4.TabIndex = 6289;
      this.label4.Text = "Unknown";
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label7.ForeColor = Color.Silver;
      this.label7.Location = new Point(12, 129);
      this.label7.Name = "label7";
      this.label7.Size = new Size(99, 17);
      this.label7.TabIndex = 6288;
      this.label7.Text = "Raider Creator:";
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(12, 102);
      this.label1.Name = "label1";
      this.label1.Size = new Size(24, 17);
      this.label1.TabIndex = 6287;
      this.label1.Text = "C#";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label3.ForeColor = Color.Silver;
      this.label3.Location = new Point(12, 85);
      this.label3.Name = "label3";
      this.label3.Size = new Size(117, 17);
      this.label3.TabIndex = 6286;
      this.label3.Text = "Coding Language:";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(12, 60);
      this.label2.Name = "label2";
      this.label2.Size = new Size(145, 17);
      this.label2.TabIndex = 6285;
      this.label2.Text = "2.4";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.label5.ForeColor = Color.Silver;
      this.label5.Location = new Point(12, 43);
      this.label5.Name = "label5";
      this.label5.Size = new Size(105, 17);
      this.label5.TabIndex = 6284;
      this.label5.Text = "Current Version:";
      this.panel40.BackColor = Color.FromArgb(51, 51, 51);
      this.panel40.Location = new Point(-1, 270);
      this.panel40.Name = "panel40";
      this.panel40.Size = new Size(387, 2);
      this.panel40.TabIndex = 6283;
      this.HeadExtraPnl.BackColor = Color.FromArgb(33, 34, 38);
      this.HeadExtraPnl.Controls.Add((Control)this.panel42);
      this.HeadExtraPnl.Controls.Add((Control)this.HeadExtraLbl);
      this.HeadExtraPnl.Controls.Add((Control)this.panel43);
      this.HeadExtraPnl.Controls.Add((Control)this.comboBox6);
      this.HeadExtraPnl.Controls.Add((Control)this.textBox9);
      this.HeadExtraPnl.Controls.Add((Control)this.button7);
      this.HeadExtraPnl.Controls.Add((Control)this.panel44);
      this.HeadExtraPnl.Controls.Add((Control)this.panel45);
      this.HeadExtraPnl.Controls.Add((Control)this.panel46);
      this.HeadExtraPnl.Dock = DockStyle.Top;
      this.HeadExtraPnl.Location = new Point(0, 0);
      this.HeadExtraPnl.Name = "HeadExtraPnl";
      this.HeadExtraPnl.Size = new Size(195, 29);
      this.HeadExtraPnl.TabIndex = 6282;
      this.panel42.BackColor = Color.FromArgb(51, 51, 51);
      this.panel42.Location = new Point(15, 24);
      this.panel42.Name = "panel42";
      this.panel42.Size = new Size(167, 2);
      this.panel42.TabIndex = 6222;
      this.HeadExtraLbl.AutoSize = true;
      this.HeadExtraLbl.Font = new Font("Microsoft Tai Le", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.HeadExtraLbl.ForeColor = Color.White;
      this.HeadExtraLbl.Location = new Point(68, 3);
      this.HeadExtraLbl.Name = "HeadExtraLbl";
      this.HeadExtraLbl.Size = new Size(57, 21);
      this.HeadExtraLbl.TabIndex = 6166;
      this.HeadExtraLbl.Text = "INFOS";
      this.panel43.BackColor = Color.FromArgb(51, 51, 51);
      this.panel43.Font = new Font("Segoe UI", 9f);
      this.panel43.Location = new Point(362, -44);
      this.panel43.Name = "panel43";
      this.panel43.Size = new Size(2, 25);
      this.panel43.TabIndex = 6160;
      this.comboBox6.BackColor = Color.FromArgb(25, 25, 25);
      this.comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBox6.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
      this.comboBox6.ForeColor = Color.Silver;
      this.comboBox6.FormattingEnabled = true;
      this.comboBox6.Location = new Point(364, -44);
      this.comboBox6.Name = "comboBox6";
      this.comboBox6.Size = new Size(254, 25);
      this.comboBox6.TabIndex = 6154;
      this.textBox9.BackColor = Color.FromArgb(25, 25, 25);
      this.textBox9.BorderStyle = BorderStyle.None;
      this.textBox9.Font = new Font("Segoe UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.textBox9.ForeColor = Color.White;
      this.textBox9.Location = new Point(364, -42);
      this.textBox9.Multiline = true;
      this.textBox9.Name = "textBox9";
      this.textBox9.Size = new Size(231, 21);
      this.textBox9.TabIndex = 6156;
      this.textBox9.Text = " Voice Channel";
      this.button7.BackColor = Color.FromArgb(25, 25, 25);
      this.button7.FlatAppearance.BorderColor = Color.FromArgb(142, 68, 173);
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.Font = new Font("Webdings", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)2);
      this.button7.ForeColor = Color.Silver;
      this.button7.Location = new Point(594, -43);
      this.button7.Name = "button7";
      this.button7.Size = new Size(25, 22);
      this.button7.TabIndex = 6155;
      this.button7.Text = "6";
      this.button7.UseVisualStyleBackColor = false;
      this.panel44.BackColor = Color.FromArgb(51, 51, 51);
      this.panel44.Font = new Font("Segoe UI", 9f);
      this.panel44.Location = new Point(364, -21);
      this.panel44.Name = "panel44";
      this.panel44.Size = new Size(254, 2);
      this.panel44.TabIndex = 6157;
      this.panel45.BackColor = Color.FromArgb(51, 51, 51);
      this.panel45.Font = new Font("Segoe UI", 9f);
      this.panel45.Location = new Point(364, -44);
      this.panel45.Name = "panel45";
      this.panel45.Size = new Size(254, 2);
      this.panel45.TabIndex = 6158;
      this.panel46.BackColor = Color.FromArgb(51, 51, 51);
      this.panel46.Font = new Font("Segoe UI", 9f);
      this.panel46.Location = new Point(617, -44);
      this.panel46.Name = "panel46";
      this.panel46.Size = new Size(2, 25);
      this.panel46.TabIndex = 6159;
      this.GetEmojiTimer.Tick += new EventHandler(this.GetEmojiTimer_Tick);
      this.WinInfo.BalloonTipTitle = "Discord Raider";
      this.WinInfo.Icon = (Icon)componentResourceManager.GetObject("WinInfo.Icon");
      this.WinInfo.Visible = true;
      this.pictureBox1.Image = (Image)Resources.PoweredByByteTools;
      this.pictureBox1.Location = new Point(358, 341);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(147, 19);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6303;
      this.pictureBox1.TabStop = false;
      this.RemoveReactionBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.RemoveReactionBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.RemoveReactionBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 34, 38);
      this.RemoveReactionBtn.FlatAppearance.BorderSize = 0;
      this.RemoveReactionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 34, 38);
      this.RemoveReactionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 34, 38);
      this.RemoveReactionBtn.FlatStyle = FlatStyle.Flat;
      this.RemoveReactionBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.RemoveReactionBtn.Location = new Point(200, 93);
      this.RemoveReactionBtn.Name = "RemoveReactionBtn";
      this.RemoveReactionBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.RemoveReactionBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.RemoveReactionBtn.OnHoverTextColor = Color.White;
      this.RemoveReactionBtn.Size = new Size(174, 23);
      this.RemoveReactionBtn.TabIndex = 6318;
      this.RemoveReactionBtn.Text = "Rmv Reaction";
      this.RemoveReactionBtn.TextColor = Color.White;
      this.RemoveReactionBtn.UseVisualStyleBackColor = true;
      this.RemoveReactionBtn.Click += new EventHandler(this.RemoveReactionBtn_Click);
      this.AddReactionBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.AddReactionBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.AddReactionBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 34, 38);
      this.AddReactionBtn.FlatAppearance.BorderSize = 0;
      this.AddReactionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 34, 38);
      this.AddReactionBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 34, 38);
      this.AddReactionBtn.FlatStyle = FlatStyle.Flat;
      this.AddReactionBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.AddReactionBtn.Location = new Point(20, 93);
      this.AddReactionBtn.Name = "AddReactionBtn";
      this.AddReactionBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.AddReactionBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.AddReactionBtn.OnHoverTextColor = Color.White;
      this.AddReactionBtn.Size = new Size(174, 23);
      this.AddReactionBtn.TabIndex = 6317;
      this.AddReactionBtn.Text = "Add Reaction";
      this.AddReactionBtn.TextColor = Color.White;
      this.AddReactionBtn.UseVisualStyleBackColor = true;
      this.AddReactionBtn.Click += new EventHandler(this.AddReactionBtn_Click);
      this.RemoveReBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.RemoveReBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.RemoveReBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.RemoveReBtn.FlatAppearance.BorderSize = 0;
      this.RemoveReBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.RemoveReBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.RemoveReBtn.FlatStyle = FlatStyle.Flat;
      this.RemoveReBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.RemoveReBtn.Location = new Point(226, 5);
      this.RemoveReBtn.Name = "RemoveReBtn";
      this.RemoveReBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.RemoveReBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.RemoveReBtn.OnHoverTextColor = Color.White;
      this.RemoveReBtn.Size = new Size(116, 22);
      this.RemoveReBtn.TabIndex = 6317;
      this.RemoveReBtn.Text = "REMOVE REQUEST";
      this.RemoveReBtn.TextColor = Color.White;
      this.RemoveReBtn.UseVisualStyleBackColor = true;
      this.RemoveReBtn.Click += new EventHandler(this.RemoveReBtn_Click);
      this.SendReBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.SendReBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.SendReBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.SendReBtn.FlatAppearance.BorderSize = 0;
      this.SendReBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.SendReBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.SendReBtn.FlatStyle = FlatStyle.Flat;
      this.SendReBtn.Font = new Font("Segoe UI Black", 8.25f, FontStyle.Bold);
      this.SendReBtn.Location = new Point(234, 5);
      this.SendReBtn.Name = "SendReBtn";
      this.SendReBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.SendReBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.SendReBtn.OnHoverTextColor = Color.White;
      this.SendReBtn.Size = new Size(108, 22);
      this.SendReBtn.TabIndex = 6316;
      this.SendReBtn.Text = "SEND REQUEST";
      this.SendReBtn.TextColor = Color.White;
      this.SendReBtn.UseVisualStyleBackColor = true;
      this.SendReBtn.Click += new EventHandler(this.SendReBtn_Click);
      this.AddTokensBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.AddTokensBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.AddTokensBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.AddTokensBtn.FlatAppearance.BorderSize = 0;
      this.AddTokensBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.AddTokensBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.AddTokensBtn.FlatStyle = FlatStyle.Flat;
      this.AddTokensBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.AddTokensBtn.Location = new Point(311, 5);
      this.AddTokensBtn.Name = "AddTokensBtn";
      this.AddTokensBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.AddTokensBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.AddTokensBtn.OnHoverTextColor = Color.White;
      this.AddTokensBtn.Size = new Size(103, 22);
      this.AddTokensBtn.TabIndex = 6316;
      this.AddTokensBtn.Text = "ADD";
      this.AddTokensBtn.TextColor = Color.White;
      this.AddTokensBtn.UseVisualStyleBackColor = true;
      this.AddTokensBtn.Click += new EventHandler(this.AddTokensBtn_Click);
      this.LeaveBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.LeaveBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.LeaveBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.LeaveBtn.FlatAppearance.BorderSize = 0;
      this.LeaveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.LeaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.LeaveBtn.FlatStyle = FlatStyle.Flat;
      this.LeaveBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.LeaveBtn.Location = new Point(233, 5);
      this.LeaveBtn.Name = "LeaveBtn";
      this.LeaveBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.LeaveBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.LeaveBtn.OnHoverTextColor = Color.White;
      this.LeaveBtn.Size = new Size(86, 22);
      this.LeaveBtn.TabIndex = 6316;
      this.LeaveBtn.Text = "LEAVE";
      this.LeaveBtn.TextColor = Color.White;
      this.LeaveBtn.UseVisualStyleBackColor = true;
      this.LeaveBtn.Click += new EventHandler(this.LeaveBtn_Click);
      this.JoinServerBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.JoinServerBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.JoinServerBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.JoinServerBtn.FlatAppearance.BorderSize = 0;
      this.JoinServerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.JoinServerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.JoinServerBtn.FlatStyle = FlatStyle.Flat;
      this.JoinServerBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.JoinServerBtn.Location = new Point(233, 5);
      this.JoinServerBtn.Name = "JoinServerBtn";
      this.JoinServerBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.JoinServerBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.JoinServerBtn.OnHoverTextColor = Color.White;
      this.JoinServerBtn.Size = new Size(86, 22);
      this.JoinServerBtn.TabIndex = 6315;
      this.JoinServerBtn.Text = "JOIN";
      this.JoinServerBtn.TextColor = Color.White;
      this.JoinServerBtn.UseVisualStyleBackColor = true;
      this.JoinServerBtn.Click += new EventHandler(this.JoinServerBtn_Click_1);
      this.StartEmbedSpammer.BorderColor = Color.FromArgb(105, 105, 205);
      this.StartEmbedSpammer.ButtonColor = Color.FromArgb(105, 105, 205);
      this.StartEmbedSpammer.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.StartEmbedSpammer.FlatAppearance.BorderSize = 0;
      this.StartEmbedSpammer.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.StartEmbedSpammer.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.StartEmbedSpammer.FlatStyle = FlatStyle.Flat;
      this.StartEmbedSpammer.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.StartEmbedSpammer.Location = new Point(178, 5);
      this.StartEmbedSpammer.Name = "StartEmbedSpammer";
      this.StartEmbedSpammer.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.StartEmbedSpammer.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.StartEmbedSpammer.OnHoverTextColor = Color.White;
      this.StartEmbedSpammer.Size = new Size(114, 22);
      this.StartEmbedSpammer.TabIndex = 6314;
      this.StartEmbedSpammer.Text = "Start Spammer";
      this.StartEmbedSpammer.TextColor = Color.White;
      this.StartEmbedSpammer.UseVisualStyleBackColor = true;
      this.StartEmbedSpammer.Click += new EventHandler(this.StartEmbedSpammer_Click);
      this.SpammerBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.SpammerBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.SpammerBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.SpammerBtn.FlatAppearance.BorderSize = 0;
      this.SpammerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.SpammerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.SpammerBtn.FlatStyle = FlatStyle.Flat;
      this.SpammerBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.SpammerBtn.Location = new Point(178, 5);
      this.SpammerBtn.Name = "SpammerBtn";
      this.SpammerBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.SpammerBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.SpammerBtn.OnHoverTextColor = Color.White;
      this.SpammerBtn.Size = new Size(114, 22);
      this.SpammerBtn.TabIndex = 6315;
      this.SpammerBtn.Text = "Start Spammer";
      this.SpammerBtn.TextColor = Color.White;
      this.SpammerBtn.UseVisualStyleBackColor = true;
      this.SpammerBtn.Click += new EventHandler(this.SpammerBtn_Click);
      this.OpenJoinerBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenJoinerBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenJoinerBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenJoinerBtn.FlatAppearance.BorderSize = 0;
      this.OpenJoinerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenJoinerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenJoinerBtn.FlatStyle = FlatStyle.Flat;
      this.OpenJoinerBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenJoinerBtn.Location = new Point(165, 7);
      this.OpenJoinerBtn.Name = "OpenJoinerBtn";
      this.OpenJoinerBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenJoinerBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenJoinerBtn.OnHoverTextColor = Color.White;
      this.OpenJoinerBtn.Size = new Size(75, 22);
      this.OpenJoinerBtn.TabIndex = 6319;
      this.OpenJoinerBtn.Text = "OPEN";
      this.OpenJoinerBtn.TextColor = Color.White;
      this.OpenJoinerBtn.UseVisualStyleBackColor = true;
      this.OpenJoinerBtn.Click += new EventHandler(this.OpenJoinerBtn_Click);
      this.OpenTokenAddBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenTokenAddBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenTokenAddBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenTokenAddBtn.FlatAppearance.BorderSize = 0;
      this.OpenTokenAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenTokenAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenTokenAddBtn.FlatStyle = FlatStyle.Flat;
      this.OpenTokenAddBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenTokenAddBtn.Location = new Point(165, 7);
      this.OpenTokenAddBtn.Name = "OpenTokenAddBtn";
      this.OpenTokenAddBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenTokenAddBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenTokenAddBtn.OnHoverTextColor = Color.White;
      this.OpenTokenAddBtn.Size = new Size(75, 22);
      this.OpenTokenAddBtn.TabIndex = 6320;
      this.OpenTokenAddBtn.Text = "OPEN";
      this.OpenTokenAddBtn.TextColor = Color.White;
      this.OpenTokenAddBtn.UseVisualStyleBackColor = true;
      this.OpenTokenAddBtn.Click += new EventHandler(this.OpenTokenAddBtn_Click);
      this.OpenFriendBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenFriendBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenFriendBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenFriendBtn.FlatAppearance.BorderSize = 0;
      this.OpenFriendBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenFriendBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenFriendBtn.FlatStyle = FlatStyle.Flat;
      this.OpenFriendBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenFriendBtn.Location = new Point(165, 7);
      this.OpenFriendBtn.Name = "OpenFriendBtn";
      this.OpenFriendBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenFriendBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenFriendBtn.OnHoverTextColor = Color.White;
      this.OpenFriendBtn.Size = new Size(75, 22);
      this.OpenFriendBtn.TabIndex = 6320;
      this.OpenFriendBtn.Text = "OPEN";
      this.OpenFriendBtn.TextColor = Color.White;
      this.OpenFriendBtn.UseVisualStyleBackColor = true;
      this.OpenFriendBtn.Click += new EventHandler(this.OpenFriendBtn_Click);
      this.OpenReactorBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenReactorBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenReactorBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenReactorBtn.FlatAppearance.BorderSize = 0;
      this.OpenReactorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenReactorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenReactorBtn.FlatStyle = FlatStyle.Flat;
      this.OpenReactorBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenReactorBtn.Location = new Point(165, 7);
      this.OpenReactorBtn.Name = "OpenReactorBtn";
      this.OpenReactorBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenReactorBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenReactorBtn.OnHoverTextColor = Color.White;
      this.OpenReactorBtn.Size = new Size(75, 22);
      this.OpenReactorBtn.TabIndex = 6320;
      this.OpenReactorBtn.Text = "OPEN";
      this.OpenReactorBtn.TextColor = Color.White;
      this.OpenReactorBtn.UseVisualStyleBackColor = true;
      this.OpenReactorBtn.Click += new EventHandler(this.OpenReactorBtn_Click);
      this.OpenSpammerBtn.BorderColor = Color.FromArgb(105, 105, 205);
      this.OpenSpammerBtn.ButtonColor = Color.FromArgb(105, 105, 205);
      this.OpenSpammerBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 50, 55);
      this.OpenSpammerBtn.FlatAppearance.BorderSize = 0;
      this.OpenSpammerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 50, 55);
      this.OpenSpammerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 50, 55);
      this.OpenSpammerBtn.FlatStyle = FlatStyle.Flat;
      this.OpenSpammerBtn.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold);
      this.OpenSpammerBtn.Location = new Point(165, 7);
      this.OpenSpammerBtn.Name = "OpenSpammerBtn";
      this.OpenSpammerBtn.OnHoverBorderColor = Color.FromArgb(88, 99, 180);
      this.OpenSpammerBtn.OnHoverButtonColor = Color.FromArgb(88, 99, 180);
      this.OpenSpammerBtn.OnHoverTextColor = Color.White;
      this.OpenSpammerBtn.Size = new Size(75, 22);
      this.OpenSpammerBtn.TabIndex = 6320;
      this.OpenSpammerBtn.Text = "OPEN";
      this.OpenSpammerBtn.TextColor = Color.White;
      this.OpenSpammerBtn.UseVisualStyleBackColor = true;
      this.OpenSpammerBtn.Click += new EventHandler(this.OpenSpammerBtn_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(25, 25, 25);
      this.ClientSize = new Size(509, 358);
      this.Controls.Add((Control)this.pictureBox1);
      this.Controls.Add((Control)this.panel14);
      this.Controls.Add((Control)this.HeadLinePnl);
      this.Controls.Add((Control)this.FunctionPnl);
      this.Controls.Add((Control)this.InfosLbl);
      this.Controls.Add((Control)this.RaiderPnl);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(509, 358);
      this.Name = nameof(SpamMain);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Discord Raider";
      this.FormClosing += new FormClosingEventHandler(this.SpamMain_FormClosing);
      this.HeadLinePnl.ResumeLayout(false);
      this.HeadLinePnl.PerformLayout();
      ((ISupportInitialize)this.HeadPic).EndInit();
      this.RaiderPnl.ResumeLayout(false);
      this.RaiderPnl.PerformLayout();
      this.JoinLeavePnl.ResumeLayout(false);
      this.JoinLeavePnl.PerformLayout();
      this.AddTokensPnl.ResumeLayout(false);
      this.AddTokensPnl.PerformLayout();
      this.FriendPnl.ResumeLayout(false);
      this.FriendPnl.PerformLayout();
      this.ReactorPnl.ResumeLayout(false);
      this.ReactorPnl.PerformLayout();
      this.SpammingPnl.ResumeLayout(false);
      this.SpammingPnl.PerformLayout();
      this.FunctionPnl.ResumeLayout(false);
      this.HeadLineFunc.ResumeLayout(false);
      this.HeadLineFunc.PerformLayout();
      this.ModsControl.ResumeLayout(false);
      this.ReactPage.ResumeLayout(false);
      this.MsgReactPnl.ResumeLayout(false);
      this.MsgReactPnl.PerformLayout();
      this.EmojiReactPnl.ResumeLayout(false);
      this.EmojiReactPnl.PerformLayout();
      this.ReactIdPnl.ResumeLayout(false);
      this.ReactIdPnl.PerformLayout();
      this.FriendPage.ResumeLayout(false);
      this.FriendPage.PerformLayout();
      this.RmvPanel.ResumeLayout(false);
      this.RmvPanel.PerformLayout();
      this.AddPnl.ResumeLayout(false);
      this.AddPnl.PerformLayout();
      this.TokensPage.ResumeLayout(false);
      this.TokensPage.PerformLayout();
      this.TokensPnl.ResumeLayout(false);
      this.TokensPnl.PerformLayout();
      this.ErrorPage.ResumeLayout(false);
      this.ErrorPnl.ResumeLayout(false);
      this.ErrorPnl.PerformLayout();
      this.JoinPage.ResumeLayout(false);
      this.JoinPage.PerformLayout();
      this.LeaveID.ResumeLayout(false);
      this.LeaveID.PerformLayout();
      this.InvitePnl.ResumeLayout(false);
      this.InvitePnl.PerformLayout();
      this.SpammingPage.ResumeLayout(false);
      this.SpammingPage.PerformLayout();
      this.EmbedPnl.ResumeLayout(false);
      this.EmbedDescPnl.ResumeLayout(false);
      this.EmbedDescPnl.PerformLayout();
      this.EmbedTitlePnl.ResumeLayout(false);
      this.EmbedTitlePnl.PerformLayout();
      this.EmbedChannelPnl.ResumeLayout(false);
      this.EmbedChannelPnl.PerformLayout();
      this.ChannelSpPnl.ResumeLayout(false);
      this.ChannelSpPnl.PerformLayout();
      this.SpamPnl.ResumeLayout(false);
      this.SpamPnl.PerformLayout();
      this.EmbedPnl2.ResumeLayout(false);
      this.EmbedPnl2.PerformLayout();
      this.SettingsPnl.ResumeLayout(false);
      this.SettingsPnl.PerformLayout();
      this.InfosLbl.ResumeLayout(false);
      this.InfosLbl.PerformLayout();
      this.HeadExtraPnl.ResumeLayout(false);
      this.HeadExtraPnl.PerformLayout();
      ((ISupportInitialize)this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
