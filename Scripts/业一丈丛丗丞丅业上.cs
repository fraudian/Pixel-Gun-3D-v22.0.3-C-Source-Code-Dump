using UnityEngine;
private sealed class ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上
{
    // Fields
    public ParticleAtraktor 丐丘业丂丙丞三不七;
    public string 丕一丛丂丛丏七上不;
    public PGCompany.ClanWarUIRewardsAnimator.丐丟三丐丈丙且且专 丕丅丏丁丅东且七丌;
    
    // Methods
    public ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上()
    {
    
    }
    internal void 上三丗丌丕丆丂不丛()
    {
        var val_20;
        this.丐丘业丂丙丞三不七.丏丏丝丅东专丏三丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarUIRewardsAnimator.业一丈丛丗丞丅业上::上三丗丌丕丆丂不丛()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.丐丘业丂丙丞三不七.transform.parent, 丏业丟一东丂东丘丛:  false);
        this.丕丅丏丁丅东且七丌.东丟且丗且三专丙丁.丝且与丝丒丟万丁专.且业丛三丛丛丛与万(丞丅上丏丂且下丅与:  this.丕一丛丂丛丏七上不, 丐丘业丂丙丞三不七:  this.丐丘业丂丙丞三不七);
        Rilisoft.OfferItemType val_4 = this.丕丅丏丁丅东且七丌.下丅丙一丂丗丅丝七.Type;
        if(val_4 == 1200)
        {
            goto label_11;
        }
        
        if((val_4 != 1220) || (ClanWarUI.丑七不且上丗丁一世().世丙世丄丗七下下世().丒丙世东丒业且且东().丏三世七东丒万丕丅() >= this.丕丅丏丁丅东且七丌.东丟且丗且三专丙丁.万丈丞上丌丏丞丗丐))
        {
            goto label_48;
        }
        
        ClanWarRatingUI val_11 = ClanWarUI.丑七不且上丗丁一世().世丙世丄丗七下下世().丒丙世东丒业且且东();
        val_11.一七与丁丏丄不世丄(丙业与丙丗丝不丈东:  this.丕丅丏丁丅东且七丌.下丅丙一丂丗丅丝七.Count + val_11.丏三世七东丒万丕丅());
        goto label_48;
        label_11:
        if((System.String.op_Equality(a:  this.丕丅丏丁丅东且七丌.下丅丙一丂丗丅丝七.Id, b:  "ClanSilver")) == false)
        {
            goto label_48;
        }
        
        List.Enumerator<T> val_18 = PGCompany.ItemCurrencyUI.丞万丟业丟与七丅上(丟丒上丄丏丄丝丁丙:  79).GetEnumerator();
        label_41:
        if(((-1891933040) & 1) == 0)
        {
            goto label_36;
        }
        
        string val_21 = val_20.丐丏七丌丕丗业且上();
        val_21.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丕丅丏丁丅东且七丌.下丅丙一丂丗丅丝七.Count + val_21.丂丁丏一丙丛业且丌());
        goto label_41;
        label_36:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_48:
        this.丕丅丏丁丅东且七丌.东丟且丗且三专丙丁.丝丅世万一丁七丄丝 = this.丕丅丏丁丅东且七丌.东丟且丗且三专丙丁.丝丅世万一丁七丄丝 + 1;
    }

}
