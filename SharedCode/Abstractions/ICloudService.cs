using System;
using System.Threading.Tasks;

namespace SharedCode
{
	public interface ICloudService
	{
		Task<ICloudTable<T>> GetTableAsync<T>() where T : TableData;

		//Task<StorageTokenViewModel> GetSasTokenAsync(string directory, string fileName);

		Task SyncOfflineCacheAsync();
		Task InitializeAsync();

		//MobileServiceClient GetMobileClient();
		//Task<MobileServiceUser> LoginAsync();

		//Task<MobileServiceUser> LoginAsync(DeviceParing deviceParing);
        //string GetIdentityAsync();
		//Task CheckForAward(string awardCategory);

	}
}
