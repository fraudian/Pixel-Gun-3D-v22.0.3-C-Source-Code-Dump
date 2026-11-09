using UnityEngine;
[Serializable]
public class EventDelegate
{
    // Fields
    private UnityEngine.MonoBehaviour mTarget;
    private string mMethodName;
    private EventDelegate.Parameter[] mParameters;
    public bool oneShot;
    private EventDelegate.丒万业丛丏东专世丟 mCachedCallback;
    private bool mRawDelegate;
    private bool mCached;
    private System.Reflection.MethodInfo mMethod;
    private System.Reflection.ParameterInfo[] mParameterInfos;
    private object[] mArgs;
    private static int s_Hash;
    
    // Properties
    public UnityEngine.MonoBehaviour target { get; set; }
    public string methodName { get; set; }
    public EventDelegate.Parameter[] parameters { get; }
    public bool isValid { get; }
    public bool isEnabled { get; }
    
    // Methods
    public UnityEngine.MonoBehaviour get_target()
    {
        return (UnityEngine.MonoBehaviour)this.mTarget;
    }
    public void set_target(UnityEngine.MonoBehaviour 丙业与丙丗丝不丈东)
    {
        this.mTarget = 丙业与丙丗丝不丈东;
        this.mCachedCallback = 0;
        this.mRawDelegate = false;
        this.mCached = false;
        this.mParameters = 0;
        this.mMethod = 0;
        this.mParameterInfos = 0;
    }
    public string get_methodName()
    {
        return (string)this.mMethodName;
    }
    public void set_methodName(string 丙业与丙丗丝不丈东)
    {
        this.mCachedCallback = 0;
        this.mRawDelegate = false;
        this.mCached = false;
        this.mMethodName = 丙业与丙丗丝不丈东;
        this.mParameters = 0;
        this.mMethod = 0;
        this.mParameterInfos = 0;
    }
    public EventDelegate.Parameter[] get_parameters()
    {
        if(this.mCached == true)
        {
                return (Parameter[])this.mParameters;
        }
        
        this.丏万丟丙上丏丟万丑();
        return (Parameter[])this.mParameters;
    }
    public bool get_isValid()
    {
        var val_4;
        if(this.mCached != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if((this.mRawDelegate != false) && (this.mCachedCallback != null))
        {
                val_4 = 1;
            return (bool)val_4 & 1;
        }
        
        if(this.mTarget != 0)
        {
                val_4 = (System.String.IsNullOrEmpty(value:  this.mMethodName)) ^ 1;
            return (bool)val_4 & 1;
        }
        
        val_4 = 0;
        return (bool)val_4 & 1;
    }
    public bool get_isEnabled()
    {
        UnityEngine.MonoBehaviour val_3;
        var val_4;
        val_3 = this;
        if(this.mCached != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if(this.mRawDelegate != false)
        {
                if(this.mCachedCallback != null)
        {
            goto label_3;
        }
        
        }
        
        if(this.mTarget == 0)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        val_3 = this.mTarget;
        if(val_3 == 0)
        {
                label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        
        if(val_3 != null)
        {
                return val_3.enabled;
        }
        
        return val_3.enabled;
    }
    public EventDelegate()
    {
    
    }
    public EventDelegate(EventDelegate.丒万业丛丏东专世丟 丟丕丞丂一丙不丅丝)
    {
        this.丅专下万丕丑丆丅丝(丟丕丞丂一丙不丅丝:  丟丕丞丂一丙不丅丝);
    }
    public EventDelegate(UnityEngine.MonoBehaviour 丞下万上三丘上与专, string 丑与丆丝丕东丛丄丝)
    {
        val_1 = new System.Object();
        this.mRawDelegate = false;
        this.mCached = false;
        this.mCachedCallback = 0;
        this.mMethodName = val_1;
        this.mParameters = 0;
        this.mParameterInfos = 0;
        this.mArgs = 0;
        this.mMethod = 0;
        this.mTarget = 丞下万上三丘上与专;
    }
    private static string 业东七丁丏丝丟丞丘(EventDelegate.丒万业丛丏东专世丟 业丏丈世世世丞丒世)
    {
        if(业丏丈世世世丞丒世.Method == null)
        {
            
        }
    
    }
    private static bool 丑丕丈丈不不且丑且(EventDelegate.丒万业丛丏东专世丟 业丏丈世世世丞丒世)
    {
        if(业丏丈世世世丞丒世 == null)
        {
                return (bool)业丏丈世世世丞丒世;
        }
        
        return System.Reflection.MethodInfo.op_Inequality(left:  业丏丈世世世丞丒世.Method, right:  0);
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        UnityEngine.MonoBehaviour val_9;
        string val_10;
        string val_11;
        var val_12;
        if(万且万且丑丗且丌丆 == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        val_9 = this.mTarget;
        if(val_9 != X22)
        {
            goto label_17;
        }
        
        val_10 = this.mMethodName;
        return System.String.Equals(a:  val_10 = this.mMethodName, b:  val_11 = EventDelegate.业东七丁丏丝丟丞丘(业丏丈世世世丞丒世:  万且万且丑丗且丌丆));
        label_1:
        val_12 = this.isValid ^ 1;
        return (bool)val_12 & 1;
        label_2:
        if((万且万且丑丗且丌丆.Equals(obj:  this.mCachedCallback)) != false)
        {
                val_12 = 1;
            return (bool)val_12 & 1;
        }
        
        object val_4 = 万且万且丑丗且丌丆.Target;
        val_9 = 0;
        if(this.mTarget == )
        {
                return System.String.Equals(a:  val_10, b:  val_11);
        }
        
        label_17:
        val_12 = 0;
        return (bool)val_12 & 1;
    }
    public override int GetHashCode()
    {
        null = null;
        return (int)EventDelegate.s_Hash;
    }
    private void 丅专下万丕丑丆丅丝(EventDelegate.丒万业丛丏东专世丟 丟丕丞丂一丙不丅丝)
    {
        var val_6;
        this.mTarget = 0;
        mem[1152921531157076216] = 0;
        mem[1152921531157076208] = 0;
        mem[1152921531157076184] = 0;
        mem[1152921531157076192] = 0;
        mem[1152921531157076232] = 0;
        mem[1152921531157076240] = 0;
        mem[1152921531157076224] = 0;
        if(丟丕丞丂一丙不丅丝 == null)
        {
                return;
        }
        
        if((EventDelegate.丑丕丈丈不不且丑且(业丏丈世世世丞丒世:  丟丕丞丂一丙不丅丝)) == false)
        {
                return;
        }
        
        object val_2 = 丟丕丞丂一丙不丅丝.Target;
        val_6 = 0;
        mem[1152921531157076176] = ;
        if( == 0)
        {
                this.mCachedCallback = 丟丕丞丂一丙不丅丝;
            this.mRawDelegate = true;
            this.mMethodName = 0;
            return;
        }
        
        this.mMethodName = EventDelegate.业东七丁丏丝丟丞丘(业丏丈世世世丞丒世:  丟丕丞丂一丙不丅丝);
        this.mRawDelegate = false;
    }
    public void 丅专下万丕丑丆丅丝(UnityEngine.MonoBehaviour 丞下万上三丘上与专, string 丑与丆丝丕东丛丄丝)
    {
        this.mRawDelegate = false;
        this.mCached = false;
        this.mCachedCallback = 0;
        this.mMethodName = 丑与丆丝丕东丛丄丝;
        this.mParameters = 0;
        this.mParameterInfos = 0;
        this.mArgs = 0;
        this.mMethod = 0;
        this.mTarget = 丞下万上三丘上与专;
    }
    private void 丏万丟丙上丏丟万丑()
    {
        UnityEngine.MonoBehaviour val_27;
        var val_28;
        System.Type val_29;
        System.Object[] val_31;
        object val_32;
        object val_33;
        int val_34;
        int val_35;
        丒万业丛丏东专世丟 val_36;
        this.mCached = true;
        if(this.mRawDelegate == true)
        {
                return;
        }
        
        if(this.mCachedCallback == null)
        {
            goto label_2;
        }
        
        object val_1 = this.mCachedCallback.Target;
        val_27 = this;
        val_28 = 0;
        goto label_7;
        label_2:
        val_27 = this.mTarget;
        goto label_9;
        label_7:
        if( == this.mTarget)
        {
                if((System.String.op_Inequality(a:  EventDelegate.业东七丁丏丝丟丞丘(业丏丈世世世丞丒世:  this.mCachedCallback), b:  this.mMethodName)) == false)
        {
                return;
        }
        
        }
        
        label_9:
        if(this.mTarget == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mMethodName)) != false)
        {
                return;
        }
        
        this.mMethod = 0;
        val_29 = this.mTarget.GetType();
        goto label_22;
        label_30:
        System.Reflection.MethodInfo val_9 = val_29.GetMethod(name:  this.mMethodName, bindingAttr:  52);
        this.mMethod = val_9;
        if((System.Reflection.MethodInfo.op_Inequality(left:  val_9, right:  0)) == true)
        {
            goto label_20;
        }
        
        val_29 = val_29;
        label_22:
        if((System.Type.op_Inequality(left:  val_29, right:  0)) == true)
        {
            goto label_30;
        }
        
        label_20:
        if((System.Reflection.MethodInfo.op_Equality(left:  this.mMethod, right:  0)) == false)
        {
            goto label_31;
        }
        
        val_31 = new object[4];
        val_32 = "Could not find method \'";
        val_31[0] = val_32;
        val_31[1] = this.mMethodName;
        val_31[2] = "\' on ";
        val_33 = this.mTarget.GetType();
        val_34 = val_13.Length;
        goto label_45;
        label_31:
        if((System.Type.op_Inequality(left:  this.mMethod, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_49;
        }
        
        object[] val_17 = new object[4];
        val_31 = val_17;
        val_31[0] = this.mTarget.GetType();
        val_32 = ".";
        val_31[1] = val_32;
        val_31[2] = this.mMethodName;
        val_34 = val_17.Length;
        val_33 = " must have a \'void\' return type.";
        label_45:
        val_31[3] = val_33;
        UnityEngine.Debug.LogError(message:  +val_17, context:  this.mTarget);
        return;
        label_49:
        this.mParameterInfos = this.mMethod;
        if(null == null)
        {
            goto label_68;
        }
        
        this.mCachedCallback = 0;
        if(this.mParameters != null)
        {
                if(this.mParameters.Length == this.mParameterInfos.Length)
        {
            goto label_74;
        }
        
        }
        
        val_35 = this.mParameterInfos.Length;
        this.mParameters = new Parameter[0];
        if(val_20.Length >= 1)
        {
                var val_27 = 0;
            do
        {
            EventDelegate.Parameter val_22 = null;
            val_35 = 0;
            val_22 = new EventDelegate.Parameter();
            if((val_22 != null) && (val_22 == null))
        {
                val_35 = 0;
        }
        
            if(val_27 >= this.mParameters.Length)
        {
                val_35 = 0;
        }
        
            val_27 = val_27 + 1;
            this.mParameters[val_27] = val_22;
        }
        while((val_20.Length & 4294967295) != val_27);
        
        }
        
        label_74:
        if(this.mParameters.Length < 1)
        {
                return;
        }
        
        var val_30 = 0;
        do
        {
            if(val_30 >= this.mParameters.Length)
        {
                val_35 = 0;
        }
        
            Parameter val_28 = this.mParameters[val_30];
            if(val_30 >= this.mParameterInfos.Length)
        {
                val_35 = 0;
        }
        
            val_30 = val_30 + 1;
            this.mParameters[0x0][0].expectedType = this.mParameterInfos[val_30];
        }
        while((this.mParameters.Length & 4294967295) != val_30);
        
        return;
        label_68:
        if(((System.Delegate.CreateDelegate(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), target:  this.mTarget, method:  this.mMethodName)) != null) && (null != null))
        {
                val_36 = 0;
        }
        
        this.mCachedCallback = val_36;
        this.mArgs = 0;
        this.mParameters = 0;
    }
    public bool 丞丙东丌一三专丏不()
    {
        Parameter[] val_28;
        var val_29;
        string val_30;
        var val_32;
        object val_33;
        var val_34;
        object val_35;
        var val_36;
        if(this.mCached != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if(this.mCachedCallback != null)
        {
                this.mCachedCallback.Invoke();
            return true;
        }
        
        if((System.Reflection.MethodInfo.op_Inequality(left:  this.mMethod, right:  0)) == false)
        {
                return true;
        }
        
        val_28 = this.mParameters;
        if((val_28 == null) || (this.mParameters.Length == 0))
        {
            goto label_5;
        }
        
        if(this.mArgs != null)
        {
                if(this.mArgs.Length == this.mParameters.Length)
        {
            goto label_7;
        }
        
        }
        
        val_28 = this.mParameters;
        this.mArgs = new object[0];
        if(val_28 == null)
        {
            goto label_8;
        }
        
        label_7:
        if(this.mParameters.Length < 1)
        {
            goto label_9;
        }
        
        var val_30 = 0;
        label_19:
        object val_5 = this.mParameters[val_30].value;
        if(this.mArgs == null)
        {
            goto label_13;
        }
        
        if(val_5 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_5 == null)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        val_30 = val_30 + 1;
        this.mArgs[val_30] = val_5;
        if((this.mParameters.Length & 4294967295) != val_30)
        {
            goto label_19;
        }
        
        label_9:
        object val_6 = this.mMethod.Invoke(obj:  this.mTarget, parameters:  this.mArgs);
        label_91:
        int val_31 = this.mArgs.Length;
        if(val_31 < 1)
        {
                return true;
        }
        
        val_31 = val_31 & 4294967295;
        var val_36 = 4;
        label_38:
        var val_7 = val_36 - 4;
        if(this.mParameterInfos[0].IsIn != true)
        {
                if(this.mParameterInfos[0].IsOut == false)
        {
            goto label_30;
        }
        
        }
        
        this.mParameters[0].value = this.mArgs[0];
        label_30:
        this.mArgs[0] = 0;
        val_36 = val_36 + 1;
        if(((-val_31) + val_36) != 4)
        {
            goto label_38;
        }
        
        return true;
        label_5:
        object val_11 = this.mMethod.Invoke(obj:  this.mTarget, parameters:  0);
        return true;
        label_8:
        val_29 = 0;
        if((this.mParameters.Length & 4294967295) != 1)
        {
            goto label_43;
        }
        
        if((null & 1) == 0)
        {
            goto label_44;
        }
        
        if(this.mTarget == 0)
        {
                val_30 = this.mMethod;
            string val_13 = "Error calling " + val_30;
        }
        else
        {
                object[] val_14 = new object[4];
            val_14[0] = "Error calling ";
            val_32 = 0;
            System.Type val_15 = this.mTarget.GetType();
            if((val_15 != null) && (val_15 == null))
        {
                val_32 = 0;
        }
        
            if(val_14.Length <= 1)
        {
                val_32 = 0;
        }
        
            val_14[1] = val_15;
            if("." == null)
        {
                val_32 = 0;
        }
        
            if(val_14.Length <= 2)
        {
                val_32 = 0;
        }
        
            val_14[2] = ".";
            val_30 = 0;
            val_14[3] = this.mMethod;
        }
        
        string val_18 = +val_14(+val_14) + ": "(": ") + 1179403647(+val_14(+val_14) + ": "(": ") + 1179403647) + "\n  Expected: "("\n  Expected: ");
        if(this.mParameterInfos.Length == 0)
        {
            goto label_67;
        }
        
        val_33 = val_18 + this.mParameterInfos[0];
        val_34 = 1;
        goto label_70;
        label_75:
        val_33 = val_33 + ", " + this.mParameterInfos[1];
        val_34 = 2;
        label_70:
        if(val_34 < this.mParameterInfos.Length)
        {
            goto label_75;
        }
        
        goto label_76;
        label_67:
        val_33 = val_18 + "no arguments";
        label_76:
        string val_22 = val_33 + "\n  Received: "("\n  Received: ");
        if(this.mParameters.Length == 0)
        {
            goto label_78;
        }
        
        val_35 = val_22 + this.mParameters[0].type;
        val_36 = 1;
        goto label_82;
        label_87:
        val_35 = val_35 + ", " + this.mParameters[1].type;
        val_36 = 2;
        label_82:
        if(val_36 < this.mParameters.Length)
        {
            goto label_87;
        }
        
        goto label_88;
        label_78:
        val_35 = val_22 + "no arguments";
        label_88:
        UnityEngine.Debug.LogError(message:  val_35 + "\n");
        goto label_91;
        label_44:
        mem[8] = 1179403647;
        val_29 = 8;
        label_43:
    }
    public void 世业丒万丘丆专丘丐()
    {
        this.mRawDelegate = false;
        this.mCached = false;
        this.mCachedCallback = 0;
        this.mMethodName = 0;
        this.mParameters = 0;
        this.mTarget = 0;
        this.mParameterInfos = 0;
        this.mArgs = 0;
        this.mMethod = 0;
    }
    public override string ToString()
    {
        string val_8;
        if(this.mTarget == 0)
        {
                return (string)(this.mRawDelegate == true) ? "[delegate]" : 0;
        }
        
        val_8 = this.mTarget.GetType();
        int val_3 = val_8.LastIndexOf(value:  '.');
        if(val_3 >= 1)
        {
                val_8 = val_8.Substring(startIndex:  val_3 + 1);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mMethodName)) == false)
        {
                return val_8 + "/"("/") + this.mMethodName;
        }
        
        return val_8 + "/[delegate]"("/[delegate]");
    }
    public static void 丞丙东丌一三专丏不(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(丝丘丑业丛万丞丌丝 == null)
        {
                return;
        }
        
        val_10 = 1152921531104250576;
        if(丝丘丑业丛万丞丌丝.Count < 1)
        {
                return;
        }
        
        val_11 = 1152921531160346720;
        val_12 = 1152921531160347744;
        val_13 = 0;
        goto label_19;
        label_18:
        val_14 = public System.Int32 System.Collections.Generic.List<EventDelegate>::get_Count();
        val_13 = 1;
        goto label_4;
        label_19:
        EventDelegate val_5 = 丝丘丑业丛万丞丌丝.Item[0];
        if(val_5 == null)
        {
            goto label_18;
        }
        
        bool val_6 = val_5.丞丙东丌一三专丏不();
        if(val_13 >= 丝丘丑业丛万丞丌丝.Count)
        {
                return;
        }
        
        if(丝丘丑业丛万丞丌丝.Item[0] != val_5)
        {
            goto label_17;
        }
        
        if(val_5.oneShot == false)
        {
            goto label_18;
        }
        
        丝丘丑业丛万丞丌丝.RemoveAt(index:  0);
        label_17:
        val_14 = public System.Int32 System.Collections.Generic.List<EventDelegate>::get_Count();
        label_4:
        if(val_13 < 丝丘丑业丛万丞丌丝.Count)
        {
            goto label_19;
        }
    
    }
    public static bool 丑丕丈丈不不且丑且(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝)
    {
        if(丝丘丑业丛万丞丌丝 == null)
        {
                return false;
        }
        
        int val_1 = 丝丘丑业丛万丞丌丝.Count;
        if(val_1 < 1)
        {
                return false;
        }
        
        var val_4 = 0;
        do
        {
            EventDelegate val_2 = 丝丘丑业丛万丞丌丝.Item[0];
            if(val_2 != null)
        {
                if(val_2.isValid == true)
        {
                return false;
        }
        
        }
        
            val_4 = val_4 + 1;
        }
        while(val_4 < val_1);
        
        return false;
    }
    public static EventDelegate 丅专下万丕丑丆丅丝(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate.丒万业丛丏东专世丟 业丏丈世世世丞丒世)
    {
        EventDelegate val_2;
        if(丝丘丑业丛万丞丌丝 != null)
        {
                EventDelegate val_1 = null;
            val_2 = val_1;
            val_1 = new EventDelegate();
            val_1.丅专下万丕丑丆丅丝(丟丕丞丂一丙不丅丝:  业丏丈世世世丞丒世);
            丝丘丑业丛万丞丌丝.Clear();
            丝丘丑业丛万丞丌丝.Add(item:  val_1);
            return (EventDelegate)val_2;
        }
        
        val_2 = 0;
        return (EventDelegate)val_2;
    }
    public static void 丅专下万丕丑丆丅丝(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate 世不与丐万万丕丆万)
    {
        if(丝丘丑业丛万丞丌丝 == null)
        {
                return;
        }
        
        丝丘丑业丛万丞丌丝.Clear();
        丝丘丑业丛万丞丌丝.Add(item:  世不与丐万万丕丆万);
    }
    public static EventDelegate 业丏丗丐丂业东丂丗(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate.丒万业丛丏东专世丟 业丏丈世世世丞丒世)
    {
        return EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  丝丘丑业丛万丞丌丝, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丕万三专丕不七专丐:  false);
    }
    public static EventDelegate 业丏丗丐丂业东丂丗(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate.丒万业丛丏东专世丟 业丏丈世世世丞丒世, bool 丕万三专丕不七专丐)
    {
        EventDelegate val_5;
        if(丝丘丑业丛万丞丌丝 != null)
        {
                int val_1 = 丝丘丑业丛万丞丌丝.Count;
            if(val_1 >= 1)
        {
                var val_5 = 0;
            do
        {
            val_5 = 丝丘丑业丛万丞丌丝.Item[0];
            if(val_5 != null)
        {
                if((val_5 & 1) != 0)
        {
                return (EventDelegate)val_5;
        }
        
        }
        
            val_5 = val_5 + 1;
        }
        while(val_5 < val_1);
        
        }
        
            EventDelegate val_3 = null;
            val_5 = val_3;
            val_3 = new EventDelegate();
            val_3.丅专下万丕丑丆丅丝(丟丕丞丂一丙不丅丝:  业丏丈世世世丞丒世);
            .oneShot = 丕万三专丕不七专丐;
            丝丘丑业丛万丞丌丝.Add(item:  val_3);
            return (EventDelegate)val_5;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Attempting to add a callback to a list that\'s null");
        val_5 = 0;
        return (EventDelegate)val_5;
    }
    public static void 业丏丗丐丂业东丂丗(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate 丙不不丒丁丄丄与丛)
    {
        EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  丝丘丑业丛万丞丌丝, 丙不不丒丁丄丄与丛:  丙不不丒丁丄丄与丛, 丕万三专丕不七专丐:  (丙不不丒丁丄丄与丛.oneShot == true) ? 1 : 0);
    }
    public static void 业丏丗丐丂业东丂丗(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate 丙不不丒丁丄丄与丛, bool 丕万三专丕不七专丐)
    {
        bool val_11;
        UnityEngine.MonoBehaviour val_12;
        val_11 = 丕万三专丕不七专丐;
        if(丙不不丒丁丄丄与丛.mRawDelegate != true)
        {
                if(丙不不丒丁丄丄与丛.mTarget != 0)
        {
                if((System.String.IsNullOrEmpty(value:  丙不不丒丁丄丄与丛.mMethodName)) == false)
        {
            goto label_6;
        }
        
        }
        
        }
        
        EventDelegate val_4 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  丝丘丑业丛万丞丌丝, 业丏丈世世世丞丒世:  丙不不丒丁丄丄与丛.mCachedCallback, 丕万三专丕不七专丐:  val_11);
        return;
        label_6:
        if(丝丘丑业丛万丞丌丝 == null)
        {
            goto label_9;
        }
        
        int val_5 = 丝丘丑业丛万丞丌丝.Count;
        if(val_5 >= 1)
        {
                var val_11 = 0;
            do
        {
            EventDelegate val_6 = 丝丘丑业丛万丞丌丝.Item[0];
            if(val_6 != null)
        {
                if((val_6 & 1) != 0)
        {
                return;
        }
        
        }
        
            val_11 = val_11 + 1;
        }
        while(val_11 < val_5);
        
        }
        
        if(丙不不丒丁丄丄与丛 == null)
        {
            goto label_14;
        }
        
        val_12 = 丙不不丒丁丄丄与丛.mTarget;
        goto label_15;
        label_9:
        UnityEngine.Debug.LogWarning(message:  "Attempting to add a callback to a list that\'s null");
        return;
        label_14:
        val_12 = 丙不不丒丁丄丄与丛.mTarget;
        label_15:
        .mRawDelegate = false;
        .mCached = false;
        .mCachedCallback = 0;
        .mMethodName = 丙不不丒丁丄丄与丛.mMethodName;
        .mParameters = 0;
        .mParameterInfos = 0;
        .mArgs = 0;
        .mMethod = 0;
        .mTarget = val_12;
        .oneShot = val_11;
        if((丙不不丒丁丄丄与丛.mParameters == null) || (丙不不丒丁丄丄与丛.mParameters.Length == 0))
        {
            goto label_20;
        }
        
        int val_9 = 丙不不丒丁丄丄与丛.mParameters.Length & 4294967295;
        val_12 = 0;
        .mParameters = new Parameter[0];
        goto label_21;
        label_29:
        val_12 = 1;
        (EventDelegate)[1152921531161598544].mParameters[0] = 丙不不丒丁丄丄与丛.mParameters[0];
        label_21:
        val_11 = 丙不不丒丁丄丄与丛.mParameters;
        if(val_12 < 丙不不丒丁丄丄与丛.mParameters.Length)
        {
            goto label_29;
        }
        
        label_20:
        丝丘丑业丛万丞丌丝.Add(item:  new EventDelegate());
    }
    public static bool Remove(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate.丒万业丛丏东专世丟 业丏丈世世世丞丒世)
    {
        var val_3;
        if(丝丘丑业丛万丞丌丝 == null)
        {
                return false;
        }
        
        int val_1 = 丝丘丑业丛万丞丌丝.Count;
        if(val_1 < 1)
        {
                return false;
        }
        
        do
        {
            EventDelegate val_2 = 丝丘丑业丛万丞丌丝.Item[0];
            if(val_2 != null)
        {
                if((val_2 & 1) != 0)
        {
            goto label_4;
        }
        
        }
        
            val_3 = 0 + 1;
        }
        while(val_3 < val_1);
        
        return false;
        label_4:
        丝丘丑业丛万丞丌丝.RemoveAt(index:  0);
        return false;
    }
    public static bool Remove(System.Collections.Generic.List<EventDelegate> 丝丘丑业丛万丞丌丝, EventDelegate 丙不不丒丁丄丄与丛)
    {
        var val_3;
        if(丝丘丑业丛万丞丌丝 == null)
        {
                return false;
        }
        
        int val_1 = 丝丘丑业丛万丞丌丝.Count;
        if(val_1 < 1)
        {
                return false;
        }
        
        do
        {
            EventDelegate val_2 = 丝丘丑业丛万丞丌丝.Item[0];
            if(val_2 != null)
        {
                if((val_2 & 1) != 0)
        {
            goto label_4;
        }
        
        }
        
            val_3 = 0 + 1;
        }
        while(val_3 < val_1);
        
        return false;
        label_4:
        丝丘丑业丛万丞丌丝.RemoveAt(index:  0);
        return false;
    }
    private static EventDelegate()
    {
        if("EventDelegate" == null)
        {
                "EventDelegate" = "EventDelegate";
        }
        
        EventDelegate.s_Hash = "EventDelegate";
    }

}
