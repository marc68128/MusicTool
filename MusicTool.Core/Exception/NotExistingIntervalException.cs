using System.Globalization;

namespace MusicTool.Core.Exception
{
    public class NotExistingIntervalException : System.Exception
    {
        public NotExistingIntervalException()
        {
        }

        public NotExistingIntervalException(string message) : base(message)
        {
        }
    }
}