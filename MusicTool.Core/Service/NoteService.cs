using System;
using MusicTool.Core.Exception;
using MusicTool.Core.IService;
using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;

namespace MusicTool.Core.Service
{
    public class NoteService : INoteService
    {
        private readonly KeyService _keyService; 

        public NoteService(KeyService keyService = null)
        {
            _keyService = keyService ?? new KeyService(); 
        }

        public Note GetByInterval(Note startNote, Interval interval, IntervalQuality intervalQuality)
        {
            var targetKey = _keyService.GetByInterval(startNote.Key, interval);
            var halfStepCountBetweenStartNoteAndTargetKey = (_keyService.GetHalfStepCountBetweenTwoKey(startNote.Key, targetKey) - (int)startNote.Alteration);
            var targetHalfStepCount = GetHalfStepCountFromInterval(interval, intervalQuality);
            var neededAlterationHalfStepCount = targetHalfStepCount - halfStepCountBetweenStartNoteAndTargetKey;
            var alteration = (Alteration)(neededAlterationHalfStepCount);
            return new Note(targetKey, alteration);
        }


        private int GetHalfStepCountFromInterval(Interval interval, IntervalQuality intervalQuality)
        {
            switch (interval)
            {
                case Interval.Second:
                    switch (intervalQuality)
                    {
                        case IntervalQuality.Major:
                            return 2;
                        case IntervalQuality.Minor:
                            return 1;
                        case IntervalQuality.Augmented:
                            return 3;
                        case IntervalQuality.Diminished:
                            return 0;
                        case IntervalQuality.Perfect:
                            throw new NotExistingIntervalException($"Interval {interval} {intervalQuality} does not exist");
                        default:
                            throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
                    }
                case Interval.Third:
                    switch (intervalQuality)
                    {
                        case IntervalQuality.Major:
                            return 4;
                        case IntervalQuality.Minor:
                            return 3;
                        case IntervalQuality.Augmented:
                            return 5;
                        case IntervalQuality.Diminished:
                            return 2;
                        case IntervalQuality.Perfect:
                            throw new NotExistingIntervalException($"Interval {interval} {intervalQuality} does not exist");
                        default:
                            throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
                    }
                case Interval.Fourth:
                    switch (intervalQuality)
                    {
                        case IntervalQuality.Perfect:
                            return 5;
                        case IntervalQuality.Augmented:
                            return 6;
                        case IntervalQuality.Diminished:
                            return 4;
                        case IntervalQuality.Major:
                        case IntervalQuality.Minor:
                            throw new NotExistingIntervalException($"Interval {interval} {intervalQuality} does not exist");
                        default:
                            throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
                    }
                case Interval.Fifth:
                    switch (intervalQuality)
                    {
                        case IntervalQuality.Perfect:
                            return 7;
                        case IntervalQuality.Augmented:
                            return 8;
                        case IntervalQuality.Diminished:
                            return 6;
                        case IntervalQuality.Major:
                        case IntervalQuality.Minor:
                            throw new NotExistingIntervalException($"Interval {interval} {intervalQuality} does not exist");
                        default:
                            throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
                    }
                case Interval.Sixth:
                    switch (intervalQuality)
                    {
                        case IntervalQuality.Major:
                            return 9;
                        case IntervalQuality.Minor:
                            return 8;
                        case IntervalQuality.Augmented:
                            return 10;
                        case IntervalQuality.Diminished:
                            return 7;
                        case IntervalQuality.Perfect:
                            throw new NotExistingIntervalException($"Interval {interval} {intervalQuality} does not exist");
                        default:
                            throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
                    }
                case Interval.Seventh:
                    switch (intervalQuality)
                    {
                        case IntervalQuality.Major:
                            return 11;
                        case IntervalQuality.Minor:
                            return 10;
                        case IntervalQuality.Augmented:
                            return 12;
                        case IntervalQuality.Diminished:
                            return 9;
                        case IntervalQuality.Perfect:
                            throw new NotExistingIntervalException($"Interval {interval} {intervalQuality} does not exist");
                        default:
                            throw new ArgumentOutOfRangeException(nameof(intervalQuality), intervalQuality, null);
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(interval), interval, null);
            }
        }
    }
}
