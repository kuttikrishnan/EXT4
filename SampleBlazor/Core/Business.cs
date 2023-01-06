using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleBlazor.Model;

namespace SampleBlazor.Core
{
    public class Business : IBusiness
    {
        public Task FileSelection(FolderHierarchy FolderFileHierarchy, InputFile inputFile)
        {
            var subFolder = FolderFileHierarchy.subFolders.SelectMany(x => x.subFolders).Where(x => x.Name == inputFile.Name);
            var folders = subFolder.SelectMany(x => x.subFolders);
            foreach (var folder in folders)
            {
                folder.IsSelected = inputFile.isSelected;
                foreach (var file in folder.Files)
                {
                    file.IsSelected = inputFile.isSelected;
                }
            }

            var files = subFolder.SelectMany(x => x.Files);
            foreach (var file in files)
            {
                file.IsSelected = inputFile.isSelected;
            }

            return Task.CompletedTask;
        }
    }
}
