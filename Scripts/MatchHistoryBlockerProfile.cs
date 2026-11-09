using UnityEngine;
internal sealed class MatchHistoryBlockerProfile : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject[] _enableIfBlocked;
    private UnityEngine.GameObject[] _disableIfBlocked;
    private UILabel _matchHistoryLockerLabel;
    
    // Methods
    private void OnEnable()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if(ExperienceController.丞丞丘业东丙丏七丌() > BalanceController.业丌丁丞丆丆万业丘)
        {
                val_9 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
        }
        else
        {
                val_9 = 1;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._enableIfBlocked, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._disableIfBlocked, 丏业丟一东丂东丘丛:  (val_9 == 0) ? 1 : 0);
        val_10 = null;
        val_10 = null;
        int val_7 = BalanceController.业丌丁丞丆丆万业丘;
        val_7 = val_7 + 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._matchHistoryLockerLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9683"), arg0:  val_7));
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._matchHistoryLockerLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._disableIfBlocked, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._matchHistoryLockerLabel, 丏业丟一东丂东丘丛:  true);
    }
    public MatchHistoryBlockerProfile()
    {
    
    }

}
