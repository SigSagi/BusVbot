﻿namespace MyTTCBot.Bot
{
    public static class CommonConstants
    {
        public static class Location
        {
            public const string FrequentLocationPrefix = "🚩: ";

            public const string OsmAndLocationRegex = @"geo:([+|-]?\d+(?:.\d+)?),([+|-]?\d+(?:.\d+)?)";

            public const short MaxSavedLocations = 4;
        }

        public static class Direction
        {
            public const string DirectionCallbackQueryPrefix = "↕: ";
        }

        public static class BusRoute
        {
            public const string ValidTtcBusTagRegex = @"^\d{1,3}[a-z]?$";
        }

        public static class FlagEmojis
        {
            public const string Canada = "🇨🇦";

            public const string UnitedStates = "🇺🇸";
        }

        public static class CallbackQueries
        {
            public static class UserProfileSetup
            {
                public const string UserProfileSetupPrefix = "ups/";

                public const string CountryPrefix = UserProfileSetupPrefix + "c:"; // ups/c:{country}

                public const string RegionPrefix = UserProfileSetupPrefix + "r:"; // ups/r:{name}

                public const string AgencyPrefix = UserProfileSetupPrefix + "a:"; // ups/a:{id}

                public const string BackToRegionsForCountryPrefix = UserProfileSetupPrefix + "r/c:"; // ups/r/c:{country}

                public const string BackToCountries = UserProfileSetupPrefix + "c"; // ups/c
            }
        }
    }
}
