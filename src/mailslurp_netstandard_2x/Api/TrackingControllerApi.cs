/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace mailslurp_netstandard_2x.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrackingControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create tracking pixel
        /// </summary>
        /// <remarks>
        /// Create a tracking pixel
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <returns>TrackingPixelDto</returns>
        TrackingPixelDto CreateTrackingPixel(CreateTrackingPixelOptions createTrackingPixelOptions);

        /// <summary>
        /// Create tracking pixel
        /// </summary>
        /// <remarks>
        /// Create a tracking pixel
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <returns>ApiResponse of TrackingPixelDto</returns>
        ApiResponse<TrackingPixelDto> CreateTrackingPixelWithHttpInfo(CreateTrackingPixelOptions createTrackingPixelOptions);
        /// <summary>
        /// Get tracking pixels
        /// </summary>
        /// <remarks>
        /// List tracking pixels in paginated form
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>PageTrackingPixelProjection</returns>
        PageTrackingPixelProjection GetAllTrackingPixels(int? page = default(int?), int? size = default(int?), string sort = default(string));

        /// <summary>
        /// Get tracking pixels
        /// </summary>
        /// <remarks>
        /// List tracking pixels in paginated form
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>ApiResponse of PageTrackingPixelProjection</returns>
        ApiResponse<PageTrackingPixelProjection> GetAllTrackingPixelsWithHttpInfo(int? page = default(int?), int? size = default(int?), string sort = default(string));
        /// <summary>
        /// Get pixel
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>TrackingPixelDto</returns>
        TrackingPixelDto GetTrackingPixel(Guid id);

        /// <summary>
        /// Get pixel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of TrackingPixelDto</returns>
        ApiResponse<TrackingPixelDto> GetTrackingPixelWithHttpInfo(Guid id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrackingControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create tracking pixel
        /// </summary>
        /// <remarks>
        /// Create a tracking pixel
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TrackingPixelDto</returns>
        System.Threading.Tasks.Task<TrackingPixelDto> CreateTrackingPixelAsync(CreateTrackingPixelOptions createTrackingPixelOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create tracking pixel
        /// </summary>
        /// <remarks>
        /// Create a tracking pixel
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TrackingPixelDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrackingPixelDto>> CreateTrackingPixelWithHttpInfoAsync(CreateTrackingPixelOptions createTrackingPixelOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get tracking pixels
        /// </summary>
        /// <remarks>
        /// List tracking pixels in paginated form
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PageTrackingPixelProjection</returns>
        System.Threading.Tasks.Task<PageTrackingPixelProjection> GetAllTrackingPixelsAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get tracking pixels
        /// </summary>
        /// <remarks>
        /// List tracking pixels in paginated form
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PageTrackingPixelProjection)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTrackingPixelProjection>> GetAllTrackingPixelsWithHttpInfoAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get pixel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TrackingPixelDto</returns>
        System.Threading.Tasks.Task<TrackingPixelDto> GetTrackingPixelAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get pixel
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TrackingPixelDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrackingPixelDto>> GetTrackingPixelWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrackingControllerApi : ITrackingControllerApiSync, ITrackingControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TrackingControllerApi : ITrackingControllerApi
    {
        private mailslurp_netstandard_2x.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrackingControllerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrackingControllerApi(String basePath)
        {
            this.Configuration = mailslurp_netstandard_2x.Client.Configuration.MergeConfigurations(
                mailslurp_netstandard_2x.Client.GlobalConfiguration.Instance,
                new mailslurp_netstandard_2x.Client.Configuration { BasePath = basePath }
            );
            this.Client = new mailslurp_netstandard_2x.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mailslurp_netstandard_2x.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = mailslurp_netstandard_2x.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TrackingControllerApi(mailslurp_netstandard_2x.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = mailslurp_netstandard_2x.Client.Configuration.MergeConfigurations(
                mailslurp_netstandard_2x.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new mailslurp_netstandard_2x.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new mailslurp_netstandard_2x.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = mailslurp_netstandard_2x.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TrackingControllerApi(mailslurp_netstandard_2x.Client.ISynchronousClient client, mailslurp_netstandard_2x.Client.IAsynchronousClient asyncClient, mailslurp_netstandard_2x.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = mailslurp_netstandard_2x.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public mailslurp_netstandard_2x.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public mailslurp_netstandard_2x.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public mailslurp_netstandard_2x.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public mailslurp_netstandard_2x.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create tracking pixel Create a tracking pixel
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <returns>TrackingPixelDto</returns>
        public TrackingPixelDto CreateTrackingPixel(CreateTrackingPixelOptions createTrackingPixelOptions)
        {
            mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto> localVarResponse = CreateTrackingPixelWithHttpInfo(createTrackingPixelOptions);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create tracking pixel Create a tracking pixel
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <returns>ApiResponse of TrackingPixelDto</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto> CreateTrackingPixelWithHttpInfo(CreateTrackingPixelOptions createTrackingPixelOptions)
        {
            // verify the required parameter 'createTrackingPixelOptions' is set
            if (createTrackingPixelOptions == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'createTrackingPixelOptions' when calling TrackingControllerApi->CreateTrackingPixel");

            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createTrackingPixelOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<TrackingPixelDto>("/tracking/pixels", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateTrackingPixel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create tracking pixel Create a tracking pixel
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TrackingPixelDto</returns>
        public async System.Threading.Tasks.Task<TrackingPixelDto> CreateTrackingPixelAsync(CreateTrackingPixelOptions createTrackingPixelOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto> localVarResponse = await CreateTrackingPixelWithHttpInfoAsync(createTrackingPixelOptions, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create tracking pixel Create a tracking pixel
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTrackingPixelOptions">createTrackingPixelOptions</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TrackingPixelDto)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto>> CreateTrackingPixelWithHttpInfoAsync(CreateTrackingPixelOptions createTrackingPixelOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'createTrackingPixelOptions' is set
            if (createTrackingPixelOptions == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'createTrackingPixelOptions' when calling TrackingControllerApi->CreateTrackingPixel");


            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createTrackingPixelOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<TrackingPixelDto>("/tracking/pixels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateTrackingPixel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get tracking pixels List tracking pixels in paginated form
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>PageTrackingPixelProjection</returns>
        public PageTrackingPixelProjection GetAllTrackingPixels(int? page = default(int?), int? size = default(int?), string sort = default(string))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<PageTrackingPixelProjection> localVarResponse = GetAllTrackingPixelsWithHttpInfo(page, size, sort);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get tracking pixels List tracking pixels in paginated form
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>ApiResponse of PageTrackingPixelProjection</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<PageTrackingPixelProjection> GetAllTrackingPixelsWithHttpInfo(int? page = default(int?), int? size = default(int?), string sort = default(string))
        {
            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (sort != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "sort", sort));
            }

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PageTrackingPixelProjection>("/tracking/pixels", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllTrackingPixels", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get tracking pixels List tracking pixels in paginated form
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PageTrackingPixelProjection</returns>
        public async System.Threading.Tasks.Task<PageTrackingPixelProjection> GetAllTrackingPixelsAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<PageTrackingPixelProjection> localVarResponse = await GetAllTrackingPixelsWithHttpInfoAsync(page, size, sort, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get tracking pixels List tracking pixels in paginated form
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PageTrackingPixelProjection)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<PageTrackingPixelProjection>> GetAllTrackingPixelsWithHttpInfoAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (sort != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "sort", sort));
            }

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PageTrackingPixelProjection>("/tracking/pixels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllTrackingPixels", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get pixel 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>TrackingPixelDto</returns>
        public TrackingPixelDto GetTrackingPixel(Guid id)
        {
            mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto> localVarResponse = GetTrackingPixelWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get pixel 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <returns>ApiResponse of TrackingPixelDto</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto> GetTrackingPixelWithHttpInfo(Guid id)
        {
            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", mailslurp_netstandard_2x.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<TrackingPixelDto>("/tracking/pixels/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTrackingPixel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get pixel 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TrackingPixelDto</returns>
        public async System.Threading.Tasks.Task<TrackingPixelDto> GetTrackingPixelAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto> localVarResponse = await GetTrackingPixelWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get pixel 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TrackingPixelDto)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<TrackingPixelDto>> GetTrackingPixelWithHttpInfoAsync(Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", mailslurp_netstandard_2x.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TrackingPixelDto>("/tracking/pixels/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTrackingPixel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
