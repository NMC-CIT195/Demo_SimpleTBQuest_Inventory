using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleTBQuest_Inventory
{
    /// <summary>
    /// class to manage the game flow
    /// </summary>
    class GameController
    {
        #region FIELDS

        //
        // declare the major data objects
        //
        private Player _myPlayer;
        private Hall _hall;
        private ConsoleView _userConsoleView;

        // Demo
        private GameItemInventory _gameInventory;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// when the GameController object is instantiated, setup the game and begin playing
        /// </summary>
        public GameController()
        {
            SetupGame();
            PlayGame();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Set up all data objects before game play
        /// </summary>
        private void SetupGame()
        {
            //
            // instantiate a Player, Hall, and Guests
            //
            InitializePlayer();
            InitializeHall();
            InitializeGameInventory();
            InitializeUserConsoleView();
        }

        /// <summary>
        /// perform the game loop
        /// </summary>
        private void PlayGame()
        {
            //
            // instantiate a new ConsoleView object
            //
            _userConsoleView = new ConsoleView(_myPlayer, _hall, _gameInventory);

            _userConsoleView.DisplayWelcomeScreen();

            _userConsoleView.DisplayAllObjectInformation();

            _userConsoleView.DisplayReset();
            _userConsoleView.DisplayExitPrompt();
        }

        /// <summary>
        /// initialize the player with their properties
        /// </summary>
        private void InitializePlayer()
        {
            _myPlayer = new Player(
                "Bonzo",
                1);
        }

        /// <summary>
        /// initialize the hall and rooms with their properties
        /// </summary>
        private void InitializeHall()
        {
            _hall = new Hall();

            //
            // initialize array of rooms
            //
            for (int roomNumber = 0; roomNumber < 4; roomNumber++)
            {
                _hall.Rooms[roomNumber] = new Room();
            }

            //
            // add room information
            //
            _hall.Rooms[0].Name = "The Great Hall";
            _hall.Rooms[0].Description = "You are in a large room with oak beams and dark wood panel." +
                                    "The room is filled with furniture dating back to the 18th century." +
                                     "On all but one wall you notice a large door large brass knobs.";
            _hall.Rooms[0].Type = Room.TypeName.Room;
            _hall.Rooms[0].IsLighted = true;
            _hall.Rooms[0].CanEnter = true;

            _hall.Rooms[1].Name = "The Master Bedroom";
            _hall.Rooms[1].Description = "You are in a large room with oak beams and dark wood panel.";
            _hall.Rooms[1].Type = Room.TypeName.Room;
            _hall.Rooms[1].IsLighted = false;
            _hall.Rooms[1].CanEnter = true;
            _hall.Rooms[1].RoomGuest = new Guest
            {
                Name = "Mr. Smith",
                AppearsFriendly = true,
                CurrentRoomNumber = 1,
                InitialGreeting = "Hello, my name is Mr. Smith and I am a traveler from the North Region."
            };

            _hall.Rooms[2].Name = "The Kitchen";
            _hall.Rooms[2].Description = "You are in a large room with oak beams and dark wood panel.";
            _hall.Rooms[2].Type = Room.TypeName.Room;
            _hall.Rooms[2].IsLighted = true;
            _hall.Rooms[2].CanEnter = true;
            _hall.Rooms[2].RoomGuest = null;

            _hall.Rooms[3].Name = "The Armory";
            _hall.Rooms[3].Description = "You are in a room, crowed with racks of swords.";
            _hall.Rooms[3].Type = Room.TypeName.Room;
            _hall.Rooms[3].IsLighted = true;
            _hall.Rooms[3].CanEnter = true;
            _hall.Rooms[3].RoomGuest = new Guest
            {
                Name = "Gordle",
                AppearsFriendly = false,
                CurrentRoomNumber = 3,
                InitialGreeting = "You are in my room. What are your intentions?"
            };
        }

        // Demo
        /// <summary>
        /// Initialize starting game inventory
        /// </summary>
        public void InitializeGameInventory()
        {
            _gameInventory = new GameItemInventory();

            _gameInventory.GameItems.Add(
                new GameItem
                {
                    Name = "Golden Goose",
                    ItemType = GameItem.GameItenType.GeneralObject,
                    CurrentLocation = 1,
                    IsInPlayerInventory = false
                }
                );

            _gameInventory.GameItems.Add(
                new GameItem
                {
                    Name = "Golden Goose",
                    ItemType = GameItem.GameItenType.GeneralObject,
                    CurrentLocation = 1,
                    IsInPlayerInventory = false
                }
                );

            _gameInventory.GameItems.Add(
                new GameItem
                {
                    Name = "Crystal Key",
                    ItemType = GameItem.GameItenType.Key,
                    CurrentLocation = 1,
                    IsInPlayerInventory = false
                }
                );

            _gameInventory.GameItems.Add(
                new GameItem
                {
                    Name = "Thumper Emerald",
                    ItemType = GameItem.GameItenType.Jewel,
                    CurrentLocation = 0,
                    IsInPlayerInventory = false
                }
                );
        }

        /// <summary>
        /// initialize the ConsoleView object
        /// </summary>
        public void InitializeUserConsoleView()
        {
            //
            // instantiate a new ConsoleView object
            //
            _userConsoleView = new ConsoleView(_myPlayer, _hall, _gameInventory);
        }

        #endregion
    }
}
