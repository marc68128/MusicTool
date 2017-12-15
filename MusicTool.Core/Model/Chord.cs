using System;
using System.Collections.Generic;
using MusicTool.Core.Model.Enum;

namespace MusicTool.Core.Model
{
    public class Chord
    {
        public Chord(ChordQuality chordType, params Note[] notes)
        {
            ChordType = chordType;
            Notes = notes;
        }

        public ChordQuality ChordType { get; set; }
        public Note[] Notes { get; set; }
    }
}
