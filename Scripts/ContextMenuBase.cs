using UnityEngine;
public class ContextMenuBase : MonoBehaviour, 丒业丆与三丟丟丝世
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    public System.Collections.Generic.List<ContextMenuItemBase> MenuItems;
    public UnityEngine.Transform Pointer;
    
    // Methods
    public virtual void Show(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Vector3 丁业下丘丅丒东丄丛)
    {
        float val_37;
        System.Collections.Generic.List<ContextMenuItemBase> val_38;
        var val_39;
        var val_43;
        val_37 = 丁业下丘丅丒东丄丛.z;
        val_38 = this;
        if(丞下万上三丘上与专 != 0)
        {
                val_39 = 丞下万上三丘上与专.gameObject;
            if(val_39.activeInHierarchy == false)
        {
                return;
        }
        
        }
        
        InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
        val_4.丗东丐丈丞丁且丁万 = true;
        InfoWindowController val_6 = InfoWindowController.丑七不且上丗丁一世();
        this.transform.SetParent(p:  val_6.infoWindowCamera.transform);
        if(丞下万上三丘上与专 == 0)
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        }
        else
        {
                InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
            val_43 = null;
            val_43 = null;
            UnityEngine.Vector3 val_12 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 丁业下丘丅丒东丄丛.x, y = 丁业下丘丅丒东丄丛.y, z = val_37});
            UnityEngine.Vector3 val_13 = val_11.infoWindowCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        val_37 = val_15.x;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_37, y = val_15.y, z = val_15.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        if(this.Pointer != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.Pointer, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_19 = this.Pointer.position;
            UnityEngine.Vector3 val_21 = this.transform.position;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Transform val_23 = this.transform;
            UnityEngine.Vector3 val_24 = val_23.position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            val_37 = val_25.x;
            val_23.position = new UnityEngine.Vector3() {x = val_37, y = val_25.y, z = val_25.z};
        }
        
        InfoWindowController val_28 = InfoWindowController.丑七不且上丗丁一世();
        if(this.gameObject.layer != val_28.infoWindowCamera.gameObject.layer)
        {
                InfoWindowController val_32 = InfoWindowController.丑七不且上丗丁一世();
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.gameObject, 不东丛三丂丌丑专丆:  val_32.infoWindowCamera.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        
        val_38 = this.MenuItems;
        List.Enumerator<T> val_35 = val_38.GetEnumerator();
        val_39 = 1152921539421701344;
        label_62:
        if((456514312 & 1) == 0)
        {
            goto label_58;
        }
        
        string val_36 = 0.丐丏七丌丕丗业且上();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_36, 丏业丟一东丂东丘丛:  true);
        if(val_36 != null)
        {
            goto label_62;
        }
        
        goto label_62;
        label_58:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public virtual void Close()
    {
        InfoWindowController val_1 = InfoWindowController.丑七不且上丗丁一世();
        val_1.丗东丐丈丞丁且丁万 = false;
        bool val_3 = InfoWindowController.丑七不且上丗丁一世().丅丗下丝东三丗业丞();
        List.Enumerator<T> val_4 = this.MenuItems.GetEnumerator();
        label_9:
        if((456761512 & 1) == 0)
        {
            goto label_6;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
        goto label_9;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.transform.parent = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public virtual void OnInteractWithItem(丛丐丕丐丁专丒丌丐 丒万丂丞世世丙丄丒)
    {
        goto typeof(ContextMenuBase).__il2cppRuntimeField_198;
    }
    protected virtual void 业丂丑东与丟丒丆不(丛丐丕丐丁专丒丌丐 丒万丂丞世世丙丄丒)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        this.MenuItems.Add(item:  null);
        if(丒万丂丞世世丙丄丒 != null)
        {
                val_4 = null;
        }
        
        val_4 = null;
        var val_2 = (((丛丐丕丐丁专丒丌丐.__il2cppRuntimeField_typeHierarchy + ContextMenuItemBase.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_4) ? 丒万丂丞世世丙丄丒 : 0;
        mem2[0] = this;
    }
    protected virtual void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        new System.Action() = new System.Action(object:  this, method:  typeof(ContextMenuBase).__il2cppRuntimeField_1A0);
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
    }
    protected virtual void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    public ContextMenuBase()
    {
    
    }

}
