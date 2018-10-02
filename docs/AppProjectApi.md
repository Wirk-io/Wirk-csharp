# Io.Wirk.Api.Wirk.Api.AppProjectApi

All URIs are relative to *https://api.wirk.io/v1_0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](AppProjectApi.md#get) | **GET** /AppProject/{id} | 
[**Post**](AppProjectApi.md#post) | **POST** /AppProject | 


# **Get**
> AppProjectReaderServiceModel Get (int? id)



Get

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

            var apiInstance = new AppProjectApi();
            var id = 1;  // int? | ID

            try
            {
                AppProjectReaderServiceModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppProjectApi.Get: " + e.Message );
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

[**AppProjectReaderServiceModel**](AppProjectReaderServiceModel.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **Post**
> AppProjectReaderServiceModel Post (AppProjectWriterServiceModel appProjectWriterServiceModel)



Post app project

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

            var apiInstance = new AppProjectApi();
            var appProjectWriterServiceModel = new AppProjectWriterServiceModel(); // AppProjectWriterServiceModel | Definition of the appProject

            try
            {
                AppProjectReaderServiceModel result = apiInstance.Post(appProjectWriterServiceModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppProjectApi.Post: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appProjectWriterServiceModel** | [**AppProjectWriterServiceModel**](AppProjectWriterServiceModel.md)| Definition of the appProject | 

### Return type

[**AppProjectReaderServiceModel**](AppProjectReaderServiceModel.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

