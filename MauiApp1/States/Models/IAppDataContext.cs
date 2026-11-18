using System.ComponentModel;

namespace MauiApp1.States.Models
{
    public interface IAppDataContext : INotifyPropertyChanged
    {
        public abstract int Number { get; }
        public abstract void Increment();
    }
}