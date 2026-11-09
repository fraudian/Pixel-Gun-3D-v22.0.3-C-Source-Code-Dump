using UnityEngine;
internal sealed class ButtonPressEffect : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<ButtonPressEffectEntry> moveOnPress;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnPress;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnRelease;
    
    // Methods
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_4;
        var val_5;
        if(this.moveOnPress == null)
        {
            goto label_8;
        }
        
        List.Enumerator<T> val_1 = this.moveOnPress.GetEnumerator();
        label_4:
        if((892275016 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        val_2.丅专下万丕丑丆丅丝(万东丂丒且丅丛丑丕:  万东丂丒且丅丛丑丕);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_8:
        if(万东丂丒且丅丛丑丕 != false)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnPress, 丏业丟一东丂东丘丛:  true);
            val_4 = this.enableOnRelease;
            val_5 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnPress, 丏业丟一东丂东丘丛:  false);
            val_4 = this.enableOnRelease;
            val_5 = 1;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
    }
    public ButtonPressEffect()
    {
    
    }

}
