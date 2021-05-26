using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_BlackJack.Data;
using WPF_BlackJack.Models;

namespace WPF_BlackJack.Business
{
    public class GameBusiness
    {
        public enum GameStatus 
        {
            Quit,
            QuitSave
        }

        private string _userName;
        private PlayerDataService _playerDataService;

        public Player daprplayer { get; private set; }

        public string UserName
        {
            get => _userName;
            set 
            {
                _userName = value; 
            }
        }


        List<Player> _allPlayers;

        Player _player;


        public GameBusiness()
        {
        }


        public List<Player> GetAllPlayers() 
        {
            _playerDataService = new PlayerDataService();
            return _playerDataService.GetUsers();
        }
        public List<Round> GetRounds(Player player)
        {
            _playerDataService = new PlayerDataService();
            return _playerDataService.GetRounds(player.Id);
        }

        public void SavePlayer(List<Player> player, string userName) 
        {
            _userName = userName;
            _playerDataService = new PlayerDataService();
            _playerDataService.InsertUser(player[0]);
        }

        public void SaveRound(List<Player> player, string userName)
        {
            _userName = userName;
            _playerDataService = new PlayerDataService();
            _playerDataService.UpdateUser(player[0]);
            _playerDataService.InsertRound(player[0]);
        }


        public Player GetPlayer(string userName)
        {
            _allPlayers = GetAllPlayers();

            foreach (var player in _allPlayers)
            {

                player.Name = player.Name.Replace(" ", String.Empty);
                if (player.Name == userName)
                {
                    _userName = userName;
                    _player = player;
                    return _player;

                }

            }
            return _player  ;
        }
    }

}
