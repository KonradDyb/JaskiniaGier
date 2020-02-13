using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaskiniaGier.Services
{
    public class StripeApiFactory
    {
        private readonly string _apiKey;
        private readonly string _publishableKey;

        public StripeApiFactory(string apiKey, string publishableKey)
        {
            _apiKey = apiKey;
            _publishableKey = publishableKey;
        }

        public string GetApiKey()
        {
            return _apiKey;
        }

        public string GetPublishableKey()
        {
            return _publishableKey;
        }
    }
}
