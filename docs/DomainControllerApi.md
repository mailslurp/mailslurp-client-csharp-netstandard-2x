# mailslurp_netstandard_2x.Api.DomainControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDomainWildcardCatchAll**](DomainControllerApi#adddomainwildcardcatchall) | **POST** /domains/{id}/wildcard | Add catch all wild card inbox to domain |
| [**CreateDomain**](DomainControllerApi#createdomain) | **POST** /domains | Create Domain |
| [**DeleteDomain**](DomainControllerApi#deletedomain) | **DELETE** /domains/{id} | Delete a domain |
| [**GetAvailableDomains**](DomainControllerApi#getavailabledomains) | **GET** /domains/available-domains | Get all usable domains |
| [**GetDomain**](DomainControllerApi#getdomain) | **GET** /domains/{id} | Get a domain |
| [**GetDomainIssues**](DomainControllerApi#getdomainissues) | **GET** /domains/issues | Get domain issues |
| [**GetDomainWildcardCatchAllInbox**](DomainControllerApi#getdomainwildcardcatchallinbox) | **GET** /domains/{id}/wildcard | Get catch all wild card inbox for domain |
| [**GetDomains**](DomainControllerApi#getdomains) | **GET** /domains | Get domains |
| [**GetMailSlurpDomains**](DomainControllerApi#getmailslurpdomains) | **GET** /domains/mailslurp-domains | Get MailSlurp domains |
| [**UpdateDomain**](DomainControllerApi#updatedomain) | **PUT** /domains/{id} | Update a domain |

<a name="adddomainwildcardcatchall"></a>
# **AddDomainWildcardCatchAll**
> DomainDto AddDomainWildcardCatchAll (Guid id)

Add catch all wild card inbox to domain

Add a catch all inbox to a domain so that any emails sent to it that cannot be matched will be sent to the catch all inbox generated

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class AddDomainWildcardCatchAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Add catch all wild card inbox to domain
                DomainDto result = apiInstance.AddDomainWildcardCatchAll(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.AddDomainWildcardCatchAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDomainWildcardCatchAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add catch all wild card inbox to domain
    ApiResponse<DomainDto> response = apiInstance.AddDomainWildcardCatchAllWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.AddDomainWildcardCatchAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**DomainDto**](DomainDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="createdomain"></a>
# **CreateDomain**
> DomainDto CreateDomain (CreateDomainOptions createDomainOptions)

Create Domain

Link a domain that you own with MailSlurp so you can create email addresses using it. Endpoint returns DNS records used for validation. You must add these verification records to your host provider's DNS setup to verify the domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var createDomainOptions = new CreateDomainOptions(); // CreateDomainOptions | 

            try
            {
                // Create Domain
                DomainDto result = apiInstance.CreateDomain(createDomainOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.CreateDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Domain
    ApiResponse<DomainDto> response = apiInstance.CreateDomainWithHttpInfo(createDomainOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.CreateDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDomainOptions** | [**CreateDomainOptions**](CreateDomainOptions) |  |  |

### Return type

[**DomainDto**](DomainDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="deletedomain"></a>
# **DeleteDomain**
> List&lt;string&gt; DeleteDomain (Guid id)

Delete a domain

Delete a domain. This will disable any existing inboxes that use this domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a domain
                List<string> result = apiInstance.DeleteDomain(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.DeleteDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a domain
    ApiResponse<List<string>> response = apiInstance.DeleteDomainWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.DeleteDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

**List<string>**

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getavailabledomains"></a>
# **GetAvailableDomains**
> DomainGroupsDto GetAvailableDomains (string inboxType = null)

Get all usable domains

List all domains available for use with email address creation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetAvailableDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var inboxType = "HTTP_INBOX";  // string |  (optional) 

            try
            {
                // Get all usable domains
                DomainGroupsDto result = apiInstance.GetAvailableDomains(inboxType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.GetAvailableDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailableDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all usable domains
    ApiResponse<DomainGroupsDto> response = apiInstance.GetAvailableDomainsWithHttpInfo(inboxType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.GetAvailableDomainsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxType** | **string** |  | [optional]  |

### Return type

[**DomainGroupsDto**](DomainGroupsDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getdomain"></a>
# **GetDomain**
> DomainDto GetDomain (Guid id, bool? checkForErrors = null)

Get a domain

Returns domain verification status and tokens for a given domain

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var id = "id_example";  // Guid | 
            var checkForErrors = true;  // bool? |  (optional) 

            try
            {
                // Get a domain
                DomainDto result = apiInstance.GetDomain(id, checkForErrors);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.GetDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a domain
    ApiResponse<DomainDto> response = apiInstance.GetDomainWithHttpInfo(id, checkForErrors);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.GetDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **checkForErrors** | **bool?** |  | [optional]  |

### Return type

[**DomainDto**](DomainDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getdomainissues"></a>
# **GetDomainIssues**
> DomainIssuesDto GetDomainIssues ()

Get domain issues

List domain issues for domains you have created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetDomainIssuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);

            try
            {
                // Get domain issues
                DomainIssuesDto result = apiInstance.GetDomainIssues();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.GetDomainIssues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDomainIssuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get domain issues
    ApiResponse<DomainIssuesDto> response = apiInstance.GetDomainIssuesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.GetDomainIssuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DomainIssuesDto**](DomainIssuesDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getdomainwildcardcatchallinbox"></a>
# **GetDomainWildcardCatchAllInbox**
> InboxDto GetDomainWildcardCatchAllInbox (Guid id)

Get catch all wild card inbox for domain

Get the catch all inbox for a domain for missed emails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetDomainWildcardCatchAllInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get catch all wild card inbox for domain
                InboxDto result = apiInstance.GetDomainWildcardCatchAllInbox(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.GetDomainWildcardCatchAllInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDomainWildcardCatchAllInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get catch all wild card inbox for domain
    ApiResponse<InboxDto> response = apiInstance.GetDomainWildcardCatchAllInboxWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.GetDomainWildcardCatchAllInboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**InboxDto**](InboxDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getdomains"></a>
# **GetDomains**
> List&lt;DomainPreview&gt; GetDomains ()

Get domains

List all custom domains you have created

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);

            try
            {
                // Get domains
                List<DomainPreview> result = apiInstance.GetDomains();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.GetDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get domains
    ApiResponse<List<DomainPreview>> response = apiInstance.GetDomainsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.GetDomainsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;DomainPreview&gt;**](DomainPreview)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getmailslurpdomains"></a>
# **GetMailSlurpDomains**
> DomainGroupsDto GetMailSlurpDomains (string inboxType = null)

Get MailSlurp domains

List all MailSlurp domains used with non-custom email addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetMailSlurpDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var inboxType = "HTTP_INBOX";  // string |  (optional) 

            try
            {
                // Get MailSlurp domains
                DomainGroupsDto result = apiInstance.GetMailSlurpDomains(inboxType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.GetMailSlurpDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMailSlurpDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MailSlurp domains
    ApiResponse<DomainGroupsDto> response = apiInstance.GetMailSlurpDomainsWithHttpInfo(inboxType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.GetMailSlurpDomainsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxType** | **string** |  | [optional]  |

### Return type

[**DomainGroupsDto**](DomainGroupsDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="updatedomain"></a>
# **UpdateDomain**
> DomainDto UpdateDomain (Guid id, UpdateDomainOptions updateDomainOptions)

Update a domain

Update values on a domain. Note you cannot change the domain name as it is immutable. Recreate the domain if you need to alter this.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class UpdateDomainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new DomainControllerApi(config);
            var id = "id_example";  // Guid | 
            var updateDomainOptions = new UpdateDomainOptions(); // UpdateDomainOptions | 

            try
            {
                // Update a domain
                DomainDto result = apiInstance.UpdateDomain(id, updateDomainOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DomainControllerApi.UpdateDomain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a domain
    ApiResponse<DomainDto> response = apiInstance.UpdateDomainWithHttpInfo(id, updateDomainOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DomainControllerApi.UpdateDomainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **updateDomainOptions** | [**UpdateDomainOptions**](UpdateDomainOptions) |  |  |

### Return type

[**DomainDto**](DomainDto)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

