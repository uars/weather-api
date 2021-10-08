// <copyright file="SimpleWeatherController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace CurrentWeatherData.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using CurrentWeatherData.Standard;
    using CurrentWeatherData.Standard.Authentication;
    using CurrentWeatherData.Standard.Http.Client;
    using CurrentWeatherData.Standard.Http.Request;
    using CurrentWeatherData.Standard.Http.Response;
    using CurrentWeatherData.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SimpleWeatherController.
    /// </summary>
    public class SimpleWeatherController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWeatherController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal SimpleWeatherController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Weather by CityName EndPoint.
        /// </summary>
        /// <param name="weather">Required parameter: Example: .</param>
        /// <param name="appid">Required parameter: Example: 67efe337072a2e09c9d9796a16c42af9.</param>
        /// <param name="q">Required parameter: Example: London.</param>
        /// <param name="mode">Required parameter: Example: .</param>
        /// <param name="units">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic WeatherByCityName(
                Models.TypeWeatherEnum weather,
                string appid,
                string q,
                Models.TypeModeEnum mode,
                Models.TypeUnitsEnum units,
                Models.TypeLanguageEnum lang)
        {
            Task<dynamic> t = this.WeatherByCityNameAsync(weather, appid, q, mode, units, lang);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Weather by CityName EndPoint.
        /// </summary>
        /// <param name="weather">Required parameter: Example: .</param>
        /// <param name="appid">Required parameter: Example: 67efe337072a2e09c9d9796a16c42af9.</param>
        /// <param name="q">Required parameter: Example: London.</param>
        /// <param name="mode">Required parameter: Example: .</param>
        /// <param name="units">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> WeatherByCityNameAsync(
                Models.TypeWeatherEnum weather,
                string appid,
                string q,
                Models.TypeModeEnum mode,
                Models.TypeUnitsEnum units,
                Models.TypeLanguageEnum lang,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/{weather}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "weather", ApiHelper.JsonSerialize(weather).Trim('\"') },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "appid", appid },
                { "q", q },
                { "mode", ApiHelper.JsonSerialize(mode).Trim('\"') },
                { "units", ApiHelper.JsonSerialize(units).Trim('\"') },
                { "lang", ApiHelper.JsonSerialize(lang).Trim('\"') },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }

        /// <summary>
        /// Weather by CityID EndPoint.
        /// </summary>
        /// <param name="weather">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: 2172797.</param>
        /// <param name="appid">Required parameter: Example: 67efe337072a2e09c9d9796a16c42af9.</param>
        /// <param name="mode">Required parameter: Example: .</param>
        /// <param name="units">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public dynamic WeatherByCityID(
                Models.TypeWeatherEnum weather,
                int id,
                string appid,
                Models.TypeModeEnum mode,
                Models.TypeUnitsEnum units,
                Models.TypeLanguageEnum lang)
        {
            Task<dynamic> t = this.WeatherByCityIDAsync(weather, id, appid, mode, units, lang);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Weather by CityID EndPoint.
        /// </summary>
        /// <param name="weather">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: 2172797.</param>
        /// <param name="appid">Required parameter: Example: 67efe337072a2e09c9d9796a16c42af9.</param>
        /// <param name="mode">Required parameter: Example: .</param>
        /// <param name="units">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the dynamic response from the API call.</returns>
        public async Task<dynamic> WeatherByCityIDAsync(
                Models.TypeWeatherEnum weather,
                int id,
                string appid,
                Models.TypeModeEnum mode,
                Models.TypeUnitsEnum units,
                Models.TypeLanguageEnum lang,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/{weather}");

            // process optional template parameters.
            ApiHelper.AppendUrlWithTemplateParameters(queryBuilder, new Dictionary<string, object>()
            {
                { "weather", ApiHelper.JsonSerialize(weather).Trim('\"') },
            });

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "id", id },
                { "appid", appid },
                { "mode", ApiHelper.JsonSerialize(mode).Trim('\"') },
                { "units", ApiHelper.JsonSerialize(units).Trim('\"') },
                { "lang", ApiHelper.JsonSerialize(lang).Trim('\"') },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<dynamic>(response.Body);
        }
    }
}