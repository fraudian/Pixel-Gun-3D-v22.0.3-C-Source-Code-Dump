using UnityEngine;
internal sealed class BuffExtendPromotionBannerWindow : BannerWindow
{
    // Fields
    internal int 丝丙丙丅一丟且丌丙;
    private System.Collections.Generic.Dictionary<int, StorePromotionExtendUIAbstract> 下丕不丘丌丕丗丈丒;
    
    // Methods
    public override void Show()
    {
        object val_16;
        var val_17;
        UnityEngine.Object val_18;
        var val_19;
        var val_20;
        var val_21;
        val_16 = this;
        this.Show();
        val_17 = 1152921505570795520;
        int val_2 = PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().丑丂上丟丒丞丞丏丞();
        this.丝丙丙丅一丟且丌丙 = val_2;
        if((val_2 & 2147483648) != 0)
        {
            goto label_19;
        }
        
        val_17 = PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世();
        PGCompany.东丑丆丗丏丐丟下丄 val_4 = val_17.丐丆专七不万丆与丛(丞世不丒下上上丝丑:  this.丝丙丙丅一丟且丌丙);
        if((val_4 == null) || (val_4.丗丐世丅丕丞丗丂上() == null))
        {
            goto label_9;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_4.丗丐世丅丕丞丗丂上())) == true)
        {
            goto label_19;
        }
        
        if((this.下丕不丘丌丕丗丈丒.ContainsKey(key:  this.丝丙丙丅一丟且丌丙)) == false)
        {
            goto label_12;
        }
        
        val_18 = this.下丕不丘丌丕丗丈丒.Item[this.丝丙丙丅一丟且丌丙];
        goto label_14;
        label_9:
        UnityEngine.Debug.LogError(message:  "----- storePromotion?.Config.Settings == null");
        label_19:
        this.HideSelf();
        return;
        label_12:
        val_18 = this.丞丞丝丟丁丏丘上丞(丟丈一下东业一丝丆:  val_4.丗丐世丅丕丞丗丂上());
        if(val_18 == 0)
        {
            goto label_19;
        }
        
        this.下丕不丘丌丕丗丈丒.set_Item(key:  this.丝丙丙丅一丟且丌丙, value:  val_18);
        label_14:
        System.Action val_13 = new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf());
        if(val_18 == null)
        {
            goto label_22;
        }
        
        if(null == null)
        {
            goto label_23;
        }
        
        val_16 = 1152921505272180736;
        val_19 = null;
        val_19 = null;
        var val_14 = (((StorePromotionExtendUIAbstract.__il2cppRuntimeField_typeHierarchy + (StorePromotionExtendUIDefault.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_19) ? (val_18) : 0;
        goto label_27;
        label_22:
        label_27:
        0.丈且东丑丂且万丒丅();
        return;
        label_23:
        val_18.丈且东丑丂且万丒丅(丙且丄丑丂万丅丘丗:  3);
        val_20 = null;
        if(null != val_20)
        {
                val_21 = null;
        }
        else
        {
                val_21 = val_20;
        }
        
        (val_20 == val_21) ? (val_18) : 0.丞三业东丐丛丛丈丄();
    }
    private StorePromotionExtendUIAbstract 丞丞丝丟丁丏丘上丞(string 丟丈一下东业一丝丆)
    {
        string val_6;
        var val_7;
        val_6 = 丟丈一下东业一丝丆;
        StorePromotionExtendUIAbstract val_1 = UnityEngine.Resources.Load<StorePromotionExtendUIAbstract>(path:  val_6);
        if(val_1 == 0)
        {
                object[] val_3 = new object[1];
            val_3[0] = val_6;
            UnityEngine.Debug.LogErrorFormat(format:  "Not found prefab on path: {0}", args:  val_3);
            val_7 = 0;
            return (StorePromotionExtendUIAbstract)UnityEngine.Object.Instantiate<StorePromotionExtendUIAbstract>(original:  val_1, parent:  val_6 = this.transform);
        }
        
        return (StorePromotionExtendUIAbstract)UnityEngine.Object.Instantiate<StorePromotionExtendUIAbstract>(original:  val_1, parent:  val_6);
    }
    public override void Hide()
    {
        this.Hide();
        this.丝丙丙丅一丟且丌丙 = 0;
    }
    public BuffExtendPromotionBannerWindow()
    {
        this.丝丙丙丅一丟且丌丙 = 0;
        this.下丕不丘丌丕丗丈丒 = new System.Collections.Generic.Dictionary<System.Int32, StorePromotionExtendUIAbstract>();
    }

}
