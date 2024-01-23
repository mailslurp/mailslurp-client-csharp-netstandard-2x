# mailslurp_netstandard_2x.Model.InboxForwarderDto
Inbox forwarder. Describes how an inbox will forward matching emails to designated recipients.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**InboxId** | **Guid** |  | 
**Name** | **string** | Name of inbox forwarder | [optional] 
**Field** | **string** | Which field to match against | 
**Match** | **string** | Wild-card type pattern to apply to field | 
**ForwardToRecipients** | **List&lt;string&gt;** | Who to send forwarded email to | 
**CreatedAt** | **DateTime** |  | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

