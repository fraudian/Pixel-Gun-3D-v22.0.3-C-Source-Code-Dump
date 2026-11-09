using UnityEngine;

namespace PGCompany
{
    internal sealed class 万丘业丅丅丏丆东丈
    {
        // Fields
        private const string 与一丙丆丄丙七丘丈 = "Attribution.ConversionData";
        private const string 且丑不万丑与丞且万 = "Attribution.ConversionDataSent";
        private PGCompany.AppsFlyerTrackerCallbacks 丟七东丌丞丝与丏丙;
        private string 丅丂下丛丗丘万丙丝;
        private System.WeakReference<string> 丕丁丐三丆丞上专且;
        private System.WeakReference 丌下世丅七丂丞且一;
        private string 丞七丑且业上丄下丙;
        private bool 且丗丌业与丁丛丘丐;
        private static readonly PGCompany.万丘业丅丅丏丆东丈 <不丁丄七丛不丆丁丕>k__BackingField;
        
        // Properties
        internal static PGCompany.万丘业丅丅丏丆东丈 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        private PGCompany.AppsFlyerTrackerCallbacks 且丟三丑三不专三丈 { get; }
        
        // Methods
        private 万丘业丅丅丏丆东丈()
        {
            业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::丆与丂且丐与丝且丅()));
        }
        internal static PGCompany.万丘业丅丅丏丆东丈 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.万丘业丅丅丏丆东丈)PGCompany.万丘业丅丅丏丆东丈.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private PGCompany.AppsFlyerTrackerCallbacks 丟下专且丑业丌丐丏()
        {
            return (PGCompany.AppsFlyerTrackerCallbacks)this.丟七东丌丞丝与丏丙;
        }
        internal void 上丛丌丆丑上七世三()
        {
            var val_5;
            PGCompany.AppsFlyerTrackerCallbacks val_6;
            val_5 = null;
            if(PGCompany.万丘业丅丅丏丆东丈.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AttributionManager.Initialize]");
            }
            
            val_6 = this.丟七东丌丞丝与丏丙;
            if(val_6 == null)
            {
                    val_6 = PGCompany.AppsFlyerTrackerCallbacks.丑七不且上丗丁一世();
                this.丟七东丌丞丝与丏丙 = val_6;
            }
            
            val_6.三丞万丟下专上丁上(丙业与丙丗丝不丈东:  new System.EventHandler<System.String>(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::万且一且专上丆与丐(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)));
            this.丟七东丌丞丝与丏丙.上丆丆丂上丗丙丆丙(丙业与丙丗丝不丈东:  new System.EventHandler<System.String>(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::丂与且丄且下丐世专(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)));
        }
        internal string 与世丑下上丐丒丂丂()
        {
            string val_1 = 0;
            if(this.丕丁丐三丆丞上专且 != null)
            {
                    if((this.丕丁丐三丆丞上专且.TryGetTarget(target: out  val_1)) != false)
            {
                    if((System.String.IsNullOrWhiteSpace(value:  val_1)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            }
            
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Attribution.ConversionData")) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            string val_5 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Attribution.ConversionData");
            if((System.String.IsNullOrEmpty(value:  val_5)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            if(this.丕丁丐三丆丞上专且 != null)
            {
                    this.丕丁丐三丆丞上专且.SetTarget(target:  val_5);
                return (string)System.String.alignConst;
            }
            
            this.丕丁丐三丆丞上专且 = new System.WeakReference<System.String>(target:  val_5, trackResurrection:  false);
            return (string)System.String.alignConst;
        }
        internal System.Collections.Generic.IDictionary<string, object> 丈世丒一万丒丆专丞()
        {
            object val_6;
            if((this.丌下世丅七丂丞且一 != null) && ((this.丌下世丅七丂丞且一 & 1) != 0))
            {
                    val_6 = this.丌下世丅七丂丞且一;
                if(val_6 != null)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_6;
            }
            
            }
            
            string val_1 = this.与世丑下上丐丒丂丂();
            bool val_2 = System.String.IsNullOrEmpty(value:  val_1);
            if(val_2 != false)
            {
                    val_6 = PGCompany.丟丝下丕丄丛丞业丗<System.String, System.Object>.丟一丞丝丑七丈与丝();
                return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_6;
            }
            
            val_6 = val_2.不丕丒丕上七丌世丘(丒丟世丕三三丅一丗:  val_1);
            if(this.丌下世丅七丂丞且一 != null)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_6;
            }
            
            this.丌下世丅七丂丞且一 = new System.WeakReference(target:  val_6, trackResurrection:  false);
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_6;
        }
        private System.Collections.Generic.IDictionary<string, object> 不丕丒丕上七丌世丘(string 丒丟世丕三三丅一丗)
        {
            if((System.String.IsNullOrEmpty(value:  丒丟世丕三三丅一丗)) == true)
            {
                    return (System.Collections.Generic.IDictionary<System.String, System.Object>)PGCompany.丟丝下丕丄丛丞业丗<System.String, System.Object>.丟一丞丝丑七丈与丝();
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丒丟世丕三三丅一丗);
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)PGCompany.丟丝下丕丄丛丞业丗<System.String, System.Object>.丟一丞丝丑七丈与丝();
        }
        private System.Collections.IEnumerator 丛丕上且业上东丁一()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 万丘业丅丅丏丆东丈.丞下丕专丘丄丘丐且();
        }
        private System.Collections.IEnumerator 三丐丙与丒不丄丕且()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 万丘业丅丅丏丆东丈.上一丛丁三丗丟三丙();
        }
        private void 丗丙丌丙丂丗丞业不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            this.且丗丌业与丁丛丘丐 = false;
            if((丑与丂丌世丕丆一丗.ContainsKey(key:  "err_code")) != false)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "Attribution.ConversionDataSent", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private static void 丅万与世东上一丞丂(System.Collections.Generic.IDictionary<object, object> 丏丂万业丙专丏丒丒, System.Collections.Generic.IDictionary<string, object> 丐丆丂丒丁万丈丛丅, string 下上丐丆丝丟丝丒不)
        {
            string val_1 = PGCompany.万丘业丅丅丏丆东丈.与丞丝东东丑丗专丞(丐丆丂丒丁万丈丛丅:  丐丆丂丒丁万丈丛丅, 下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            var val_3 = 0;
            val_3 = val_3 + 1;
            丏丂万业丙专丏丒丒.set_Item(key:  null, value:  null);
        }
        private static string 与丞丝东东丑丗专丞(System.Collections.Generic.IDictionary<string, object> 丐丆丂丒丁万丈丛丅, string 下上丐丆丝丟丝丒不)
        {
            int val_3;
            TValue val_2 = 0;
            var val_4 = 0;
            val_4 = val_4 + 1;
            if((val_2 != 0) && ((丐丆丂丒丁万丈丛丅.TryGetValue(key:  ???, value: out  val_2)) != false))
            {
                    val_3 = val_2;
                return (string)val_3;
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal void 丗专丁三丝且东专且()
        {
            var val_5 = null;
            if(PGCompany.万丘业丅丅丏丆东丈.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AttributionManager.LoadAndSendConversionData]");
            }
            
            UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丛丕上且业上东丁一());
        }
        private void 万且一且专上丆与丐(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)
        {
            string val_6;
            var val_7;
            PGCompany.AppsFlyerTrackerCallbacks val_8;
            val_6 = 丗丛不丁丑专专丂且;
            val_7 = null;
            if(PGCompany.万丘业丅丅丏丆东丈.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AttributionManager.OnReceivedConversionData] " + val_6);
            }
            
            val_8 = this.丟七东丌丞丝与丏丙;
            if(val_8 != 0)
            {
                    this.丟七东丌丞丝与丏丙.丆丙丝丄丐丕丆丆丛(丙业与丙丗丝不丈东:  new System.EventHandler<System.String>(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::万且一且专上丆与丐(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)));
                val_8 = this.丟七东丌丞丝与丏丙;
                val_8.万丅丝丒丅万丒丂丘(丙业与丙丗丝不丈东:  new System.EventHandler<System.String>(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::丂与且丄且下丐世专(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)));
            }
            
            if(val_6 == null)
            {
                    val_6 = System.String.alignConst;
            }
            
            this.丅丂下丛丗丘万丙丝 = val_6;
        }
        private void 丂与且丄且下丐世专(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)
        {
            string val_6;
            var val_7;
            PGCompany.AppsFlyerTrackerCallbacks val_8;
            val_6 = 丗丛不丁丑专专丂且;
            val_7 = null;
            if(PGCompany.万丘业丅丅丏丆东丈.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[AttributionManager.OnReceivedConversionError] " + val_6);
            }
            
            val_8 = this.丟七东丌丞丝与丏丙;
            if(val_8 != 0)
            {
                    this.丟七东丌丞丝与丏丙.丆丙丝丄丐丕丆丆丛(丙业与丙丗丝不丈东:  new System.EventHandler<System.String>(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::万且一且专上丆与丐(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)));
                val_8 = this.丟七东丌丞丝与丏丙;
                val_8.万丅丝丒丅万丒丂丘(丙业与丙丗丝不丈东:  new System.EventHandler<System.String>(object:  this, method:  System.Void PGCompany.万丘业丅丅丏丆东丈::丂与且丄且下丐世专(object 不丟丗丏丛丕不丁丌, string 丗丛不丁丑专专丂且)));
            }
            
            if(val_6 == null)
            {
                    val_6 = System.String.alignConst;
            }
            
            this.丞七丑且业上丄下丙 = val_6;
        }
        private void 丆与丂且丐与丝且丅()
        {
            this.且丗丌业与丁丛丘丐 = false;
        }
        private static 万丘业丅丅丏丆东丈()
        {
            PGCompany.万丘业丅丅丏丆东丈.<不丁丄七丛不丆丁丕>k__BackingField = new PGCompany.万丘业丅丅丏丆东丈();
        }
        private bool 丛丅丑东丞专丝丟丗()
        {
            return (bool)this.且丗丌业与丁丛丘丐;
        }
        private bool 丕丂丙一丈三丄丁与()
        {
            return (bool)this.且丗丌业与丁丛丘丐;
        }
    
    }

}
