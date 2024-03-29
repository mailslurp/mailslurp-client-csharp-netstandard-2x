# mailslurp_netstandard_2x.Api.GroupControllerApi

All URIs are relative to *https://csharp.api.mailslurp.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddContactsToGroup**](GroupControllerApi#addcontactstogroup) | **PUT** /groups/{groupId}/contacts | Add contacts to a group |
| [**CreateGroup**](GroupControllerApi#creategroup) | **POST** /groups | Create a group |
| [**DeleteGroup**](GroupControllerApi#deletegroup) | **DELETE** /groups/{groupId} | Delete group |
| [**GetAllGroups**](GroupControllerApi#getallgroups) | **GET** /groups/paginated | Get all Contact Groups in paginated format |
| [**GetGroup**](GroupControllerApi#getgroup) | **GET** /groups/{groupId} | Get group |
| [**GetGroupWithContacts**](GroupControllerApi#getgroupwithcontacts) | **GET** /groups/{groupId}/contacts | Get group and contacts belonging to it |
| [**GetGroupWithContactsPaginated**](GroupControllerApi#getgroupwithcontactspaginated) | **GET** /groups/{groupId}/contacts-paginated |  |
| [**GetGroups**](GroupControllerApi#getgroups) | **GET** /groups | Get all groups |
| [**RemoveContactsFromGroup**](GroupControllerApi#removecontactsfromgroup) | **DELETE** /groups/{groupId}/contacts | Remove contacts from a group |

<a name="addcontactstogroup"></a>
# **AddContactsToGroup**
> GroupContactsDto AddContactsToGroup (Guid groupId, UpdateGroupContacts updateGroupContacts)

Add contacts to a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class AddContactsToGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var groupId = "groupId_example";  // Guid | 
            var updateGroupContacts = new UpdateGroupContacts(); // UpdateGroupContacts | 

            try
            {
                // Add contacts to a group
                GroupContactsDto result = apiInstance.AddContactsToGroup(groupId, updateGroupContacts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.AddContactsToGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddContactsToGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add contacts to a group
    ApiResponse<GroupContactsDto> response = apiInstance.AddContactsToGroupWithHttpInfo(groupId, updateGroupContacts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.AddContactsToGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |
| **updateGroupContacts** | [**UpdateGroupContacts**](UpdateGroupContacts) |  |  |

### Return type

[**GroupContactsDto**](GroupContactsDto)

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

<a name="creategroup"></a>
# **CreateGroup**
> GroupDto CreateGroup (CreateGroupOptions createGroupOptions)

Create a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var createGroupOptions = new CreateGroupOptions(); // CreateGroupOptions | 

            try
            {
                // Create a group
                GroupDto result = apiInstance.CreateGroup(createGroupOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.CreateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a group
    ApiResponse<GroupDto> response = apiInstance.CreateGroupWithHttpInfo(createGroupOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.CreateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupOptions** | [**CreateGroupOptions**](CreateGroupOptions) |  |  |

### Return type

[**GroupDto**](GroupDto)

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

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (Guid groupId)

Delete group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var groupId = "groupId_example";  // Guid | 

            try
            {
                // Delete group
                apiInstance.DeleteGroup(groupId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.DeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete group
    apiInstance.DeleteGroupWithHttpInfo(groupId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.DeleteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |

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

<a name="getallgroups"></a>
# **GetAllGroups**
> PageGroupProjection GetAllGroups (int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)

Get all Contact Groups in paginated format

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetAllGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var page = 0;  // int? | Optional page index in list pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in list pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                // Get all Contact Groups in paginated format
                PageGroupProjection result = apiInstance.GetAllGroups(page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.GetAllGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all Contact Groups in paginated format
    ApiResponse<PageGroupProjection> response = apiInstance.GetAllGroupsWithHttpInfo(page, size, sort, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.GetAllGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Optional page index in list pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in list pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageGroupProjection**](PageGroupProjection)

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

<a name="getgroup"></a>
# **GetGroup**
> GroupDto GetGroup (Guid groupId)

Get group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var groupId = "groupId_example";  // Guid | 

            try
            {
                // Get group
                GroupDto result = apiInstance.GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get group
    ApiResponse<GroupDto> response = apiInstance.GetGroupWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.GetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |

### Return type

[**GroupDto**](GroupDto)

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

<a name="getgroupwithcontacts"></a>
# **GetGroupWithContacts**
> GroupContactsDto GetGroupWithContacts (Guid groupId)

Get group and contacts belonging to it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetGroupWithContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var groupId = "groupId_example";  // Guid | 

            try
            {
                // Get group and contacts belonging to it
                GroupContactsDto result = apiInstance.GetGroupWithContacts(groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.GetGroupWithContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get group and contacts belonging to it
    ApiResponse<GroupContactsDto> response = apiInstance.GetGroupWithContactsWithHttpInfo(groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.GetGroupWithContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |

### Return type

[**GroupContactsDto**](GroupContactsDto)

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

<a name="getgroupwithcontactspaginated"></a>
# **GetGroupWithContactsPaginated**
> PageContactProjection GetGroupWithContactsPaginated (Guid groupId, int? page = null, int? size = null, string sort = null, DateTime? since = null, DateTime? before = null)



Get group and paginated contacts belonging to it

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetGroupWithContactsPaginatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var groupId = "groupId_example";  // Guid | 
            var page = 0;  // int? | Optional page index in group contact pagination (optional)  (default to 0)
            var size = 20;  // int? | Optional page size in group contact pagination (optional)  (default to 20)
            var sort = "ASC";  // string | Optional createdAt sort direction ASC or DESC (optional)  (default to ASC)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at after the given timestamp (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Filter by created at before the given timestamp (optional) 

            try
            {
                PageContactProjection result = apiInstance.GetGroupWithContactsPaginated(groupId, page, size, sort, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.GetGroupWithContactsPaginated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithContactsPaginatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PageContactProjection> response = apiInstance.GetGroupWithContactsPaginatedWithHttpInfo(groupId, page, size, sort, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.GetGroupWithContactsPaginatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |
| **page** | **int?** | Optional page index in group contact pagination | [optional] [default to 0] |
| **size** | **int?** | Optional page size in group contact pagination | [optional] [default to 20] |
| **sort** | **string** | Optional createdAt sort direction ASC or DESC | [optional] [default to ASC] |
| **since** | **DateTime?** | Filter by created at after the given timestamp | [optional]  |
| **before** | **DateTime?** | Filter by created at before the given timestamp | [optional]  |

### Return type

[**PageContactProjection**](PageContactProjection)

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

<a name="getgroups"></a>
# **GetGroups**
> List&lt;GroupProjection&gt; GetGroups ()

Get all groups

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class GetGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);

            try
            {
                // Get all groups
                List<GroupProjection> result = apiInstance.GetGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.GetGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all groups
    ApiResponse<List<GroupProjection>> response = apiInstance.GetGroupsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.GetGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;GroupProjection&gt;**](GroupProjection)

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

<a name="removecontactsfromgroup"></a>
# **RemoveContactsFromGroup**
> GroupContactsDto RemoveContactsFromGroup (Guid groupId, UpdateGroupContacts updateGroupContacts)

Remove contacts from a group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using mailslurp_netstandard_2x.Api;
using mailslurp_netstandard_2x.Client;
using mailslurp_netstandard_2x.Model;

namespace Example
{
    public class RemoveContactsFromGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://csharp.api.mailslurp.com";
            // Configure API key authorization: API_KEY
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            var apiInstance = new GroupControllerApi(config);
            var groupId = "groupId_example";  // Guid | 
            var updateGroupContacts = new UpdateGroupContacts(); // UpdateGroupContacts | 

            try
            {
                // Remove contacts from a group
                GroupContactsDto result = apiInstance.RemoveContactsFromGroup(groupId, updateGroupContacts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupControllerApi.RemoveContactsFromGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveContactsFromGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove contacts from a group
    ApiResponse<GroupContactsDto> response = apiInstance.RemoveContactsFromGroupWithHttpInfo(groupId, updateGroupContacts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupControllerApi.RemoveContactsFromGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |
| **updateGroupContacts** | [**UpdateGroupContacts**](UpdateGroupContacts) |  |  |

### Return type

[**GroupContactsDto**](GroupContactsDto)

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

