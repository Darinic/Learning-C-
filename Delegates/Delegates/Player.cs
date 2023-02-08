using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Player
    {

        public string PlayerName { get; set; }
        
        public Player(string name)
        {
            this.PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName} ");
        }

        private void GameOver()
        {
            Console.WriteLine($"Player {PlayerName} has been removed from the game");
        }
    }
}
