using UnityEngine;
public class ClanBuildingsGraphics : PGBehaviour
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.Transform> buildingHoldersList;
    internal System.Collections.Generic.List<PGCompany.丏丌丝丕丐七丈且丒> 丞丏上三专丑丅丁万;
    internal System.Collections.Generic.Dictionary<PGCompany.丏丌丝丕丐七丈且丒, ClanBuildingsGraphics.不丒丆上丑丗一丄丛> 上丝丕丘丄一丏不丙;
    
    // Methods
    private void OnEnable()
    {
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingsGraphics::下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丒丂丘丐万三且丌丐.丆世一丒丕上丈东一(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingsGraphics::下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)));
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanBuildingsGraphics::UpdateView()));
        ClansController.丒世丒业丙丟丌世上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanBuildingsGraphics::UpdateView()));
        this.UpdateView();
    }
    private void OnDisable()
    {
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingsGraphics::下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丒丂丘丐万三且丌丐.丅丒丘上丞不下丐丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingsGraphics::下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)));
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanBuildingsGraphics::UpdateView()));
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanBuildingsGraphics::UpdateView()));
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_10;
        System.Collections.Generic.List<UnityEngine.Transform> val_11;
        if(this.丞丏上三专丑丅丁万 != null)
        {
                if(this.丞丏上三专丑丅丁万.Count > 0)
        {
                return;
        }
        
        }
        
        this.丞丏上三专丑丅丁万 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一上丄与丌七业丈不<PGCompany.丏丌丝丕丐七丈且丒>(丁丅丈丌丟世丗丗丟:  80);
        this.上丝丕丘丄一丏不丙 = new System.Collections.Generic.Dictionary<PGCompany.丏丌丝丕丐七丈且丒, 不丒丆上丑丗一丄丛>();
        val_10 = 0;
        goto label_4;
        label_12:
        .丄三下丙下世丅丘丙 = 0;
        val_11 = this.buildingHoldersList;
        if(val_10 < val_11.Count)
        {
                val_11 = this.buildingHoldersList;
            .丄三下丙下世丅丘丙 = val_11.Item[0];
        }
        
        this.上丝丕丘丄一丏不丙.Add(key:  this.丞丏上三专丑丅丁万.Item[0], value:  new ClanBuildingsGraphics.不丒丆上丑丗一丄丛());
        val_10 = 1;
        label_4:
        if(val_10 < this.丞丏上三专丑丅丁万.Count)
        {
            goto label_12;
        }
    
    }
    public void UpdateView()
    {
        var val_3;
        this.丘上丐世丆丑且丞丒();
        List.Enumerator<T> val_1 = this.丞丏上三专丑丅丁万.GetEnumerator();
        label_45:
        if((1895160496 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        不丒丆上丑丗一丄丛 val_5 = this.上丝丕丘丄一丏不丙.Item[val_4];
        bool val_6 = UnityEngine.Object.op_Inequality(x:  val_5.丄三下丙下世丅丘丙, y:  0);
        if(val_6 == false)
        {
            goto label_45;
        }
        
        string val_7 = val_6.丟一丅丘丗丑丒丑丙(上丟专三丙丅丆丛且:  val_4);
        不丒丆上丑丗一丄丛 val_8 = this.上丝丕丘丄一丏不丙.Item[val_4];
        if(val_8.丁丑丏三丈丞丐丝丆 == 0)
        {
            goto label_12;
        }
        
        不丒丆上丑丗一丄丛 val_10 = this.上丝丕丘丄一丏不丙.Item[val_4];
        if((System.String.op_Inequality(a:  val_10.丁丑丏三丈丞丐丝丆.name, b:  val_7)) == false)
        {
            goto label_45;
        }
        
        label_12:
        不丒丆上丑丗一丄丛 val_13 = this.上丝丕丘丄一丏不丙.Item[val_4];
        if(val_13.丁丑丏三丈丞丐丝丆 != 0)
        {
                不丒丆上丑丗一丄丛 val_15 = this.上丝丕丘丄一丏不丙.Item[val_4];
            UnityEngine.Object.Destroy(obj:  val_15.丁丑丏三丈丞丐丝丆.gameObject);
        }
        
        UnityEngine.GameObject val_18 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Clans/ClanBuildingGraphics/"("Clans/ClanBuildingGraphics/") + val_7);
        if(val_18 == 0)
        {
            goto label_45;
        }
        
        不丒丆上丑丗一丄丛 val_20 = this.上丝丕丘丄一丏不丙.Item[val_4];
        不丒丆上丑丗一丄丛 val_21 = this.上丝丕丘丄一丏不丙.Item[val_4];
        val_20.丁丑丏三丈丞丐丝丆 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18, parent:  val_21.丄三下丙下世丅丘丙);
        不丒丆上丑丗一丄丛 val_23 = this.上丝丕丘丄一丏不丙.Item[val_4];
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
        val_23.丁丑丏三丈丞丐丝丆.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        不丒丆上丑丗一丄丛 val_26 = this.上丝丕丘丄一丏不丙.Item[val_4];
        val_26.丁丑丏三丈丞丐丝丆.name = val_7;
        goto label_45;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private string 丟一丅丘丗丑丒丑丙(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        string val_6 = 上丟专三丙丅丆丛且.业上丙丞丐丄丆丅七();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  上丟专三丙丅丆丛且.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
        {
                return (string)val_6;
        }
        
        val_6 = val_6 + "_ruins";
        return (string)val_6;
    }
    private void 下丑丞丂不不丑下一(int 丛丑丅丞丝丈丘丆三)
    {
        this.UpdateView();
    }
    public ClanBuildingsGraphics()
    {
    
    }

}
