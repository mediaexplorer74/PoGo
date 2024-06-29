﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 0649

namespace PokemonGo_UWP.Entities
{
    public class WebConfigurationInfo
    {
        private static WebConfigurationInfo instance;

        static WebConfigurationInfo()
        {
        }

        private WebConfigurationInfo()
        {
        }

        public static WebConfigurationInfo Instance
        {
            get
            {
                return instance;
            }
        }

        public static bool SetInstance(string json)
        {
            instance = JsonConvert.DeserializeObject<WebConfigurationInfo>(json);
            return instance != null;
        }

        public bool gymsaredisabled;
    }
}
