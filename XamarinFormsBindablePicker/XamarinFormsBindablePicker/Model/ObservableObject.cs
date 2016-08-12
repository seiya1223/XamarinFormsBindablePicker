namespace XamarinFormsBindablePicker.Model {
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class ObservableObject : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] String propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}