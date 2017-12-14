using MusicTool.Core.Model;

namespace MusicTool.Core.IService
{
    public interface INoteService
    {
        Note GetMinorSecond(Note note);
    }
}