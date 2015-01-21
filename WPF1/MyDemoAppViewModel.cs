﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WPF1
{
    class MyDemoAppViewModel : PropertyChangedBase
    {

        private string _externalData;

        private string _userInput;
        private bool _isUpdatePending = true;

        public String ExternalData {
            get { return _externalData; }

            set
            {
                _externalData = value;
                _userInput = value;
                NotifyOfPropertyChange(() => ExternalData);
                NotifyOfPropertyChange(() => UserInput);
            }
        }


        public String UserInput
        {
            get { return _userInput; }

            set
            {
                _isUpdatePending = true;
                _userInput = value;
                NotifyOfPropertyChange(() => ExternalData);
            }
        }


        public bool CanUpdate
        {
            get { return _isUpdatePending; }
        }

        public void Update()
        {
            ExternalData = UserInput;
        }


    }
}