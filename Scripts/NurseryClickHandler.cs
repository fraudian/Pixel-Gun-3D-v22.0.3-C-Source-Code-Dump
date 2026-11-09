using UnityEngine;
public class NurseryClickHandler : MonoBehaviour
{
    // Fields
    internal const string 丝丑专万下丘丙丙万 = "NurseryHintShowed";
    
    // Methods
    private void OnEnable()
    {
        this.世丅东且三丞丙上丞();
    }
    private void 世丅东且三丞丙上丞()
    {
        var val_24;
        var val_25;
        System.Func<UnityEngine.Collider, System.Boolean> val_27;
        var val_29;
        var val_30;
        var val_33;
        var val_34;
        val_24 = 1152921505236451328;
        val_25 = null;
        val_25 = null;
        val_27 = NurseryClickHandler.<>c.<>9__2_0;
        if(val_27 == null)
        {
                System.Func<UnityEngine.Collider, System.Boolean> val_2 = null;
            val_27 = val_2;
            val_2 = new System.Func<UnityEngine.Collider, System.Boolean>(object:  NurseryClickHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NurseryClickHandler.<>c::丛世万丛丂丗三丕不(UnityEngine.Collider 丁丂专业丁丅丅丈丙));
            NurseryClickHandler.<>c.<>9__2_0 = val_27;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<UnityEngine.Collider>(source:  this.GetComponentsInChildren<UnityEngine.Collider>(), predicate:  val_2).GetEnumerator();
        val_29 = 1152921504691191808;
        val_30 = 1152921538456591888;
        label_28:
        var val_28 = 0;
        val_28 = val_28 + 1;
        if(val_5.MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        Rilisoft.ButtonEventsHandler val_11 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.ButtonEventsHandler>(丝三丁东丈丒世丅业:  val_5.Current.gameObject);
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NurseryClickHandler::OnClick());
        val_11.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction());
        new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NurseryClickHandler::OnClick());
        val_11.OnClickEvent.AddListener(call:  new UnityEngine.Events.UnityAction());
        goto label_28;
        label_16:
        val_33 = 0;
        val_34 = 0;
        if(val_5 == null)
        {
            
        }
        else
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_5.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_34 = ???;
        val_33 = ???;
        val_24 = ???;
        val_29 = ???;
        val_30 = ???;
    }
    private void OnClick()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = this;
        val_11 = 1152921505080860672;
        val_12 = null;
        val_12 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(activeInHierarchy == false)
        {
                return;
        }
        
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_11 = 1152921505236504576;
        val_14 = null;
        if(NurseryGuiController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        val_15 = this.gameObject;
        if((val_15.GetComponentInChildren<Rilisoft.上丆丕业丘业丈丄丆>()) == null)
        {
                return;
        }
        
        val_16 = null;
        if(NurseryGuiController.丙丌不七丁与世上下() != false)
        {
                ButtonClickSound.丁业上丏不丕三丗不();
            val_17 = null;
            val_17 = null;
            if((NurseryClickHandler.<>c.<>9__3_0) == null)
        {
                NurseryClickHandler.<>c.<>9__3_0 = new System.Action(object:  NurseryClickHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NurseryClickHandler.<>c::丕丗丏丒丏丆丘丑不());
        }
        
            NurseryGuiController.丘丏丑丕丙东丗丏下(丙业与丙丗丝不丈东:  true);
            return;
        }
        
        val_10 = BannerWindowController.与丅与丒丅专丙丐丗();
        val_10.ForceShowBanner(丌丅丕一丛丛丄一万:  30, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void Start()
    {
        Rilisoft.BindedBillboard val_1 = Rilisoft.BindedBillboard.专丟下丄丄专丆专丑(丒丈丄上丂业丙三丁:  "ToPetsBindedBillboard");
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.enabled = true;
        val_1.BindTo(丅专与丒丈丗丒丘丌:  new System.Func<UnityEngine.Transform>(object:  this, method:  UnityEngine.Transform NurseryClickHandler::丕丌丒与丈丒丑上丏()));
    }
    public NurseryClickHandler()
    {
    
    }
    private UnityEngine.Transform 丕丌丒与丈丒丑上丏()
    {
        return this.transform;
    }

}
