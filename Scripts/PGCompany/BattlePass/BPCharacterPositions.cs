using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPCharacterPositions : ScriptableObject
    {
        // Fields
        private static PGCompany.BattlePass.BPCharacterPositions _instance;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPCharacterPositions.PositionDescription> Storage;
        
        // Properties
        internal static PGCompany.BattlePass.BPCharacterPositions Instance { get; }
        
        // Methods
        internal static PGCompany.BattlePass.BPCharacterPositions get_Instance()
        {
            if(PGCompany.BattlePass.BPCharacterPositions._instance != 0)
            {
                    return (PGCompany.BattlePass.BPCharacterPositions)PGCompany.BattlePass.BPCharacterPositions._instance;
            }
            
            PGCompany.BattlePass.BPCharacterPositions._instance = UnityEngine.Resources.Load<PGCompany.BattlePass.BPCharacterPositions>(path:  "BattlePassCharacterPositions");
            return (PGCompany.BattlePass.BPCharacterPositions)PGCompany.BattlePass.BPCharacterPositions._instance;
        }
        internal static PGCompany.BattlePass.BPCharacterPositions.PositionDescription 丐丅丟丙一且丟丗丝(string 丞一丁业丄一一业且)
        {
            var val_6;
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            val_6 = 0;
            if(PGCompany.BattlePass.BPCharacterPositions.Instance == 0)
            {
                    return (PositionDescription)val_6;
            }
            
            if(val_2.Storage != null)
            {
                    PositionDescription val_5 = System.Linq.Enumerable.FirstOrDefault<PositionDescription>(source:  val_2.Storage, predicate:  new System.Func<PositionDescription, System.Boolean>(object:  new BPCharacterPositions.上丌专丄丘丂东且丒(), method:  System.Boolean BPCharacterPositions.上丌专丄丘丂东且丒::七东丟且万丏一丗丘(PGCompany.BattlePass.BPCharacterPositions.PositionDescription 丏丛与丅丛丌万专丌)));
                return (PositionDescription)val_6;
            }
            
            val_6 = 0;
            return (PositionDescription)val_6;
        }
        public BPCharacterPositions()
        {
        
        }
    
    }

}
