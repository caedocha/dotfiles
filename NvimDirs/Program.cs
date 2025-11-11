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

var homeDirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config");
Console.WriteLine($"Creating default dirs at '{homeDirPath}'");
if(args.Length > 0 && args.Contains("nuke"))
{
	var nvimDirPath = Path.Combine(homeDirPath, "nvim");
	Console.WriteLine("'nuke' option passed as arg. Nuking nvim config.");
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

Directory.SetCurrentDirectory(homeDirPath);
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
