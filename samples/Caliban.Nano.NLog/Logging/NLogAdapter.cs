using System;
using NLog;

namespace Caliban.Nano.NLog.Logging
{
    /// <summary>
    /// A NLog logging adapter.
    /// </summary>
    public sealed class NLogAdapter : Contracts.ILogger
    {
        private readonly Logger _log;

        /// <summary>
        /// Initializes a new configured instance of this class.
        /// </summary>
        /// <param name="filename">The log filename.</param>
        public NLogAdapter(string filename)
        {
            LogManager.Configuration = new NLogConfig(filename);

            _log = LogManager.GetCurrentClassLogger();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            LogManager.Shutdown();
        }

        /// <inheritdoc />
        public void Info(string message)
        {
            _log.Info(message);
        }

        /// <inheritdoc />
        public void Warn(string message)
        {
            _log.Warn(message);
        }

        /// <inheritdoc />
        public void Error(string message)
        {
            _log.Error(message);
        }

        /// <inheritdoc />
        public void Error(string format, params object[] args)
        {
            _log.Error(format, args);
        }

        /// <inheritdoc />
        public void Error(Exception exception)
        {
            _log.Error(exception);
        }

        /// <inheritdoc />
        public void Error(Exception exception, string format, params object[] args)
        {
            _log.Error(exception, format, args);
        }
    }
}
