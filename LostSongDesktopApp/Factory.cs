using LostSongDesktopAppBackend.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostSongDesktopApp
{
    public static class Factory
    {
        public static IFileTagger CreateFileTagger()
        {
            return new FileTagger();
        }
    }
}
