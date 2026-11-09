using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    public abstract class Integers
    {
        // Methods
        public static int RotateLeft(int i, int distance)
        {
            var val_2 = -distance;
            int val_1 = distance & 31;
            val_2 = val_2 & 31;
            val_1 = i << val_1;
            val_2 = i >> val_2;
            i = val_1 ^ val_2;
            return (int)i;
        }
        public static int RotateRight(int i, int distance)
        {
            var val_2 = -distance;
            int val_1 = distance & 31;
            val_2 = val_2 & 31;
            val_1 = i >> val_1;
            val_2 = i << val_2;
            i = val_1 ^ val_2;
            return (int)i;
        }
        protected Integers()
        {
        
        }
    
    }

}
