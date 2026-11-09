using UnityEngine;

namespace PGCompany
{
    internal sealed class PixelPassTestController : PGBehaviour
    {
        // Fields
        private static PGCompany.PixelPassTestController 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.PixelPassTestController 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.PixelPassTestController 丑七不且上丗丁一世()
        {
            PGCompany.PixelPassTestController val_4 = PGCompany.PixelPassTestController.丝业丆丁业三丈丟东;
            if(val_4 != 0)
            {
                    return (PGCompany.PixelPassTestController)PGCompany.PixelPassTestController.丝业丆丁业三丈丟东;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "PixelPassTestController");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            PGCompany.PixelPassTestController.丝业丆丁业三丈丟东 = val_2.AddComponent<PGCompany.PixelPassTestController>();
            return (PGCompany.PixelPassTestController)PGCompany.PixelPassTestController.丝业丆丁业三丈丟东;
        }
        private void Awake()
        {
            PGCompany.PixelPassTestController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        public PixelPassTestController()
        {
        
        }
    
    }

}
