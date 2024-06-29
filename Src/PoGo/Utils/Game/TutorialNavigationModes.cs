﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo_UWP.Utils.Game
{
    public enum TutorialNavigationModes
    {
        // Navigating from GameMapPageViewModel when the tutorial needs to be completed
        TutorialStart,
        // Navigating from CapturePokemonPageViewModel when starter pokemon has been catched
        StarterPokemonCatched
    }
}
