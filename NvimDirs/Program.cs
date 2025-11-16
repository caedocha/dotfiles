using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Commands;
using Extensions;

static Dictionary<string, string?> ParseArgs(string[] args)
{
	var parsedArgs = new Dictionary<string, string?>();
	foreach(var arg in args)
	{
		var splittedArgs = arg.Split("=");
		if(splittedArgs.Length >= 2)
		{
			parsedArgs.Add(splittedArgs[0], splittedArgs[1]);
		}
		else
		{
			parsedArgs.Add(splittedArgs[0], null);
		}
	}
	return parsedArgs;
}

static void PrintHelp()
{
	var help = @"
		NvimDirs is a command line tool that automates chores involved in creating and maintaining a nvim config. I made it for fun.
		Options:
		create
			Create a brand new Nvim config.
		link
			Links an existing Nvim config.
		";
	Console.WriteLine(help);
}

var parsedArgs = ParseArgs(args);

if(parsedArgs.HasCommands())
{
  if(parsedArgs.HasMultipleCommands())
  {
    Console.WriteLine("You are trying to run multiple commands at the same time. Pick one.");
  }
  else
  {
    ICommand command = parsedArgs.GetCommand() switch
    {
      "create" => new CreateCommand(parsedArgs),
      "link" => new LinkCommand(parsedArgs),
      _ => throw new ArgumentException(nameof(command))
    };
    command.Execute();
  }
}
else
{
  if(parsedArgs.ContainsKey("--help"))
  {
    PrintHelp();
  }
  else
  { 
    Console.WriteLine("I don't know what to do. Try running me with '--help'.");
  }
}
