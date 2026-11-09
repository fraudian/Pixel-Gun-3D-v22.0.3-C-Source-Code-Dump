using UnityEngine;
internal sealed class ClansTutorilStap : PGBehaviour
{
    // Fields
    private bool _needCallHideForOperationBack;
    private ClansTutorialController.丙且丌业世万丂丝上 <专丙丑业丟丝东丑世>k__BackingField;
    private Progress.不专丂万丐丄七上丗 东丆专东上丆与丏丂;
    private Progress.与丄东丄丘丐丙丅业 丅丄丑下丛与丅丁丅;
    private System.Action<Progress.不专丂万丐丄七上丗> 三下丌丈丄丅丟丈专;
    private System.Action<Progress.与丄东丄丘丐丙丅业> 丏一三专丟与丆专不;
    private System.Action<ClansTutorilStap> 丈丒下丝业专丑一丗;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Properties
    internal ClansTutorialController.丙且丌业世万丂丝上 丙且丌业世万丂丝上 { get; set; }
    
    // Methods
    internal ClansTutorialController.丙且丌业世万丂丝上 专丌丘丅七丈丐丆丟()
    {
        return (丙且丌业世万丂丝上)this.<专丙丑业丟丝东丑世>k__BackingField;
    }
    internal void 丐丟丑下业丑下丙丝(ClansTutorialController.丙且丌业世万丂丝上 丙业与丙丗丝不丈东)
    {
        this.<专丙丑业丟丝东丑世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 且且与丏丒不丈丗丘(System.Action<Progress.不专丂万丐丄七上丗> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三下丌丈丄丅丟丈专, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三下丌丈丄丅丟丈专 != 1152921536685791512);
    
    }
    private void 业业丝丘三丁东丞七(System.Action<Progress.不专丂万丐丄七上丗> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三下丌丈丄丅丟丈专, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三下丌丈丄丅丟丈专 != 1152921536685928088);
    
    }
    private void 世专丛世一丟丅且丅(System.Action<Progress.与丄东丄丘丐丙丅业> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丏一三专丟与丆专不, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏一三专丟与丆专不 != 1152921536686064672);
    
    }
    private void 七万丞丑三丞三世七(System.Action<Progress.与丄东丄丘丐丙丅业> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丏一三专丟与丆专不, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丏一三专丟与丆专不 != 1152921536686201248);
    
    }
    private void 下丝丑丁丂丐三万三(System.Action<ClansTutorilStap> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丒下丝业专丑一丗, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丒下丝业专丑一丗 != 1152921536686337832);
    
    }
    private void 且丅七丞一东七万丕(System.Action<ClansTutorilStap> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丒下丝业专丑一丗, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丒下丝业专丑一丗 != 1152921536686474408);
    
    }
    private void OnEnable()
    {
        System.Action val_7;
        if(this._needCallHideForOperationBack != false)
        {
                System.Action val_1 = null;
            val_7 = val_1;
            val_1 = new System.Action(object:  this, method:  public System.Void ClansTutorilStap::U_Hide());
        }
        else
        {
                val_7 = 0;
        }
        
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_7, 与且专丈不万东一万:  System.String.Format(format:  "ClansTutorilStap_{0}", arg0:  this.gameObject.name));
    }
    private void OnDisable()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    internal void 丄专丁万不丄丗万且(Progress.不专丂万丐丄七上丗 丛不东丘丌丂丟丌丁, System.Action<Progress.不专丂万丐丄七上丗> 丈专且三丛东与丟丛)
    {
        this.东丆专东上丆与丏丂 = 丛不东丘丌丂丟丌丁;
        this.三下丌丈丄丅丟丈专 = 丈专且三丛东与丟丛;
    }
    internal void 丄专丁万不丄丗万且(Progress.与丄东丄丘丐丙丅业 丌丙丟万东丑丗业万, System.Action<Progress.与丄东丄丘丐丙丅业> 丈专且三丛东与丟丛)
    {
        this.丅丄丑下丛与丅丁丅 = 丌丙丟万东丑丗业万;
        this.丏一三专丟与丆专不 = 丈专且三丛东与丟丛;
    }
    internal void 业一丛丕丒丕且丂丛(ClansTutorialController.丙且丌业世万丂丝上 业丝丛且丛专丝业丁, System.Action<ClansTutorilStap> 上东七世丁下上万丑)
    {
        this.<专丙丑业丟丝东丑世>k__BackingField = 业丝丛且丛专丝业丁;
        this.丈丒下丝业专丑一丗 = 上东七世丁下上万丑;
    }
    public void U_Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        this.万丏丛东下丝下丟丕();
    }
    private void 万丏丛东下丝下丟丕()
    {
        if(this.三下丌丈丄丅丟丈专 != null)
        {
                this.三下丌丈丄丅丟丈专.Invoke(obj:  this.东丆专东上丆与丏丂);
        }
        
        if(this.丏一三专丟与丆专不 == null)
        {
                return;
        }
        
        this.丏一三专丟与丆专不.Invoke(obj:  this.丅丄丑下丛与丅丁丅);
    }
    private void OnDestroy()
    {
        if(this.丈丒下丝业专丑一丗 == null)
        {
                return;
        }
        
        this.丈丒下丝业专丑一丗.Invoke(obj:  this);
    }
    public ClansTutorilStap()
    {
    
    }

}
