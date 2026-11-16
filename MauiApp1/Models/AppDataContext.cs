
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.Models
{
    public partial class AppDataContext : ObservableObject
    {
        [ObservableProperty]
        public partial int Number { get; set; }
    }
}