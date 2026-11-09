using UnityEngine;

namespace PGCompany.Banners
{
    public class FreePlayModeInfo : BannerWindow
    {
        // Properties
        internal static bool 丁丟丛丛不丏丞东丕 { get; }
        
        // Methods
        internal static bool 丞丈上丙丟七丄丗东()
        {
            var val_10;
            var val_11;
            if(ConnectScene.丈丘丂丙不丛业丟三() != false)
            {
                    val_10 = ExperienceController.丂丂下丑且下丌丝东();
                if(val_10 >= (Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  31)))
            {
                    System.Version val_5 = 业丂丏与世一丏业不.一丒三丝三下丑业下();
                if(val_5 != null)
            {
                    if(val_5.Major <= 19)
            {
                    val_10 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
                val_11 = (val_10.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  68)) ^ 1;
                return (bool)val_11 & 1;
            }
            
            }
            
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11 & 1;
        }
        public override void Show()
        {
            this.Show();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  68);
        }
        public void U_OnClickOkButton()
        {
            UnityEngine.Object val_3;
            var val_4;
            var val_5;
            val_3 = this;
            this.HideSelf();
            if(ConnectScene.丈丘丂丙不丛业丟三() == false)
            {
                    return;
            }
            
            val_4 = static_value_081DACA8;
            val_4 = static_value_081DACA8;
            val_3 = mem[static_value_081DACA8 + 184 + 16];
            val_3 = static_value_081DACA8 + 184 + 16;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_5 = static_value_081DACA8;
            val_5 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.丘东万丙丌丑丄丗专(丒七世丈丌丑丏丄丏:  31);
        }
        public FreePlayModeInfo()
        {
        
        }
    
    }

}
