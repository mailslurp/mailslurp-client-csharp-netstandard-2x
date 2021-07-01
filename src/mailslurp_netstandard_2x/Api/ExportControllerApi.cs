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
    public interface IExportControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <returns>byte[]</returns>
        byte[] ExportEntities(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string));

        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> ExportEntitiesWithHttpInfo(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string));
        /// <summary>
        /// Get export link
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <returns>ExportLink</returns>
        ExportLink GetExportLink(string exportType, ExportOptions exportOptions, string apiKey = default(string));

        /// <summary>
        /// Get export link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <returns>ApiResponse of ExportLink</returns>
        ApiResponse<ExportLink> GetExportLinkWithHttpInfo(string exportType, ExportOptions exportOptions, string apiKey = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> ExportEntitiesAsync(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Export inboxes link callable via browser
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> ExportEntitiesWithHttpInfoAsync(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get export link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExportLink</returns>
        System.Threading.Tasks.Task<ExportLink> GetExportLinkAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get export link
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExportLink)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExportLink>> GetExportLinkWithHttpInfoAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportControllerApi : IExportControllerApiSync, IExportControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExportControllerApi : IExportControllerApi
    {
        private mailslurp_netstandard_2x.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportControllerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportControllerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExportControllerApi(mailslurp_netstandard_2x.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ExportControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ExportControllerApi(mailslurp_netstandard_2x.Client.ISynchronousClient client, mailslurp_netstandard_2x.Client.IAsynchronousClient asyncClient, mailslurp_netstandard_2x.Client.IReadableConfiguration configuration)
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
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <returns>byte[]</returns>
        public byte[] ExportEntities(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<byte[]> localVarResponse = ExportEntitiesWithHttpInfo(apiKey, exportType, outputFormat, createdEarliestTime, createdOldestTime, excludePreviouslyExported, filter, listSeparatorToken);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <returns>ApiResponse of byte[]</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<byte[]> ExportEntitiesWithHttpInfo(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string))
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'apiKey' when calling ExportControllerApi->ExportEntities");

            // verify the required parameter 'exportType' is set
            if (exportType == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->ExportEntities");

            // verify the required parameter 'outputFormat' is set
            if (outputFormat == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'outputFormat' when calling ExportControllerApi->ExportEntities");

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

            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            if (createdEarliestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "createdEarliestTime", createdEarliestTime));
            }
            if (createdOldestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "createdOldestTime", createdOldestTime));
            }
            if (excludePreviouslyExported != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "excludePreviouslyExported", excludePreviouslyExported));
            }
            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (listSeparatorToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "listSeparatorToken", listSeparatorToken));
            }
            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "outputFormat", outputFormat));

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<byte[]>("/export", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExportEntities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> ExportEntitiesAsync(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<byte[]> localVarResponse = await ExportEntitiesWithHttpInfoAsync(apiKey, exportType, outputFormat, createdEarliestTime, createdOldestTime, excludePreviouslyExported, filter, listSeparatorToken, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export inboxes link callable via browser 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">apiKey</param>
        /// <param name="exportType">exportType</param>
        /// <param name="outputFormat">outputFormat</param>
        /// <param name="createdEarliestTime">createdEarliestTime (optional)</param>
        /// <param name="createdOldestTime">createdOldestTime (optional)</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported (optional)</param>
        /// <param name="filter">filter (optional)</param>
        /// <param name="listSeparatorToken">listSeparatorToken (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<byte[]>> ExportEntitiesWithHttpInfoAsync(string apiKey, string exportType, string outputFormat, DateTime? createdEarliestTime = default(DateTime?), DateTime? createdOldestTime = default(DateTime?), bool? excludePreviouslyExported = default(bool?), string filter = default(string), string listSeparatorToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'apiKey' when calling ExportControllerApi->ExportEntities");

            // verify the required parameter 'exportType' is set
            if (exportType == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->ExportEntities");

            // verify the required parameter 'outputFormat' is set
            if (outputFormat == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'outputFormat' when calling ExportControllerApi->ExportEntities");


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

            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            if (createdEarliestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "createdEarliestTime", createdEarliestTime));
            }
            if (createdOldestTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "createdOldestTime", createdOldestTime));
            }
            if (excludePreviouslyExported != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "excludePreviouslyExported", excludePreviouslyExported));
            }
            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (listSeparatorToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "listSeparatorToken", listSeparatorToken));
            }
            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "outputFormat", outputFormat));

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<byte[]>("/export", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ExportEntities", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <returns>ExportLink</returns>
        public ExportLink GetExportLink(string exportType, ExportOptions exportOptions, string apiKey = default(string))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<ExportLink> localVarResponse = GetExportLinkWithHttpInfo(exportType, exportOptions, apiKey);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <returns>ApiResponse of ExportLink</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<ExportLink> GetExportLinkWithHttpInfo(string exportType, ExportOptions exportOptions, string apiKey = default(string))
        {
            // verify the required parameter 'exportType' is set
            if (exportType == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->GetExportLink");

            // verify the required parameter 'exportOptions' is set
            if (exportOptions == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'exportOptions' when calling ExportControllerApi->GetExportLink");

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

            if (apiKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            }
            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            localVarRequestOptions.Data = exportOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ExportLink>("/export", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExportLink", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ExportLink</returns>
        public async System.Threading.Tasks.Task<ExportLink> GetExportLinkAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<ExportLink> localVarResponse = await GetExportLinkWithHttpInfoAsync(exportType, exportOptions, apiKey, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get export link 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="exportType">exportType</param>
        /// <param name="exportOptions">exportOptions</param>
        /// <param name="apiKey">apiKey (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ExportLink)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<ExportLink>> GetExportLinkWithHttpInfoAsync(string exportType, ExportOptions exportOptions, string apiKey = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'exportType' is set
            if (exportType == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'exportType' when calling ExportControllerApi->GetExportLink");

            // verify the required parameter 'exportOptions' is set
            if (exportOptions == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'exportOptions' when calling ExportControllerApi->GetExportLink");


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

            if (apiKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "apiKey", apiKey));
            }
            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "exportType", exportType));
            localVarRequestOptions.Data = exportOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ExportLink>("/export", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetExportLink", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
