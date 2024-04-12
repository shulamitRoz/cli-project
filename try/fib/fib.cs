
using System.CommandLine;
using System.IO;
using System.Linq;
//private static string RemoveEmptyLines(string content)
//{
//    return string.Join(Environment.NewLine, content.Split('\n').Where(line => !string.IsNullOrWhiteSpace(line.Trim())));
//}

var bundleCommand = new Command("bundle", "Bundle code files");

var outputOptin = new Option<FileInfo>("--output", "file path and name");
outputOptin.AddAlias("--o");


var languageOption = new Option<string>("--language", "packs all files into one file") { IsRequired = true };
languageOption.AddAlias("--lang");

var noteOption = new Option<bool>("--note", "Add note whit file path");
noteOption.AddAlias("--n");

var signOption = new Option<string>("--sign", "sign for the note");
signOption.AddAlias("--si");

var removEmptyLineOption = new Option<bool>("--remove-empty-lines", "Remove empty liner from file contens");
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

bundleCommand.SetHandler<FileInfo, string, bool, string, bool, bool, string>((output, language,note, sign, removeEmptyLine, sort, auther) =>

{
    string[] languageArr = { "java", "javaScript", "python", "c#", "c++", "react" };

    try
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        List<string> files = new List<string>();
        //string[] files;
        if (language.ToLower() == "all")
        {
            //List<string> fileList = new List<string>();
            foreach (string lang in languageArr)
            {
                //files = Directory.GetFiles(currentDirectory, $"*.{lang}");
                // files.Append(Directory.GetFiles(currentDirectory, $"*.{lang}").ToArray();
                //fileList.ToList<string>().AddRange(Directory.GetFiles(currentDirectory, $"*.{lang}").ToArray()
                files.AddRange(Directory.GetFiles(currentDirectory, $"*.{lang}"));
            }


        }
        else
        {
            files.AddRange(Directory.GetFiles(currentDirectory, $"*.{language}"));
        }
        if (sort)
        {

            //files = files.OrderBy(f => Path.GetExtension(f)).ToArray();
            //files=Directory.GetFiles(Directory.GetCurrentDirectory()).OrderBy(file => Path.GetExtension(file),)

            //files = Directory.GetFiles(Directory.GetCurrentDirectory()).OrderBy(file => Path.GetExtension(file), StringComparer.OrdinalIgnoreCase)
            //    .ToArray();
            files = Directory.GetFiles(Directory.GetCurrentDirectory()).OrderBy(file => Path.GetExtension(file), StringComparer.OrdinalIgnoreCase).ToList();
        }

        //if (sort)
        //{
        //    files = files.OrderBy(f => Path.GetExtension(f)).ToList();

        //}
        //else
        //{
        //    files.Sort();

        //}
        using (StreamWriter outputFile = new StreamWriter(output.FullName)) //משמש לכתיבת תוכן לקובץ בצורה בטוחה כך שמשאבי הקובץ ייסגרו אוטומטית כשיטוצאים מבלוק הקוד
            {

                if (auther != "")
                {
                    outputFile.WriteLine($"Auther:{auther}");
                    //outputFile.WriteLine();
                }

                foreach (string file in files)
                {

                    if (note)//תוסיף לי את המקור של הקובץ
                    {

                        Console.WriteLine("note work");
                        string Note = Path.GetFullPath(file);
                        File.AppendAllText(output.FullName, Note);
                        File.AppendAllText(output.FullName, Environment.NewLine);

                    }

                    string fileContens = File.ReadAllText(file);

                    //if (removeEmptyLine)
                    //{
                    //    fileContents = RemoveEmptyLines(fileContents);
                    //}

                    //outputFile.WriteLine($"File:{file}\n{fileContens}\n");
                    outputFile.WriteLine($"File:{fileContens}\n");
                    Console.WriteLine("you create file seccesfoly");
                }
            }
        
    }

    catch (DirectoryNotFoundException ex)
    {

        Console.WriteLine(" Error: file path is invalid");

    }

}, outputOptin, languageOption,  noteOption, signOption, sortOption, removEmptyLineOption, autherOption);


var rootCommand = new RootCommand("Root command for");

rootCommand.AddCommand(bundleCommand);
rootCommand.InvokeAsync(args);
