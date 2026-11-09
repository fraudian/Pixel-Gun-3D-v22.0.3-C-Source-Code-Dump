using UnityEngine;
private sealed class AIBotController.丁业丂丌丈丞丏丑丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBot.AIBotController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 万下一丈丄丌三且丙;
    private float 一丈丞丕丒且丅丅丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AIBotController.丁业丂丌丈丞丏丑丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_31;
        var val_35;
        var val_36;
        UnityEngine.WaitForSeconds val_37;
        var val_38;
        float val_39;
        UnityEngine.WaitForSeconds val_40;
        int val_41;
        PlayerBotController val_42;
        var val_44;
        PlayerBotController val_46;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        val_35 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.与丈业且丞东不丅丛 = false;
        goto label_3;
        label_1:
        val_36 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_36;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_5;
        }
        
        UnityEngine.WaitForSeconds val_2 = null;
        val_37 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.shootcCycleTiime);
        this.万下一丈丄丌三且丙 = val_37;
        this.一丈丞丕丒且丅丅丄 = 0f;
        goto label_6;
        label_2:
        val_35 = 148;
        mem[148] = 0;
        label_3:
        if(((this.丝且与丝丒丟万丁专.业业丏与丄丛丐丗丂() == false) || (this.丝且与丝丒丟万丁专.丕丞丑丕一不下丞丙 > 0f)) || (this.丝且与丝丒丟万丁专.useTestBehavior == true))
        {
            goto label_97;
        }
        
        if(this.丝且与丝丒丟万丁专.currentBehaviorType == 2)
        {
            goto label_11;
        }
        
        if(this.丝且与丝丒丟万丁专.currentBehaviorType != 3)
        {
            goto label_38;
        }
        
        val_37 = this.丝且与丝丒丟万丁专._targetDetector.与丝丁丑丁丌丞丞东;
        val_38 = 0;
        goto label_18;
        label_5:
        UnityEngine.WaitForSeconds val_4 = null;
        val_37 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  1.651491E-34f);
        this.万下一丈丄丌三且丙 = val_37;
        this.一丈丞丕丒且丅丅丄 = 0f;
        label_6:
        val_39 = this.丝且与丝丒丟万丁专.丛丙东丕丙丙丐丞丙;
        UnityEngine.WaitForSeconds val_5 = null;
        val_40 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  val_39);
        val_41 = 1;
        goto label_19;
        label_11:
        三丐七丞专丑一丟世 val_6 = this.丝且与丝丒丟万丁专.playerBotController.player.丐丌丘丑丄丂万丟丑();
        val_42 = this.丝且与丝丒丟万丁专.playerBotController;
        val_37 = this.丝且与丝丒丟万丁专.playerBotController.player.丐丌丘丑丄丂万丟丑();
        if(val_6.丅丕丟丙七下丘丏丁 > (((val_7.专丆丛世丂丗丞一与 < 0) ? (val_7.专丆丛世丂丗丞一与 + 1) : val_7.专丆丛世丂丗丞一与) >> 1))
        {
            goto label_38;
        }
        
        val_37 = this.丝且与丝丒丟万丁专.playerBotController.player;
        val_37.丆丁世一且丒丒世世();
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_44;
        }
        
        goto label_42;
        label_18:
        if( == 0)
        {
            goto label_38;
        }
        
        val_37 = this.丝且与丝丒丟万丁专._targetDetector.与丝丁丑丁丌丞丞东;
        var val_36 = 0;
        val_36 = val_36 + 1;
        if(val_37.BotTargetIsDead == true)
        {
            goto label_38;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_39;
        }
        
        val_37 = this.丝且与丝丒丟万丁专;
        if(this.丝且与丝丒丟万丁专.丒丅丏丁丆丆丟丑丁 == false)
        {
            goto label_40;
        }
        
        label_43:
        mem2[0] = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_44;
        }
        
        goto label_42;
        label_39:
        val_37 = 149;
        val_42 = 0;
        if(val_42 != 0)
        {
            goto label_43;
        }
        
        label_40:
        mem[148] = 1;
        label_38:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_44;
        }
        
        label_42:
        label_44:
        if(this.丝且与丝丒丟万丁专.万丁丕丄丈丆丕不东 == true)
        {
            goto label_97;
        }
        
        val_37 = this.丝且与丝丒丟万丁专._targetDetector.与丝丁丑丁丌丞丞东;
        val_44 = 0;
        if(( == 0) || (this.丝且与丝丒丟万丁专.世丙丕与东一丗万丟() == false))
        {
            goto label_65;
        }
        
        UnityEngine.Vector3 val_17 = this.丝且与丝丒丟万丁专.transform.position;
        var val_37 = 0;
        val_37 = val_37 + 1;
        val_37 = this.丝且与丝丒丟万丁专._targetDetector.与丝丁丑丁丌丞丞东.BotTargetTransform;
        UnityEngine.Vector3 val_20 = val_37.position;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        val_39 = val_21.x;
        if(val_39 >= 0)
        {
            goto label_65;
        }
        
        if(this.丝且与丝丒丟万丁专.上丛世丟丐上丌东东() == true)
        {
            goto label_97;
        }
        
        val_37 = this.丝且与丝丒丟万丁专.playerBotController.player.丁丛丏业东丗丘丕丛(七丆丒与丗丌丄且丂:  2);
        if((val_37 == null) || (this.丝且与丝丒丟万丁专.playerBotController.丗丈东丕不丘三丞业.丅下万丏丘东丄丌万 == true))
        {
            goto label_97;
        }
        
        this.丝且与丝丒丟万丁专.playerBotController.player.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  val_37);
        this.一丈丞丕丒且丅丅丄 = this.丝且与丝丒丟万丁专.timerForChangeWeaponFromMelee;
        goto label_97;
        label_65:
        if(this.丝且与丝丒丟万丁专.上丛世丟丐上丌东东() == false)
        {
            goto label_97;
        }
        
        float val_38 = this.一丈丞丕丒且丅丅丄;
        if(val_38 <= 0f)
        {
            goto label_77;
        }
        
        val_38 = val_38 - this.丝且与丝丒丟万丁专.shootcCycleTiime;
        this.一丈丞丕丒且丅丅丄 = val_38;
        goto label_97;
        label_77:
        this.一丈丞丕丒且丅丅丄 = 0f;
        if(this.丝且与丝丒丟万丁专.playerBotController.player.且丒世一丏丈丘丌专() != null)
        {
                if(this.丝且与丝丒丟万丁专.playerBotController.player.且丒世一丏丈丘丌专().丌上丗丕不七世丅丁().丐专丒丟丈丛丈丂业() == false)
        {
            goto label_104;
        }
        
        }
        
        val_37 = this.丝且与丝丒丟万丁专.playerBotController.player.equippedWeapons;
        List.Enumerator<T> val_29 = val_37.GetEnumerator();
        val_42 = 1152921538663869616;
        label_93:
        if((1823321264 & 1) == 0)
        {
            goto label_90;
        }
        
        val_37 = val_31.丐丏七丌丕丗业且上();
        if(val_37.丌上丗丕不七世丅丁().丐专丒丟丈丛丈丂业() == true)
        {
            goto label_93;
        }
        
        this.丝且与丝丒丟万丁专.playerBotController.player.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  val_37);
        label_90:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_97;
        label_104:
        val_46 = this.丝且与丝丒丟万丁专.playerBotController;
        if(this.丝且与丝丒丟万丁专.playerBotController != null)
        {
            goto label_106;
        }
        
        val_46 = this.丝且与丝丒丟万丁专.playerBotController;
        if(val_46 == null)
        {
            goto label_107;
        }
        
        label_106:
        val_37 = this.丝且与丝丒丟万丁专.playerBotController.player.且丒世一丏丈丘丌专();
        this.丝且与丝丒丟万丁专.playerBotController.player.丙一世丞丏丌丑丟丘(丌丝下丄业一丄不三:  val_37);
        label_97:
        val_40 = this.万下一丈丄丌三且丙;
        val_41 = 2;
        label_19:
        val_36 = 1;
        this.丒上七丌业七丟与丐 = val_40;
        this.丗丏丅丕丆世丁专丟 = val_41;
        return (bool)val_36;
        label_107:
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
