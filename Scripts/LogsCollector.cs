using UnityEngine;
public class LogsCollector : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<LogsCollectorLog> 专丛丅业丞丗丗专丝;
    private bool 丕丙世不丝与一三丌;
    public System.Action<LogsCollectorLog> OnLogAdded;
    private bool 丁丟丂丗万且一丈丏;
    private UnityEngine.LogType[] logTypes;
    private bool 万世七丙丑三东丌丝;
    
    // Properties
    public System.Collections.Generic.List<LogsCollectorLog> 丌丟丂一丌丐丌上一 { get; }
    
    // Methods
    public System.Collections.Generic.List<LogsCollectorLog> get_logs()
    {
        return (System.Collections.Generic.List<LogsCollectorLog>)this.专丛丅业丞丗丗专丝;
    }
    public void StartLogging(bool 丁一丁丙丌丆七丏万 = False)
    {
        var val_7;
        if(丁一丁丙丌丆七丏万 != false)
        {
                this.专丛丅业丞丗丗专丝 = new System.Collections.Generic.List<LogsCollectorLog>();
        }
        
        this.丁丟丂丗万且一丈丏 = true;
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_7 = 1;
        this.万世七丙丑三东丌丝 = UnityEngine.Debug.unityLogger.logEnabled;
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_7 = 2;
        UnityEngine.Debug.unityLogger.logEnabled = true;
    }
    public void EndLogging()
    {
        this.丁丟丂丗万且一丈丏 = false;
        var val_4 = 0;
        val_4 = val_4 + 1;
        UnityEngine.Debug.unityLogger.logEnabled = (this.万世七丙丑三东丌丝 == true) ? 1 : 0;
    }
    public void ClearLogs()
    {
        this.专丛丅业丞丗丗专丝.Clear();
    }
    private void 不丑丗丈不丟丌下丄(string 丆丌丞一丞丅丙上丟, string 三丐丄上丕下丞丅专, UnityEngine.LogType 丁丅丈丌丟世丗丗丟)
    {
        LogsCollectorLog val_3;
        var val_4;
        if(this.丁丟丂丗万且一丈丏 == false)
        {
                return;
        }
        
        val_4 = 0;
        goto label_2;
        label_9:
        val_3 = 0;
        if(this.logTypes[0] == 丁丅丈丌丟世丗丗丟)
        {
                LogsCollectorLog val_1 = null;
            val_3 = val_1;
            val_1 = new LogsCollectorLog();
            .logType = 丁丅丈丌丟世丗丗丟;
            .logString = 丆丌丞一丞丅丙上丟;
            .stackTrace = 三丐丄上丕下丞丅专;
            this.专丛丅业丞丗丗专丝.Add(item:  val_1);
            if(this.OnLogAdded != null)
        {
                (this.OnLogAdded == 0) ? 0 : this.OnLogAdded.Invoke(obj:  val_1);
        }
        
        }
        
        val_4 = 1;
        label_2:
        if(val_4 < this.logTypes.Length)
        {
            goto label_9;
        }
    
    }
    public System.Collections.Generic.List<LogsCollectorLog> logsOfType(UnityEngine.LogType 丁丅丈丌丟世丗丗丟)
    {
        System.Collections.Generic.List<LogsCollectorLog> val_5;
        var val_6;
        val_5 = this;
        if((this.专丛丅业丞丗丗专丝 == null) || (this.专丛丅业丞丗丗专丝.Count == 0))
        {
            goto label_2;
        }
        
        System.Collections.Generic.List<LogsCollectorLog> val_2 = null;
        val_6 = val_2;
        val_2 = new System.Collections.Generic.List<LogsCollectorLog>();
        val_5 = this.专丛丅业丞丗丗专丝;
        List.Enumerator<T> val_3 = val_5.GetEnumerator();
        label_8:
        if(((-688525496) & 1) == 0)
        {
            goto label_4;
        }
        
        if(val_4.m_stringLength != 丁丅丈丌丟世丗丗丟)
        {
            goto label_8;
        }
        
        val_2.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_8;
        label_2:
        val_6 = 0;
        return (System.Collections.Generic.List<LogsCollectorLog>)val_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<LogsCollectorLog>)val_6;
    }
    public System.Collections.Generic.List<LogsCollectorLog> logsOfTypes(UnityEngine.LogType[] 一丕丅一丕丘世丑丆)
    {
        System.Collections.Generic.List<LogsCollectorLog> val_5;
        var val_6;
        val_5 = this;
        if((this.专丛丅业丞丗丗专丝 == null) || (this.专丛丅业丞丗丗专丝.Count == 0))
        {
            goto label_2;
        }
        
        System.Collections.Generic.List<LogsCollectorLog> val_2 = null;
        val_6 = val_2;
        val_2 = new System.Collections.Generic.List<LogsCollectorLog>();
        val_5 = this.专丛丅业丞丗丗专丝;
        List.Enumerator<T> val_3 = val_5.GetEnumerator();
        label_11:
        if(((-688335688) & 1) == 0)
        {
            goto label_4;
        }
        
        var val_6 = 0;
        label_9:
        if(val_6 >= 一丕丅一丕丘世丑丆.Length)
        {
            goto label_11;
        }
        
        val_6 = val_6 + 1;
        if(val_4.m_stringLength != 一丕丅一丕丘世丑丆[0])
        {
            goto label_9;
        }
        
        val_2.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_11;
        label_2:
        val_6 = 0;
        return (System.Collections.Generic.List<LogsCollectorLog>)val_6;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<LogsCollectorLog>)val_6;
    }
    private void Awake()
    {
        UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  this, method:  System.Void LogsCollector::不丑丗丈不丟丌下丄(string 丆丌丞一丞丅丙上丟, string 三丐丄上丕下丞丅专, UnityEngine.LogType 丁丅丈丌丟世丗丗丟)));
    }
    private void OnDestroy()
    {
        UnityEngine.Application.remove_logMessageReceived(value:  new Application.LogCallback(object:  this, method:  System.Void LogsCollector::不丑丗丈不丟丌下丄(string 丆丌丞一丞丅丙上丟, string 三丐丄上丕下丞丅专, UnityEngine.LogType 丁丅丈丌丟世丗丗丟)));
    }
    private void Update()
    {
        if(this.丕丙世不丝与一三丌 == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  116)) != false)
        {
                this.StartLogging(丁一丁丙丌丆七丏万:  false);
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  121)) != false)
        {
                this.EndLogging();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  117)) == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  this.专丛丅业丞丗丗专丝);
    }
    public LogsCollector()
    {
        this.专丛丅业丞丗丗专丝 = new System.Collections.Generic.List<LogsCollectorLog>();
        this.logTypes = new UnityEngine.LogType[1];
    }

}
