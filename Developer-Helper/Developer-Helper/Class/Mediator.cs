using Developer_Helper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Helper.Class
{
    class Mediator
    {
        #region Instance        
        private static Mediator _instance;
        public static Mediator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Mediator();
                }
                return _instance;
            }
        }

        private ConnectionInformationModel _sharedModel;
        public ConnectionInformationModel SharedModel
        {
            get
            {
                if (_sharedModel == null)
                {
                    _sharedModel = new ConnectionInformationModel();
                }
                return _sharedModel;
            }
        }
        
        #endregion

        #region add parameter
        private readonly Dictionary<string, Action<object>> _colleagues = new Dictionary<string, Action<object>>();

        public void Subscribe(string message, Action<object> action)
        {
            if (!_colleagues.ContainsKey(message))
            {
                _colleagues[message] = null;
            }

            _colleagues[message] += action;
        }

        public void Unsubscribe(string message, Action<object> action)
        {
            if (_colleagues.ContainsKey(message))
            {
                _colleagues[message] -= action;
            }
        }

        public void Notify(string message, object parameter)
        {
            if (_colleagues.ContainsKey(message))
            {
                _colleagues[message]?.Invoke(parameter);
            }
        }
        #endregion

        #region no parameter
        private readonly Dictionary<string, Action> _colleagues_noparam = new Dictionary<string, Action>();

        public void Subscribe(string message, Action action)
        {
            if (!_colleagues_noparam.ContainsKey(message))
            {
                _colleagues_noparam[message] = null;
            }

            _colleagues_noparam[message] += action;
        }

        public void Unsubscribe(string message, Action action)
        {
            if (_colleagues_noparam.ContainsKey(message))
            {
                _colleagues_noparam[message] -= action;
            }
        }

        public void Notify(string message)
        {
            if (_colleagues_noparam.ContainsKey(message))
            {
                _colleagues_noparam[message]?.Invoke();
            }
        }
        #endregion        
    }
}
