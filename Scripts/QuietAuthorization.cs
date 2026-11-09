using UnityEngine;
internal class QuietAuthorization : Singleton<QuietAuthorization>
{
    // Fields
    private UnityEngine.Coroutine 东丗丌丑丕丏丏丏丂;
    
    // Properties
    internal bool 东丏丌丝三丂东不万 { get; }
    internal bool 丛丙且与丏丆丟丐丘 { get; }
    
    // Methods
    internal bool 丗与丄万丈与丐专业()
    {
        if(this.丝丞与丏七丈丆丕丒() == true)
        {
                return false;
        }
        
        if(AuthSceneController.丏丌丏丞丄与上丌丂() == false)
        {
                return false;
        }
        
        if(AuthSceneController.丑七不且上丗丁一世() == 0)
        {
                if(ConnectionLostChecker.且三世专下丂丏与下() != 1)
        {
            goto label_6;
        }
        
        }
        
        return false;
        label_6:
        if(ConnectionLostChecker.世丁世丆丙丅丄丑丌() != false)
        {
                if(ConnectionLostChecker.业丌丗丘一丆丝且丞() == false)
        {
                return false;
        }
        
        }
        
        if(ConnectionLostChecker.丐丒丟一丆丛万丟业() != false)
        {
                return false;
        }
        
        ConnectionLostChecker val_9 = ConnectionLostChecker.丑七不且上丗丁一世();
        if(val_9 != null)
        {
                return val_9.东不丙丅丏丘丄东丘();
        }
        
        return val_9.东不丙丅丏丘丄东丘();
    }
    internal bool 丝丞与丏七丈丆丕丒()
    {
        var val_6;
        var val_7;
        val_6 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
        if(val_6.丌丞东丅上丁不丗丄() == 9)
        {
                val_7 = 1;
            return (bool)(val_6.丌丞东丅上丁不丗丄() == 10) ? 1 : 0;
        }
        
        val_6 = 业丞丝东丅丞丐丌专.丑七不且上丗丁一世();
        return (bool)(val_6.丌丞东丅上丁不丗丄() == 10) ? 1 : 0;
    }
    internal void 丛世东丛丐丅七丙丗()
    {
        null = null;
        Progress.下丁下丂七丆丙七一.丙丘七丝丘丕丙丅专 = false;
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丏丂丙一丛万与丅丞();
    }
    private void 丄三东与丂七不世上()
    {
        if(this.东丗丌丑丕丏丏丏丂 != null)
        {
                this.StopCoroutine(routine:  this.东丗丌丑丕丏丏丏丂);
        }
        
        this.东丗丌丑丕丏丏丏丂 = this.StartCoroutine(routine:  this.丐上丞丕丏一丐万东());
    }
    private void 万丞丛下业丑一丌丛()
    {
        if(this.东丗丌丑丕丏丏丏丂 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.东丗丌丑丕丏丏丏丂);
        this.东丗丌丑丕丏丏丏丂 = 0;
    }
    private System.Collections.IEnumerator 丐上丞丕丏一丐万东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new QuietAuthorization.丈丙丘丝上不丐丝且();
    }
    private void Awake()
    {
        业丞丝东丅丞丐丌专.丛丁专专一一丒丑丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void QuietAuthorization::丄三东与丂七不世上()));
        业丞丝东丅丞丐丌专.专丗丕且丞上丁丐丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void QuietAuthorization::万丞丛下业丑一丌丛()));
        业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void QuietAuthorization::万丞丛下业丑一丌丛()));
    }
    public QuietAuthorization()
    {
    
    }

}
