using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_BlackJack.Presentation;

namespace WPF_BlackJack.Models
{
    public class Round : ObservableObject
    {
        private int _id;
        private int _sessionid;
        private int _gains;
        private int _Userid;
        private int _winlos;

        public int id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        public int sessionid
        {
            get => _sessionid;
            set
            {
                _sessionid = value;
                OnPropertyChanged(nameof(sessionid));
            }
        }

        public int gains
        {
            get => _gains;
            set
            {
                _gains = value;
                OnPropertyChanged(nameof(gains));
            }
        }

        public int Userid
        {
            get => _Userid;
            set
            {
                _Userid = value;
                OnPropertyChanged(nameof(Userid));
            }
        }

        public int winlos
        {
            get => _winlos;
            set
            {
                _winlos = value;
                OnPropertyChanged(nameof(winlos));
            }
        }

        public Round(int id, int sessionid, int gains, int Userid, int winlos)
        {
            _id = id;
            _sessionid = sessionid;
            _gains = gains;
            _Userid = Userid;
            _winlos = winlos;
        }

    }
}
