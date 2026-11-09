using UnityEngine;
internal sealed class PiggyProgressView : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _holder;
    private UISprite _oldProgressSprite;
    private UISprite _newProgressSprite;
    private UILabel _progressLabel;
    private UILabel _levelLabel;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(int 丘丕丐丁下世丙七丂)
    {
        UILabel val_28;
        var val_29;
        object val_30;
        string val_31;
        var val_32;
        var val_33;
        var val_34;
        if(PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丛下丆且丟丙与万丗() == null)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
        int val_4 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丈一下下丞世三丑丄();
        if(val_4 != PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丄且东且丕丛与丆丒())
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._oldProgressSprite, 丙业与丙丗丝不丈东:  1f);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8450"));
        val_28 = this._levelLabel;
        val_29 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431");
        val_30 = val_4;
        val_31 = val_29;
        goto label_12;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
        return;
        label_7:
        val_32 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().且丆丟业丞丕丑上且();
        int val_13 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().且丆丟业丞丕丑上且() + 丘丕丐丁下世丙七丂;
        val_33 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().上丄丈丛与丛丕丂丐();
        object val_16 = (val_13 > val_33) ? (val_4 + 1) : (val_4);
        int val_18 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丄且东且丕丛与丆丒();
        if(val_16 == val_18)
        {
                float val_27 = (float)val_32;
            val_27 = val_27 / (float)val_33;
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._oldProgressSprite, 丙业与丙丗丝不丈东:  val_27);
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._newProgressSprite, 丙业与丙丗丝不丈东:  1f);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8450"));
            return;
        }
        
        val_34 = val_13 - val_33;
        if(val_16 <= val_18)
        {
                val_34 = val_13;
        }
        else
        {
                val_33 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世().丅万丘且丁丁丈世且(丈丘丝一丗下丈丐不:  val_16 + 1);
            val_32 = 0;
        }
        
        float val_28 = 0f;
        float val_29 = (float)val_33;
        val_28 = val_28 / val_29;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._oldProgressSprite, 丙业与丙丗丝不丈东:  val_28);
        val_29 = (float)val_34 / val_29;
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._newProgressSprite, 丙业与丙丗丝不丈东:  val_29);
        float val_30 = 100f;
        val_30 = val_29 * val_30;
        val_29 = 1152921504622075904;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  UnityEngine.Mathf.Clamp(value:  (int)val_30, min:  0, max:  100)));
        val_28 = this._levelLabel;
        val_30 = val_16;
        val_31 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10431");
        label_12:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_28, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_31, arg0:  val_16));
    }
    public PiggyProgressView()
    {
    
    }

}
