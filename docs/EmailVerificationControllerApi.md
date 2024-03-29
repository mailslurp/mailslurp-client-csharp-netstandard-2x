# mailslurp_netstandard_2x.Api.EmailVerificationControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAllValidationRequests**](EmailVerificationControllerApi#deleteallvalidationrequests) | **DELETE** /email-verification | Delete all validation requests |
| [**DeleteValidationRequest**](EmailVerificationControllerApi#deletevalidationrequest) | **DELETE** /email-verification/{id} | Delete a validation record |
| [**GetValidationRequests**](EmailVerificationControllerApi#getvalidationrequests) | **GET** /email-verification/validation-requests | Validate a list of email addresses. Per unit billing. See your plan for pricing. |
| [**ValidateEmailAddressList**](EmailVerificationControllerApi#validateemailaddresslist) | **POST** /email-verification/email-address-list | Validate a list of email addresses. Per unit billing. See your plan for pricing. |

<a name="deleteallvalidationrequests"></a>
# **DeleteAllValidationRequests**
> void DeleteAllValidationRequests ()

Delete all validation requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteAllValidationRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EmailVerificationControllerApi(config);

            try
            {
                // Delete all validation requests
                apiInstance.DeleteAllValidationRequests();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailVerificationControllerApi.DeleteAllValidationRequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllValidationRequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete all validation requests
    apiInstance.DeleteAllValidationRequestsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailVerificationControllerApi.DeleteAllValidationRequestsWithHttpInfo: " + e.Message);
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

<a name="deletevalidationrequest"></a>
# **DeleteValidationRequest**
> void DeleteValidationRequest (Guid id)

Delete a validation record

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteValidationRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EmailVerificationControllerApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                // Delete a validation record
                apiInstance.DeleteValidationRequest(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailVerificationControllerApi.DeleteValidationRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteValidationRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a validation record
    apiInstance.DeleteValidationRequestWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailVerificationControllerApi.DeleteValidationRequestWithHttpInfo: " + e.Message);
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

<a name="getvalidationrequests"></a>
# **GetValidationRequests**
> PageEmailValidationRequest GetValidationRequests (int? page = null, int? size = null, string sort = null, string searchFilter = null, DateTime? since = null, DateTime? before = null, bool? isValid = null)

Validate a list of email addresses. Per unit billing. See your plan for pricing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetValidationRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EmailVerificationControllerApi(config);
            var page = 0;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size for paginated result list. (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to DESC)
            var searchFilter = "searchFilter_example";  // string | Optional search filter (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 
            var isValid = true;  // bool? | Filter where email is valid is true or false (optional) 

            try
            {
                // Validate a list of email addresses. Per unit billing. See your plan for pricing.
                PageEmailValidationRequest result = apiInstance.GetValidationRequests(page, size, sort, searchFilter, since, before, isValid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailVerificationControllerApi.GetValidationRequests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValidationRequestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a list of email addresses. Per unit billing. See your plan for pricing.
    ApiResponse<PageEmailValidationRequest> response = apiInstance.GetValidationRequestsWithHttpInfo(page, size, sort, searchFilter, since, before, isValid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailVerificationControllerApi.GetValidationRequestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Optional page index in list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size for paginated result list. | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to DESC] |
| **searchFilter** | **string** | Optional search filter | [optional]  |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |
| **isValid** | **bool?** | Filter where email is valid is true or false | [optional]  |

### Return type

[**PageEmailValidationRequest**](PageEmailValidationRequest)

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

<a name="validateemailaddresslist"></a>
# **ValidateEmailAddressList**
> ValidateEmailAddressListResult ValidateEmailAddressList (ValidateEmailAddressListOptions validateEmailAddressListOptions)

Validate a list of email addresses. Per unit billing. See your plan for pricing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class ValidateEmailAddressListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new EmailVerificationControllerApi(config);
            var validateEmailAddressListOptions = new ValidateEmailAddressListOptions(); // ValidateEmailAddressListOptions | 

            try
            {
                // Validate a list of email addresses. Per unit billing. See your plan for pricing.
                ValidateEmailAddressListResult result = apiInstance.ValidateEmailAddressList(validateEmailAddressListOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmailVerificationControllerApi.ValidateEmailAddressList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateEmailAddressListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a list of email addresses. Per unit billing. See your plan for pricing.
    ApiResponse<ValidateEmailAddressListResult> response = apiInstance.ValidateEmailAddressListWithHttpInfo(validateEmailAddressListOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EmailVerificationControllerApi.ValidateEmailAddressListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateEmailAddressListOptions** | [**ValidateEmailAddressListOptions**](ValidateEmailAddressListOptions) |  |  |

### Return type

[**ValidateEmailAddressListResult**](ValidateEmailAddressListResult)

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

