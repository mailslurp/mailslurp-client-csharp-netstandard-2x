# mailslurp_netstandard_2x.Api.ConnectorControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateConnector**](ConnectorControllerApi#createconnector) | **POST** /connectors | Create an inbox connector |
| [**CreateConnectorImapConnection**](ConnectorControllerApi#createconnectorimapconnection) | **POST** /connectors/{id}/imap | Create an inbox connector IMAP connection |
| [**CreateConnectorSmtpConnection**](ConnectorControllerApi#createconnectorsmtpconnection) | **POST** /connectors/{id}/smtp | Create an inbox connector SMTP connection |
| [**DeleteAllConnector**](ConnectorControllerApi#deleteallconnector) | **DELETE** /connectors | Delete all inbox connectors |
| [**DeleteConnector**](ConnectorControllerApi#deleteconnector) | **DELETE** /connectors/{id} | Delete an inbox connector |
| [**DeleteConnectorImapConnection**](ConnectorControllerApi#deleteconnectorimapconnection) | **DELETE** /connectors/{id}/imap | Delete an inbox connector IMAP connection |
| [**DeleteConnectorSmtpConnection**](ConnectorControllerApi#deleteconnectorsmtpconnection) | **DELETE** /connectors/{id}/smtp | Delete an inbox connector SMTP connection |
| [**GetAllConnectorSyncEvents**](ConnectorControllerApi#getallconnectorsyncevents) | **GET** /connectors/events | Get all inbox connector sync events |
| [**GetConnector**](ConnectorControllerApi#getconnector) | **GET** /connectors/{id} | Get an inbox connector |
| [**GetConnectorSyncEvent**](ConnectorControllerApi#getconnectorsyncevent) | **GET** /connectors/events/{id} | Get an inbox connector sync event |
| [**GetConnectorSyncEvents**](ConnectorControllerApi#getconnectorsyncevents) | **GET** /connectors/{id}/events | Get an inbox connector sync events |
| [**GetConnectors**](ConnectorControllerApi#getconnectors) | **GET** /connectors | Get inbox connectors |
| [**SyncConnector**](ConnectorControllerApi#syncconnector) | **POST** /connectors/{id}/sync | Sync an inbox connector |
| [**UpdateConnector**](ConnectorControllerApi#updateconnector) | **PUT** /connectors/{id} | Update an inbox connector |

<a name="createconnector"></a>
# **CreateConnector**
> ConnectorDto CreateConnector (CreateConnectorOptions createConnectorOptions)

Create an inbox connector

Sync emails between external mailboxes and MailSlurp inboxes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var createConnectorOptions = new CreateConnectorOptions(); // CreateConnectorOptions | 

            try
            {
                // Create an inbox connector
                ConnectorDto result = apiInstance.CreateConnector(createConnectorOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.CreateConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inbox connector
    ApiResponse<ConnectorDto> response = apiInstance.CreateConnectorWithHttpInfo(createConnectorOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.CreateConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createConnectorOptions** | [**CreateConnectorOptions**](CreateConnectorOptions) |  |  |

### Return type

[**ConnectorDto**](ConnectorDto)

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

<a name="createconnectorimapconnection"></a>
# **CreateConnectorImapConnection**
> ConnectorImapConnectionDto CreateConnectorImapConnection (Guid id, CreateConnectorImapConnectionOptions createConnectorImapConnectionOptions)

Create an inbox connector IMAP connection

Allows the reading of emails in an external mailbox and syncing to a MailSlurp inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateConnectorImapConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 
            var createConnectorImapConnectionOptions = new CreateConnectorImapConnectionOptions(); // CreateConnectorImapConnectionOptions | 

            try
            {
                // Create an inbox connector IMAP connection
                ConnectorImapConnectionDto result = apiInstance.CreateConnectorImapConnection(id, createConnectorImapConnectionOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.CreateConnectorImapConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConnectorImapConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inbox connector IMAP connection
    ApiResponse<ConnectorImapConnectionDto> response = apiInstance.CreateConnectorImapConnectionWithHttpInfo(id, createConnectorImapConnectionOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.CreateConnectorImapConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **createConnectorImapConnectionOptions** | [**CreateConnectorImapConnectionOptions**](CreateConnectorImapConnectionOptions) |  |  |

### Return type

[**ConnectorImapConnectionDto**](ConnectorImapConnectionDto)

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

<a name="createconnectorsmtpconnection"></a>
# **CreateConnectorSmtpConnection**
> ConnectorSmtpConnectionDto CreateConnectorSmtpConnection (Guid id, CreateConnectorSmtpConnectionOptions createConnectorSmtpConnectionOptions)

Create an inbox connector SMTP connection

Allows sending via connector and email is routed to connected inbox and sent via SMTP

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateConnectorSmtpConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 
            var createConnectorSmtpConnectionOptions = new CreateConnectorSmtpConnectionOptions(); // CreateConnectorSmtpConnectionOptions | 

            try
            {
                // Create an inbox connector SMTP connection
                ConnectorSmtpConnectionDto result = apiInstance.CreateConnectorSmtpConnection(id, createConnectorSmtpConnectionOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.CreateConnectorSmtpConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConnectorSmtpConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an inbox connector SMTP connection
    ApiResponse<ConnectorSmtpConnectionDto> response = apiInstance.CreateConnectorSmtpConnectionWithHttpInfo(id, createConnectorSmtpConnectionOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.CreateConnectorSmtpConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **createConnectorSmtpConnectionOptions** | [**CreateConnectorSmtpConnectionOptions**](CreateConnectorSmtpConnectionOptions) |  |  |

### Return type

[**ConnectorSmtpConnectionDto**](ConnectorSmtpConnectionDto)

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

<a name="deleteallconnector"></a>
# **DeleteAllConnector**
> void DeleteAllConnector ()

Delete all inbox connectors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteAllConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);

            try
            {
                // Delete all inbox connectors
                apiInstance.DeleteAllConnector();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.DeleteAllConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all inbox connectors
    apiInstance.DeleteAllConnectorWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.DeleteAllConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a name="deleteconnector"></a>
# **DeleteConnector**
> void DeleteConnector (Guid id)

Delete an inbox connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete an inbox connector
                apiInstance.DeleteConnector(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.DeleteConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an inbox connector
    apiInstance.DeleteConnectorWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.DeleteConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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

<a name="deleteconnectorimapconnection"></a>
# **DeleteConnectorImapConnection**
> void DeleteConnectorImapConnection (Guid id)

Delete an inbox connector IMAP connection

Delete IMAP connection for external inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteConnectorImapConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete an inbox connector IMAP connection
                apiInstance.DeleteConnectorImapConnection(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.DeleteConnectorImapConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteConnectorImapConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an inbox connector IMAP connection
    apiInstance.DeleteConnectorImapConnectionWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.DeleteConnectorImapConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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

<a name="deleteconnectorsmtpconnection"></a>
# **DeleteConnectorSmtpConnection**
> void DeleteConnectorSmtpConnection (Guid id)

Delete an inbox connector SMTP connection

Delete SMTP connection for external inbox

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteConnectorSmtpConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete an inbox connector SMTP connection
                apiInstance.DeleteConnectorSmtpConnection(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.DeleteConnectorSmtpConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteConnectorSmtpConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an inbox connector SMTP connection
    apiInstance.DeleteConnectorSmtpConnectionWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.DeleteConnectorSmtpConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

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

<a name="getallconnectorsyncevents"></a>
# **GetAllConnectorSyncEvents**
> PageConnectorSyncEvents GetAllConnectorSyncEvents (int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get all inbox connector sync events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetAllConnectorSyncEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var page = 0;  // int? | Optional page index in connector list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in connector list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get all inbox connector sync events
                PageConnectorSyncEvents result = apiInstance.GetAllConnectorSyncEvents(page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.GetAllConnectorSyncEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllConnectorSyncEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all inbox connector sync events
    ApiResponse<PageConnectorSyncEvents> response = apiInstance.GetAllConnectorSyncEventsWithHttpInfo(page, size, sort, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.GetAllConnectorSyncEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Optional page index in connector list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in connector list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageConnectorSyncEvents**](PageConnectorSyncEvents)

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

<a name="getconnector"></a>
# **GetConnector**
> ConnectorDto GetConnector (Guid id)

Get an inbox connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get an inbox connector
                ConnectorDto result = apiInstance.GetConnector(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.GetConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox connector
    ApiResponse<ConnectorDto> response = apiInstance.GetConnectorWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.GetConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConnectorDto**](ConnectorDto)

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

<a name="getconnectorsyncevent"></a>
# **GetConnectorSyncEvent**
> ConnectorSyncEventDto GetConnectorSyncEvent (Guid id)

Get an inbox connector sync event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetConnectorSyncEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Get an inbox connector sync event
                ConnectorSyncEventDto result = apiInstance.GetConnectorSyncEvent(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.GetConnectorSyncEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConnectorSyncEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox connector sync event
    ApiResponse<ConnectorSyncEventDto> response = apiInstance.GetConnectorSyncEventWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.GetConnectorSyncEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConnectorSyncEventDto**](ConnectorSyncEventDto)

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

<a name="getconnectorsyncevents"></a>
# **GetConnectorSyncEvents**
> PageConnectorSyncEvents GetConnectorSyncEvents (Guid id, int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get an inbox connector sync events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetConnectorSyncEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 
            var page = 0;  // int? | Optional page index in connector list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in connector list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get an inbox connector sync events
                PageConnectorSyncEvents result = apiInstance.GetConnectorSyncEvents(id, page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.GetConnectorSyncEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConnectorSyncEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an inbox connector sync events
    ApiResponse<PageConnectorSyncEvents> response = apiInstance.GetConnectorSyncEventsWithHttpInfo(id, page, size, sort, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.GetConnectorSyncEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **page** | **int?** | Optional page index in connector list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in connector list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageConnectorSyncEvents**](PageConnectorSyncEvents)

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

<a name="getconnectors"></a>
# **GetConnectors**
> PageConnector GetConnectors (int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get inbox connectors

List inbox connectors that sync external emails to MailSlurp inboxes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetConnectorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var page = 0;  // int? | Optional page index in connector list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in connector list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get inbox connectors
                PageConnector result = apiInstance.GetConnectors(page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.GetConnectors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConnectorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get inbox connectors
    ApiResponse<PageConnector> response = apiInstance.GetConnectorsWithHttpInfo(page, size, sort, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.GetConnectorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Optional page index in connector list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in connector list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageConnector**](PageConnector)

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

<a name="syncconnector"></a>
# **SyncConnector**
> ConnectorSyncRequestResult SyncConnector (Guid id)

Sync an inbox connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class SyncConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Sync an inbox connector
                ConnectorSyncRequestResult result = apiInstance.SyncConnector(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.SyncConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SyncConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sync an inbox connector
    ApiResponse<ConnectorSyncRequestResult> response = apiInstance.SyncConnectorWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.SyncConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**ConnectorSyncRequestResult**](ConnectorSyncRequestResult)

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

<a name="updateconnector"></a>
# **UpdateConnector**
> ConnectorDto UpdateConnector (Guid id, CreateConnectorOptions createConnectorOptions)

Update an inbox connector

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class UpdateConnectorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new ConnectorControllerApi(config);
            var id = "id_example";  // Guid | 
            var createConnectorOptions = new CreateConnectorOptions(); // CreateConnectorOptions | 

            try
            {
                // Update an inbox connector
                ConnectorDto result = apiInstance.UpdateConnector(id, createConnectorOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectorControllerApi.UpdateConnector: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateConnectorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an inbox connector
    ApiResponse<ConnectorDto> response = apiInstance.UpdateConnectorWithHttpInfo(id, createConnectorOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectorControllerApi.UpdateConnectorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **createConnectorOptions** | [**CreateConnectorOptions**](CreateConnectorOptions) |  |  |

### Return type

[**ConnectorDto**](ConnectorDto)

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

