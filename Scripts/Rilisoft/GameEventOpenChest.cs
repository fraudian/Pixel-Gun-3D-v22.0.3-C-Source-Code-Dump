using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventOpenChest : GameEventOpenChestBase
    {
        // Fields
        private UnityEngine.Camera _camera;
        
        // Properties
        internal static bool 丞不丗丄丞丘丛丙东 { get; }
        
        // Methods
        internal static bool 丁七下丌丏丄丟上三()
        {
            var val_5;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                    return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  135)) > 0) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  135)) > 0) ? 1 : 0;
        }
        public override void Show()
        {
            this.Show();
            PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
            if(( & 1) == 0)
            {
                    return;
            }
            
            PGCompany.丆下丐丁丏世丈上丟 val_2 = this.丑丐丙丄丅世世丑丒();
            this._camera.depth = V0.16B;
        }
        protected override void 业不下业与下丛一丂()
        {
            goto typeof(Rilisoft.GameEventOpenChest).__il2cppRuntimeField_258;
        }
        public GameEventOpenChest()
        {
            this = new BannerWindowWithBack();
        }
    
    }

}
