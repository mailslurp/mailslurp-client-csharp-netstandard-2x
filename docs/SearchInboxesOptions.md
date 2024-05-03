# mailslurp_netstandard_2x.Model.SearchInboxesOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PageIndex** | **int?** | Optional page index in list pagination | [optional] 
**PageSize** | **int?** | Optional page size in list pagination | [optional] 
**SortDirection** | **string** | Optional createdAt sort direction ASC or DESC | [optional] 
**Favourite** | **bool?** | Optionally filter results for favourites only | [optional] 
**Search** | **string** | Optionally filter by search words partial matching ID, tags, name, and email address | [optional] 
**Tag** | **string** | Optionally filter by tags. Will return inboxes that include given tags | [optional] 
**Since** | **DateTime?** | Optional filter by created after given date time | [optional] 
**Before** | **DateTime?** | Optional filter by created before given date time | [optional] 
**InboxType** | **string** | Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send). | [optional] 
**InboxFunction** | **string** | Optional filter by inbox function | [optional] 
**DomainId** | **Guid?** | Optional domain ID filter | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

