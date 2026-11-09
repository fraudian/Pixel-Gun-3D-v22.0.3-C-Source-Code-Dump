using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPChallengeParameter
    {
        // Fields
        public string Name;
        public string Value;
        
        // Methods
        public override string ToString()
        {
            return System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}={1}", arg0:  (this.Name == null) ? "(null)" : this.Name, arg1:  (this.Value == null) ? "(null)" : this.Value);
        }
        public BPChallengeParameter()
        {
        
        }
    
    }

}
