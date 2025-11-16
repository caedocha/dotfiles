namespace Commands
{
  public class CommandUtils
  {
    public static IList<string> GetValidCommandNames()
    {
      return new List<ICommand> { new CreateCommand() }
        .Select(cmd => cmd.CommandName)
        .ToList();
    }
  }
}
