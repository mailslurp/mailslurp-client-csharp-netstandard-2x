# mailslurp_netstandard_2x.Model.ForwardEmailOptions
Options for forwarding an email

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **List&lt;string&gt;** | To recipients for forwarded email | 
**Subject** | **string** | Subject for forwarded email | [optional] 
**Cc** | **List&lt;string&gt;** | Optional cc recipients | [optional] 
**Bcc** | **List&lt;string&gt;** | Optional bcc recipients | [optional] 
**From** | **string** | Optional from override | [optional] 
**UseInboxName** | **bool?** | Optionally use inbox name as display name for sender email address | [optional] 
**FilterBouncedRecipients** | **bool?** | Filter recipients to remove any bounced recipients from to, bcc, and cc before sending | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

