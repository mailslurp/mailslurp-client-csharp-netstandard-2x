# mailslurp_netstandard_2x.Api.CommonActionsControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewEmailAddress**](CommonActionsControllerApi#createnewemailaddress) | **POST** /newEmailAddress | Create new random inbox |
| [**CreateRandomInbox**](CommonActionsControllerApi#createrandominbox) | **POST** /createInbox | Create new random inbox |
| [**DeleteEmailAddress**](CommonActionsControllerApi#deleteemailaddress) | **DELETE** /deleteEmailAddress | Delete inbox email address by inbox id |
| [**EmptyInbox**](CommonActionsControllerApi#emptyinbox) | **DELETE** /emptyInbox | Delete all emails in an inbox |
| [**SendEmailQuery**](CommonActionsControllerApi#sendemailquery) | **POST** /sendEmailQuery | Send an email using query parameters |
| [**SendEmailSimple**](CommonActionsControllerApi#sendemailsimple) | **POST** /sendEmail | Send an email |

<a name="createnewemailaddress"></a>
# **CreateNewEmailAddress**
> InboxDto CreateNewEmailAddress (bool? allowTeamAccess = null, bool? useDomainPool = null, DateTime? expiresAt = null, long? expiresIn = null, string emailAddress = null, string inboxType = null, string description = null, string name = null, List<string> tags = null, bool? favourite = null, bool? virtualInbox = null, bool? useShortAddress = null, string domainName = null, Guid? domainId = null, string prefix = null)

Create new random inbox

Returns an Inbox with an `id` and an `emailAddress`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateNewEmailAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var allowTeamAccess = true;  // bool? |  (optional) 
            var useDomainPool = true;  // bool? |  (optional) 
            var expiresAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var expiresIn = 789L;  // long? |  (optional) 
            var emailAddress = "emailAddress_example";  // string |  (optional) 
            var inboxType = "HTTP_INBOX";  // string |  (optional) 
            var description = "description_example";  // string |  (optional) 
            var name = "name_example";  // string |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var favourite = true;  // bool? |  (optional) 
            var virtualInbox = true;  // bool? |  (optional) 
            var useShortAddress = true;  // bool? |  (optional) 
            var domainName = "domainName_example";  // string |  (optional) 
            var domainId = "domainId_example";  // Guid? |  (optional) 
            var prefix = "prefix_example";  // string |  (optional) 

            try
            {
                // Create new random inbox
                InboxDto result = apiInstance.CreateNewEmailAddress(allowTeamAccess, useDomainPool, expiresAt, expiresIn, emailAddress, inboxType, description, name, tags, favourite, virtualInbox, useShortAddress, domainName, domainId, prefix);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.CreateNewEmailAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNewEmailAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new random inbox
    ApiResponse<InboxDto> response = apiInstance.CreateNewEmailAddressWithHttpInfo(allowTeamAccess, useDomainPool, expiresAt, expiresIn, emailAddress, inboxType, description, name, tags, favourite, virtualInbox, useShortAddress, domainName, domainId, prefix);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommonActionsControllerApi.CreateNewEmailAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allowTeamAccess** | **bool?** |  | [optional]  |
| **useDomainPool** | **bool?** |  | [optional]  |
| **expiresAt** | **DateTime?** |  | [optional]  |
| **expiresIn** | **long?** |  | [optional]  |
| **emailAddress** | **string** |  | [optional]  |
| **inboxType** | **string** |  | [optional]  |
| **description** | **string** |  | [optional]  |
| **name** | **string** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string) |  | [optional]  |
| **favourite** | **bool?** |  | [optional]  |
| **virtualInbox** | **bool?** |  | [optional]  |
| **useShortAddress** | **bool?** |  | [optional]  |
| **domainName** | **string** |  | [optional]  |
| **domainId** | **Guid?** |  | [optional]  |
| **prefix** | **string** |  | [optional]  |

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
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="createrandominbox"></a>
# **CreateRandomInbox**
> InboxDto CreateRandomInbox (bool? allowTeamAccess = null, bool? useDomainPool = null, DateTime? expiresAt = null, long? expiresIn = null, string emailAddress = null, string inboxType = null, string description = null, string name = null, List<string> tags = null, bool? favourite = null, bool? virtualInbox = null, bool? useShortAddress = null, string domainName = null, Guid? domainId = null, string prefix = null)

Create new random inbox

Returns an Inbox with an `id` and an `emailAddress`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateRandomInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var allowTeamAccess = true;  // bool? |  (optional) 
            var useDomainPool = true;  // bool? |  (optional) 
            var expiresAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var expiresIn = 789L;  // long? |  (optional) 
            var emailAddress = "emailAddress_example";  // string |  (optional) 
            var inboxType = "HTTP_INBOX";  // string |  (optional) 
            var description = "description_example";  // string |  (optional) 
            var name = "name_example";  // string |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 
            var favourite = true;  // bool? |  (optional) 
            var virtualInbox = true;  // bool? |  (optional) 
            var useShortAddress = true;  // bool? |  (optional) 
            var domainName = "domainName_example";  // string |  (optional) 
            var domainId = "domainId_example";  // Guid? |  (optional) 
            var prefix = "prefix_example";  // string |  (optional) 

            try
            {
                // Create new random inbox
                InboxDto result = apiInstance.CreateRandomInbox(allowTeamAccess, useDomainPool, expiresAt, expiresIn, emailAddress, inboxType, description, name, tags, favourite, virtualInbox, useShortAddress, domainName, domainId, prefix);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.CreateRandomInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRandomInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new random inbox
    ApiResponse<InboxDto> response = apiInstance.CreateRandomInboxWithHttpInfo(allowTeamAccess, useDomainPool, expiresAt, expiresIn, emailAddress, inboxType, description, name, tags, favourite, virtualInbox, useShortAddress, domainName, domainId, prefix);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommonActionsControllerApi.CreateRandomInboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allowTeamAccess** | **bool?** |  | [optional]  |
| **useDomainPool** | **bool?** |  | [optional]  |
| **expiresAt** | **DateTime?** |  | [optional]  |
| **expiresIn** | **long?** |  | [optional]  |
| **emailAddress** | **string** |  | [optional]  |
| **inboxType** | **string** |  | [optional]  |
| **description** | **string** |  | [optional]  |
| **name** | **string** |  | [optional]  |
| **tags** | [**List&lt;string&gt;**](string) |  | [optional]  |
| **favourite** | **bool?** |  | [optional]  |
| **virtualInbox** | **bool?** |  | [optional]  |
| **useShortAddress** | **bool?** |  | [optional]  |
| **domainName** | **string** |  | [optional]  |
| **domainId** | **Guid?** |  | [optional]  |
| **prefix** | **string** |  | [optional]  |

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
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="deleteemailaddress"></a>
# **DeleteEmailAddress**
> void DeleteEmailAddress (Guid inboxId)

Delete inbox email address by inbox id

Deletes inbox email address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteEmailAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var inboxId = "inboxId_example";  // Guid | 

            try
            {
                // Delete inbox email address by inbox id
                apiInstance.DeleteEmailAddress(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.DeleteEmailAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEmailAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete inbox email address by inbox id
    apiInstance.DeleteEmailAddressWithHttpInfo(inboxId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommonActionsControllerApi.DeleteEmailAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid** |  |  |

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

<a name="emptyinbox"></a>
# **EmptyInbox**
> void EmptyInbox (Guid inboxId)

Delete all emails in an inbox

Deletes all emails

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class EmptyInboxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var inboxId = "inboxId_example";  // Guid | 

            try
            {
                // Delete all emails in an inbox
                apiInstance.EmptyInbox(inboxId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.EmptyInbox: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmptyInboxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all emails in an inbox
    apiInstance.EmptyInboxWithHttpInfo(inboxId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommonActionsControllerApi.EmptyInboxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboxId** | **Guid** |  |  |

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

<a name="sendemailquery"></a>
# **SendEmailQuery**
> void SendEmailQuery (string to, Guid? senderId = null, string body = null, string subject = null)

Send an email using query parameters

If no senderId or inboxId provided a random email address will be used to send from. Ensure your parameters are URL encoded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class SendEmailQueryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var to = "to_example";  // string | Email address to send to
            var senderId = "senderId_example";  // Guid? | ID of inbox to send from. If null an inbox will be created for sending (optional) 
            var body = "body_example";  // string | Body of the email message. Supports HTML (optional) 
            var subject = "subject_example";  // string | Subject line of the email (optional) 

            try
            {
                // Send an email using query parameters
                apiInstance.SendEmailQuery(to, senderId, body, subject);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.SendEmailQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendEmailQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an email using query parameters
    apiInstance.SendEmailQueryWithHttpInfo(to, senderId, body, subject);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommonActionsControllerApi.SendEmailQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **to** | **string** | Email address to send to |  |
| **senderId** | **Guid?** | ID of inbox to send from. If null an inbox will be created for sending | [optional]  |
| **body** | **string** | Body of the email message. Supports HTML | [optional]  |
| **subject** | **string** | Subject line of the email | [optional]  |

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
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

<a name="sendemailsimple"></a>
# **SendEmailSimple**
> void SendEmailSimple (SimpleSendEmailOptions simpleSendEmailOptions)

Send an email

If no senderId or inboxId provided a random email address will be used to send from.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class SendEmailSimpleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new CommonActionsControllerApi(config);
            var simpleSendEmailOptions = new SimpleSendEmailOptions(); // SimpleSendEmailOptions | 

            try
            {
                // Send an email
                apiInstance.SendEmailSimple(simpleSendEmailOptions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CommonActionsControllerApi.SendEmailSimple: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendEmailSimpleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an email
    apiInstance.SendEmailSimpleWithHttpInfo(simpleSendEmailOptions);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CommonActionsControllerApi.SendEmailSimpleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **simpleSendEmailOptions** | [**SimpleSendEmailOptions**](SimpleSendEmailOptions) |  |  |

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
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to Model list]](../README#documentation-for-models) [[Back to README]](../README)

