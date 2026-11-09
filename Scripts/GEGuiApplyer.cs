using UnityEngine;
[Serializable]
public class GEGuiApplyer : MonoBehaviour
{
    // Fields
    public string resourceName;
    internal bool beenApplyed;
    internal Rilisoft.GameEventOpenChestBase openChestBanner;
    internal Rilisoft.AbstractGameEventGui gameEventGui;
    internal Rilisoft.GameEventSetsViewBase setsViewBase;
    internal Rilisoft.InAppBonusLobbyButtonDependingObject bonusLobbyButton;
    internal Rilisoft.GameEventExtendedEventInfoView gameEventExtendedEventInfoView;
    private Rilisoft.丛且世丐丆上七业丁 lastContext;
    internal bool SkipCheckCanApply;
    
    // Properties
    internal Rilisoft.丛且世丐丆上七业丁 Context { get; }
    
    // Methods
    internal Rilisoft.丛且世丐丆上七业丁 get_Context()
    {
        Rilisoft.InAppBonusLobbyButtonDependingObject val_6;
        Rilisoft.丛且世丐丆上七业丁 val_7;
        val_6 = this;
        if(this.openChestBanner != 0)
        {
                if(this.openChestBanner != null)
        {
                return this.openChestBanner.丄丌一七丈万万丌丐();
        }
        
            return this.openChestBanner.丄丌一七丈万万丌丐();
        }
        
        if(this.gameEventGui != 0)
        {
                if(this.gameEventGui != null)
        {
                return this.gameEventGui.Context;
        }
        
            return this.gameEventGui.Context;
        }
        
        if(this.setsViewBase != 0)
        {
                if(this.setsViewBase != null)
        {
                return this.setsViewBase.Context;
        }
        
            return this.setsViewBase.Context;
        }
        
        if(this.bonusLobbyButton != 0)
        {
                val_6 = this.bonusLobbyButton;
            val_7 = this.bonusLobbyButton.gameEvent;
            return val_7;
        }
        
        val_7 = 0;
        if(this.gameEventExtendedEventInfoView == 0)
        {
                return val_7;
        }
        
        if(this.gameEventExtendedEventInfoView != null)
        {
                return this.gameEventExtendedEventInfoView.ContextEvent;
        }
        
        return this.gameEventExtendedEventInfoView.ContextEvent;
    }
    internal virtual void 丘上丐世丆丑且丞丒()
    {
        if(this.gameEventGui == 0)
        {
                this.gameEventGui = this.GetComponentInParent<Rilisoft.AbstractGameEventGui>();
        }
        
        if(this.setsViewBase == 0)
        {
                this.setsViewBase = this.GetComponentInParent<Rilisoft.GameEventSetsViewBase>();
        }
        
        if(this.bonusLobbyButton == 0)
        {
                this.bonusLobbyButton = this.GetComponentInParent<Rilisoft.InAppBonusLobbyButtonDependingObject>();
        }
        
        if(this.gameEventExtendedEventInfoView == 0)
        {
                this.gameEventExtendedEventInfoView = this.GetComponentInParent<Rilisoft.GameEventExtendedEventInfoView>();
        }
        
        if(this.openChestBanner != 0)
        {
                return;
        }
        
        this.openChestBanner = this.GetComponentInParent<Rilisoft.GameEventOpenChestBase>();
    }
    internal virtual void OnEnable()
    {
        if(this.lastContext != null)
        {
                if(this.lastContext == this.Context)
        {
                return;
        }
        
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this);
    }
    protected virtual void OnDisable()
    {
    
    }
    internal virtual System.Collections.IEnumerator 三世丛一丄丒丁东与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GEGuiApplyer.丗丄丈业丆东业丆专();
    }
    internal virtual bool 七丆业丗不业丙丏三()
    {
        var val_4;
        if(this.Context == null)
        {
                return (bool)(this.lastContext != this.Context) ? 1 : 0;
        }
        
        if(this.SkipCheckCanApply == false)
        {
                return (bool)(this.lastContext != this.Context) ? 1 : 0;
        }
        
        val_4 = 1;
        return (bool)(this.lastContext != this.Context) ? 1 : 0;
    }
    internal virtual bool 三业丒丑丂三丕上丛()
    {
        this.beenApplyed = true;
        this.lastContext = this.Context;
        return false;
    }
    public GEGuiApplyer()
    {
    
    }

}
