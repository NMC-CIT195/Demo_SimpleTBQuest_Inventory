using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    // TODO 01 - add a Character class to act as the base class for the Player class
    /// <summary>
    /// base class for player and guests in game
    /// </summary>
    public class Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        protected string _name;
        private int _currentRoomNumber;

        public int CurrentRoomNumber
        {
            get { return _currentRoomNumber; }
            set { _currentRoomNumber = value; }
        }
        

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        /// <summary>
        /// instantiate a character and set initial properties
        /// </summary>
        /// <param name="name">character name</param>
        public Character(string name, int currentRoomNumber)
        {
            _name = name;
            _currentRoomNumber = currentRoomNumber;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
