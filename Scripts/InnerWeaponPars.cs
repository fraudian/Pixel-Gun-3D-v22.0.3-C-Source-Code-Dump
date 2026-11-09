using UnityEngine;
public class InnerWeaponPars : MonoBehaviour
{
    // Fields
    internal WeaponSounds 丌丝下丄业一丄不三;
    public UnityEngine.GameObject animationObject;
    public UnityEngine.Transform[] bonesRoot;
    public UnityEngine.GameObject bonusPrefab;
    public UnityEngine.GameObject sphereEffect;
    public UnityEngine.GameObject fakeGrenade;
    public PlayerBodyAttachment exoskeletonBone;
    public PlayerBodyAttachment exoskeletonWeapon;
    public UnityEngine.Transform grenatePoint;
    public UnityEngine.Transform[] grenadePoints;
    public UnityEngine.Transform LeftArmorHand;
    public UnityEngine.Transform LeftWrist;
    public UnityEngine.GameObject particlePoint;
    public UnityEngine.Texture preview;
    public UnityEngine.SkinnedMeshRenderer renderArms;
    public UnityEngine.Transform RightArmorHand;
    public UnityEngine.Transform RightWrist;
    public UnityEngine.AudioClip shoot;
    public UnityEngine.AudioClip shootSecond;
    public UnityEngine.AudioClip reload;
    public UnityEngine.AudioClip empty;
    public UnityEngine.AudioClip idle;
    public UnityEngine.AudioClip zoomIn;
    public UnityEngine.AudioClip zoomOut;
    public UnityEngine.AudioClip charge;
    public UnityEngine.AudioClip loading;
    public UnityEngine.AudioClip shootStart;
    public UnityEngine.AudioClip shootEnd;
    public UnityEngine.GameObject traiEffectObj1;
    public UnityEngine.GameObject traiEffectObj2;
    public float trailShowDelay;
    public float trailShowDuration;
    public bool trailShowEffect;
    public bool trailShowEffectInShop;
    
    // Methods
    private void Start()
    {
        this.FindArms();
    }
    public void FindArms()
    {
        if(this.renderArms != 0)
        {
                return;
        }
        
        T[] val_2 = this.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>(includeInactive:  true);
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.Length < 1)
        {
                return;
        }
        
        do
        {
            T val_8 = val_2[0];
            if(val_8 != 0)
        {
                if((val_8.gameObject != this.bonusPrefab) || (this.丌丝下丄业一丄不三.IsWeaponInsideHands == true))
        {
            goto label_15;
        }
        
        }
        
        }
        while((0 + 1) < val_2.Length);
        
        return;
        label_15:
        this.renderArms = val_8;
    }
    internal void 三且七丙丞丑丟与三(UnityEngine.Material[] 不七七丒丆丁丗丅丂, bool 丒专丞丅丐丝丛不丄 = False)
    {
        UnityEngine.SkinnedMeshRenderer val_9;
        var val_10;
        val_9 = 丒专丞丅丐丝丛不丄;
        if(this.renderArms == 0)
        {
                this.FindArms();
        }
        
        if((this.renderArms != 0) && (val_9 != true))
        {
                this.renderArms.sharedMaterials = 不七七丒丆丁丗丅丂;
        }
        
        if(val_9 == false)
        {
            goto label_9;
        }
        
        if(this.renderArms != 0)
        {
                val_9 = this.renderArms;
            val_9.sharedMaterial = 不七七丒丆丁丗丅丂[0];
        }
        
        val_10 = 0;
        goto label_17;
        label_27:
        val_9 = this.transform.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>()[0];
        if(val_9.material != 0)
        {
                val_9.sharedMaterial = 不七七丒丆丁丗丅丂[0];
        }
        
        val_10 = 1;
        label_17:
        if(val_10 < val_5.Length)
        {
            goto label_27;
        }
        
        return;
        label_9:
        if(this.renderArms == 0)
        {
                return;
        }
        
        this.renderArms.sharedMaterials = 不七七丒丆丁丗丅丂;
    }
    public InnerWeaponPars()
    {
        this.trailShowEffectInShop = true;
    }

}
