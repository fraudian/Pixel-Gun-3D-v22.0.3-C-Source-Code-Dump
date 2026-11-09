using UnityEngine;
internal sealed class MutationTable : MonoBehaviour
{
    // Fields
    internal UITable verticalTable;
    private UILabel blueHeader;
    private UILabel redHeader;
    private UnityEngine.GameObject redTable;
    private UnityEngine.GameObject winBlueState;
    private UnityEngine.GameObject winRedState;
    private SimpleTweenePlayer winBlueTween;
    private SimpleTweenePlayer winRedTween;
    private ObjectListEnabler 丁丈丘三丏丙丙下下;
    private ObjectListEnabler 丟七专且丑丂上丅丗;
    private int 一丘东丈丌丌七丂东;
    private int 丘丟万一与丂丏丛丂;
    private int 世下上下丁东丝丏下;
    private System.Collections.Generic.List<int> 丐且丈丝丕丕一丒与;
    private System.Collections.Generic.List<int> 丒七丈丏丏与丛丌丘;
    
    // Properties
    internal System.Collections.Generic.List<int> 丙上七丕专丗万丝三 { get; }
    internal System.Collections.Generic.List<int> 业丐丂丈丄丆世丒丐 { get; }
    
    // Methods
    internal System.Collections.Generic.List<int> 丒丞七丌丛丄丈上丑()
    {
        return (System.Collections.Generic.List<System.Int32>)this.丐且丈丝丕丕一丒与;
    }
    internal System.Collections.Generic.List<int> 丙丏丒丕丁丘丈专丄()
    {
        return (System.Collections.Generic.List<System.Int32>)this.丒七丈丏丏与丛丌丘;
    }
    internal void 世丌丛万且丗业丄东(int 丗三上丞丆七不且七)
    {
        this.winBlueState.SetActive(value:  (丗三上丞丆七不且七 == 1) ? 1 : 0);
        this.winRedState.SetActive(value:  (丗三上丞丆七不且七 == 2) ? 1 : 0);
    }
    private void 业丂丅丅不丈不一丂(int 世丒万丅丗上丆万丟, int 丄丂上专丝东丒东丂, bool 丛上丐七丛丘丒下一)
    {
        int val_1 = (丛上丐七丛丘丒下一 != true) ? (1 + 1) : 1;
        if(this.verticalTable == 0)
        {
                return;
        }
        
        if((this.一丘东丈丌丌七丂东 == 世丒万丅丗上丆万丟) && (this.丘丟万一与丂丏丛丂 == 丄丂上专丝东丒东丂))
        {
                if(val_1 == this.世下上下丁东丝丏下)
        {
                return;
        }
        
        }
        
        this.verticalTable.repositionNow = true;
        this.一丘东丈丌丌七丂东 = 世丒万丅丗上丆万丟;
        this.丘丟万一与丂丏丛丂 = 丄丂上专丝东丒东丂;
        this.世下上下丁东丝丏下 = val_1;
    }
    private void 丒世上丝丕上丕丈丄()
    {
        if(this.丐且丈丝丕丕一丒与 != null)
        {
                this.丐且丈丝丕丕一丒与.Clear();
        }
        else
        {
                this.丐且丈丝丕丕一丒与 = new System.Collections.Generic.List<System.Int32>();
        }
        
        if(this.丒七丈丏丏与丛丌丘 != null)
        {
                this.丒七丈丏丏与丛丌丘.Clear();
            return;
        }
        
        this.丒七丈丏丏与丛丌丘 = new System.Collections.Generic.List<System.Int32>();
    }
    private void 丆七世万七丆丝丌且()
    {
        this.丐且丈丝丕丕一丒与 = this.丒七丈丏丏与丛丌丘;
        this.丒七丈丏丏与丛丌丘 = this.丐且丈丝丕丕一丒与;
    }
    internal void 下上丞丌七丝万丘专(bool 丛上丐七丛丘丒下一, NetworkStartTable[] 专上世丝丈专一丂丅, 丈万且丗丂丝丙一东[] 丌丐丂七丌三万丑丅)
    {
        int val_13;
        var val_14;
        System.Collections.Generic.List<System.Int32> val_15;
        var val_16;
        this.丒世上丝丕上丕丈丄();
        if(专上世丝丈专一丂丅 == null)
        {
            goto label_1;
        }
        
        val_13 = 专上世丝丈专一丂丅.Length;
        if(val_13 < 1)
        {
            goto label_7;
        }
        
        do
        {
            this.与丕丏专丁一上世不(不且上一上丐三万丛:  专上世丝丈专一丂丅[0], 世上且丏丂丅丛三丛:  0, 丙丄丕一丒丛丂丞下:  0);
            val_13 = 专上世丝丈专一丂丅.Length;
        }
        while((0 + 1) < val_13);
        
        goto label_7;
        label_1:
        if(丌丐丂七丌三万丑丅 == null)
        {
            goto label_7;
        }
        
        val_13 = 丌丐丂七丌三万丑丅.Length;
        if(val_13 < 1)
        {
            goto label_7;
        }
        
        val_14 = 丛上丐七丛丘丒下一;
        do
        {
            this.与丕丏专丁一上世不(不且上一上丐三万丛:  0, 世上且丏丂丅丛三丛:  丌丐丂七丌三万丑丅[0], 丙丄丕一丒丛丂丞下:  0);
            bool val_2 = 丌丐丂七丌三万丑丅[0x0] + 32.丟丌下三七丁与丟丑();
            if(val_2 != false)
        {
                val_14 = val_2.丐万丟东丆丛丄下上(世上且丏丂丅丛三丛:  丌丐丂七丌三万丑丅[0x0] + 32);
        }
        
            val_13 = 丌丐丂七丌三万丑丅.Length;
        }
        while((0 + 1) < val_13);
        
        if(val_14 == false)
        {
            goto label_14;
        }
        
        label_17:
        val_15 = this.丒七丈丏丏与丛丌丘;
        val_16 = 1;
        if(val_15 != null)
        {
            goto label_18;
        }
        
        goto label_16;
        label_7:
        if(丛上丐七丛丘丒下一 == true)
        {
            goto label_17;
        }
        
        label_14:
        val_15 = this.丐且丈丝丕丕一丒与;
        val_16 = 0;
        this.丐且丈丝丕丕一丒与 = this.丒七丈丏丏与丛丌丘;
        this.丒七丈丏丏与丛丌丘 = val_15;
        if(val_15 != null)
        {
            goto label_18;
        }
        
        label_16:
        label_18:
        this.业丂丅丅不丈不一丂(世丒万丅丗上丆万丟:  val_15.Count, 丄丂上专丝东丒东丂:  this.丐且丈丝丕丕一丒与.Count, 丛上丐七丛丘丒下一:  false);
        this.blueHeader.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_16 != 0) ? "Key_12419" : "Key_12418");
        this.redHeader.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_16 != 0) ? "Key_12418" : "Key_12419");
        this.redTable.SetActive(value:  (this.丐且丈丝丕丕一丒与.Count > 0) ? 1 : 0);
    }
    private bool 丞七丌三丝丑丛丁上()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((((GameController.onlineMode != null) && ((GameController.onlineMode + 88) != 0)) && ((GameController.onlineMode + 88 + 56) == 2)) && ((GameController.onlineMode + 88 + 148) == 2))
        {
                var val_1 = ((GameController.onlineMode + 88 + 49) != 0) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    private bool 丐万丟东丆丛丄下上(丈万且丗丂丝丙一东 世上且丏丂丅丛三丛)
    {
        var val_4;
        var val_5;
        if(世上且丏丂丅丛三丛 == null)
        {
            goto label_9;
        }
        
        if((世上且丏丂丅丛三丛.丟丌下三七丁与丟丑() == false) || (世上且丏丂丅丛三丛.万业丌丏丟丂丘丝且 == false))
        {
            goto label_8;
        }
        
        val_4 = null;
        val_4 = null;
        if(((GameController.onlineMode == null) || ((GameController.onlineMode + 88) == 0)) || ((GameController.onlineMode + 88 + 49) == 0))
        {
            goto label_8;
        }
        
        if((GameController.onlineMode + 88 + 148) != 2)
        {
            goto label_9;
        }
        
        var val_2 = ((GameController.onlineMode + 88 + 56) == 2) ? 1 : 0;
        return (bool)val_5;
        label_8:
        var val_3 = (世上且丏丂丅丛三丛.万业丌丏丟丂丘丝且 == true) ? 1 : 0;
        return (bool)val_5;
        label_9:
        val_5 = 0;
        return (bool)val_5;
    }
    private void 与丕丏专丁一上世不(NetworkStartTable 不且上一上丐三万丛, 丈万且丗丂丝丙一东 世上且丏丂丅丛三丛, int 丙丄丕一丒丛丂丞下)
    {
        System.Collections.Generic.List<System.Int32> val_4;
        bool val_1 = UnityEngine.Object.op_Equality(x:  不且上一上丐三万丛, y:  0);
        if(val_1 == false)
        {
            goto label_3;
        }
        
        if((val_1.丐万丟东丆丛丄下上(世上且丏丂丅丛三丛:  世上且丏丂丅丛三丛)) == true)
        {
            goto label_4;
        }
        
        label_8:
        val_4 = this.丐且丈丝丕丕一丒与;
        if(val_4 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_3:
        if(不且上一上丐三万丛.且世专不丄丏七下万() == false)
        {
            goto label_8;
        }
        
        label_4:
        val_4 = this.丒七丈丏丏与丛丌丘;
        if(val_4 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_4.Add(item:  丙丄丕一丒丛丂丞下);
    }
    private void OnDestroy()
    {
        if(this.丁丈丘三丏丙丙下下 != 0)
        {
                this.丁丈丘三丏丙丙下下.remove_onBegin(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丛丑丒丞七丒丞丒一()));
            this.丁丈丘三丏丙丙下下.remove_onFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丅三专丟世丗丘丏丁()));
        }
        
        if(this.丟七专且丑丂上丅丗 == 0)
        {
                return;
        }
        
        this.丟七专且丑丂上丅丗.remove_onBegin(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丛丑丒丞七丒丞丒一()));
        this.丟七专且丑丂上丅丗.remove_onFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丝丟丙东丄与丁业丆()));
    }
    private void 丅三专丟世丗丘丏丁()
    {
        this.丁丈丘三丏丙丙下下.enabled = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈七不丌三下丑七丘());
    }
    private void 丝丟丙东丄与丁业丆()
    {
        this.丟七专且丑丂上丅丗.enabled = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.与上丛与丛丙丟东丞());
    }
    private System.Collections.IEnumerator 与上丛与丛丙丟东丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MutationTable.丆丙丝丘一且东丛丘();
    }
    private System.Collections.IEnumerator 丈七不丌三下丑七丘()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new MutationTable.上丞东丐丅丆丝丏丂();
    }
    private void Awake()
    {
        ObjectListEnabler val_9;
        ObjectListEnabler val_10;
        if(this.winBlueState != null)
        {
                val_9 = this.winBlueState.GetComponent<ObjectListEnabler>();
        }
        else
        {
                val_9 = 0;
        }
        
        this.丁丈丘三丏丙丙下下 = val_9;
        if(val_9 != 0)
        {
                this.丁丈丘三丏丙丙下下.add_onBegin(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丛丑丒丞七丒丞丒一()));
            this.丁丈丘三丏丙丙下下.add_onFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丅三专丟世丗丘丏丁()));
        }
        
        if(this.winRedState != null)
        {
                val_10 = this.winRedState.GetComponent<ObjectListEnabler>();
        }
        else
        {
                val_10 = 0;
        }
        
        this.丟七专且丑丂上丅丗 = val_10;
        if(val_10 == 0)
        {
                return;
        }
        
        this.丟七专且丑丂上丅丗.add_onBegin(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丛丑丒丞七丒丞丒一()));
        this.丟七专且丑丂上丅丗.add_onFinish(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MutationTable::丝丟丙东丄与丁业丆()));
    }
    private void 丛丑丒丞七丒丞丒一()
    {
        if(this.verticalTable == 0)
        {
                return;
        }
        
        this.verticalTable.repositionNow = true;
    }
    public MutationTable()
    {
    
    }

}
