using UnityEngine;

namespace Rilisoft
{
    public class GameEventChestLapsView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.与专丒丞丐一丒丂东>
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.GameEventChestLapView> _lapViews;
        private Rilisoft.与专丒丞丐一丒丂东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        public Rilisoft.与专丒丞丐一丒丂东 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public Rilisoft.与专丒丞丐一丒丂东 get_Context()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.与专丒丞丐一丒丂东 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            int val_5;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_2;
            label_14:
            Rilisoft.GameEventChestLapView val_1 = this._lapViews.Item[0];
            UnityEngine.GameObject val_3 = val_1.gameObject;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.专丝东丘一丐丛丂丛()) > val_5)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
                val_1.<丅丝丌丝丁丏丙东丞>k__BackingField = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
                val_1.世丝丞七丅丝丄与三 = val_5;
                val_1.丝一丅丆三东丂丞七();
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
            }
            
            val_5 = 1;
            label_2:
            if(val_5 < this._lapViews.Count)
            {
                goto label_14;
            }
        
        }
        public GameEventChestLapsView()
        {
        
        }
    
    }

}
