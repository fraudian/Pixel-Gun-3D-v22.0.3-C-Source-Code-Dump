using UnityEngine;
internal class MiniBannerListContentUpdater : PGBehaviour
{
    // Fields
    internal UniversalMiniBannerListUI bannerListUI;
    private System.Collections.Generic.List<MiniBannerEntry> 七且不专丞上上丙丐;
    private int 丏且丆丙丐丛丑丐丝;
    private TagSystem.三与下丘七丘丌丏丄 丆丅丕丅一丆丂一丟;
    
    // Methods
    private void OnEnable()
    {
        this.丏且丆丙丐丛丑丐丝 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().世上丒丆丟三丒丑丒().下丌业业丐丘丐丘三(东丌丕上丞万丌丙丑:  this.丆丅丕丅一丆丂一丟, 丟且丒专下丈七丗丕:  2, 业丒丒专丞丒丘丌丗:  new System.Action<PGCompany.MainStore.丑东丁丏丘丏世丄丙>(object:  this, method:  System.Void MiniBannerListContentUpdater::七丅丗东世专且七七(PGCompany.MainStore.丑东丁丏丘丏世丄丙 专丒丌丆下丐丞丟丞)));
        this.世七丈丞下丂丄丗丑();
    }
    private void OnDisable()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().世上丒丆丟三丒丑丒().万不丒上丕丗丂丘丒(且与丆丑下丕七丑丗:  this.丏且丆丙丐丛丑丐丝);
    }
    private void 七丅丗东世专且七七(PGCompany.MainStore.丑东丁丏丘丏世丄丙 专丒丌丆下丐丞丟丞)
    {
        this.世七丈丞下丂丄丗丑();
    }
    private void 世七丈丞下丂丄丗丑()
    {
        TagSystem.三与下丘七丘丌丏丄 val_7;
        this.丑专专丈丂丆丌丆东();
        PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        val_7 = this.丆丅丕丅一丆丂一丟;
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丗不丞一且丟丈丈丗(七丄丆丘丒与丐丘丅: ref  val_3, 三不丟丈丐丟丏专丁:  val_7, 丁丏且丝丞丙万丗与:  2);
        List.Enumerator<T> val_4 = val_3.GetEnumerator();
        label_7:
        if((481800440 & 1) == 0)
        {
            goto label_6;
        }
        
        this.丂丒七丌与上万丆丁(且丘丏丁丑与丙与丁:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不()) != null)
        {
                return;
        }
    
    }
    private void 丂丒七丌与上万丆丁(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        UnityEngine.Object val_15;
        if(且丘丏丁丑与丙与丁 == null)
        {
                return;
        }
        
        if(且丘丏丁丑与丙与丁.下丒丗丄丌丘不丑丘() >= 1)
        {
                val_15 = 且丘丏丁丑与丙与丁.下丒丗丄丌丘不丑丘();
            if(PixelTime.丙三丝下丛丈丌丟下() >= (val_15 << ))
        {
                return;
        }
        
        }
        
        string val_4 = 且丘丏丁丑与丙与丁.丈丒丄万万丘丕世丐();
        val_15 = this.bannerListUI.poolGroup.Get<MiniBannerViewPromotion>(丛丄业丕且丗下一万:  val_4);
        if(val_15 == 0)
        {
                UnityEngine.Debug.LogError(message:  "Mini banner not exist! Path: "("Mini banner not exist! Path: ") + val_4);
            return;
        }
        
        不专丞丘世七丈丙丞 val_8 = new 不专丞丘世七丈丙丞();
        .丞丅上丏丂且下丅与 = System.String.Format(format:  "{0}_{1}", arg0:  且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙(), arg1:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与());
        .丏不万且丑丗丄一丕 = 且丘丏丁丑与丙与丁.下丒丗丄丌丘不丑丘();
        val_15.丈且东丑丂且万丒丅(丄一世丁上丅丘东丈:  val_8, 且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        MiniBannerEntry val_13 = new MiniBannerEntry();
        .data = val_8;
        .view = val_15;
        bool val_14 = this.bannerListUI.丂丒七丌与上万丆丁(三且丑东与丝丛丐丏:  val_13);
        this = this.七且不专丞上上丙丐;
        this.Add(item:  val_13);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_15, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丑专专丈丂丆丌丆东()
    {
        List.Enumerator<T> val_1 = this.七且不专丞上上丙丐.GetEnumerator();
        label_4:
        if((482183288 & 1) == 0)
        {
            goto label_2;
        }
        
        this.bannerListUI.丕东丅丒丏丐丘丌丙(三且丑东与丝丛丐丏:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.七且不专丞上上丙丐.Clear();
    }
    public MiniBannerListContentUpdater()
    {
        this.七且不专丞上上丙丐 = new System.Collections.Generic.List<MiniBannerEntry>();
        this.丆丅丕丅一丆丂一丟 = new TagSystem.三与下丘七丘丌丏丄(丆万一不丌且东丐丐:  "source.offers.tier-bundles");
    }

}
