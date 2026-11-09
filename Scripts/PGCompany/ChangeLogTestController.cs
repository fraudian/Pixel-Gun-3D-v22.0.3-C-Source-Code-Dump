using UnityEngine;

namespace PGCompany
{
    internal sealed class ChangeLogTestController : PGBehaviour
    {
        // Fields
        private static PGCompany.ChangeLogTestController 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.ChangeLogTestController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.ChangeLogTestController 丑七不且上丗丁一世()
        {
            PGCompany.ChangeLogTestController val_4 = PGCompany.ChangeLogTestController.丝业丆丁业三丈丟东;
            if(val_4 != 0)
            {
                    return (PGCompany.ChangeLogTestController)PGCompany.ChangeLogTestController.丝业丆丁业三丈丟东;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "ChangeLogTestController");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            PGCompany.ChangeLogTestController.丝业丆丁业三丈丟东 = val_2.AddComponent<PGCompany.ChangeLogTestController>();
            return (PGCompany.ChangeLogTestController)PGCompany.ChangeLogTestController.丝业丆丁业三丈丟东;
        }
        private void Awake()
        {
            PGCompany.ChangeLogTestController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public ChangeLogTestController()
        {
        
        }
    
    }

}
