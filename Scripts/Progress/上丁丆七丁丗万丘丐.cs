using UnityEngine;

namespace Progress
{
    internal class 上丁丆七丁丗万丘丐 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private static System.Action 丛丘世丕丞丌不业丈;
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal static readonly string 丗丐世丘丏丝不丒下;
        private string 丆丆丂业丒丈丙丒丅;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        internal string 丙丞万丁丌七不丘上 { get; set; }
        
        // Methods
        internal static void 不业丘丑丐丟上丂东(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Progress.上丁丆七丁丗万丘丐.丛丘世丕丞丌不业丈, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丕且丁东丆七丑丌丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Progress.上丁丆七丁丗万丘丐.丛丘世丕丞丌不业丈, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.上丁丆七丁丗万丘丐.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.上丁丆七丁丗万丘丐.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 1;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            goto typeof(Progress.上丁丆七丁丗万丘丐).__il2cppRuntimeField_1A8;
        }
        internal override void 不一丘丅且丆不七上(object 丁丘丄丕下专东七不)
        {
            var val_6;
            var val_7;
            string val_2 = 0;
            val_6 = null;
            val_6 = null;
            val_7 = 0;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  Progress.上丁丆七丁丗万丘丐.丗丐世丘丏丝不丒下, 丙业与丙丗丝不丈东: out  val_2)) == false)
            {
                    return;
            }
            
            if(val_2 == 0)
            {
                    return;
            }
            
            string val_4 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_2);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == true)
            {
                    return;
            }
            
            this.丆丆丂业丒丈丙丒丅 = val_4;
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_2;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_2 = null;
            val_2 = null;
            if(this.丆丆丂业丒丈丙丒丅 == null)
            {
                goto label_3;
            }
            
            label_6:
            val_1.Add(key:  Progress.上丁丆七丁丗万丘丐.丗丐世丘丏丝不丒下, value:  this.丆丆丂业丒丈丙丒丅);
            return (object)val_1;
            label_3:
            if(val_1 != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  "NamePlayer")) == false)
            {
                    return;
            }
            
            this.东业丑丗丂丅七万丁(丙业与丙丗丝不丈东:  UnityEngine.PlayerPrefs.GetString(key:  "NamePlayer"));
        }
        internal string 与与丌万丟丄丌丘三()
        {
            return (string)this.丆丆丂业丒丈丙丒丅;
        }
        internal void 东业丑丗丂丅七万丁(string 丙业与丙丗丝不丈东)
        {
            string val_8;
            string val_9;
            var val_10;
            val_8 = 丙业与丙丗丝不丈东;
            if(val_8.Length >= 21)
            {
                    val_8 = val_8.Substring(startIndex:  0, length:  20);
            }
            
            string val_3 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  val_8);
            val_9 = val_3;
            if((System.String.IsNullOrEmpty(value:  val_3)) != true)
            {
                    if((System.String.op_Equality(a:  val_9.Trim(), b:  System.String.alignConst)) == false)
            {
                goto label_8;
            }
            
            }
            
            val_9 = ProfileController.丐与丄东丆上丟丑与();
            label_8:
            this.丆丆丂业丒丈丙丒丅 = val_9;
            val_10 = null;
            val_10 = null;
            if(Progress.上丁丆七丁丗万丘丐.丛丘世丕丞丌不业丈 == null)
            {
                    return;
            }
            
            Progress.上丁丆七丁丗万丘丐.丛丘世丕丞丌不业丈.Invoke();
        }
        internal override void 且七丙丄丘一丄上不()
        {
        
        }
        public 上丁丆七丁丗万丘丐()
        {
        
        }
        private static 上丁丆七丁丗万丘丐()
        {
            Progress.上丁丆七丁丗万丘丐.丕丟一七丑丙丂丆丙 = "player_slot";
            Progress.上丁丆七丁丗万丘丐.丐丌丞上世丛丐丏丛 = "Player_Info_Slot_Key_Nov2018";
            Progress.上丁丆七丁丗万丘丐.丗丐世丘丏丝不丒下 = "n";
        }
    
    }

}
