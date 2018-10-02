/* 
 * Wirk
 *
 * API for api.wirk.io
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Io.Wirk.Api.Wirk.Client;
using Io.Wirk.Api.Wirk.Model;

namespace Io.Wirk.Api.Wirk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskLineApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// ID
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>TaskLineReaderServiceModel</returns>
        TaskLineReaderServiceModel Get (int? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// ID
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of TaskLineReaderServiceModel</returns>
        ApiResponse<TaskLineReaderServiceModel> GetWithHttpInfo (int? id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Post taskline
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>TaskLineReaderServiceModel</returns>
        TaskLineReaderServiceModel Post (TaskLineWriterServiceModel taskLineWriterServiceModel);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Post taskline
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>ApiResponse of TaskLineReaderServiceModel</returns>
        ApiResponse<TaskLineReaderServiceModel> PostWithHttpInfo (TaskLineWriterServiceModel taskLineWriterServiceModel);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// ID
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of TaskLineReaderServiceModel</returns>
        System.Threading.Tasks.Task<TaskLineReaderServiceModel> GetAsync (int? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// ID
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (TaskLineReaderServiceModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskLineReaderServiceModel>> GetAsyncWithHttpInfo (int? id);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Post taskline
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>Task of TaskLineReaderServiceModel</returns>
        System.Threading.Tasks.Task<TaskLineReaderServiceModel> PostAsync (TaskLineWriterServiceModel taskLineWriterServiceModel);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Post taskline
        /// </remarks>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>Task of ApiResponse (TaskLineReaderServiceModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskLineReaderServiceModel>> PostAsyncWithHttpInfo (TaskLineWriterServiceModel taskLineWriterServiceModel);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskLineApi : ITaskLineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskLineApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLineApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaskLineApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  ID
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>TaskLineReaderServiceModel</returns>
        public TaskLineReaderServiceModel Get (int? id)
        {
             ApiResponse<TaskLineReaderServiceModel> localVarResponse = GetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  ID
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>ApiResponse of TaskLineReaderServiceModel</returns>
        public ApiResponse< TaskLineReaderServiceModel > GetWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaskLineApi->Get");

            var localVarPath = "/TaskLine/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (Authorization) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaskLineReaderServiceModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaskLineReaderServiceModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaskLineReaderServiceModel)));
            
        }

        /// <summary>
        ///  ID
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of TaskLineReaderServiceModel</returns>
        public async System.Threading.Tasks.Task<TaskLineReaderServiceModel> GetAsync (int? id)
        {
             ApiResponse<TaskLineReaderServiceModel> localVarResponse = await GetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  ID
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID</param>
        /// <returns>Task of ApiResponse (TaskLineReaderServiceModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaskLineReaderServiceModel>> GetAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling TaskLineApi->Get");

            var localVarPath = "/TaskLine/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (Authorization) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaskLineReaderServiceModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaskLineReaderServiceModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaskLineReaderServiceModel)));
            
        }

        /// <summary>
        ///  Post taskline
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>TaskLineReaderServiceModel</returns>
        public TaskLineReaderServiceModel Post (TaskLineWriterServiceModel taskLineWriterServiceModel)
        {
             ApiResponse<TaskLineReaderServiceModel> localVarResponse = PostWithHttpInfo(taskLineWriterServiceModel);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Post taskline
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>ApiResponse of TaskLineReaderServiceModel</returns>
        public ApiResponse< TaskLineReaderServiceModel > PostWithHttpInfo (TaskLineWriterServiceModel taskLineWriterServiceModel)
        {
            // verify the required parameter 'taskLineWriterServiceModel' is set
            if (taskLineWriterServiceModel == null)
                throw new ApiException(400, "Missing required parameter 'taskLineWriterServiceModel' when calling TaskLineApi->Post");

            var localVarPath = "/TaskLine";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskLineWriterServiceModel != null && taskLineWriterServiceModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taskLineWriterServiceModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taskLineWriterServiceModel; // byte array
            }

            // authentication (Authorization) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaskLineReaderServiceModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaskLineReaderServiceModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaskLineReaderServiceModel)));
            
        }

        /// <summary>
        ///  Post taskline
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>Task of TaskLineReaderServiceModel</returns>
        public async System.Threading.Tasks.Task<TaskLineReaderServiceModel> PostAsync (TaskLineWriterServiceModel taskLineWriterServiceModel)
        {
             ApiResponse<TaskLineReaderServiceModel> localVarResponse = await PostAsyncWithHttpInfo(taskLineWriterServiceModel);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Post taskline
        /// </summary>
        /// <exception cref="Io.Wirk.Api.Wirk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskLineWriterServiceModel">Taskline description</param>
        /// <returns>Task of ApiResponse (TaskLineReaderServiceModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaskLineReaderServiceModel>> PostAsyncWithHttpInfo (TaskLineWriterServiceModel taskLineWriterServiceModel)
        {
            // verify the required parameter 'taskLineWriterServiceModel' is set
            if (taskLineWriterServiceModel == null)
                throw new ApiException(400, "Missing required parameter 'taskLineWriterServiceModel' when calling TaskLineApi->Post");

            var localVarPath = "/TaskLine";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (taskLineWriterServiceModel != null && taskLineWriterServiceModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taskLineWriterServiceModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taskLineWriterServiceModel; // byte array
            }

            // authentication (Authorization) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Post: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TaskLineReaderServiceModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TaskLineReaderServiceModel) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TaskLineReaderServiceModel)));
            
        }

    }
}
