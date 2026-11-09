using UnityEngine;
internal sealed class ZombiManagerSynch : VTableHolder
{
    // Fields
    private UnityEngine.Vector3 丞上业丐丞丝不丐专;
    private UnityEngine.Quaternion 丘丐丐不丐丁丛且丝;
    
    // Methods
    internal ZombiManagerSynch()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.丞上业丐丞丝不丐专 = val_1;
        mem[1152921537034608956] = val_1.y;
        mem[1152921537034608960] = val_1.z;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.丘丐丐不丐丁丛且丝 = val_2;
        mem[1152921537034608968] = val_2.y;
        mem[1152921537034608972] = val_2.z;
        mem[1152921537034608976] = val_2.w;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void ZombiManagerSynch::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void Awake()
    {
        var val_1 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == true)
        {
                return;
        }
        
        }
        
        this.enabled = false;
    }
    private void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        下丌丙丘丈丌世万专 val_9 = 东业丄丅丅且世七丄;
        if(val_9.丕专丏万下不丞丐丛() != false)
        {
                UnityEngine.Vector3 val_3 = this.transform.position;
            val_9.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
            if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
            val_9 = val_9.东与上丗与丏下丂丘();
            丅丑丞上丛丆东丟丂.三丅丐业丙丕丙业丕(丑与丆丝丕东丛丄丝:  "Stream " + this.GetType(), 丗丟上上丒丐丗丞丙:  val_9);
            return;
        }
        
        object val_8 = val_9.与万三丘与专丛丄七();
        this.丞上业丐丞丝不丐专 = new UnityEngine.Vector3();
        mem[1152921537034915856] = ???;
    }

}
