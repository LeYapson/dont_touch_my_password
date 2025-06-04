using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using ReactiveUI;

namespace dont_touch_my_password.ViewModels;

public class ViewModelBase : ReactiveObject
{
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        this.RaisePropertyChanged(propertyName);
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}
