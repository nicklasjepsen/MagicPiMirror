﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace SystemOut.MagicPiMirror
{
    internal static class Strings
    {

        private static readonly ResourceLoader ResourceLoader = new ResourceLoader();

        public static string LoadingWeatherData => ResourceLoader.GetString(nameof(LoadingWeatherData));
        public static string LoadingCalendarEvents => ResourceLoader.GetString(nameof(LoadingCalendarEvents));
        public static string TodaysAgendaHeading => ResourceLoader.GetString(nameof(TodaysAgendaHeading));
        public static string TomorrowHeading => ResourceLoader.GetString(nameof(TomorrowHeading));
        public static string Error => ResourceLoader.GetString(nameof(Error));
        public static string UnableToConnectToWeatherService => ResourceLoader.GetString(nameof(UnableToConnectToWeatherService));
        public static string UnableToGetWeatherInformation => ResourceLoader.GetString(nameof(UnableToGetWeatherInformation));

        
    }
}
