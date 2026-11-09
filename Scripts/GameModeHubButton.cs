using UnityEngine;
internal sealed class GameModeHubButton : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject tapRewardHolder;
    private PGCompany.InventoryItemView tapRewardView;
    
    // Methods
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        var val_5;
        PGCompany.InventoryItemView val_13;
        string val_14;
        UnityEngine.GameObject val_15;
        val_13 = this;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tapRewardHolder, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_3 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丈世世三万丝一丕一().GetEnumerator();
        label_11:
        if((75367232 & 1) == 0)
        {
            goto label_14;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        PGCompany.GameModeHub.丘专丕丂且丅业三丁 val_8 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丝丟不丄丅且专丄丈();
        if(val_6 == null)
        {
            goto label_7;
        }
        
        if(val_8 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_7:
        val_14 = 0;
        if(val_8 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if((val_8.不专上一丌丅世丅丈(七丆丒与丗丌丄且丂:  val_14)) == false)
        {
            goto label_11;
        }
        
        val_15 = this.tapRewardHolder;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  true);
        val_13 = this.tapRewardView;
        if(val_13 != null)
        {
                val_15 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丝丟不丄丅且专丄丈();
            val_13.Setup(丈丄不七三万丄丁不:  val_15.一且丞丈下丑东专丑(七丆丒与丗丌丄且丂:  val_6));
        }
        
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public GameModeHubButton()
    {
    
    }

}
