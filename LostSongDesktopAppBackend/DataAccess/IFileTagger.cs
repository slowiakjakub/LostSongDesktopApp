using LostSongDesktopAppBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostSongDesktopAppBackend.DataAccess
{
    public interface IFileTagger
    {
        void TagFile(string filePath, LookupResponseModel lookupResponse);
    }
}
