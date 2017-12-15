using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;
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
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.C, Alteration.Flat, Key.D, Alteration.DoubleFlat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.C, Alteration.None, Key.D, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.C, Alteration.Sharp, Key.D, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.D, Alteration.Flat, Key.E, Alteration.DoubleFlat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.D, Alteration.None, Key.E, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.D, Alteration.Sharp, Key.E, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.E, Alteration.Flat, Key.F, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.E, Alteration.None, Key.F, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.E, Alteration.Sharp, Key.F, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.F, Alteration.Flat, Key.G, Alteration.DoubleFlat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.F, Alteration.None, Key.G, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.F, Alteration.Sharp, Key.G, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.G, Alteration.Flat, Key.A, Alteration.DoubleFlat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.G, Alteration.None, Key.A, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.G, Alteration.Sharp, Key.A, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.A, Alteration.Flat, Key.B, Alteration.DoubleFlat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.A, Alteration.None, Key.B, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.A, Alteration.Sharp, Key.B, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.B, Alteration.Flat, Key.C, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.B, Alteration.None, Key.C, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Minor, Key.B, Alteration.Sharp, Key.C, Alteration.Sharp)]

        [TestCase(Interval.Second, IntervalQuality.Major, Key.C, Alteration.Flat, Key.D, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.C, Alteration.None, Key.D, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.C, Alteration.Sharp, Key.D, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.D, Alteration.Flat, Key.E, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.D, Alteration.None, Key.E, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.D, Alteration.Sharp, Key.E, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.E, Alteration.Flat, Key.F, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.E, Alteration.None, Key.F, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.E, Alteration.Sharp, Key.F, Alteration.DoubleSharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.F, Alteration.Flat, Key.G, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.F, Alteration.None, Key.G, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.F, Alteration.Sharp, Key.G, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.G, Alteration.Flat, Key.A, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.G, Alteration.None, Key.A, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.G, Alteration.Sharp, Key.A, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.A, Alteration.Flat, Key.B, Alteration.Flat)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.A, Alteration.None, Key.B, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.A, Alteration.Sharp, Key.B, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.B, Alteration.Flat, Key.C, Alteration.None)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.B, Alteration.None, Key.C, Alteration.Sharp)]
        [TestCase(Interval.Second, IntervalQuality.Major, Key.B, Alteration.Sharp, Key.C, Alteration.DoubleSharp)]
        
        [TestCase(Interval.Second, IntervalQuality.Diminished, Key.C, Alteration.None, Key.D, Alteration.DoubleFlat)]
        [TestCase(Interval.Second, IntervalQuality.Augmented, Key.B, Alteration.None, Key.C, Alteration.DoubleSharp)]

        [TestCase(Interval.Third, IntervalQuality.Diminished, Key.A, Alteration.None, Key.C, Alteration.Flat)]
        [TestCase(Interval.Third, IntervalQuality.Minor, Key.D, Alteration.None, Key.F, Alteration.None)]
        [TestCase(Interval.Third, IntervalQuality.Major, Key.E, Alteration.Flat, Key.G, Alteration.None)]
        [TestCase(Interval.Third, IntervalQuality.Augmented, Key.B, Alteration.Sharp, Key.D, Alteration.TripleSharp)]

        [TestCase(Interval.Fourth, IntervalQuality.Diminished, Key.A, Alteration.None, Key.D, Alteration.Flat)]
        [TestCase(Interval.Fourth, IntervalQuality.Perfect, Key.E, Alteration.Flat, Key.A, Alteration.Flat)]
        [TestCase(Interval.Fourth, IntervalQuality.Augmented, Key.B, Alteration.Sharp, Key.E, Alteration.DoubleSharp)]

        [TestCase(Interval.Fifth, IntervalQuality.Diminished, Key.A, Alteration.None, Key.E, Alteration.Flat)]
        [TestCase(Interval.Fifth, IntervalQuality.Perfect, Key.E, Alteration.Flat, Key.B, Alteration.Flat)]
        [TestCase(Interval.Fifth, IntervalQuality.Augmented, Key.B, Alteration.Sharp, Key.F, Alteration.TripleSharp)]

        [TestCase(Interval.Sixth, IntervalQuality.Diminished, Key.A, Alteration.None, Key.F, Alteration.Flat)]
        [TestCase(Interval.Sixth, IntervalQuality.Minor, Key.D, Alteration.None, Key.B, Alteration.Flat)]
        [TestCase(Interval.Sixth, IntervalQuality.Major, Key.E, Alteration.Flat, Key.C, Alteration.None)]
        [TestCase(Interval.Sixth, IntervalQuality.Augmented, Key.B, Alteration.Sharp, Key.G, Alteration.TripleSharp)]

        [TestCase(Interval.Seventh, IntervalQuality.Diminished, Key.A, Alteration.None, Key.G, Alteration.Flat)]
        [TestCase(Interval.Seventh, IntervalQuality.Minor, Key.D, Alteration.None, Key.C, Alteration.None)]
        [TestCase(Interval.Seventh, IntervalQuality.Major, Key.E, Alteration.Flat, Key.D, Alteration.None)]
        [TestCase(Interval.Seventh, IntervalQuality.Augmented, Key.B, Alteration.Sharp, Key.A, Alteration.TripleSharp)]
        public void Test_GetByInterval(Interval interval, IntervalQuality intervalQuality, Key inputKey, Alteration inputAlteration, Key expectedKey, Alteration expectedAlteration)
        {
            var result = _noteService.GetByInterval(new Note(inputKey, inputAlteration), interval, intervalQuality);
            Assert.That(result.Key, Is.EqualTo(expectedKey));
            Assert.That(result.Alteration, Is.EqualTo(expectedAlteration));
        }

    }
}
