using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        private char activePlayer;
        public Player()
        {
            //aktywny gracz - zaczynają kółka
            activePlayer = 'O';
        }
        public string GetPlayer()
        {
            //zwróć symbol gracza jako string do umieszczania na guziku
            return activePlayer.ToString();
        }
        public void SwitchPlayer()
        {
            //zmień aktywnego gracza
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
        }
        public void Reset()
        {
            
            activePlayer = 'O';
        }
    }
}
