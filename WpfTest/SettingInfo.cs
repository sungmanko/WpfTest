using System.ComponentModel;

namespace WpfApplication1
{
    public class SettingInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string test = string.Empty;
        public string Test
        {
            get { return test; }
            set
            {
                this.test = value;
                RaisePropertyChanged("Test");
            }
        }
    }
}
