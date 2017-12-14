using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicTool.Core.Model;
using MusicTool.Core.Service;

namespace MusicTool.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new NoteService();
            var t1 = s.GetMinorSecond(new Note(Key.C));
            var t2 = s.GetMinorSecond(new Note(Key.C,  Alteration.Flat));
            var t3 = s.GetMinorSecond(new Note(Key.C, Alteration.Sharp));
            var t4 = s.GetMinorSecond(new Note(Key.C, Alteration.DoubleFlat));

        }
    }
}
