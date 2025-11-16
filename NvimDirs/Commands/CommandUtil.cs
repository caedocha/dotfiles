namespace Commands
{
  public class CommandUtils
  {
    public static IList<ICommand> GetValidCommands()
    {
      return new List<ICommand> { new CreateCommand() }.ToList();
    }
    public static IList<string> GetValidCommandNames()
    {
      return GetValidCommands()
        .Select(cmd => cmd.CommandName)
        .ToList();
    }
  }
}
