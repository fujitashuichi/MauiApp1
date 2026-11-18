using System.ComponentModel;

public interface IAppDataContext : INotifyPropertyChanged
{
    public abstract int Number { get; }
	public abstract void Increment();
}
