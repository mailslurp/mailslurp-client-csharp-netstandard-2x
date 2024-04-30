# mailslurp_netstandard_2x.Model.EmailProjection
A compact representation of a full email. Used in list endpoints to keep response sizes low. Body and attachments are not included. To get all fields of the email use the `getEmail` method with the email projection's ID. See `EmailDto` for documentation on projection properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | 
**Attachments** | **List&lt;string&gt;** |  | [optional] 
**InboxId** | **Guid** |  | 
**To** | **List&lt;string&gt;** |  | 
**DomainId** | **Guid?** |  | [optional] 
**Bcc** | **List&lt;string&gt;** |  | [optional] 
**Cc** | **List&lt;string&gt;** |  | [optional] 
**Read** | **bool** |  | 
**BodyExcerpt** | **string** |  | [optional] 
**TeamAccess** | **bool** |  | 
**BodyMD5Hash** | **string** |  | [optional] 
**TextExcerpt** | **string** |  | [optional] 
**Subject** | **string** |  | [optional] 
**Id** | **Guid** |  | 
**From** | **string** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

