using System;
using System.Configuration;
using System.Reflection;

// Hello World

namespace Nardax
{
    public static class AssemblyExtensions
    {
        public static string GetAppSettingsValue(this Assembly assembly, string key)
        {
            //Hitta AppSettings-värden utifrån Assembly

            var configuration = ConfigurationManager.OpenExeConfiguration(assembly.Location);

            if (configuration.AppSettings.Settings[key] != null)
            {
                return configuration.AppSettings.Settings[key].Value;
            }

            throw new IndexOutOfRangeException(string.Format(ExceptionMessages.SettingsKeyNotFound, key));
        }
    }
}