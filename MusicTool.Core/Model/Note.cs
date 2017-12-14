using System.Collections.Generic;
using System.Linq;

namespace MusicTool.Core.Model
{
    public class Note
    {
        public Note(Key key, Alteration alteration = Model.Alteration.None)
        {
            Key = key; 
            Alteration = alteration;
        }
        public Key Key { get; set; }
        public Alteration Alteration { get; set; }
    }
}
