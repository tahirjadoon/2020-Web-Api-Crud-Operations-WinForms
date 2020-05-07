using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test.Helpers
{
    public static class ApiCrudCallHelper
    {
        /// <summary>
        /// Performs Post and returns ApiCallResult
        /// </summary>
        /// <typeparam name="T">model to Post, could be null, T, List T</typeparam>
        /// <typeparam name="X">return model by API, could be X, List X, string </typeparam>
        /// <param name="data">data to post of type T, List T</param>
        /// <param name="apiUrl">api full URL like http://localhost:65152/API/Test if executing custom action, provide that as well at the end </param>
        /// <returns>
        /// ApiCallResult
        ///     StatusCode: status code returned by the API
        ///     ReasonPhrase: reason phrase returned by the API
        ///     IsError: true/false
        ///     IsException: true/false
        ///     Message: error message, exception message, or result of OK etc results by API
        ///     X ResponseObject: model returned by the API, it might not be available in all cases. Could be X, List X or string as provided by X above
        /// </returns>
        public static async Task<ApiCallResult<X>> Post<T, X>(T data, string apiUrl) where X : class
        {
            var apiCallResult = new ApiCallResult<X> { IsError = true, Message = "No run" };
            try
            {
                //json string 
                var jsonString = JsonConvert.SerializeObject(data);
                using (var client = new HttpClient())
                {
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, httpContent);
                    var jsonResponseString = await response.Content.ReadAsStringAsync();

                    //fill
                    if (response.IsSuccessStatusCode)
                    {
                        //deserialize
                        if (!typeof(X).Equals(typeof(string)))
                        {
                            apiCallResult.ResponseObject = JsonConvert.DeserializeObject<X>(jsonResponseString);
                        }
                        apiCallResult.IsError = false;
                    }
                    apiCallResult.StatusCode = response.StatusCode;
                    apiCallResult.ReasonPhrase = response.ReasonPhrase;
                    apiCallResult.Message = jsonResponseString;
                }
            }
            catch (Exception ex)
            {
                apiCallResult.IsException = true;
                apiCallResult.Message = ex.Message;
            }

            return apiCallResult;
        }

        /// <summary>
        /// Performs Put and returns ApiCallResult
        /// </summary>
        /// <typeparam name="T">model to Post, could be null, T, List T</typeparam>
        /// <typeparam name="X">return model by API, could be X, List X, string </typeparam>
        /// <param name="data">data to post of type T, List T</param>
        /// <param name="apiUrl">api full URL including the Id like http://localhost:65152/API/Test/12345 if executing custom action, provide that as well </param>
        /// <returns>
        /// ApiCallResult
        ///     HttpStatusCode StatusCode: status code returned by the API
        ///     string ReasonPhrase: reason phrase returned by the API
        ///     bool IsError: true/false
        ///     bool IsException: true/false
        ///     string Message: error message, exception message, or result of OK etc results by API
        ///     X ResponseObject: model returned by the API, it might not be available in all cases. Could be X, List X or string as provided by X above
        /// </returns>
        public static async Task<ApiCallResult<X>> Put<T, X>(T data, string apiUrl) where X : class
        {
            var apiCallResult = new ApiCallResult<X> { IsError = true, Message = "No run" };
            try
            {
                //json string 
                var jsonString = JsonConvert.SerializeObject(data);
                using (var client = new HttpClient())
                {
                    var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    var response = await client.PutAsync(apiUrl, httpContent);
                    var jsonResponseString = await response.Content.ReadAsStringAsync();

                    //fill
                    if (response.IsSuccessStatusCode)
                    {
                        //deserialize
                        if (!typeof(X).Equals(typeof(string)))
                        {
                            apiCallResult.ResponseObject = JsonConvert.DeserializeObject<X>(jsonResponseString);
                        }
                        apiCallResult.IsError = false;
                    }
                    apiCallResult.StatusCode = response.StatusCode;
                    apiCallResult.ReasonPhrase = response.ReasonPhrase;
                    apiCallResult.Message = jsonResponseString;
                }
            }
            catch (Exception ex)
            {
                apiCallResult.IsException = true;
                apiCallResult.Message = ex.Message;
            }

            return apiCallResult;
        }

        /// <summary>
        /// Performs Delete and returns ApiCallResult
        /// </summary>
        /// <typeparam name="X">return model by API, could be X, List X, string. Usually you'll only get Ok result etc for delete, so specify string  </typeparam>
        /// <param name="apiUrl">api full URL including the Id like http://localhost:65152/API/Test/12345 if executing custom action, provide that as well </param>
        /// <returns>
        /// ApiCallResult
        ///     HttpStatusCode StatusCode: status code returned by the API
        ///     string ReasonPhrase: reason phrase returned by the API
        ///     bool IsError: true/false
        ///     bool IsException: true/false
        ///     string Message: error message, exception message, or result of OK etc results by API
        ///     X ResponseObject: will only be available if api is returning a model (should not), in most cases it will not be available. Could be X, List X or string as provided by X above
        /// </returns>
        public static async Task<ApiCallResult<X>> Delete<X>(string apiUrl) where X : class
        {
            var apiCallResult = new ApiCallResult<X> { IsError = true, Message = "No run" };
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.DeleteAsync(apiUrl);
                    var jsonResponseString = await response.Content.ReadAsStringAsync();

                    //fill
                    if (response.IsSuccessStatusCode)
                    {
                        //deserialize
                        if (!typeof(X).Equals(typeof(string)))
                        {
                            apiCallResult.ResponseObject = JsonConvert.DeserializeObject<X>(jsonResponseString);
                        }
                        apiCallResult.IsError = false;
                    }
                    apiCallResult.StatusCode = response.StatusCode;
                    apiCallResult.ReasonPhrase = response.ReasonPhrase;
                    apiCallResult.Message = jsonResponseString;
                }
            }
            catch (Exception ex)
            {
                apiCallResult.IsException = true;
                apiCallResult.Message = ex.Message;
            }

            return apiCallResult;
        }

        /// <summary>
        /// Performs Get and returns ApiCallResult
        /// </summary>
        /// <typeparam name="X">return model by API, could be X, List X, string. </typeparam>
        /// <param name="apiUrl">api full URL </param>
        /// <returns>
        /// ApiCallResult
        ///     HttpStatusCode StatusCode: status code returned by the API
        ///     string ReasonPhrase: reason phrase returned by the API
        ///     bool IsError: true/false
        ///     bool IsException: true/false
        ///     string Message: error message, exception message, or result of OK etc results by API
        ///     X ResponseObject: Could be X, List X or string as provided by X above
        /// </returns>
        public static async Task<ApiCallResult<X>> Get<X>(string apiUrl) where X : class
        {
            var apiCallResult = new ApiCallResult<X> { IsError = true, Message = "No run" };
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    var jsonResponseString = await response.Content.ReadAsStringAsync();

                    //fill
                    if (response.IsSuccessStatusCode)
                    {
                        //deserialize
                        if (!typeof(X).Equals(typeof(string)))
                        {
                            apiCallResult.ResponseObject = JsonConvert.DeserializeObject<X>(jsonResponseString);
                        }
                        apiCallResult.IsError = false;
                    }
                    apiCallResult.StatusCode = response.StatusCode;
                    apiCallResult.ReasonPhrase = response.ReasonPhrase;
                    apiCallResult.Message = jsonResponseString;
                }
            }
            catch (Exception ex)
            {
                apiCallResult.IsException = true;
                apiCallResult.Message = ex.Message;
            }

            return apiCallResult;
        }
    }
}
