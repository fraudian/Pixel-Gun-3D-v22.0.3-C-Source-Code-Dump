using UnityEngine;
public class BounceCounter : MonoBehaviour
{
    // Fields
    public UnityDataConnector conn;
    public bool trackBounces;
    
    // Methods
    private void OnCollisionEnter(UnityEngine.Collision 丁丂专业丁丅丅丈丙)
    {
        if(this.trackBounces == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = 丁丂专业丁丅丅丈丙.relativeVelocity;
        this.conn.SaveDataOnTheCloud(丌七与万丆丘丞丁一:  this.gameObject.name, 且丐丑丐与丂上万世:  val_3.x);
    }
    public BounceCounter()
    {
        this.trackBounces = true;
    }

}
