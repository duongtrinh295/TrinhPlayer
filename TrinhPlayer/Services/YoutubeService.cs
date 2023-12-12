
namespace TrinhPlayer.Services
{
    public class YoutubeService : RestServiceBase , IApiService
    {
        public YoutubeService(IConnectivity connectivity, IBarrel cacheBarrel) : base(connectivity, cacheBarrel)
        {
           SetBaseURL(Constants.ApiServiceURL);
        }

        public async Task<ChannelSearchResult> GetChannels(string channelIDs)
        {
            throw new NotImplementedException();
        }

        public async Task<CommentsSearchResult> GetComments(string videoID)
        {
            throw new NotImplementedException();
        }

        public async Task<YoutubeVideoDetail> GetVideoDetails(string videoID)
        {
            throw new NotImplementedException();
        }

        public async Task<VideoSearchResult> SearchVideos(string searchQuery, string nextPageToken = "")
        {
             //'https://youtube.googleapis.com/youtube/v3/search?part=snippet&q=iphone%2014&key=[YOUR_API_KEY]' \
            var resourceUri = $"search?part=snippet&maxResults=10&type=video&key={Constants.ApiKey}&q={WebUtility.UrlEncode(searchQuery)}"
             +
             (!string.IsNullOrEmpty(nextPageToken) ? $"&pageToken={nextPageToken}" : "");

            var result = await GetAsync<VideoSearchResult>(resourceUri, 4);

            return result;
        }
    }
}
