using UnityEngine;

namespace Rilisoft
{
    public class AreaPlayerStepsSounds : AreaBase
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<int, SkinName> 七丏三丞丈丏与专丂;
        private Rilisoft.PlayerStepsSoundsData _sounds;
        private Rilisoft.PlayerStepsSoundsData _soundsOriginal;
        
        // Methods
        public override void CheckIn(UnityEngine.GameObject 专丂丕丗丗东世丞下)
        {
            mem[1152921542323614848] = 1;
        }
        public override void CheckOut(UnityEngine.GameObject 丈丗与丞一上且上上)
        {
            mem[1152921542323735040] = 0;
        }
        private SkinName 丌丈丆上丁万万三丗(UnityEngine.GameObject 丝三丁东丈丒世丅业)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Func<UnityEngine.GameObject, System.Boolean> val_10;
            var val_11;
            val_6 = null;
            val_6 = null;
            if((Rilisoft.AreaPlayerStepsSounds.七丏三丞丈丏与专丂.ContainsKey(key:  丝三丁东丈丒世丅业)) != false)
            {
                    val_7 = null;
                val_7 = null;
                if(Rilisoft.AreaPlayerStepsSounds.七丏三丞丈丏与专丂 != null)
            {
                    return Rilisoft.AreaPlayerStepsSounds.七丏三丞丈丏与专丂.Item[丝三丁东丈丒世丅业];
            }
            
                return Rilisoft.AreaPlayerStepsSounds.七丏三丞丈丏与专丂.Item[丝三丁东丈丒世丅业];
            }
            
            val_8 = null;
            val_8 = null;
            val_10 = AreaPlayerStepsSounds.<>c.<>9__5_0;
            if(val_10 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Boolean> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  AreaPlayerStepsSounds.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AreaPlayerStepsSounds.<>c::丘世丆丗上丁丅丏丄(UnityEngine.GameObject 丆丛丑世下一丐且丕));
                AreaPlayerStepsSounds.<>c.<>9__5_0 = val_10;
            }
            
            SkinName val_5 = System.Linq.Enumerable.First<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.东丕丟丏丐业丅东丐(丈丆上丅丘世专丑丕:  丝三丁东丈丒世丅业), predicate:  val_3).GetComponentInChildren<SkinName>();
            val_11 = null;
            val_11 = null;
            Rilisoft.AreaPlayerStepsSounds.七丏三丞丈丏与专丂.Add(key:  丝三丁东丈丒世丅业, value:  val_5);
            return val_5;
        }
        public AreaPlayerStepsSounds()
        {
        
        }
        private static AreaPlayerStepsSounds()
        {
            Rilisoft.AreaPlayerStepsSounds.七丏三丞丈丏与专丂 = new System.Collections.Generic.Dictionary<System.Int32, SkinName>();
        }
    
    }

}
