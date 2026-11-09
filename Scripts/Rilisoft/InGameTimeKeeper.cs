using UnityEngine;

namespace Rilisoft
{
    internal sealed class InGameTimeKeeper : MonoBehaviour
    {
        // Fields
        private const string 与丌与世丕丈丈丌丑 = "DailyInGameTime";
        private static Rilisoft.InGameTimeKeeper 世丒丞七专三与万丕;
        private double 丞一且丂三丈下东丂;
        private System.DateTime 丛七专下上丒丝丗丟;
        
        // Properties
        internal static Rilisoft.InGameTimeKeeper 丆丕丝丒不丙且丐丗 { get; }
        internal System.TimeSpan 与丕丕丕丈丁丆丕上 { get; }
        
        // Methods
        private InGameTimeKeeper()
        {
        
        }
        internal static Rilisoft.InGameTimeKeeper 丑七不且上丗丁一世()
        {
            Rilisoft.InGameTimeKeeper val_4 = Rilisoft.InGameTimeKeeper.世丒丞七专三与万丕;
            if(val_4 != 0)
            {
                    return (Rilisoft.InGameTimeKeeper)Rilisoft.InGameTimeKeeper.世丒丞七专三与万丕;
            }
            
            val_4 = CoroutineRunner.Instance;
            Rilisoft.InGameTimeKeeper.世丒丞七专三与万丕 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.InGameTimeKeeper>(不下丙丟专丙丆万丆:  val_4);
            return (Rilisoft.InGameTimeKeeper)Rilisoft.InGameTimeKeeper.世丒丞七专三与万丕;
        }
        internal System.TimeSpan 东一丂一丘与世下不()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            return this.丈三不不一丈丘不不(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_1.dateData});
        }
        internal void 上丛丌丆丑上七世三()
        {
        
        }
        internal void 丂且不业丂专丛丆东()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = this.丈三不不一丈丘不不(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_1.dateData});
            System.Collections.Generic.Dictionary<System.String, System.Double> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Double>();
            val_3.Add(key:  val_1.dateData, value:  val_2._ticks.TotalSeconds);
            UnityEngine.PlayerPrefs.SetString(key:  "DailyInGameTime", value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_3));
        }
        internal System.TimeSpan 丈三不不一丈丘不不(System.DateTime 不丗万丘丆丗上丗丏)
        {
            long val_8;
            ulong val_9;
            val_8 = this;
            System.DateTime val_1 = this.丛七专下上丒丝丗丟.Date;
            System.DateTime val_2 = 不丗万丘丆丗上丗丏.dateData.Date;
            val_9 = val_2.dateData;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_1.dateData}, t2:  new System.DateTime() {dateData = val_9})) != false)
            {
                    System.TimeSpan val_4 = 不丗万丘丆丗上丗丏.dateData.TimeOfDay;
                return (System.TimeSpan)val_7._ticks;
            }
            
            val_9 = this.丛七专下上丒丝丗丟;
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 不丗万丘丆丗上丗丏.dateData}, d2:  new System.DateTime() {dateData = val_9});
            val_8 = val_5._ticks;
            System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  this.丞一且丂三丈下东丂);
            System.TimeSpan val_7 = System.TimeSpan.op_Addition(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = val_6._ticks});
            return (System.TimeSpan)val_7._ticks;
        }
        private void Awake()
        {
            Rilisoft.InGameTimeKeeper.世丒丞七专三与万丕 = this;
        }
        private void Start()
        {
            var val_7;
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.丛七专下上丒丝丗丟 = val_1;
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  "DailyInGameTime", defaultValue:  System.String.alignConst));
            val_7 = 0;
            if(val_3 != null)
            {
                
            }
            
            this.丞一且丂三丈下东丂 = ((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Double>(丏丂万业丙专丏丒丒:  val_3, 下上丐丆丝丟丝丒不:  val_1.dateData, 丙业与丙丗丝不丈东: out  double val_4 = 1.28824051649442E-231)) != true) ? 0 : 0;
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            ulong val_8;
            System.DateTime val_9;
            System.DateTime val_1 = System.DateTime.UtcNow;
            if(丁与丟万丄丒丗专丌 == false)
            {
                goto label_3;
            }
            
            System.DateTime val_2 = this.丛七专下上丒丝丗丟.Date;
            System.DateTime val_3 = val_1.dateData.Date;
            if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_2.dateData}, t2:  new System.DateTime() {dateData = val_3.dateData})) == false)
            {
                goto label_6;
            }
            
            System.DateTime val_5 = val_1.dateData.Date;
            val_9 = val_5.dateData;
            this.丞一且丂三丈下东丂 = 0;
            this.丛七专下上丒丝丗丟 = val_5;
            goto label_7;
            label_3:
            this.丛七专下上丒丝丗丟 = val_1;
            return;
            label_6:
            val_9 = this.丛七专下上丒丝丗丟;
            label_7:
            val_8 = val_1.dateData;
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = val_9});
            double val_7 = val_6._ticks.TotalSeconds;
            val_7 = val_7 + this.丞一且丂三丈下东丂;
            this.丞一且丂三丈下东丂 = val_7;
            this.丛七专下上丒丝丗丟 = val_1;
        }
    
    }

}
