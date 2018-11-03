namespace ComboBoxSample
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModel : INotifyPropertyChanged
    {
        private string selectedCurrency;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedCurrency
        {
            get => this.selectedCurrency;
            set
            {
                if (value == this.selectedCurrency)
                {
                    return;
                }

                this.selectedCurrency = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<string> Currencies { get; } = new ObservableCollection<string> { "USD", "SEK" };

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
