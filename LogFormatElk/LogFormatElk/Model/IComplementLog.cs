namespace LogFormatElk.Model
{
    public interface IComplementLog
    {
        #region Méthodes publiques

        /// <summary>
        ///     Transforme le complément en JSON
        /// </summary>
        /// <returns>complément au format JSON</returns>
        string ToJson();

        #endregion
    }
}
