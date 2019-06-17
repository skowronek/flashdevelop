﻿using System.IO;

namespace SourceControl.Sources.Subversion
{
    class MoveCommand : BaseCommand
    {
        public MoveCommand(string fromPath, string toPath)
        {
            string args = string.Format("move \"{0}\" \"{1}\"", Path.GetFileName(fromPath), toPath);

            Run(args, Path.GetDirectoryName(fromPath));
        }
    }
}
