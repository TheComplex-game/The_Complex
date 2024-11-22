//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Threading.Tasks;
using System.Collections.Generic;
using Unity.Services.Friends.Internal.Generated.Models;
using Unity.Services.Friends.Internal.Generated.Http;
using Unity.Services.Authentication.Internal;
using Unity.Services.Friends.Internal.Generated.Notifications;

namespace Unity.Services.Friends.Internal.Generated.Apis.Notifications
{
    /// <summary>
    /// Interface for the NotificationsApiClient
    /// </summary>
    internal interface INotificationsApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Get notification auth details..
            /// </summary>
            /// <param name="request">Request object for GetNotificationsAuth.</param>
            /// <param name="operationConfiguration">Configuration for GetNotificationsAuth.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.NotificationAuth object.</returns>
            /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.NotificationAuth>> GetNotificationsAuthAsync(Unity.Services.Friends.Internal.Generated.Notifications.GetNotificationsAuthRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="INotificationsApiClient"/>
    internal class NotificationsApiClient : BaseApiClient, INotificationsApiClient
    {
        private IAccessToken _accessToken;
        private const int _baseTimeout = 10;
        private Configuration _configuration;
        /// <summary>
        /// Accessor for the client configuration object. This returns a merge
        /// between the current configuration and the global configuration to
        /// ensure the correct combination of headers and a base path (if it is
        /// set) are returned.
        /// </summary>
        public Configuration Configuration
        {
            get {
                // We return a merge between the current configuration and the
                // global configuration to ensure we have the correct
                // combination of headers and a base path (if it is set).
                Configuration globalConfiguration = new Configuration("https://social.services.api.unity.com", 10, 4, null);
                if (FriendsService.Instance != null)
                {
                    globalConfiguration = FriendsService.Instance.Configuration;
                }
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// NotificationsApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for NotificationsApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> NotificationsApiClient Configuration object.</param>
        public NotificationsApiClient(IHttpClient httpClient,
            IAccessToken accessToken,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            _accessToken = accessToken;
        }


        /// <summary>
        /// Async Operation.
        /// Get notification auth details..
        /// </summary>
        /// <param name="request">Request object for GetNotificationsAuth.</param>
        /// <param name="operationConfiguration">Configuration for GetNotificationsAuth.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.NotificationAuth object.</returns>
        /// <exception cref="Unity.Services.Friends.Internal.Generated.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.NotificationAuth>> GetNotificationsAuthAsync(Unity.Services.Friends.Internal.Generated.Notifications.GetNotificationsAuthRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.NotificationAuth)   },{"400", typeof(Models.Error)   },{"403", typeof(Models.Error)   },{"500", typeof(Models.Error)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.NotificationAuth>(response, statusCodeToTypeMap);
            return new Response<Models.NotificationAuth>(response, handledResponse);
        }

    }
}
