using System;
using System.Windows.Forms;

namespace DiscordRaider
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new DiscordRaider.Main());
    }
  }
}
