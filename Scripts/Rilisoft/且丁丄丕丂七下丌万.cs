using UnityEngine;

namespace Rilisoft
{
    public class 且丁丄丕丂七下丌万 : 丘丈丒丕丂丅丞与丙
    {
        // Fields
        private string <七丆丕丑丆专丂丂万>k__BackingField;
        
        // Properties
        protected string 与丌丘专专与一丅且 { get; set; }
        
        // Methods
        public 且丁丄丕丂七下丌万(string 丂万一与丈丛丝丌丝)
        {
            this.<七丆丕丑丆专丂丂万>k__BackingField = 丂万一与丈丛丝丌丝;
        }
        protected string 丒丌丒专丙下一丅万()
        {
            return (string)this.<七丆丕丑丆专丂丂万>k__BackingField;
        }
        protected void 丏丌业丘丏与业丘丞(string 丙业与丙丗丝不丈东)
        {
            this.<七丆丕丑丆专丂丂万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 专业丛丂丅与世上丙(bool 与且专丏丅世丐丐丑 = True)
        {
            System.Threading.Tasks.TaskCompletionSource<Rilisoft.丌业丒一丛专万三世> val_1 = new System.Threading.Tasks.TaskCompletionSource<Rilisoft.丌业丒一丛专万三世>();
            if(val_1 != null)
            {
                    val_1.SetResult(result:  0);
                return val_1.Task;
            }
            
            val_1.SetResult(result:  0);
            return val_1.Task;
        }
        public override void 丅万丞丘与丏丝丕丅(string 一丐丗丁丞丆丅丟丄)
        {
            if(一丐丗丁丞丆丅丟丄 != null)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = ((this.<七丆丕丑丆专丂丂万>k__BackingField) == null) ? "null" : this.<七丆丕丑丆专丂丂万>k__BackingField;
            UnityEngine.Debug.LogErrorFormat(format:  "EditorCloudSlotSynchronizer.Push: data == null , slotName = {0}", args:  val_1);
        }
        protected string 世丒业丂一上丆一东()
        {
            return Rilisoft.且丁丄丕丂七下丌万.专丏下丞丙下丟丛一(丂万一与丈丛丝丌丝:  this.<七丆丕丑丆专丂丂万>k__BackingField);
        }
        internal static string 专丏下丞丙下丟丛一(string 丂万一与丈丛丝丌丝)
        {
            return System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  丂万一与丈丛丝丌丝);
        }
    
    }

}
