using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public struct SkinMemento : IEquatable<Rilisoft.SkinMemento>
    {
        // Fields
        private string id;
        private string name;
        private string skin;
        private System.Nullable<int> _skinHashCode;
        
        // Properties
        public string Id { get; }
        public string Name { get; }
        public string Skin { get; }
        
        // Methods
        public SkinMemento(string 丞丅上丏丂且下丅与, string 丒丘丏上丙丟丑丕丈, string 丂丒丘丅专丗丂世丛)
        {
        
        }
        public string get_Id()
        {
            string val_1 = this.skin;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public string get_Name()
        {
            System.Nullable<System.Int32> val_1 = this._skinHashCode;
            if(val_1 != 0)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public string get_Skin()
        {
            int val_1;
            if(69355 != 0)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public bool Equals(Rilisoft.SkinMemento 丘丛丏丘丝七世七丅)
        {
            string val_1 = this.skin;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
        
        }
        public override int GetHashCode()
        {
        
        }
        public override string ToString()
        {
        
        }
        private int 且不不丂万丗丆万丟()
        {
            return 106043712;
        }
    
    }

}
