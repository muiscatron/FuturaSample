using Caliburn.Micro;

namespace WPF1
{
    class MyDemoAppViewModel : PropertyChangedBase
    {

        private int _externalData;

        private int _userInput;
        private bool _isUpdatePending;

        public int ExternalData {
            get { return _externalData; }

            set
            {
                _externalData = value;
                _userInput = value;
                NotifyOfPropertyChange(() => ExternalData);
                NotifyOfPropertyChange(() => UserInput);
            }
        }


        public int UserInput
        {
            get { return _userInput; }

            set
            {
                _isUpdatePending = true;
                _userInput = value;
                NotifyOfPropertyChange(() => ExternalData);
                NotifyOfPropertyChange(() => CanUpdate);
            }
        }


        public bool CanUpdate
        {
            get { return _isUpdatePending; }
        }


        public void Update()
        {
            ExternalData = UserInput;
            _isUpdatePending = false;
            NotifyOfPropertyChange(() => CanUpdate);
        }


    }
}
