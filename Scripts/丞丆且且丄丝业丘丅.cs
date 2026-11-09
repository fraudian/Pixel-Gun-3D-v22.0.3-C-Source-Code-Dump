using UnityEngine;
private sealed class BattlePassConnectScene.丞丆且且丄丝业丘丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.BattlePass.BattlePassConnectScene 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 业丅万业东丗下专丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassConnectScene.丞丆且且丄丝业丘丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.BattlePass.BattlePassConnectScene val_30;
        UnityEngine.GameObject val_31;
        int val_32;
        Rilisoft.丝丑丂丛万丐丈丘且 val_33;
        val_30 = this.丝且与丝丒丟万丁专;
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
            goto label_51;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_31 = Rilisoft.Singleton<BattlePassController>.Instance.专丁丟丏丁丏不丗三();
        if(val_30 == null)
        {
            goto label_5;
        }
        
        if(val_31 == false)
        {
            goto label_6;
        }
        
        label_42:
        val_31 = this.丝且与丝丒丟万丁专._beforeLevel3Obj;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  false);
        if((this.丝且与丝丒丟万丁专.丆世且上丂丙丂丛丆 == 0) || (val_30.丄丄丆东丑三丝专丂() == null))
        {
            goto label_10;
        }
        
        val_31 = val_30.丄丄丆东丑三丝专丂();
        if(val_31.Count != 0)
        {
            goto label_12;
        }
        
        label_10:
        val_30.丙丁万与一丒三下丞(丙业与丙丗丝不丈东:  PGCompany.BattlePass.BattlePassConnectScene.与业下丏丂上三丗丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 不丌丒丆丞下丙专万:  (this.丝且与丝丒丟万丁专.丆世且上丂丙丂丛丆 == 0) ? 1 : 0));
        label_12:
        this.业丅万业东丗下专丙 = 0;
        goto label_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_31 = PGCompany.BattlePass.BattlePassConnectScene.与业下丏丂上三丗丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 不丌丒丆丞下丙专万:  (this.丝且与丝丒丟万丁专.丆世且上丂丙丂丛丆 == 0) ? 1 : 0);
        val_30.丙丁万与一丒三下丞(丙业与丙丗丝不丈东:  val_31);
        label_16:
        if(FriendsController.丝丗专上三不丄丑丑() < 1)
        {
            goto label_25;
        }
        
        val_31 = Rilisoft.Singleton<BattlePassController>.Instance;
        if(val_31.丛东丛丕东丟丂丈丝() == null)
        {
            goto label_25;
        }
        
        if(val_30.丄丄丆东丑三丝专丂() == null)
        {
            goto label_27;
        }
        
        val_31 = val_30.丄丄丆东丑三丝专丂();
        if(val_31.Count != 0)
        {
            goto label_30;
        }
        
        label_27:
        val_31 = PGCompany.BattlePass.BattlePassConnectScene.与业下丏丂上三丗丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 不丌丒丆丞下丙专万:  (this.丝且与丝丒丟万丁专.丆世且上丂丙丂丛丆 == 0) ? 1 : 0);
        val_30.丙丁万与一丒三下丞(丙业与丙丗丝不丈东:  val_31);
        label_30:
        val_30.丕丕业七丙七丅丈丄();
        val_30 = this.业丅万业东丗下专丙;
        if(val_30 == null)
        {
                UnityEngine.WaitForSeconds val_21 = null;
            val_30 = val_21;
            val_21 = new UnityEngine.WaitForSeconds(seconds:  5f);
            this.业丅万业东丗下专丙 = val_30;
        }
        
        val_32 = 1;
        this.丒上七丌业七丟与丐 = val_30;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_32;
        label_25:
        val_30 = this.丝且与丝丒丟万丁专._body;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30, 丏业丟一东丂东丘丛:  false);
        val_32 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_32;
        return (bool)val_32;
        label_5:
        if(val_31 == true)
        {
            goto label_42;
        }
        
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._tutorialObj, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._challengeBody, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buyPremBody, 丏业丟一东丂东丘丛:  false);
        PGCompany.BattlePass.上丕丁专三丗丝万丆 val_23 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
        if(val_23 == null)
        {
                return (bool)val_32;
        }
        
        if((val_23.丗丄上丑丑丅丐丒丌() != true) && (val_23.丌丈一丘上丕丏东丛() != true))
        {
                if(val_23.丐丟东专丒丈一丅丕() == null)
        {
                return (bool)val_32;
        }
        
            if((val_26.Progress != 2147483647) && (this.丝且与丝丒丟万丁专.丆世且上丂丙丂丛丆 == 0))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._beforeLevel3Obj, 丏业丟一东丂东丘丛:  true);
            val_31 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11219");
            if(val_23.丐丟东专丒丈一丅丕() != null)
        {
                val_33 = val_28.Progress;
        }
        
            val_30 = System.String.Format(format:  val_31, arg0:  val_33);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专._bpLevelRequiredLabel, 丕丗丘丑丛与丑业丒:  val_30);
        }
        
        }
        
        label_51:
        val_32 = 0;
        return (bool)val_32;
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
