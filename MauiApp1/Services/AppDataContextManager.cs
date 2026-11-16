using MauiApp1.Models;
using System.Diagnostics;

namespace MauiApp1.Services
{
    public class AppDataContextManager : IAppDataContextManager
    {
        public void CountUpNumber(AppDataContext context)
        {
            var oldValue = context.Number;
            context.Number++;
            LogChange(context, nameof(AppDataContext.Number), oldValue, context.Number);
        }

        public void LogChange(AppDataContext context, string propertyName, object oldValue, object newValue)
        {
            Debug.WriteLine($"Property '{propertyName}' changed from '{oldValue}' to '{newValue}' in context.");
        }
    }
}