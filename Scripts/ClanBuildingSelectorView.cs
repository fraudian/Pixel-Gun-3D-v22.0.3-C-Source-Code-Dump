using UnityEngine;
public class ClanBuildingSelectorView : PGBehaviour
{
    // Fields
    private System.Action<PGCompany.丏丌丝丕丐七丈且丒> 丗不世丙丏丅丄丂下;
    private ClanBuildingPointsView selectedBuildingView;
    private UnityEngine.GameObject selectNextButton;
    private System.Collections.Generic.List<PGCompany.丏丌丝丕丐七丈且丒> 丑且丞且丛丂丒丈且;
    private PGCompany.丏丌丝丕丐七丈且丒 丌三丛丁东丅下世世;
    
    // Properties
    internal PGCompany.丏丌丝丕丐七丈且丒 与丆与丂丄丞丒丏丑 { get; }
    
    // Methods
    internal void 丐丗丗丅丐世七万七(System.Action<PGCompany.丏丌丝丕丐七丈且丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗不世丙丏丅丄丂下, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921536564784760);
    
    }
    internal void 丁专一世丆丄丟丝上(System.Action<PGCompany.丏丌丝丕丐七丈且丒> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗不世丙丏丅丄丂下, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗不世丙丏丅丄丂下 != 1152921536564921336);
    
    }
    internal PGCompany.丏丌丝丕丐七丈且丒 丆世丆东三专东东三()
    {
        return (PGCompany.丏丌丝丕丐七丈且丒)this.丌三丛丁东丅下世世;
    }
    private void OnEnable()
    {
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingSelectorView::丗上丄下与丈丗丝丙(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丑丒丝丒七丐与下丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingSelectorView::丗上丄下与丈丗丝丙(int 丛丑丅丞丝丈丘丆三)));
    }
    private void OnDisable()
    {
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingSelectorView::丗上丄下与丈丗丝丙(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丛丘丁世丄丑且丐丁(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingSelectorView::丗上丄下与丈丗丝丙(int 丛丑丅丞丝丈丘丆三)));
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.丏丌丝丕丐七丈且丒> 丑且丞且丛丂丒丈且, PGCompany.丏丌丝丕丐七丈且丒 丛丗七丅下丞丗且丐)
    {
        PGCompany.丏丌丝丕丐七丈且丒 val_3 = 丛丗七丅下丞丗且丐;
        this.丑且丞且丛丂丒丈且 = 丑且丞且丛丂丒丈且;
        if((丑且丞且丛丂丒丈且.Contains(item:  val_3 = 丛丗七丅下丞丗且丐)) != true)
        {
                val_3 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丏丌丝丕丐七丈且丒>(source:  丑且丞且丛丂丒丈且);
        }
        
        this.丌三丛丁东丅下世世 = val_3;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        this.selectedBuildingView.Setup(下丅丙一丂丗丅丝七:  this.丌三丛丁东丅下世世);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectNextButton, 丏业丟一东丂东丘丛:  (this.丑且丞且丛丂丒丈且.Count > 1) ? 1 : 0);
    }
    private void 丗上丄下与丈丗丝丙(int 丛丑丅丞丝丈丘丆三)
    {
        if(this.selectedBuildingView.丕万丌世丆下丈丟与 == null)
        {
                return;
        }
        
        if(this.selectedBuildingView.丕万丌世丆下丈丟与.业东丅东丌上丗丑不() != 丛丑丅丞丝丈丘丆三)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public void U_SelectNext()
    {
        var val_6;
        if(this.丑且丞且丛丂丒丈且 == null)
        {
                return;
        }
        
        if(this.丑且丞且丛丂丒丈且.Count == 0)
        {
                return;
        }
        
        if(this.丌三丛丁东丅下世世 != null)
        {
                val_6 = (this.丑且丞且丛丂丒丈且.IndexOf(item:  this.丌三丛丁东丅下世世)) + 1;
        }
        else
        {
                val_6 = 1;
        }
        
        PGCompany.丏丌丝丕丐七丈且丒 val_5 = this.丑且丞且丛丂丒丈且.Item[(val_6 < this.丑且丞且丛丂丒丈且.Count) ? (val_6) : 0];
        this.丌三丛丁东丅下世世 = val_5;
        this.丗不世丙丏丅丄丂下.Invoke(obj:  val_5);
        this.丝一丅丆三东丂丞七();
    }
    public ClanBuildingSelectorView()
    {
    
    }

}
