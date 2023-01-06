using SampleBlazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlazor.Core
{
    internal interface IBusiness
    {
        Task FileSelection(FolderHierarchy FolderFileHierarchy, InputFile inputFile);
    }
}
