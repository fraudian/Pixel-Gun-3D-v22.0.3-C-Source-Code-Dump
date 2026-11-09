using UnityEngine;
internal class ClanRankScrollElementView : MonoBehaviour
{
    // Fields
    private UISprite rankSprite;
    private UITexture currentRankSelectorTexture;
    private UITexture prevRankSelectorTexture;
    private UILabel rankNameLabel;
    private UILabel rankExpCountLabel;
    private PGCompany.ProgressBarView rankProgressBarView;
    private UIButton singleRewardUIButton;
    private UITextureMasked rewardCurrencySingleSprite;
    private UILabel rewardCurrencySingleCountLabel;
    private UnityEngine.GameObject takenSingleState;
    private UnityEngine.GameObject readySingleState;
    private UnityEngine.GameObject lockedSingleState;
    private UIButton duoRewardUIButton;
    private UITextureMasked rewardCurrencySprite;
    private UILabel rewardCurrencyCountLabel;
    private UnityEngine.GameObject takenState;
    private UnityEngine.GameObject readyState;
    private UnityEngine.GameObject lockedState;
    private UITextureMasked rewardItemSprite;
    private UILabel rewardItemCountLabel;
    private UISprite rewardItemRaritySprite;
    private PGCompany.丟丁丅万与丏丙三下 丆万丄三且丒丝世丟;
    private UnityEngine.Transform 丝丐与丁与专丟业专;
    private bool 一丑世丏丏丕丙丘丈;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丟丁丅万与丏丙三下 专世专丟丝丌与丘上, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        int val_5;
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.rankSprite, 万丑丞一丝丌丐丒丘:  专世专丟丝丌与丘上.丟丗丛丌一丁世东丑());
        if(专世专丟丝丌与丘上.丕丘丁丈丛丗丄丟丌() > 0)
        {
                val_5 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  专世专丟丝丌与丘上.丕丘丁丈丛丗丄丟丌());
        }
        else
        {
                val_5 = System.String.alignConst;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rankExpCountLabel, 丕丗丘丑丛与丑业丒:  val_5);
        this.丆万丄三且丒丝世丟 = 专世专丟丝丌与丘上;
        this.丝丐与丁与专丟业专 = 丈东丘丏与丌东东下;
        this.丛七丝不一与与丙东();
        this.上与丟丗一上丛丌专();
    }
    internal void 上与丟丗一上丛丌专()
    {
        var val_49;
        string val_50;
        bool val_52;
        PGCompany.业丌万丅丄不丒丞三 val_54;
        PGCompany.丌丑丕丙丅丈丈丘丄 val_55;
        var val_56;
        int val_57;
        var val_58;
        UITextureMasked val_59;
        var val_60;
        UnityEngine.GameObject val_62;
        val_49 = this;
        val_50 = this.丆万丄三且丒丝世丟.一东丏七丄丒不丌丕();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rankNameLabel, 丕丗丘丑丛与丑业丒:  val_50);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.singleRewardUIButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.duoRewardUIButton, 丏业丟一东丂东丘丛:  false);
        if(this.丆万丄三且丒丝世丟.丙丄与世丁丛丞业不() == false)
        {
                return;
        }
        
        val_50 = 丌丅且丗七丘丅丛丑.丙与不不丕丁丅三万(专世专丟丝丌与丘上:  this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂());
        if(this.丆万丄三且丒丝世丟.丘丑丆丝丟丏丘丒丟() == false)
        {
            goto label_11;
        }
        
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下丞丝丂万丙三丏上(世且丐丐丑丛东专丟:  this.丆万丄三且丒丝世丟.丄与丘丑业专丞七丅.业东丅东丌上丗丑不())) < 1)
        {
            goto label_15;
        }
        
        val_52 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丛丈丏丅丂一不丒业(上七下丘一下三世丏:  this.丆万丄三且丒丝世丟.丄与丘丑业专丞七丅.丑丐丙丄丅世世丑丒()), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        goto label_21;
        label_11:
        val_52 = 0;
        goto label_21;
        label_15:
        val_52 = true;
        label_21:
        this.一丑世丏丏丕丙丘丈 = val_52;
        List.Enumerator<T> val_15 = val_50.GetEnumerator();
        val_54 = 0;
        val_55 = 0;
        goto label_28;
        label_29:
        string val_16 = 0.丐丏七丌丕丗业且上();
        if((PGCompany.万丞丘与丕丞下万丌.丞丒丟丒且丑丏且业(丁丅丈丌丟世丗丗丟:  val_16.不业丙丒丂丞下丆丙())) != false)
        {
                new PGCompany.丌丑丕丙丅丈丈丘丄() = new PGCompany.丌丑丕丙丅丈丈丘丄(丈丄不七三万丄丁不:  val_16);
            val_55 = new PGCompany.丌丑丕丙丅丈丈丘丄();
        }
        else
        {
                new PGCompany.业丌万丅丄不丒丞三() = new PGCompany.业丌万丅丄不丒丞三(丈丄不七三万丄丁不:  val_16);
            val_54 = new PGCompany.业丌万丅丄不丒丞三();
        }
        
        label_28:
        if((1955872160 & 1) != 0)
        {
            goto label_29;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_56 = 1152921505284374528;
        val_57 = val_50.Count;
        if(val_55 == 0)
        {
                val_55 = this.丆万丄三且丒丝世丟.不丛万丘下丝丄丑丐;
        }
        
        if( <= 0)
        {
                if(this.丆万丄三且丒丝世丟.上丈丙丙专丅上且东() != false)
        {
                if(this.一丑世丏丏丕丙丘丈 == false)
        {
            goto label_47;
        }
        
        }
        
        }
        
        if(val_50.Count >= 2)
        {
            goto label_47;
        }
        
        if(this.丆万丄三且丒丝世丟.上丈丙丙专丅上且东() != false)
        {
                if(this.丆万丄三且丒丝世丟.上丈丙丙专丅上且东() == false)
        {
                return;
        }
        
            if(this.一丑世丏丏丕丙丘丈 != true)
        {
                if(val_50.Count != 1)
        {
                return;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.singleRewardUIButton, 丏业丟一东丂东丘丛:  true);
        var val_26 = ( < 1) ? 1 : 0;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardCurrencySingleCountLabel, 丕丗丘丑丛与丑业丒:  val_55.丂丁丏一丙丛业且丌().ToString());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.takenSingleState, 丏业丟一东丂东丘丛:  ( > 0) ? 1 : 0);
        if( <= 0)
        {
            goto label_60;
        }
        
        val_55 = 1152921505149763584;
        val_58 = 0;
        goto label_61;
        label_47:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.duoRewardUIButton, 丏业丟一东丂东丘丛:  true);
        var val_30 = ( < 1) ? 1 : 0;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardCurrencyCountLabel, 丕丗丘丑丛与丑业丒:  val_55.丂丁丏一丙丛业且丌().ToString());
        if(val_54 != null)
        {
                val_59 = this.rewardItemSprite;
        }
        else
        {
                val_54 = this.丆万丄三且丒丝世丟.丄与丘丑业专丞七丅;
            val_59 = this.rewardItemSprite;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardItemCountLabel, 丕丗丘丑丛与丑业丒:  val_54.丂丁丏一丙丛业且丌().ToString());
        UnityEngine.Color val_36 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_54);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.rewardItemCountLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_36.r, g = val_36.g, b = val_36.b, a = val_36.a});
        UnityEngine.Color val_37 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_54);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.rewardItemRaritySprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_37.r, g = val_37.g, b = val_37.b, a = val_37.a});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.takenState, 丏业丟一东丂东丘丛:  ( > 0) ? 1 : 0);
        if( > 0)
        {
                val_55 = 1152921505149763584;
            val_60 = 0;
        }
        else
        {
                val_55 = 1152921505149763584;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.readyState, 丏业丟一东丂东丘丛:  (丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与() >= this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂()) ? 1 : 0);
        val_62 = this.lockedState;
        goto label_91;
        label_60:
        val_55 = 1152921505149763584;
        label_61:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.readySingleState, 丏业丟一东丂东丘丛:  (丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与() >= this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂()) ? 1 : 0);
        val_62 = this.lockedSingleState;
        label_91:
        val_50 = this.丆万丄三且丒丝世丟;
        val_49 = 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_62, 丏业丟一东丂东丘丛:  (val_49 < val_50.丙东专丂世丈丏丁丂()) ? 1 : 0);
    }
    internal void 丛七丝不一与与丙东()
    {
        PGCompany.ProgressBarView val_21;
        PGCompany.丟丁丅万与丏丙三下 val_22;
        var val_23;
        val_21 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.prevRankSelectorTexture, 丏业丟一东丂东丘丛:  (this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂() < 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.currentRankSelectorTexture, 丏业丟一东丂东丘丛:  (this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂() == 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()) ? 1 : 0);
        val_22 = this.丆万丄三且丒丝世丟;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rankProgressBarView, 丏业丟一东丂东丘丛:  (val_22.丙东专丂世丈丏丁丂() > 1) ? 1 : 0);
        if(this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂() < 2)
        {
                return;
        }
        
        if(this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂() <= 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与())
        {
            goto label_13;
        }
        
        if((this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂() - 丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()) != 1)
        {
            goto label_17;
        }
        
        val_22 = 丌丅且丗七丘丅丛丑.丛丏丒业丂丅丂丕丐() - (丌丅且丗七丘丅丛丑.丒不丐丁丕丝丟与丗(专世专丟丝丌与丘上:  丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与()));
        int val_19 = 丌丅且丗七丘丅丛丑.丙丆与丕万丁丘丁丒(专且丅丄且丘丟丅业:  丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与());
        val_21 = this.rankProgressBarView;
        if(val_21 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_13:
        val_21 = this.rankProgressBarView;
        if(val_21 != null)
        {
            goto label_23;
        }
        
        goto label_23;
        label_17:
        val_21 = this.rankProgressBarView;
        val_23;
        label_21:
        label_23:
        val_21.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  0f, 七丝东丛东丝且丆不:  1f, 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
    }
    public void U_RewardClicked()
    {
        if((丌丅且丗七丘丅丛丑.丙与不不丕丁丅三万(专世专丟丝丌与丘上:  this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂()).Count) == 0)
        {
                if(丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与() >= this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂())
        {
            goto label_9;
        }
        
        }
        
        this.与丈不丟丄三七丗上();
        return;
        label_9:
        this.丕丏丂一与万丟专丙();
    }
    private void 丕丏丂一与万丟专丙()
    {
        if((丌丅且丗七丘丅丛丑.丁万丝丛丅丁下一丅(专世专丟丝丌与丘上:  this.丆万丄三且丒丝世丟.丙东专丂世丈丏丁丂())) == false)
        {
                return;
        }
        
        if(this.丆万丄三且丒丝世丟.上丈丙丙专丅上且东() != false)
        {
                if(this.一丑世丏丏丕丙丘丈 == false)
        {
            goto label_7;
        }
        
        }
        
        if(this.丆万丄三且丒丝世丟.丙丄与世丁丛丞业不() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.takenSingleState, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.readySingleState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedSingleState, 丏业丟一东丂东丘丛:  false);
        if(this.singleRewardUIButton != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        this = ???;
        goto typeof(UIButton).__il2cppRuntimeField_178;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.takenState, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.readyState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedState, 丏业丟一东丂东丘丛:  false);
        if(this.duoRewardUIButton != null)
        {
            goto label_15;
        }
        
        goto label_16;
    }
    private void 与丈不丟丄三七丗上()
    {
        UnityEngine.Transform val_5;
        var val_6;
        PGCompany.丌丑丕丙丅丈丈丘丄 val_7;
        if(this.丆万丄三且丒丝世丟.上丈丙丙专丅上且东() != true)
        {
                if(this.丆万丄三且丒丝世丟.丘丑丆丝丟丏丘丒丟() == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.一丑世丏丏丕丙丘丈 != false)
        {
                label_4:
            if(this.丆万丄三且丒丝世丟.丕世丙专世丞丘丘丘() == false)
        {
                return;
        }
        
            val_5 = this.丝丐与丁与专丟业专;
            val_6 = 1152921505493692416;
            val_7 = this.丆万丄三且丒丝世丟.不丛万丘下丝丄丑丐;
        }
        else
        {
                val_5 = this.丝丐与丁与专丟业专;
            val_6 = 1152921505493692416;
            val_7 = this.丆万丄三且丒丝世丟.丄与丘丑业专丞七丅;
        }
        
        Rilisoft.ItemViewer val_4 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_5, 下丅丙一丂丗丅丝七:  val_7, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 丒不业且丄丅世世下:  false);
    }
    public ClanRankScrollElementView()
    {
    
    }

}
