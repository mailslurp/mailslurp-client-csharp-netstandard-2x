# mailslurp_netstandard_2x.Model.PageComplaint
Paginated complaint email. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full entity use the projection ID with individual method calls.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**List&lt;Complaint&gt;**](Complaint) |  | [optional] 
**Pageable** | [**PageableObject**](PageableObject) |  | [optional] 
**TotalPages** | **int** |  | 
**TotalElements** | **long** |  | 
**Last** | **bool** |  | [optional] 
**NumberOfElements** | **int** |  | [optional] 
**First** | **bool** |  | [optional] 
**Size** | **int** |  | [optional] 
**Number** | **int** |  | [optional] 
**Sort** | [**SortObject**](SortObject) |  | [optional] 
**Empty** | **bool** |  | [optional] 

[[Back to Model list]](../README#documentation-for-models) [[Back to API list]](../README#documentation-for-api-endpoints) [[Back to README]](../README)

