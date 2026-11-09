using UnityEngine;

namespace Org.BouncyCastle.Utilities.Date
{
    public sealed class DateTimeObject
    {
        // Fields
        private readonly System.DateTime dt;
        
        // Properties
        public System.DateTime Value { get; }
        
        // Methods
        public DateTimeObject(System.DateTime dt)
        {
            this.dt = dt;
        }
        public System.DateTime get_Value()
        {
            return (System.DateTime)this.dt;
        }
        public override string ToString()
        {
            return 655535880;
        }
    
    }

}
