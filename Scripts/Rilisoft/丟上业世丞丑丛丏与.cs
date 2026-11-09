using UnityEngine;

namespace Rilisoft
{
    internal class 丟上业世丞丑丛丏与 : 丈丕丅丄七丁丒丅上
    {
        // Fields
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丈丌丕下丄丞丘丐万;
        private System.Collections.Generic.List<GameEventPlayerGot> 丅丞且丁丟丆丞丂丙;
        private bool 丝世丘丁万业七丟丁;
        
        // Properties
        protected override bool 丙三丝丏专丘丈丐业 { get; }
        
        // Methods
        public 丟上业世丞丑丛丏与(System.Collections.Generic.List<GameEventPlayerGot> 丏上丐丑上丏一专与)
        {
            this.丈丌丕下丄丞丘丐万 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>>();
            this.丅丞且丁丟丆丞丂丙 = 丏上丐丑上丏一专与;
        }
        protected override bool 一业丟丁上丑丘丕丄()
        {
            if(this.丈丌丕下丄丞丘丐万 == null)
            {
                    return (bool)(this.丈丌丕下丄丞丘丐万.Count > 0) ? 1 : 0;
            }
            
            return (bool)(this.丈丌丕下丄丞丘丐万.Count > 0) ? 1 : 0;
        }
        protected override void 与丐丈丐丏一丒三与()
        {
            object val_7;
            var val_34;
            object val_35;
            var val_36;
            var val_37;
            var val_38;
            string val_39;
            object val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            System.Func<System.String, System.Boolean> val_50;
            val_34 = this;
            丟上业世丞丑丛丏与.丘丞上世丗丘丏丐东 val_1 = null;
            val_35 = val_1;
            val_1 = new 丟上业世丞丑丛丏与.丘丞上世丗丘丏丐东();
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与不下且且丅东丘世());
            if(val_35 != null)
            {
                    val_36 = val_35;
                .三丕丂丆世丟丒丒上 = val_4;
            }
            else
            {
                    val_36 = 16;
                mem[16] = val_4;
            }
            
            List.Enumerator<T> val_5 = val_36.GetEnumerator();
            val_37 = 1152921542926308816;
            val_38 = 1152921524493730496;
            goto label_7;
            label_46:
            string val_8 = val_7.丐丏七丌丕丗业且上();
            bool val_10 = this.丈丌丕下丄丞丘丐万.ContainsKey(key:  val_8.业上丙丞丐丄丆丅七());
            if(val_10 != false)
            {
                    val_39 = val_8.业上丙丞丐丄丆丅七();
                System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = this.丈丌丕下丄丞丘丐万.Item[val_39];
                val_40 = val_35;
                val_41 = val_34;
                val_42 = val_36;
                val_43 = 1152921542997384304;
                val_44 = val_38;
                val_45 = 1152921542926309840;
                val_46 = val_37;
            }
            else
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = val_10.丂丝丒丁下丄东业丝(丗丛不丁丑专专丂且:  val_8);
                val_39 = this.丈丌丕下丄丞丘丐万;
                val_40 = val_35;
                val_42 = val_36;
                val_43 = 1152921542997384304;
                val_44 = val_38;
                val_45 = 1152921542926309840;
                val_46 = val_37;
                val_41 = val_34;
                val_39.Add(key:  val_8.业上丙丞丐丄丆丅七(), value:  val_13);
            }
            
            val_37 = val_46;
            val_38 = val_44;
            val_36 = val_42;
            val_34 = val_41;
            val_35 = val_40;
            if(FriendsController.丝丗专上三不丄丑丑() >= 1)
            {
                    val_39 = val_8.丁专丗万三上丟三丆();
                if((val_16.EndDate & 1) != 0)
            {
                    val_39 = val_13;
                if((val_39.ContainsKey(key:  "EndTime")) != true)
            {
                    val_7 = 0;
                val_13.Add(key:  "EndTime", value:  val_7);
                val_39 = val_13;
            }
            
                Rilisoft.GameEventData val_18 = val_8.丁专丗万三上丟三丆();
                val_7 = 0;
                System.TimeSpan val_19 = val_18.EndDate.Subtract(value:  new System.DateTime());
                val_39.set_Item(key:  "EndTime", value:  (long)val_19._ticks.TotalSeconds);
            }
            
            }
            
            val_47 = 0;
            goto label_28;
            label_45:
            GameEventPlayerGot val_21 = this.丅丞且丁丟丆丞丂丙.Item[0];
            val_39 = mem[16];
            if(val_47 < val_39.Count)
            {
                    val_39 = mem[16].Item[0];
                val_21.Setup(与且专丈不万东一万:  val_39);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            else
            {
                    val_21.Setup(与且专丈不万东一万:  0);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            val_47 = 1;
            label_28:
            if(val_47 < this.丅丞且丁丟丆丞丂丙.Count)
            {
                goto label_45;
            }
            
            label_7:
            if(((-264036656) & 1) != 0)
            {
                goto label_46;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_47;
            label_88:
            val_50 = (丟上业世丞丑丛丏与.丘丞上世丗丘丏丐东)[1152921542997560112].丂丌丑一丏丌丌世丆;
            if(val_50 == null)
            {
                    System.Func<System.String, System.Boolean> val_28 = null;
                val_50 = val_28;
                val_28 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean 丟上业世丞丑丛丏与.丘丞上世丗丘丏丐东::丞且与丏七丙丟上专(string 丞丅上丏丂且下丅与));
                .丂丌丑一丏丌丌世丆 = val_50;
            }
            
            bool val_30 = this.丈丌丕下丄丞丘丐万.Remove(key:  System.Linq.Enumerable.First<System.String>(source:  this.丈丌丕下丄丞丘丐万.Keys, predicate:  val_28));
            label_47:
            if((System.Linq.Enumerable.Any<System.String>(source:  this.丈丌丕下丄丞丘丐万.Keys, predicate:  new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean 丟上业世丞丑丛丏与.丘丞上世丗丘丏丐东::一丏丗专丂丏丘下丕(string 丞丅上丏丂且下丅与)))) == true)
            {
                goto label_88;
            }
        
        }
        public override void 下丈丂丟丐业丟丂丁(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 与万丁丈与且丁三丁)
        {
            var val_13;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_14;
            var val_15;
            var val_16;
            if(与万丁丈与且丁三丁 == null)
            {
                    return;
            }
            
            val_13 = this.丈丌丕下丄丞丘丐万.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = val_13.GetEnumerator();
            val_14 = 1152921536207523776;
            val_15 = 1152921526102992048;
            val_16 = 1152921524492951872;
            label_7:
            if(((-263754664) & 1) == 0)
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = this.丈丌丕下丄丞丘丐万.Item[0.丐丏七丌丕丗业且上()];
            if((与万丁丈与且丁三丁.Contains(item:  val_4)) == true)
            {
                goto label_7;
            }
            
            与万丁丈与且丁三丁.Add(item:  val_4);
            goto label_7;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(与万丁丈与且丁三丁.Count < 1)
            {
                    return;
            }
            
            val_15 = 1152921537962402672;
            val_16 = 1152921516630043280;
            do
            {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = 与万丁丈与且丁三丁.Item[0];
                if((val_7.ContainsKey(key:  "gameEvent")) != false)
            {
                    val_14 = this.丈丌丕下丄丞丘丐万;
                if((System.Linq.Enumerable.Contains<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  val_14.Values, value:  val_7)) != true)
            {
                    bool val_11 = 与万丁丈与且丁三丁.Remove(item:  val_7);
            }
            
            }
            
                val_13 = 0 + 1;
            }
            while(val_13 < 与万丁丈与且丁三丁.Count);
        
        }
        private System.Collections.Generic.Dictionary<string, object> 丂丝丒丁下丄东业丝(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且)
        {
            var val_5;
            if(丗丛不丁丑专专丂且 == null)
            {
                goto label_1;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(val_5 == null)
            {
                goto label_2;
            }
            
            val_1.Add(key:  "gameEvent", value:  丗丛不丁丑专专丂且);
            goto label_3;
            label_1:
            val_5 = 0;
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_5;
            label_2:
            val_1.Add(key:  "gameEvent", value:  丗丛不丁丑专专丂且);
            label_3:
            val_1.Add(key:  "Type", value:  "gameEvent");
            Rilisoft.GameEventData val_2 = 丗丛不丁丑专专丂且.丁专丗万三上丟三丆();
            val_1.Add(key:  "Key", value:  System.String.Format(format:  "gameEvent-{0}", arg0:  val_2.EventId));
            Rilisoft.GameEventData val_4 = 丗丛不丁丑专专丂且.丁专丗万三上丟三丆();
            val_1.Add(key:  "ID", value:  val_4.EventId);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_5;
        }
    
    }

}
