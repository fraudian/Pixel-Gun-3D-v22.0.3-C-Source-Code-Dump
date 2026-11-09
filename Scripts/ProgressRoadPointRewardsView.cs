using UnityEngine;
internal sealed class ProgressRoadPointRewardsView : PGBehaviour
{
    // Fields
    private ItemListUI rewrdsListUI;
    private System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 上丟丆上业一专且丁;
    private PGCompany.ItemCurrencyLayout currencyLayout;
    private RewardParticlesSource.Settings particleSettings;
    private float sendParticlesDelay;
    private bool showOnlyFirst;
    
    // Properties
    internal int 丙丞上丂丆丌丝丅一 { get; }
    
    // Methods
    internal int 三丙丆上丘专丟丝丑()
    {
        if(this.gameObject.activeSelf == false)
        {
                return 0;
        }
        
        System.Collections.Generic.List<PGCompany.InventoryItemView> val_3 = this.rewrdsListUI.丆业丈丐丞丄丙业丂();
        if(val_3 != null)
        {
                return val_3.Count;
        }
        
        return val_3.Count;
    }
    internal void 丈且东丑丂且万丒丅(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
    {
        System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> val_1 = new System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一>();
        val_1.Add(item:  东东丗丅与一下丄丈);
        this.丈且东丑丂且万丒丅(三丒不不一七东丕业:  val_1);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<ProgressRoad.丅丂丅丕下丑丘万一> 三丒不不一七东丕业)
    {
        var val_4;
        this.上丟丆上业一专且丁 = 三丒不不一七东丕业;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_2 = 三丒不不一七东丕业.GetEnumerator();
        label_5:
        if(((-185625792) & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.AddRange(collection:  val_4.丐丏七丌丕丗业且上());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.rewrdsListUI != 0)
        {
                if(this.showOnlyFirst != false)
        {
                this.rewrdsListUI.丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_1));
        }
        else
        {
                this.rewrdsListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_1);
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  (val_1.Count > 0) ? 1 : 0);
        if(this.currencyLayout == 0)
        {
                return;
        }
        
        一丛丟世丗丈丘丏万 val_13 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "LevelUp_RewardParticles", 丘丁三丅丆与丆业业:  this.sendParticlesDelay, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  public System.Void ProgressRoadPointRewardsView::SendParticles()));
    }
    public void SendParticles()
    {
        var val_5;
        var val_14;
        RewardParticlesReceiver val_15;
        val_14 = this;
        if(this.currencyLayout == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = this.rewrdsListUI.丆业丈丐丞丄丙业丂().GetEnumerator();
        label_21:
        if(((-185431872) & 1) == 0)
        {
            goto label_6;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(X21 == 0)
        {
            goto label_21;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_8 = val_6.ItemParams;
        if((this.currencyLayout.丝丗丟丛丕丐丂世与(丈丄不七三万丄丁不:  val_8)) != 0)
        {
                val_15 = val_9.rewardParticlesReceiver;
        }
        else
        {
                val_15 = 0;
        }
        
        if(val_15 == 0)
        {
            goto label_21;
        }
        
        val_8.三且世三丂七丐一丟(丈丄不七三万丄丁不:  val_6.ItemParams, 业丄丒丑一丙丛丆丕:  val_15, 与不丕丆丈不丙丟丛:  this.particleSettings);
        goto label_21;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ProgressRoadPointRewardsView()
    {
        this.sendParticlesDelay = 2f;
    }

}
