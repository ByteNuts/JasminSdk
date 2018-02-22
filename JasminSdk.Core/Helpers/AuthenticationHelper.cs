using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers
{
    public static class AuthenticationHelper
    {
        public static async Task RefreshAccessTokenAsync(ILogger logger)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(Constants.JasminBaseIdentityUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("pt-PT"));

                    var postData = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("grant_type", "client_credentials"),
                        new KeyValuePair<string, string>("scope", "application"),
                        new KeyValuePair<string, string>("client_id", Constants.Config.ClientId),
                        new KeyValuePair<string, string>("client_secret", Constants.Config.ClientSecret)
                    };

                    var content = new FormUrlEncodedContent(postData);

                    var response = await client.PostAsync(Constants.JasminBaseIdentityUrl, content);
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject(jsonString);

                    Constants.AccessToken = ((dynamic) responseData).access_token;
                    Constants.AccessTokenLifetime = DateTime.Now.AddSeconds(Convert.ToInt32(((dynamic) responseData).expires_in));

                    logger.LogInformation("Authentication succeeded!");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Authentication failed!!");
                    throw new Exception($"Error authenticating with Jasmin. ErrorMessage: {ex.Message}");
                }
            }
        }
    }
}
