using MauiApp1.Models;

namespace MauiApp1.Services
{
    public interface IAppDataContextManager
    {
        void CountUpNumber(AppDataContext context);

        void LogChange(AppDataContext context, string propertyName, object oldValue, object newValue);
    }
}