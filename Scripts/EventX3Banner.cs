using UnityEngine;
public class EventX3Banner : BannerWindow
{
    // Fields
    private UnityEngine.GameObject _x3panel;
    private UnityEngine.GameObject _x10panel;
    public UILabel amazonEventCaptionLabel;
    public UnityEngine.GameObject amazonEventObject;
    public UILabel amazonEventTitleLabel;
    private string 丆万丐不丝上下不丙;
    private UnityEngine.GameObject 丅丒七与上东不丛丒;
    
    // Methods
    protected override void OnEnable()
    {
        X10Manager.丄专丂专丑一丂丙丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EventX3Banner::丁万丝丘丂下业丛业()));
        this.丁万丝丘丂下业丛业();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.amazonEventObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丁万丝丘丂下业丛业()
    {
        var val_10;
        var val_11;
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() != null)
        {
                val_10 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌();
        }
        else
        {
                val_10 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._x3panel, 丏业丟一东丂东丘丛:  false);
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() != null)
        {
                val_11 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛();
        }
        else
        {
                val_11 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._x10panel, 丏业丟一东丂东丘丛:  false);
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世() == null)
        {
                return;
        }
        
        if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛() == false)
        {
                return;
        }
        
        this.丒丌丗丝七丟世业不();
    }
    private void 丒丌丗丝七丟世业不()
    {
        UnityEngine.GameObject val_18;
        UnityEngine.Object val_19;
        var val_20;
        string val_2 = X10Manager.丑七不且上丗丁一世().与丑丏丅下丁丏丟丛();
        if(this.丆万丐不丝上下不丙 != null)
        {
                if((System.String.op_Inequality(a:  this.丆万丐不丝上下不丙, b:  val_2)) != false)
        {
                if(this.丅丒七与上东不丛丒 != 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丅丒七与上东不丛丒);
            this.丅丒七与上东不丛丒 = 0;
        }
        
            this.丆万丐不丝上下不丙 = 0;
        }
        else
        {
                if(this.丆万丐不丝上下不丙 != null)
        {
                return;
        }
        
        }
        
        }
        
        this.丆万丐不丝上下不丙 = val_2;
        val_18 = this.丅丒七与上东不丛丒;
        if(val_18 != 0)
        {
                return;
        }
        
        val_18 = 1152921524279436720;
        val_19 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/{0}", arg0:  System.String.Format(format:  "banner_x10_{0}", arg0:  val_2.ToLower())));
        if(val_19 == 0)
        {
                val_20 = "basic";
            if("basic" == null)
        {
                val_20 = "basic";
        }
        
            val_19 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/banner_x10_{0}", arg0:  ToLower()));
        }
        
        if(val_19 == 0)
        {
                return;
        }
        
        val_18 = this._x10panel.transform;
        int val_16 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        this.丅丒七与上东不丛丒 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_19, 丈东丘丏与丌东东下:  val_18, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    protected override void OnDisable()
    {
        X10Manager.东丑三丐业业业丄业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EventX3Banner::丁万丝丘丂下业丛业()));
        this.OnDisable();
    }
    private void 与业丒丟丂丙丛丙丏()
    {
    
    }
    private void 丕东与丌丘上丆丈丗()
    {
    
    }
    public EventX3Banner()
    {
    
    }

}
