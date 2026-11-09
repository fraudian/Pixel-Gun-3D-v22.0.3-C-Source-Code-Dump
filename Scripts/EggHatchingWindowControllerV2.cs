using UnityEngine;
public class EggHatchingWindowControllerV2 : MonoBehaviour
{
    // Fields
    private static EggHatchingWindowControllerV2 basePrefab;
    private static EggHatchingWindowControllerV2.丌丈丈丕东丅七七丟 下丝上丐丗七丑三丛;
    private static EggHatchingWindowControllerV2 丅丑丟丛一万丅丆丗;
    internal static EggHatchingWindowControllerV2.下丏业丗丄七丙丞丂 丕丑东丈丈世七丘不;
    private UnityEngine.GameObject 丁一丆业丅不丌丟丆;
    private UnityEngine.Transform eggPoint;
    private UnityEngine.GameObject eggPrefabModel;
    private EggIncubator3dController incubator3d;
    private UnityEngine.Animator petCardAnimation;
    private System.Collections.Generic.List<PetCardController> petCardList;
    private UnityEngine.GameObject quad;
    private UnityEngine.GameObject quadInstantly;
    private UnityEngine.GameObject tapToClose;
    private static System.Action 东丌丄东丗丑东丈丕;
    private static System.Action 丟专万丆丄丈东丆丄;
    
    // Properties
    internal static EggHatchingWindowControllerV2 丌丛丟丁丏丌且丛且 { get; }
    
    // Methods
    internal static EggHatchingWindowControllerV2 且丕丈丙丛不业丂丗()
    {
        null = null;
        return (EggHatchingWindowControllerV2)EggHatchingWindowControllerV2.丅丑丟丛一万丅丆丗;
    }
    internal static void 丟业业与三世不丅万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  EggHatchingWindowControllerV2.东丌丄东丗丑东丈丕, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(EggHatchingWindowControllerV2.东丌丄东丗丑东丈丕 != 1152921505235496992);
    
    }
    internal static void 丌丅世丑丄丐丐丈丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  EggHatchingWindowControllerV2.东丌丄东丗丑东丈丕, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(EggHatchingWindowControllerV2.东丌丄东丗丑东丈丕 != 1152921505235496992);
    
    }
    internal static void 丂万三丘七丞业三万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄 != 1152921505235497000);
    
    }
    internal static void 且七丌不丐丈与丘七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄 != 1152921505235497000);
    
    }
    private void 与丐上且丆业丒上东()
    {
        var val_8;
        System.Action val_9;
        var val_10;
        System.Action val_11;
        val_8 = null;
        val_8 = null;
        EggHatchingWindowControllerV2.丕丑东丈丈世七丘不 = 1;
        if(EggHatchingWindowControllerV2.下丝上丐丗七丑三丛 == 1)
        {
                System.Action val_2 = null;
            val_9 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void EggHatchingWindowControllerV2::与丐上且丆业丒上东());
            this.丁一丆业丅不丌丟丆.GetComponent<EggModelEventHandler>().remove_OnOpened(丙业与丙丗丝不丈东:  val_2);
        }
        else
        {
                EggIncubator3dController val_3 = this.丁一丆业丅不丌丟丆.GetComponent<EggIncubator3dController>();
            System.Action val_5 = null;
            val_9 = val_5;
            val_5 = new System.Action(object:  this, method:  System.Void EggHatchingWindowControllerV2::与丐上且丆业丒上东());
            val_3.animator.GetComponent<EggModelEventHandler>().remove_OnOpened(丙业与丙丗丝不丈东:  val_5);
            EggIncubator3dController val_6 = this.丁一丆业丅不丌丟丆.GetComponent<EggIncubator3dController>();
        }
        
        this.petCardAnimation.SetBool(name:  "Start", value:  true);
        val_10 = null;
        val_10 = null;
        val_11 = EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄;
        if(val_11 != null)
        {
                val_11 = EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄;
            if(val_11 == null)
        {
                val_11 = 0;
        }
        
            val_11.Invoke();
        }
        
        if(this.quad == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.quad, 丏业丟一东丂东丘丛:  true);
    }
    private void 丄且丐且丝世丆七丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        UnityEngine.GameObject val_4;
        var val_5;
        var val_6;
        System.Action val_7;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(EggHatchingWindowControllerV2.丕丑东丈丈世七丘不 < 2)
        {
            goto label_3;
        }
        
        if(EggHatchingWindowControllerV2.丕丑东丈丈世七丘不 != 2)
        {
            goto label_4;
        }
        
        this.petCardAnimation.SetBool(name:  "Get", value:  true);
        return;
        label_3:
        this.petCardAnimation.SetBool(name:  "Skip", value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丁一丆业丅不丌丟丆, 丏业丟一东丂东丘丛:  false);
        if(this.quad != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.quad, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.quadInstantly != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.quadInstantly, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.tapToClose != 0)
        {
                val_4 = this.tapToClose;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        }
        
        val_6 = null;
        val_6 = null;
        EggHatchingWindowControllerV2.丕丑东丈丈世七丘不 = 2;
        val_7 = EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄;
        if(val_7 == null)
        {
                return;
        }
        
        val_7 = EggHatchingWindowControllerV2.丟专万丆丄丈东丆丄;
        if(val_7 == null)
        {
                val_7 = 0;
        }
        
        val_7.Invoke();
        return;
        label_4:
        UnityEngine.Debug.LogError(message:  "Unknown state EggHacthing");
    }
    private void OnDisable()
    {
        var val_9;
        System.EventHandler val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        System.Action val_15;
        val_9 = null;
        val_9 = null;
        val_10 = 1152921504848912384;
        if(EggHatchingWindowControllerV2.丅丑丟丛一万丅丆丗 != 0)
        {
                val_11 = null;
            val_11 = null;
            if(EggHatchingWindowControllerV2.丅丑丟丛一万丅丆丗.petCardAnimation != 0)
        {
                val_12 = null;
            val_12 = null;
            if(gameObject != 0)
        {
                val_13 = null;
            val_13 = null;
            Rilisoft.ButtonHandler val_6 = gameObject.GetComponent<Rilisoft.ButtonHandler>();
            if(val_6 != 0)
        {
                System.EventHandler val_8 = null;
            val_10 = val_8;
            val_8 = new System.EventHandler(object:  this, method:  System.Void EggHatchingWindowControllerV2::丄且丐且丝世丆七丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_6.remove_Clicked(丙业与丙丗丝不丈东:  val_8);
        }
        
        }
        
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = EggHatchingWindowControllerV2.东丌丄东丗丑东丈丕;
        if(val_15 == null)
        {
                return;
        }
        
        val_15 = EggHatchingWindowControllerV2.东丌丄东丗丑东丈丕;
        if(val_15 == null)
        {
                val_15 = 0;
        }
        
        val_15.Invoke();
    }
    public EggHatchingWindowControllerV2()
    {
    
    }
    private static EggHatchingWindowControllerV2()
    {
    
    }

}
