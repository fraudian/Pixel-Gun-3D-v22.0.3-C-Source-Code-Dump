using UnityEngine;
internal sealed class CW_TributeProgressUI : PGBehaviour
{
    // Fields
    private 不上丌世万丁丝丏丆 丐丌丞东上万万丈丂;
    private UILabel rewardCountLabel;
    private UILabel tributeTimer;
    private UnityEngine.GameObject canCollectTrubute;
    private UILabel hoblinTributeTimer;
    private UnityEngine.GameObject hoblinCollectingState;
    private UnityEngine.GameObject trubuteNotAvailable;
    private UnityEngine.Coroutine 丕丆上下丕与东丈业;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        UILabel val_11;
        string val_12;
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        if(丌丝万上丅丒一丈丘.丑丗丗一三上万丈丑() != null)
        {
                if(丌丝万上丅丒一丈丘.丑丗丗一三上万丈丑().Count >= 2)
        {
            goto label_5;
        }
        
        }
        
        val_11 = this.rewardCountLabel;
        val_12 = "";
        goto label_8;
        label_5:
        val_11 = this.rewardCountLabel;
        val_12 = 丌丝万上丅丒一丈丘.丑丗丗一三上万丈丑().Item[1].Count.ToString();
        label_8:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_11, 丕丗丘丑丛与丑业丒:  val_12);
        if(this.tributeTimer == 0)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.且丒不丙丌丅丑丂丄();
    }
    private void OnEnable()
    {
        if(this.tributeTimer == 0)
        {
                return;
        }
        
        this.且丒不丙丌丅丑丂丄();
    }
    private void OnDisable()
    {
        if(this.丕丆上下丕与东丈业 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
        this.丕丆上下丕与东丈业 = 0;
    }
    private void 且丒不丙丌丅丑丂丄()
    {
        if(this.丕丆上下丕与东丈业 != null)
        {
                this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
            this.丕丆上下丕与东丈业 = 0;
        }
        
        this.丕丆上下丕与东丈业 = this.StartCoroutine(routine:  this.与东丆丟丞丈一丕上());
    }
    private void 一丛丄七一且东三七()
    {
        if(this.丕丆上下丕与东丈业 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
        this.丕丆上下丕与东丈业 = 0;
    }
    private System.Collections.IEnumerator 与东丆丟丞丈一丕上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CW_TributeProgressUI.一丒且丅七专丒丅丈();
    }
    private void 丝丂丕东专世丅丝丁()
    {
        var val_15;
        UnityEngine.GameObject val_16;
        UILabel val_17;
        ulong val_18;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tributeTimer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.canCollectTrubute, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.hoblinTributeTimer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hoblinCollectingState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.trubuteNotAvailable, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝丌丄丘丞东丕世且(且下丕七丙丗丄不七:  1)) == false)
        {
            goto label_4;
        }
        
        val_15 = null;
        val_16 = this.trubuteNotAvailable;
        goto label_16;
        label_4:
        bool val_5 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专世东丌丑丐与与业();
        if(一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与() < 1)
        {
            goto label_10;
        }
        
        if(val_5 == false)
        {
            goto label_11;
        }
        
        val_15 = null;
        val_16 = this.hoblinCollectingState;
        goto label_16;
        label_10:
        if(val_5 == false)
        {
            goto label_14;
        }
        
        val_15 = null;
        val_16 = this.canCollectTrubute;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_16, 丏业丟一东丂东丘丛:  true);
        return;
        label_11:
        System.Nullable<System.DateTime> val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世专世丒一下丟世丟();
        System.Nullable<System.DateTime> val_8 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-2123557568) & 1) == 0)
        {
                return;
        }
        
        if(((-2123557584) & 1) == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.hoblinTributeTimer, 丏业丟一东丂东丘丛:  true);
        val_17 = this.hoblinTributeTimer;
        val_18;
        goto label_24;
        label_14:
        System.Nullable<System.DateTime> val_10 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世专世丒一下丟世丟();
        System.Nullable<System.DateTime> val_11 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-2123557608) & 1) == 0)
        {
                return;
        }
        
        if(((-2123557624) & 1) == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tributeTimer, 丏业丟一东丂东丘丛:  true);
        val_17 = this.tributeTimer;
        val_18;
        label_24:
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_18}, d2:  new System.DateTime() {});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_17, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)val_12._ticks.TotalSeconds, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
    }
    public CW_TributeProgressUI()
    {
    
    }

}
