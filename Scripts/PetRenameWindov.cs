using UnityEngine;
public class PetRenameWindov : MonoBehaviour
{
    // Fields
    private static System.Action<PGCompany.世丒丗丅丛丕不万丂> 一丈七丝丗三七专丝;
    private UnityEngine.Transform _petPoint;
    private UIInput petsNameInput;
    private UILabel buttonLabel;
    public AnimationCoroutineRunner petProfileAnimationRunner;
    internal string 丂下丕东丗专丆丐且;
    private System.Action 专世丐丂世丞丌且丛;
    private PGCompany.世丒丗丅丛丕不万丂 丑七三丆丐丙丟丈且;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    internal static void 丁下专丘万丂丄世丟(System.Action<PGCompany.世丒丗丅丛丕不万丂> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PetRenameWindov.一丈七丝丗三七专丝, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 专七丝且丞丁不丁三(System.Action<PGCompany.世丒丗丅丛丕不万丂> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PetRenameWindov.一丈七丝丗三七专丝, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void 丘丒丛丌一丐不且丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专世丐丂世丞丌且丛, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专世丐丂世丞丌且丛 != 1152921535485488640);
    
    }
    private void 一且丑上三丕丄丑丛(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专世丐丂世丞丌且丛, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专世丐丂世丞丌且丛 != 1152921535485625216);
    
    }
    internal void 丒与丏一丞丈丙丛上(System.Action 丌不丞丁七丂万上丏)
    {
        this.专世丐丂世丞丌且丛 = 丌不丞丁七丂万上丏;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.世丒丗丅丛丕不万丂 上东丞世三世且丈丌)
    {
        this.丑七三丆丐丙丟丈且 = 上东丞世三世且丈丌;
        UnityEngine.Transform val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<Rilisoft.PetEngine>(path:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丘丕丂万丝丁丌丞业(世丐丗专丅三丝丑丆:  this.丑七三丆丐丙丟丈且.业上丙丞丐丄丆丅七())).下七丏不丒丗业丛专()).GetComponent<UnityEngine.Transform>();
        val_7.parent = this._petPoint;
        PetInfo val_10 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.丑七三丆丐丙丟丈且.业上丙丞丐丄丆丅七());
        val_7.localPosition = new UnityEngine.Vector3() {x = val_10.m_positionInBanners, y = V9.16B, z = V10.16B};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_10.m_rotationInBanners, y = val_10.m_positionInBanners, z = V9.16B});
        val_7.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        if(val_7 != null)
        {
                val_7.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        else
        {
                val_7.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_7.gameObject, 不东丛三丂丌丑专丆:  this._petPoint.gameObject.layer);
        if(val_7 != null)
        {
                this.专东丁丙丞丂东丝丁(丞下丂丝丁丏丛丌世:  val_7.gameObject);
        }
        else
        {
                this.专东丁丙丞丂东丝丁(丞下丂丝丁丏丛丌世:  val_7.gameObject);
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_7.gameObject);
        this.petsNameInput.value = 上东丞世三世且丈丌.专三丏丏东丌七丅且();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.buttonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丂下丕东丗专丆丐且));
    }
    public void HandleConfirm(UIInput 丗丄下丈丑七丗丞专)
    {
        this.OnSubmitPetsName(丗丄下丈丑七丗丞专:  丗丄下丈丑七丗丞专);
        this.丆世与丑丆丅丐万且();
    }
    public void OnSubmitPetsName(UIInput 丗丄下丈丑七丗丞专)
    {
        int val_2 = this.petsNameInput.value;
        if(val_2 == null)
        {
            goto label_2;
        }
        
        if(this.丑七三丆丐丙丟丈且 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_2:
        val_2 = System.String.alignConst;
        if(this.丑七三丆丐丙丟丈且 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        this.丑七三丆丐丙丟丈且.下丘丞丙丛丙丙丄与(丒丘丏上丙丟丑丕丈:  val_2);
        if(PetRenameWindov.一丈七丝丗三七专丝 == null)
        {
                return;
        }
        
        PetRenameWindov.一丈七丝丗三七专丝.Invoke(obj:  this.丑七三丆丐丙丟丈且);
    }
    private void 专东丁丙丞丂东丝丁(UnityEngine.GameObject 丞下丂丝丁丏丛丌世)
    {
        UnityEngine.Animation val_11;
        System.Object[] val_12 = this;
        if(丞下丂丝丁丏丛丌世 == 0)
        {
                return;
        }
        
        if(上丑三丁丄丛丁万丑.东丅三丏丂丞下上丑() == true)
        {
                return;
        }
        
        val_11 = 丞下丂丝丁丏丛丌世.GetComponent<UnityEngine.Animation>();
        this.petProfileAnimationRunner.StopAllCoroutines();
        if((val_11.GetClip(name:  "Profile")) == 0)
        {
                object[] val_6 = new object[1];
            val_12 = val_6;
            val_12[0] = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  丞下丂丝丁丏丛丌世);
            UnityEngine.Debug.LogErrorFormat(format:  "Error: pet {0} has no Profile animation clip (EggHatchingWindowController)", args:  val_6);
            return;
        }
        
        if(this.petProfileAnimationRunner.gameObject.activeInHierarchy != false)
        {
                val_12 = this.petProfileAnimationRunner;
            val_12.StartPlay(丆不丝丝上一丞七业:  val_11, 七不丐下丟专业万丅:  "Profile", 丄三丗丛丑下丅丏七:  false, 丟丘丙丄丅万丏与丗:  0);
            return;
        }
        
        val_12 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "Coroutine couldn\'t be started because the the game object \'AnimationCoroutineRunner\' is inactive! (Pet)", args:  val_12);
    }
    private void Awake()
    {
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PetRenameWindov::HandleBackgroundTapped()), 与且专丈不万东一万:  "NotificationWindowController");
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void HandleBackgroundTapped()
    {
        this.丆世与丑丆丅丐万且();
    }
    public void HandleClose()
    {
        this.丆世与丑丆丅丐万且();
    }
    private void 丆世与丑丆丅丐万且()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(this.专世丐丂世丞丌且丛 != null)
        {
                this.专世丐丂世丞丌且丛.Invoke();
        }
        
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 东三世丙丁丒丝世丕()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public PetRenameWindov()
    {
        this.丂下丕东丗专丆丐且 = "Key_2560";
    }

}
