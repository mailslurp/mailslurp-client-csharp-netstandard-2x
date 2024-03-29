# mailslurp_netstandard_2x.Model.CreateWebhookOptions
Options for creating a webhook. Webhooks can be attached to inboxes and MailSlurp will POST a webhook payload to the URL specified whenever the webhook's event is triggered. Webhooks are great for processing many inbound emails and responding to other events at scale. Customize the payload sent to your endpoint by setting the `requestBodyTemplate` property to a string with moustache style variables. Property names from the standard payload model for the given event are available as variables.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | Public URL on your server that MailSlurp can post WebhookNotification payload to when an email is received or an event is trigger. The payload of the submitted JSON is dependent on the webhook event type. See docs.mailslurp.com/webhooks for event payload documentation. | 
**BasicAuth** | [**BasicAuthOptions**](BasicAuthOptions) |  | [optional] 
**Name** | **string** | Optional name for the webhook | [optional] 
**EventName** | **string** | Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60; and is triggered when an email is received by the inbox associated with the webhook. Payload differ according to the webhook event name. | [optional] 
**IncludeHeaders** | [**WebhookHeaders**](WebhookHeaders) |  | [optional] 
**RequestBodyTemplate** | **string** | Template for the JSON body of the webhook request that will be sent to your server. Use Moustache style &#x60;{{variableName}}&#x60; templating to use parts of the standard webhook payload for the given event. | [optional] 
**UseStaticIpRange** | **bool?** | Use static IP range when calling webhook endpoint | [optional] [default to false]
**IgnoreInsecureSslCertificates** | **bool?** | Ignore insecure SSL certificates when sending request. Useful for self-signed certs. | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

