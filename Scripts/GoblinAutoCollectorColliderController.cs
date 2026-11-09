using UnityEngine;
internal sealed class GoblinAutoCollectorColliderController : PGBehaviour
{
    // Fields
    private UnityEngine.BoxCollider _goblinIdleCollider;
    private UnityEngine.BoxCollider _goblinSiegeCollider;
    
    // Methods
    private void OnEnable()
    {
        this.一一业丟东下丂丌与();
        GoblinAutoCollectorClanLobby.丌上丁业丐丟丐与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GoblinAutoCollectorColliderController::一一业丟东下丂丌与()));
    }
    private void OnDisable()
    {
        GoblinAutoCollectorClanLobby.一三世丝丙丒上丒业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GoblinAutoCollectorColliderController::一一业丟东下丂丌与()));
    }
    private void 一一业丟东下丂丌与()
    {
        if(this._goblinSiegeCollider != 0)
        {
                this._goblinSiegeCollider.enabled = false;
        }
        
        if(this._goblinIdleCollider != 0)
        {
                this._goblinIdleCollider.enabled = false;
        }
        
        if(一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与() < 1)
        {
                return;
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐不业一业丁丞世丏()) != 1)
        {
            goto label_13;
        }
        
        if(this._goblinSiegeCollider == 0)
        {
                return;
        }
        
        if(this._goblinSiegeCollider != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        this._goblinSiegeCollider.enabled = true;
        return;
        label_13:
        if(this._goblinIdleCollider == 0)
        {
                return;
        }
        
        if(this._goblinIdleCollider != null)
        {
            goto label_21;
        }
        
        goto label_22;
    }
    public void HandleClicked()
    {
        GoblinAutoCollectorClanLobby.丆丕丝丒不丙且丐丗.丈专丂丑且不丟上丕();
    }
    public GoblinAutoCollectorColliderController()
    {
    
    }

}
