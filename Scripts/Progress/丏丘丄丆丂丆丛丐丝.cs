using UnityEngine;

namespace Progress
{
    internal class 丏丘丄丆丂丆丛丐丝 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        internal readonly 丐七不丄业丟丙丄一 业丑不丈丐七丅不丏;
        private System.Collections.Generic.Dictionary<string, int> 丅不丝丐丕丄东丕丈;
        private System.Collections.Generic.Dictionary<string, string> 丑丌丛丛专丐丒丘下;
        private System.Collections.Generic.Dictionary<string, int> 丛丘丕三丟万丟且丒;
        private System.Collections.Generic.Dictionary<string, int> 下丘下丑三丏专丒丝;
        private int 丞七丄丆专不丞东丙;
        private int 丂丛丏专丛且丌下丝;
        private int 丙三丒东丟丐业下丟;
        private System.Collections.Generic.Dictionary<string, bool> 丁丏业三丏且专丒丒;
        private System.Collections.Generic.Dictionary<string, int> 专丝万世丐丂专不丝;
        internal static System.Collections.Generic.Dictionary<string, int> 丝丅丙东丘且丄业世;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        public 丏丘丄丆丂丆丛丐丝()
        {
            this.业丑不丈丐七丅不丏 = new 丐七不丄业丟丙丄一();
            this.丅不丝丐丕丄东丕丈 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丑丌丛丛专丐丒丘下 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.丛丘丕三丟万丟且丒 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.下丘下丑三丏专丒丝 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丞七丄丆专不丞东丙 = 0;
            this.丂丛丏专丛且丌下丝 = 0;
            this.丙三丒东丟丐业下丟 = 0;
            this.丁丏业三丏且专丒丒 = new System.Collections.Generic.Dictionary<System.String, System.Boolean>();
            this.专丝万世丐丂专不丝 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Progress.丏丘丄丆丂丆丛丐丝::丂不万世丝丟丅丗丏()));
        }
        private void 丂不万世丝丟丅丗丏()
        {
            string val_13;
            var val_14;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_16;
            val_13 = this.丞丌且不丄专专且丈(丙一丗丂三丕专七丏:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七());
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) == true)
            {
                    return;
            }
            
            char[] val_4 = new char[1];
            val_4[0] = '#';
            val_13 = System.Linq.Enumerable.Select<System.String, 三丅丁丗丗丝丂万且>(source:  val_13.Split(separator:  val_4, options:  1), selector:  new System.Func<System.String, 三丅丁丗丗丝丂万且>(object:  0, method:  static 三丅丁丗丗丝丂万且 丏丄丑上丛不丈且万::三丕丑丙丄上丆七下(string 丟丈一下东业一丝丆)));
            val_14 = null;
            val_14 = null;
            val_16 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__13_0;
            if(val_16 == null)
            {
                    System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_8 = null;
                val_16 = val_8;
                val_8 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丘丄丆丂丆丛丐丝.<>c::丛东丐专且一丈丘丙(三丅丁丗丗丝丂万且 三丟东丕丄丄下下丑));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__13_0 = val_16;
            }
            
            if((System.Linq.Enumerable.Any<三丅丁丗丗丝丂万且>(source:  val_13, predicate:  val_8)) == false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七(), 下下丏一丙不丘丌丞:  WeaponManager.业丞业丕丈丟丂丄丏());
        }
        internal int 丕丈丗丅丈丑丒丆与()
        {
            var val_4;
            if(this.丛丘丕三丟万丟且丒 != null)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                bool val_3 = this.丛丘丕三丟万丟且丒.TryGetValue(key:  7.ToString(), value: out  0);
                val_4 = 0;
                return (int)val_4;
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        internal void 东三上世专一业丟丘()
        {
            var val_27;
            System.Func<System.String, System.Collections.Generic.IEnumerable<System.String>> val_29;
            var val_31;
            var val_32;
            var val_33;
            var val_36;
            var val_37;
            val_27 = null;
            val_27 = null;
            val_29 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__15_0;
            if(val_29 == null)
            {
                    System.Func<System.String, System.Collections.Generic.IEnumerable<System.String>> val_2 = null;
                val_29 = val_2;
                val_2 = new System.Func<System.String, System.Collections.Generic.IEnumerable<System.String>>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> 丏丘丄丆丂丆丛丐丝.<>c::万上丏丕万丘专世丗(string 三丟东丕丄丄下下丑));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__15_0 = val_29;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_31 = 1152921504691191808;
            val_32 = "No record for Weapon";
            val_33 = System.Linq.Enumerable.SelectMany<System.String, System.String>(source:  this.丑丌丛丛专丐丒丘下.Values, selector:  val_2).GetEnumerator();
            label_33:
            var val_31 = 0;
            val_31 = val_31 + 1;
            if(val_33.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            T val_9 = val_33.Current;
            三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_9);
            if(val_10 == null)
            {
                goto label_25;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  val_10.与不丞丑七丘丁丂丛())) == true)
            {
                goto label_33;
            }
            
            UnityEngine.Debug.LogError(message:  val_9 + " " + val_10.与不丞丑七丘丁丂丛());
            goto label_33;
            label_25:
            UnityEngine.Debug.LogError(message:  "No record for Weapon" + val_9);
            goto label_33;
            label_17:
            val_36 = 0;
            val_37 = 0;
            if(val_33 == null)
            {
                
            }
            else
            {
                    var val_33 = 0;
                val_33 = val_33 + 1;
                val_33.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_33 = ???;
            val_36 = ???;
            val_31 = ???;
            val_32 = ???;
        }
        internal int 丑专万丟三丕上不东()
        {
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_3;
            int val_1 = 0;
            val_3 = this.丛丘丕三丟万丟且丒;
            if(val_3 == null)
            {
                    return (int)val_3;
            }
            
            bool val_2 = val_3.TryGetValue(key:  "Wear.CURRENT_ALTERNATIVE_ARMOR_V5_KEY", value: out  val_1);
            val_3 = val_1;
            return (int)val_3;
        }
        internal string 丞丌且不丄专专且丈(Progress.丗丂下不丞丞丑丙且 丙一丗丂三丕专七丏, string 下上丐丆丝丟丝丒不)
        {
            丗七丝丑丁丈丘丑上 val_22;
            string val_27;
            val_22 = this;
            if((丙一丗丂三丕专七丏 - 1) <= 6)
            {
                    var val_22 = 106046244 + ((丙一丗丂三丕专七丏 - 1)) << 2;
                val_22 = val_22 + 106046244;
            }
            else
            {
                    val_27 = 0;
                if((System.String.IsNullOrEmpty(value:  null)) == false)
            {
                    return (string)val_27;
            }
            
                val_22 = this.业丑不丈丐七丅不丏.下一丛丂且东丑丈一;
                val_27 = val_22.丟丄专丕丞丐丆一丟(丙一丗丂三丕专七丏:  丙一丗丂三丕专七丏).Invoke(arg:  下上丐丆丝丟丝丒不);
                return (string)val_27;
            }
        
        }
        internal void 上东丌丟丁丑丅丟丛(Progress.丗丂下不丞丞丑丙且 丙一丗丂三丕专七丏, string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
        {
            string val_14;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_15;
            val_14 = 丙业与丙丗丝不丈东;
            val_15 = this;
            if((丙一丗丂三丕专七丏 - 1) > 6)
            {
                    return;
            }
            
            var val_14 = 106046272 + ((丙一丗丂三丕专七丏 - 1)) << 2;
            val_14 = val_14 + 106046272;
            goto (106046272 + ((丙一丗丂三丕专七丏 - 1)) << 2 + 106046272);
        }
        internal bool 丑上万丌丏上丌下三(string 下上丐丆丝丟丝丒不)
        {
            if((this.业丑不丈丐七丅不丏.丄丙业丗丌上丂世丞.Contains(item:  下上丐丆丝丟丝丒不)) == false)
            {
                    return false;
            }
            
            if(this.丁丏业三丏且专丒丒 != null)
            {
                    return this.丁丏业三丏且专丒丒.Item[下上丐丆丝丟丝丒不];
            }
            
            return this.丁丏业三丏且专丒丒.Item[下上丐丆丝丟丝丒不];
        }
        internal void 万丞上丘丗丆丙一丑(string 下上丐丆丝丟丝丒不, bool 丙业与丙丗丝不丈东)
        {
            if((this.业丑不丈丐七丅不丏.丄丙业丗丌上丂世丞.Contains(item:  下上丐丆丝丟丝丒不)) == false)
            {
                    return;
            }
            
            this.丁丏业三丏且专丒丒.set_Item(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            object val_4 = this;
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Progress.丏丘丄丆丂丆丛丐丝::不三东丒丟东不丝丘()));
            List.Enumerator<T> val_2 = this.业丑不丈丐七丅不丏.丄丙业丗丌上丂世丞.GetEnumerator();
            label_5:
            if(((-1937777144) & 1) == 0)
            {
                goto label_3;
            }
            
            this.丁丏业三丏且专丒丒.Add(key:  0.丐丏七丌丕丗业且上(), value:  false);
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 不三东丒丟东不丝丘()
        {
            this.丏丝丑丌丘万三丒丘();
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 9;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            object val_9 = 一丐丗丁丞丆丅丟丄;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丅不丝丐丕丄东丕丈 = null;
            System.Collections.Generic.Dictionary<System.String, System.String> val_2 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this.丑丌丛丛专丐丒丘下 = null;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丛丘丕三丟万丟且丒 = null;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.丞七丄丆专不丞东丙 = 0;
            this.丂丛丏专丛且丌下丝 = 0;
            mem[1152921541324441840] = null;
            mem[1152921541324441856] = 0;
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            this.业丑不丈丐七丅不丏.三与丘与丕专丗不东(丙一丗丂三丕专七丏:  1, 丐丙丆业丗丙上丅丌:  null, 丕丈丛三丏下丂丟与:  this.丅不丝丐丕丄东丕丈);
            this.业丑不丈丐七丅不丏.丟世七下丙丙东丂业(丐丙丆业丗丙上丅丌:  null, 丙丒东丏万丘丄一世:  this.丑丌丛丛专丐丒丘下);
            this.业丑不丈丐七丅不丏.三与丘与丕专丗不东(丙一丗丂三丕专七丏:  3, 丐丙丆业丗丙上丅丌:  null, 丕丈丛三丏下丂丟与:  this.丛丘丕三丟万丟且丒);
            this.业丑不丈丐七丅不丏.三与丘与丕专丗不东(丙一丗丂三丕专七丏:  4, 丐丙丆业丗丙上丅丌:  null, 丕丈丛三丏下丂丟与:  this.下丘下丑三丏专丒丝);
            this.业丑不丈丐七丅不丏.丅七丌丕丘丛丝丂丘(丙一丗丂三丕专七丏:  5, 丐丙丆业丗丙上丅丌:  null, 丅丕不丛丂与丙丟丘: out  1152921541324441848);
            this.业丑不丈丐七丅不丏.丅七丌丕丘丛丝丂丘(丙一丗丂三丕专七丏:  6, 丐丙丆业丗丙上丅丌:  null, 丅丕不丛丂与丙丟丘: out  1152921541324441852);
            this.业丑不丈丐七丅不丏.丅七丌丕丘丛丝丂丘(丙一丗丂三丕专七丏:  7, 丐丙丆业丗丙上丅丌:  null, 丅丕不丛丂与丙丟丘: out  1152921541324441856);
            this.业丑不丈丐七丅不丏.丁丝丑丝丞丒丙与下(丐丙丆业丗丙上丅丌:  null, 丟丙丅丒业丕丐不丁:  this.丁丏业三丏且专丒丒);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            丐七不丄业丟丙丄一 val_14;
            string val_15;
            System.Collections.Generic.Dictionary<System.String, System.Boolean> val_16;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  1), value:  this.业丑不丈丐七丅不丏.世万不且不丁一丅丐(丂丂丁一世丛丘专三:  1, 三世丄专丏不世世不:  this.丅不丝丐丕丄东丕丈));
            val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  2), value:  this.业丑不丈丐七丅不丏.丄丗丘一丙世丑丕下(丙丒东丏万丘丄一世:  this.丑丌丛丛专丐丒丘下));
            val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  3), value:  this.业丑不丈丐七丅不丏.世万不且不丁一丅丐(丂丂丁一世丛丘专三:  3, 三世丄专丏不世世不:  this.丛丘丕三丟万丟且丒));
            val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  4), value:  this.业丑不丈丐七丅不丏.世万不且不丁一丅丐(丂丂丁一世丛丘专三:  4, 三世丄专丏不世世不:  this.下丘下丑三丏专丒丝));
            val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  5), value:  this.丞七丄丆专不丞东丙);
            val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  6), value:  this.丂丛丏专丛且丌下丝);
            if(this.丙三丒东丟丐业下丟 != 1)
            {
                    val_1.Add(key:  this.业丑不丈丐七丅不丏.东丕丁丆专丆七丞东(丁丅丈丌丟世丗丗丟:  7), value:  this.丙三丒东丟丐业下丟);
            }
            
            val_14 = this.业丑不丈丐七丅不丏;
            if(val_14 != null)
            {
                    val_15 = this.业丑不丈丐七丅不丏.不丙一业丄万丟业万;
                val_16 = this.丁丏业三丏且专丒丒;
            }
            else
            {
                    val_15 = this.业丑不丈丐七丅不丏.不丙一业丄万丟业万;
                val_16 = this.丁丏业三丏且专丒丒;
                if(this.业丑不丈丐七丅不丏 != null)
            {
                    val_14 = this.业丑不丈丐七丅不丏;
            }
            else
            {
                    val_14 = 0;
            }
            
            }
            
            val_1.Add(key:  val_15, value:  val_14.世不丈上丏丝七世一(丟丙丅丒业丕丐不丁:  val_16));
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            this.丞万丙丄丌丈丂丟丟();
            this.七世丂丒不丝七七丝();
            this.丙丛丅丞丌丘丁上万();
            this.且三与七七丂丌丆丘();
            this.丄世丐七丝上专丂世();
            this.丄丛上丂丆丐专丁下();
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丏丘丄丆丂丆丛丐丝.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丏丘丄丆丂丆丛丐丝.丐丌丞上世丛丐丏丛;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            var val_3 = this;
            this.丅不丝丐丕丄东丕丈.Clear();
            this.丑丌丛丛专丐丒丘下.Clear();
            this.丛丘丕三丟万丟且丒.Clear();
            this.下丘下丑三丏专丒丝.Clear();
            this.丁丏业三丏且专丒丒.Clear();
            this.专丝万世丐丂专不丝.Clear();
            this.丞七丄丆专不丞东丙 = 0;
            this.丂丛丏专丛且丌下丝 = 0;
            this.丙三丒东丟丐业下丟 = 0;
            List.Enumerator<T> val_1 = this.业丑不丈丐七丅不丏.丄丙业丗丌上丂世丞.GetEnumerator();
            label_11:
            if(((-1936144120) & 1) == 0)
            {
                goto label_9;
            }
            
            this.丁丏业三丏且专丒丒.Add(key:  0.丐丏七丌丕丗业且上(), value:  false);
            goto label_11;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丞万丙丄丌丈丂丟丟()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丅不丝丐丕丄东丕丈.set_Item(key:  12500.ToString(), value:  231);
        }
        private void 七世丂丒不丝七七丝()
        {
            var val_4;
            var val_13;
            string val_14;
            val_13 = this;
            List.Enumerator<T> val_2 = WeaponManager.一丝丞丗不丄万丅丗().GetEnumerator();
            label_14:
            if(((-1935825952) & 1) == 0)
            {
                goto label_4;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_14 = "";
            if(UnityEngine.Application.isEditor != false)
            {
                    string val_7 = UnityEngine.PlayerPrefs.GetString(key:  val_5);
                val_14 = val_7.世三丄丑丙丏七丁业(丕与丝万丑丏丑东与:  val_7, 丂丛丅丝丟丆世上丌:  val_5);
            }
            else
            {
                    if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_5)) != false)
            {
                    string val_10 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_5);
                val_14 = val_10.世三丄丑丙丏七丁业(丕与丝万丑丏丑东与:  val_10, 丂丛丅丝丟丆世上丌:  val_5);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  val_14)) == true)
            {
                goto label_14;
            }
            
            this.丑丌丛丛专丐丒丘下.set_Item(key:  val_5, value:  val_14);
            goto label_14;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private string 世三丄丑丙丏七丁业(string 丕与丝万丑丏丑东与, string 丂丛丅丝丟丆世上丌)
        {
            string val_38;
            var val_39;
            var val_40;
            var val_41;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_43;
            System.Char[] val_44;
            var val_45;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_47;
            var val_48;
            System.Func<System.String, 三丅丁丗丗丝丂万且> val_50;
            var val_51;
            System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_53;
            var val_54;
            System.Func<三丅丁丗丗丝丂万且, System.String> val_56;
            var val_57;
            string val_58;
            val_38 = 丕与丝万丑丏丑东与;
            .丕与丝万丑丏丑东与 = val_38;
            val_39 = 1152921505171275776;
            if((System.String.op_Inequality(a:  丂丛丅丝丟丆世上丌, b:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗())) != false)
            {
                    if((System.String.op_Inequality(a:  丂丛丅丝丟丆世上丌, b:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七())) == true)
            {
                goto label_155;
            }
            
            }
            
            val_38 = (丏丘丄丆丂丆丛丐丝.且且丛丌丝三丏丙丛)[1152921541326143232].丕与丝万丑丏丑东与;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_38)) == true)
            {
                goto label_155;
            }
            
            val_40 = null;
            val_40 = null;
            val_41 = null;
            val_41 = null;
            val_43 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__36_0;
            if(val_43 == null)
            {
                    val_43 = null;
                val_43 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丘丄丆丂丆丛丐丝.<>c::丗一丅丂丑丂丘七上(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__36_0 = val_43;
            }
            
            val_45 = null;
            val_45 = null;
            val_47 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__36_1;
            if(val_47 == null)
            {
                    val_47 = null;
                val_47 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> 丏丘丄丆丂丆丛丐丝.<>c::丟丆丏一且上万上不(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__36_1 = val_47;
            }
            
            val_48 = null;
            val_48 = null;
            val_50 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__36_2;
            if(val_50 == null)
            {
                    val_50 = null;
                val_50 = new System.Func<System.String, 三丅丁丗丗丝丂万且>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  三丅丁丗丗丝丂万且 丏丘丄丆丂丆丛丐丝.<>c::丒丗且世万一丕业丝(string 丒东业不丐丑丕丄丆));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__36_2 = val_50;
            }
            
            val_51 = null;
            val_51 = null;
            val_53 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__36_3;
            if(val_53 == null)
            {
                    val_53 = null;
                val_53 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丘丄丆丂丆丛丐丝.<>c::不且丛丁丝业丑丑世(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__36_3 = val_53;
            }
            
            val_54 = null;
            val_54 = null;
            val_56 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__36_4;
            if(val_56 == null)
            {
                    val_56 = null;
                val_56 = new System.Func<三丅丁丗丗丝丂万且, System.String>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丏丘丄丆丂丆丛丐丝.<>c::丒万三丞丘丌业世丄(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__36_4 = val_56;
            }
            
            val_38 = null;
            val_38 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.Select<三丅丁丗丗丝丂万且, System.String>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Select<System.String, 三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  null), selector:  null), selector:  null), predicate:  null), selector:  null));
            System.Func<System.String, System.Boolean> val_18 = new System.Func<System.String, System.Boolean>(object:  new 丏丘丄丆丂丆丛丐丝.且且丛丌丝三丏丙丛(), method:  System.Boolean 丏丘丄丆丂丆丛丐丝.且且丛丌丝三丏丙丛::与世丝丘且且业丟上(string 三丟东丕丄丄下下丑));
            if((System.Linq.Enumerable.Any<System.String>(source:  null, predicate:  null)) == false)
            {
                goto label_155;
            }
            
            string[] val_20 = new string[11];
            val_20[0] = WeaponManager.上业丅丂丘不且丕丌();
            val_20[1] = "#";
            val_20[2] = WeaponManager.丅丗丟丕丅下丆世丙();
            val_20[3] = "#";
            val_20[4] = WeaponManager.丑世丐世丟三三不丒();
            val_20[5] = "#";
            val_20[6] = WeaponManager.丘三丅丝专万丅丒丒();
            val_20[7] = "#";
            val_20[8] = WeaponManager.丘专与世丅丌丛丙世();
            val_20[9] = "#";
            val_20[10] = WeaponManager.丞丌上万丆下东丞七;
            char[] val_31 = new char[1];
            val_44 = val_31;
            val_44[0] = '#';
            val_57 = 0;
            goto label_80;
            label_95:
            val_39 = 0;
            val_44 = (丏丘丄丆丂丆丛丐丝.且且丛丌丝三丏丙丛)[1152921541326143232].丕与丝万丑丏丑东与.Split(separator:  val_31)[val_39];
            if(val_44 != null)
            {
                    if(val_57 >= val_32.Length)
            {
                    val_44 = mem[val_32[0x0] + 32];
                val_44 = val_32[0x0] + 32;
            }
            
                if((null.Contains(item:  val_44)) != false)
            {
                    char[] val_34 = new char[1];
                val_34[0] = '#';
                System.String[] val_39 = ((System.String.op_Equality(a:  丂丛丅丝丟丆世上丌, b:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗())) != true) ? (+val_20) : WeaponManager.业丞业丕丈丟丂丄丏().Split(separator:  val_34);
                string val_38 = val_39[val_39];
                val_39 = (val_38 == null) ? "" : (val_38);
                mem2[0] = val_39;
            }
            
            }
            
            val_57 = 1;
            label_80:
            if(val_57 < val_32.Length)
            {
                goto label_95;
            }
            
            return val_58;
            label_155:
            val_58 = (丏丘丄丆丂丆丛丐丝.且且丛丌丝三丏丙丛)[1152921541326143232].丕与丝万丑丏丑东与;
            return val_58;
        }
        private void 丙丛丅丞丌丘丁上万()
        {
            var val_6;
            var val_23;
            System.Func<CategoryNames, System.String> val_25;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_26;
            var val_27;
            var val_28;
            object val_29;
            string val_30;
            var val_31;
            var val_33;
            val_23 = null;
            val_23 = null;
            val_25 = 丏丘丄丆丂丆丛丐丝.<>c.<>9__37_0;
            if(val_25 == null)
            {
                    System.Func<CategoryNames, System.String> val_1 = null;
                val_25 = val_1;
                val_1 = new System.Func<CategoryNames, System.String>(object:  丏丘丄丆丂丆丛丐丝.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丏丘丄丆丂丆丛丐丝.<>c::业丛丑丈七丈丙丌丂(CategoryNames 丁丂专业丁丅丅丈丙));
                丏丘丄丆丂丆丛丐丝.<>c.<>9__37_0 = val_25;
            }
            
            val_26 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = val_26.GetEnumerator();
            val_27 = 1152921505266909184;
            val_28 = 1152921523768715824;
            val_29 = 1152921505259454464;
            label_30:
            if(((-1935075968) & 1) == 0)
            {
                goto label_10;
            }
            
            int val_7 = val_6.丙东专丂世丈丏丁丂();
            string val_8 = val_1.Invoke(arg:  val_7);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_8)) != false)
            {
                    val_30 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_8);
            }
            else
            {
                    val_30 = 丆丟七丌丞东丆丕丌.丈丑东丆丛万丙丅业(丁丂专业丁丅丅丈丙:  val_7);
            }
            
            if((System.String.IsNullOrEmpty(value:  val_30)) == true)
            {
                goto label_30;
            }
            
            if(val_7 == 7)
            {
                    val_31 = val_28;
                var val_15 = ((System.String.op_Inequality(a:  val_30, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) != true) ? "Armor_Army_1" : (val_30);
            }
            else
            {
                    val_31 = val_28;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem[1152921541326488840].set_Item(key:  val_7.ToString(), value:  mem[1152921541326488816] + 80.Item[3].Invoke(arg:  val_30));
            goto label_30;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "Wear.CURRENT_ALTERNATIVE_ARMOR_V5_KEY")) == false)
            {
                    return;
            }
            
            val_33 = null;
            val_29 = mem[1152921541326488840];
            val_33 = null;
            val_26 = Progress.丏丘丄丆丂丆丛丐丝.丝丅丙东丘且丄业世;
            val_29.set_Item(key:  "Wear.CURRENT_ALTERNATIVE_ARMOR_V5_KEY", value:  val_26.Item[丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "Wear.CURRENT_ALTERNATIVE_ARMOR_V5_KEY")]);
        }
        private void 且三与七七丂丌丆丘()
        {
            int val_8;
            string[] val_1 = new string[5];
            val_1[0] = "GlidersInfo.GLIDER_EQUIPPED_KEY";
            val_1[1] = "GlidersInfo.TRANSPORT_EQUIPPED_KEY";
            val_1[2] = "RoyaleHatsVisualInfo.ROYALE_HAT_EQUIPPED_KEY";
            val_1[3] = "RoyaleHatsVisualInfo.ROYALE_AVATAR_EQUIPPED_KEY";
            val_8 = val_1.Length;
            if(val_8 <= 4)
            {
                    val_8 = val_1.Length;
            }
            
            val_1[4] = "RoyaleHatsVisualInfo.LANDING_TRAIL_EQUIPPED_KEY";
            if(val_8 >= 1)
            {
                    do
            {
                if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_1[0])) != false)
            {
                    this.下丘下丑三丏专丒丝.set_Item(key:  val_1[0x0] + 32, value:  this.业丑不丈丐七丅不丏.丅不与丘丄丑丛与万.Item[4].Invoke(arg:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_1[0x0] + 32)));
            }
            
            }
            while((0 + 1) < val_1.Length);
            
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY")) == false)
            {
                    return;
            }
            
            this.上东丌丟丁丑丅丟丛(丙一丗丂三丕专七丏:  4, 下上丐丆丝丟丝丒不:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY", 丙业与丙丗丝不丈东:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "WeaponManager.BATTLE_ROYALE_SHOVEL_KEY"));
        }
        private void 丄世丐七丝上专丂世()
        {
            string val_13;
            if((UnityEngine.PlayerPrefs.HasKey(key:  "Name Current Skin")) == false)
            {
                    return;
            }
            
            val_13 = UnityEngine.PlayerPrefs.GetString(key:  "Name Current Skin", defaultValue:  "0");
            int val_4 = this.业丑不丈丐七丅不丏.丅不与丘丄丑丛与万.Item[5].Invoke(arg:  val_13);
            this.丞七丄丆专不丞东丙 = val_4;
            if(val_4 != 1)
            {
                    return;
            }
            
            string val_5 = UnityEngine.PlayerPrefs.GetString(key:  "Name Current Skin", defaultValue:  "0");
            if(((val_5.Length - 7) & 2147483648) != 0)
            {
                goto label_7;
            }
            
            val_13 = val_5.Length - 7;
            if(val_5 != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_5.Substring(startIndex:  val_13, length:  7), 丙业与丙丗丝不丈东: out  0)) == false)
            {
                    return;
            }
            
            this.丞七丄丆专不丞东丙 = 0;
            return;
            label_7:
            if(val_5 != null)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        private void 丄丛上丂丆丐专丁下()
        {
            List.Enumerator<T> val_1 = this.业丑不丈丐七丅不丏.丄丙业丗丌上丂世丞.GetEnumerator();
            label_10:
            if(((-1934559608) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_2)) == false)
            {
                goto label_10;
            }
            
            this.丁丏业三丏且专丒丒.set_Item(key:  val_2, value:  ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_2, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1) ? 1 : 0);
            goto label_10;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal int 丅世丌且下业丐丟且(string 丛丘丂丈丘下丂一丛)
        {
            if((this.专丝万世丐丂专不丝.ContainsKey(key:  丛丘丂丈丘下丂一丛)) != false)
            {
                    if(this.专丝万世丐丂专不丝 != null)
            {
                    return this.专丝万世丐丂专不丝.Item[丛丘丂丈丘下丂一丛];
            }
            
                return this.专丝万世丐丂专不丝.Item[丛丘丂丈丘下丂一丛];
            }
            
            if(this.业丑不丈丐七丅不丏.下一丛丂且东丑丈一 != null)
            {
                    return this.业丑不丈丐七丅不丏.下一丛丂且东丑丈一.东丗专且与万丌丈三(丛丘丂丈丘下丂一丛:  丛丘丂丈丘下丂一丛);
            }
            
            return this.业丑不丈丐七丅不丏.下一丛丂且东丑丈一.东丗专且与万丌丈三(丛丘丂丈丘下丂一丛:  丛丘丂丈丘下丂一丛);
        }
        internal void 丄丆下东丕丐三丌与(string 丑一丕三专东不上丞, int 七丆丒与丗丌丄且丂)
        {
            this.专丝万世丐丂专不丝.set_Item(key:  丑一丕三专东不上丞, value:  七丆丒与丗丌丄且丂);
        }
        internal void 丑丘三且丞丕丟丁下()
        {
            null = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  WeaponManager.丒丆丙一且丂一丙专, 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.专丝万世丐丂专不丝));
        }
        private void 丏丝丑丌丘万三丒丘()
        {
            if((this.丑上万丌丏上丌下三(下上丐丆丝丟丝丒不:  "ShowWearKeySetting")) != false)
            {
                    return;
            }
            
            三丐下丁丒丆丘下丄.丛丅世丈丐丑世丆三(丙业与丙丗丝不丈东:  false);
            三丐下丁丒丆丘下丄.与丂业丞东丌专万不(丙业与丙丗丝不丈东:  false);
            三丐下丁丒丆丘下丄.且世丗丐一不丒三丈(丙业与丙丗丝不丈东:  false);
            三丐下丁丒丆丘下丄.与丑丗七不丄丗丗东(丙业与丙丗丝不丈东:  false);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().一不七丞丐世上世丕(下上丐丆丝丟丝丒不:  "ShowWearKeySetting", 下下丏一丙不丘丌丞:  true);
        }
        private static 丏丘丄丆丂丆丛丐丝()
        {
            Progress.丏丘丄丆丂丆丛丐丝.丕丟一七丑丙丂丆丙 = "Player_EquipmentSlot";
            Progress.丏丘丄丆丂丆丛丐丝.丐丌丞上世丛丐丏丛 = "Player_EquipmentSlot_2018";
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "cyber_santa_armor", value:  129002);
            }
            else
            {
                    val_1.Add(key:  "cyber_santa_armor", value:  129002);
            }
            
            val_1.Add(key:  "exoskeleton_pilot_avatar_armor", value:  129002 + 1000);
            if(val_1 != null)
            {
                    val_1.Add(key:  "Armor_Halloween", value:  129002 + 2000);
            }
            else
            {
                    val_1.Add(key:  "Armor_Halloween", value:  129002 + 2000);
            }
            
            val_1.Add(key:  "pilgrim_armor", value:  129002 + 3000);
            Progress.丏丘丄丆丂丆丛丐丝.丝丅丙东丘且丄业世 = val_1;
        }
    
    }

}
