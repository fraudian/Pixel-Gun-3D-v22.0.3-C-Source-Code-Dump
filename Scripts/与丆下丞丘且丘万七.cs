using UnityEngine;
private sealed class NetworkStartTableNGUIController.与丆下丞丘且丘万七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    private 丏与丌丐东七丈丑丕 丐丟丄丁丆丙丄一丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.与丆下丞丘且丘万七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_112;
        System.Func<System.Boolean> val_113;
        int val_114;
        丏与丌丐东七丈丑丕 val_115;
        var val_116;
        var val_117;
        int val_119;
        int val_120;
        int val_121;
        int val_122;
        int val_123;
        int val_124;
        int val_125;
        int val_126;
        Rilisoft.OfferItem val_127;
        val_112 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Func<System.Boolean> val_1 = null;
        val_113 = val_1;
        val_1 = new System.Func<System.Boolean>(object:  this.丝且与丝丒丟万丁专, method:  System.Boolean NetworkStartTableNGUIController::丁丅丕不丘丐丁丏丙());
        val_114 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_1);
        this.丗丏丅丕丆世丁专丟 = val_114;
        return (bool)val_114;
        label_1:
        val_115 = this.丐丟丄丁丆丙丄一丒;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_11;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_32;
        }
        
        label_33:
        label_32:
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丏丒丁丙世东丏丝();
        if((Rilisoft.VIPController.丌丏丄专丘丕丑上且() != false) && ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) != true))
        {
                if((0 == 0) && (this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.万万下东上丏且丅七() >= 1))
        {
                this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丌且且丒丝一丝丅一();
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = true;
        val_115 = val_112;
        this.丐丟丄丁丆丙丄一丒 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.GetEnumerator();
        丏与丌丐东七丈丑丕 val_10 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.GetEnumerator();
        label_29:
        if(val_10.MoveNext() == false)
        {
            goto label_26;
        }
        
        丁丙丆丑不三丌丗丟 val_13 = val_10.丒丒丆丙与且丅不丌().丌东业与丞丐丂丝专();
        goto label_29;
        label_11:
        var val_15 = (~GameConnect.世丐丄三三上丅七三()) & 1;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_32;
        }
        
        goto label_33;
        label_26:
        val_116 = 0;
        val_117 = 0;
        if(val_10 != null)
        {
                var val_112 = 0;
            val_112 = val_112 + 1;
            val_10.Dispose();
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丆上丐丄丗丆丟丝丝 = false;
        }
        
        UnityEngine.GameObject val_18 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().GetRewardFrameForType(丁丅丈丌丟世丗丗丟:  0);
        if(val_18 != 0)
        {
                if(val_18.activeInHierarchy != true)
        {
                if((this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().EnableRewardAnimationForType(丁丅丈丌丟世丗丗丟:  0)) == true)
        {
            goto label_56;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.CanShowNextReward();
        label_56:
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_119 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丝丈丑业不丝丑丏丟();
        }
        else
        {
                val_119 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丝丈丑业不丝丑丏丟();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.一丄丁丆丈丕专丌丌(丙业与丙丗丝不丈东:  val_119);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_120 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丈丙丂丝丞上丆一丅();
        }
        else
        {
                val_120 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丈丙丂丝丞上丆一丅();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.且三丞丈上丘丛一丄(丙业与丙丗丝不丈东:  val_120);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_121 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丘丒丄丞丘丂丄丅丅();
        }
        else
        {
                val_121 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丘丒丄丞丘丂丄丅丅();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.下丁一丐丞世专丑丛(丙业与丙丗丝不丈东:  val_121);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_122 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.不丝丟丄丏一丐专丒();
        }
        else
        {
                val_122 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.不丝丟丄丏一丐专丒();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专世丅不丑下丒东丒(丙业与丙丗丝不丈东:  val_122);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_123 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丕丘丗一下且丆不丒();
        }
        else
        {
                val_123 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丕丘丗一下且丆不丒();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丞丏丝七丈丒不丗丅(丙业与丙丗丝不丈东:  val_123);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_124 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丝丑丞下一丙丝不丌();
        }
        else
        {
                val_124 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丝丑丞下一丙丝不丌();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丄丁丗丄三万丁丌丞(丙业与丙丗丝不丈东:  val_124);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_125 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.业一丅丆一丝一丏丘();
        }
        else
        {
                val_125 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.业一丅丆一丝一丏丘();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.不丟丄丙丏三丝丅丞(丙业与丙丗丝不丈东:  val_125);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_126 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丗丛与丏丟丒丒不上();
        }
        else
        {
                val_126 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丗丛与丏丟丒丒不上();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丒下丗丑丑万下丈丝(丙业与丙丗丝不丈东:  val_126);
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒 != null)
        {
                val_127 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丗东丁世一丞与与专();
        }
        else
        {
                val_127 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丗东丁世一丞与与专();
        }
        
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.上丄丆丈丕七丄业丂(丙业与丙丗丝不丈东:  val_127);
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().StopCounting();
        RewardWindowView val_42 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七();
        val_42.countingDuration = 0.1f;
        label_5:
        val_113 = this.丐丟丄丁丆丙丄一丒;
        if(val_113.MoveNext() == false)
        {
            goto label_80;
        }
        
        丞丅与与丈丕丟丑丘 val_44 = this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_82;
        }
        
        this.丝且与丝丒丟万丁专.丘丘丆下丞丟与一与(丒丙业丕万丒丞万丂:  val_44);
        goto label_83;
        label_80:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_84;
        }
        
        this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = false;
        this.丝且与丝丒丟万丁专.丒一不丅丌业丁三丕();
        goto label_85;
        label_82:
        0.丘丘丆下丞丟与一与(丒丙业丕万丒丞万丂:  val_44);
        label_83:
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().RunCounting();
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.一丄丁丆丈丕专丌丌(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丒丆丄上丆丌且丅业() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专不三丙丅丞丄不丑());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.且三丞丈上丘丛一丄(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丄丂丞丂丗丌一丂丆() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丐丞丕丞丟下丑下丒());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丞丏丝七丈丒不丗丅(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().与七丒丟东业丑专一() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丐万丐丌丛上丘丞丂());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.下丁一丐丞世专丑丛(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丙丟丘下丏丗丗丟丘() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.且丞上丁万不专下专());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专世丅不丑下丒东丒(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().业下七七上丄丙专丐() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丝东丗丏丗丁丕丈丝());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丄丁丗丄三万丁丌丞(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().东世东丆丁丗七丏丒() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丅下丐丕丂丞丝丑丝());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.不丟丄丙丏三丝丅丞(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().不丐世丄不丏业丐丐() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丛与丆丏与丛丈世上());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丒下丗丑丑万下丈丝(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丘丁丈一与丟下丙丝() * this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丏下七丐且且丙万丕());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.一丄丁丆丈丕专丌丌(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丟丈东丒丆丘一丒丗() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专不三丙丅丞丄不丑());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.且三丞丈上丘丛一丄(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().专一且丈丁下与丙丗() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丐丞丕丞丟下丑下丒());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丞丏丝七丈丒不丗丅(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().且丈万丄丅东不业与() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丐万丐丌丛上丘丞丂());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.下丁一丐丞世专丑丛(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丏丑下丂不一三且丟() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.且丞上丁万不专下专());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专世丅不丑下丒东丒(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().丐丂丐丕丒丛七万丐() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丝东丗丏丗丁丕丈丝());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丄丁丗丄三万丁丌丞(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().七万三东东一丁世丘() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丅下丐丕丂丞丝丑丝());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.不丟丄丙丏三丝丅丞(丙业与丙丗丝不丈东:  this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().下丛业不上丒一丅丄() + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丛与丆丏与丛丈世上());
        val_117 = this.丐丟丄丁丆丙丄一丒.丒丒丆丙与且丅不丌().与丗世七三丝业丏丏();
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丒下丗丑丑万下丈丝(丙业与丙丗丝不丈东:  val_117 + this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丏下七丐且且丙万丕());
        System.Func<System.Boolean> val_110 = null;
        val_113 = val_110;
        val_110 = new System.Func<System.Boolean>(object:  this.丝且与丝丒丟万丁专, method:  System.Boolean NetworkStartTableNGUIController::丁业与丕三丙丄丞七());
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_110);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_114 = 1;
        return (bool)val_114;
        label_84:
        0.丒一不丅丌业丁三丕();
        label_85:
        val_112 = this.丝且与丝丒丟万丁专.OkWithAds;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_112, 丏业丟一东丂东丘丛:  false);
        label_3:
        val_114 = 0;
        return (bool)val_114;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
