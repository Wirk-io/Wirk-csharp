# Io.Wirk.Api.Wirk.Api.AppApi

All URIs are relative to *https://api.wirk.io/v1_0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](AppApi.md#get) | **GET** /App/{id} | 
[**GetAll**](AppApi.md#getall) | **GET** /App | 


# **Get**
> AppReaderServiceModel Get (int? id)



Get App Id

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
            
            var apiInstance = new AppApi();
            var id = 1;  // int? | id

            try
            {
                AppReaderServiceModel result = apiInstance.Get(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| id | 

### Return type

[**AppReaderServiceModel**](AppReaderServiceModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **GetAll**
> List<AppReaderServiceModel> GetAll ()



Get all apps

### Example
```csharp
using System;
using System.Diagnostics;
using Io.Wirk.Api.Wirk.Api;
using Io.Wirk.Api.Wirk.Client;
using Io.Wirk.Api.Wirk.Model;

namespace Example
{
    public class GetAllExample
    {
        public void main()
        {
            
            var apiInstance = new AppApi();

            try
            {
                List&lt;AppReaderServiceModel&gt; result = apiInstance.GetAll();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppApi.GetAll: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AppReaderServiceModel>**](AppReaderServiceModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

