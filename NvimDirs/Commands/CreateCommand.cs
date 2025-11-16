using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Commands
{
  public class CreateCommand : ICommand
  {
    public string CommandName => "create";

    private IDictionary<string, string?> Args { get; }

    public CreateCommand()
    {
    }

    public CreateCommand(IDictionary<string, string?> args)
    {
      Args = args;
    }

    public void Help()
    {
      var help = @"
        Creates a brand new Nvim config with a set of default dirs and empty init files.
        By default, the config is created at the '~/.config/' dir on Unix and '~/AppData/Local/' on Windows.
        It won't create the config if there is a config already in the target dir.
        Options:
        --homeDirOverride
        Overrides the directory where the nvim config is going to be created.
        --nuke
        Deletes the entire nvim config.
        --help
        Shows the help section.
        ";
      Console.WriteLine(help);
    }

    public void Execute()
    {
      var homeDirPath = GetHomeDirPath();

      Console.WriteLine($"Creating default dirs at '{homeDirPath}'");
      if(Args.Count > 0 && Args.ContainsKey("--nuke"))
      {
        var nvimDirPath = Path.Combine(homeDirPath, "nvim");
        Console.WriteLine("'--nuke' option passed as arg. Nuking nvim config.");
        if(Directory.Exists(nvimDirPath))
        {
          Directory.Delete(nvimDirPath, recursive: true);
          Console.WriteLine($"Deleted nvim config at '{nvimDirPath}'.");
        }
        else
        {
          Console.WriteLine($"Can't nuke, nvim config at '{nvimDirPath}' does not exist.");
        }
      }

      if(Args.ContainsKey("--homeDirOverride") && Args.TryGetValue("--homeDirOverride", out var newHomeDirPath))
      {
        Console.WriteLine($"'--homDireOverride' is present. The nvim config will be create in '{newHomeDirPath}'");
        Directory.SetCurrentDirectory(newHomeDirPath);
      }
      else
      {
        Directory.SetCurrentDirectory(homeDirPath);
      }
      CreateDirIfNotExist("nvim");
      Directory.SetCurrentDirectory("nvim");
      CreateFileIfNotExist("init.lua");
      CreateDirIfNotExist("lua");
      CreateDirIfNotExist("after");
      Directory.SetCurrentDirectory("lua");
      CreateDirIfNotExist("fanky");
      Directory.SetCurrentDirectory("fanky");
      CreateFileIfNotExist("init.lua");
      Directory.SetCurrentDirectory("../..");
      CreateDirIfNotExist("plugin");
      Console.WriteLine("Done");
    }

    private string GetHomeDirPath()
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

    private void CreateFileIfNotExist(string fileName)
    {
      if(!File.Exists(fileName))
      {

        Console.WriteLine($"Creating '{fileName}' file");
        File.Create(fileName).Dispose();
      }
      else
      {
        Console.WriteLine($"'{fileName}' dir already exists.");
      }
    }

    private void CreateDirIfNotExist(string dirName)
    {
      if(!Directory.Exists(dirName))
      {
        Console.WriteLine($"Creating '{dirName}' dir");
        var nvim = Directory.CreateDirectory(dirName);
      }
      else
      {
        Console.WriteLine($"'{dirName}' dir already exists.");
      }
    }
  }
}
