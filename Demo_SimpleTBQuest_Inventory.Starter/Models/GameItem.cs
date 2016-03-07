using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    public class GameItem
    {
        #region ENUMERABLES

        public enum GameItenType
        {
            GeneralObject,
            Key,
            Jewel,
            Coin
        }

        #endregion


        #region FIELDS

        private string _name;
        private GameItenType _ItemType;
        private int _currentLocation;        
        private bool _isInPlayerInventory;

        #endregion


        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public GameItenType ItemType
        {
            get { return _ItemType; }
            set { _ItemType = value; }
        }
        public int CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }
        
        public bool IsInPlayerInventory
        {
            get { return _isInPlayerInventory; }
            set { _isInPlayerInventory = value; }
        }

        #endregion


        #region CONSTRUCTORS



        #endregion


        #region METHODS



        #endregion
    }
}
