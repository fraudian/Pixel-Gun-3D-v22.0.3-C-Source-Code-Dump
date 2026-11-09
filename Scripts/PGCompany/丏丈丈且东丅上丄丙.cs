using UnityEngine;

namespace PGCompany
{
    internal class 丏丈丈且东丅上丄丙
    {
        // Fields
        private 丘丙且丏丌世丗上丁 _type;
        private string _id;
        
        // Properties
        internal 丘丙且丏丌世丗上丁 丒三丝一上丙专丗丒 { get; }
        internal string 下丄丈不与世丐业专 { get; }
        
        // Methods
        internal 丘丙且丏丌世丗上丁 不业丙丒丂丞下丆丙()
        {
            return (丘丙且丏丌世丗上丁)this._type;
        }
        internal string 业上丙丞丐丄丆丅七()
        {
            return (string)this._id;
        }
        internal 丏丈丈且东丅上丄丙()
        {
        
        }
        internal 丏丈丈且东丅上丄丙(丘丙且丏丌世丗上丁 丁丅丈丌丟世丗丗丟, int 丞世不丒下上上丝丑)
        {
            this._type = 丁丅丈丌丟世丗丗丟;
            this._id = 丞世不丒下上上丝丑.ToString();
        }
        internal 丏丈丈且东丅上丄丙(丘丙且丏丌世丗上丁 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与)
        {
            val_1 = new System.Object();
            this._type = 丁丅丈丌丟世丗丗丟;
            this._id = val_1;
        }
        internal bool 丑丕丈丈不不且丑且()
        {
            丘丙且丏丌世丗上丁 val_3 = this._type;
            if(val_3 != 0)
            {
                    bool val_1 = System.String.IsNullOrEmpty(value:  this._id);
                val_3 = val_1 ^ 1;
            }
            
            val_1 = val_3;
            return (bool)val_1;
        }
    
    }

}
