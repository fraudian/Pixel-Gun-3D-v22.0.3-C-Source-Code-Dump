using UnityEngine;

namespace PGCompany
{
    internal sealed class FeatureTestController : PGBehaviour
    {
        // Fields
        private static PGCompany.FeatureTestController 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.FeatureTestController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.FeatureTestController 丑七不且上丗丁一世()
        {
            PGCompany.FeatureTestController val_4 = PGCompany.FeatureTestController.丝业丆丁业三丈丟东;
            if(val_4 != 0)
            {
                    return (PGCompany.FeatureTestController)PGCompany.FeatureTestController.丝业丆丁业三丈丟东;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "FeatureTestController");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            PGCompany.FeatureTestController.丝业丆丁业三丈丟东 = val_2.AddComponent<PGCompany.FeatureTestController>();
            return (PGCompany.FeatureTestController)PGCompany.FeatureTestController.丝业丆丁业三丈丟东;
        }
        private void Awake()
        {
            PGCompany.FeatureTestController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public FeatureTestController()
        {
        
        }
    
    }

}
