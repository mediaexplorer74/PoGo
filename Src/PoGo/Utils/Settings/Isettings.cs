﻿using PokemonGo_UWP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo_UWP.Utils.Settings
{
    public interface ISettings
    {
        AuthType AuthType { get; set; }
        double DefaultLatitude { get; set; }
        double DefaultLongitude { get; set; }
        double DefaultAccuracy { get; set; }
        string GoogleRefreshToken { get; set; }
        string PtcPassword { get; set; }
        string PtcUsername { get; set; }
        string GoogleUsername { get; set; }
        string GooglePassword { get; set; }
        string DevicePlatform { get; set; }
        string DeviceId { get; set; }
        string AndroidBoardName { get; set; }
        string AndroidBootloader { get; set; }
        string DeviceBrand { get; set; }
        string DeviceModel { get; set; }
        string DeviceModelIdentifier { get; set; }
        string DeviceModelBoot { get; set; }
        string HardwareManufacturer { get; set; }
        string HardwareModel { get; set; }
        string FirmwareBrand { get; set; }
        string FirmwareTags { get; set; }
        string FirmwareType { get; set; }
        string FirmwareFingerprint { get; set; }
    }
}
