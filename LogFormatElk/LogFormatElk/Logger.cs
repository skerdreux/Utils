namespace LogFormatElk
{
    #region Usings

    using System;
    using System.Reflection;
    using JetBrains.Annotations;
    using log4net;
    using LogFormatElk.Model;

    #endregion

    [PublicAPI]
    public static class Logger
    {
        #region Champs et constantes statiques

        /// <summary>
        ///     The log
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Méthodes publiques

        /// <summary>
        ///     Logs the message.
        /// </summary>
        /// <param name="baseCommonLog">The base common log.</param>
        /// <param name="complementLog">The complement log.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void LogMessage([NotNull] BaseCommon baseCommonLog, [CanBeNull] IComplementLog complementLog)
        {
            CommonProcessing(baseCommonLog);
            ComplementProcessing(complementLog);
            switch (baseCommonLog.NiveauLog)
            {
                case NiveauLog.Debug:
                    Log.Debug(baseCommonLog.MainMessage);
                    break;
                case NiveauLog.Info:
                    Log.Info(baseCommonLog.MainMessage);
                    break;
                case NiveauLog.Warning:
                    Log.Warn(baseCommonLog.MainMessage);
                    break;
                case NiveauLog.Error:
                    Log.Error(baseCommonLog.MainMessage);
                    break;
                case NiveauLog.Fatal:
                    Log.Fatal(baseCommonLog.MainMessage);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Méthodes privées

        /// <summary>
        ///     Commons the processing.
        /// </summary>
        /// <param name="baseCommonLog">The base common log.</param>
        /// <exception cref="ArgumentNullException">baseCommonLog</exception>
        private static void CommonProcessing(BaseCommon baseCommonLog)
        {
            if (baseCommonLog != null)
            {
                LogicalThreadContext.Properties["Categorie"] = baseCommonLog.Categorie;
                LogicalThreadContext.Properties["CallerMemberName"] = baseCommonLog.CallerMemberName;
            }
            else
            {
                throw new ArgumentNullException(nameof(baseCommonLog));
            }
        }

        /// <summary>
        ///     Complements the processing.
        /// </summary>
        /// <param name="complementLog">The complement log.</param>
        private static void ComplementProcessing(IComplementLog complementLog)
        {
            if (complementLog != null)
            {
                LogicalThreadContext.Properties["Json"] = complementLog.ToJson();
            }
        }

        #endregion
    }
}
