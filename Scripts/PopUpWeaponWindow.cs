using UnityEngine;
internal sealed class PopUpWeaponWindow : PGBehaviour
{
    // Fields
    private UIScrollView scrollView;
    private ScrollViewHelper scrollViewHelper;
    private UnityEngine.GameObject popUpObject;
    private System.Collections.Generic.List<世丂丈世且万世丞上> currentWeaponBonuses;
    private UnityEngine.GameObject weaponsListGameObject;
    private WidgetLayout oneWeaponUiWidgetLayout;
    private System.Collections.Generic.List<PopUpOneWeaponUI> oneWeaponUiList;
    private bool 丁与万丂丝丒丐万丄;
    internal TouchButton openCloseTouchButton;
    private UnityEngine.GameObject openWeaponIcon;
    private UnityEngine.GameObject closeWeaponIcon;
    private UnityEngine.GameObject notificationWeaponCountObject;
    private UILabel weaponCountLabel;
    private TweenAlpha tweenAlphaForPanel;
    private bool 下丙丆丏丈三与丛丈;
    private bool 七丕丌丟丑丑丂丙东;
    private int 丗丌丏丁丆东丏三且;
    private bool 不丒下三与上丙丟七;
    private int 上丙七万丌丒丐丗丑;
    private System.Collections.Generic.Dictionary<int, float> timeTouch;
    private float deltaTouchTime;
    
    // Properties
    internal bool 万丟丑丈丟丌丘丂东 { get; }
    
    // Methods
    internal bool 丐丗与丁七下丕世丈()
    {
        var val_3;
        if(this.weaponsListGameObject.activeInHierarchy != false)
        {
                var val_2 = (this.丁与万丂丝丒丐万丄 == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    private void Start()
    {
        System.Action val_6;
        this.openCloseTouchButton.onClick = 0;
        val_6 = System.Delegate.Combine(a:  this.openCloseTouchButton.onClick, b:  new System.Action(object:  this, method:  System.Void PopUpWeaponWindow::丏与丟一东丈丈业丘()));
        if(this.openCloseTouchButton == null)
        {
            goto label_3;
        }
        
        if(val_6 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_6 == null)
        {
            goto label_7;
        }
        
        label_4:
        if(null != null)
        {
                val_6 = 0;
        }
        
        label_7:
        this.openCloseTouchButton.onClick = val_6;
        this.丐丑丈丁七丐丘与万();
        this.丐丝丌丛业丑丞且上();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.世一丝一专一丁丏与());
    }
    private void 丐丝丌丛业丑丞且上()
    {
        this.丁与万丂丝丒丐万丄 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openWeaponIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.closeWeaponIcon, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponsListGameObject, 丏业丟一东丂东丘丛:  true);
    }
    private System.Collections.IEnumerator 世一丝一专一丁丏与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PopUpWeaponWindow.东三丒丞且业丟丂上();
    }
    internal void 与丏丅丑丙丑万三丝()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.世一丝一专一丁丏与());
    }
    internal bool 下下世丙丟丅丐丞丒(UnityEngine.Vector2 丟下丙丆不东一与丅)
    {
        float val_12;
        UnityEngine.Object val_13;
        var val_14;
        var val_15;
        val_12 = 丟下丙丆不东一与丅.y;
        val_13 = this.weaponsListGameObject.GetComponent<UIPanel>();
        if(val_13 != 0)
        {
                val_14 = null;
            val_14 = null;
            UnityEngine.Vector3 val_4 = this.weaponsListGameObject.transform.position;
            UnityEngine.Vector3 val_5 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = V12.16B});
            val_13 = val_13;
            UnityEngine.Vector3 val_7 = UICamera.currentCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = V15.16B});
            val_12 = val_7.y;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_12, z = val_7.z});
            float val_12 = 0.5f;
            val_12 = val_5.x - (val_8.x * val_12);
            float val_11 = val_5.y - (val_8.y * val_12);
        }
        else
        {
                val_15 = 0;
        }
        
        val_15 = val_15 & 1;
        return (bool)val_15;
    }
    private void Update()
    {
        this.丝丅丈万丘专丒丗且();
        this.丐丙一丝与丌一丘下();
        this.丞上世丈丂丟不世一();
        if(this.不丒下三与上丙丟七 != false)
        {
                if(activeInHierarchy != true)
        {
                this.七丄与且且丈不一万();
            this.不丒下三与上丙丟七 = false;
        }
        
        }
        
        if(this.scrollView.verticalScrollBar == null)
        {
            
        }
    
    }
    private void 丞上世丈丂丟不世一()
    {
        UnityEngine.GameObject val_6;
        var val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.weaponsListGameObject, 丏业丟一东丂东丘丛:  (this.丁与万丂丝丒丐万丄 == true) ? 1 : 0);
        var val_5 = (this.currentWeaponBonuses.Count < 1) ? 1 : 0;
        val_5 = activeInHierarchy | val_5;
        val_5 = isWorldMapOpened | val_5;
        if(val_5 != false)
        {
                val_6 = this.popUpObject;
            val_7 = 0;
        }
        else
        {
                val_7 = 1;
            val_6 = this.popUpObject;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
    }
    internal bool 丂下丗丛丂丄业业业(世丂丈世且万世丞上 丆丗上丗丆丑丘一丞)
    {
        System.Collections.Generic.List<世丂丈世且万世丞上> val_8;
        .丆丗上丗丆丑丘一丞 = 丆丗上丗丆丑丘一丞;
        val_8 = this.currentWeaponBonuses;
        if(val_8.Count > 20)
        {
                return false;
        }
        
        this.不丒下三与上丙丟七 = true;
        this.专不丄一丂丏丄丙丏();
        val_8 = (PopUpWeaponWindow.丐丐七丈丅丐三且丆)[1152921536412822624].丆丗上丗丆丑丘一丞;
        if((val_8 & 1) != 0)
        {
                return false;
        }
        
        val_8 = (PopUpWeaponWindow.丐丐七丈丅丐三且丆)[1152921536412822624].丆丗上丗丆丑丘一丞;
        var val_9 = 0;
        val_9 = val_9 + 1;
        if(val_8.AlreadyHaveThisWeapon() != true)
        {
                if((this.丗业丕丟丈丁丏丂丅() == false) || (PopUpWeaponWindow.丑三丟丈丅与丒丛丆() < 1))
        {
            goto label_13;
        }
        
        }
        
        this.三下丗万丆专丄且东(丗丌丅丒世专丕一丑:  (PopUpWeaponWindow.丐丐七丈丅丐三且丆)[1152921536412822624].丆丗上丗丆丑丘一丞);
        return false;
        label_13:
        val_8 = this.currentWeaponBonuses;
        if((val_8.Find(match:  new System.Predicate<世丂丈世且万世丞上>(object:  new PopUpWeaponWindow.丐丐七丈丅丐三且丆(), method:  System.Boolean PopUpWeaponWindow.丐丐七丈丅丐三且丆::丕丑丞上专七丆丅丏(世丂丈世且万世丞上 三丟东丕丄丄下下丑)))) != null)
        {
                return false;
        }
        
        this.currentWeaponBonuses.Add(item:  (PopUpWeaponWindow.丐丐七丈丅丐三且丆)[1152921536412822624].丆丗上丗丆丑丘一丞);
        return false;
    }
    internal void 丂丟丗丗三不丁丏上(世丂丈世且万世丞上 丆丗上丗丆丑丘一丞, bool 丁丈丝上丐且丘且专 = False)
    {
        object val_7;
        PopUpWeaponWindow.世丘丛上丞丆丟丟丐 val_1 = null;
        val_7 = val_1;
        val_1 = new PopUpWeaponWindow.世丘丛上丞丆丟丟丐();
        .丆丗上丗丆丑丘一丞 = 丆丗上丗丆丑丘一丞;
        this.不丒下三与上丙丟七 = true;
        this.专不丄一丂丏丄丙丏();
        if(((PopUpWeaponWindow.世丘丛上丞丆丟丟丐)[1152921536413018608].丆丗上丗丆丑丘一丞 & 1) != 0)
        {
                return;
        }
        
        val_7 = this.currentWeaponBonuses.Find(match:  new System.Predicate<世丂丈世且万世丞上>(object:  val_1, method:  System.Boolean PopUpWeaponWindow.世丘丛上丞丆丟丟丐::七一丛丝上丙丞东丛(世丂丈世且万世丞上 三丟东丕丄丄下下丑)));
        if(val_7 != null)
        {
                bool val_4 = this.currentWeaponBonuses.Remove(item:  val_7);
        }
        
        if(丁丈丝上丐且丘且专 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丐丁且丗三万丁丒丒());
    }
    private System.Collections.IEnumerator 丐丁且丗三万丁丒丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PopUpWeaponWindow.丑一丒业丟世丕丄一();
    }
    private void 专不丄一丂丏丄丙丏()
    {
        System.Collections.Generic.List<世丂丈世且万世丞上> val_3;
        System.Collections.Generic.List<世丂丈世且万世丞上> val_3 = this.currentWeaponBonuses;
        val_3 = val_3.Count - 1;
        if((val_3 & 2147483648) != 0)
        {
                return;
        }
        
        do
        {
            val_3 = this.currentWeaponBonuses.Item[val_3];
            if((val_3 & 1) != 0)
        {
                val_3 = this.currentWeaponBonuses;
            val_3.RemoveAt(index:  val_3);
        }
        
            val_3 = val_3 - 1;
        }
        while((val_3 & 2147483648) == 0);
    
    }
    private void 七丄与且且丈不一万()
    {
        ScrollViewHelper val_7;
        int val_8;
        int val_9;
        val_7 = this;
        this.一丗下丆万丛一丌不();
        this.丐丑丈丁七丐丘与万();
        val_8 = this.oneWeaponUiList.Count;
        int val_3 = UnityEngine.Mathf.Min(a:  this.currentWeaponBonuses.Count, b:  val_8);
        if(val_3 >= 4)
        {
            goto label_5;
        }
        
        if((val_3 - 1) > 1)
        {
            goto label_6;
        }
        
        this.scrollViewHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        this.scrollView.disableDragIfFits = true;
        val_8 = this.scrollView.verticalScrollBar;
        val_8.enabled = false;
        val_9 = this.丗丌丏丁丆东丏三且;
        goto label_20;
        label_5:
        val_8 = this.scrollView.verticalScrollBar;
        float val_5 = val_8.value;
        val_9 = val_7;
        val_5 = val_5 * (float)this.丗丌丏丁丆东丏三且;
        if(val_5 < ((float)val_3 - 1))
        {
            goto label_20;
        }
        
        this.scrollView.verticalScrollBar.enabled = true;
        val_8 = this.scrollView;
        this.scrollView.disableDragIfFits = false;
        val_7 = this.scrollViewHelper;
        val_7.ScrollToEnd(丌与丟丁万丝丞丄丏:  false);
        goto label_20;
        label_6:
        val_9 = val_7;
        if(this.丗丌丏丁丆东丏三且 < val_3)
        {
                this.scrollView.disableDragIfFits = false;
            val_8 = this.scrollView.verticalScrollBar;
            val_8.enabled = true;
            val_7 = this.scrollViewHelper;
            val_7.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        }
        
        label_20:
        this.丗丌丏丁丆东丏三且 = val_3;
    }
    private void 一丗下丆万丛一丌不()
    {
        世丂丈世且万世丞上 val_22;
        var val_23;
        int val_25;
        val_22 = 1152921536412583952;
        this.weaponCountLabel.text = this.currentWeaponBonuses.Count.ToString();
        val_23 = null;
        val_23 = null;
        if((PopUpWeaponWindow.<>c.<>9__33_0) == null)
        {
            goto label_5;
        }
        
        label_51:
        this.currentWeaponBonuses.Sort(comparison:  PopUpWeaponWindow.<>c.<>9__33_0);
        val_25 = this.currentWeaponBonuses.Count;
        goto label_8;
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.oneWeaponUiList.Item[val_25], 丏业丟一东丂东丘丛:  false);
        val_25 = val_25 + 1;
        label_8:
        if(val_25 < this.oneWeaponUiList.Count)
        {
            goto label_13;
        }
        
        int val_8 = UnityEngine.Mathf.Min(a:  this.currentWeaponBonuses.Count, b:  this.oneWeaponUiList.Count);
        if(val_8 >= 1)
        {
                var val_29 = 0;
            do
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.oneWeaponUiList.Item[0], 丏业丟一东丂东丘丛:  true);
            val_22 = this.currentWeaponBonuses.Item[0];
            this.oneWeaponUiList.Item[0].丝丈丞丂东丟东丘丌(丌且丗丌丝丐下东丘:  val_22);
            if(this.isActiveAndEnabled != false)
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            int val_15 = this.currentWeaponBonuses.Item[0].GetCurrentAmmoInClip();
            int val_27 = this.currentWeaponBonuses.Item[0];
            var val_26 = 0;
            val_26 = val_26 + 1;
            int val_18 = val_27.GetCurrentAmmoInBackpack();
            val_27 = (val_18 == 1) ? (val_15) : (val_18);
            var val_28 = 0;
            val_28 = val_28 + 1;
            this.oneWeaponUiList.Item[0].InitAmmoAmount(丅丕丟丙七下丘丏丁:  val_15, 万东丕丈一专三上丁:  val_27, 丐丙东丏丂业与业丂:  this.currentWeaponBonuses.Item[0].IsGadget());
        }
        
            val_29 = val_29 + 1;
        }
        while(val_29 != val_8);
        
        }
        
        this.丐丑丈丁七丐丘与万();
        this.oneWeaponUiWidgetLayout.Reposition();
        this.丗丌丏丁丆东丏三且 = val_8;
        return;
        label_5:
        PopUpWeaponWindow.<>c.<>9__33_0 = new System.Comparison<世丂丈世且万世丞上>(object:  PopUpWeaponWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PopUpWeaponWindow.<>c::专丟且且丂丝业丂东(世丂丈世且万世丞上 丂七丈东不丒专下上, 世丂丈世且万世丞上 七丙一丂丐丕三上丒));
        if(this.currentWeaponBonuses != null)
        {
            goto label_51;
        }
        
        goto label_51;
    }
    private void 三下丗万丆专丄且东(世丂丈世且万世丞上 丗丌丅丒世专丕一丑)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        丗丌丅丒世专丕一丑.AddWeaponToPlayer();
    }
    private void 丏与丟一东丈丈业丘()
    {
        bool val_1 = (this.丁与万丂丝丒丐万丄 == false) ? 1 : 0;
        bool val_3 = (this.丁与万丂丝丒丐万丄 == true) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notificationWeaponCountObject.gameObject, 丏业丟一东丂东丘丛:  val_3);
        this.丁与万丂丝丒丐万丄 = val_1;
        this.丐丑丈丁七丐丘与万();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openWeaponIcon, 丏业丟一东丂东丘丛:  val_3);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.closeWeaponIcon, 丏业丟一东丂东丘丛:  val_1);
    }
    private bool 丗业丕丟丈丁丏丂丅()
    {
        if(this.丁与万丂丝丒丐万丄 == false)
        {
                return false;
        }
        
        return 丟丌丁且且世丈丈丟.东七丟丕且一丗丅一();
    }
    private void 丐丑丈丁七丐丘与万()
    {
        var val_10;
        if(this.丗业丕丟丈丁丏丂丅() == false)
        {
            goto label_5;
        }
        
        val_10 = UnityEngine.Mathf.Min(a:  PopUpWeaponWindow.丑三丟丈丅与丒丛丆(), b:  UnityEngine.Mathf.Min(a:  this.currentWeaponBonuses.Count, b:  this.oneWeaponUiList.Count));
        if(val_10 < 1)
        {
            goto label_13;
        }
        
        var val_10 = 0;
        do
        {
            this.oneWeaponUiList.Item[0].StartAutoEquipped();
            val_10 = val_10 + 1;
        }
        while(val_10 != val_10);
        
        goto label_13;
        label_5:
        val_10 = 0;
        goto label_13;
        label_17:
        this.oneWeaponUiList.Item[0].StopAutoEquipped();
        val_10 = 1;
        label_13:
        if(val_10 < this.oneWeaponUiList.Count)
        {
            goto label_17;
        }
    
    }
    private static int 丑三丟丈丅与丒丛丆()
    {
        null = null;
        int val_3 = typeof(Player_move_c).__il2cppRuntimeField_538.Count;
        int val_5 = WeaponManager.丂丐丛业世丝丁丛丕;
        val_5 = val_5 - (val_3 + WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count);
        val_3 = val_5 & (~(val_5 >> 31));
        return (int)val_3;
    }
    private void 丝丅丈万丘专丒丗且()
    {
        var val_13;
        var val_14;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_13 = 0;
        val_14 = 0;
        val_17 = null;
        val_17 = null;
        val_18 = null;
        val_18 = null;
        if(isPressed == true)
        {
            goto label_19;
        }
        
        val_19 = null;
        val_19 = null;
        if(isPressed == false)
        {
            goto label_24;
        }
        
        label_19:
        if(this != null)
        {
            goto label_53;
        }
        
        label_54:
        label_53:
        this.七丕丌丟丑丑丂丙东 = true;
        this.丟七丆丏丛丈丟下丝();
        return;
        label_24:
        val_20 = null;
        val_20 = null;
        var val_5 = (typeof(Player_move_c).__il2cppRuntimeField_57D != 0) ? 1 : 0;
        val_5 = (( == true) ? 1 : 0) | val_5;
        val_21 = null;
        val_21 = null;
        if(isPressed == true)
        {
            goto label_45;
        }
        
        val_22 = null;
        val_22 = null;
        if(isPressed == true)
        {
            goto label_45;
        }
        
        val_23 = null;
        val_23 = null;
        if(isPressed == true)
        {
            goto label_45;
        }
        
        val_24 = null;
        val_24 = null;
        if(isPressed == false)
        {
            goto label_50;
        }
        
        label_45:
        if(this != null)
        {
            goto label_53;
        }
        
        goto label_54;
        label_50:
        bool val_11 = this.丝丗上一不下丕专丆();
        if(this != null)
        {
            goto label_53;
        }
        
        goto label_54;
    }
    private void 丟七丆丏丛丈丟下丝()
    {
        if(((this.下丙丆丏丈三与丛丈 == true) ? 1 : 0) == ((this.七丕丌丟丑丑丂丙东 == true) ? 1 : 0))
        {
                return;
        }
        
        this.下丙丆丏丈三与丛丈 = this.七丕丌丟丑丑丂丙东;
        if(this.tweenAlphaForPanel == null)
        {
            goto label_1;
        }
        
        if(this.七丕丌丟丑丑丂丙东 == false)
        {
            goto label_2;
        }
        
        label_3:
        this.tweenAlphaForPanel.PlayReverse();
        return;
        label_1:
        if(this.七丕丌丟丑丑丂丙东 == true)
        {
            goto label_3;
        }
        
        label_2:
        this.tweenAlphaForPanel.PlayForward();
    }
    internal void 东丐丟丂丝上丞丁丅()
    {
        this.不丒下三与上丙丟七 = true;
    }
    private void 丐丙一丝与丌一丘下()
    {
        InGameGUI val_13;
        int val_1 = UnityEngine.Input.touchCount;
        if(val_1 < 1)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_13 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_13.isWorldMapOpened == true)
        {
                return;
        }
        
        }
        
        var val_13 = 0;
        var val_14 = 32;
        label_21:
        int val_5 = UnityEngine.Input.touches[val_14].丙东专丂世丈丏丁丂();
        int val_8 = UnityEngine.Input.touches[val_14].专三三与三且一且一();
        if((this.timeTouch.ContainsKey(key:  val_5)) == false)
        {
            goto label_12;
        }
        
        if(val_8 == 3)
        {
            goto label_13;
        }
        
        val_13 = UnityEngine.Input.touches;
        if(val_13[val_14].专三三与三且一且一() != 4)
        {
            goto label_19;
        }
        
        label_13:
        val_13 = this.timeTouch;
        bool val_11 = val_13.Remove(key:  val_5);
        goto label_19;
        label_12:
        if(val_8 == 0)
        {
                val_13 = this.timeTouch;
            val_13.Add(key:  val_5, value:  UnityEngine.Time.time);
        }
        
        label_19:
        val_13 = val_13 + 1;
        val_14 = val_14 + 68;
        if(val_13 < (long)val_1)
        {
            goto label_21;
        }
    
    }
    private bool 丝丗上一不下丕专丆()
    {
        var val_2;
        float val_3;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.timeTouch.GetEnumerator();
        label_5:
        if((1743724320 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_2.丐丏七丌丕丗业且上();
        if((System.Math.Abs(val_3 - UnityEngine.Time.time)) <= this.deltaTouchTime)
        {
            goto label_5;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = JoystickController.丘万丏三丏丑世丐丏.HasTouchFinger;
        val_10 = 1;
        goto label_9;
        label_2:
        val_10 = 0;
        val_9 = 0;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_11 = val_10 & val_9;
        return (bool)val_11;
    }
    public PopUpWeaponWindow()
    {
        this.currentWeaponBonuses = new System.Collections.Generic.List<世丂丈世且万世丞上>();
        this.丗丌丏丁丆东丏三且 = 0;
        this.上丙七万丌丒丐丗丑 = 0;
        this.timeTouch = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        this.deltaTouchTime = 0.3f;
    }

}
