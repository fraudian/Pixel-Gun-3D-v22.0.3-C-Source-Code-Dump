using UnityEngine;
public class VipRewardView : MonoBehaviour
{
    // Fields
    public ChangableBasicSprite[] spritesWorst;
    public ChangableBasicSprite[] spritesGood;
    public ChangableBasicSprite[] spritesBest;
    
    // Methods
    public void SetVipType(且丝丄万丟丗一丛下 三七且业丗丕丗丕丑)
    {
        var val_1;
        if(三七且业丗丕丗丕丑 == 0)
        {
            goto label_0;
        }
        
        if(三七且业丗丕丗丕丑 == 1)
        {
            goto label_1;
        }
        
        if(三七且业丗丕丗丕丑 != 2)
        {
                return;
        }
        
        val_1 = 0;
        goto label_3;
        label_8:
        this.spritesWorst[0].与专丟业下且丕不丈();
        val_1 = 1;
        label_3:
        if(val_1 < this.spritesWorst.Length)
        {
            goto label_8;
        }
        
        return;
        label_0:
        val_1 = 0;
        goto label_10;
        label_15:
        this.spritesBest[0].与专丟业下且丕不丈();
        val_1 = 1;
        label_10:
        if(val_1 < this.spritesBest.Length)
        {
            goto label_15;
        }
        
        return;
        label_1:
        val_1 = 0;
        goto label_17;
        label_22:
        this.spritesGood[0].与专丟业下且丕不丈();
        val_1 = 1;
        label_17:
        if(val_1 < this.spritesGood.Length)
        {
            goto label_22;
        }
    
    }
    private void 丙丘丌丕丑一丏万丑()
    {
        var val_3;
        this.spritesGood = new ChangableBasicSprite[0];
        val_3 = 0;
        this.spritesBest = new ChangableBasicSprite[0];
        goto label_3;
        label_21:
        ChangableBasicSprite val_3 = this.spritesWorst[0];
        if(this.spritesGood == null)
        {
            goto label_6;
        }
        
        if(val_3 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_3 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        this.spritesGood[0] = val_3;
        ChangableBasicSprite val_4 = this.spritesWorst[0];
        if(this.spritesBest == null)
        {
            goto label_14;
        }
        
        if(val_4 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_4 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        val_3 = 1;
        this.spritesBest[0] = val_4;
        label_3:
        if(val_3 < this.spritesWorst.Length)
        {
            goto label_21;
        }
    
    }
    private void 且丅丟丂三丆丏七丛()
    {
        this.SetVipType(三七且业丗丕丗丕丑:  1);
    }
    private void 丗丝丁丛丑丂丒丝丆()
    {
        this.SetVipType(三七且业丗丕丗丕丑:  0);
    }
    private void 专丌下丐上丗丕丄且()
    {
        this.SetVipType(三七且业丗丕丗丕丑:  2);
    }
    public VipRewardView()
    {
    
    }

}
