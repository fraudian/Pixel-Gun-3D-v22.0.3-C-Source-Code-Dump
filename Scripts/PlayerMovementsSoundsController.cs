using UnityEngine;
public class PlayerMovementsSoundsController : MonoBehaviour
{
    // Fields
    private FirstPersonControlSharp playerControl;
    private PlayerAnimationWrapper animationWrapper;
    private UnityEngine.AudioClip[] stepWalkAudioClips;
    private UnityEngine.AudioClip[] stepWaterAudioClips;
    private UnityEngine.AudioClip[] stepCrouchAudioClips;
    private UnityEngine.AudioClip walkMechBearAudioClip;
    private float stepWalkSoundTimeoutModifierBySpeed;
    private PlayerAnimationWrapper.丂专丅一业东丘东丈 丞上三业专东丁丞丑;
    private PlayerAnimationWrapper.丂专丅一业东丘东丈 丒丂丁东丄丐丙业丞;
    private float 且丆丆丝丂且丁丌丟;
    private int 丁丁丁丄一丐丝丕丙;
    private bool 丌丏丐丁不且丂东万;
    
    // Properties
    public UnityEngine.AudioClip 一丛丞七丗丐丐东三 { get; }
    
    // Methods
    public UnityEngine.AudioClip get_walkMechAudio()
    {
        PlayerMechBody val_3;
        UnityEngine.AudioClip val_4;
        var val_5;
        val_3 = this;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_4 = this.walkMechBearAudioClip;
        }
        else
        {
                val_5 = 0;
            if(this.playerControl._moveC.丑丝丂丗丝丛与不七 == 0)
        {
                return (UnityEngine.AudioClip)val_5;
        }
        
            val_3 = this.playerControl._moveC.丑丝丂丗丝丛与不七;
            val_4 = this.playerControl._moveC.丑丝丂丗丝丛与不七.stepSound;
        }
        
        val_5 = mem[this.playerControl._moveC.丑丝丂丗丝丛与不七.stepSound];
        return (UnityEngine.AudioClip)val_5;
    }
    private void Awake()
    {
        this.丞上三业专东丁丞丑 = 0;
    }
    private void Update()
    {
        UnityEngine.Object val_28;
        var val_29;
        FirstPersonControlSharp val_30;
        var val_31;
        UnityEngine.AudioClip[] val_33;
        float val_34;
        var val_35;
        val_28 = 1152921505171275776;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_3;
        }
        
        this.丞上三业专东丁丞丑 = this.animationWrapper.丄丙丂丝丄丌丗丂丅();
        val_29 = null;
        val_29 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_7;
        }
        
        val_30 = this;
        if(this.playerControl.丌且下丕下下丌万丞 == false)
        {
            goto label_9;
        }
        
        label_7:
        if(丘丐丘万丌丟丞下丝.不丐且丞世业不丆丝() == false)
        {
            goto label_24;
        }
        
        val_30 = this.playerControl;
        goto label_13;
        label_3:
        if(this.playerControl.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.isPlaying == false)
        {
                return;
        }
        
        this.playerControl.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.Stop();
        return;
        label_9:
        if(this.playerControl.丞丗丄丂丆业丈丑业.interpolateScript.专丞世丒丞丞不丝东 == false)
        {
            goto label_24;
        }
        
        label_13:
        val_31 = 1;
        goto label_87;
        label_24:
        if(this.animationWrapper.一七丟丘丕且一丁丘() == false)
        {
            goto label_27;
        }
        
        if((this.丞上三业专东丁丞丑 != 0) || (this.animationWrapper.丕专丅东下丙丙丌万() <= 0.1f))
        {
            goto label_30;
        }
        
        UnityEngine.AudioClip val_7 = this.walkMechAudio;
        val_30 = this.playerControl;
        if(val_7 != 0)
        {
                if((mem[this.playerControl] + 328 + 304.isPlaying) == false)
        {
            goto label_37;
        }
        
        }
        
        val_28 = mem[this.playerControl] + 328 + 304.clip;
        if(val_28 == val_7)
        {
            goto label_83;
        }
        
        label_37:
        mem[this.playerControl] + 328 + 304.loop = true;
        val_28 = mem[mem[this.playerControl] + 328 + 304];
        val_28 = mem[this.playerControl] + 328 + 304;
        val_28.clip = val_7;
        mem[this.playerControl] + 328 + 304.Play();
        goto label_83;
        label_27:
        val_30 = this.playerControl;
        if(this.丌丏丐丁不且丂东万 != false)
        {
                mem[this.playerControl] + 328 + 304.Stop();
        }
        
        if(((mem[this.playerControl] + 267) == 0) || (this.丞上三业专东丁丞丑 > 2))
        {
            goto label_60;
        }
        
        val_33 = this.stepWaterAudioClips;
        goto label_71;
        label_30:
        val_30 = this;
        if(this.playerControl.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.isPlaying == false)
        {
            goto label_83;
        }
        
        this.playerControl.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.Stop();
        goto label_83;
        label_60:
        if((this.丞上三业专东丁丞丑 - 1) >= 2)
        {
            goto label_70;
        }
        
        val_33 = this.stepCrouchAudioClips;
        goto label_71;
        label_70:
        if(this.丞上三业专东丁丞丑 != 0)
        {
            goto label_83;
        }
        
        val_33 = this.stepWalkAudioClips;
        label_71:
        if(mem[this.stepWalkAudioClips] == 0)
        {
            goto label_83;
        }
        
        val_28 = this.animationWrapper;
        if(val_28.丕专丅东下丙丙丌万() <= 0.1f)
        {
            goto label_83;
        }
        
        val_28 = mem[mem[this.playerControl] + 216];
        val_28 = mem[this.playerControl] + 216;
        if(val_28.isGrounded == true)
        {
            goto label_78;
        }
        
        val_28 = mem[this.playerControl];
        if((mem[this.playerControl] + 272) != 0)
        {
            goto label_83;
        }
        
        label_78:
        if(this.丒丂丁东丄丐丙业丞 == 3)
        {
            goto label_83;
        }
        
        val_28 = this.animationWrapper;
        val_34 = UnityEngine.Time.realtimeSinceStartup;
        float val_17 = val_28.丕专丅东下丙丙丌万();
        val_17 = this.stepWalkSoundTimeoutModifierBySpeed / val_17;
        if((val_34 - this.且丆丆丝丂且丁丌丟) <= val_17)
        {
            goto label_83;
        }
        
        val_28 = mem[mem[this.playerControl] + 328 + 304];
        val_28 = mem[this.playerControl] + 328 + 304;
        丂专丅一业东丘东丈 val_28 = this.丞上三业专东丁丞丑;
        val_28 = val_28 - 1;
        val_28.PlayOneShot(clip:  this.万丅丘丄丅东上丒万(丗丞丙丒丏丁世丒丞:  mem[this.stepWalkAudioClips], 丙丏专下丙与万丘世: ref  this.丁丁丁丄一丐丝丕丙), volumeScale:  (val_28 < 2) ? 1f : 1.4f);
        val_31 = 0;
        this.且丆丆丝丂且丁丌丟 = UnityEngine.Time.realtimeSinceStartup;
        goto label_87;
        label_83:
        val_31 = 0;
        label_87:
        if((mem[this.playerControl] + 272) == 0)
        {
            goto label_109;
        }
        
        丂专丅一业东丘东丈 val_29 = this.丞上三业专东丁丞丑;
        丂专丅一业东丘东丈 val_30 = this.丒丂丁东丄丐丙业丞;
        if(val_29 == val_30)
        {
            goto label_109;
        }
        
        val_29 = val_29 - 5;
        if(val_29 < 2)
        {
            goto label_91;
        }
        
        val_30 = val_30 - 5;
        if(val_30 > 1)
        {
            goto label_109;
        }
        
        label_91:
        mem[this.playerControl] + 328 + 304.Stop();
        if(this.丞上三业专东丁丞丑 != 5)
        {
            goto label_96;
        }
        
        mem[this.playerControl] + 328 + 304.loop = true;
        val_28 = mem[mem[this.playerControl] + 328 + 104];
        val_28 = mem[this.playerControl] + 328 + 104;
        if((mem[this.playerControl] + 328 + 304) != 0)
        {
            goto label_117;
        }
        
        label_118:
        label_117:
        mem[this.playerControl] + 328 + 304.clip = val_28;
        mem[this.playerControl] + 328 + 304.Play();
        goto label_109;
        label_96:
        val_31 = val_31 & ((this.丞上三业专东丁丞丑 != 5) ? 1 : 0);
        if(this.丞上三业专东丁丞丑 != 6)
        {
            goto label_109;
        }
        
        mem[this.playerControl] + 328 + 304.loop = true;
        if((mem[this.playerControl] + 328 + 304) != 0)
        {
            goto label_117;
        }
        
        goto label_118;
        label_109:
        if(((((val_31 & 1) != 0) || ((mem[this.playerControl] + 272) == 0)) || (this.丞上三业专东丁丞丑 == 3)) || (this.丒丂丁东丄丐丙业丞 != 3))
        {
            goto label_129;
        }
        
        val_35 = mem[this.playerControl];
        if(mem[this.playerControl] != 0)
        {
            goto label_124;
        }
        
        val_35 = mem[this.playerControl];
        if(val_35 == 0)
        {
            goto label_125;
        }
        
        label_124:
        if((mem[this.playerControl] + 267) != 0)
        {
                val_28 = this.万丅丘丄丅东上丒万(丗丞丙丒丏丁世丒丞:  this.stepWaterAudioClips, 丙丏专下丙与万丘世: ref  this.丁丁丁丄一丐丝丕丙);
            mem[this.playerControl] + 328 + 304.PlayOneShot(clip:  val_28, volumeScale:  1.4f);
        }
        else
        {
                val_28 = mem[mem[this.playerControl] + 328 + 184];
            val_28 = mem[this.playerControl] + 328 + 184;
            mem[this.playerControl] + 328 + 304.PlayOneShot(clip:  val_28);
        }
        
        label_129:
        this.丒丂丁东丄丐丙业丞 = this.丞上三业专东丁丞丑;
        this.丌丏丐丁不且丂东万 = this.animationWrapper.一七丟丘丕且一丁丘();
        return;
        label_125:
    }
    internal void 丕丗丁丄专丏三东不()
    {
        var val_7;
        var val_8;
        FirstPersonControlSharp val_9;
        val_7 = null;
        val_7 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.playerControl.丌且下丕下下丌万丞 == false)
        {
            goto label_5;
        }
        
        }
        
        val_8 = 丘丐丘万丌丟丞下丝.不丐且丞世业不丆丝();
        goto label_8;
        label_5:
        label_8:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(((((this.playerControl.丞丗丄丂丆业丈丑业.interpolateScript.专丞世丒丞丞不丝东 == true) ? 1 : 0) ^ 1) & 1) == 0)
        {
                return;
        }
        
        val_9 = this.playerControl;
        if(this.playerControl != null)
        {
            goto label_16;
        }
        
        val_9 = this.playerControl;
        if(val_9 == null)
        {
            goto label_17;
        }
        
        label_16:
        if(this.playerControl.丅丁丝丞丄丏三丌三 != false)
        {
                this.playerControl.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.PlayOneShot(clip:  this.万丅丘丄丅东上丒万(丗丞丙丒丏丁世丒丞:  this.stepWaterAudioClips, 丙丏专下丙与万丘世: ref  this.丁丁丁丄一丐丝丕丙), volumeScale:  1.4f);
            return;
        }
        
        this.playerControl.丞丗丄丂丆业丈丑业.东且下上丒上七东丞.PlayOneShot(clip:  this.playerControl.丞丗丄丂丆业丈丑业.jumpAudio);
        return;
        label_17:
    }
    private UnityEngine.AudioClip 万丅丘丄丅东上丒万(UnityEngine.AudioClip[] 丗丞丙丒丏丁世丒丞, ref int 丙丏专下丙与万丘世)
    {
        int val_5;
        var val_6;
        if(丙丏专下丙与万丘世 <= 0)
        {
            goto label_0;
        }
        
        val_5 = 丗丞丙丒丏丁世丒丞.Length - 1;
        if(丙丏专下丙与万丘世 >= val_5)
        {
            goto label_2;
        }
        
        val_5 = 丙丏专下丙与万丘世;
        if((UnityEngine.Random.Range(min:  0, max:  2)) != 1)
        {
            goto label_3;
        }
        
        val_6 = 0;
        goto label_7;
        label_0:
        val_5 = 丗丞丙丒丏丁世丒丞.Length;
        label_2:
        val_6 = 1;
        label_7:
        int val_2 = UnityEngine.Random.Range(min:  1, max:  val_5);
        丙丏专下丙与万丘世 = val_2;
        return (UnityEngine.AudioClip)丗丞丙丒丏丁世丒丞[(long)val_2];
        label_3:
        int val_3 = val_5 + 1;
        goto label_7;
    }
    public PlayerMovementsSoundsController()
    {
        this.stepWalkSoundTimeoutModifierBySpeed = 2f;
        this.丁丁丁丄一丐丝丕丙 = 0;
    }

}
