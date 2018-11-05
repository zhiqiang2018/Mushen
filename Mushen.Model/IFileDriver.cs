using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mushen.Fuwen
{
    public interface IFileDriver
    {
        void WriteRow(string[] row);

        void WriteCell(object val, bool isEnd);

        void End();

        void AddWorksheet(string name);
    }
}
