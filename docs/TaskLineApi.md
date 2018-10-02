# Io.Wirk.Api.Wirk.Api.TaskLineApi

All URIs are relative to *https://api.wirk.io/v1_0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](TaskLineApi.md#get) | **GET** /TaskLine/{id} | 
[**Post**](TaskLineApi.md#post) | **POST** /TaskLine | 


# **Get**
> TaskLineReaderServiceModel Get (int? id)



ID

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Wirk.Api.Wirk.Api;
using Io.Wirk.Api.Wirk.Client;
using Io.Wirk.Api.Wirk.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: Authorization
            Configuration.Default.Username = 'YOUR_USERNAME';
            Configuration.Default.Password = 'YOUR_PASSWORD';

            var apiInstance = new TaskLineApi();
            var id = 1;  // int? | ID

            try
            {
                TaskLineReaderServiceModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLineApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| ID | 

### Return type

[**TaskLineReaderServiceModel**](TaskLineReaderServiceModel.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **Post**
> TaskLineReaderServiceModel Post (TaskLineWriterServiceModel taskLineWriterServiceModel)



Post taskline

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Wirk.Api.Wirk.Api;
using Io.Wirk.Api.Wirk.Client;
using Io.Wirk.Api.Wirk.Model;

namespace Example
{
    public class PostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: Authorization
            Configuration.Default.Username = 'YOUR_USERNAME';
            Configuration.Default.Password = 'YOUR_PASSWORD';

            var apiInstance = new TaskLineApi();
            var taskLineWriterServiceModel = new TaskLineWriterServiceModel(); // TaskLineWriterServiceModel | Taskline description

            try
            {
                TaskLineReaderServiceModel result = apiInstance.Post(taskLineWriterServiceModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskLineApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskLineWriterServiceModel** | [**TaskLineWriterServiceModel**](TaskLineWriterServiceModel.md)| Taskline description | 

### Return type

[**TaskLineReaderServiceModel**](TaskLineReaderServiceModel.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

