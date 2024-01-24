# mailslurp_netstandard_2x.Model.UpdateInboxReplierOptions
Options for updating an inbox replier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InboxId** | **Guid** | Inbox ID to attach replier to | 
**Name** | **string** | Name for replier | [optional] 
**Field** | **string** | Field to match against to trigger inbox replier for inbound email | 
**Match** | **string** | String or wildcard style match for field specified when evaluating reply rules | 
**ReplyTo** | **string** | Reply-to email address when sending replying | [optional] 
**Subject** | **string** | Subject override when replying to email | [optional] 
**From** | **string** | Send email from address | [optional] 
**Charset** | **string** | Email reply charset | [optional] 
**IsHTML** | **bool?** | Send HTML email | [optional] 
**IgnoreReplyTo** | **bool?** | Ignore sender replyTo when responding. Send directly to the sender if enabled. | [optional] 
**Body** | **string** | Email body for reply | [optional] 
**TemplateId** | **Guid?** | ID of template to use when sending a reply | [optional] 
**TemplateVariables** | **Dictionary&lt;string, Object&gt;** | Template variable values | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

