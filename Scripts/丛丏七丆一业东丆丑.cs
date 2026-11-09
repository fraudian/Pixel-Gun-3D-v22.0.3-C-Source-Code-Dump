using UnityEngine;
private sealed class Player_move_c.丛丏七丆一业东丆丑 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private float 丐三丞丞丑丒丘东丑;
    private float 丕丐丅东丌世丈一丅;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丄丙不丈丙东丅丐丆;
    private float 东丑丈丅丈不丝丐东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丛丏七丆一业东丆丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_89;
        float val_93;
        int val_94;
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_96;
        int val_97;
        bool val_102;
        var val_104;
        UnityEngine.AudioClip val_105;
        float val_107;
        float val_108;
        if(this.丗丏丅丕丆世丁专丟 > 4)
        {
            goto label_1;
        }
        
        var val_89 = 106016716 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_89 = this.丝且与丝丒丟万丁专;
        val_89 = val_89 + 106016716;
        goto (106016716 + (this.丗丏丅丕丆世丁专丟) << 2 + 106016716);
        label_162:
        val_93 = this.丝且与丝丒丟万丁专.丅丄下丛东丙且且丞;
        if(val_93 <= 0f)
        {
            goto label_68;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.东丑丈丅丈不丝丐东 * val_2;
        val_2 = val_93 - val_2;
        val_94 = 4;
        this.丝且与丝丒丟万丁专.丅丄下丛东丙且且丞 = (val_2 < 0) ? -0.01f : (val_2);
        goto label_14;
        label_1:
        val_97 = 0;
        return (bool)val_97;
        label_14:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = ;
        val_97 = 1;
        return (bool)val_97;
        if(val_89.丙不丅丕三丂业东丕().丌上丗丕不七世丅丁() == null)
        {
            goto label_112;
        }
        
        int val_38 = val_89.丙不丅丕三丂业东丕().丌上丗丕不七世丅丁().万上丄下业丛丌不丈();
        int val_39 = val_38 - 1;
        var val_40 = (val_39 == 1) ? 0 : 0;
        if(val_39 != 1)
        {
            goto label_91;
        }
        
        if(this.丝且与丝丒丟万丁专.ChangeWeaponClip_Backup == 0)
        {
            goto label_112;
        }
        
        val_105 = this.丝且与丝丒丟万丁专.ChangeWeaponClip_Backup;
        goto label_112;
        label_91:
        if(val_39 == 0)
        {
            goto label_96;
        }
        
        if(val_39 != 2)
        {
            goto label_97;
        }
        
        val_102 = val_40;
        if(this.丝且与丝丒丟万丁专.ChangeWeaponClip_Melee == 0)
        {
            goto label_184;
        }
        
        val_105 = this.丝且与丝丒丟万丁专.ChangeWeaponClip_Melee;
        goto label_112;
        label_96:
        if(this.丝且与丝丒丟万丁专.ChangeWeaponClip_Primary != 0)
        {
                val_105 = this.丝且与丝丒丟万丁专.ChangeWeaponClip_Primary;
        }
        
        label_112:
        val_102 = 0;
        label_184:
        if(((val_105 != 0) && (GameConnect.东且三丆丑世世丘丟() != true)) && (与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false))
        {
                if(val_89.丙丙丟世丌且丑丅丘() != 0)
        {
                val_89.丙丙丟世丌且丑丅丘().PlayOneShot(clip:  val_105);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.业丒丏丘一丌丄丞丞 != false)
        {
                val_96 = val_89.丙不丅丕三丂业东丕().七丆丗丘丈丞丁丞丞();
        }
        else
        {
                val_96 = 0;
        }
        
        val_93 = this.丝且与丝丒丟万丁专.万业七万丐万丁一下;
        float val_57 = UnityEngine.Time.realtimeSinceStartup;
        val_57 = val_57 - this.丝且与丝丒丟万丁专.丅东业上一丕丐丂丒;
        float val_58 = val_93 - val_57;
        if(val_102 == 0)
        {
            goto label_129;
        }
        
        this.丝且与丝丒丟万丁专.丅丄下丛东丙且且丞 = 0f;
        UnityEngine.AnimationState val_61 = val_89.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().Item["Loading"];
        if(val_96 == 0)
        {
            goto label_132;
        }
        
        val_96 = val_89.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().GetClip(name:  "Loading");
        float val_65 = val_96.length;
        val_93 = val_65;
        val_65 = val_93 / val_58;
        val_61.speed = val_65;
        goto label_143;
        label_129:
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丛业七丆万丕一丟丏() == false)
        {
            goto label_140;
        }
        
        val_107 = 300f;
        goto label_141;
        label_132:
        val_61.speed = 1f;
        if(this.丝且与丝丒丟万丁专.业丒丏丘一丌丄丞丞 != false)
        {
                val_93 = val_89.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().GetClip(name:  "Loading").length;
            float val_90 = this.丝且与丝丒丟万丁专.万业七万丐万丁一下;
            val_90 = val_90 / val_58;
            val_90 = val_93 * val_90;
            val_90 = val_90 - val_93;
            val_90 = UnityEngine.Time.realtimeSinceStartup - val_90;
            val_89.丏一丛世专丆七丌丕(丑丒业丘丑东丕世丅:  true, 丙且丒丈丕丅不丝丏:  val_93, 丝丁专丙丐与丞丐一:  true, 丅丁丟万丝不丛东万:  val_90);
        }
        
        label_143:
        bool val_74 = val_89.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().Play(animation:  "Loading");
        label_68:
        val_104 = 0;
        if(val_89.丛丌丐丞丅丟专七丂() == 1001)
        {
                this.丝且与丝丒丟万丁专.丅丄下丛东丙且且丞 = 0f;
        }
        
        val_97 = 0;
        this.丝且与丝丒丟万丁专.photonView.synchronization = 2;
        this.丝且与丝丒丟万丁专.丑一丆专不丂丆东与 = false;
        return (bool)val_97;
        label_140:
        一三专丈世丑丆丑丐 val_76 = PlayerCoreSettingsStorager.dynamicSettings;
        val_107 = val_76.丒丄丂丄丟丏丑丌下;
        label_141:
        this.东丑丈丅丈不丝丐东 = val_107;
        if(GameConnect.与不丗丏万丙丞丌丑() != false)
        {
                float val_91 = this.丐三丞丞丑丒丘东丑;
            if(val_91 > 0.4f)
        {
                val_108 = 200f;
        }
        else
        {
                val_91 = 0.4f / val_91;
            val_108 = val_91 * 200f;
        }
        
            this.东丑丈丅丈不丝丐东 = val_108;
        }
        
        if(this.丝且与丝丒丟万丁专.业丒丏丘一丌丄丞丞 == false)
        {
            goto label_162;
        }
        
        float val_78 = 40f / this.东丑丈丅丈不丝丐东;
        float val_92 = this.丝且与丝丒丟万丁专.万业七万丐万丁一下;
        val_92 = val_92 / val_58;
        val_92 = val_78 * val_92;
        val_92 = val_92 - val_78;
        val_92 = UnityEngine.Time.realtimeSinceStartup - val_92;
        val_89.丏一丛世专丆七丌丕(丑丒业丘丑东丕世丅:  true, 丙且丒丈丕丅不丝丏:  val_78, 丝丁专丙丐与丞丐一:  true, 丅丁丟万丝不丛东万:  val_92);
        goto label_162;
        label_97:
        var val_80 = (val_39 == 3) ? 0 : ((val_39 == 2) ? 0 : ((val_39 == 0) ? 0 : (val_40)));
        if(val_39 != 3)
        {
            goto label_163;
        }
        
        if(this.丝且与丝丒丟万丁专.ChangeWeaponClip_Special == 0)
        {
            goto label_184;
        }
        
        goto label_184;
        label_163:
        if(val_38 == 6)
        {
            goto label_174;
        }
        
        if((val_38 != 5) || (this.丝且与丝丒丟万丁专.ChangeWeaponClip_Sniper == 0))
        {
            goto label_184;
        }
        
        goto label_184;
        label_174:
        if(this.丝且与丝丒丟万丁专.ChangeWeaponClip_Heavy == 0)
        {
            goto label_184;
        }
        
        goto label_184;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Player_move_c.丛丏七丆一业东丆丑();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
