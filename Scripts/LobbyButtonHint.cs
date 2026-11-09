using UnityEngine;
internal sealed class LobbyButtonHint : PGBehaviour
{
    // Fields
    private PGContentView pgContentView;
    private lockedOnProgressUI lockedUI;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(LobbyButton 一丑不丞丟丑东丗丛)
    {
        if(this.pgContentView != null)
        {
                this.pgContentView.丈且东丑丂且万丒丅(丕丈下丁丑丂丗丒业:  一丑不丞丟丑东丗丛.丘丑丄专丗丙丅丏下(), 丙丒七且世丂不丕丄:  "progress.road");
        }
        
        if((上丞丟上丌丟丁不丗.专且丝丞丂丕丒丐七(上且丁万丝世三丄丂:  一丑不丞丟丑东丗丛._buttonType)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedUI, 丏业丟一东丂东丘丛:  true);
            if(this.lockedUI == null)
        {
                return;
        }
        
            this.lockedUI.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  上丞丟上丌丟丁不丗.世丟专丟丝七丅丐不(上且丁万丝世三丄丂:  一丑不丞丟丑东丗丛._buttonType));
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedUI, 丏业丟一东丂东丘丛:  false);
    }
    public LobbyButtonHint()
    {
    
    }

}
