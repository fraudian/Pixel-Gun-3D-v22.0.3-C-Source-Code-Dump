using UnityEngine;
private sealed class ChatAnimator.丈不与丟七丟上丒丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ChatAnimator 丝且与丝丒丟万丁专;
    private UnityEngine.Vector3 丂东丞丂万七不丕丆;
    private UnityEngine.Vector3 丄丞丄丐丟东丌三丝;
    private UnityEngine.Vector3 丑东丙丗东丘丞丘丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ChatAnimator.丈不与丟七丟上丒丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_24;
        float val_25;
        var val_26;
        float val_27;
        UnityEngine.Transform val_29;
        var val_30;
        var val_31;
        UnityEngine.Vector3 val_32;
        float val_33;
        UnityEngine.Transform val_34;
        UnityEngine.Vector3 val_35;
        float val_36;
        float val_37;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.丗丂丐万丅丄丗万丒 = true;
        this.丝且与丝丒丟万丁专.animTimer = 0f;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_24 = 0;
        this.丝且与丝丒丟万丁专.丗丂丐万丅丄丗万丒 = false;
        return (bool)val_24;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_8;
        }
        
        val_25 = 0f;
        if((1.643967E-34f) >= 0)
        {
            goto label_9;
        }
        
        val_26 = 104;
        val_27 = 1.643967E-34f;
        float val_1 = UnityEngine.Time.smoothDeltaTime;
        val_1 = val_27 + val_1;
        mem[104] = val_1;
        val_29 = 0;
        val_30 = 1;
        val_31 = 100;
        goto label_10;
        label_3:
        val_24 = 0;
        return (bool)val_24;
        label_4:
        mem[42] = 1;
        mem[104] = 0;
        label_5:
        UnityEngine.Vector3[] val_2 = this.丝且与丝丒丟万丁专.丁与上三下丄丐丕丒();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        int val_27 = this.丝且与丝丒丟万丁专.KeyBoardHeight;
        val_27 = val_27 - 76;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  (float)val_27);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2[0], y = val_2[0], z = val_2[1]}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        this.丂东丞丂万七不丕丆 = val_5;
        mem[1152921525651090412] = val_5.y;
        mem[1152921525651090416] = val_5.z;
        UnityEngine.Vector3[] val_6 = this.丝且与丝丒丟万丁专.丁与上三下丄丐丕丒();
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  (float)this.丝且与丝丒丟万丁专.ChatInput.height - 2);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6[1], y = val_6[2], z = val_6[2]}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        this.丄丞丄丐丟东丌三丝 = val_11;
        mem[1152921525651090424] = val_11.y;
        mem[1152921525651090428] = val_11.z;
        UnityEngine.Vector3[] val_12 = this.丝且与丝丒丟万丁专.丁与上三下丄丐丕丒();
        val_32 = val_12[2];
        UnityEngine.Vector3 val_32 = val_12[2];
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
        val_33 = val_13.y;
        int val_15 = this.丝且与丝丒丟万丁专.KeyBoardHeight + this.丝且与丝丒丟万丁专.ChatInput.height;
        val_15 = val_15 - 78;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_33, z = val_13.z}, d:  (float)val_15);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12[1], y = val_32, z = val_32}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        this.丑东丙丗东丘丞丘丛 = val_17;
        mem[1152921525651090436] = val_17.y;
        mem[1152921525651090440] = val_17.z;
        label_8:
        val_26 = this.丝且与丝丒丟万丁专;
        val_31 = this.丝且与丝丒丟万丁专 + 104;
        if(this.丝且与丝丒丟万丁专.animTimer < 0)
        {
            goto label_25;
        }
        
        label_9:
        this.丝且与丝丒丟万丁专.LeftContainer.localPosition = new UnityEngine.Vector3() {x = this.丂东丞丂万七不丕丆, y = val_32, z = val_32};
        val_34 = this.丝且与丝丒丟万丁专.RightContainer;
        val_35 = this.丑东丙丗东丘丞丘丛;
        val_34.localPosition = new UnityEngine.Vector3() {x = val_35, y = val_32, z = val_32};
        val_24 = true;
        this.丝且与丝丒丟万丁专.isKeyboardShow = val_24;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_24;
        label_25:
        float val_18 = UnityEngine.Time.smoothDeltaTime;
        val_29 = this.丝且与丝丒丟万丁专.LeftContainer;
        val_18 = this.丝且与丝丒丟万丁专.animTimer + val_18;
        val_30 = 0;
        this.丝且与丝丒丟万丁专.animTimer = val_18;
        label_10:
        UnityEngine.Vector3[] val_19 = this.丝且与丝丒丟万丁专.丁与上三下丄丐丕丒();
        if((val_30 & 1) != 0)
        {
                val_37 = mem[this.丝且与丝丒丟万丁专 + 104];
            val_37 = this.丝且与丝丒丟万丁专 + 104;
        }
        else
        {
                val_37 = mem[this.丝且与丝丒丟万丁专 + 104];
            val_37 = this.丝且与丝丒丟万丁专 + 104;
        }
        
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_19[0], y = val_19[0], z = val_19[1]}, b:  new UnityEngine.Vector3() {x = this.丂东丞丂万七不丕丆, y = val_33, z = val_13.z}, t:  val_37 / (this.丝且与丝丒丟万丁专 + 104 + -4));
        val_29.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        float val_36 = this.丝且与丝丒丟万丁专 + 104;
        val_36 = val_36 / (this.丝且与丝丒丟万丁专 + 104 + -4);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丄丞丄丐丟东丌三丝, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = this.丑东丙丗东丘丞丘丛, y = val_33, z = val_13.z}, t:  val_36);
        val_35 = val_22.x;
        val_36 = val_22.z;
        this.丝且与丝丒丟万丁专.RightContainer.localPosition = new UnityEngine.Vector3() {x = val_35, y = val_22.y, z = val_36};
        val_34 = this.丝且与丝丒丟万丁专.StickersPanel;
        val_34.SetDirty();
        this.丝且与丝丒丟万丁专.StickersPanel.Refresh();
        val_24 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
