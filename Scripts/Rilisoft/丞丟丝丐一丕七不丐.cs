using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丞丟丝丐一丕七不丐
    {
        // Fields
        private readonly string 丘下与丞丘丕丛东丒;
        private readonly int 丘与丟丏与丂下万丘;
        private readonly float 且业丁丝丐丅且上丝;
        private int 东丘且丂下丟一七丕;
        private float 世专且世东丒一上丑;
        private readonly System.Diagnostics.Stopwatch 三丘丙丞丏丗一丏上;
        
        // Properties
        public string 丄丄一丐东丐丝丗七 { get; }
        public int 丝万丟上与与上东丕 { get; }
        public float 丄上丏丈且丟世三丄 { get; }
        public System.TimeSpan 丂丑且丑丟与丙三丐 { get; }
        
        // Methods
        public string 丄丌一七丈万万丌丐()
        {
            return (string)this.丘下与丞丘丕丛东丒;
        }
        public int 丂丕七与下东丁丂丙()
        {
            return (int)this.东丘且丂下丟一七丕;
        }
        public float 丞丗丗与七丐丏世丆()
        {
            return (float)this.世专且世东丒一上丑;
        }
        public System.TimeSpan 东丁丘丙且丑丄丝丅()
        {
            if(this.三丘丙丞丏丗一丏上 != null)
            {
                    return this.三丘丙丞丏丗一丏上.Elapsed;
            }
            
            return this.三丘丙丞丏丗一丏上.Elapsed;
        }
        public 丞丟丝丐一丕七不丐(string 与且专丈不万东一万)
        {
            if(与且专丈不万东一万 != null)
            {
                    this.丘下与丞丘丕丛东丒 = 与且专丈不万东一万;
                this.丘与丟丏与丂下万丘 = UnityEngine.Time.frameCount;
                this.且业丁丝丐丅且上丝 = UnityEngine.Time.realtimeSinceStartup;
                this.三丘丙丞丏丗一丏上 = new System.Diagnostics.Stopwatch();
                return;
            }
            
            System.ArgumentNullException val_4 = new System.ArgumentNullException(paramName:  "context");
        }
        public void 三丑丛丄万丟丄丞丁()
        {
            this.三丘丙丞丏丗一丏上.Start();
        }
        public void 丌丄丏下七丁专丂世()
        {
            this.三丘丙丞丏丗一丏上.Stop();
            int val_3 = this.丘与丟丏与丂下万丘;
            val_3 = UnityEngine.Time.frameCount - val_3;
            this.东丘且丂下丟一七丕 = val_3;
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            val_2 = val_2 - this.且业丁丝丐丅且上丝;
            this.世专且世东丒一上丑 = val_2;
        }
    
    }

}
