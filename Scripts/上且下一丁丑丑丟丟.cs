using UnityEngine;
public class 上且下一丁丑丑丟丟
{
    // Fields
    private static Rilisoft.七丞丞丅东丞专丙丝<上且下一丁丑丑丟丟> 丝业丆丁业三丈丟东;
    private System.Collections.Generic.Dictionary<int, 上且下一丁丑丑丟丟.AILevelSettings> 丟丘丑不丄丙且丘万;
    private System.Collections.Generic.Dictionary<int, 上且下一丁丑丑丟丟.AILevelSettings> 丕丐丞业不一丒万丕;
    
    // Properties
    internal static 上且下一丁丑丑丟丟 丆丕丝丒不丙且丐丗 { get; }
    private System.Collections.Generic.Dictionary<int, 上且下一丁丑丑丟丟.AILevelSettings> 下丑丙三丏专丒丂丆 { get; }
    
    // Methods
    internal static 上且下一丁丑丑丟丟 丑七不且上丗丁一世()
    {
        null = null;
        if(上且下一丁丑丑丟丟.丝业丆丁业三丈丟东 != null)
        {
                return 上且下一丁丑丑丟丟.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        
        return 上且下一丁丑丑丟丟.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
    }
    private System.Collections.Generic.Dictionary<int, 上且下一丁丑丑丟丟.AILevelSettings> 丛丒丌丅一丏丝丗丂()
    {
        return (System.Collections.Generic.Dictionary<System.Int32, AILevelSettings>)(GameConnect.丛上丆一丂业丕丈丐() != true) ? this.丕丐丞业不一丒万丕 : this.丟丘丑不丄丙且丘万;
    }
    internal void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
    {
        if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 52)
        {
                if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 114)
        {
                return;
        }
        
        }
        
        this.丘上丐世丆丑且丞丒();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_11;
        var val_12;
        val_11 = 0;
        this.丟丘丑不丄丙且丘万 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  52)).丟丈上丛丙丕业丁丐(丆丟丞丅丘丛七丛丙:  null);
        object val_8 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  86));
        val_12 = 0;
        this.丕丐丞业不一丒万丕 = 0.Item["AI"].丟丈上丛丙丕业丁丐(丆丟丞丅丘丛七丛丙:  null);
    }
    private System.Collections.Generic.Dictionary<int, 上且下一丁丑丑丟丟.AILevelSettings> 丟丈上丛丙丕业丁丐(System.Collections.Generic.Dictionary<string, object> 丆丟丞丅丘丛七丛丙)
    {
        var val_114;
        var val_115;
        var val_116;
        var val_117;
        int val_118;
        var val_119;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_116 = 丆丟丞丅丘丛七丛丙;
        int val_48 = 0;
        if(val_116 != null)
        {
                System.Collections.Generic.Dictionary<System.Int32, AILevelSettings> val_1 = null;
            val_114 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.Int32, AILevelSettings>();
            object val_2 = val_116.Item["weapons"];
            val_115 = 0;
        }
        else
        {
                val_114 = 0;
            return (System.Collections.Generic.Dictionary<System.Int32, AILevelSettings>)val_114;
        }
        
        object val_42 = val_116.Item["throwGrenade"];
        val_116 = 0;
        val_117 = 0;
        goto label_66;
        label_150:
        val_1.Add(key:  0, value:  new 上且下一丁丑丑丟丟.AILevelSettings());
        System.Collections.Generic.List<System.String> val_44 = new System.Collections.Generic.List<System.String>();
        char[] val_46 = new char[2];
        val_118 = val_46.Length;
        if(val_118 == 0)
        {
                val_118 = val_46.Length;
        }
        
        val_46[0] = ',';
        val_46[0] = 32;
        val_119 = 0;
        goto label_74;
        label_84:
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  Item[0].Split(separator:  val_46)[0], 丙业与丙丗丝不丈东: out  val_48)) != false)
        {
                if((丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  (val_48 * 1000) | 1)) != null)
        {
                val_44.Add(item:  System.String.Format(format:  "Weapon{0}", arg0:  0));
        }
        
        }
        
        val_119 = 1;
        label_74:
        if(val_119 < val_47.Length)
        {
            goto label_84;
        }
        
        AILevelSettings val_54 = val_1.Item[0];
        val_115 = ;
        val_54.weapons = val_44;
        AILevelSettings val_55 = val_1.Item[0];
        val_55.minRandomValueForAim = System.Convert.ToSingle(value:  Item[0]);
        AILevelSettings val_58 = val_1.Item[0];
        val_58.maxRandomValueForAim = System.Convert.ToSingle(value:  Item[0]);
        AILevelSettings val_61 = val_1.Item[0];
        val_61.attackRange = System.Convert.ToSingle(value:  Item[0]);
        AILevelSettings val_64 = val_1.Item[0];
        val_64.rotationSpeedMinSkirmish = System.Convert.ToSingle(value:  Item[0]);
        AILevelSettings val_67 = val_1.Item[0];
        val_67.rotationSpeedMaxSkirmish = System.Convert.ToSingle(value:  Item[0]);
        AILevelSettings val_70 = val_1.Item[0];
        val_70.dodge = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_73 = val_1.Item[0];
        val_73.dodgeWithMelee = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_76 = val_1.Item[0];
        val_76.jumpOnDodje = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_79 = val_1.Item[0];
        val_79.jumpOnDodjeWithMelee = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_82 = val_1.Item[0];
        val_82.straightDodje = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_85 = val_1.Item[0];
        val_85.switchOnTarget = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_88 = val_1.Item[0];
        val_88.switchOnTargetWhenHaveTarget = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_91 = val_1.Item[0];
        val_91.takeMeleeWeapon = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_94 = val_1.Item[0];
        val_94.goForBonus = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_97 = val_1.Item[0];
        val_97.rotateWhenStand = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_100 = val_1.Item[0];
        val_100.choosePlayerAsTarget = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_103 = val_1.Item[0];
        val_103.doDamageOnShoot = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_106 = val_1.Item[0];
        val_106.changeWeaponOnReload = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_109 = val_1.Item[0];
        val_109.pauseOnShoot = System.Convert.ToInt32(value:  Item[0]);
        AILevelSettings val_112 = val_1.Item[0];
        val_117 = 1;
        val_112.throwGrenade = System.Convert.ToInt32(value:  Item[0]);
        label_66:
        if(val_117 < val_115.Count)
        {
            goto label_150;
        }
        
        return (System.Collections.Generic.Dictionary<System.Int32, AILevelSettings>)val_114;
    }
    internal bool 与上不丈丑丒丐上丛(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.dodge) ? 1 : 0;
    }
    internal bool 三丒丟丑三万丗专丛(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.dodgeWithMelee) ? 1 : 0;
    }
    internal bool 三丅丈丆丐丏丑丙丏(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.straightDodje) ? 1 : 0;
    }
    internal float 丘丟丁不下丛不丅丑(int 丑万世丂专丈丌业且)
    {
        return (float)(float)UnityEngine.Random.Range(min:  2, max:  7);
    }
    internal bool 七丘丁丅丞万丟丟东(bool 丑丗丘七丘丞丁业丕, int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= ((丑丗丘七丘丞丁业丕 != true) ? val_3.switchOnTargetWhenHaveTarget : val_3.switchOnTarget)) ? 1 : 0;
    }
    internal bool 丟丂丝一丁上业与丄(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.takeMeleeWeapon) ? 1 : 0;
    }
    internal bool 专东丄东丕下东丐一(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.goForBonus) ? 1 : 0;
    }
    internal bool 丄丌不丘丟业丐丕丟(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.rotateWhenStand) ? 1 : 0;
    }
    internal bool 七丘丌三丙丝丂丆三(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.choosePlayerAsTarget) ? 1 : 0;
    }
    internal bool 与丂三业丂上丐且丑(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.jumpOnDodje) ? 1 : 0;
    }
    internal bool 下丝东丆丒丆一且丌(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.jumpOnDodjeWithMelee) ? 1 : 0;
    }
    internal float 与丛不丂丛丈不丑七(int 丑万世丂专丈丌业且)
    {
        if(this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且] != null)
        {
                return (float)val_2.minRandomValueForAim;
        }
        
        return (float)val_2.minRandomValueForAim;
    }
    internal float 一丑不一丘丘丅丛丐(int 丑万世丂专丈丌业且)
    {
        if(this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且] != null)
        {
                return (float)val_2.maxRandomValueForAim;
        }
        
        return (float)val_2.maxRandomValueForAim;
    }
    internal float 与丗且丈万东丒丁丑(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_2 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        AILevelSettings val_4 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        float val_5 = val_4.attackRange;
        val_5 = val_2.attackRange * val_5;
        return (float)val_5;
    }
    internal float 丏上丁丈三下与丟丗(int 丑万世丂专丈丌业且)
    {
        if(this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且] != null)
        {
                return (float)val_2.attackRange;
        }
        
        return (float)val_2.attackRange;
    }
    internal bool 丈专丙且丐丐丝丅丟(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.doDamageOnShoot) ? 1 : 0;
    }
    internal bool 七专丏七丁丌丟丏丑(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.changeWeaponOnReload) ? 1 : 0;
    }
    internal bool 下丅世丘丈丛上丈下(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.pauseOnShoot) ? 1 : 0;
    }
    internal System.Collections.Generic.List<string> 七丛丕三与丙丂丗丞(int 丑万世丂专丈丌业且)
    {
        if(this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且] != null)
        {
                return (System.Collections.Generic.List<System.String>)val_2.weapons;
        }
        
        return (System.Collections.Generic.List<System.String>)val_2.weapons;
    }
    internal float 一丁万丑丞业丆丁与(int 丑万世丂专丈丌业且)
    {
        if(this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且] != null)
        {
                return (float)val_2.rotationSpeedMinSkirmish;
        }
        
        return (float)val_2.rotationSpeedMinSkirmish;
    }
    internal float 丟丄丘丝且不且与一(int 丑万世丂专丈丌业且)
    {
        if(this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且] != null)
        {
                return (float)val_2.rotationSpeedMaxSkirmish;
        }
        
        return (float)val_2.rotationSpeedMaxSkirmish;
    }
    internal bool 七一丘万下丙丄丘丅(int 丑万世丂专丈丌业且)
    {
        AILevelSettings val_3 = this.丛丒丌丅一丏丝丗丂().Item[丑万世丂专丈丌业且];
        return (bool)((UnityEngine.Random.Range(min:  0, max:  101)) <= val_3.throwGrenade) ? 1 : 0;
    }
    public 上且下一丁丑丑丟丟()
    {
        this.丟丘丑不丄丙且丘万 = new System.Collections.Generic.Dictionary<System.Int32, AILevelSettings>();
        this.丕丐丞业不一丒万丕 = new System.Collections.Generic.Dictionary<System.Int32, AILevelSettings>();
    }
    private static 上且下一丁丑丑丟丟()
    {
        null = null;
        上且下一丁丑丑丟丟.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<上且下一丁丑丑丟丟>(丙丂丌且丌世丒丐三:  new System.Func<上且下一丁丑丑丟丟>(object:  上且下一丁丑丑丟丟.<>c.<>9, method:  上且下一丁丑丑丟丟 上且下一丁丑丑丟丟.<>c::丙丆丙丙丟丌专丈一()));
    }

}
