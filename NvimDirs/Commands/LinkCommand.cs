using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Commands
{
  public class LinkCommand : ICommand
  {
    public string CommandName => "link";

    private IDictionary<string, string?> Args { get; }

    public LinkCommand()
    {
    }

    public LinkCommand(IDictionary<string, string?> args)
    {
      Args = args;
    }

    public void Help()
    {
    }

    public void Execute()
    {
    }
  }
}
