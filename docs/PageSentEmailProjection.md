# mailslurp_netstandard_2x.Model.PageSentEmailProjection
Paginated sent email results. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full sent email entity use the projection ID with individual method calls.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;SentEmailProjection&gt;**](SentEmailProjection) | Collection of items | 
**Pageable** | [**PageableObject**](PageableObject) |  | [optional] 
**Total** | **long** |  | [optional] 
**NumberOfElements** | **int** | Number of items returned | 
**TotalElements** | **long** | Total number of items available for querying | 
**TotalPages** | **int** | Total number of pages available | 
**Size** | **int** | Size of page requested | 
**Number** | **int** | Page number starting at 0 | 
**Last** | **bool** |  | [optional] 
**First** | **bool** |  | [optional] 
**Sort** | [**SortObject**](SortObject) |  | [optional] 
**Empty** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

