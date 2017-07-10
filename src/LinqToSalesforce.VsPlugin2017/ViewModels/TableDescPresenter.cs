using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using LinqToSalesforce.VsPlugin2017.Annotations;

namespace LinqToSalesforce.VsPlugin2017.ViewModels
{
    public class TableDescPresenter : INotifyPropertyChanged
    {
        private bool _selected;

        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                OnPropertyChanged();
            }
        }

        public Rest.TableDesc Table { get; set; }

        public ICommand SelectTable => new RelayCommand(() =>
        {
            
        });

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}