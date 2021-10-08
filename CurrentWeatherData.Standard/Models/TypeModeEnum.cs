// <copyright file="TypeModeEnum.cs" company="APIMatic">
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
    /// TypeModeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeModeEnum
    {
        /// <summary>
        /// Xml.
        /// </summary>
        [EnumMember(Value = "xml")]
        Xml,

        /// <summary>
        /// Html.
        /// </summary>
        [EnumMember(Value = "html")]
        Html,

        /// <summary>
        /// Json.
        /// </summary>
        [EnumMember(Value = "json")]
        Json,
    }
}