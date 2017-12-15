using System;
using System.ComponentModel.Design;
using System.Linq;
using MusicTool.Core.IService;
using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;

namespace MusicTool.Core.Service
{
    public class KeyService : IKeyService
    {
        public Key GetNextKey(Key key)
        {
            if (key == Key.B)
                return Key.C;

            return Enum.GetValues(typeof(Key)).Cast<Key>().First(k => (int)k > (int)key);
        }
        public Key GetPreviousKey(Key key)
        {
            if (key == Key.C)
                return Key.B;

            return Enum.GetValues(typeof(Key)).Cast<Key>().OrderByDescending(k => (int)k).First(k => (int)k < (int)key);
        }

        public Key GetByInterval(Key startKey, Interval interval)
        {
            var outKey = startKey; 
            for (int i = 0; i < (int)interval; i++)
            {
                outKey = GetNextKey(outKey);
            }
            return outKey; 
        }

        public int GetHalfStepCountBetweenTwoKey(Key k1, Key k2)
        {
            return (12 + ((int)k2 - (int)k1)) % 12;
        }

    }
}
