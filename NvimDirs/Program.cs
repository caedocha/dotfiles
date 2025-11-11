using System;
using System.IO;

static void CreateFileIfNotExist(string fileName)
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

static void CreateDirIfNotExist(string dirName)
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
		--homeDirOverride
			Overrides the directory where the nvim config is going to be created.
			The default is the '~/.config/' dir.
		--nuke
			Deletes the entire nvim config.
		-- help
			Shows the help section.
		";
	Console.WriteLine(help);
}

var parsedArgs = ParseArgs(args);

if(parsedArgs.ContainsKey("--help"))
{
	PrintHelp();
	return;
}

var homeDirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config");
Console.WriteLine($"Creating default dirs at '{homeDirPath}'");
if(args.Length > 0 && args.Contains("--nuke"))
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

if(parsedArgs.ContainsKey("homeDirOverride") && parsedArgs.TryGetValue("homeDirOverride", out var newHomeDirPath))
{
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
