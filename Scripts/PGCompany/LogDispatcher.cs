using UnityEngine;

namespace PGCompany
{
    internal sealed class LogDispatcher : MonoBehaviour
    {
        // Fields
        private static PGCompany.LogDispatcher 与东丝丈上丐东丞丁;
        private System.Collections.Concurrent.ConcurrentBag<System.Exception> 丙上丄丟业丑丄丆丄;
        private System.Collections.Concurrent.ConcurrentBag<string> 专丅丗丙不东三世丆;
        private System.Collections.Concurrent.ConcurrentBag<string> 一与东丌专丄不业世;
        
        // Properties
        internal static PGCompany.LogDispatcher 丗丗丟丙专丙丟丏丟 { get; }
        
        // Methods
        internal static PGCompany.LogDispatcher 万世丅七一专丕丞不()
        {
            PGCompany.LogDispatcher val_3;
            if((UnityEngine.Object.op_Implicit(exists:  PGCompany.LogDispatcher.与东丝丈上丐东丞丁)) != false)
            {
                    val_3 = PGCompany.LogDispatcher.与东丝丈上丐东丞丁;
                return val_2;
            }
            
            PGCompany.LogDispatcher val_2 = PGCompany.LogDispatcher.东丝七业丄丑丒世七();
            PGCompany.LogDispatcher.与东丝丈上丐东丞丁 = val_2;
            return val_2;
        }
        private static PGCompany.LogDispatcher 东丝七业丄丑丒世七()
        {
            UnityEngine.GameObject val_2 = CoroutineRunner.Instance.gameObject;
            if(val_2 != null)
            {
                    return val_2.AddComponent<PGCompany.LogDispatcher>();
            }
            
            return val_2.AddComponent<PGCompany.LogDispatcher>();
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            if(PGCompany.LogDispatcher.与东丝丈上丐东丞丁 != null)
            {
                    return;
            }
            
            PGCompany.LogDispatcher.与东丝丈上丐东丞丁 = PGCompany.LogDispatcher.东丝七业丄丑丒世七();
        }
        internal void 丁丌丘丝丗万丕丘三(string 丄丙下丝丛丒七丂丘)
        {
            System.Collections.Concurrent.ConcurrentBag<System.String> val_2;
            if(丄丙下丝丛丒七丂丘 == null)
            {
                    return;
            }
            
            val_2 = this.专丅丗丙不东三世丆;
            if(val_2 == null)
            {
                    System.Collections.Concurrent.ConcurrentBag<System.String> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Concurrent.ConcurrentBag<System.String>();
                this.专丅丗丙不东三世丆 = val_2;
            }
            
            val_1.Add(item:  丄丙下丝丛丒七丂丘);
        }
        internal void 与丐丞一与七七七丂(string 丄丙下丝丛丒七丂丘)
        {
            System.Collections.Concurrent.ConcurrentBag<System.String> val_2;
            if(丄丙下丝丛丒七丂丘 == null)
            {
                    return;
            }
            
            val_2 = this.一与东丌专丄不业世;
            if(val_2 == null)
            {
                    System.Collections.Concurrent.ConcurrentBag<System.String> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Concurrent.ConcurrentBag<System.String>();
                this.一与东丌专丄不业世 = val_2;
            }
            
            val_1.Add(item:  丄丙下丝丛丒七丂丘);
        }
        internal void 丗且世与丗丑下且上(System.Exception 世丝丒丙下东丗丙上)
        {
            System.Collections.Concurrent.ConcurrentBag<System.Exception> val_2;
            if(世丝丒丙下东丗丙上 == null)
            {
                    return;
            }
            
            val_2 = this.丙上丄丟业丑丄丆丄;
            if(val_2 == null)
            {
                    System.Collections.Concurrent.ConcurrentBag<System.Exception> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Concurrent.ConcurrentBag<System.Exception>();
                this.丙上丄丟业丑丄丆丄 = val_2;
            }
            
            val_1.Add(item:  世丝丒丙下东丗丙上);
        }
        private void Update()
        {
            System.Collections.Concurrent.ConcurrentBag<System.Exception> val_7;
            var val_8;
            System.Collections.Concurrent.ConcurrentBag<System.String> val_9;
            System.Collections.Concurrent.ConcurrentBag<System.String> val_10;
            object val_3 = 0;
            System.Exception val_1 = 0;
            object val_5 = 0;
            val_7 = this.丙上丄丟业丑丄丆丄;
            if(val_7 == null)
            {
                goto label_1;
            }
            
            val_8 = 1152921555753619888;
            goto label_2;
            label_6:
            UnityEngine.Debug.LogException(exception:  val_1);
            val_7 = this.丙上丄丟业丑丄丆丄;
            label_2:
            if((val_7.TryTake(result: out  val_1)) == true)
            {
                goto label_6;
            }
            
            label_1:
            val_9 = this.一与东丌专丄不业世;
            if(val_9 == null)
            {
                goto label_7;
            }
            
            val_8 = 1152921555753629104;
            goto label_8;
            label_12:
            UnityEngine.Debug.LogWarning(message:  val_3);
            val_9 = this.一与东丌专丄不业世;
            label_8:
            if((val_9.TryTake(result: out  val_3)) == true)
            {
                goto label_12;
            }
            
            label_7:
            val_10 = this.专丅丗丙不东三世丆;
            if(val_10 == null)
            {
                    return;
            }
            
            val_8 = 1152921555753629104;
            goto label_14;
            label_18:
            UnityEngine.Debug.Log(message:  val_5);
            val_10 = this.专丅丗丙不东三世丆;
            label_14:
            if((val_10.TryTake(result: out  val_5)) == true)
            {
                goto label_18;
            }
        
        }
        public LogDispatcher()
        {
        
        }
    
    }

}
