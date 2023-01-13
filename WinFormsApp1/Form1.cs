using EXTClassLib;
//using SharpExt4;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diskNumber = 1;
            int partitionNumer = 1;
            var filePath = "home";
            listBox1.Items.Add("Clicked on the button");
            var files = EXT4Cls.HitEXT4(filePath, diskNumber, partitionNumer);

            foreach (var item in files)
            {
                listBox1.Items.Add(item);
            }

            //DisplayEXT4FileSystem();

        }

        //void DisplayEXT4FileSystem()
        //{
        //    int diskNumber = 1;
        //    int partitionNumer = 1;
        //    var filePath = "home";
        //    try
        //    {
        //        Console.WriteLine($"Start Executing.... For Disk Number -> {diskNumber}  & Partition Number -> {partitionNumer}");
        //        listBox1.Items.Add($"Start Executing.... For Disk Number -> {diskNumber}  & Partition Number -> {partitionNumer}");
        //        var disk = ExtDisk.Open(diskNumber);
        //        var fs = ExtFileSystem.Open(disk, disk.Partitions[partitionNumer]);
        //        int fileCounter = 0;

        //        //Copy only images from Source to Destination Path.
        //        fileCounter = DisplayFiles(fs, fileCounter, filePath);

        //        Console.Write("\n\n Process completed successfully! Close this command prompt window and remove the card");
        //        Console.Read();

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write($"Process completed with errors! Please check the Log file for errors: ");
        //        Console.Read();
        //    }

        //}

        //int DisplayFiles(ExtFileSystem fs, int fileCounter, string directory)
        //{
        //    int counter = 0;
        //    string fileName = "";
        //    Console.WriteLine($"Source Directory Path : {directory}");
        //    try
        //    {
        //        string[] directories = null;

        //        if (!fs.DirectoryExists(directory))
        //            throw new AccessViolationException($"{directory} is not exist");

        //        directories = fs.GetDirectories(directory, "*", SearchOption.AllDirectories);
        //        if (directories.Length > 0)
        //        {
                    
        //            Console.WriteLine("Available Directoies");
        //            Console.WriteLine("********************");
        //            foreach (var folder in directories)
        //            {
        //                try
        //                {
        //                    listBox1.Items.Add(folder);
        //                   fileCounter = fileCounter + 1;
        //                    Console.WriteLine($"DirectoryName : {folder}");
        //                    counter++;

        //                }
        //                catch (Exception ex)
        //                {
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"There are no sub directoies present under {directory}");
        //        }
        //        return fileCounter;

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}