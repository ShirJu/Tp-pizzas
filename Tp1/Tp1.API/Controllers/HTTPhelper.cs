using Microsoft.AspNetCore.Mvc;

namespace OMDB.API.Controllers;
public static class HTTPhelper {
    public static async Task<string> GetTaskAsync(string targetURL, string defaultValueOnError){
        string returnValue;
        HttpClient httpClient;

        returnValue = defaultValueOnError;
        httpClient = new HttpClient();

        try
        {
            using (HttpResponseMessage response = await httpClient.GetAsync(targetURL))
            {
                returnValue=await response.Content.ReadAsStringAsync();  
            } 
        
        } catch (Exception ex) {

            returnValue=defaultValueOnError;
        
        }
            
        return returnValue;
    }

    internal static Task<string> GetContentAsync(string v, object value)
    {
        throw new NotImplementedException();
    }
}


    