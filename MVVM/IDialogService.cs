using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    internal interface IDialogService
    {

        void ShowMassage(string massage);

        string FilePath { get; set; }

        bool OpenFileDialog();

        bool SaveFileDialog();
    }
}
