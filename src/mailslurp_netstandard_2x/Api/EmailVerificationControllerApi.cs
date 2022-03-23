/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
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
    public interface IEmailVerificationControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <returns>PageEmailValidationRequest</returns>
        PageEmailValidationRequest GetValidationRequests(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?));

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <returns>ApiResponse of PageEmailValidationRequest</returns>
        ApiResponse<PageEmailValidationRequest> GetValidationRequestsWithHttpInfo(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?));
        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <returns>ValidateEmailAddressListResult</returns>
        ValidateEmailAddressListResult ValidateEmailAddressList(ValidateEmailAddressListOptions validateEmailAddressListOptions);

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <returns>ApiResponse of ValidateEmailAddressListResult</returns>
        ApiResponse<ValidateEmailAddressListResult> ValidateEmailAddressListWithHttpInfo(ValidateEmailAddressListOptions validateEmailAddressListOptions);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailVerificationControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PageEmailValidationRequest</returns>
        System.Threading.Tasks.Task<PageEmailValidationRequest> GetValidationRequestsAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PageEmailValidationRequest)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEmailValidationRequest>> GetValidationRequestsWithHttpInfoAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ValidateEmailAddressListResult</returns>
        System.Threading.Tasks.Task<ValidateEmailAddressListResult> ValidateEmailAddressListAsync(ValidateEmailAddressListOptions validateEmailAddressListOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ValidateEmailAddressListResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidateEmailAddressListResult>> ValidateEmailAddressListWithHttpInfoAsync(ValidateEmailAddressListOptions validateEmailAddressListOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEmailVerificationControllerApi : IEmailVerificationControllerApiSync, IEmailVerificationControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EmailVerificationControllerApi : IEmailVerificationControllerApi
    {
        private mailslurp_netstandard_2x.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailVerificationControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailVerificationControllerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailVerificationControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailVerificationControllerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="EmailVerificationControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailVerificationControllerApi(mailslurp_netstandard_2x.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="EmailVerificationControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EmailVerificationControllerApi(mailslurp_netstandard_2x.Client.ISynchronousClient client, mailslurp_netstandard_2x.Client.IAsynchronousClient asyncClient, mailslurp_netstandard_2x.Client.IReadableConfiguration configuration)
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
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <returns>PageEmailValidationRequest</returns>
        public PageEmailValidationRequest GetValidationRequests(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<PageEmailValidationRequest> localVarResponse = GetValidationRequestsWithHttpInfo(page, size, sort, searchFilter, since, before, isValid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <returns>ApiResponse of PageEmailValidationRequest</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<PageEmailValidationRequest> GetValidationRequestsWithHttpInfo(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?))
        {
            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
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
            if (searchFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "searchFilter", searchFilter));
            }
            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }
            if (isValid != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "isValid", isValid));
            }

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PageEmailValidationRequest>("/email-verification/validation-requests", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetValidationRequests", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PageEmailValidationRequest</returns>
        public async System.Threading.Tasks.Task<PageEmailValidationRequest> GetValidationRequestsAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<PageEmailValidationRequest> localVarResponse = await GetValidationRequestsWithHttpInfoAsync(page, size, sort, searchFilter, since, before, isValid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Optional page index in list pagination (optional, default to 0)</param>
        /// <param name="size">Optional page size for paginated result list. (optional, default to 20)</param>
        /// <param name="sort">Optional createdAt sort direction ASC or DESC (optional, default to DESC)</param>
        /// <param name="searchFilter">Optional search filter (optional)</param>
        /// <param name="since">Filter by created at after the given timestamp (optional)</param>
        /// <param name="before">Filter by created at before the given timestamp (optional)</param>
        /// <param name="isValid">Filter where email is valid is true or false (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PageEmailValidationRequest)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<PageEmailValidationRequest>> GetValidationRequestsWithHttpInfoAsync(int? page = default(int?), int? size = default(int?), string sort = default(string), string searchFilter = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), bool? isValid = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
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
            if (searchFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "searchFilter", searchFilter));
            }
            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "since", since));
            }
            if (before != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "before", before));
            }
            if (isValid != null)
            {
                localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "isValid", isValid));
            }

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PageEmailValidationRequest>("/email-verification/validation-requests", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetValidationRequests", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <returns>ValidateEmailAddressListResult</returns>
        public ValidateEmailAddressListResult ValidateEmailAddressList(ValidateEmailAddressListOptions validateEmailAddressListOptions)
        {
            mailslurp_netstandard_2x.Client.ApiResponse<ValidateEmailAddressListResult> localVarResponse = ValidateEmailAddressListWithHttpInfo(validateEmailAddressListOptions);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <returns>ApiResponse of ValidateEmailAddressListResult</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<ValidateEmailAddressListResult> ValidateEmailAddressListWithHttpInfo(ValidateEmailAddressListOptions validateEmailAddressListOptions)
        {
            // verify the required parameter 'validateEmailAddressListOptions' is set
            if (validateEmailAddressListOptions == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'validateEmailAddressListOptions' when calling EmailVerificationControllerApi->ValidateEmailAddressList");

            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };

            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = validateEmailAddressListOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ValidateEmailAddressListResult>("/email-verification/email-address-list", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateEmailAddressList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ValidateEmailAddressListResult</returns>
        public async System.Threading.Tasks.Task<ValidateEmailAddressListResult> ValidateEmailAddressListAsync(ValidateEmailAddressListOptions validateEmailAddressListOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<ValidateEmailAddressListResult> localVarResponse = await ValidateEmailAddressListWithHttpInfoAsync(validateEmailAddressListOptions, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Validate a list of email addresses. Per unit billing. See your plan for pricing. 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="validateEmailAddressListOptions"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ValidateEmailAddressListResult)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<ValidateEmailAddressListResult>> ValidateEmailAddressListWithHttpInfoAsync(ValidateEmailAddressListOptions validateEmailAddressListOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'validateEmailAddressListOptions' is set
            if (validateEmailAddressListOptions == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'validateEmailAddressListOptions' when calling EmailVerificationControllerApi->ValidateEmailAddressList");


            mailslurp_netstandard_2x.Client.RequestOptions localVarRequestOptions = new mailslurp_netstandard_2x.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "*/*"
            };


            var localVarContentType = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = mailslurp_netstandard_2x.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = validateEmailAddressListOptions;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ValidateEmailAddressListResult>("/email-verification/email-address-list", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ValidateEmailAddressList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}