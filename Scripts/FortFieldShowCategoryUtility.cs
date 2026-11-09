using UnityEngine;
internal sealed class FortFieldShowCategoryUtility : PGBehaviour
{
    // Fields
    private string category;
    private string subcategory;
    private float 丞一丗东丈丄丟万丂;
    private float 丁丙丌丏丑丟万丅丌;
    private float 丒丏上丌丒且万丞丄;
    
    // Methods
    private void Awake()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Start()
    {
        this.丞一丗东丈丄丟万丂 = (float)UnityEngine.Screen.height;
        this.丁丙丌丏丑丟万丅丌 = (float)UnityEngine.Screen.width;
    }
    private void OnMouseDown()
    {
        Base_BuildingUI val_10;
        string val_11;
        float val_12;
        val_10 = this;
        val_11 = 1152921530862937872;
        if((Rilisoft.Singleton<ClansVisitController>.Instance.IsVisitClan) != false)
        {
                if((Rilisoft.Singleton<ClansVisitController>.Instance.VisitClan) != null)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_12 = val_5.y;
        if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch val_7 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            val_12 = val_8.y;
        }
        
        if(Base_BuildingUI.instance == 0)
        {
                return;
        }
        
        if(Base_BuildingUI.instance.slideUp != false)
        {
                float val_10 = this.丞一丗东丈丄丟万丂;
            val_10 = val_12 / val_10;
            if(val_10 < 0)
        {
                return;
        }
        
        }
        
        val_11 = this.category;
        val_10 = Base_BuildingUI.instance;
        val_10.丝且七丑不丘丘丏万(丌丄丗七丝丘与丆与:  false);
    }
    internal void 世丈丞丐丈丛丐东且(string 七丆丒与丗丌丄且丂, string 世丛业下丘与丞东丞)
    {
        this.category = 七丆丒与丗丌丄且丂;
        this.subcategory = 世丛业下丘与丞东丞;
    }
    public FortFieldShowCategoryUtility()
    {
        this.丒丏上丌丒且万丞丄 = 0.4f;
    }

}
