# mailslurp_netstandard_2x.Model.AttachmentMetaData
Meta data associated with an attachment. Attachments are stored as byte blobs so the meta data is stored separately.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of attachment if given | 
**ContentType** | **string** | Content type of attachment such as &#x60;image/png&#x60; | 
**ContentLength** | **long** | Size of attachment in bytes | 
**Id** | **string** | ID of attachment. Can be used to with attachment controller endpoints to download attachment or with sending methods to attach to an email. | 
**ContentId** | **string** | CID of attachment | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

