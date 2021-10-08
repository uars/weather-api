// <copyright file="TypeWeatherEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace CurrentWeatherData.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using CurrentWeatherData.Standard;
    using CurrentWeatherData.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// TypeWeatherEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeWeatherEnum
    {
        /// <summary>
        /// Weather.
        /// </summary>
        [EnumMember(Value = "weather")]
        Weather,
    }
}