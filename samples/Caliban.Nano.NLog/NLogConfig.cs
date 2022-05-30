using NLog;
using NLog.Config;
using NLog.Targets;

namespace Caliban.Nano.NLog
{
    /// <summary>
    /// A NLog logfile configuration.
    /// </summary>
    public sealed class NLogConfig : LoggingConfiguration
    {
        /// <summary>
        /// Initializes a new instance of this class.
        /// </summary>
        /// <param name="filename">The log filename.</param>
        public NLogConfig(string filename)
        {
            AddRule(LogLevel.Debug, LogLevel.Fatal, new FileTarget("logfile")
            {
                FileName = filename
            });
        }
    }
}
