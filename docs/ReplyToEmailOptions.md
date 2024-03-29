# mailslurp_netstandard_2x.Model.ReplyToEmailOptions
Options for replying to email with API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Body** | **string** | Body of the reply email you want to send | 
**IsHTML** | **bool** | Is the reply HTML | 
**From** | **string** | The from header that should be used. Optional | [optional] 
**ReplyTo** | **string** | The replyTo header that should be used. Optional | [optional] 
**CustomHeaders** | **Dictionary&lt;string, string&gt;** | Optional custom headers | [optional] 
**Charset** | **string** | The charset that your message should be sent with. Optional. Default is UTF-8 | [optional] 
**Attachments** | **List&lt;string&gt;** | List of uploaded attachments to send with the reply. Optional. | [optional] 
**TemplateVariables** | **Dictionary&lt;string, Object&gt;** | Template variables if using a template | [optional] 
**Template** | **Guid?** | Template ID to use instead of body. Will use template variable map to fill defined variable slots. | [optional] 
**SendStrategy** | **string** | How an email should be sent based on its recipients | [optional] 
**UseInboxName** | **bool?** | Optionally use inbox name as display name for sender email address | [optional] 
**Html** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

