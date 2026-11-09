using UnityEngine;
internal sealed class FortFieldGateUtility : PGBehaviour
{
    // Fields
    private TriggerOpenDungeonDoor triggerOpenDungeonDoor;
    private OpenDoorAtDestroy openDoorAtDestroy;
    private HealthBarDamageableObject healthBarDamageableObject;
    private BotChangeDamageMaterial botChangerMaterial;
    private System.Collections.Generic.List<BotChangeDamageMaterial> listBotChangerMaterials;
    
    // Methods
    private void Start()
    {
        BotChangeDamageMaterial val_7;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor != 0)
        {
                this.openDoorAtDestroy.不丒世下丝万丙丟丆(丅丞万丒不专丈专丕:  FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor);
            this.healthBarDamageableObject.不丒世下丝万丙丟丆(丅丞万丒不专丈专丕:  FortDefenceLinkController.丄丘七三上丕世丞业.damageDoor);
            val_7 = this.botChangerMaterial;
            一东丆专不丙丄业丞(丅丁七丑丅丙且与丏:  val_7, 丗丟丗丞世丞下丑且:  this.listBotChangerMaterials);
        }
        
        PhotonView val_3 = GetComponent<PhotonView>();
        if(val_3 != 0)
        {
                val_7 = this.triggerOpenDungeonDoor;
            val_7.丟丏且丌丅丝丞丛丅(丄丈丑丐丆丞丘与丗:  val_3);
        }
        
        UnityEngine.BoxCollider val_5 = GetComponent<UnityEngine.BoxCollider>();
        if(val_5 != 0)
        {
                val_7 = this.openDoorAtDestroy;
            val_7.不丂丄丂七丒丛丏丞(丗丑东丛东下丈丆丕:  val_5);
        }
        
        this.triggerOpenDungeonDoor.丑世上万丑专万丛万();
    }
    public FortFieldGateUtility()
    {
    
    }

}
