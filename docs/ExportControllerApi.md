# mailslurp_netstandard_2x.Api.ExportControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportEntities**](ExportControllerApi#exportentities) | **GET** /export | Export inboxes link callable via browser |
| [**GetExportLink**](ExportControllerApi#getexportlink) | **POST** /export | Get export link |

<a name="exportentities"></a>
# **ExportEntities**
> byte[] ExportEntities (string exportType, string apiKey, string outputFormat, string filter = null, string listSeparatorToken = null, bool? excludePreviouslyExported = null, DateTime? createdEarliestTime = null, DateTime? createdOldestTime = null)

Export inboxes link callable via browser

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ExportEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExportControllerApi(config);
            var exportType = "INBOXES";  // string | 
            var apiKey = "apiKey_example";  // string | 
            var outputFormat = "CSV_DEFAULT";  // string | 
            var filter = "filter_example";  // string |  (optional) 
            var listSeparatorToken = "listSeparatorToken_example";  // string |  (optional) 
            var excludePreviouslyExported = true;  // bool? |  (optional) 
            var createdEarliestTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var createdOldestTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                // Export inboxes link callable via browser
                byte[] result = apiInstance.ExportEntities(exportType, apiKey, outputFormat, filter, listSeparatorToken, excludePreviouslyExported, createdEarliestTime, createdOldestTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportControllerApi.ExportEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export inboxes link callable via browser
    ApiResponse<byte[]> response = apiInstance.ExportEntitiesWithHttpInfo(exportType, apiKey, outputFormat, filter, listSeparatorToken, excludePreviouslyExported, createdEarliestTime, createdOldestTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportControllerApi.ExportEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exportType** | **string** |  |  |
| **apiKey** | **string** |  |  |
| **outputFormat** | **string** |  |  |
| **filter** | **string** |  | [optional]  |
| **listSeparatorToken** | **string** |  | [optional]  |
| **excludePreviouslyExported** | **bool?** |  | [optional]  |
| **createdEarliestTime** | **DateTime?** |  | [optional]  |
| **createdOldestTime** | **DateTime?** |  | [optional]  |

### Return type

**byte[]**

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

<a name="getexportlink"></a>
# **GetExportLink**
> ExportLink GetExportLink (string exportType, ExportOptions exportOptions, string apiKey = null)

Get export link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetExportLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ExportControllerApi(config);
            var exportType = "INBOXES";  // string | 
            var exportOptions = new ExportOptions(); // ExportOptions | 
            var apiKey = "apiKey_example";  // string |  (optional) 

            try
            {
                // Get export link
                ExportLink result = apiInstance.GetExportLink(exportType, exportOptions, apiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportControllerApi.GetExportLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExportLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get export link
    ApiResponse<ExportLink> response = apiInstance.GetExportLinkWithHttpInfo(exportType, exportOptions, apiKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportControllerApi.GetExportLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exportType** | **string** |  |  |
| **exportOptions** | [**ExportOptions**](ExportOptions) |  |  |
| **apiKey** | **string** |  | [optional]  |

### Return type

[**ExportLink**](ExportLink)

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

