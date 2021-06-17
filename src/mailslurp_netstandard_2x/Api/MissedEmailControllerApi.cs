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
    public interface IMissedEmailControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get all MissedEmails in paginated format
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>PageMissedEmailProjection</returns>
        PageMissedEmailProjection GetAllMissedEmails(int? page = default(int?), int? size = default(int?), string sort = default(string));

        /// <summary>
        /// Get all MissedEmails in paginated format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>ApiResponse of PageMissedEmailProjection</returns>
        ApiResponse<PageMissedEmailProjection> GetAllMissedEmailsWithHttpInfo(int? page = default(int?), int? size = default(int?), string sort = default(string));
        /// <summary>
        /// Get MissedEmail
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <returns>MissedEmail</returns>
        MissedEmail GetMissedEmail(Guid missedEmailId);

        /// <summary>
        /// Get MissedEmail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <returns>ApiResponse of MissedEmail</returns>
        ApiResponse<MissedEmail> GetMissedEmailWithHttpInfo(Guid missedEmailId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMissedEmailControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get all MissedEmails in paginated format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PageMissedEmailProjection</returns>
        System.Threading.Tasks.Task<PageMissedEmailProjection> GetAllMissedEmailsAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all MissedEmails in paginated format
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PageMissedEmailProjection)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageMissedEmailProjection>> GetAllMissedEmailsWithHttpInfoAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get MissedEmail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MissedEmail</returns>
        System.Threading.Tasks.Task<MissedEmail> GetMissedEmailAsync(Guid missedEmailId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get MissedEmail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MissedEmail)</returns>
        System.Threading.Tasks.Task<ApiResponse<MissedEmail>> GetMissedEmailWithHttpInfoAsync(Guid missedEmailId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMissedEmailControllerApi : IMissedEmailControllerApiSync, IMissedEmailControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MissedEmailControllerApi : IMissedEmailControllerApi
    {
        private mailslurp_netstandard_2x.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MissedEmailControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MissedEmailControllerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissedEmailControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MissedEmailControllerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="MissedEmailControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MissedEmailControllerApi(mailslurp_netstandard_2x.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="MissedEmailControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MissedEmailControllerApi(mailslurp_netstandard_2x.Client.ISynchronousClient client, mailslurp_netstandard_2x.Client.IAsynchronousClient asyncClient, mailslurp_netstandard_2x.Client.IReadableConfiguration configuration)
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
        /// Get all MissedEmails in paginated format 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>PageMissedEmailProjection</returns>
        public PageMissedEmailProjection GetAllMissedEmails(int? page = default(int?), int? size = default(int?), string sort = default(string))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<PageMissedEmailProjection> localVarResponse = GetAllMissedEmailsWithHttpInfo(page, size, sort);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all MissedEmails in paginated format 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <returns>ApiResponse of PageMissedEmailProjection</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<PageMissedEmailProjection> GetAllMissedEmailsWithHttpInfo(int? page = default(int?), int? size = default(int?), string sort = default(string))
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
            var localVarResponse = this.Client.Get<PageMissedEmailProjection>("/missed-emails", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllMissedEmails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all MissedEmails in paginated format 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PageMissedEmailProjection</returns>
        public async System.Threading.Tasks.Task<PageMissedEmailProjection> GetAllMissedEmailsAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<PageMissedEmailProjection> localVarResponse = await GetAllMissedEmailsWithHttpInfoAsync(page, size, sort, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all MissedEmails in paginated format 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in inbox list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size in inbox list pagination (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to ASC)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PageMissedEmailProjection)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<PageMissedEmailProjection>> GetAllMissedEmailsWithHttpInfoAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<PageMissedEmailProjection>("/missed-emails", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAllMissedEmails", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get MissedEmail 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <returns>MissedEmail</returns>
        public MissedEmail GetMissedEmail(Guid missedEmailId)
        {
            mailslurp_netstandard_2x.Client.ApiResponse<MissedEmail> localVarResponse = GetMissedEmailWithHttpInfo(missedEmailId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get MissedEmail 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <returns>ApiResponse of MissedEmail</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<MissedEmail> GetMissedEmailWithHttpInfo(Guid missedEmailId)
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

            localVarRequestOptions.PathParameters.Add("MissedEmailId", mailslurp_netstandard_2x.Client.ClientUtils.ParameterToString(missedEmailId)); // path parameter

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MissedEmail>("/missed-emails/{MissedEmailId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMissedEmail", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get MissedEmail 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MissedEmail</returns>
        public async System.Threading.Tasks.Task<MissedEmail> GetMissedEmailAsync(Guid missedEmailId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<MissedEmail> localVarResponse = await GetMissedEmailWithHttpInfoAsync(missedEmailId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get MissedEmail 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="missedEmailId">MissedEmailId</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MissedEmail)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<MissedEmail>> GetMissedEmailWithHttpInfoAsync(Guid missedEmailId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("MissedEmailId", mailslurp_netstandard_2x.Client.ClientUtils.ParameterToString(missedEmailId)); // path parameter

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<MissedEmail>("/missed-emails/{MissedEmailId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetMissedEmail", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
