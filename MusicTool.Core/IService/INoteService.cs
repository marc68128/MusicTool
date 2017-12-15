using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;

namespace MusicTool.Core.IService
{
    public interface INoteService
    {
        Note GetByInterval(Note startNote, Interval interval, IntervalQuality intervalQuality);
    }
}