using UnityEngine;

namespace PGCompany
{
    internal sealed class 业专丝丆与下丙丒丑
    {
        // Fields
        private static PGCompany.业专丝丆与下丙丒丑 丝业丆丁业三丈丟东;
        private const string 不丘丝丝三丕丈丐丌 = "hub_events_info";
        private System.Collections.Generic.Dictionary<PGCompany.EventHub.丄世丌东丏三东丒丂, PGCompany.业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟> 下丌丙世不丛丙丆东;
        private System.Collections.Generic.List<PGCompany.EventHub.丄世丌东丏三东丒丂> 三丏世上业丐丛三丁;
        private PGCompany.EventHub.丅丝丙与丑七不丛世 丁且且丒丞丅万丟东;
        private UnityEngine.Coroutine 世丈丗丂丕一上丕丂;
        
        // Properties
        internal static PGCompany.业专丝丆与下丙丒丑 丆丕丝丒不丙且丐丗 { get; }
        private PGCompany.EventHub.丅丝丙与丑七不丛世 丅丝丙与丑七不丛世 { get; }
        
        // Methods
        internal static PGCompany.业专丝丆与下丙丒丑 丑七不且上丗丁一世()
        {
            string val_1 = PGCompany.业专丝丆与下丙丒丑.不丘丝丝三丕丈丐丌;
            if(val_1 != null)
            {
                    return (PGCompany.业专丝丆与下丙丒丑)val_1;
            }
            
            PGCompany.业专丝丆与下丙丒丑.上丛丌丆丑上七世三();
            val_1 = PGCompany.业专丝丆与下丙丒丑.不丘丝丝三丕丈丐丌;
            return (PGCompany.业专丝丆与下丙丒丑)val_1;
        }
        private PGCompany.EventHub.丅丝丙与丑七不丛世 丕丂丕世丁且丁世一()
        {
            PGCompany.EventHub.丅丝丙与丑七不丛世 val_1 = this.丁且且丒丞丅万丟东;
            if(val_1 != null)
            {
                    return val_1;
            }
            
            this.丞丗不丞东世丅与丞();
            val_1 = this.丁且且丒丞丅万丟东;
            return val_1;
        }
        internal static void 上丛丌丆丑上七世三()
        {
            PGCompany.业专丝丆与下丙丒丑 val_1 = new PGCompany.业专丝丆与下丙丒丑();
            PGCompany.业专丝丆与下丙丒丑.不丘丝丝三丕丈丐丌 = val_1;
            val_1.丟下业丒业七丐丁丘();
            专丈专业丆且且业下.丄与东丌丟下丑与丛(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void PGCompany.业专丝丆与下丙丒丑::丘上丐世丆丑且丞丒()));
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void PGCompany.业专丝丆与下丙丒丑::丘上丐世丆丑且丞丒()));
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  val_1, method:  System.Void PGCompany.业专丝丆与下丙丒丑::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  val_1, method:  System.Void PGCompany.业专丝丆与下丙丒丑::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        }
        internal void 丘上丐世丆丑且丞丒()
        {
            this.丟下业丒业七丐丁丘();
        }
        internal bool 丂丐丆丈一专丗丄三()
        {
            return (bool)(this.三丏世上业丐丛三丁.Count > 0) ? 1 : 0;
        }
        internal PGCompany.EventHub.丄世丌东丏三东丒丂 丟丑三万丛丂丏万不()
        {
            if(this.三丏世上业丐丛三丁.Count < 1)
            {
                    return 5;
            }
            
            if(this.三丏世上业丐丛三丁 != null)
            {
                    return this.三丏世上业丐丛三丁.Item[0];
            }
            
            return this.三丏世上业丐丛三丁.Item[0];
        }
        internal void 丕丕丟丅一不丁丙丗()
        {
            this.丕丕丟丅一不丁丙丗(丂三丟丂丈丐丆丗丟:  PixelTime.丙丅丅业丟丁世丁丗());
        }
        internal void 丕丕丟丅一不丁丙丗(int 丂三丟丂丈丐丆丗丟)
        {
            var val_4;
            var val_17;
            if(this.丁且且丒丞丅万丟东 == null)
            {
                goto label_1;
            }
            
            if(丂三丟丂丈丐丆丗丟 >= 1)
            {
                goto label_2;
            }
            
            return;
            label_1:
            this.丞丗不丞东世丅与丞();
            if(丂三丟丂丈丐丆丗丟 < 1)
            {
                    return;
            }
            
            if(this.丁且且丒丞丅万丟东 == null)
            {
                    return;
            }
            
            label_2:
            val_17 = this.丁且且丒丞丅万丟东.丆丂丅丅丛丏丆丁专();
            List.Enumerator<T> val_2 = val_17.GetEnumerator();
            goto label_7;
            label_24:
            int val_5 = val_4.丙东专丂世丈丏丁丂();
            if((this.下丌丙世不丛丙丆东.ContainsKey(key:  val_5)) != true)
            {
                    new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟() = new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟();
                this.下丌丙世不丛丙丆东.set_Item(key:  val_5, value:  new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟());
            }
            
            if(this.丁且且丒丞丅万丟东 == null)
            {
                    this.丞丗不丞东世丅与丞();
            }
            
            PGCompany.EventHub.丁七丑丝丂丄丅丏丑 val_8 = 0.且丌与东七丛专丘东(丁丅丈丌丟世丗丗丟:  val_5);
            丝丁丄丅丈丁丏万丟 val_9 = this.下丌丙世不丛丙丆东.Item[val_5];
            if((System.String.op_Inequality(a:  val_9.专丏丟丆七与丙丁世, b:  val_8.丅东丄丛上丁丐万丏())) != false)
            {
                    丝丁丄丅丈丁丏万丟 val_12 = this.下丌丙世不丛丙丆东.Item[val_5];
                val_12.东专丙丑丏丆七丆专 = 0;
            }
            
            丝丁丄丅丈丁丏万丟 val_13 = this.下丌丙世不丛丙丆东.Item[val_5];
            val_13.专丏丟丆七与丙丁世 = val_8.丅东丄丛上丁丐万丏();
            val_17 = this.下丌丙世不丛丙丆东.Item[val_5];
            val_15.丞万丅丞丞不丆且与 = 丂三丟丂丈丐丆丗丟;
            label_7:
            if(((-842436544) & 1) != 0)
            {
                goto label_24;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.业丞丗丛丞丝丝下丙();
        }
        internal void 一东丁世丆与丆万丌(PGCompany.EventHub.丄世丌东丏三东丒丂 丈七丄丆丅丂东丄一)
        {
            if((this.下丌丙世不丛丙丆东.ContainsKey(key:  丈七丄丆丅丂东丄一)) != true)
            {
                    this.下丌丙世不丛丙丆东.set_Item(key:  丈七丄丆丅丂东丄一, value:  new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟());
            }
            
            丝丁丄丅丈丁丏万丟 val_3 = this.下丌丙世不丛丙丆东.Item[丈七丄丆丅丂东丄一];
            val_3.东专丙丑丏丆七丆专 = PixelTime.丙丅丅业丟丁世丁丗();
            this.业丞丗丛丞丝丝下丙();
        }
        internal void 不下丑丆丐且丆下与()
        {
            this.三丏世上业丐丛三丁.Clear();
            if(this.世丈丗丂丕一上丕丂 != null)
            {
                    return;
            }
            
            this.世丐丟丕一七丁专一();
        }
        internal void 丒专与三丈一丒丕丑()
        {
            if(this.世丈丗丂丕一上丕丂 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.世丈丗丂丕一上丕丂);
            this.世丈丗丂丕一上丕丂 = 0;
        }
        private void 世丐丟丕一七丁专一()
        {
            var val_6;
            object val_18;
            PGCompany.EventHub.丅丝丙与丑七不丛世 val_19;
            val_18 = this;
            val_19 = this.丁且且丒丞丅万丟东;
            this.世丈丗丂丕一上丕丂 = CoroutineRunner.不七丏丝丒一下丄万(丂三丟丂丈丐丆丗丟:  0.1f, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.业专丝丆与下丙丒丑::世丐丟丕一七丁专一()));
            if(val_19 == null)
            {
                    this.丞丗不丞东世丅与丞();
                val_19 = this.丁且且丒丞丅万丟东;
                if(val_19 == null)
            {
                    return;
            }
            
            }
            
            List.Enumerator<T> val_4 = val_19.丆丂丅丅丛丏丆丁专().GetEnumerator();
            label_22:
            if(((-841774512) & 1) == 0)
            {
                goto label_6;
            }
            
            int val_7 = val_6.丙东专丂世丈丏丁丂();
            if(this.丁且且丒丞丅万丟东 == null)
            {
                    this.丞丗不丞东世丅与丞();
            }
            
            PGCompany.EventHub.丁七丑丝丂丄丅丏丑 val_8 = 0.且丌与东七丛专丘东(丁丅丈丌丟世丗丗丟:  val_7);
            if(val_8 == null)
            {
                goto label_22;
            }
            
            if((val_8 & 1) != 0)
            {
                    if(val_8.丁丟丘世下丟万丙丕() != true)
            {
                    if(val_8.丐丄东丛东丛丕丘且() == false)
            {
                goto label_12;
            }
            
            }
            
            }
            
            label_18:
            if((this.三丏世上业丐丛三丁.Contains(item:  val_7)) == false)
            {
                goto label_22;
            }
            
            bool val_12 = this.三丏世上业丐丛三丁.Remove(item:  val_7);
            goto label_22;
            label_12:
            if((this.专一且业丑丂世丝东(丈七丄丆丅丂东丄一:  val_7, 丞丅上丏丂且下丅与:  val_8.丅东丄丛上丁丐万丏())) != true)
            {
                    if((this.业且与丟丄丄一三七(丈七丄丆丅丂东丄一:  val_7)) == false)
            {
                goto label_18;
            }
            
            }
            
            if((this.三丏世上业丐丛三丁.Contains(item:  val_7)) == true)
            {
                goto label_22;
            }
            
            this.三丏世上业丐丛三丁.Add(item:  val_7);
            goto label_22;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private bool 专一且业丑丂世丝东(PGCompany.EventHub.丄世丌东丏三东丒丂 丈七丄丆丅丂东丄一, string 丞丅上丏丂且下丅与)
        {
            if((this.下丌丙世不丛丙丆东.ContainsKey(key:  丈七丄丆丅丂东丄一)) == false)
            {
                    return true;
            }
            
            if(this.下丌丙世不丛丙丆东.Item[丈七丄丆丅丂东丄一] != null)
            {
                    return System.String.op_Inequality(a:  val_2.专丏丟丆七与丙丁世, b:  丞丅上丏丂且下丅与);
            }
            
            return System.String.op_Inequality(a:  val_2.专丏丟丆七与丙丁世, b:  丞丅上丏丂且下丅与);
        }
        private bool 业且与丟丄丄一三七(PGCompany.EventHub.丄世丌东丏三东丒丂 丈七丄丆丅丂东丄一)
        {
            var val_13;
            System.Collections.Generic.Dictionary<PGCompany.EventHub.丄世丌东丏三东丒丂, 丝丁丄丅丈丁丏万丟> val_14;
            var val_15;
            val_13 = this;
            val_14 = this.下丌丙世不丛丙丆东;
            if((val_14.ContainsKey(key:  丈七丄丆丅丂东丄一)) == false)
            {
                goto label_2;
            }
            
            val_14 = PixelTime.丙丅丅业丟丁世丁丗();
            丝丁丄丅丈丁丏万丟 val_3 = this.下丌丙世不丛丙丆东.Item[丈七丄丆丅丂东丄一];
            if(this.丁且且丒丞丅万丟东 == null)
            {
                    this.丞丗不丞东世丅与丞();
            }
            
            if((val_14 - val_3.丞万丅丞丞不丆且与) >= (0.丅业丘丟丗世丌丅不().丗丁丈上三丗丛丝丐() << ))
            {
                goto label_10;
            }
            
            val_15 = 0;
            return (bool)((val_14 - val_8.东专丙丑丏丆七丆专) >= (val_13.世且不丘业丄业丄万() << )) ? 1 : 0;
            label_2:
            val_15 = 1;
            return (bool)((val_14 - val_8.东专丙丑丏丆七丆专) >= (val_13.世且不丘业丄业丄万() << )) ? 1 : 0;
            label_10:
            val_14 = PixelTime.丙丅丅业丟丁世丁丗();
            丝丁丄丅丈丁丏万丟 val_8 = this.下丌丙世不丛丙丆东.Item[丈七丄丆丅丂东丄一];
            if(this.丁且且丒丞丅万丟东 == null)
            {
                    this.丞丗不丞东世丅与丞();
            }
            
            val_13 = 0.丅业丘丟丗世丌丅不();
            return (bool)((val_14 - val_8.东专丙丑丏丆七丆专) >= (val_13.世且不丘业丄业丄万() << )) ? 1 : 0;
        }
        private void 丟下业丒业七丐丁丘()
        {
            int val_8;
            object val_9;
            string val_16;
            var val_18;
            this.下丌丙世不丛丙丆东 = 0;
            val_16 = System.String.Format(format:  "{0}.{1}", arg0:  "hub_events_info", arg1:  FriendsController.不丝丕丒丂丆丘丙丙());
            string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  val_16, 丞丌丑丛上丕丙丕下:  System.String.alignConst);
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) == true) || ((UnityEngine.JsonUtility.FromJson<EventInfoHandler>(json:  val_3)) == null))
            {
                goto label_32;
            }
            
            System.Collections.Generic.Dictionary<PGCompany.EventHub.丄世丌东丏三东丒丂, 丝丁丄丅丈丁丏万丟> val_6 = new System.Collections.Generic.Dictionary<PGCompany.EventHub.丄世丌东丏三东丒丂, 丝丁丄丅丈丁丏万丟>();
            this.下丌丙世不丛丙丆东 = null;
            List.Enumerator<T> val_7 = val_5.Data.GetEnumerator();
            label_15:
            if(((-841178160) & 1) == 0)
            {
                goto label_10;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟() = new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟();
            if(new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟() != null)
            {
                    .专丏丟丆七与丙丁世 = null;
                .丞万丅丞丞不丆且与 = val_8;
            }
            else
            {
                    mem[16] = ???;
                mem[24] = ???;
            }
            
            .东专丙丑丏丆七丆专 = ;
            this.下丌丙世不丛丙丆东.set_Item(key:  val_10.m_stringLength, value:  new 业专丝丆与下丙丒丑.丝丁丄丅丈丁丏万丟());
            goto label_15;
            label_10:
            val_16 = 0;
            val_18 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_28;
            }
            
            if( == 0)
            {
                goto label_32;
            }
            
            if(179 != 179)
            {
                goto label_30;
            }
            
            goto label_32;
            label_28:
            if( == 0)
            {
                goto label_32;
            }
            
            label_30:
            label_32:
            if(this.下丌丙世不丛丙丆东 != null)
            {
                    return;
            }
            
            this.下丌丙世不丛丙丆东 = new System.Collections.Generic.Dictionary<PGCompany.EventHub.丄世丌东丏三东丒丂, 丝丁丄丅丈丁丏万丟>();
        }
        private void 业丞丗丛丞丝丝下丙()
        {
            string val_5;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.下丌丙世不丛丙丆东.GetEnumerator();
            label_8:
            if(((-840976960) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            new 业专丝丆与下丙丒丑.EventInfoParams() = new 业专丝丆与下丙丒丑.EventInfoParams(丈七丄丆丅丂东丄一:  val_6._value._obj.丙东专丂世丈丏丁丂(), 丞丅上丏丂且下丅与:  val_5, 世丞丌丐东丕丞丆丐:  val_5, 丗丗丑丅丞丙丐一万:  val_5);
            (业专丝丆与下丙丒丑.EventInfoHandler)[1152921555305521712].Data.Add(item:  new 业专丝丆与下丙丒丑.EventInfoParams());
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "hub_events_info." + FriendsController.不丝丕丒丂丆丘丙丙(), 下下丏一丙不丘丌丞:  UnityEngine.JsonUtility.ToJson(obj:  new 业专丝丆与下丙丒丑.EventInfoHandler()));
        }
        private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 105)
            {
                    return;
            }
            
            this.丞丗不丞东世丅与丞();
        }
        private void 丞丗不丞东世丅与丞()
        {
            if(PGCompany.EventHub.EventHubBanner.丝丏上且丄丗丛丕世() == null)
            {
                goto label_3;
            }
            
            if(this != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            this.丁且且丒丞丅万丟东 = new PGCompany.EventHub.丅丝丙与丑七不丛世(不丐专不丒丒上丒业:  PGCompany.EventHub.EventHubBanner.丝丏上且丄丗丛丕世(), 丁世丛业丟下丕三丟:  0);
            return;
            label_3:
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_8;
        }
        public 业专丝丆与下丙丒丑()
        {
            this.三丏世上业丐丛三丁 = new System.Collections.Generic.List<PGCompany.EventHub.丄世丌东丏三东丒丂>();
        }
    
    }

}
