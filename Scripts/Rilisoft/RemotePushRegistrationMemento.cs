using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal struct RemotePushRegistrationMemento : IEquatable<Rilisoft.RemotePushRegistrationMemento>
    {
        // Fields
        private string registrationId;
        private string registrationTime;
        private string version;
        
        // Properties
        public string RegistrationId { get; }
        public string RegistrationTime { get; }
        public string Version { get; }
        
        // Methods
        public RemotePushRegistrationMemento(string 一丌丅丂丑丅丝丂丁, System.DateTime 丁丄丞丂丄丕业丛三, string 丌丈不丄丝七丕万专)
        {
        
        }
        public string get_RegistrationId()
        {
            string val_1 = this.version;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public string get_RegistrationTime()
        {
            int val_1;
            if(64329 != 0)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public string get_Version()
        {
            int val_1;
            if(64330 != 0)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public bool Equals(Rilisoft.RemotePushRegistrationMemento 丘丛丏丘丝七世七丅)
        {
            string val_1 = this.version;
            val_1 = val_1 & 1;
            return (bool)val_1;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
        
        }
        public override int GetHashCode()
        {
            return 106038320;
        }
    
    }

}
