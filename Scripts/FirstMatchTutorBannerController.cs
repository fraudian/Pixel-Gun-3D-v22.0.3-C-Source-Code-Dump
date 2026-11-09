using UnityEngine;
public class FirstMatchTutorBannerController : BannerWindow
{
    // Fields
    private UITextureMasked _loading;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private bool 丌东丅丅与丕且一丕;
    
    // Methods
    protected override void Awake()
    {
        object val_7;
        var val_8;
        var val_9;
        if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != false)
        {
                val_7 = "/Hi";
        }
        else
        {
                val_7 = null;
        }
        
        val_8 = null;
        val_8 = null;
        UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Loading_{1}", arg0:  val_7, arg1:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  PGCompany.丁东丌世与丕东丆上.丛不丝丆与不丌与七()).丙且上丒不下丑下丞()));
        val_9 = 0;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._loading, 与万丆丛丒万丝丙丑:  null);
        this.Awake();
    }
    public void U_Accept()
    {
        if(this.丌东丅丅与丕且一丕 == true)
        {
                return;
        }
        
        上丐丛丗丑三万丘专.丒丟丐丞丘丂专丘丙(丞丁丑丏丄丏七丂不:  PGCompany.丁东丌世与丕东丆上.丛不丝丆与不丌与七(), 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 丂丛丑东不丅丈一东:  2);
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  23);
        this.丌东丅丅与丕且一丕 = true;
    }
    protected override void OnEnable()
    {
        var val_6;
        this.OnEnable();
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        Rilisoft.BackSystem val_2 = Rilisoft.BackSystem.丑七不且上丗丁一世();
        val_6 = null;
        val_6 = null;
        if((FirstMatchTutorBannerController.<>c.<>9__4_0) == null)
        {
            goto label_10;
        }
        
        label_16:
        this.丐丆七且丞丏下三丙 = val_2.Register(业丏丈世世世丞丒世:  FirstMatchTutorBannerController.<>c.<>9__4_0, 与且专丈不万东一万:  0);
        return;
        label_10:
        FirstMatchTutorBannerController.<>c.<>9__4_0 = new System.Action(object:  FirstMatchTutorBannerController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void FirstMatchTutorBannerController.<>c::丆丂丆三丆丌丞七丞());
        if(val_2 != null)
        {
            goto label_16;
        }
        
        goto label_16;
    }
    protected override void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = 0;
        this.OnDisable();
    }
    public FirstMatchTutorBannerController()
    {
    
    }

}
