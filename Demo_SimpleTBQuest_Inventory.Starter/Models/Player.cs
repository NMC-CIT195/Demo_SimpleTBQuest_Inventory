using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    /// <summary>
    /// Player class, inherits from Character class
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES

        public enum ActionChoice
        {
            None,
            QuitGame,
            Move,
            Get,
            Leave
        }

        #endregion

        #region FIELDS

        private bool _inHall;
        private int _actionCount = Enum.GetNames(typeof(ActionChoice)).Length;

        #endregion

        #region PROPERTIES

        public bool InHall
        {
            get { return _inHall; }
            set { _inHall = value; }
        }

        public int ActionCount
        {
            get { return _actionCount; }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// instantiate a player and set initial properties
        /// </summary>
        /// <param name="name">player name</param>
        /// <param name="currentRoomNumber">room location as an index of the hall array</param>
        public Player(
            string name,
            int currentRoomNumber)
            : base(name, currentRoomNumber)
        {

        }

        #endregion

        #region METHODS

        #endregion
    }
}
