using UnityEngine;
internal sealed class TaskUIImposterModeShieldRepair : TaskUIImposterModeAbstract
{
    // Fields
    private TaskUIImposterNumButton _shieldIndicatorExample;
    private System.Collections.Generic.List<UnityEngine.Transform> _shieldIndicatorPoints;
    private UnityEngine.GameObject completeMessage;
    private UnityEngine.AudioClip shipClip;
    private UnityEngine.AudioSource audioSource;
    private System.Collections.Generic.List<TaskUIImposterNumButton> 丑丐七丏丕专业下东;
    
    // Methods
    protected override void Awake()
    {
        if(this.丑丐七丏丕专业下东.Count != 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<TaskUIImposterNumButton>(专下丐丒丈万丗丟丝:  this.丑丐七丏丕专业下东, 专丑业丁丗丏丌不丛:  this._shieldIndicatorExample.gameObject, 丈东丘丏与丌东东下:  this.transform, 与业丄丂丂丆下上丞:  this._shieldIndicatorPoints.Count - 1, 丏东下下一丗专下丏:  0);
        this.丑丐七丏丕专业下东.Insert(index:  0, item:  this._shieldIndicatorExample);
    }
    protected override void OnEnable()
    {
        this.丑丐七丏丕专业下东.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeShieldRepair::丈丌丗丟丐丝上且丕(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
        this.OnEnable();
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  false);
        this.业丈丂丌丂丁丌丐丑();
        this.丛不上丛一丆丛丅下();
    }
    private void 业丈丂丌丂丁丌丐丑()
    {
        this.audioSource.clip = 0;
        this.audioSource.loop = false;
        this.audioSource.Stop();
    }
    private void 丛不上丛一丆丛丅下()
    {
        this.audioSource.clip = this.shipClip;
        this.audioSource.loop = true;
        this.audioSource.Play();
    }
    protected override void OnDisable()
    {
        this.业丈丂丌丂丁丌丐丑();
        this.丑丐七丏丕专业下东.ForEach(action:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeShieldRepair::丆丂专丆不业丐丒丗(TaskUIImposterNumButton 丞丘世丕丝与专丗七)));
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.丕东丟丌三丕丗丅丞();
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        this.业丈丂丌丂丁丌丐丑();
        this.丛不上丛一丆丛丅下();
    }
    private void 丕东丟丌三丕丗丅丞()
    {
        UnityEngine.Transform val_16;
        var val_17;
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        if(val_3 != null)
        {
                val_3.Add(item:  0);
            val_3.Add(item:  1);
            val_3.Add(item:  2);
            val_3.Add(item:  3);
            val_3.Add(item:  4);
            val_3.Add(item:  5);
        }
        else
        {
                val_3.Add(item:  0);
            val_3.Add(item:  1);
            val_3.Add(item:  2);
            val_3.Add(item:  3);
            val_3.Add(item:  4);
            val_3.Add(item:  5);
        }
        
        val_3.Add(item:  6);
        val_16 = new System.Random(Seed:  丐丕不丅三专万丕丗());
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        if(val_16 >= 1)
        {
                do
        {
            int val_5 = val_3.Count;
            int val_6 = val_3.Item[-1368777904];
            val_4.Add(item:  val_6);
            val_3.RemoveAt(index:  val_6);
            val_16 = val_16 - 1;
        }
        while(val_16 != null);
        
        }
        
        val_17 = 0;
        goto label_11;
        label_29:
        TaskUIImposterNumButton val_7 = this.丑丐七丏丕专业下东.Item[0];
        val_7.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
        val_7.丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
        bool val_8 = val_4.Contains(item:  0);
        TaskUIImposterNumButton val_9 = this.丑丐七丏丕专业下东.Item[0];
        if(val_9 == null)
        {
            goto label_16;
        }
        
        if(val_8 == false)
        {
            goto label_17;
        }
        
        label_19:
        val_9.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  true);
        goto label_18;
        label_16:
        if(val_8 == true)
        {
            goto label_19;
        }
        
        label_17:
        val_9.丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  true);
        label_18:
        val_16 = this._shieldIndicatorPoints.Item[0];
        this.丑丐七丏丕专业下东.Item[0].transform.SetParent(p:  val_16);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丑丐七丏丕专业下东.Item[0].transform);
        val_17 = 1;
        label_11:
        if(val_17 < this.丑丐七丏丕专业下东.Count)
        {
            goto label_29;
        }
    
    }
    private void 世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)
    {
        var val_6;
        UnityEngine.Debug.LogError(message:  "ActionOnPress");
        if(丟丄丕且丝丛与业丛 != null)
        {
                丟丄丕且丝丛与业丛.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
            丟丄丕且丝丛与业丛.丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
        }
        else
        {
                0.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  false);
            0.丛七丘上丂上丘丙丞(丏业丟一东丂东丘丛:  false);
        }
        
        丟丄丕且丝丛与业丛.东丄丅丆丙丏丟丏丒(丏业丟一东丂东丘丛:  true);
        List.Enumerator<T> val_1 = this.丑丐七丏丕专业下东.GetEnumerator();
        val_6 = 0;
        goto label_6;
        label_8:
        val_6 = val_6 + 0.丐丏七丌丕丗业且上().丑丈与丛丕一丞丏丐();
        label_6:
        if(((-1368623880) & 1) != 0)
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_6 < this.丑丐七丏丕专业下东.Count)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.completeMessage, 丏业丟一东丂东丘丛:  true);
        this.万丏丛东下丝下丟丕();
    }
    public TaskUIImposterModeShieldRepair()
    {
        this._shieldIndicatorPoints = new System.Collections.Generic.List<UnityEngine.Transform>();
        this.丑丐七丏丕专业下东 = new System.Collections.Generic.List<TaskUIImposterNumButton>();
        this = new PGBehaviour();
    }
    private void 丈丌丗丟丐丝上且丕(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.万丂丐丛丒万下丝一(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeShieldRepair::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }
    private void 丆丂专丆不业丐丒丗(TaskUIImposterNumButton 丞丘世丕丝与专丗七)
    {
        丞丘世丕丝与专丗七.丙与丏丈丘三丅丏丟(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposterNumButton>(object:  this, method:  System.Void TaskUIImposterModeShieldRepair::世丙一七丂下丗丂一(TaskUIImposterNumButton 丟丄丕且丝丛与业丛)));
    }

}
