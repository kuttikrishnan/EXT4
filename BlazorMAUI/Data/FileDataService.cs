using BlazorMAUI.Helper;
using BlazorMAUI.Model;
namespace SampleBlazor.Data
{
    public class FileDataService
    {
        public async Task<bool> FileSelectionAsync(FolderHierarchy FolderFileHierarchy, InputFile inputFile)
        {
            await UpdateFileSelection(FolderFileHierarchy, inputFile);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateFileSelection(FolderHierarchy fh, InputFile inputFile)
        {
            foreach (var file in fh.Files)
            {
                file.IsSelected = inputFile.isSelected;
                Console.WriteLine(file.FileName);
            }

            foreach (var folder in fh.subFolders)
            {
                folder.IsSelected = inputFile.isSelected;
                await UpdateFileSelection(folder, inputFile);
            }

            return await Task.FromResult(true);
        }
    }
}
