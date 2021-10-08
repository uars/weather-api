// <copyright file="TypeLanguageEnum.cs" company="APIMatic">
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
    /// TypeLanguageEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeLanguageEnum
    {
        /// <summary>
        ///English
        /// En.
        /// </summary>
        [EnumMember(Value = "en")]
        En,

        /// <summary>
        ///japanese
        /// Ja.
        /// </summary>
        [EnumMember(Value = "ja")]
        Ja,
    }
}