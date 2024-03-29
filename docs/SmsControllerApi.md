# mailslurp_netstandard_2x.Api.SmsControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteSmsMessage**](SmsControllerApi#deletesmsmessage) | **DELETE** /sms/{smsId} | Delete SMS message. |
| [**DeleteSmsMessages**](SmsControllerApi#deletesmsmessages) | **DELETE** /sms | Delete all SMS messages |
| [**GetReplyForSmsMessage**](SmsControllerApi#getreplyforsmsmessage) | **GET** /sms/{smsId}/reply | Get reply for an SMS message |
| [**GetSmsCount**](SmsControllerApi#getsmscount) | **GET** /sms/count | Get SMS count |
| [**GetSmsMessage**](SmsControllerApi#getsmsmessage) | **GET** /sms/{smsId} | Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController. |
| [**GetSmsMessagesPaginated**](SmsControllerApi#getsmsmessagespaginated) | **GET** /sms | Get all SMS messages in all phone numbers in paginated form. . |
| [**GetUnreadSmsCount**](SmsControllerApi#getunreadsmscount) | **GET** /sms/unreadCount | Get unread SMS count |
| [**ReplyToSmsMessage**](SmsControllerApi#replytosmsmessage) | **POST** /sms/{smsId}/reply | Send a reply to a received SMS message. Replies are sent from the receiving number. |

<a name="deletesmsmessage"></a>
# **DeleteSmsMessage**
> void DeleteSmsMessage (Guid smsId)

Delete SMS message.

Delete an SMS message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var smsId = "smsId_example";  // Guid | 

            try
            {
                // Delete SMS message.
                apiInstance.DeleteSmsMessage(smsId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.DeleteSmsMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSmsMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SMS message.
    apiInstance.DeleteSmsMessageWithHttpInfo(smsId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.DeleteSmsMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsId** | **Guid** |  |  |

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

<a name="deletesmsmessages"></a>
# **DeleteSmsMessages**
> void DeleteSmsMessages (Guid? phoneNumberId = null)

Delete all SMS messages

Delete all SMS messages or all messages for a given phone number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteSmsMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var phoneNumberId = "phoneNumberId_example";  // Guid? |  (optional) 

            try
            {
                // Delete all SMS messages
                apiInstance.DeleteSmsMessages(phoneNumberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.DeleteSmsMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSmsMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all SMS messages
    apiInstance.DeleteSmsMessagesWithHttpInfo(phoneNumberId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.DeleteSmsMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phoneNumberId** | **Guid?** |  | [optional]  |

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

<a name="getreplyforsmsmessage"></a>
# **GetReplyForSmsMessage**
> ReplyForSms GetReplyForSmsMessage (Guid smsId)

Get reply for an SMS message

Get reply for an SMS message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetReplyForSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var smsId = "smsId_example";  // Guid | 

            try
            {
                // Get reply for an SMS message
                ReplyForSms result = apiInstance.GetReplyForSmsMessage(smsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetReplyForSmsMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReplyForSmsMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get reply for an SMS message
    ApiResponse<ReplyForSms> response = apiInstance.GetReplyForSmsMessageWithHttpInfo(smsId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.GetReplyForSmsMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsId** | **Guid** |  |  |

### Return type

[**ReplyForSms**](ReplyForSms)

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

<a name="getsmscount"></a>
# **GetSmsCount**
> CountDto GetSmsCount ()

Get SMS count

Get number of SMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetSmsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);

            try
            {
                // Get SMS count
                CountDto result = apiInstance.GetSmsCount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetSmsCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SMS count
    ApiResponse<CountDto> response = apiInstance.GetSmsCountWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.GetSmsCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CountDto**](CountDto)

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

<a name="getsmsmessage"></a>
# **GetSmsMessage**
> SmsDto GetSmsMessage (Guid smsId)

Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController.

Returns a SMS summary object with content.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var smsId = "smsId_example";  // Guid | 

            try
            {
                // Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController.
                SmsDto result = apiInstance.GetSmsMessage(smsId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetSmsMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SMS content including body. Expects SMS to exist by ID. For SMS that may not have arrived yet use the WaitForController.
    ApiResponse<SmsDto> response = apiInstance.GetSmsMessageWithHttpInfo(smsId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.GetSmsMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsId** | **Guid** |  |  |

### Return type

[**SmsDto**](SmsDto)

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

<a name="getsmsmessagespaginated"></a>
# **GetSmsMessagesPaginated**
> PageSmsProjection GetSmsMessagesPaginated (Guid? phoneNumber = null, int? page = null, int? size = null, string sort = null, bool? unreadOnly = null, DateTime? since = null, DateTime? before = null)

Get all SMS messages in all phone numbers in paginated form. .

By default returns all SMS messages across all phone numbers sorted by ascending created at date. Responses are paginated. You can restrict results to a list of phone number IDs. You can also filter out read messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetSmsMessagesPaginatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var phoneNumber = "phoneNumber_example";  // Guid? | Optional receiving phone number to filter SMS messages for (optional) 
            var page = 0;  // int? | Optional page index in SMS list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in SMS list pagination. Maximum size is 100. Use page index and sort to page through larger results (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var unreadOnly = false;  // bool? | Optional filter for unread SMS only. All SMS are considered unread until they are viewed in the dashboard or requested directly (optional)  (default to false)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Optional filter SMSs received after given date time (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Optional filter SMSs received before given date time (optional) 

            try
            {
                // Get all SMS messages in all phone numbers in paginated form. .
                PageSmsProjection result = apiInstance.GetSmsMessagesPaginated(phoneNumber, page, size, sort, unreadOnly, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetSmsMessagesPaginated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmsMessagesPaginatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all SMS messages in all phone numbers in paginated form. .
    ApiResponse<PageSmsProjection> response = apiInstance.GetSmsMessagesPaginatedWithHttpInfo(phoneNumber, page, size, sort, unreadOnly, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.GetSmsMessagesPaginatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phoneNumber** | **Guid?** | Optional receiving phone number to filter SMS messages for | [optional]  |
| **page** | **int?** | Optional page index in SMS list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in SMS list pagination. Maximum size is 100. Use page index and sort to page through larger results | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **unreadOnly** | **bool?** | Optional filter for unread SMS only. All SMS are considered unread until they are viewed in the dashboard or requested directly | [optional] [default to false] |
| **since** | **DateTime?** | Optional filter SMSs received after given date time | [optional]  |
| **before** | **DateTime?** | Optional filter SMSs received before given date time | [optional]  |

### Return type

[**PageSmsProjection**](PageSmsProjection)

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

<a name="getunreadsmscount"></a>
# **GetUnreadSmsCount**
> UnreadCount GetUnreadSmsCount ()

Get unread SMS count

Get number of SMS unread. Unread means has not been viewed in dashboard or returned in an email API response

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetUnreadSmsCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);

            try
            {
                // Get unread SMS count
                UnreadCount result = apiInstance.GetUnreadSmsCount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.GetUnreadSmsCount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUnreadSmsCountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get unread SMS count
    ApiResponse<UnreadCount> response = apiInstance.GetUnreadSmsCountWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.GetUnreadSmsCountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnreadCount**](UnreadCount)

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

<a name="replytosmsmessage"></a>
# **ReplyToSmsMessage**
> SentSmsDto ReplyToSmsMessage (Guid smsId, SmsReplyOptions smsReplyOptions)

Send a reply to a received SMS message. Replies are sent from the receiving number.

Reply to an SMS message.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ReplyToSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new SmsControllerApi(config);
            var smsId = "smsId_example";  // Guid | 
            var smsReplyOptions = new SmsReplyOptions(); // SmsReplyOptions | 

            try
            {
                // Send a reply to a received SMS message. Replies are sent from the receiving number.
                SentSmsDto result = apiInstance.ReplyToSmsMessage(smsId, smsReplyOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmsControllerApi.ReplyToSmsMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplyToSmsMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a reply to a received SMS message. Replies are sent from the receiving number.
    ApiResponse<SentSmsDto> response = apiInstance.ReplyToSmsMessageWithHttpInfo(smsId, smsReplyOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmsControllerApi.ReplyToSmsMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsId** | **Guid** |  |  |
| **smsReplyOptions** | [**SmsReplyOptions**](SmsReplyOptions) |  |  |

### Return type

[**SentSmsDto**](SentSmsDto)

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

