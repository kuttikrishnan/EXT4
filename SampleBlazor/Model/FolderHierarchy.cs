using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlazor.Model
{
    public class FolderHierarchy
    {
        public string Name { get; set; }

        public List<FolderHierarchy> subFolders { get; set; }

        public List<FileData> Files { get; set; }

        public bool IsSelected { get; set; }
    }
}
