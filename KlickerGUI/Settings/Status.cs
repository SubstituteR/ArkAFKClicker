using System.ComponentModel;

namespace KlickerGUI
{
    public sealed class Settings
    {
        private static readonly StatusClass status = new StatusClass();
        private Settings() { }

        public static StatusClass Status
        {
            get
            {
                return status;
            }
        }

        public sealed class StatusClass : INotifyPropertyChanged
        {

            private bool clicking;
            private bool gamefound;
            private bool hotkeyenabled;
            private bool gameforeground;
            public bool Clicking
            {
                get
                {
                    return clicking;
                }

                set
                {
                    if (gamefound && hotkeyenabled)
                    {
                        clicking = value;
                        OnPropertyChanged("Clicking");
                    }
                    else
                    {
                        clicking = false;
                        OnPropertyChanged("Clicking");
                    }
                }
            }

            public bool GameFound
            {
                get
                {
                    return gamefound;
                }
                set
                {
                    gamefound = value;
                    OnPropertyChanged("GameFound");
                    UpdateClicking(value);
                }
            }

            public bool HotkeyEnabled
            {
                get
                {
                    return hotkeyenabled;
                }
                set
                {
                    hotkeyenabled = value;
                    OnPropertyChanged("HotkeyEnabled");
                    UpdateClicking(value);
                }
            }

            public bool GameForeground
            {
                get
                {
                    return gameforeground;
                }
                set
                {
                    gameforeground = value;
                    OnPropertyChanged("GameForeground");
                }
            }

            public void UpdateClicking(bool value)
            {
                if (value == false)
                {
                    Clicking = false;
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public void OnPropertyChanged(string name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    
}
