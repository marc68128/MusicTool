using System;
using MusicTool.Core.IService;
using MusicTool.Core.Model;

namespace MusicTool.Core.Service
{
    public class NoteService : INoteService
    {
        private readonly KeyService _keyService; 
        public NoteService(KeyService keyService = null)
        {
            _keyService = keyService ?? new KeyService(); 
        }
        public Note GetMinorSecond(Note note)
        {
            return GetSecond(note, IntervalQuality.Minor);        
        }

        public Note GetMajorSecond(Note note)
        {
            return GetSecond(note, IntervalQuality.Major);
        }

        private Note GetSecond(Note note, IntervalQuality intervalQuality)
        {
            if (intervalQuality != IntervalQuality.Minor && intervalQuality != IntervalQuality.Major)
                throw new ArgumentException($"A second can only be major or minor, you tried to get a {intervalQuality} second.");

            var secondKey = _keyService.GetNextKey(note.Key);
            var intervalBetweenSecondKeyAndTarget = (_keyService.GetInterval(note.Key, secondKey) - (int)note.Alteration) - (intervalQuality == IntervalQuality.Minor ? 1 : 2);

            var alteration = GetAlterationFromInterval(intervalBetweenSecondKeyAndTarget); 

            return new Note(secondKey, alteration);
        }

        private Alteration GetAlterationFromInterval(int interval)
        {
            if (interval == 0)
                return Alteration.None;

            if (interval <= 6)
                return (Alteration)(-interval);

            return (Alteration)(12 - interval);
        }
    }
}
