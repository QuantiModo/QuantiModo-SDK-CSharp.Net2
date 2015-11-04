using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IVariableCategoryApi
    {
        
        /// <summary>
        /// Get all VariableCategories Get all VariableCategories
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="fillingValue">filling_value</param>
        /// <param name="maximumAllowedValue">maximum_allowed_value</param>
        /// <param name="minimumAllowedValue">minimum_allowed_value</param>
        /// <param name="durationOfAction">duration_of_action</param>
        /// <param name="onsetDelay">onset_delay</param>
        /// <param name="combinationOperation">combination_operation</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">cause_only</param>
        /// <param name="_public">public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">created_at</param>
        /// <param name="updatedAt">updated_at</param>
        /// <param name="imageUrl">image_url</param>
        /// <param name="defaultUnitId">default_unit_id</param>
        /// <param name="limit">limit</param>
        /// <param name="offset">offset</param>
        /// <param name="sort">sort</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 VariableCategoriesGet (string name, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? durationOfAction, int? onsetDelay, string combinationOperation, int? updated, bool? causeOnly, int? _public, bool? outcome, string createdAt, string updatedAt, string imageUrl, int? defaultUnitId, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 VariableCategoriesPost (VariableCategory body);
        
        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 VariableCategoriesIdGet (int? id);
        
        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableCategoriesIdPut (int? id, VariableCategory body);
        
        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableCategoriesIdDelete (int? id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableCategoryApi : IVariableCategoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariableCategoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableCategoryApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get all VariableCategories Get all VariableCategories
        /// </summary>
        /// <param name="name">name</param> 
        /// <param name="fillingValue">filling_value</param> 
        /// <param name="maximumAllowedValue">maximum_allowed_value</param> 
        /// <param name="minimumAllowedValue">minimum_allowed_value</param> 
        /// <param name="durationOfAction">duration_of_action</param> 
        /// <param name="onsetDelay">onset_delay</param> 
        /// <param name="combinationOperation">combination_operation</param> 
        /// <param name="updated">updated</param> 
        /// <param name="causeOnly">cause_only</param> 
        /// <param name="_public">public</param> 
        /// <param name="outcome">outcome</param> 
        /// <param name="createdAt">created_at</param> 
        /// <param name="updatedAt">updated_at</param> 
        /// <param name="imageUrl">image_url</param> 
        /// <param name="defaultUnitId">default_unit_id</param> 
        /// <param name="limit">limit</param> 
        /// <param name="offset">offset</param> 
        /// <param name="sort">sort</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 VariableCategoriesGet (string name, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? durationOfAction, int? onsetDelay, string combinationOperation, int? updated, bool? causeOnly, int? _public, bool? outcome, string createdAt, string updatedAt, string imageUrl, int? defaultUnitId, int? limit, int? offset, string sort)
        {
            
    
            var path = "/variableCategories";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
             if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
             if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
             if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
             if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
             if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
             if (combinationOperation != null) queryParams.Add("combination_operation", ApiClient.ParameterToString(combinationOperation)); // query parameter
             if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
             if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
             if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
             if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (imageUrl != null) queryParams.Add("image_url", ApiClient.ParameterToString(imageUrl)); // query parameter
             if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        
        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="body">VariableCategory that should be stored</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 VariableCategoriesPost (VariableCategory body)
        {
            
    
            var path = "/variableCategories";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        
        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <returns>InlineResponse20024</returns>            
        public InlineResponse20024 VariableCategoriesIdGet (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdGet");
            
    
            var path = "/variableCategories/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20024) ApiClient.Deserialize(response.Content, typeof(InlineResponse20024), response.Headers);
        }
    
        
        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="body">VariableCategory that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariableCategoriesIdPut (int? id, VariableCategory body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdPut");
            
    
            var path = "/variableCategories/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariableCategoriesIdDelete (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdDelete");
            
    
            var path = "/variableCategories/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
