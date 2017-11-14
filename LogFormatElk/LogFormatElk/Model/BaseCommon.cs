namespace LogFormatElk.Model
{
    #region Usings

    using System.Reflection;
    using JetBrains.Annotations;

    #endregion

    /// <summary>
    /// les différents de niveau dans le log
    /// </summary>
    public enum NiveauLog
    {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3,
        Fatal = 4
    }

    [PublicAPI]
    public sealed class BaseCommon
    {
        #region Constructeurs et destructeurs

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCommon" /> class.
        /// </summary>
        /// <param name="niveauLog">The niveau log.</param>
        /// <param name="mainMessage">The main message.</param>
        /// <param name="categorie">The categorie.</param>
        /// <param name="callerMemberName">Name of the caller member.</param>
        public BaseCommon(NiveauLog niveauLog, string mainMessage, string categorie, MethodBase callerMemberName)
        {
            this.MainMessage = mainMessage;
            this.Categorie = categorie;
            this.CallerMemberName = callerMemberName;
            this.NiveauLog = niveauLog;
        }

        #endregion

        #region Propriétés et indexeurs


        /// <summary>
        /// Gets or sets le niveau du log
        /// </summary>
        /// <value>
        /// The niveau log.
        /// </value>
        public NiveauLog NiveauLog { get; set; }

        /// <summary>
        ///     Gets or sets le nom de la fonction appellante
        /// </summary>
        /// <value>
        ///     nom de la fonction appellante
        /// </value>
        public MethodBase CallerMemberName { get; set; }

        /// <summary>
        ///     Gets or sets une catégorie pour un log (par exemple : "Converter" pour tous les logs concernant des converters)
        /// </summary>
        /// <value>
        ///     catégorie pour un log (par exemple : "Converter" pour tous les logs concernant des converters)
        /// </value>
        public string Categorie { get; set; }

        /// <summary>
        ///     Gets or sets le message principal du log
        /// </summary>
        /// <value>
        ///     MainMessage
        /// </value>
        public string MainMessage { get; set; }

        #endregion
    }
}
