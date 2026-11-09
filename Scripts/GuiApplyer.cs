using UnityEngine;
[Serializable]
public class GuiApplyer : MonoBehaviour
{
    // Fields
    public string resourceId;
    protected GuiApplyersGroup guiApplyersGroup;
    
    // Properties
    public GuiApplyersGroup Group { get; }
    
    // Methods
    public GuiApplyersGroup get_Group()
    {
        return (GuiApplyersGroup)this.guiApplyersGroup;
    }
    internal virtual void 丈且东丑丂且万丒丅(GuiApplyersGroup 专与万丐七丌丐丁丂)
    {
        this.guiApplyersGroup = 专与万丐七丌丐丁丂;
    }
    internal virtual void OnEnable()
    {
        if(this.guiApplyersGroup == 0)
        {
                return;
        }
        
        if((this.guiApplyersGroup.allGuiApplyers.Contains(item:  this)) != false)
        {
                return;
        }
        
        if(this.guiApplyersGroup == null)
        {
            
        }
    
    }
    protected virtual void OnDisable()
    {
    
    }
    protected virtual void 不丏丌丟丑丄丟上丝()
    {
    
    }
    internal virtual bool 七丆业丗不业丙丏三()
    {
        return UnityEngine.Object.op_Inequality(x:  this.guiApplyersGroup, y:  0);
    }
    internal virtual bool 三业丒丑丂三丕上丛()
    {
        return false;
    }
    public GuiApplyer()
    {
    
    }

}
