using System.Collections.Generic;
using System.Linq;
using Commands;

namespace Extensions
{
  public static class DictionaryExtensions
  {

    public static IList<string> GetCommandKeys(this IDictionary<string, string?> args)
    {
      var validCommands = CommandUtils.GetValidCommandNames();
      var cmds = args
        .Where(arg => validCommands.Contains(arg.Key))
        .Select(arg => arg.Key)
        .ToList();

      return cmds;
    }

    public static bool HasCommands(this IDictionary<string, string?> args)
    {
      var keys = args.GetCommandKeys();

      return keys.Count >= 1;
    }

    public static bool HasMultipleCommands(this IDictionary<string, string?> args)
    {
      var keys = args.GetCommandKeys();

      return keys.Count >= 2;
    }

    public static string GetCommand(this IDictionary<string, string?> args)
    {
      return args.GetCommandKeys().FirstOrDefault();
    }
  }
}
