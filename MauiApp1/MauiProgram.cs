using CommunityToolkit.Maui;
using MauiApp1.Models;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var exception = e.ExceptionObject as Exception;
                if (exception != null)
                {
                    // Log the exception or handle it as needed
                    System.Diagnostics.Debug.WriteLine($"Unhandled exception: {exception.Message}");
                }
            };
            TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                // Log the exception or handle it as needed
                System.Diagnostics.Debug.WriteLine($"Unobserved task exception: {e.Exception.Message}");
                e.SetObserved(); // Prevents the process from terminating
            };

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionToolkit()
                .ConfigureMauiHandlers(handlers =>
                {
#if WINDOWS
    				Microsoft.Maui.Controls.Handlers.Items.CollectionViewHandler.Mapper.AppendToMapping("KeyboardAccessibleCollectionView", (handler, view) =>
    				{
    					handler.PlatformView.SingleSelectionFollowsFocus = false;
    				});
#endif
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("SegoeUI-Semibold.ttf", "SegoeSemibold");
                    fonts.AddFont("FluentSystemIcons-Regular.ttf", FluentUI.FontFamily);
                });

#if DEBUG
    		builder.Logging.AddDebug();
    		builder.Services.AddLogging(configure => configure.AddDebug());
#endif
            builder.Services.AddSingleton<MainPageModel>();
            builder.Services.AddSingleton<AppDataContext>();
            builder.Services.AddSingleton<IAppDataContextManager, AppDataContextManager>();

            return builder.Build();
        }
    }
}
