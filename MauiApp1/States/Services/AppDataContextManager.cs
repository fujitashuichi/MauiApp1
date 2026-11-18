using System.Diagnostics;
using MauiApp1.States.Models;

namespace MauiApp1.States.Services
{
    public class AppDataContextManager : IAppDataContextManager
    {
        public void CountUpNumber(AppDataContext context)
        {
            var oldValue = context.Number;
            context.Increment();
            LogChanged(context, nameof(AppDataContext.Number), oldValue, context.Number);
        }

        public void LogChanged(AppDataContext context, string propertyName, object oldValue, object newValue)
        {
            Debug.WriteLine($"Property '{propertyName}' changed from '{oldValue}' to '{newValue}' in context.");
        }
    }
}