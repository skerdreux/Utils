namespace LogFormatElk.Model
{
    #region Usings

    using Newtonsoft.Json;

    #endregion

    public abstract class ComplementBase : IComplementLog
    {
        #region Méthodes publiques

        /// <summary>
        ///     Transforme le complément en JSON
        /// </summary>
        /// <returns>
        ///     complément au format JSON
        /// </returns>
        public string ToJson() => JsonConvert.SerializeObject(this);

        #endregion
    }
}
