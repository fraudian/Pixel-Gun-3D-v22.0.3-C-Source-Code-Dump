using UnityEngine;
public class ClanWarMapUI : MonoBehaviour
{
    // Fields
    private static System.Action<UnityEngine.Vector2> 丛不丈丄丙世丁丂丑;
    private static System.Action<bool> 丈丏丂丗丕丞丑上丑;
    public ClanWarUI clanWarUI;
    public UIWidget widget;
    private System.Nullable<DiscreteVector2> 丅丗一丟丅丒丈世世;
    private bool 丘万丟丐三不丏丈丏;
    
    // Methods
    public static void add_onDrag(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ClanWarMapUI.丛不丈丄丙世丁丂丑, b:  丙业与丙丗丝不丈东);
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
    public static void remove_onDrag(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ClanWarMapUI.丛不丈丄丙世丁丂丑, value:  丙业与丙丗丝不丈东);
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
    public static void add_onPress(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  ClanWarMapUI.丈丏丂丗丕丞丑上丑, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(ClanWarMapUI.丈丏丂丗丕丞丑上丑 != 1152921505158393864);
    
    }
    public static void remove_onPress(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  ClanWarMapUI.丈丏丂丗丕丞丑上丑, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(ClanWarMapUI.丈丏丂丗丕丞丑上丑 != 1152921505158393864);
    
    }
    private void OnEnable()
    {
        Rilisoft.Singleton<TouchManager>.Instance.add_onTouchBegan(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Touch>(object:  this, method:  System.Void ClanWarMapUI::三丘上三与且丅丄丗(UnityEngine.Touch 丟下丙丆不东一与丅)));
    }
    private void OnDisable()
    {
        Rilisoft.Singleton<TouchManager>.Instance.remove_onTouchBegan(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Touch>(object:  this, method:  System.Void ClanWarMapUI::三丘上三与且丅丄丗(UnityEngine.Touch 丟下丙丆不东一与丅)));
    }
    public void SetBottomAnchor(int 丙业与丙丗丝不丈东)
    {
        mem2[0] = 丙业与丙丗丝不丈东;
    }
    private void 三丘上三与且丅丄丗(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        if((Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Count) < 2)
        {
                return;
        }
        
        mem[1152921536815422000] = 0;
        this.丅丗一丟丅丒丈世世 = 0;
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        GamepadCursorController val_10;
        bool val_11;
        float val_15;
        float val_16;
        float val_17;
        bool val_18;
        val_11 = 万东丂丒且丅丛丑丕;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_15 = val_1.x;
        val_16 = val_1.y;
        val_17 = val_1.z;
        if(GamepadCursorController.丂业丗业世世丛丟七() != false)
        {
                val_10 = GamepadCursorController.丆丕丝丒不丙且丐丗;
            if(val_10 != 0)
        {
                val_10 = GamepadCursorController.丆丕丝丒不丙且丐丗.丌丘丙丒丅丆三不东();
            if(val_10 != false)
        {
                val_18 = 0;
        }
        else
        {
                val_18 = this.丘万丟丐三不丏丈丏;
        }
        
            bool val_5 = val_10;
            val_18 = val_18 | val_5;
            if(val_18 != false)
        {
                this.丘万丟丐三不丏丈丏 = val_5;
            UnityEngine.Vector2 val_6 = GamepadCursorController.丆丕丝丒不丙且丐丗.丐东下丒丞七丂丟业();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_15 = val_7.x;
            val_16 = val_7.y;
            val_17 = val_7.z;
            val_11 = val_10;
        }
        
        }
        
        }
        
        if(ClanWarMapUI.丈丏丂丗丕丞丑上丑 != null)
        {
                ClanWarMapUI.丈丏丂丗丕丞丑上丑.Invoke(obj:  val_11);
        }
        
        this.三丘丏丅专丛丟业丞(万东丂丒且丅丛丑丕:  val_11, 一东且与下丞专丙上:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17});
    }
    private void 三丘丏丅专丛丟业丞(bool 万东丂丒且丅丛丑丕, UnityEngine.Vector3 一东且与下丞专丙上)
    {
        ClanWarUI val_16;
        ClanWarUI val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_26;
        float val_29;
        float val_30;
        val_16 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_20 = this.clanWarUI;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 一东且与下丞专丙上.x, y = 一东且与下丞专丙上.y, z = 一东且与下丞专丙上.z}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
        {
                val_21 = 一东且与下丞专丙上.x;
            val_22 = 一东且与下丞专丙上.y;
            val_23 = 一东且与下丞专丙上.z;
        }
        else
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            val_21 = val_3.x;
            val_22 = val_3.y;
            val_23 = val_3.z;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
        val_26 = val_4.y;
        System.Nullable<DiscreteVector2> val_5 = val_20.一上世下业丐业丟东(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_4.x, y = val_26});
        if(万东丂丒且丅丛丑丕 == false)
        {
            goto label_10;
        }
        
        if((Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Count) > 1)
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 一东且与下丞专丙上.x, y = 一东且与下丞专丙上.y, z = 一东且与下丞专丙上.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == false)
        {
            goto label_16;
        }
        
        val_29 = 一东且与下丞专丙上.x;
        val_30 = 一东且与下丞专丙上.y;
        goto label_19;
        label_10:
        this.clanWarUI.UnpressCell();
        if(( & 1) == 0)
        {
                return;
        }
        
        if((this.丅丗一丟丅丒丈世世 & 1) == 0)
        {
                return;
        }
        
        val_20 = ;
        if((DiscreteVector2.丌且丕丐丛上丅且丁(万且丂丘丌业七与丞:  new DiscreteVector2() {_x = 2144064992, _y = 268435463}, 丅专丌丅业与丏丞下:  new DiscreteVector2() {_x = this.丅丗一丟丅丒丈世世, _y = this.丅丗一丟丅丒丈世世})) == false)
        {
                return;
        }
        
        val_16 = this.clanWarUI;
        val_16.TrySelectCell(一东且与下丞专丙上:  new UnityEngine.Vector3() {x = 一东且与下丞专丙上.x, y = 一东且与下丞专丙上.y, z = 一东且与下丞专丙上.z});
        mem2[0] = 0;
        mem2[0] = 0;
        return;
        label_16:
        UnityEngine.Vector3 val_12 = UnityEngine.Input.mousePosition;
        val_29 = val_12.x;
        val_30 = val_12.y;
        label_19:
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_29, y = val_30, z = val_12.z});
        val_26 = val_13.y;
        System.Nullable<DiscreteVector2> val_14 = this.clanWarUI.一上世下业丐业丟东(专世丐丆丗丙万七下:  new UnityEngine.Vector2() {x = val_13.x, y = val_26});
        this.丅丗一丟丅丒丈世世 = val_14;
        mem[1152921536815695200] = 2143778880;
        label_13:
        if(( & 1) == 0)
        {
                return;
        }
        
        if((this.丅丗一丟丅丒丈世世 & 1) == 0)
        {
                return;
        }
        
        val_20 = ;
        if((DiscreteVector2.丌且丕丐丛上丅且丁(万且丂丘丌业七与丞:  new DiscreteVector2() {_x = 2144064992, _y = 268435463}, 丅专丌丅业与丏丞下:  new DiscreteVector2() {_x = this.丅丗一丟丅丒丈世世, _y = this.丅丗一丟丅丒丈世世})) == false)
        {
                return;
        }
        
        val_16 = this.clanWarUI;
        val_16.TryPressCell(一东且与下丞专丙上:  new UnityEngine.Vector3() {x = 一东且与下丞专丙上.x, y = 一东且与下丞专丙上.y, z = 一东且与下丞专丙上.z});
    }
    private void OnDrag(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        if((Rilisoft.Singleton<TouchManager>.Instance.CurrentTouches.Count) > 1)
        {
                return;
        }
        
        mem[1152921536815845088] = 0;
        this.丅丗一丟丅丒丈世世 = 0;
        if(ClanWarMapUI.丛不丈丄丙世丁丂丑 == null)
        {
                return;
        }
        
        ClanWarMapUI.丛不丈丄丙世丁丂丑.Invoke(obj:  new UnityEngine.Vector2() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y});
    }
    public ClanWarMapUI()
    {
    
    }

}
