using UnityEngine;
public class PhotonRigidbodyView : MonoBehaviour, 丈丆丁上丁业丒七丘
{
    // Fields
    private bool m_SynchronizeVelocity;
    private bool m_SynchronizeAngularVelocity;
    private UnityEngine.Rigidbody 丝丘业三丑丘丆七丌;
    
    // Methods
    private void Awake()
    {
        this.丝丘业三丑丘丆七丌 = this.GetComponent<UnityEngine.Rigidbody>();
    }
    public void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        object val_6;
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                if(this.m_SynchronizeVelocity != false)
        {
                UnityEngine.Vector3 val_2 = this.丝丘业三丑丘丆七丌.velocity;
            val_6 = val_2;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_2);
        }
        
            if(this.m_SynchronizeAngularVelocity == false)
        {
                return;
        }
        
            UnityEngine.Vector3 val_3 = this.丝丘业三丑丘丆七丌.angularVelocity;
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
            return;
        }
        
        if(this.m_SynchronizeVelocity != false)
        {
                val_6 = this.丝丘业三丑丘丆七丌;
            object val_4 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            val_6.velocity = new UnityEngine.Vector3() {x = 3.782474E-38f};
        }
        
        if(this.m_SynchronizeAngularVelocity == false)
        {
                return;
        }
        
        object val_5 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.丝丘业三丑丘丆七丌.angularVelocity = new UnityEngine.Vector3() {x = 3.782474E-38f};
    }
    public PhotonRigidbodyView()
    {
        this.m_SynchronizeVelocity = true;
        this.m_SynchronizeAngularVelocity = true;
    }

}
