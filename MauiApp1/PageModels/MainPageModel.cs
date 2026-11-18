using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.States.Services;
using MauiApp1.States.Models;

namespace MauiApp1.PageModels
{
    public partial class MainPageModel : ObservableObject
    {
        private readonly IAppDataContextManager _contextManager;
        
        [ObservableProperty]
        public partial AppDataContext Context { get; set; }
        
        public MainPageModel(AppDataContext context, IAppDataContextManager contextManager)
        {
            Context = context;
            _contextManager = contextManager;
        }
        

        [RelayCommand]
        private void CountUp()
        {
            _contextManager.CountUpNumber(Context);
        }
    }
}