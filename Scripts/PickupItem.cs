using UnityEngine;
public class PickupItem : MonoBehaviour, 丈丆丁上丁业丒七丘, 东丁丆一业丈万丆丐
{
    // Fields
    public float SecondsBeforeRespawn;
    public bool PickupOnTrigger;
    public bool PickupIsMine;
    public UnityEngine.MonoBehaviour OnPickedUpCall;
    public bool SentPickup;
    public double TimeOfRespawn;
    public static System.Collections.Generic.HashSet<PickupItem> DisabledPickupItems;
    
    // Properties
    public int 丙丘丄丕七丁一上丌 { get; }
    
    // Methods
    public int get_ViewID()
    {
        if(this.photonView != null)
        {
                return (int)val_1.viewIdField;
        }
        
        return (int)val_1.viewIdField;
    }
    public void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        PhotonView val_1 = 丘丛丏丘丝七世七丅.GetComponent<PhotonView>();
        if(this.PickupOnTrigger == false)
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
    public void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                if(this.SecondsBeforeRespawn <= 0f)
        {
            goto label_3;
        }
        
        }
        
        object val_2 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.gameObject.transform.position = new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B};
        return;
        label_3:
        UnityEngine.Vector3 val_7 = this.gameObject.transform.position;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_7);
    }
    public void Pickup()
    {
        if(this.SentPickup != false)
        {
                return;
        }
        
        this.SentPickup = true;
    }
    public void Drop()
    {
    
    }
    public void Drop(UnityEngine.Vector3 且丌上七丅东与丁万)
    {
    
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void PunPickup(业丘丘丘丁丂丕万东 与上丛丞丑与与丗专)
    {
        if(与上丛丞丑与与丗专.不丟丗丏丛丕不丁丌.不丐七丌下丗丈丒丅 != false)
        {
                this.SentPickup = false;
        }
        
        if((丅丆万丟丐丏丏下丄.世三丅不丄丂丒丕上(丞下万上三丘上与专:  this.gameObject)) == false)
        {
            goto label_3;
        }
        
        this.PickupIsMine = 与上丛丞丑与与丗专.不丟丗丏丛丕不丁丌.不丐七丌下丗丈丒丅;
        if(this.OnPickedUpCall != 0)
        {
                this.OnPickedUpCall.SendMessage(methodName:  "OnPickedUp", value:  this);
        }
        
        if(this.SecondsBeforeRespawn <= 0f)
        {
            goto label_9;
        }
        
        double val_5 = 与上丛丞丑与与丗专.东丙业七丐丄三丙丆();
        val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - val_5;
        val_5 = (double)this.SecondsBeforeRespawn - val_5;
        if(val_5 <= 0f)
        {
                return;
        }
        
        goto label_13;
        label_3:
        object[] val_6 = new object[4];
        val_6[0] = this.gameObject;
        val_6[1] = this.SecondsBeforeRespawn;
        val_6[2] = this.TimeOfRespawn;
        val_6[3] = (this.TimeOfRespawn > 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄()) ? 1 : 0;
        this = System.String.Format(format:  "Ignored PU RPC, cause item is inactive. {0} SecondsBeforeRespawn: {1} TimeOfRespawn: {2} respawn in future: {3}", args:  val_6);
        UnityEngine.Debug.Log(message:  this);
        return;
        label_9:
        label_13:
        this.丛丆且东万下丅丟丝(且三丄丄丞丟丝丏丞:  0f);
    }
    internal void 丛丆且东万下丅丟丝(float 且三丄丄丞丟丝丏丞)
    {
        var val_4;
        this.gameObject.SetActive(value:  false);
        val_4 = null;
        val_4 = null;
        bool val_2 = PickupItem.DisabledPickupItems.Add(item:  this);
        this.TimeOfRespawn = 0;
        if(且三丄丄丞丟丝丏丞 <= 0f)
        {
                return;
        }
        
        double val_3 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_3 = val_3 + (double)且三丄丄丞丟丝丏丞;
        this.TimeOfRespawn = val_3;
        this.Invoke(methodName:  "PunRespawn", time:  且三丄丄丞丟丝丏丞);
    }
    internal void PunRespawn(UnityEngine.Vector3 下业丕七东丌丝下且)
    {
        UnityEngine.Debug.Log(message:  "PunRespawn with Position.");
        this.PunRespawn();
        this.gameObject.transform.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
    }
    internal void PunRespawn()
    {
        null = null;
        bool val_1 = PickupItem.DisabledPickupItems.Remove(item:  this);
        this.TimeOfRespawn = 0;
        this.PickupIsMine = false;
        if(this.gameObject == 0)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  true);
    }
    public PickupItem()
    {
        this.SecondsBeforeRespawn = 2f;
    }
    private static PickupItem()
    {
        PickupItem.DisabledPickupItems = new System.Collections.Generic.HashSet<PickupItem>();
    }

}
