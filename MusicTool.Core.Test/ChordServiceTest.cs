using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;
using MusicTool.Core.Service;
using NUnit.Framework;

namespace MusicTool.Core.Test
{
    [TestFixture]
    class ChordServiceTest
    {
        private ChordService _chordService;

        [SetUp]
        public void SetUp()
        {
            _chordService = new ChordService();
        }

        [Test]
        [TestCase(Key.C, Alteration.None, ChordQuality.Maj, Key.C, Alteration.None, Key.E, Alteration.None, Key.G, Alteration.None)]
        [TestCase(Key.D, Alteration.Sharp, ChordQuality.Min, Key.D, Alteration.Sharp, Key.F, Alteration.Sharp, Key.A, Alteration.Sharp)]
        [TestCase(Key.E, Alteration.Flat, ChordQuality.Aug, Key.E, Alteration.Flat, Key.G, Alteration.None, Key.B, Alteration.None)]
        [TestCase(Key.F, Alteration.None, ChordQuality.Dim, Key.F, Alteration.None, Key.A, Alteration.Flat, Key.C, Alteration.Flat)]
        [TestCase(Key.G, Alteration.Sharp, ChordQuality.MajB5, Key.G, Alteration.Sharp, Key.B, Alteration.Sharp, Key.D, Alteration.None)]
        [TestCase(Key.A, Alteration.Flat, ChordQuality.Sus2, Key.A, Alteration.Flat, Key.B, Alteration.Flat, Key.E, Alteration.Flat)]
        [TestCase(Key.B, Alteration.None, ChordQuality.Sus4, Key.B, Alteration.None, Key.E, Alteration.None, Key.F, Alteration.Sharp)]
        public void Test_GetChordTriade(Key tonic, Alteration tonicAlteration, ChordQuality chordQuality, 
            Key expectedNoteKey1, Alteration expectedNoteAlteration1, 
            Key expectedNoteKey2, Alteration expectedNoteAlteration2, 
            Key expectedNoteKey3, Alteration expectedNoteAlteration3)
        {
            var chord = _chordService.GetChord(new Note(tonic, tonicAlteration), chordQuality);
            var expectedNotes = new []
            {
                new Note(expectedNoteKey1, expectedNoteAlteration1),
                new Note(expectedNoteKey2, expectedNoteAlteration2),
                new Note(expectedNoteKey3, expectedNoteAlteration3)
            };
        
            Assert.That(chord.Notes.Length, Is.EqualTo(expectedNotes.Length));

            foreach (var expectedNote in expectedNotes)
            {
                Assert.Contains(expectedNote, chord.Notes);
            }
        }
    }
}
