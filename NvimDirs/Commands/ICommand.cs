namespace Commands
{
  public interface ICommand
  {
    public string CommandName { get; }
    public void Help();
    public void Execute();
  }
}
