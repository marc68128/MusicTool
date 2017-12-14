using MusicTool.Core.Model;

namespace MusicTool.Core.IService
{
    public interface IKeyService
    {
        Key GetNextKey(Key key);
        Key GetPreviousKey(Key key);
        int GetInterval(Key k1, Key k2);
    }
}
