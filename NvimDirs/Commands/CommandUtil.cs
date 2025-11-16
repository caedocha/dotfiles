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
  }
}
