/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
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
    public interface IApiUserControllerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string GetJsonPropertyAsString(string property, Object body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetJsonPropertyAsStringWithHttpInfo(string property, Object body);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfoDto</returns>
        UserInfoDto GetUserInfo();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfoDto</returns>
        ApiResponse<UserInfoDto> GetUserInfoWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiUserControllerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetJsonPropertyAsStringAsync(string property, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetJsonPropertyAsStringWithHttpInfoAsync(string property, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UserInfoDto</returns>
        System.Threading.Tasks.Task<UserInfoDto> GetUserInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UserInfoDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserInfoDto>> GetUserInfoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiUserControllerApi : IApiUserControllerApiSync, IApiUserControllerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApiUserControllerApi : IApiUserControllerApi
    {
        private mailslurp_netstandard_2x.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUserControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApiUserControllerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiUserControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApiUserControllerApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ApiUserControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApiUserControllerApi(mailslurp_netstandard_2x.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ApiUserControllerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ApiUserControllerApi(mailslurp_netstandard_2x.Client.ISynchronousClient client, mailslurp_netstandard_2x.Client.IAsynchronousClient asyncClient, mailslurp_netstandard_2x.Client.IReadableConfiguration configuration)
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
        ///  Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string GetJsonPropertyAsString(string property, Object body)
        {
            mailslurp_netstandard_2x.Client.ApiResponse<string> localVarResponse = GetJsonPropertyAsStringWithHttpInfo(property, body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<string> GetJsonPropertyAsStringWithHttpInfo(string property, Object body)
        {
            // verify the required parameter 'property' is set
            if (property == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'property' when calling ApiUserControllerApi->GetJsonPropertyAsString");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'body' when calling ApiUserControllerApi->GetJsonPropertyAsString");

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

            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "property", property));
            localVarRequestOptions.Data = body;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<string>("/user/json/pluck", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJsonPropertyAsString", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetJsonPropertyAsStringAsync(string property, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<string> localVarResponse = await GetJsonPropertyAsStringWithHttpInfoAsync(property, body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Utility function to extract properties from JSON objects in language where this is cumbersome.
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="property">JSON property name or dot separated path selector such as &#x60;a.b.c&#x60;</param>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<string>> GetJsonPropertyAsStringWithHttpInfoAsync(string property, Object body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'property' is set
            if (property == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'property' when calling ApiUserControllerApi->GetJsonPropertyAsString");

            // verify the required parameter 'body' is set
            if (body == null)
                throw new mailslurp_netstandard_2x.Client.ApiException(400, "Missing required parameter 'body' when calling ApiUserControllerApi->GetJsonPropertyAsString");


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

            localVarRequestOptions.QueryParameters.Add(mailslurp_netstandard_2x.Client.ClientUtils.ParameterToMultiMap("", "property", property));
            localVarRequestOptions.Data = body;

            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<string>("/user/json/pluck", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetJsonPropertyAsString", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserInfoDto</returns>
        public UserInfoDto GetUserInfo()
        {
            mailslurp_netstandard_2x.Client.ApiResponse<UserInfoDto> localVarResponse = GetUserInfoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserInfoDto</returns>
        public mailslurp_netstandard_2x.Client.ApiResponse<UserInfoDto> GetUserInfoWithHttpInfo()
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


            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<UserInfoDto>("/user/info", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UserInfoDto</returns>
        public async System.Threading.Tasks.Task<UserInfoDto> GetUserInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            mailslurp_netstandard_2x.Client.ApiResponse<UserInfoDto> localVarResponse = await GetUserInfoWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="mailslurp_netstandard_2x.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UserInfoDto)</returns>
        public async System.Threading.Tasks.Task<mailslurp_netstandard_2x.Client.ApiResponse<UserInfoDto>> GetUserInfoWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            // authentication (API_KEY) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<UserInfoDto>("/user/info", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
