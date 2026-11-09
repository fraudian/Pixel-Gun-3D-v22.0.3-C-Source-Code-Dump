using UnityEngine;

namespace BestHTTP.Authentication
{
    public sealed class Credentials
    {
        // Fields
        private BestHTTP.Authentication.AuthenticationTypes <Type>k__BackingField;
        private string <UserName>k__BackingField;
        private string <Password>k__BackingField;
        
        // Properties
        public BestHTTP.Authentication.AuthenticationTypes Type { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        // Methods
        public BestHTTP.Authentication.AuthenticationTypes get_Type()
        {
            return (BestHTTP.Authentication.AuthenticationTypes)this.<Type>k__BackingField;
        }
        private void set_Type(BestHTTP.Authentication.AuthenticationTypes value)
        {
            this.<Type>k__BackingField = value;
        }
        public string get_UserName()
        {
            return (string)this.<UserName>k__BackingField;
        }
        private void set_UserName(string value)
        {
            this.<UserName>k__BackingField = value;
        }
        public string get_Password()
        {
            return (string)this.<Password>k__BackingField;
        }
        private void set_Password(string value)
        {
            this.<Password>k__BackingField = value;
        }
        public Credentials(string userName, string password)
        {
            val_1 = new System.Object();
            this.<Type>k__BackingField = 0;
            this.<UserName>k__BackingField = userName;
            this.<Password>k__BackingField = val_1;
        }
        public Credentials(BestHTTP.Authentication.AuthenticationTypes type, string userName, string password)
        {
            val_1 = new System.Object();
            this.<Type>k__BackingField = type;
            this.<UserName>k__BackingField = val_1;
            this.<Password>k__BackingField = password;
        }
    
    }

}
