using System.IO;
using System.Runtime.InteropServices;

namespace Commands
{
  public class CommandUtils
  {
    public static IList<ICommand> GetValidCommands()
    {
      return new List<ICommand> { new CreateCommand(), new LinkCommand() }.ToList();
    }

    public static IList<string> GetValidCommandNames()
    {
      return GetValidCommands()
        .Select(cmd => cmd.CommandName)
        .ToList();
    }

    public static string GetHomeDirPath()
    {
      var userDirPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
      var configPath = ".config";

      if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
      {
        configPath = "AppData/Local/";
      }
      var homeDirPath = Path.Combine(userDirPath, configPath);

      return homeDirPath;
    }
  }
}
