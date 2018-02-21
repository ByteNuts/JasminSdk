using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers
{
    public class ApiCall<T>
    {
        protected readonly ILogger Logger;
        public ApiCall(ILogger logger)
        {
            Logger = logger;
        }

        public async Task<ApiResponse<T>> Get(string endpoint, bool expect404 = false, bool useBearerAuth = true)
        {
            if (useBearerAuth && (string.IsNullOrEmpty(Constants.AccessToken) || Constants.AccessTokenLifetime <= DateTime.Now))
                await AuthenticationHelper.RefreshAccessTokenAsync();

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    if (useBearerAuth) client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.AccessToken);

                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pt-PT"));

                    using (var response = await client.GetAsync(endpoint))
                    {
                        if (!response.IsSuccessStatusCode && !expect404 && response.StatusCode != HttpStatusCode.NotFound)
                        {
                            return new ApiResponse<T>
                            {
                                Success = false,
                                Error = await response.Content.ReadAsStringAsync(),
                                HttpStatusCode = (int)response.StatusCode,
                                HttpStatusCodeDesc = response.StatusCode.ToString()
                            };
                        }
                        
                        if (!response.IsSuccessStatusCode && !expect404 &&
                                 response.StatusCode == HttpStatusCode.NotFound)
                        {
                            return new ApiResponse<T>
                            {
                                Success = true,
                                Error = await response.Content.ReadAsStringAsync(),
                                HttpStatusCode = (int)response.StatusCode,
                                HttpStatusCodeDesc = response.StatusCode.ToString()
                            };
                        }

                        if (response.Content.Headers.ContentType.MediaType == "application/json")
                        {
                            var jsonString = await response.Content.ReadAsStringAsync();

                            return new ApiResponse<T>
                            {
                                Success = true,
                                HttpStatusCode = (int)response.StatusCode,
                                HttpStatusCodeDesc = response.StatusCode.ToString(),
                                Response = !string.IsNullOrEmpty(jsonString) ? (IsSimple(typeof(T).GetTypeInfo()) ? (T)(object)jsonString : JsonConvert.DeserializeObject<T>(jsonString)) : default(T)
                            };
                        }

                        return new ApiResponse<T>
                        {
                            Success = true,
                            HttpStatusCode = (int)response.StatusCode,
                            HttpStatusCodeDesc = response.StatusCode.ToString(),
                            Response = (T)(object)await response.Content.ReadAsByteArrayAsync()
                        };
                    }
                }
            }
            catch (Exception e)
            {
                return new ApiResponse<T>
                {
                    Success = false,
                    Error = e.Message,
                    HttpStatusCode = (int)HttpStatusCode.InternalServerError,
                    HttpStatusCodeDesc = HttpStatusCode.InternalServerError.ToString()
                };
            }
        }

        public async Task<ApiResponse<T>> Post(string endpoint, HttpContent content, bool useBearerAuth = true)
        {
            if (useBearerAuth && (string.IsNullOrEmpty(Constants.AccessToken) || Constants.AccessTokenLifetime <= DateTime.Now))
                await AuthenticationHelper.RefreshAccessTokenAsync();

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    if (useBearerAuth) client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.AccessToken);

                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pt-PT"));

                    using (var response = await client.PostAsync(endpoint, content))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            var errorContent = await response.Content.ReadAsStringAsync();

                            return new ApiResponse<T>
                            {
                                Success = false,
                                Error = errorContent,
                                HttpStatusCode = (int)response.StatusCode,
                                HttpStatusCodeDesc = response.StatusCode.ToString()
                            };
                        }

                        var jsonString = await response.Content.ReadAsStringAsync();

                        return new ApiResponse<T>
                        {
                            Success = true,
                            HttpStatusCode = (int)response.StatusCode,
                            HttpStatusCodeDesc = response.StatusCode.ToString(),
                            Response = !string.IsNullOrEmpty(jsonString) ? (IsSimple(typeof(T).GetTypeInfo()) ? (T)(object)jsonString : JsonConvert.DeserializeObject<T>(jsonString)) : default(T)
                        };
                    }
                }

            }
            catch (Exception e)
            {
                return new ApiResponse<T>
                {
                    Success = false,
                    Error = e.Message,
                    HttpStatusCode = (int)HttpStatusCode.InternalServerError,
                    HttpStatusCodeDesc = HttpStatusCode.InternalServerError.ToString()
                };
            }
        }

        public async Task<ApiResponse<T>> Put(string endpoint, HttpContent content, bool expect404 = false, bool useBearerAuth = true)
        {
            if (useBearerAuth && (string.IsNullOrEmpty(Constants.AccessToken) || Constants.AccessTokenLifetime <= DateTime.Now))
                await AuthenticationHelper.RefreshAccessTokenAsync();

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    if (useBearerAuth) client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.AccessToken);

                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pt-PT"));

                    using (var response = await client.PutAsync(endpoint, content))
                    {
                        if (!response.IsSuccessStatusCode && !expect404 && response.StatusCode != HttpStatusCode.NotFound)
                        {
                            return new ApiResponse<T>
                            {
                                Success = false,
                                Error = await response.Content.ReadAsStringAsync(),
                                HttpStatusCode = (int)response.StatusCode,
                                HttpStatusCodeDesc = response.StatusCode.ToString()
                            };
                        }

                        var jsonString = await response.Content.ReadAsStringAsync();

                        return new ApiResponse<T>
                        {
                            Success = true,
                            HttpStatusCode = (int)response.StatusCode,
                            HttpStatusCodeDesc = response.StatusCode.ToString(),
                            Response = !string.IsNullOrEmpty(jsonString) ? (IsSimple(typeof(T).GetTypeInfo()) ? (T)(object)jsonString : JsonConvert.DeserializeObject<T>(jsonString)) : default(T)
                        };
                    }
                }

            }
            catch (Exception e)
            {
                return new ApiResponse<T>
                {
                    Success = false,
                    Error = e.Message,
                    HttpStatusCode = (int)HttpStatusCode.InternalServerError,
                    HttpStatusCodeDesc = HttpStatusCode.InternalServerError.ToString()
                };
            }
        }

        public async Task<ApiResponse<T>> Delete(string endpoint, bool expect404 = false, bool useBearerAuth = true)
        {
            if (useBearerAuth && (string.IsNullOrEmpty(Constants.AccessToken) || Constants.AccessTokenLifetime <= DateTime.Now))
                await AuthenticationHelper.RefreshAccessTokenAsync();

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    if (useBearerAuth) client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.AccessToken);

                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pt-PT"));

                    using (var response = await client.DeleteAsync(endpoint))
                    {
                        if (!response.IsSuccessStatusCode && !expect404 && response.StatusCode != HttpStatusCode.NotFound)
                        {
                            return new ApiResponse<T>
                            {
                                Success = false,
                                Error = await response.Content.ReadAsStringAsync(),
                                HttpStatusCode = (int)response.StatusCode,
                                HttpStatusCodeDesc = response.StatusCode.ToString()
                            };
                        }

                        var jsonString = await response.Content.ReadAsStringAsync();

                        return new ApiResponse<T>
                        {
                            Success = true,
                            HttpStatusCode = (int)response.StatusCode,
                            HttpStatusCodeDesc = response.StatusCode.ToString(),
                            Response = !string.IsNullOrEmpty(jsonString) ? (IsSimple(typeof(T).GetTypeInfo()) ? (T)(object)jsonString : JsonConvert.DeserializeObject<T>(jsonString)) : default(T)
                        };
                    }
                }

            }
            catch (Exception e)
            {
                return new ApiResponse<T>
                {
                    Success = false,
                    Error = e.Message,
                    HttpStatusCode = (int)HttpStatusCode.InternalServerError,
                    HttpStatusCodeDesc = HttpStatusCode.InternalServerError.ToString()
                };
            }
        }



        private static bool IsSimple(TypeInfo type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                // nullable type, check if the nested type is simple.
                return IsSimple((type.GenericTypeArguments[0]).GetTypeInfo());
            }
            return type.IsPrimitive
                   || type.IsEnum
                   || type.Equals(typeof(decimal));
        }
    }
}
