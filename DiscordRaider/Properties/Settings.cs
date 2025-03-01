using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DiscordRaider.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default => Settings.defaultInstance;

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string BotToken
    {
      get => (string) this[nameof (BotToken)];
      set => this[nameof (BotToken)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("")]
    [DebuggerNonUserCode]
    public string _TokenPath
    {
      get => (string) this[nameof (_TokenPath)];
      set => this[nameof (_TokenPath)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool _SaveTokens
    {
      get => (bool) this[nameof (_SaveTokens)];
      set => this[nameof (_SaveTokens)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public bool _HideTokens
    {
      get => (bool) this[nameof (_HideTokens)];
      set => this[nameof (_HideTokens)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("False")]
    public bool _GiveCredits
    {
      get => (bool) this[nameof (_GiveCredits)];
      set => this[nameof (_GiveCredits)] = (object) value;
    }
  }
}
