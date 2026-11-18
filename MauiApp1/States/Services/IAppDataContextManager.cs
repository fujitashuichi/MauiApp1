using MauiApp1.States.Models;

namespace MauiApp1.States.Services
{
    public interface IAppDataContextManager
    {
        void CountUpNumber(AppDataContext context);

        void LogChanged(AppDataContext context, string propertyName, object oldValue, object newValue);
    }
}