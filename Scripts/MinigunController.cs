using UnityEngine;
public class MinigunController : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform gunBone;
    private UnityEngine.Transform gunBoneDouble;
    private bool invertRotation;
    private bool invertRotationDouble;
    private MinigunController.丙专专丆丆丒三下丏 gunRotationAxis;
    private bool rotateRight;
    private float gunMaxRotationSpeed;
    private float gunSpinUpTime;
    private float gunSpinDownTime;
    private UnityEngine.AudioClip startSpinUpAudioClip;
    private UnityEngine.AudioClip stopSpinUpAudioClip;
    private UnityEngine.AudioClip loopRotationAudioClip;
    private float loopRotationSoundMinPitch;
    private float loopRotationSoundMaxPitch;
    private float loopRotationSoundFadeThresold;
    internal bool instantMinigun;
    private float[] size;
    private UnityEngine.Transform[] gunBoneOthers;
    private bool[] invertRotationOthers;
    private UnityEngine.AudioSource 业丒丘三不丟东丂丏;
    private UnityEngine.AudioSource 世丗丁丒丝丅丂丈三;
    private float 丅丏且且丂丑且丒七;
    private float 丏且丞丅丛上丁丄上;
    private int 丏丐丞且丞丙丗且丞;
    private bool 丘丆上丑丕世丅三丁;
    private WeaponSounds 丄丏丅与丙丆丞丒丏;
    private float 丝丞丏丈丁丌七专丆;
    private float 且世业丅丒丕丘丛丆;
    internal float 万丒下东且世三丄丒;
    internal bool shouldStopRotationForReloading;
    public int currentInstantShoot;
    public bool identityRotation;
    private bool 且下且丐一丁丂丄丕;
    
    // Properties
    internal float 丒上丕三下丏专丁丗 { get; }
    internal bool 丒七丝丈丂业丏业丅 { get; }
    
    // Methods
    internal float 丐丅世世万丒东丕且()
    {
        if(this.currentInstantShoot >= this.size.Length)
        {
                return (float)this[this.currentInstantShoot];
        }
        
        if((this.currentInstantShoot & 2147483648) != 0)
        {
                return (float)this[this.currentInstantShoot];
        }
        
        this = this.size;
        return (float)this[this.currentInstantShoot];
    }
    internal void 丄丙业丈上丐业丞世()
    {
        int val_1 = this.currentInstantShoot;
        val_1 = val_1 + 1;
        this.currentInstantShoot = val_1;
    }
    internal bool 丐与七丄七丈丞丁业()
    {
        if(this.instantMinigun == false)
        {
                return (bool)(this.丅丏且且丂丑且丒七 >= this.gunMaxRotationSpeed) ? 1 : 0;
        }
        
        return (bool)(this.丅丏且且丂丑且丒七 > 0f) ? 1 : 0;
    }
    internal void 丐丁不丅丁丝丑业丏()
    {
        this.丘丆上丑丕世丅三丁 = true;
        this.且下且丐一丁丂丄丕 = false;
    }
    internal void 万丛丂丑丑丆且丌丁()
    {
        this.丅丏且且丂丑且丒七 = 0f;
        this.丂三业丐丒丕丞丗丙();
        this.丘丆上丑丕世丅三丁 = false;
        if(this.丄丏丅与丙丆丞丒丏 == 0)
        {
                return;
        }
        
        if(this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁() == 0)
        {
                return;
        }
        
        this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().专丙丕三丈且三丞丘(不丗不且一丆丞上丗:  -10000f);
    }
    internal void 上万丟与丏东一丅丘()
    {
        if(this.shouldStopRotationForReloading == false)
        {
                return;
        }
        
        this.万丛丂丑丑丆且丌丁();
    }
    internal void 丂三业丐丒丕丞丗丙()
    {
        if(this.shouldStopRotationForReloading == false)
        {
                return;
        }
        
        this.gunBone.localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        if(this.gunBoneDouble == 0)
        {
                return;
        }
        
        this.gunBoneDouble.localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
    }
    private void Start()
    {
        UnityEngine.AnimationCurve val_21;
        UnityEngine.AudioSource val_22;
        UnityEngine.AudioSource val_23;
        this.丏且丞丅丛上丁丄上 = UnityEngine.Random.Range(min:  0f, max:  360f);
        WeaponSounds val_2 = this.GetComponent<WeaponSounds>();
        this.丄丏丅与丙丆丞丒丏 = val_2;
        val_21 = 0;
        if(val_2 != 0)
        {
                val_21 = 0;
            if(this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁() != 0)
        {
                val_21 = this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().GetComponent<UnityEngine.AudioSource>().GetCustomCurve(type:  0);
        }
        
        }
        
        val_22 = this.gameObject.AddComponent<UnityEngine.AudioSource>();
        this.业丒丘三不丟东丂丏 = val_22;
        if(val_21 == null)
        {
            goto label_12;
        }
        
        if(this.丄丏丅与丙丆丞丒丏 != 0)
        {
            goto label_15;
        }
        
        if(this.业丒丘三不丟东丂丏 != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_15:
        Player_move_c val_12 = this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁();
        if(val_12.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
            goto label_23;
        }
        
        }
        
        if(this.业丒丘三不丟东丂丏 != null)
        {
            goto label_51;
        }
        
        label_52:
        label_51:
        label_17:
        this.业丒丘三不丟东丂丏.spatialBlend = 0f;
        this.业丒丘三不丟东丂丏.dopplerLevel = 0f;
        this.业丒丘三不丟东丂丏.rolloffMode = 2;
        this.业丒丘三不丟东丂丏.SetCustomCurve(type:  0, curve:  val_21);
        this.业丒丘三不丟东丂丏.maxDistance = 50f;
        val_22 = this.业丒丘三不丟东丂丏;
        label_12:
        val_22.clip = this.loopRotationAudioClip;
        this.业丒丘三不丟东丂丏.volume = 0f;
        this.业丒丘三不丟东丂丏.loop = true;
        this.业丒丘三不丟东丂丏.Play();
        val_23 = this.gameObject;
        this.世丗丁丒丝丅丂丈三 = val_23.AddComponent<UnityEngine.AudioSource>();
        if(val_21 == null)
        {
            goto label_34;
        }
        
        if(this.丄丏丅与丙丆丞丒丏 != 0)
        {
            goto label_37;
        }
        
        if(this.世丗丁丒丝丅丂丈三 != null)
        {
            goto label_39;
        }
        
        goto label_39;
        label_37:
        Player_move_c val_18 = this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁();
        if(val_18.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
            goto label_45;
        }
        
        }
        
        if(this.世丗丁丒丝丅丂丈三 != null)
        {
            goto label_53;
        }
        
        label_54:
        label_53:
        label_39:
        this.世丗丁丒丝丅丂丈三.spatialBlend = 0f;
        this.世丗丁丒丝丅丂丈三.dopplerLevel = 0f;
        this.世丗丁丒丝丅丂丈三.rolloffMode = 2;
        val_23 = this.世丗丁丒丝丅丂丈三;
        val_23.SetCustomCurve(type:  0, curve:  val_21);
        this.世丗丁丒丝丅丂丈三.maxDistance = 50f;
        label_34:
        this.丏下丕丟丛丆七丈丄();
        return;
        label_23:
        if(this.业丒丘三不丟东丂丏 != null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_45:
        if(this.世丗丁丒丝丅丂丈三 != null)
        {
            goto label_53;
        }
        
        goto label_54;
    }
    private void LateUpdate()
    {
        float val_33;
        float val_34;
        UnityEngine.AudioClip val_35;
        float val_36;
        float val_37;
        val_33 = this.丅丏且且丂丑且丒七;
        if(val_33 == 0f)
        {
                this.currentInstantShoot = 0;
        }
        
        if(this.shouldStopRotationForReloading != false)
        {
                if((this.丄丏丅与丙丆丞丒丏.丌丙丆下专丝丑且丈().IsPlaying(name:  "Reload")) == true)
        {
                return;
        }
        
        }
        
        if((this.丄丏丅与丙丆丞丒丏 != 0) && (this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁() != 0))
        {
                Player_move_c val_6 = this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁();
            if(val_6.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
            goto label_18;
        }
        
        }
        
        }
        
        int val_9 = (this.丘丆上丑丕世丅三丁 == false) ? (-1) : 1;
        if(this.丏丐丞且丞丙丗且丞 != val_9)
        {
            goto label_19;
        }
        
        if(this.丘丆上丑丕世丅三丁 == true)
        {
            goto label_23;
        }
        
        val_33 = this.丝丞丏丈丁丌七专丆;
        goto label_21;
        label_19:
        if(this.丘丆上丑丕世丅三丁 == true)
        {
            goto label_23;
        }
        
        float val_10 = UnityEngine.Time.realtimeSinceStartup;
        this.丝丞丏丈丁丌七专丆 = val_10;
        label_21:
        if(val_10 != 0f)
        {
                float val_11 = UnityEngine.Time.realtimeSinceStartup;
            val_11 = val_11 - this.丝丞丏丈丁丌七专丆;
            if(val_11 <= this.且世业丅丒丕丘丛丆)
        {
            goto label_65;
        }
        
        }
        
        label_23:
        float val_32 = this.gunMaxRotationSpeed;
        val_32 = val_32 * (float)val_9;
        if(this.丘丆上丑丕世丅三丁 == true)
        {
            goto label_25;
        }
        
        val_34 = this.gunSpinDownTime;
        if(val_34 >= 0)
        {
            goto label_26;
        }
        
        label_25:
        val_34 = this.gunSpinUpTime;
        label_26:
        float val_12 = val_32 / val_34;
        label_65:
        float val_33 = this.丅丏且且丂丑且丒七;
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_12 * val_13;
        val_33 = val_33 + val_13;
        this.丅丏且且丂丑且丒七 = val_33;
        val_35 = 1152921504838422528;
        float val_14 = UnityEngine.Mathf.Clamp(value:  val_33, min:  0f, max:  this.gunMaxRotationSpeed);
        this.丅丏且且丂丑且丒七 = val_14;
        val_14 = val_14 * ((this.rotateRight == true) ? -1f : 1f);
        val_14 = this.丏且丞丅丛上丁丄上 + val_14;
        this.丏且丞丅丛上丁丄上 = val_14;
        if((this.丄丏丅与丙丆丞丒丏 == 0) && (this.丅丏且且丂丑且丒七 == 0f))
        {
                this.丏且丞丅丛上丁丄上 = 0f;
        }
        
        val_36 = 0f;
        if(this.丅丏且且丂丑且丒七 > 0f)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                float val_34 = this.丅丏且且丂丑且丒七;
            val_34 = val_34 / this.gunMaxRotationSpeed;
            val_36 = val_34 / this.loopRotationSoundFadeThresold;
        }
        
        }
        
        this.业丒丘三不丟东丂丏.volume = UnityEngine.Mathf.Clamp(value:  val_36, min:  0f, max:  1f);
        val_37 = this.loopRotationSoundMinPitch;
        float val_19 = this.loopRotationSoundMaxPitch - val_37;
        val_19 = val_19 * (this.丅丏且且丂丑且丒七 / this.gunMaxRotationSpeed);
        val_19 = val_37 + val_19;
        this.业丒丘三不丟东丂丏.pitch = val_19;
        if(this.丏丐丞且丞丙丗且丞 != val_9)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_35 = mem[val_9 == 0x1 ? this.startSpinUpAudioClip : this.stopSpinUpAudioClip];
            val_35 = (val_9 == 1) ? this.startSpinUpAudioClip : this.stopSpinUpAudioClip;
            this.世丗丁丒丝丅丂丈三.PlayOneShot(clip:  val_35);
        }
        
        }
        
        if((this.丄丏丅与丙丆丞丒丏 != 0) && (this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁() != 0))
        {
                Player_move_c val_26 = this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁();
            if(val_26.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
            goto label_59;
        }
        
        }
        
            if(val_12 != this.万丒下东且世三丄丒)
        {
                this.万丒下东且世三丄丒 = val_12;
            val_37 = this.万丒下东且世三丄丒;
            this.丄丏丅与丙丆丞丒丏.下丏丆下丙与丘上丁().专丙丕三丈且三丞丘(不丗不且一丆丞上丗:  val_37);
        }
        
        }
        
        label_59:
        this.丏下丕丟丛丆七丈丄();
        this.丘丆上丑丕世丅三丁 = false;
        this.丏丐丞且丞丙丗且丞 = val_9;
        return;
        label_18:
        var val_31 = (((int)UnityEngine.Mathf.Sign(f:  this.万丒下东且世三丄丒)) != 0f) ? ((int)UnityEngine.Mathf.Sign(f:  this.万丒下东且世三丄丒)) : (0 + 1);
        goto label_65;
    }
    private void 丏下丕丟丛丆七丈丄()
    {
        UnityEngine.Transform[] val_3;
        var val_4;
        bool val_5;
        this.丏下丕丟丛丆七丈丄(三丈七丝世丑三三业:  this.gunBone, 丐丅万丅业丟专丂丘:  this.invertRotation);
        if(this.gunBoneDouble != 0)
        {
                this.丏下丕丟丛丆七丈丄(三丈七丝世丑三三业:  this.gunBoneDouble, 丐丅万丅业丟专丂丘:  this.invertRotationDouble);
        }
        
        val_3 = this.gunBoneOthers;
        if(val_3 == null)
        {
                return;
        }
        
        val_4 = 0;
        goto label_5;
        label_13:
        if((this.invertRotationOthers != null) && (val_4 < this.invertRotationOthers.Length))
        {
                val_5 = this.invertRotationOthers[0];
        }
        else
        {
                val_5 = 0;
        }
        
        this.丏下丕丟丛丆七丈丄(三丈七丝世丑三三业:  this.gunBoneOthers[0], 丐丅万丅业丟专丂丘:  (val_5 != 0) ? 1 : 0);
        val_3 = this.gunBoneOthers;
        val_4 = 1;
        label_5:
        if(val_4 < this.gunBoneOthers.Length)
        {
            goto label_13;
        }
    
    }
    private void 丏下丕丟丛丆七丈丄(UnityEngine.Transform 三丈七丝世丑三三业, bool 丐丅万丅业丟专丂丘 = False)
    {
        float val_12;
        float val_13;
        float val_14;
        UnityEngine.Quaternion val_1 = 三丈七丝世丑三三业.localRotation;
        val_12 = val_1.x;
        val_13 = val_1.y;
        val_14 = val_1.z;
        if(this.identityRotation != false)
        {
                if(((this.丄丏丅与丙丆丞丒丏 == 0) && (this.丅丏且且丂丑且丒七 == 0f)) && (this.且下且丐一丁丂丄丕 != true))
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.且下且丐一丁丂丄丕 = true;
            val_12 = val_3.x;
            val_13 = val_3.y;
            val_14 = val_3.z;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
            三丈七丝世丑三三业.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        
        }
        
        if(this.shouldStopRotationForReloading != false)
        {
                if(this.丅丏且且丂丑且丒七 <= 0.001f)
        {
                return;
        }
        
        }
        
        if(this.gunRotationAxis == 2)
        {
            goto label_15;
        }
        
        if(this.gunRotationAxis == 1)
        {
            goto label_16;
        }
        
        if(this.gunRotationAxis != 0)
        {
            goto label_19;
        }
        
        var val_5 = (丐丅万丅业丟专丂丘 != true) ? (-this.丏且丞丅丛上丁丄上) : this.丏且丞丅丛上丁丄上;
        goto label_19;
        label_15:
        var val_6 = (丐丅万丅业丟专丂丘 != true) ? (-this.丏且丞丅丛上丁丄上) : this.丏且丞丅丛上丁丄上;
        goto label_19;
        label_16:
        label_19:
        if(this.identityRotation != false)
        {
                if(this.且下且丐一丁丂丄丕 == true)
        {
                return;
        }
        
        }
        
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_12, y = (丐丅万丅业丟专丂丘 != true) ? (-this.丏且丞丅丛上丁丄上) : this.丏且丞丅丛上丁丄上, z = val_14});
        val_12 = val_8.x;
        val_14 = val_8.z;
        三丈七丝世丑三三业.localRotation = new UnityEngine.Quaternion() {x = val_12, y = val_8.y, z = val_14, w = val_8.w};
    }
    internal void 丟不丌丏丏与丞丂与()
    {
        if(this.业丒丘三不丟东丂丏 == 0)
        {
                return;
        }
        
        if(this.业丒丘三不丟东丂丏.clip == 0)
        {
                return;
        }
        
        this.业丒丘三不丟东丂丏.volume = 0f;
    }
    public MinigunController()
    {
        this.gunMaxRotationSpeed = 0f;
        this.gunSpinUpTime = 1f;
        this.gunRotationAxis = 2;
        this.gunSpinDownTime = -1f;
        this.loopRotationSoundMinPitch = 0.7f;
        this.loopRotationSoundMaxPitch = 1.5f;
        this.rotateRight = true;
        this.loopRotationSoundFadeThresold = 0.2f;
        this.丏丐丞且丞丙丗且丞 = 0;
        this.且世业丅丒丕丘丛丆 = 0.2f;
        this.且下且丐一丁丂丄丕 = true;
    }

}
