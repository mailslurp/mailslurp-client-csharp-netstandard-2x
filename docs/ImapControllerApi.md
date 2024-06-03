# mailslurp_netstandard_2x.Api.ImapControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ImapServerFetch**](ImapControllerApi#imapserverfetch) | **POST** /imap/server/fetch | Fetch message in an inbox |
| [**ImapServerGet**](ImapControllerApi#imapserverget) | **POST** /imap/server/get | Get a message by email ID |
| [**ImapServerList**](ImapControllerApi#imapserverlist) | **POST** /imap/server/list | List messages in an inbox |
| [**ImapServerMailbox**](ImapControllerApi#imapservermailbox) | **POST** /imap/server/mailbox | Create a new mailbox if possible |
| [**ImapServerSearch**](ImapControllerApi#imapserversearch) | **POST** /imap/server/search | Search messages in an inbox |
| [**ImapServerStatus**](ImapControllerApi#imapserverstatus) | **POST** /imap/server/status | Get status for mailbox |
| [**ImapServerUpdateFlags**](ImapControllerApi#imapserverupdateflags) | **POST** /imap/server/update-flags |  |

<a name="imapserverfetch"></a>
# **ImapServerFetch**
> ImapServerFetchResult ImapServerFetch (long seqNum, Guid? inboxId = null)

Fetch message in an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerFetchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var seqNum = 789L;  // long | 
            var inboxId = "inboxId_example";  // Guid? | Inbox ID to search (optional) 

            try
            {
                // Fetch message in an inbox
                ImapServerFetchResult result = apiInstance.ImapServerFetch(seqNum, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerFetch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerFetchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch message in an inbox
    ApiResponse<ImapServerFetchResult> response = apiInstance.ImapServerFetchWithHttpInfo(seqNum, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerFetchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **seqNum** | **long** |  |  |
| **inboxId** | **Guid?** | Inbox ID to search | [optional]  |

### Return type

[**ImapServerFetchResult**](ImapServerFetchResult)

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

<a name="imapserverget"></a>
# **ImapServerGet**
> ImapServerGetResult ImapServerGet (Guid emailId, Guid? inboxId = null)

Get a message by email ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var emailId = "emailId_example";  // Guid | Email ID to get
            var inboxId = "inboxId_example";  // Guid? | Inbox ID to search (optional) 

            try
            {
                // Get a message by email ID
                ImapServerGetResult result = apiInstance.ImapServerGet(emailId, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a message by email ID
    ApiResponse<ImapServerGetResult> response = apiInstance.ImapServerGetWithHttpInfo(emailId, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailId** | **Guid** | Email ID to get |  |
| **inboxId** | **Guid?** | Inbox ID to search | [optional]  |

### Return type

[**ImapServerGetResult**](ImapServerGetResult)

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

<a name="imapserverlist"></a>
# **ImapServerList**
> ImapServerListResult ImapServerList (ImapServerListOptions imapServerListOptions, Guid? inboxId = null)

List messages in an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var imapServerListOptions = new ImapServerListOptions(); // ImapServerListOptions | 
            var inboxId = "inboxId_example";  // Guid? | Inbox ID to list (optional) 

            try
            {
                // List messages in an inbox
                ImapServerListResult result = apiInstance.ImapServerList(imapServerListOptions, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List messages in an inbox
    ApiResponse<ImapServerListResult> response = apiInstance.ImapServerListWithHttpInfo(imapServerListOptions, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imapServerListOptions** | [**ImapServerListOptions**](ImapServerListOptions) |  |  |
| **inboxId** | **Guid?** | Inbox ID to list | [optional]  |

### Return type

[**ImapServerListResult**](ImapServerListResult)

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

<a name="imapservermailbox"></a>
# **ImapServerMailbox**
> ImapServerMailboxResult ImapServerMailbox (string name)

Create a new mailbox if possible

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerMailboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var name = "name_example";  // string | Inbox email address to create

            try
            {
                // Create a new mailbox if possible
                ImapServerMailboxResult result = apiInstance.ImapServerMailbox(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerMailbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerMailboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new mailbox if possible
    ApiResponse<ImapServerMailboxResult> response = apiInstance.ImapServerMailboxWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerMailboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Inbox email address to create |  |

### Return type

[**ImapServerMailboxResult**](ImapServerMailboxResult)

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

<a name="imapserversearch"></a>
# **ImapServerSearch**
> ImapServerSearchResult ImapServerSearch (ImapServerSearchOptions imapServerSearchOptions, Guid? inboxId = null)

Search messages in an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var imapServerSearchOptions = new ImapServerSearchOptions(); // ImapServerSearchOptions | 
            var inboxId = "inboxId_example";  // Guid? | Inbox ID to search (optional) 

            try
            {
                // Search messages in an inbox
                ImapServerSearchResult result = apiInstance.ImapServerSearch(imapServerSearchOptions, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search messages in an inbox
    ApiResponse<ImapServerSearchResult> response = apiInstance.ImapServerSearchWithHttpInfo(imapServerSearchOptions, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imapServerSearchOptions** | [**ImapServerSearchOptions**](ImapServerSearchOptions) |  |  |
| **inboxId** | **Guid?** | Inbox ID to search | [optional]  |

### Return type

[**ImapServerSearchResult**](ImapServerSearchResult)

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

<a name="imapserverstatus"></a>
# **ImapServerStatus**
> ImapServerStatusResult ImapServerStatus (ImapServerStatusOptions imapServerStatusOptions, Guid? inboxId = null)

Get status for mailbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var imapServerStatusOptions = new ImapServerStatusOptions(); // ImapServerStatusOptions | 
            var inboxId = "inboxId_example";  // Guid? | Inbox ID to list (optional) 

            try
            {
                // Get status for mailbox
                ImapServerStatusResult result = apiInstance.ImapServerStatus(imapServerStatusOptions, inboxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get status for mailbox
    ApiResponse<ImapServerStatusResult> response = apiInstance.ImapServerStatusWithHttpInfo(imapServerStatusOptions, inboxId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imapServerStatusOptions** | [**ImapServerStatusOptions**](ImapServerStatusOptions) |  |  |
| **inboxId** | **Guid?** | Inbox ID to list | [optional]  |

### Return type

[**ImapServerStatusResult**](ImapServerStatusResult)

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

<a name="imapserverupdateflags"></a>
# **ImapServerUpdateFlags**
> void ImapServerUpdateFlags (ImapUpdateFlagsOptions imapUpdateFlagsOptions, Guid? inboxId = null)



Update message flags

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ImapServerUpdateFlagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ImapControllerApi(config);
            var imapUpdateFlagsOptions = new ImapUpdateFlagsOptions(); // ImapUpdateFlagsOptions | 
            var inboxId = "inboxId_example";  // Guid? |  (optional) 

            try
            {
                apiInstance.ImapServerUpdateFlags(imapUpdateFlagsOptions, inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImapControllerApi.ImapServerUpdateFlags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImapServerUpdateFlagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ImapServerUpdateFlagsWithHttpInfo(imapUpdateFlagsOptions, inboxId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImapControllerApi.ImapServerUpdateFlagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imapUpdateFlagsOptions** | [**ImapUpdateFlagsOptions**](ImapUpdateFlagsOptions) |  |  |
| **inboxId** | **Guid?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

