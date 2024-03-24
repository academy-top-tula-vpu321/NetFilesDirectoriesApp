using System.Text;

DriveInfo[] drivesArr = DriveInfo.GetDrives();

List<DriveInfo> drives = new List<DriveInfo>(drivesArr);

foreach (DriveInfo drive in drives)
{
    Console.WriteLine($"Name: {drive.Name}");
    Console.WriteLine($"Type: {drive.DriveType}");
    if(drive.IsReady)
    {
        Console.WriteLine($"\tLabel: {drive.VolumeLabel}");
        Console.WriteLine($"\tTotal size: {drive.TotalSize}");
        Console.WriteLine($"\tFree size: {drive.TotalFreeSpace}\n");


        // class Directory
        //Console.WriteLine("\tDirectories:");
        //string[] dirs = Directory.GetDirectories(drive.Name, "*");
        //foreach (string dir in dirs)
        //    Console.WriteLine($"\t\t{dir}");

        //Console.WriteLine("\tFiles:");
        //string[] files = Directory.GetFiles(drive.Name);
        //foreach (string file in files)
        //    Console.WriteLine($"\t\t{file}");

        // class DirectoryInfo
        DirectoryInfo dir = new DirectoryInfo(drive.Name);
        //if(dir.Exists)
        //{
        //    Console.WriteLine("Directories:");
        //    DirectoryInfo[] dirs = dir.GetDirectories();
        //    foreach(DirectoryInfo d in dirs)
        //        Console.WriteLine($"\t\t{d.Name} / {d.FullName}");

        //    Console.WriteLine("Files:");
        //    FileInfo[] files = dir.GetFiles();
        //    foreach(FileInfo f in files)
        //        Console.WriteLine($"\t\t{f.Name} / {f.FullName}");
        //}



        //string subdirName = @"Dir\Subdir";

        //Directory.CreateDirectory(dirName);
        //Directory.CreateDirectory(subdirName);
        //DirectoryInfo dir = new DirectoryInfo(dirName);
        //if (!dir.Exists)
        //    dir.Create();
        //DirectoryInfo subdir = new DirectoryInfo(subdirName);
        //if (!subdir.Exists)
        //    subdir.Create();

        //if (dir.Exists)
        //    dir.Delete(true);

        //FileInfo[] file = dir.GetFiles();
        //foreach(FileInfo f in file)
        //{
        //    Console.WriteLine($"Name: {f.Name}");
        //    Console.WriteLine($"Name: {f.FullName}");
        //    Console.WriteLine($"Name: {f.Extension}");
        //    Console.WriteLine($"Name: {f.Directory}");
        //    Console.WriteLine($"Name: {f.CreationTime}");
        //    Console.WriteLine($"Name: {f.LastWriteTime}");
        //    Console.WriteLine($"Name: {f.Length}");
        //}

    }
}

//string dirName = @"D:\MyFolder";
string fileName = "file01.dat";

//File.WriteAllText(fileName, "Hello people");
//File.AppendAllText(fileName, "\nHello all");

//string[] dirs = Directory.GetDirectories(@"C:/");
//File.WriteAllLines(fileName, dirs);

File.WriteAllText(fileName, "Привет мир", Encoding.UTF8);

//var dirs = File.ReadAllText(fileName);
//foreach(string dir in dirs)
//Console.WriteLine(dirs);

//int number = 123;
//File.WriteAllBytes(fileName, BitConverter.GetBytes(number));

//var f = File.Create(fileName);
//f.Close();

//File.Move(fileName, "myfile02.ddd");

//File.Delete(fileName);
