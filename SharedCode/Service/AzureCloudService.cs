using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace SharedCode.Service
{
    public class AzureCloudService : ICloudService
    {
        const string applicationURL = @"https://your-service.azurewebsites.fail";

        MobileServiceClient client;

        public AzureCloudService()
        {
            client = new MobileServiceClient(applicationURL);
        }

        public Task<ICloudTable<T>> GetTableAsync<T>() where T : TableData
        {
            throw new NotImplementedException();
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task SyncOfflineCacheAsync()
        {
            throw new NotImplementedException();
        }
    }
}
