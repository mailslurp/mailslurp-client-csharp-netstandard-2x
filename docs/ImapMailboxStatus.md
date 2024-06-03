# mailslurp_netstandard_2x.Model.ImapMailboxStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The mailbox name. | 
**ReadOnly** | **bool** | True if the mailbox is open in read-only mode. | 
**Items** | **Object** | Results map | 
**Flags** | **List&lt;string&gt;** | The mailbox flags. | 
**PermanentFlags** | **List&lt;string&gt;** | The mailbox permanent flags. | 
**UnseenSeqNum** | **long** | The sequence number of the first unseen message in the mailbox. | 
**Messages** | **int** | The number of messages in this mailbox. | 
**Recent** | **int** | The number of messages not seen since the last time the mailbox was opened. | 
**Unseen** | **int** | The number of unread messages. | 
**UidNext** | **long** | The next UID. | 
**UidValidity** | **int** | Together with a UID, it is a unique identifier for a message. Must be greater than or equal to 1. | 
**AppendLimit** | **int?** | Per-mailbox limit of message size. Set only if server supports the APPENDLIMIT extension | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

