using SharpExt4;
namespace EXTClassLib
{
    public static class EXT4Cls
    {
        public static string[] HitEXT4(string dirName,int diskNumber, int partionNumber)
        {
            var disk = ExtDisk.Open(diskNumber);
            var fs = ExtFileSystem.Open(disk, disk.Partitions[partionNumber]);
            var directories = fs.GetDirectories($"/{dirName}/", "*", SearchOption.AllDirectories);
            var files = fs.GetFiles(dirName, "*", SearchOption.TopDirectoryOnly);
            return directories;
        }
    }
}