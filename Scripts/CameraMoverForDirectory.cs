using UnityEngine;
[Serializable]
internal sealed class CameraMoverForDirectory
{
    // Fields
    internal System.Collections.Generic.List<string> subdirectoryNames;
    internal UnityEngine.Vector3 positionToMove;
    internal float moveSpeed;
    internal float cameraZoomValue;
    internal float cameraZoomSpeed;
    internal bool onlyZoom;
    internal bool shouldRotate;
    internal UnityEngine.Vector3 cameraRotation;
    internal float cameraRotateSpeed;
    internal bool useTopDownViewLogic;
    internal bool playerCanControlCamera;
    
    // Methods
    internal void 三不丁三丕且丌万丏()
    {
        CameraMoverDirectoryManager val_12;
        UnityEngine.Vector3 val_15;
        var val_16;
        var val_17;
        float val_18;
        var val_20;
        var val_21;
        CameraMoverDirectoryManager val_22;
        val_12 = this;
        if((丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑() == null) || (null != null))
        {
            goto label_2;
        }
        
        业丆七世丟上下丌不 val_2 = 丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑();
        if(val_2 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        label_4:
        var val_3 = (null == null) ? (val_2) : 0;
        mem2[0] = this.useTopDownViewLogic;
        业丆七世丟上下丌不 val_4 = 丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑();
        if(val_4 != null)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        label_6:
        var val_5 = (null == null) ? (val_4) : 0;
        mem2[0] = this.playerCanControlCamera;
        label_2:
        var val_12 = 0;
        val_12 = val_12 + 1;
        丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑().SmoothZoom(上世东专丅丙一世与:  this.cameraZoomValue, 丟丞一专丕三东丗一:  this.cameraZoomSpeed);
        if(this.onlyZoom != false)
        {
                return;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑().SmoothMove(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = this.positionToMove, y = this.cameraZoomSpeed, z = V10.16B}, 东丗上东丘丄东丘世:  this.moveSpeed);
        if(this.shouldRotate != false)
        {
                val_15 = this.cameraRotation;
            val_18 = this.cameraRotateSpeed;
            val_20 = null;
            var val_14 = 0;
            val_21 = 1152921505162579976;
            val_14 = val_14 + 1;
        }
        else
        {
                val_12 = CameraMoverDirectoryManager.丄丘七三上丕世丞业;
            val_22 = val_12;
            if(val_12 == null)
        {
                val_22 = CameraMoverDirectoryManager.丄丘七三上丕世丞业;
        }
        
            val_15 = mem[CameraMoverDirectoryManager.丄丘七三上丕世丞业 + 72];
            val_15 = CameraMoverDirectoryManager.丄丘七三上丕世丞业.defaultRotation;
            val_16 = mem[CameraMoverDirectoryManager.丄丘七三上丕世丞业 + 72 + 4];
            val_16 = CameraMoverDirectoryManager.丄丘七三上丕世丞业 + 72 + 4;
            val_17 = mem[CameraMoverDirectoryManager.丄丘七三上丕世丞业 + 80];
            val_17 = CameraMoverDirectoryManager.丄丘七三上丕世丞业 + 80;
            val_18 = mem[CameraMoverDirectoryManager.丄丘七三上丕世丞业 + 84];
            val_18 = CameraMoverDirectoryManager.丄丘七三上丕世丞业.defaultRotationSpeed;
            val_20 = null;
            var val_15 = 0;
            val_21 = 1152921505162579976;
            val_15 = val_15 + 1;
        }
        
        丅丆丘丅东一丆丟丆.丐下下丅与上东丙丑().SmoothRotate(丟世丁世丏丅业下七:  new UnityEngine.Vector3() {x = val_15, y = this.cameraZoomSpeed, z = V10.16B}, 丅丅三与三七与丐上:  val_18);
    }
    public CameraMoverForDirectory()
    {
        this.moveSpeed = 10f;
        this.cameraZoomValue = 0.75f;
        this.cameraZoomSpeed = 10f;
        this.cameraRotateSpeed = 10f;
        this.useTopDownViewLogic = true;
        this.playerCanControlCamera = true;
    }

}
