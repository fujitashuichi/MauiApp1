using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.States.Models
{
    public sealed partial class AppDataContext : ObservableObject, IAppDataContext
    {
        [ObservableProperty]
        public partial int Number { get; private set; }

        public void Increment()
        {
            Number++;
        }
    }
}