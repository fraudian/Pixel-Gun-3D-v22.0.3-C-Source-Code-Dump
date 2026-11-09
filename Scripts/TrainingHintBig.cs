using UnityEngine;
public class TrainingHintBig : MonoBehaviour
{
    // Fields
    public UILabel hintLabel;
    public UnityEngine.GameObject newTask;
    public UILabel newTaskDescription;
    public UIBasicSprite newTaskIcon;
    private UnityEngine.BoxCollider 且丙与丏下丅丐世丑;
    private TrainingHints.BigHintItem 丙不丈东丒下三丛丁;
    private int 上世上丂丆东下东丒;
    private System.Action 万万丗丛丏丐七丘丏;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    private UIBasicSprite 下与丕一丏下且业丒 { get; }
    
    // Methods
    private UIBasicSprite 丂丄一丐世万丏不专()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.newTaskIcon);
        this.newTaskIcon = val_1;
        return val_1;
    }
    public void Show(TrainingHints.BigHintItem 丙不丈东丒下三丛丁, System.Action 万万丗丛丏丐七丘丏)
    {
        bool val_23;
        丈万丆丒上丅且上丛 val_24;
        var val_25;
        this.gameObject.SetActive(value:  true);
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.万万丗丛丏丐七丘丏 = 万万丗丛丏丐七丘丏;
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void TrainingHintBig::下丗丒三上上丅丟丞()), 与且专丈不万东一万:  "Big training hint");
        this.丙不丈东丒下三丛丁 = 丙不丈东丒下三丛丁;
        this.上世上丂丆东下东丒 = 0;
        val_23 = 丙不丈东丒下三丛丁.showCurrentTask;
        this.newTask.SetActive(value:  (val_23 == true) ? 1 : 0);
        if(丙不丈东丒下三丛丁.showCurrentTask == false)
        {
            goto label_19;
        }
        
        TrainingHintBig.丗丛丘丑丐不丌丑丙 val_7 = new TrainingHintBig.丗丛丘丑丐不丌丑丙();
        val_23 = QuestsGSMAnager.丑七不且上丗丁一世();
        val_24 = val_23.ActiveTask;
        if(val_7 == null)
        {
            goto label_16;
        }
        
        val_25 = val_7;
        .丏丏丝丐丙与丏东世 = val_24;
        if(val_24 != null)
        {
            goto label_17;
        }
        
        goto label_19;
        label_16:
        val_25 = 16;
        mem[16] = val_24;
        val_24 = mem[16];
        if(val_24 == 0)
        {
            goto label_19;
        }
        
        label_17:
        if(val_7 == null)
        {
                if(val_25 == 0)
        {
            goto label_21;
        }
        
        }
        
        this.newTaskDescription.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_9 + 16);
        if((TasksWindow.丅丒丞丑丝丞丏丆一(万东丆丞东且丘且丒:  mem[16])) != false)
        {
                val_23 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_7, method:  System.Boolean TrainingHintBig.丗丛丘丑丐不丌丑丙::丆且丒丗丈丞丈丘且(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟))).丙三专万丛丟万丝丘());
            if(this.丂丄一丐世万丏不专() != null)
        {
            goto label_32;
        }
        
        }
        else
        {
                val_23 = this.丂丄一丐世万丏不专();
            UnityEngine.Texture val_21 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "TaskGSIcons/task_icon_{0}", arg0:  val_9 + 32));
        }
        
        label_32:
        label_19:
        this.丐丗丐丄七丐丙上一();
        return;
        label_21:
    }
    public void Hide()
    {
        this.gameObject.SetActive(value:  false);
        if(this.万万丗丛丏丐七丘丏 == null)
        {
                return;
        }
        
        this.万万丗丛丏丐七丘丏.Invoke();
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void 下丗丒三上上丅丟丞()
    {
        int val_1 = this.上世上丂丆东下东丒 + 1;
        this.上世上丂丆东下东丒 = val_1;
        if(val_1 < this.丙不丈东丒下三丛丁.steps.Length)
        {
                this.丐丗丐丄七丐丙上一();
            return;
        }
        
        this.Hide();
    }
    private void 丐丗丐丄七丐丙上一()
    {
        this.hintLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丙不丈东丒下三丛丁.steps[(this.上世上丂丆东下东丒) << 4]);
    }
    private void Awake()
    {
        this.且丙与丏下丅丐世丑 = this.GetComponent<UnityEngine.BoxCollider>();
    }
    private void Update()
    {
    
    }
    private void OnClick()
    {
        this.下丗丒三上上丅丟丞();
    }
    public void HandleSkipButtonClick()
    {
        this.Hide();
    }
    public TrainingHintBig()
    {
    
    }

}
