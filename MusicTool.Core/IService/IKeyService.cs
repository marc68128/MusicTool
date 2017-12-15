using MusicTool.Core.Model;
using MusicTool.Core.Model.Enum;

namespace MusicTool.Core.IService
{
    public interface IKeyService
    {
        Key GetNextKey(Key key);
        Key GetPreviousKey(Key key);
        int GetHalfStepCountBetweenTwoKey(Key k1, Key k2);
    }
}
