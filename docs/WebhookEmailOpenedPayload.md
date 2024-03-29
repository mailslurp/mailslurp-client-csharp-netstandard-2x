# mailslurp_netstandard_2x.Model.WebhookEmailOpenedPayload
EMAIL_OPENED webhook payload. Sent to your webhook url endpoint via HTTP POST when an email containing a tracking pixel is opened and the pixel image is loaded by a reader.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageId** | **string** | Idempotent message ID. Store this ID locally or in a database to prevent message duplication. | 
**WebhookId** | **Guid** | ID of webhook entity being triggered | 
**EventName** | **string** | Name of the event type webhook is being triggered for. | 
**WebhookName** | **string** | Name of the webhook being triggered | [optional] 
**InboxId** | **Guid** | Id of the inbox | 
**PixelId** | **Guid** | ID of the tracking pixel | 
**SentEmailId** | **Guid** | ID of sent email | 
**Recipient** | **string** | Email address for the recipient of the tracking pixel | 
**CreatedAt** | **DateTime** | Date time of event creation | 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

