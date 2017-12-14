using MusicTool.Core.Model;
using MusicTool.Core.Service;
using NUnit.Framework;

namespace MusicTool.Core.Test
{
    [TestFixture]
    class NoteServiceTest
    {
        private NoteService _noteService;

        [SetUp]
        public void SetUp()
        {
            _noteService = new NoteService();
        } 

        [Test]
        [TestCase(Key.C, Alteration.Flat, Key.D, Alteration.DoubleFlat)]
        [TestCase(Key.C, Alteration.None, Key.D, Alteration.Flat)]
        [TestCase(Key.C, Alteration.Sharp, Key.D, Alteration.None)]
        [TestCase(Key.D, Alteration.Flat, Key.E, Alteration.DoubleFlat)]
        [TestCase(Key.D, Alteration.None, Key.E, Alteration.Flat)]
        [TestCase(Key.D, Alteration.Sharp, Key.E, Alteration.None)]
        [TestCase(Key.E, Alteration.Flat, Key.F, Alteration.Flat)]
        [TestCase(Key.E, Alteration.None, Key.F, Alteration.None)]
        [TestCase(Key.E, Alteration.Sharp, Key.F, Alteration.Sharp)]
        [TestCase(Key.F, Alteration.Flat, Key.G, Alteration.DoubleFlat)]
        [TestCase(Key.F, Alteration.None, Key.G, Alteration.Flat)]
        [TestCase(Key.F, Alteration.Sharp, Key.G, Alteration.None)]
        [TestCase(Key.G, Alteration.Flat, Key.A, Alteration.DoubleFlat)]
        [TestCase(Key.G, Alteration.None, Key.A, Alteration.Flat)]
        [TestCase(Key.G, Alteration.Sharp, Key.A, Alteration.None)]
        [TestCase(Key.A, Alteration.Flat, Key.B, Alteration.DoubleFlat)]
        [TestCase(Key.A, Alteration.None, Key.B, Alteration.Flat)]
        [TestCase(Key.A, Alteration.Sharp, Key.B, Alteration.None)]
        [TestCase(Key.B, Alteration.Flat, Key.C, Alteration.Flat)]
        [TestCase(Key.B, Alteration.None, Key.C, Alteration.None)]
        [TestCase(Key.B, Alteration.Sharp, Key.C, Alteration.Sharp)]
        public void Test_GetMinorSecond(Key inputKey, Alteration inputAlteration, Key expectedKey, Alteration expectedAlteration)
        {
            var minorSecond = _noteService.GetMinorSecond(new Note(inputKey, inputAlteration));
            Assert.That(minorSecond.Key, Is.EqualTo(expectedKey));
            Assert.That(minorSecond.Alteration, Is.EqualTo(expectedAlteration));
        }

        [Test]
        [TestCase(Key.C, Alteration.Flat, Key.D, Alteration.Flat)]
        [TestCase(Key.C, Alteration.None, Key.D, Alteration.None)]
        [TestCase(Key.C, Alteration.Sharp, Key.D, Alteration.Sharp)]
        [TestCase(Key.D, Alteration.Flat, Key.E, Alteration.Flat)]
        [TestCase(Key.D, Alteration.None, Key.E, Alteration.None)]
        [TestCase(Key.D, Alteration.Sharp, Key.E, Alteration.Sharp)]
        [TestCase(Key.E, Alteration.Flat, Key.F, Alteration.None)]
        [TestCase(Key.E, Alteration.None, Key.F, Alteration.Sharp)]
        [TestCase(Key.E, Alteration.Sharp, Key.F, Alteration.DoubleSharp)]
        [TestCase(Key.F, Alteration.Flat, Key.G, Alteration.Flat)]
        [TestCase(Key.F, Alteration.None, Key.G, Alteration.None)]
        [TestCase(Key.F, Alteration.Sharp, Key.G, Alteration.Sharp)]
        [TestCase(Key.G, Alteration.Flat, Key.A, Alteration.Flat)]
        [TestCase(Key.G, Alteration.None, Key.A, Alteration.None)]
        [TestCase(Key.G, Alteration.Sharp, Key.A, Alteration.Sharp)]
        [TestCase(Key.A, Alteration.Flat, Key.B, Alteration.Flat)]
        [TestCase(Key.A, Alteration.None, Key.B, Alteration.None)]
        [TestCase(Key.A, Alteration.Sharp, Key.B, Alteration.Sharp)]
        [TestCase(Key.B, Alteration.Flat, Key.C, Alteration.None)]
        [TestCase(Key.B, Alteration.None, Key.C, Alteration.Sharp)]
        [TestCase(Key.B, Alteration.Sharp, Key.C, Alteration.DoubleSharp)]
        public void Test_GetMajorSecond(Key inputKey, Alteration inputAlteration, Key expectedKey, Alteration expectedAlteration)
        {
            var majorSecond = _noteService.GetMajorSecond(new Note(inputKey, inputAlteration));
            Assert.That(majorSecond.Key, Is.EqualTo(expectedKey));
            Assert.That(majorSecond.Alteration, Is.EqualTo(expectedAlteration));
        }


    }
}
