
using System.CommandLine;

var bundleCommand = new Command("bundle", "Bundle code files");

var outputOptin = new Option<FileInfo>("--output", "file path and name");
outputOptin.AddAlias("--o");

string[] language = { "java", "javaScript", "python", "c#", "c", "c++", "react" };

var languageOption = new Option<string>("--language", "packs all files into one file") { IsRequired = true };
languageOption.AddAlias("--lang");

var noteOption = new Option<bool>("--note", "Add note whit file path");
noteOption.AddAlias("--n");

var removEmptyLineOption = new Option<string>("--sign", "sign for the note");
signOption.AddAlias("--si");

var signOption = new Option<bool>("--remove-empty-lines", "Remove empty liner from file contens");
removEmptyLineOption.AddAlias("--rel");

var sortOption = new Option<bool>("--sort", "Sort file order by alphabetically");
sortOption.AddAlias("--srt");

var autherOption = new Option<string>("--auther", "Auther name for bundle file");
autherOption.AddAlias("--a");

bundleCommand.AddOption(outputOptin);
bundleCommand.AddOption(languageOption);
bundleCommand.AddOption(noteOption);
bundleCommand.AddOption(signOption);
bundleCommand.AddOption(sortOption);
bundleCommand.AddOption(autherOption);

bundleCommand.SetHandler<FileInfo,string,bool,string,bool,bool,string>((output, language,note,sign,removeEmptyLine,sort,auther) => 

{
    try
    {
        string[] files;
        if (language.ToLower() == "all")
        {

            files = Directory.GetFiles(Directory.GetCurrentDirectory());
        }
        else
        {
            files = Directory.GetFiles(Directory.GetCurrentDirectory(), $"*.{language}");
        }
        if (sort)
        {
            files = files.OrderBy(f => f).ToArray();
        }

        using (StreamWriter outputFile = new StreamWriter(output.FullName)) //משמש לכתיבת תוכן לקובץ בצורה בטוחה כך שמשאבי הקובץ ייסגרו אוטומטית כשיטוצאים מבלוק הקוד
        {
         

            if (auther!="")
            {
                outputFile.WriteLine($"Auther:{auther}");
                outputFile.WriteLine();
            }

            foreach (string file in files)
            {
                if (note)
                {
                    string Note = Path.GetFullPath(file);
                    file.AppendAllText(output.FullName, sign + Note);
                    file.AppendAllText(output.FullName, Environment.NewLine);
                }

                string fileContens = File.ReadAllText(file);

                if (removeEmptyLine)
                {
                    fileContens = removeEmptyLine(fileContens);
                }
                outputFile.WriteLine($"File:{file}\n{fileContens}\n");
            }
        }
    }
    catch (DirectoryNotFoundException ex)
    {
        Console.WriteLine(" Error: file path is invalid");
    }



}, outputOptin, languageOption,noteOption,signOption,sortOption,removEmptyLineOption,autherOption);


var rootCommand = new RootCommand("Root command for");

rootCommand.AddCommand(bundleCommand);
rootCommand.InvokeAsync(args);
