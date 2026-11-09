using UnityEngine;
internal sealed class MaxLevelStateSwitch : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<UILabel> textLabel;
    private string maxLevel_Key;
    private string notMaxLevel_Key;
    private System.Collections.Generic.List<UnityEngine.GameObject> maxLevel;
    private System.Collections.Generic.List<UnityEngine.GameObject> notMaxLevel;
    
    // Methods
    private void OnEnable()
    {
        var val_5;
        string val_6;
        int val_1 = ExperienceController.丞丞丘业东丙丏七丌();
        if(val_1 < 65)
        {
                val_5 = null;
            val_6 = this.notMaxLevel_Key;
        }
        else
        {
                val_5 = null;
            val_6 = this.maxLevel_Key;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.textLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6));
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.maxLevel, 丏业丟一东丂东丘丛:  (val_1 > 64) ? 1 : 0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.notMaxLevel, 丏业丟一东丂东丘丛:  (val_1 < 65) ? 1 : 0);
    }
    public MaxLevelStateSwitch()
    {
        this.maxLevel_Key = "Key_11117";
        this.notMaxLevel_Key = "Key_11299";
    }

}
