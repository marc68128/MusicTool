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
            var secondKey = _keyService.GetNextKey(note.Key);
            var intervalBetweenSecondKeyAndTarget = (_keyService.GetInterval(note.Key, secondKey) - (int)note.Alteration) - 1;

            if (intervalBetweenSecondKeyAndTarget == 0)
                return new Note(secondKey);

            if (intervalBetweenSecondKeyAndTarget <= 6)
                return new Note(secondKey, (Alteration)(-intervalBetweenSecondKeyAndTarget));
            

            return new Note(secondKey, (Alteration)(12 - intervalBetweenSecondKeyAndTarget));         
        }
    }
}
