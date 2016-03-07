using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    /// <summary>
    /// class to manage an array of rooms
    /// </summary>
    public class Hall
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS

        public const int MAX_ROOMS = 4;

        private Room[] _rooms;


        #endregion

        #region PROPERTIES
        public Room[] Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Hall()
        {
            _rooms = new Room[MAX_ROOMS];
        }

        #endregion

        #region METHODS

        #endregion
    }
}
