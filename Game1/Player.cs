// Dyllan Sowers

namespace Game1
{
    public sealed class Player
    {
        // The class is sealed so that we cannot make a subclass
        // a subclass would have its own constructor
        // which would break Liskoff's rule
        // i.e. the subclass could have more than one instance

        private int level = 0;
        private string name = "n/a";
        private IWeapon weapon;

        // This must be static because the constructor is static
        // and the constructor is static because we want to limit
        // what code is allowed to call this constructor
        private static readonly Player thePlayer;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public IWeapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public static Player ThePlayer
        {
            get
            {
                return thePlayer;
            }
        }
        private Player()
        {
            // This could have code in it, but it is unlikely
        }

        static Player()
        {
            //if (thePlayer.Equals(null))
            //{
            thePlayer = new Player();
            //}
            // we don't need the if statement because our constructor is static
            // this code is thread safe and will only run once  
        }
    }
}
