using UnityEngine;
public class VehicleRandomizePosition : MonoBehaviour
{
    // Fields
    public VehiclePointsBattleRoyale[] points;
    
    // Methods
    private void Start()
    {
        if(UnityEngine.Application.isEditor != false)
        {
                if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        this.与丁上七丝丂不丅专();
    }
    private void 与丁上七丝丂不丅专()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 0;
        goto label_0;
        label_58:
        val_10 = 0;
        goto label_1;
        label_56:
        VehiclePointsBattleRoyale val_9 = this.points[0];
        val_11 = UnityEngine.Random.Range(min:  0, max:  this.points[0x0][0].points.Length);
        goto label_6;
        label_17:
        VehiclePointsBattleRoyale val_10 = this.points[0];
        val_11 = val_11 + 1;
        label_6:
        VehiclePointsBattleRoyale val_11 = this.points[0];
        PointChestBattleRoyale val_12 = this.points[0x0][0].points[(long)(val_11 < this.points[0x0][0].points.Length) ? (val_11) : 0];
        if((this.points[0x0][0].points[(long)(int)(val_11 < this.points[0x0][0].points.Length ? (val_1 + 1) : 0)][0].isUsed) == true)
        {
            goto label_17;
        }
        
        VehiclePointsBattleRoyale val_13 = this.points[0];
        VehiclePointsBattleRoyale val_15 = this.points[0];
        UnityEngine.Vector3 val_5 = this.points[0x0][0].points[(long)(val_11 < this.points[0x0][0].points.Length) ? (val_11) : 0].transform.position;
        this.points[0x0][0].vehicles[0].transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        VehiclePointsBattleRoyale val_17 = this.points[0];
        VehiclePointsBattleRoyale val_19 = this.points[0];
        UnityEngine.Quaternion val_8 = this.points[0x0][0].points[(long)(val_11 < this.points[0x0][0].points.Length) ? (val_11) : 0].transform.rotation;
        this.points[0x0][0].vehicles[0].transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        VehiclePointsBattleRoyale val_21 = this.points[0];
        PointChestBattleRoyale val_22 = this.points[0x0][0].points[(long)(val_11 < this.points[0x0][0].points.Length) ? (val_11) : 0];
        val_10 = 1;
        this.points[0x0][0].points[(long)(int)(val_11 < this.points[0x0][0].points.Length ? (val_1 + 1) : 0)][0].isUsed = true;
        label_1:
        VehiclePointsBattleRoyale val_23 = this.points[0];
        if(val_10 < this.points[0x0][0].vehicles.Length)
        {
            goto label_56;
        }
        
        val_9 = 1;
        label_0:
        if(val_9 < this.points.Length)
        {
            goto label_58;
        }
    
    }
    private void Update()
    {
        var val_20;
        PointChestBattleRoyale[] val_21;
        var val_22;
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        int val_5 = this.gameObject.transform.childCount;
        this.points = new VehiclePointsBattleRoyale[0];
        val_20 = 0;
        goto label_5;
        label_43:
        UnityEngine.Transform val_9 = this.gameObject.transform.GetChild(index:  0);
        if(val_9 != null)
        {
                val_21 = val_9.GetComponentsInChildren<PointChestBattleRoyale>();
            val_22 = val_9;
        }
        else
        {
                val_21 = 0.GetComponentsInChildren<PointChestBattleRoyale>();
            val_22 = 0;
        }
        
        VehiclePointsBattleRoyale val_13 = new VehiclePointsBattleRoyale();
        if(this.points == null)
        {
            goto label_10;
        }
        
        if(val_13 != null)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(val_13 == null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        this.points[0] = val_13;
        VehiclePointsBattleRoyale val_20 = this.points[0];
        this.points[0x0][0].nameLocation = val_22.gameObject.name;
        VehiclePointsBattleRoyale val_21 = this.points[0];
        this.points[0x0][0].points = val_21;
        VehiclePointsBattleRoyale val_22 = this.points[0];
        this.points[0x0][0].vehicles = val_22.GetComponentsInChildren<VehicleController>();
        VehiclePointsBattleRoyale val_23 = this.points[0];
        VehiclePointsBattleRoyale val_24 = this.points[0];
        if(this.points[0x0][0].points.Length < this.points[0x0][0].vehicles.Length)
        {
                VehiclePointsBattleRoyale val_25 = this.points[0];
            UnityEngine.Debug.LogError(message:  "Андрей, машин не может быть больше чем точек!!!\nДобавь точек в "("Андрей, машин не может быть больше чем точек!!!\nДобавь точек в ") + this.points[0x0][0].nameLocation);
        }
        
        val_20 = 1;
        label_5:
        if(val_20 < this.gameObject.transform.childCount)
        {
            goto label_43;
        }
    
    }
    public VehicleRandomizePosition()
    {
    
    }

}
