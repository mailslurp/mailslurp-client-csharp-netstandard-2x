# mailslurp_netstandard_2x.Api.InboxReplierControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewInboxReplier**](InboxReplierControllerApi#createnewinboxreplier) | **POST** /repliers | Create an inbox replier |
| [**DeleteInboxReplier**](InboxReplierControllerApi#deleteinboxreplier) | **DELETE** /repliers/{id} | Delete an inbox replier |
| [**DeleteInboxRepliers**](InboxReplierControllerApi#deleteinboxrepliers) | **DELETE** /repliers | Delete inbox repliers |
| [**GetInboxReplier**](InboxReplierControllerApi#getinboxreplier) | **GET** /repliers/{id} | Get an inbox replier |
| [**GetInboxReplierEvents**](InboxReplierControllerApi#getinboxreplierevents) | **GET** /repliers/{id}/events | Get an inbox replier event list |
| [**GetInboxRepliers**](InboxReplierControllerApi#getinboxrepliers) | **GET** /repliers | List inbox repliers |
| [**UpdateInboxReplier**](InboxReplierControllerApi#updateinboxreplier) | **PUT** /repliers/{id} | Update an inbox replier |

<a name="createnewinboxreplier"></a>
# **CreateNewInboxReplier**
> InboxReplierDto CreateNewInboxReplier (CreateInboxReplierOptions createInboxReplierOptions)

Create an inbox replier

Create a new inbox rule for reply toing, blocking, and allowing emails when sending and receiving

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateNewInboxReplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var createInboxReplierOptions = new CreateInboxReplierOptions(); // CreateInboxReplierOptions | 

            try
            {
                // Create an inbox replier
                InboxReplierDto result = apiInstance.CreateNewInboxReplier(createInboxReplierOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.CreateNewInboxReplier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewInboxReplierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inbox replier
    ApiResponse<InboxReplierDto> response = apiInstance.CreateNewInboxReplierWithHttpInfo(createInboxReplierOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.CreateNewInboxReplierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInboxReplierOptions** | [**CreateInboxReplierOptions**](CreateInboxReplierOptions) |  |  |

### Return type

[**InboxReplierDto**](InboxReplierDto)

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

<a name="deleteinboxreplier"></a>
# **DeleteInboxReplier**
> void DeleteInboxReplier (Guid id)

Delete an inbox replier

Delete inbox replier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteInboxReplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox replier

            try
            {
                // Delete an inbox replier
                apiInstance.DeleteInboxReplier(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.DeleteInboxReplier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInboxReplierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an inbox replier
    apiInstance.DeleteInboxReplierWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.DeleteInboxReplierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox replier |  |

### Return type

void (empty response body)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="deleteinboxrepliers"></a>
# **DeleteInboxRepliers**
> void DeleteInboxRepliers (Guid? inboxId = null)

Delete inbox repliers

Delete inbox repliers. Accepts optional inboxId filter.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteInboxRepliersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var inboxId = "inboxId_example";  // Guid? | Optional inbox id to attach replier to (optional) 

            try
            {
                // Delete inbox repliers
                apiInstance.DeleteInboxRepliers(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.DeleteInboxRepliers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInboxRepliersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete inbox repliers
    apiInstance.DeleteInboxRepliersWithHttpInfo(inboxId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.DeleteInboxRepliersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid?** | Optional inbox id to attach replier to | [optional]  |

### Return type

void (empty response body)

### Authorization

[API_KEY](../README#API_KEY)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="getinboxreplier"></a>
# **GetInboxReplier**
> InboxReplierDto GetInboxReplier (Guid id)

Get an inbox replier

Get inbox ruleset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetInboxReplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox replier

            try
            {
                // Get an inbox replier
                InboxReplierDto result = apiInstance.GetInboxReplier(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.GetInboxReplier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxReplierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox replier
    ApiResponse<InboxReplierDto> response = apiInstance.GetInboxReplierWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.GetInboxReplierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox replier |  |

### Return type

[**InboxReplierDto**](InboxReplierDto)

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

<a name="getinboxreplierevents"></a>
# **GetInboxReplierEvents**
> PageInboxReplierEvents GetInboxReplierEvents (Guid id, int? page = null, int? size = null, string sort = null)

Get an inbox replier event list

Get inbox ruleset events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetInboxReplierEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox replier
            var page = 0;  // int? | Optional page index in inbox replier event list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in inbox replier event list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)

            try
            {
                // Get an inbox replier event list
                PageInboxReplierEvents result = apiInstance.GetInboxReplierEvents(id, page, size, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.GetInboxReplierEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxReplierEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox replier event list
    ApiResponse<PageInboxReplierEvents> response = apiInstance.GetInboxReplierEventsWithHttpInfo(id, page, size, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.GetInboxReplierEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox replier |  |
| **page** | **int?** | Optional page index in inbox replier event list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in inbox replier event list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |

### Return type

[**PageInboxReplierEvents**](PageInboxReplierEvents)

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

<a name="getinboxrepliers"></a>
# **GetInboxRepliers**
> PageInboxReplierDto GetInboxRepliers (Guid? inboxId = null, int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

List inbox repliers

List all repliers attached to an inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetInboxRepliersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var inboxId = "inboxId_example";  // Guid? | Optional inbox id to get repliers from (optional) 
            var page = 0;  // int? | Optional page index in inbox replier list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in inbox replier list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // List inbox repliers
                PageInboxReplierDto result = apiInstance.GetInboxRepliers(inboxId, page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.GetInboxRepliers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInboxRepliersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List inbox repliers
    ApiResponse<PageInboxReplierDto> response = apiInstance.GetInboxRepliersWithHttpInfo(inboxId, page, size, sort, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.GetInboxRepliersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid?** | Optional inbox id to get repliers from | [optional]  |
| **page** | **int?** | Optional page index in inbox replier list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in inbox replier list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageInboxReplierDto**](PageInboxReplierDto)

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

<a name="updateinboxreplier"></a>
# **UpdateInboxReplier**
> InboxReplierDto UpdateInboxReplier (Guid id, UpdateInboxReplierOptions updateInboxReplierOptions)

Update an inbox replier

Update inbox ruleset

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class UpdateInboxReplierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new InboxReplierControllerApi(config);
            var id = "id_example";  // Guid | ID of inbox replier
            var updateInboxReplierOptions = new UpdateInboxReplierOptions(); // UpdateInboxReplierOptions | 

            try
            {
                // Update an inbox replier
                InboxReplierDto result = apiInstance.UpdateInboxReplier(id, updateInboxReplierOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InboxReplierControllerApi.UpdateInboxReplier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInboxReplierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an inbox replier
    ApiResponse<InboxReplierDto> response = apiInstance.UpdateInboxReplierWithHttpInfo(id, updateInboxReplierOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InboxReplierControllerApi.UpdateInboxReplierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | ID of inbox replier |  |
| **updateInboxReplierOptions** | [**UpdateInboxReplierOptions**](UpdateInboxReplierOptions) |  |  |

### Return type

[**InboxReplierDto**](InboxReplierDto)

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

