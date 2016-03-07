using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    /// <summary>
    /// Guest class, inherits from Character class
    /// </summary>
    public class Guest : Character
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS

        private bool _appearsFriendly;
        private string _initialGreeting;

        #endregion

        #region PROPERTIES

        public bool AppearsFriendly
        {
            get { return _appearsFriendly; }
            set { _appearsFriendly = value; }
        }

        public string InitialGreeting
        {
            get { return _initialGreeting; }
            set { _initialGreeting = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Guest()
        {

        }
        /// <summary>
        /// instantiate a guest and set initial properties
        /// </summary>
        /// <param name="name">guest name</param>
        /// <param name="gender">guest gender</param>
        /// <param name="race">guest race</param>
        /// <param name="currentRoomNumber">room location as an index of the hall array</param>
        public Guest(
            string name,
            int currentRoomNumber)
            : base(name, currentRoomNumber)
        {

        }

        #endregion

        #region METHODS

        /// <summary>
        /// override method for the guest's greeting
        /// </summary>
        /// <returns>greeting string</returns>
        public string Greeting(Player player)
        {
            string greeting;
            greeting = string.Format("Hello, my name is {1}. {3}", _name, _initialGreeting);

            return greeting;
        }

        #endregion
    }
}
