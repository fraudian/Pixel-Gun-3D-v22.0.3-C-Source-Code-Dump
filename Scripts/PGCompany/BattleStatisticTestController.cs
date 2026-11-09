using UnityEngine;

namespace PGCompany
{
    internal sealed class BattleStatisticTestController : PGBehaviour
    {
        // Fields
        private static PGCompany.BattleStatisticTestController 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.BattleStatisticTestController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.BattleStatisticTestController 丑七不且上丗丁一世()
        {
            PGCompany.BattleStatisticTestController val_4 = PGCompany.BattleStatisticTestController.丝业丆丁业三丈丟东;
            if(val_4 != 0)
            {
                    return (PGCompany.BattleStatisticTestController)PGCompany.BattleStatisticTestController.丝业丆丁业三丈丟东;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "BattleStatisticTestController");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            PGCompany.BattleStatisticTestController.丝业丆丁业三丈丟东 = val_2.AddComponent<PGCompany.BattleStatisticTestController>();
            return (PGCompany.BattleStatisticTestController)PGCompany.BattleStatisticTestController.丝业丆丁业三丈丟东;
        }
        private void Awake()
        {
            PGCompany.BattleStatisticTestController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public BattleStatisticTestController()
        {
        
        }
    
    }

}
