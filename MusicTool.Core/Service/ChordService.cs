using System;
using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;

namespace MusicTool.Core.Service
{
    public class ChordService
    {
        private NoteService _noteService;

        public ChordService(NoteService noteService = null)
        {
            _noteService = noteService ?? new NoteService();
        }

        public Chord GetChord(Note tonic, ChordQuality chordQuality)
        {
            switch (chordQuality)
            {
                case ChordQuality.Maj:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Third, IntervalQuality.Major), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Perfect));
                case ChordQuality.Min:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Third, IntervalQuality.Minor), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Perfect));
                case ChordQuality.Sus2:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Second, IntervalQuality.Major), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Perfect));
                case ChordQuality.Sus4:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Fourth, IntervalQuality.Perfect), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Perfect));
                case ChordQuality.MajB5:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Third, IntervalQuality.Major), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Diminished));
                case ChordQuality.Dim:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Third, IntervalQuality.Minor), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Diminished));
                case ChordQuality.Aug:
                    return new Chord(chordQuality, 
                        tonic, 
                        _noteService.GetByInterval(tonic, Interval.Third, IntervalQuality.Major), 
                        _noteService.GetByInterval(tonic, Interval.Fifth, IntervalQuality.Augmented));
                default:
                    throw new ArgumentOutOfRangeException(nameof(chordQuality), chordQuality, null);
            }
        }
    }
}
