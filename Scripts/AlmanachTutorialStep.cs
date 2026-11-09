using UnityEngine;
public class AlmanachTutorialStep : MonoBehaviour
{
    // Fields
    protected AlmanachTutorialManager 下不万三丝丄且丝下;
    public string id;
    public string localKey;
    public bool setPositionOnUpdate;
    public int index;
    private UILabel label;
    public UnityEngine.Transform arrowPoint;
    
    // Methods
    public virtual void Init(AlmanachTutorialManager 下不万三丝丄且丝下)
    {
        this.gameObject.SetActive(value:  false);
        this.下不万三丝丄且丝下 = 下不万三丝丄且丝下;
        this.index = 下不万三丝丄且丝下.steps.IndexOf(item:  this);
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual void StartStep()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.localKey));
        this.gameObject.SetActive(value:  true);
        goto typeof(AlmanachTutorialStep).__il2cppRuntimeField_1A8;
    }
    public virtual void CompleteStep()
    {
        this.gameObject.SetActive(value:  false);
    }
    public virtual void SetPosition()
    {
        if(this.arrowPoint == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.arrowPoint.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public virtual void Update()
    {
        if(this.setPositionOnUpdate == false)
        {
                return;
        }
        
        goto typeof(AlmanachTutorialStep).__il2cppRuntimeField_1A8;
    }
    public AlmanachTutorialStep()
    {
        this.setPositionOnUpdate = true;
    }

}
