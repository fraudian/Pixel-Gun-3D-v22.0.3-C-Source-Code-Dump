using UnityEngine;
internal class OpenCloseDoor : MonoBehaviour
{
    // Fields
    private UnityEngine.Vector3 _openPositionDoor;
    private UnityEngine.Vector3 _closePositionDoor;
    private bool calculateRotation;
    private UnityEngine.Quaternion _openRotationDoor;
    private UnityEngine.Quaternion _closeRotationDoor;
    private float _deltaTime;
    private float 丝丙一丝丈丂不丙一;
    private UnityEngine.Coroutine 丕万丛丘丆丂丌七丌;
    private UnityEngine.Coroutine 与世丏丐一丌丕专丆;
    
    // Methods
    public void StartOpenDoor()
    {
        if(((this._openRotationDoor == 0f) && (this._openRotationDoor == 0f)) && (this._openRotationDoor == 0f))
        {
                UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this._openRotationDoor = val_1;
            mem[1152921540036438744] = val_1.y;
            mem[1152921540036438748] = val_1.z;
            mem[1152921540036438752] = val_1.w;
        }
        
        if(((this._closeRotationDoor == 0f) && (this._closeRotationDoor == 0f)) && (this._closeRotationDoor == 0f))
        {
                UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this._closeRotationDoor = val_2;
            mem[1152921540036438760] = val_2.y;
            mem[1152921540036438764] = val_2.z;
            mem[1152921540036438768] = val_2.w;
        }
        
        if(this.与世丏丐一丌丕专丆 != null)
        {
                this.StopCoroutine(routine:  this.与世丏丐一丌丕专丆);
            this.与世丏丐一丌丕专丆 = 0;
        }
        
        if(this.丕万丛丘丆丂丌七丌 != null)
        {
                return;
        }
        
        this.丕万丛丘丆丂丌七丌 = this.StartCoroutine(routine:  this.丒丛且七丐丂丕丑丐());
    }
    public void StartCloseDoor()
    {
        if(this.丕万丛丘丆丂丌七丌 != null)
        {
                this.StopCoroutine(routine:  this.丕万丛丘丆丂丌七丌);
            this.丕万丛丘丆丂丌七丌 = 0;
        }
        
        if(this.与世丏丐一丌丕专丆 != null)
        {
                return;
        }
        
        this.与世丏丐一丌丕专丆 = this.StartCoroutine(routine:  this.丑世上万丑专万丛万());
    }
    private System.Collections.IEnumerator 丒丛且七丐丂丕丑丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new OpenCloseDoor.丛丐丁丆专丙丐丌丗();
    }
    private System.Collections.IEnumerator 丑世上万丑专万丛万()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new OpenCloseDoor.丝丆万下丅丂丂业丄();
    }
    private void 且丑丕丂与业丝丑丐()
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this._openPositionDoor = val_2;
        mem[1152921540036960444] = val_2.y;
        mem[1152921540036960448] = val_2.z;
        UnityEngine.Quaternion val_4 = this.transform.localRotation;
        this._openRotationDoor = val_4;
        mem[1152921540036960472] = val_4.y;
        mem[1152921540036960476] = val_4.z;
        mem[1152921540036960480] = val_4.w;
    }
    private void 丙下丟丒丗丂丒东七()
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this._closePositionDoor = val_2;
        mem[1152921540037088840] = val_2.y;
        mem[1152921540037088844] = val_2.z;
        UnityEngine.Quaternion val_4 = this.transform.localRotation;
        this._closeRotationDoor = val_4;
        mem[1152921540037088872] = val_4.y;
        mem[1152921540037088876] = val_4.z;
        mem[1152921540037088880] = val_4.w;
    }
    public OpenCloseDoor()
    {
        this.calculateRotation = true;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this._openRotationDoor = val_1;
        mem[1152921540037209048] = val_1.y;
        mem[1152921540037209052] = val_1.z;
        mem[1152921540037209056] = val_1.w;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this._closeRotationDoor = val_2;
        mem[1152921540037209064] = val_2.y;
        mem[1152921540037209068] = val_2.z;
        mem[1152921540037209072] = val_2.w;
    }

}
