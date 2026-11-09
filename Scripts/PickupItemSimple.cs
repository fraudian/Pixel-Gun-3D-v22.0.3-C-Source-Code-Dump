using UnityEngine;
public class PickupItemSimple : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public float SecondsBeforeRespawn;
    public bool PickupOnCollide;
    public bool SentPickup;
    
    // Methods
    public void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        PhotonView val_1 = 丘丛丏丘丝七世七丅.GetComponent<PhotonView>();
        if(this.PickupOnCollide == false)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.isMine == false)
        {
                return;
        }
        
        if(this.SentPickup == true)
        {
                return;
        }
        
        this.SentPickup = true;
    }
    public void Pickup()
    {
        if(this.SentPickup != false)
        {
                return;
        }
        
        this.SentPickup = true;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void PunPickupSimple(业丘丘丘丁丂丕万东 与上丛丞丑与与丗专)
    {
        if((this.SentPickup != false) && (与上丛丞丑与与丗专.不丟丗丏丛丕不丁丌.不丐七丌下丗丈丒丅 != false))
        {
                bool val_2 = 丅丆万丟丐丏丏下丄.世三丅不丄丂丒丕上(丞下万上三丘上与专:  this.gameObject);
        }
        
        this.SentPickup = false;
        if((丅丆万丟丐丏丏下丄.世三丅不丄丂丒丕上(丞下万上三丘上与专:  this.gameObject)) != false)
        {
                double val_10 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            double val_6 = 与上丛丞丑与与丗专.东丙业七丐丄三丙丆();
            val_6 = val_10 - val_6;
            val_10 = this.SecondsBeforeRespawn - (float)val_6;
            if(val_10 <= 0f)
        {
                return;
        }
        
            this.gameObject.SetActive(value:  false);
            this.Invoke(methodName:  "RespawnAfter", time:  val_10);
            return;
        }
        
        UnityEngine.Debug.Log(message:  "Ignored PU RPC, cause item is inactive. " + this.gameObject);
    }
    public void RespawnAfter()
    {
        if(this.gameObject == 0)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  true);
    }
    public PickupItemSimple()
    {
        this.SecondsBeforeRespawn = 2f;
    }

}
