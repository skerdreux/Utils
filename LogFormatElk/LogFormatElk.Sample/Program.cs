using System;

namespace LogFormatElk.Sample
{
    using LogFormatElk.Model;

    static class Program
    {
        static void Main()
        {
            /* configuration à rajouter dans l'app.config
             <configSections>
                <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
              </configSections>
                <log4net>
                    <appender name="FileAppender" type="log4net.Appender.RollingFileAppender">
                      <file value="c:\temp\logSampleCore.log" />
                      <appendToFile value="true" />
                      <maxSizeRollBackups value="30" />
                      <maximumFileSize value="5MB" />
                      <rollingStyle value="Size" />
                      <staticLogFileName value="false" />
                      <layout type="log4net.Layout.PatternLayout">
                        <conversionPattern value="%utcdate{yyyy-MM-dd HH:mm:ss,fff}    %level    [%property{Categorie}]    [%property{CallerMemberName}]    %message    [%property{Json}] %newline" />
                      </layout>
                    </appender>
                    <root>
                      <level value="DEBUG" />
                      <appender-ref ref="FileAppender" />
                    </root>
                </log4net>
             */


            Logger.LogMessage(
                new BaseCommon(NiveauLog.Debug, "Message Principale", "Test",
                               System.Reflection.MethodBase.GetCurrentMethod()), null);

            Logger.LogMessage(new BaseCommon(NiveauLog.Error, "Message Principale", "Test",
                                             System.Reflection.MethodBase.GetCurrentMethod()),
                              new SampleComplement("test propriété complémentaire", DateTime.Now));
        }
    }
}
