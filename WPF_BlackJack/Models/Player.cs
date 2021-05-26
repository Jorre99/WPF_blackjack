using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WPF_BlackJack.Presentation;
namespace WPF_BlackJack.Models
{
    [Serializable]
    public class Player : ObservableObject
    {
        #region BackingFields
        private int _id;
        private string _name;
        private int _bankRoll;
        private int _totalBet;
        private int _totalWinnings;
        private int? _cardTotal;
        private List<string> _card;
        private int _betAmount;
        private int _win;

        #endregion

        #region Properties
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
            
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int BankRoll
        {
            get => _bankRoll;
            set
            {
                _bankRoll = value;
                OnPropertyChanged(nameof(BankRoll));
            }
        }
        
        [JsonIgnore]
        public int TotalBet
        {
            get => _totalBet;
            set
            {
                _totalBet = value;
                OnPropertyChanged(nameof(TotalBet));
            }
        }
        
        [JsonIgnore]
        public int TotalWinnings
        {
            get => _totalWinnings;
            set
            {
                _totalWinnings = value;
                OnPropertyChanged(nameof(TotalWinnings));
            }
        }

        [JsonIgnore]
        public int? CardTotal
        {
            get => _cardTotal;
            set
            {
                _cardTotal = value;
                OnPropertyChanged(nameof(CardTotal));
            }
        }


        [JsonIgnore]
        public List<string> Card
        {
            get => _card;
            set
            {
                _card = value;
                OnPropertyChanged(nameof(Card));
            }
        }

        [JsonIgnore]
        public int BetAmount
        {
            get => _betAmount;
            set
            {
                _betAmount = value;
                OnPropertyChanged(nameof(BetAmount));
            }
        }

        public int win
        {
            get => _win;
            set
            {
                _win = value;
                OnPropertyChanged(nameof(win));
            }
        }

        #endregion

        #region Constructor

        public Player(int id, string Name, int BankRoll) 
        {
            _id = id;
            _name = Name;
            _bankRoll = BankRoll;
            _totalBet = 0;
            _totalWinnings = 0;
            _betAmount = 0;
            _win = 0;
            this.Card = new List<string>();
        }

        public Player(int totalWinnings, int win)
        {
            _name = Name;
            _bankRoll = BankRoll;
            _totalBet = 0;
            _totalWinnings = totalWinnings;
            _betAmount = 0;
            _win = win;
            this.Card = new List<string>();
        }


        #endregion
    }
}
