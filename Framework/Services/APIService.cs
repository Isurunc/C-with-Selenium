using System.Collections.Generic;
using System.Linq;
using Framework.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Framework.Services {

    public class APIService : IPagesService
    {
            //provide any APIs here
            public const string CARDS_API = "";
            public IList<PageChild> GetAllPages()
        {
            var client = new RestClient(CARDS_API);
            var request = new RestRequest
            {
                Method = Method.GET,
                RequestFormat = DataFormat.Json
            };

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new System.Exception("/Above endpoint failed with " + response.StatusCode);
            }

         return JsonConvert.DeserializeObject<IList<PageChild>>(response.Content);
        
}

        public PageChild GetPageBase(string pageName)
        {
            throw new System.NotImplementedException();
            
        }

    
    }
}




