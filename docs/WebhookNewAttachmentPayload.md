# mailslurp_netstandard_2x.Model.WebhookNewAttachmentPayload
NEW_ATTACHMENT webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to that contains an attachment. You can use the attachmentId to download the attachment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**AttachmentId** | **string** | ID of attachment. Use the &#x60;AttachmentController&#x60; to | 
**Name** | **string** | Filename of the attachment if present | 
**ContentType** | **string** | Content type of attachment such as &#39;image/png&#39; or &#39;application/pdf | 
**ContentLength** | **long** | Size of attachment in bytes | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

