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
      var help = @"
        Links the existing Nvim in this repo to the default Nvim dir on this machine.
        By default, the config is linked at the '~/.config/' dir on Unix and '~/AppData/Local/' on Windows.
        It won't link the config if there is a config already in the target dir.
        Options:
        --help
        Shows the help section.
        ";
      Console.WriteLine(help);
    }

    public void Execute()
    {
    }
  }
}
