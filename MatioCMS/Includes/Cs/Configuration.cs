﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatioCMS.Database;

namespace MatioCMS.Includes
{
    public class Configuration
    {
        /// <summary>
        /// Official full name of the web page
        /// </summary>
        public string ApplicationName { get; private set; }

        /// <summary>
        /// Installed version of Matio CMS
        /// </summary>
        public Version CMSVersion { get; private set; }

        /// <summary>
        /// Language of the interface
        /// </summary>
        public Translation.LanguageCode Language { get; private set; }

        /// <summary>
        /// Selected time zone for this app
        /// </summary>
        public float TimeZone { get; private set; }

        /// <summary>
        /// Selected theme to run
        /// </summary>
        public string SelectedTheme { get; private set; }

        /// <summary>
        /// View static page (default blank) when critical code is updating
        /// </summary>
        public bool ServiceMode { get; private set; }

        /// <summary>
        /// Page from CMS as home page
        /// </summary>
        public string StaticHomePage { get; private set; }
    }
}
