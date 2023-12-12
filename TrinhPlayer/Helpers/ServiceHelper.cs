
namespace TrinhPlayer.Helpers
{
    public static class ServiceHelpers
    {

         // kiểm tra xem chạy hệ điểu hành nào và sử dụng dịch vụ phiên bản đó
        public static TService GetService<TService>() => //test
            Current.GetService<TService>();

        public static IServiceProvider Current =>
#if WINDOWS10_0_17763_0_OR_GREATER
			MauiWinUIApplication.Current.Services;
#elif ANDROID
    MauiApplication.Current.Services;
#elif IOS || MACCATALYST
                MauiUIApplicationDelegate.Current.Services;
#else
			null;
#endif
    }
}
