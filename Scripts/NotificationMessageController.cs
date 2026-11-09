using UnityEngine;
internal class NotificationMessageController : Singleton<NotificationMessageController>
{
    // Fields
    private static System.Action<ClanNotificationType, NotificationResponseStruct> 世丘专丛万三丝丑丙;
    internal static NotificationResponseStruct 东万丛丅丌丈一丄下;
    internal static NotificationResponseStruct 一业丆丑丏丅丆与下;
    internal System.Collections.Generic.List<ClanNotificationType> 不七丙丑丑一东丙丕;
    internal 丂丆丈丂丏丄丝丈丞 丈万三业东三一丛丞;
    
    // Methods
    internal static void 丒丅丏七丈丗东与丗(System.Action<ClanNotificationType, NotificationResponseStruct> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  NotificationMessageController.世丘专丛万三丝丑丙, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal static void 丙一丈万丟丗丘丏三(System.Action<ClanNotificationType, NotificationResponseStruct> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  NotificationMessageController.世丘专丛万三丝丑丙, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    internal int 丅丅上丛万万丛与丐()
    {
        var val_8;
        if((((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null) || (this.丈万三业东三一丛丞 == null)) || (this.丈万三业东三一丛丞.三丛丁万且丌丘下丕 == null))
        {
            goto label_4;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = this.丈万三业东三一丛丞.三丛丁万且丌丘下丕.GetEnumerator();
        val_8 = 0;
        goto label_6;
        label_7:
        if(2 != 0)
        {
                var val_6 = ((0 & 255) != 0) ? (val_8 + 1) : (val_8);
        }
        
        label_6:
        if(((-352415288) & 1) != 0)
        {
            goto label_7;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_8;
        label_4:
        val_8 = 0;
        return (int)val_8;
    }
    private void Start()
    {
        this.丈万三业东三一丛丞 = new 丂丆丈丂丏丄丝丈丞();
        this.且丑与且丒丏七丝且();
    }
    private void OnEnable()
    {
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NotificationMessageController::下丅丝丝丟丌万丕丆()));
    }
    private void OnDisable()
    {
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void NotificationMessageController::下丅丝丝丟丌万丕丆()));
    }
    private void 下丅丝丝丟丌万丕丆()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == 0)
        {
                return;
        }
        
        this.丘丐丗丕丕丕丝丅上(丁丅丈丌丟世丗丗丟:  3, 丑与丂丌世丕丆一丗:  new NotificationResponseStruct() {hasNotif = ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄().Count) > 0) ? 1 : 0, counter = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄().Count, isViewd = false});
    }
    internal void 丘丐丗丕丕丕丝丅上(ClanNotificationType 丁丅丈丌丟世丗丗丟, NotificationResponseStruct 丑与丂丌世丕丆一丗)
    {
        this.丈万三业东三一丛丞.丄丄上且丛丒万丙七(业丄七丙丛上专专丕:  丁丅丈丌丟世丗丗丟, 丑与丂丌世丕丆一丗:  new System.Nullable<NotificationResponseStruct>() {HasValue = true});
        this.且丑与且丒丏七丝且();
    }
    internal void 下丌业业丐丘丐丘三(ClanNotificationType 丁丅丈丌丟世丗丗丟)
    {
        if((this.不七丙丑丑一东丙丕.Contains(item:  丁丅丈丌丟世丗丗丟)) != false)
        {
                return;
        }
        
        this.不七丙丑丑一东丙丕.Add(item:  丁丅丈丌丟世丗丗丟);
        this.且丑与且丒丏七丝且();
    }
    internal void 万不丒上丕丗丂丘丒(ClanNotificationType 丁丅丈丌丟世丗丗丟)
    {
        if((this.不七丙丑丑一东丙丕.Contains(item:  丁丅丈丌丟世丗丗丟)) == false)
        {
                return;
        }
        
        bool val_2 = this.不七丙丑丑一东丙丕.Remove(item:  丁丅丈丌丟世丗丗丟);
    }
    private void Update()
    {
        this.且丑与且丒丏七丝且();
    }
    private void 且丑与且丒丏七丝且()
    {
        var val_4;
        var val_12;
        var val_13;
        var val_14;
        System.Func<System.Collections.Generic.KeyValuePair<ClanNotificationType, NotificationResponseStruct>, System.Boolean> val_16;
        var val_17;
        var val_18;
        var val_19;
        val_12 = this;
        if(this.不七丙丑丑一东丙丕.Count < 1)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        if(NotificationMessageController.世丘专丛万三丝丑丙 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this.不七丙丑丑一东丙丕.GetEnumerator();
        label_30:
        if(((-351158496) & 1) == 0)
        {
            goto label_7;
        }
        
        int val_5 = val_4.丙东专丂世丈丏丁丂();
        if(val_5 != 9)
        {
            goto label_8;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = NotificationMessageController.<>c.<>9__16_0;
        if(val_16 == null)
        {
                val_16 = null;
            val_16 = new System.Func<System.Collections.Generic.KeyValuePair<ClanNotificationType, NotificationResponseStruct>, System.Boolean>(object:  NotificationMessageController.<>c.__il2cppRuntimeField_static_fields, method:  0);
            NotificationMessageController.<>c.<>9__16_0 = val_16;
        }
        
        if(((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<ClanNotificationType, NotificationResponseStruct>>(source:  this.丈万三业东三一丛丞.三丛丁万且丌丘下丕, predicate:  null)) == false) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
        {
            goto label_17;
        }
        
        val_17 = null;
        val_17 = null;
        NotificationMessageController.世丘专丛万三丝丑丙.Invoke(arg1:  9, arg2:  new NotificationResponseStruct() {hasNotif = NotificationMessageController.东万丛丅丌丈一丄下, counter = NotificationMessageController.东万丛丅丌丈一丄下, countOnView = NotificationMessageController.世丘专丛万三丝丑丙.__il2cppRuntimeField_10, isViewd = NotificationMessageController.世丘专丛万三丝丑丙.__il2cppRuntimeField_10});
        goto label_30;
        label_8:
        NotificationResponseStruct val_10 = this.丈万三业东三一丛丞.丘一丗丘一丙丛丌丕(业丄七丙丛上专专丕:  val_5);
        val_18 = null;
        val_18 = null;
        NotificationMessageController.世丘专丛万三丝丑丙.Invoke(arg1:  val_5, arg2:  new NotificationResponseStruct() {hasNotif = val_10.hasNotif, counter = val_10.counter, countOnView = val_10.countOnView, isViewd = val_10.isViewd});
        goto label_30;
        label_17:
        val_19 = null;
        val_19 = null;
        NotificationMessageController.世丘专丛万三丝丑丙.Invoke(arg1:  9, arg2:  new NotificationResponseStruct() {hasNotif = NotificationMessageController.一业丆丑丏丅丆与下, counter = NotificationMessageController.一业丆丑丏丅丆与下, countOnView = NotificationMessageController.世丘专丛万三丝丑丙.__il2cppRuntimeField_20, isViewd = NotificationMessageController.世丘专丛万三丝丑丙.__il2cppRuntimeField_20});
        goto label_30;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public NotificationMessageController()
    {
        this.不七丙丑丑一东丙丕 = new System.Collections.Generic.List<ClanNotificationType>();
    }
    private static NotificationMessageController()
    {
        NotificationMessageController.东万丛丅丌丈一丄下 = ;
        NotificationMessageController.一业丆丑丏丅丆与下 = ;
    }

}
