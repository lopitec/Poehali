using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poehali
{
    using System.Collections;
    using System.Windows.Forms;

    interface IStorageService
    {
        void WriteData(ICollection workers, string filename);
        ICollection ReadData(string filename);

    }
}
