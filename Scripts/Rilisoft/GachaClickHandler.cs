using UnityEngine;

namespace Rilisoft
{
    internal class GachaClickHandler : MonoBehaviour
    {
        // Fields
        private static Rilisoft.GachaClickHandler 世丒丞七专三与万丕;
        
        // Properties
        internal static Rilisoft.GachaClickHandler 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static Rilisoft.GachaClickHandler 丑七不且上丗丁一世()
        {
            return (Rilisoft.GachaClickHandler)Rilisoft.GachaClickHandler.世丒丞七专三与万丕;
        }
        private void Awake()
        {
            Rilisoft.GachaClickHandler.世丒丞七专三与万丕 = this;
        }
        private void OnDestroy()
        {
            Rilisoft.GachaClickHandler.世丒丞七专三与万丕 = 0;
        }
        private void OnClick()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(ButOpenGift.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            ButOpenGift.丄丘七三上丕世丞业.Click();
        }
        public GachaClickHandler()
        {
        
        }
    
    }

}
