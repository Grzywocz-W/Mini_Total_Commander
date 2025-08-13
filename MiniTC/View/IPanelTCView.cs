using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MiniTC.Views
{
    public interface IPanelTCView
    {
        void SetDrives(List<string> drives);
        void SetDirectoryContent(List<string> items);
        string CurrentPath { get; set; }
    }
}
