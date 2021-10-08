// <copyright file="TypeUnitsEnum.cs" company="APIMatic">
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
    /// TypeUnitsEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeUnitsEnum
    {
        /// <summary>
        /// Standard.
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard,

        /// <summary>
        /// Metric.
        /// </summary>
        [EnumMember(Value = "metric")]
        Metric,

        /// <summary>
        /// Imperial.
        /// </summary>
        [EnumMember(Value = "imperial")]
        Imperial,
    }
}