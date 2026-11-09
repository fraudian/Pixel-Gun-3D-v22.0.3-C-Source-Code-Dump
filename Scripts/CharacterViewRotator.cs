using UnityEngine;
public class CharacterViewRotator : MonoBehaviour
{
    // Fields
    private UnityEngine.Quaternion 丌丁丒丕东丟丗专丝;
    private bool 与下万丝丞丛业丅七;
    private float 丙业世下丌丙丌丕一;
    private float 业世丁丆万丈且专丆;
    public UnityEngine.Transform characterView;
    private System.Collections.Generic.List<Holoville.HOTween.Tweener> 丛丕丑上下东丘丅业;
    public UnityEngine.Events.UnityEvent OnClicked;
    private CharacterViewRotator.万丘专丂丈且世世万 万丑世丒丝丒与丂丁;
    
    // Methods
    public void SetMode(CharacterViewRotator.万丘专丂丈且世世万 丐专一上与上三丝丁)
    {
        this.万丑世丒丝丒与丂丁 = 丐专一上与上三丝丁;
    }
    public void SetDefaultRotationFromCharacterView()
    {
        UnityEngine.Quaternion val_1 = this.characterView.localRotation;
        this.丌丁丒丕东丟丗专丝 = val_1;
        mem[1152921539940211884] = val_1.y;
        mem[1152921539940211888] = val_1.z;
        mem[1152921539940211892] = val_1.w;
    }
    private void Awake()
    {
        if(this.characterView == 0)
        {
                return;
        }
        
        this.SetDefaultRotationFromCharacterView();
    }
    private void Start()
    {
        if(this.characterView == 0)
        {
                return;
        }
        
        this.ReturnCharacterToDefaultOrientation();
    }
    private void OnEnable()
    {
        if(this.characterView == 0)
        {
                return;
        }
        
        this.ReturnCharacterToDefaultOrientation();
    }
    private void Update()
    {
        if(this.characterView == 0)
        {
                return;
        }
        
        if(UnityEngine.Time.realtimeSinceStartup <= this.业世丁丆万丈且专丆)
        {
                return;
        }
        
        this.ReturnCharacterToDefaultOrientation();
    }
    private void OnClick()
    {
        if(this.与下万丝丞丛业丅七 != false)
        {
                this.与下万丝丞丛业丅七 = false;
            return;
        }
        
        if(this.OnClicked == null)
        {
                return;
        }
        
        this.OnClicked.Invoke();
    }
    private void 丐丟业丑丈丈丄丏且()
    {
        this.与下万丝丞丛业丅七 = true;
        if(this.characterView == 0)
        {
                return;
        }
        
        this.丙业世下丌丙丌丕一 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        float val_10;
        UnityEngine.Transform val_11;
        var val_12;
        val_10 = this;
        if(this.characterView == 0)
        {
                return;
        }
        
        if((Holoville.HOTween.HOTween.IsTweening(p_target:  this.characterView)) == true)
        {
                return;
        }
        
        this.七三不丙东下丕三丂();
        if(this.万丑世丒丝丒与丂丁 == 1)
        {
            goto label_7;
        }
        
        if(this.万丑世丒丝丒与丂丁 != 0)
        {
            goto label_8;
        }
        
        val_11 = this.characterView;
        val_12 = null;
        goto label_11;
        label_7:
        val_11 = this.characterView.transform.GetChild(index:  0);
        val_12 = null;
        label_11:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        float val_10 = -30f;
        val_10 = 丞且丅三三东不丄且.x * val_10;
        val_11.Rotate(axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, angle:  val_10 * (UnityEngine.Time.realtimeSinceStartup - this.丙业世下丌丙丌丕一));
        goto label_17;
        label_8:
        UnityEngine.Debug.LogError(message:  "RotetorModNot Setted");
        val_10 = this.丙业世下丌丙丌丕一;
        label_17:
        mem2[0] = UnityEngine.Time.realtimeSinceStartup;
    }
    private void OnScroll(float 丞且丅三三东不丄且)
    {
        丞且丅三三东不丄且 = 丞且丅三三东不丄且 * (-20f);
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  丞且丅三三东不丄且, y:  0f);
        this.OnDrag(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
    }
    private void 七三不丙东下丕三丂()
    {
        var val_2 = null;
        float val_2 = ShopNGUIController.上丈丂丁三丂业丛丝;
        val_2 = UnityEngine.Time.realtimeSinceStartup + val_2;
        this.业世丁丆万丈且专丆 = val_2;
    }
    public void ReturnCharacterToDefaultOrientation()
    {
        if(this.characterView == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this.丛丕丑上下东丘丅业.GetEnumerator();
        label_8:
        if((974908584 & 1) == 0)
        {
            goto label_5;
        }
        
        int val_4 = Holoville.HOTween.HOTween.Kill(p_tweener:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丛丕丑上下东丘丅业.Clear();
        this.七三不丙东下丕三丂();
        this = Holoville.HOTween.HOTween.To(p_target:  this.characterView, p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Quaternion() {x = this.丌丁丒丕东丟丗专丝, y = V9.16B, z = V10.16B, w = V11.16B})).UpdateType(p_updateType:  3).Ease(p_easeType:  0).OnComplete(p_function:  new TweenDelegate.TweenCallback(object:  this, method:  System.Void CharacterViewRotator::丞丛丕下专丕一与专())));
        this.丛丕丑上下东丘丅业.Add(item:  this);
    }
    public CharacterViewRotator()
    {
        this.丛丕丑上下东丘丅业 = new System.Collections.Generic.List<Holoville.HOTween.Tweener>();
    }
    private void 丞丛丕下专丕一与专()
    {
        this.七三不丙东下丕三丂();
    }

}
