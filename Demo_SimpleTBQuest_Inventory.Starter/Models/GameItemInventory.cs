using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    public class GameItemInventory
    {
        private List<GameItem> _gameItems;

        public List<GameItem> GameItems
        {
            get { return _gameItems; }
            set { _gameItems = value; }
        }

        public GameItemInventory()
        {
            _gameItems = new List<GameItem>();
        }
    }
}
