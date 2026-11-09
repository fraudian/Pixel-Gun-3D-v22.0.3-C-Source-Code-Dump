using UnityEngine;
public class BotAI : MonoBehaviour
{
    // Fields
    private BotTrigger 丒丈七丝与丕专丟丆;
    private BotHealth 丘丄丘上与不万丝世;
    private BotMovement 世丈三丟丛丈丛三丄;
    private bool 丄丛丌与下丁不丝丝;
    private bool 丙下丒与丗不一与丒;
    public UnityEngine.Transform homePoint;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.Transform Target;
    
    // Methods
    private void Awake()
    {
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Start()
    {
        this.Target = 0;
        this.世丈三丟丛丈丛三丄 = this.GetComponent<BotMovement>();
        this.丘丄丘上与不万丝世 = this.GetComponent<BotHealth>();
        this.万东万丆专丌丕丐丗 = this.transform;
        this.丒丈七丝与丕专丟丆 = this.GetComponent<BotTrigger>();
    }
    private void Update()
    {
        if(this.丘丄丘上与不万丝世.丁一丗专丂丏且世丈 == true)
        {
                return;
        }
        
        if(this.丙下丒与丗不一与丒 == true)
        {
                return;
        }
        
        this.SendMessage(methodName:  "Death");
        this.丒丈七丝与丕专丟丆.shouldDetectPlayer = false;
        this.丙下丒与丗不一与丒 = true;
    }
    public void SetTarget(UnityEngine.Transform 与且且丑丌业丙与三, bool 不专丁丌丌丌与丝世)
    {
        bool val_1 = 不专丁丌丌丌与丝世;
        this.丄丛丌与下丁不丝丝 = val_1;
        this.Target = 与且且丑丌业丙与三;
        this.世丈三丟丛丈丛三丄.SetTarget(丛丌丕丐世丑丂七丂:  与且且丑丌业丙与三, 不专丁丌丌丌与丝世:  val_1);
    }
    public BotAI()
    {
    
    }

}
