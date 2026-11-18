using System.ComponentModel;

namespace MauiApp1.Models
{
    public interface IAppDataContext : INotifyPropertyChanged
    {
        public abstract int Number { get; }
        public abstract void Increment();
    }
}