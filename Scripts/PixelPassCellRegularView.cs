using UnityEngine;
internal sealed class PixelPassCellRegularView : PixelPassCellBaseView
{
    // Fields
    private UILabel _levelLabel;
    private UIWidget _brogressBarWidget;
    private SimpleProgressBarWithAnimation _brogressBar;
    private PGCompany.InventoryItemView nextLevelPrice;
    private int firstBarLenght;
    private int normalBarLenght;
    private int edgeBarLenght;
    private UIWidget rewardWidget;
    private WidgetLayout countLayout;
    private int sizeCoolCollected;
    private int sizeCoolNotCollected;
    private int sizeNormalCollected;
    private int sizeNormalNotCollected;
    public UnityEngine.Transform rewardParticle;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丅丌丆丁世一丙丑丐)
    {
        int val_18;
        int val_19;
        var val_20;
        var val_22;
        var val_23;
        UnityEngine.MonoBehaviour val_24;
        this.丈且东丑丂且万丒丅(丅丌丆丁世一丙丑丐:  丅丌丆丁世一丙丑丐);
        val_18 = this.normalBarLenght;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._brogressBar.barFillPoint, 丏业丟一东丂东丘丛:  false);
        if(this._brogressBar != null)
        {
                val_19 = X23.丂丂下丑且下丌丝东();
            this._brogressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  val_19, 七丝东丛东丝且丆不:  X24.丗丏丆丂专东丆三丑(), 丈世万丙丟东与丕丞:  false);
        }
        
        if(丅丌丆丁世一丙丑丐.丘丗不丂世丘三三丙().一丞丛丂丗丁业丑丏() == 丅丌丆丁世一丙丑丐)
        {
            goto label_9;
        }
        
        val_20 = 1152921538558703984;
        goto label_10;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._brogressBar.barFillPoint, 丏业丟一东丂东丘丛:  true);
        val_20 = this;
        val_19 = val_19.丘丗不丂世丘三三丙().业丌丟且丒丅世丕丝();
        this.nextLevelPrice.Setup(丈丄不七三万丄丁不:  val_19);
        PGCompany.PixelPass.不万丄丛丁下业丟上 val_7 = this.nextLevelPrice.丁三丙丟世不丟丆丛();
        if(val_7 == (System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  val_7.丒东丒上世丘一丗丈())))
        {
            goto label_19;
        }
        
        if(this._brogressBar == null)
        {
            goto label_22;
        }
        
        val_22 = 50;
        goto label_21;
        label_19:
        if(this._brogressBar == null)
        {
            goto label_22;
        }
        
        val_22 = 75;
        label_21:
        this._brogressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  75, 七丝东丛东丝且丆不:  100, 丈世万丙丟东与丕丞:  false);
        label_10:
        label_22:
        if(1152921538558624592 == (System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  val_7.丁三丙丟世不丟丆丛().丒东丒上世丘一丗丈())))
        {
            goto label_25;
        }
        
        label_39:
        if(丅丌丆丁世一丙丑丐.丈一下下丞世三丑丄() == 1)
        {
                val_18 = this.firstBarLenght;
        }
        
        this._brogressBarWidget.width = val_18;
        this._brogressBarWidget.ResetAnchors();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._brogressBar, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  this._brogressBarWidget.丈一下下丞世三丑丄());
        if(this._levelLabel.丗丏丆丂专东丆三丑() <= 0)
        {
            goto label_34;
        }
        
        val_23 = 1;
        val_24 = this._brogressBar;
        goto label_37;
        label_25:
        if(丅丌丆丁世一丙丑丐 != null)
        {
            goto label_39;
        }
        
        goto label_39;
        label_34:
        val_24 = this._brogressBar;
        val_23 = 0;
        label_37:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_24, 丏业丟一东丂东丘丛:  false);
        this.丟丟下东东业一丒丐();
        UnityEngine.Coroutine val_17 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PixelPassCellRegularView::不业丆丕丟东三上丏()), 业丗七丕万万不丈丗:  2);
    }
    private void 丟丟下东东业一丒丐()
    {
        UnityEngine.Transform val_11;
        int val_15;
        if(万东下且丕东丄丕丐() == false)
        {
            goto label_3;
        }
        
        if((137117696 & 1) == 0)
        {
            goto label_4;
        }
        
        this.rewardWidget.height = this.sizeCoolCollected;
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardParticle)) == false)
        {
                return;
        }
        
        val_11 = this.rewardParticle;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        val_15 = this.sizeCoolCollected;
        goto label_26;
        label_3:
        if((137117696 & 1) == 0)
        {
            goto label_12;
        }
        
        this.rewardWidget.height = this.sizeNormalCollected;
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardParticle)) == false)
        {
                return;
        }
        
        val_11 = this.rewardParticle;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_15 = this.sizeNormalCollected;
        goto label_26;
        label_4:
        this.rewardWidget.height = this.sizeCoolNotCollected;
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardParticle)) == false)
        {
                return;
        }
        
        val_11 = this.rewardParticle;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_15 = this.sizeCoolNotCollected;
        goto label_26;
        label_12:
        this.rewardWidget.height = this.sizeNormalNotCollected;
        if((UnityEngine.Object.op_Implicit(exists:  this.rewardParticle)) == false)
        {
                return;
        }
        
        val_11 = this.rewardParticle;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_15 = this.sizeNormalNotCollected;
        label_26:
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  (float)val_15);
        val_11.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public PixelPassCellRegularView()
    {
        this.firstBarLenght = 300;
        this.normalBarLenght = 200;
        this.edgeBarLenght = 400;
        this.sizeCoolCollected = ;
        this.sizeCoolNotCollected = ;
        this.sizeNormalCollected = 429496729690;
        this.sizeNormalNotCollected = 100;
        mem[1152921538559108184] = 200;
        val_1 = new PGBehaviour();
    }
    private void 不业丆丕丟东三上丏()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.countLayout, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.countLayout, 丏业丟一东丂东丘丛:  true);
    }

}
