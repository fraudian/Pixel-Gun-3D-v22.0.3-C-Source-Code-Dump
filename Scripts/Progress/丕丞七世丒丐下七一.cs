using UnityEngine;

namespace Progress
{
    internal class 丕丞七世丒丐下七一 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private static readonly System.Collections.Generic.Dictionary<int, Rilisoft.GameEventType> 不一上丈丒丑与丛三;
        internal System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且> 丑丑丘丅丝丄丈丘东;
        internal System.Collections.Generic.List<Rilisoft.丛且世丐丆上七业丁.FreeSpin> 丘丘下丟丙不丂三丘;
        internal System.Collections.Generic.Dictionary<int, 丙下且专一丒丂专七> 万丆丗丅一丌丅丑丏;
        internal System.Collections.Generic.Dictionary<int, 丟丈丁世与丑丟丛丑> 丙丕丏丅丗丏丝上不;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        internal System.Collections.Generic.List<int> 丏不丟东丆三东丏一 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丕丞七世丒丐下七一.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丕丞七世丒丐下七一.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 19;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_16;
            var val_17;
            var val_18;
            this.丑丑丘丅丝丄丈丘东.Clear();
            this.丘丘下丟丙不丂三丘.Clear();
            this.万丆丗丅一丌丅丑丏.Clear();
            this.丙丕丏丅丗丏丝上不.Clear();
            if((0.ContainsKey(key:  "c")) != false)
            {
                    object val_2 = 0.Item["c"];
                this.丑丑丘丅丝丄丈丘东 = val_2.东丁丁世上与丆丑丟(万且万且丑丗且丌丆:  val_2);
            }
            
            if((0.ContainsKey(key:  "f")) != false)
            {
                    if(0.Item["f"] != null)
            {
                    val_16 = 0;
            }
            
                this.丘丘下丟丙不丂三丘 = 丛且世丐丆上七业丁.FreeSpin.丅丏下丛世七上丑丏(丐丏三丂丕世七丁丅:  null);
            }
            
            if((0.ContainsKey(key:  "ec")) != false)
            {
                    if(0.Item["ec"] != null)
            {
                    val_17 = 0;
            }
            
                this.万丆丗丅一丌丅丑丏 = 丙下且专一丒丂专七.丅丏下丛世七上丑丏(丏丂万业丙专丏丒丒:  null);
            }
            
            if((0.ContainsKey(key:  "er")) == false)
            {
                    return;
            }
            
            if(0.Item["er"] != null)
            {
                    val_18 = 0;
            }
            
            this.丙丕丏丅丗丏丝上不 = 丟丈丁世与丑丟丛丑.丅丏下丛世七上丑丏(丏丂万业丙专丏丒丒:  null);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "c", value:  val_1.一丌丆业丄不丆与不(丑丑丘丅丝丄丈丘东:  this.丑丑丘丅丝丄丈丘东));
            val_1.Add(key:  "f", value:  丛且世丐丆上七业丁.FreeSpin.东丈一丙一下丗下与(丘丘下丟丙不丂三丘:  this.丘丘下丟丙不丂三丘));
            val_1.Add(key:  "ec", value:  丙下且专一丒丂专七.东丈一丙一下丗下与(上丏丗东丆丏丛丞丅:  this.万丆丗丅一丌丅丑丏));
            val_1.Add(key:  "er", value:  丟丈丁世与丑丟丛丑.东丈一丙一下丗下与(上丏丗东丆丏丛丞丅:  this.丙丕丏丅丗丏丝上不));
            return (object)val_1;
        }
        private Rilisoft.GameEventType 丝丆丕丏七丕世丁七(string 丝丏业丅丈东业丝丒)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((Rilisoft.三一丈七且丄与丝东.丞东三丄专丏丌业丂.ContainsKey(key:  丝丏业丅丈东业丝丒)) == false)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            if(Rilisoft.三一丈七且丄与丝东.丞东三丄专丏丌业丂 != null)
            {
                    return Rilisoft.三一丈七且丄与丝东.丞东三丄专丏丌业丂.Item[丝丏业丅丈东业丝丒];
            }
            
            return Rilisoft.三一丈七且丄与丝东.丞东三丄专丏丌业丂.Item[丝丏业丅丈东业丝丒];
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            object val_4;
            var val_59;
            var val_60;
            var val_62;
            var val_63;
            var val_64;
            var val_68;
            var val_69;
            var val_71;
            val_59 = null;
            val_59 = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = Rilisoft.三一丈七且丄与丝东.丞东三丄专丏丌业丂.GetEnumerator();
            val_60 = 1152921541237533808;
            label_7:
            if(((-2023867360) & 1) == 0)
            {
                goto label_4;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            val_4 = 1;
            bool val_14 = this.业七业丄业丟丄下一(丙业与丙丗丝不丈东:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}_{2}", arg0:  "EventCurrency", arg1:  val_5._value._obj.丐丏七丌丕丗业且上(), arg2:  0), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}_{2}", arg0:  "EventCurrency", arg1:  val_5._value._obj.丐丏七丌丕丗业且上(), arg2:  val_4), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)), 丟丟丄专上丟丁丐丝:  val_5._value._obj.丐丏七丌丕丗业且上());
            goto label_7;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(((new Rilisoft.不丅且丝丁丁与不丒<FreeSpinsContainer>(丟东丟丑丕丄丂丟丙:  "game-events-free-spins")) != null) && (null != null))
            {
                    mem[1152921541237697448] = null;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_17 = Rilisoft.三一丈七且丄与丝东.丏丝丝丌丗丘且丄丅().GetEnumerator();
            val_62 = 0;
            val_63 = 0;
            label_105:
            if(((-2023867424) & 1) == 0)
            {
                goto label_29;
            }
            
            ConfiguredValueTaskAwaiter val_18 = val_4.GetAwaiter();
            if((Rilisoft.三一丈七且丄与丝东.丏一丞一丅丘东业丕().ContainsKey(key:  val_18._value._obj.丙东专丂世丈丏丁丂())) == false)
            {
                goto label_105;
            }
            
            string val_24 = Rilisoft.三一丈七且丄与丝东.丏一丞一丅丘东业丕().Item[val_18._value._obj.丙东专丂世丈丏丁丂()];
            int val_26 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}-spins-count", arg0:  val_24), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            int val_27 = val_26.业丂丁丐丂丞丗不丘(丅且丐丄世不丙一丕:  val_24);
            Rilisoft.GameEventType val_28 = val_27.丝丆丕丏七丕世丁七(丝丏业丅丈东业丝丒:  val_24);
            if(val_28 == 0)
            {
                goto label_105;
            }
            
            if(val_28 != 100)
            {
                goto label_74;
            }
            
            if((mem[1152921541237697456].ContainsKey(key:  val_18._value._obj.丙东专丂世丈丏丁丂())) != true)
            {
                    new 丙下且专一丒丂专七() = new 丙下且专一丒丂专七();
                mem[1152921541237697456].set_Item(key:  val_18._value._obj.丙东专丂世丈丏丁丂(), value:  new 丙下且专一丒丂专七());
            }
            
            if(val_26 >= 1)
            {
                    丙下且专一丒丂专七 val_34 = mem[1152921541237697456].Item[val_18._value._obj.丙东专丂世丈丏丁丂()];
                Rilisoft.丝丑丂丛万丐丈丘且 val_35 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_26);
                val_34.丕丗专且丆丂丌丕丒 = val_35;
                mem2[0] = val_35.上万三丆专丏丒丗业;
            }
            
            if((val_27 & 2147483648) == 0)
            {
                    丙下且专一丒丂专七 val_37 = mem[1152921541237697456].Item[val_18._value._obj.丙东专丂世丈丏丁丂()];
                val_37.丆万一不丌且东丐丐 = val_27;
            }
            
            List.Enumerator<T> val_38 = val_18._value._obj.GetEnumerator();
            do
            {
                label_57:
                val_64 = 0;
                if(((-2023867472) & 1) == 0)
            {
                goto label_58;
            }
            
                int val_39 = 1.GetHashCode();
                val_4 = val_18._value._obj.丙东专丂世丈丏丁丂();
                Rilisoft.不丅且丝丁丁与不丒<ChestProgressDataObject> val_42 = new Rilisoft.不丅且丝丁丁与不丒<ChestProgressDataObject>(丟东丟丑丕丄丂丟丙:  System.String.Format(format:  "event_chest_progress_{0}_{1}", arg0:  val_4, arg1:  val_39));
            }
            while(null == null);
            
            丙下且专一丒丂专七 val_44 = mem[1152921541237697456].Item[val_18._value._obj.丙东专丂世丈丏丁丂()];
            val_44.丑一丈丅丆丂丙丙丐.set_Item(key:  val_39, value:  null);
            goto label_57;
            label_58:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_60 = 1;
            if((val_60 == 1) || (761 != 761))
            {
                goto label_71;
            }
            
            val_60 = val_60 + val_64 ^ 0;
            goto label_105;
            label_71:
            if( != 0)
            {
                    val_68 = 0;
            }
            
            label_74:
            if((mem[1152921541237697464].ContainsKey(key:  val_18._value._obj.丙东专丂世丈丏丁丂())) != true)
            {
                    new 丟丈丁世与丑丟丛丑() = new 丟丈丁世与丑丟丛丑();
                mem[1152921541237697464].set_Item(key:  val_18._value._obj.丙东专丂世丈丏丁丂(), value:  new 丟丈丁世与丑丟丛丑());
            }
            
            if((val_27 & 2147483648) == 0)
            {
                    丟丈丁世与丑丟丛丑 val_51 = mem[1152921541237697464].Item[val_18._value._obj.丙东专丂世丈丏丁丂()];
                val_51.丆万一不丌且东丐丐 = val_27;
            }
            
            List.Enumerator<T> val_52 = val_18._value._obj.GetEnumerator();
            label_88:
            if(((-2023867472) & 1) == 0)
            {
                goto label_82;
            }
            
            int val_54 = val_39.GetHashCode();
            val_4 = val_18._value._obj.丙东专丂世丈丏丁丂();
            Rilisoft.不丅且丝丁丁与不丒<ChestProgressDataObject> val_57 = new Rilisoft.不丅且丝丁丁与不丒<ChestProgressDataObject>(丟东丟丑丕丄丂丟丙:  System.String.Format(format:  "event_chest_progress_{0}_{1}", arg0:  val_4, arg1:  val_54));
            if(null == null)
            {
                goto label_88;
            }
            
            丟丈丁世与丑丟丛丑 val_59 = mem[1152921541237697464].Item[val_18._value._obj.丙东专丂世丈丏丁丂()];
            val_59.丑一丈丅丆丂丙丙丐.set_Item(key:  val_54, value:  null);
            goto label_88;
            label_82:
            var val_61 = val_60;
            val_61 = val_61 + 1;
            mem2[0] = 761;
            val_69 = ;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_63 = val_61;
            if((val_63 == 1) || ((-2023867584 + (((1 + (val_64 ^ 0)) + 1)) << 2) != 761))
            {
                goto label_102;
            }
            
            var val_62 = 0;
            val_62 = val_62 ^ (val_63 >> 31);
            val_63 = val_63 + val_62;
            goto label_105;
            label_102:
            if( == 0)
            {
                goto label_105;
            }
            
            goto label_105;
            label_29:
            val_71 = val_63 + 1;
            mem2[0] = 789;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((-2023867584 + ((((1 + (val_64 ^ 0)) + 1) + (0 ^ ((int)((1 + (val_64 ^ 0)) + 1)) >> 31))) << 2) == 789)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            int val_10;
            var val_92;
            var val_98;
            Progress.丕丞七世丒丐下七一 val_99;
            var val_100;
            System.Func<System.Int32, System.String> val_102;
            var val_103;
            var val_104;
            var val_106;
            System.Func<FreeSpin, System.Int32> val_108;
            var val_109;
            System.Func<System.Int32, System.Int32> val_111;
            char val_112;
            var val_113;
            var val_114;
            System.Func<System.Int32, System.String> val_116;
            var val_117;
            var val_119;
            var val_120;
            var val_121;
            var val_122;
            var val_123;
            System.Func<System.Int32, System.Int32> val_125;
            var val_126;
            var val_127;
            System.Func<System.Int32, System.Int32> val_129;
            var val_130;
            var val_131;
            System.Func<System.String, System.String> val_133;
            var val_134;
            int val_136;
            var val_137;
            val_98;
            val_99 = this;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(this.丑丑丘丅丝丄丈丘东.Count < 1)
            {
                goto label_29;
            }
            
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
            val_100 = null;
            val_100 = null;
            val_102 = 丕丞七世丒丐下七一.<>c.<>9__13_0;
            if(val_102 == null)
            {
                    System.Func<System.Int32, System.String> val_5 = null;
                val_102 = val_5;
                val_5 = new System.Func<System.Int32, System.String>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丞七世丒丐下七一.<>c::丕万丒丌三丝丈丌丈(int 三丟东丕丄丄下下丑));
                丕丞七世丒丐下七一.<>c.<>9__13_0 = val_102;
            }
            
            List.Enumerator<T> val_8 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Int32, System.String>(source:  this.丑丑丘丅丝丄丈丘东.Keys, keySelector:  val_5)).GetEnumerator();
            label_15:
            if(((-2023265200) & 1) == 0)
            {
                goto label_10;
            }
            
            int val_11 = val_10.丙东专丂世丈丏丁丂();
            Rilisoft.丝丑丂丛万丐丈丘且 val_12 = this.丑丑丘丅丝丄丈丘东.Item[val_11];
            if((-2023265216) < 1)
            {
                goto label_15;
            }
            
            val_10 = val_11;
            Rilisoft.丝丑丂丛万丐丈丘且 val_13 = this.丑丑丘丅丝丄丈丘东.Item[val_11];
            System.Text.StringBuilder val_15 = val_3.Append(value:  System.String.Format(format:  "{0}:{1}", arg0:  val_10, arg1:  val_13.七丄不丐丗三丝丑一));
            goto label_15;
            label_10:
            val_104 = public System.Void List.Enumerator<System.Int32>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_99 = val_99;
            if((System.String.IsNullOrEmpty(value:  val_3)) != true)
            {
                    System.Text.StringBuilder val_18 = val_1.Append(value:  System.String.Format(format:  "c:{0}", arg0:  val_3));
            }
            
            label_29:
            if(mem[1152921541238299592].Count < 1)
            {
                goto label_53;
            }
            
            System.Text.StringBuilder val_20 = val_1.Append(value:  "f:");
            val_106 = null;
            val_106 = null;
            val_108 = 丕丞七世丒丐下七一.<>c.<>9__13_1;
            if(val_108 == null)
            {
                    System.Func<FreeSpin, System.Int32> val_21 = null;
                val_108 = val_21;
                val_21 = new System.Func<FreeSpin, System.Int32>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕丞七世丒丐下七一.<>c::下丂丏不与不且丌丞(Rilisoft.丛且世丐丆上七业丁.FreeSpin 三丟东丕丄丄下下丑));
                丕丞七世丒丐下七一.<>c.<>9__13_1 = val_108;
            }
            
            List.Enumerator<T> val_24 = System.Linq.Enumerable.ToList<FreeSpin>(source:  System.Linq.Enumerable.OrderBy<FreeSpin, System.Int32>(source:  mem[1152921541238299592], keySelector:  val_21)).GetEnumerator();
            val_103 = 1152921541237998576;
            label_43:
            if(((-2023265248) & 1) == 0)
            {
                goto label_40;
            }
            
            val_10 = val_25.m_firstChar;
            System.Text.StringBuilder val_28 = val_1.Append(value:  System.String.Format(format:  "i:{0}c:{1}t:{2}", arg0:  val_10, arg1:  val_10.丐丏七丌丕丗业且上().SpinsCount, arg2:  null));
            goto label_43;
            label_40:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_99 = val_99;
            label_53:
            if(mem[1152921541238299600].Count < 1)
            {
                goto label_55;
            }
            
            System.Text.StringBuilder val_30 = val_1.Append(value:  "ec:");
            val_109 = null;
            val_109 = null;
            val_111 = 丕丞七世丒丐下七一.<>c.<>9__13_2;
            if(val_111 == null)
            {
                    System.Func<System.Int32, System.Int32> val_32 = null;
                val_111 = val_32;
                val_32 = new System.Func<System.Int32, System.Int32>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕丞七世丒丐下七一.<>c::丑三东东丅丕丛上丗(int 三丟东丕丄丄下下丑));
                丕丞七世丒丐下七一.<>c.<>9__13_2 = val_111;
            }
            
            List.Enumerator<T> val_35 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Int32, System.Int32>(source:  mem[1152921541238299600].Keys, keySelector:  val_32)).GetEnumerator();
            val_112 = 0;
            val_113 = 0;
            label_117:
            if(((-2023265200) & 1) == 0)
            {
                goto label_64;
            }
            
            int val_36 = val_10.丙东专丂世丈丏丁丂();
            System.Text.StringBuilder val_38 = val_1.Append(value:  System.String.Format(format:  "{0}:", arg0:  val_36));
            丙下且专一丒丂专七 val_39 = mem[1152921541238299600].Item[val_36];
            if(val_39.丕丗专且丆丂丌丕丒 >= 1)
            {
                    System.Text.StringBuilder val_41 = val_1.Append(value:  System.String.Format(format:  "s:{0}", arg0:  val_39.丕丗专且丆丂丌丕丒));
            }
            
            val_114 = null;
            val_114 = null;
            val_116 = 丕丞七世丒丐下七一.<>c.<>9__13_3;
            if(val_116 == null)
            {
                    val_116 = null;
                val_116 = new System.Func<System.Int32, System.String>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丞七世丒丐下七一.<>c::三专丅丛丂丘丟且东(int 三丟东丕丄丄下下丑));
                丕丞七世丒丐下七一.<>c.<>9__13_3 = val_116;
            }
            
            System.Collections.Generic.List<TSource> val_45 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Int32, System.String>(source:  val_39.丑一丈丅丆丂丙丙丐.Keys, keySelector:  null));
            if(val_45.Count < 1)
            {
                goto label_117;
            }
            
            System.Text.StringBuilder val_47 = val_1.Append(value:  "p:");
            List.Enumerator<T> val_48 = val_45.GetEnumerator();
            label_102:
            if(((-2023265280) & 1) == 0)
            {
                goto label_82;
            }
            
            int val_50 = val_39.丕丗专且丆丂丌丕丒.丙东专丂世丈丏丁丂();
            System.Text.StringBuilder val_52 = val_1.Append(value:  System.String.Format(format:  "{0}:", arg0:  val_50));
            Dictionary.Enumerator<TKey, TValue> val_55 = val_39.丑一丈丅丆丂丙丙丐.Item[val_50].七丕且七丙丌丄七丘().GetEnumerator();
            label_90:
            if(((-2023265328) & 1) == 0)
            {
                goto label_88;
            }
            
            ConfiguredValueTaskAwaiter val_57 = val_10.GetAwaiter();
            System.Text.StringBuilder val_61 = val_1.Append(value:  val_57._value._obj.丐丏七丌丕丗业且上() + ":"(":") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_57._value._obj)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_57._value._obj)));
            goto label_90;
            label_88:
            val_117 = val_113;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((1 == 1) || (812 != 812))
            {
                goto label_99;
            }
            
            goto label_102;
            label_99:
            if( == 0)
            {
                goto label_102;
            }
            
            goto label_102;
            label_82:
            val_119 = val_113;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if((1 == 1) || (840 != 840))
            {
                goto label_114;
            }
            
            goto label_117;
            label_114:
            if( == 0)
            {
                goto label_117;
            }
            
            goto label_117;
            label_55:
            val_113 = 0;
            val_120 = 0;
            goto label_146;
            label_64:
            val_120 = 0 + 1;
            mem2[0] = 868;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_120 != 1) && ((-2023265552 + ((0 + 1)) << 2) == 868))
            {
                    var val_98 = 0;
                val_98 = val_98 ^ (val_120 >> 31);
                val_120 = val_120 + val_98;
            }
            else
            {
                    if( != 0)
            {
                    val_113 = 0;
            }
            
            }
            
            label_146:
            val_121 = mem[1152921541238299608];
            val_122 = public System.Int32 System.Collections.Generic.Dictionary<System.Int32, 丟丈丁世与丑丟丛丑>::get_Count();
            if(val_121.Count < 1)
            {
                goto label_240;
            }
            
            System.Text.StringBuilder val_63 = val_1.Append(value:  "er:");
            val_123 = null;
            val_123 = null;
            val_125 = 丕丞七世丒丐下七一.<>c.<>9__13_4;
            if(val_125 == null)
            {
                    System.Func<System.Int32, System.Int32> val_65 = null;
                val_125 = val_65;
                val_65 = new System.Func<System.Int32, System.Int32>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕丞七世丒丐下七一.<>c::丂万丂三丗丞丁且丛(int 三丟东丕丄丄下下丑));
                丕丞七世丒丐下七一.<>c.<>9__13_4 = val_125;
            }
            
            val_121 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Int32, System.Int32>(source:  mem[1152921541238299608].Keys, keySelector:  val_65));
            List.Enumerator<T> val_68 = val_121.GetEnumerator();
            val_126 = 1152921525710256128;
            label_217:
            if(((-2023265200) & 1) == 0)
            {
                goto label_157;
            }
            
            int val_70 = null.丙东专丂世丈丏丁丂();
            System.Text.StringBuilder val_72 = val_1.Append(value:  System.String.Format(format:  "{0}:", arg0:  val_70));
            丟丈丁世与丑丟丛丑 val_73 = mem[1152921541238299608].Item[val_70];
            val_127 = null;
            val_127 = null;
            val_129 = 丕丞七世丒丐下七一.<>c.<>9__13_5;
            if(val_129 == null)
            {
                    val_129 = null;
                val_129 = new System.Func<System.Int32, System.Int32>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕丞七世丒丐下七一.<>c::丗丌丌业丏丐丂丘专(int 三丟东丕丄丄下下丑));
                val_130 = val_126;
                丕丞七世丒丐下七一.<>c.<>9__13_5 = val_129;
            }
            
            System.Collections.Generic.List<TSource> val_77 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.OrderBy<System.Int32, System.Int32>(source:  val_73.丑一丈丅丆丂丙丙丐.Keys, keySelector:  null));
            if(val_77.Count < 1)
            {
                goto label_217;
            }
            
            System.Text.StringBuilder val_79 = val_1.Append(value:  "p:");
            List.Enumerator<T> val_80 = val_77.GetEnumerator();
            label_197:
            if(((-2023265280) & 1) == 0)
            {
                goto label_171;
            }
            
            int val_81 = val_70.GetHashCode();
            System.Text.StringBuilder val_83 = val_1.Append(value:  System.String.Format(format:  "{0}:", arg0:  val_81));
            System.Collections.Generic.Dictionary<System.String, System.Object> val_85 = val_73.丑一丈丅丆丂丙丙丐.Item[val_81].下丆丕业万丗下业七();
            val_131 = null;
            val_131 = null;
            val_133 = 丕丞七世丒丐下七一.<>c.<>9__13_6;
            if(val_133 == null)
            {
                    val_133 = null;
                val_133 = new System.Func<System.String, System.String>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丞七世丒丐下七一.<>c::一三丏业三三丅丄万(string 三丟东丕丄丄下下丑));
                丕丞七世丒丐下七一.<>c.<>9__13_6 = val_133;
            }
            
            List.Enumerator<T> val_90 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  val_85.Keys, keySelector:  null)).GetEnumerator();
            label_186:
            if(((-2023265376) & 1) == 0)
            {
                goto label_183;
            }
            
            string val_93 = val_92.丐丏七丌丕丗业且上();
            System.Text.StringBuilder val_97 = val_1.Append(value:  val_93 + ":"(":") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_85.Item[val_93])(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_85.Item[val_93])));
            goto label_186;
            label_183:
            var val_99 = val_120;
            val_134 = val_113;
            val_99 = val_99 + 1;
            mem2[0] = 1280;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_101 = val_99;
            if((val_101 == 1) || ((-2023265552 + (((0 + 1) + 1)) << 2) != 1280))
            {
                goto label_194;
            }
            
            var val_100 = 0;
            val_100 = val_100 ^ (val_101 >> 31);
            val_101 = val_101 + val_100;
            goto label_197;
            label_194:
            if( == 0)
            {
                goto label_197;
            }
            
            goto label_197;
            label_171:
            val_136 = val_113;
            val_137 = val_101 + 1;
            mem2[0] = 1308;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(( == 1) || ((-2023265552 + ((((0 + 1) + 1) + (0 ^ ((int)((0 + 1) + 1)) >> 31))) << 2) != 1308))
            {
                goto label_214;
            }
            
            var val_102 = 0;
            val_102 = val_102 ^ ( >> 31);
             =  + val_102;
            goto label_217;
            label_214:
            if( == 0)
            {
                goto label_217;
            }
            
            goto label_217;
            label_157:
            val_120 =  + 1;
            mem2[0] = 1336;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_235;
            }
            
            if(( == 0) || ((-2023265552 + ((((0 + 1) + 1) + (0 ^ ((int)((0 + 1) + 1)) >> 31))) << 2) == 1336))
            {
                goto label_240;
            }
            
            label_239:
            val_122 = 0;
            label_240:
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
            label_235:
            if( != 0)
            {
                goto label_239;
            }
            
            goto label_240;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丑丑丘丅丝丄丈丘东.Clear();
            this.丘丘下丟丙不丂三丘.Clear();
            this.万丆丗丅一丌丅丑丏.Clear();
            this.丙丕丏丅丗丏丝上不.Clear();
        }
        internal System.Collections.Generic.List<int> 丅丁一丌丌与丛专丐()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_1.AddRange(collection:  System.Linq.Enumerable.ToList<System.Int32>(source:  this.万丆丗丅一丌丅丑丏.Keys));
            val_1.AddRange(collection:  System.Linq.Enumerable.ToList<System.Int32>(source:  this.丙丕丏丅丗丏丝上不.Keys));
            return val_1;
        }
        internal Rilisoft.GameEventType 丒万丈丕专丝丛丒不(int 丙下不丏丅丅专丂丗)
        {
            var val_4;
            if((this.万丆丗丅一丌丅丑丏.ContainsKey(key:  丙下不丏丅丅专丂丗)) == false)
            {
                    return (Rilisoft.GameEventType)((this.丙丕丏丅丗丏丝上不.ContainsKey(key:  丙下不丏丅丅专丂丗)) != true) ? 200 : 0;
            }
            
            val_4 = 100;
            return (Rilisoft.GameEventType)((this.丙丕丏丅丗丏丝上不.ContainsKey(key:  丙下不丏丅丅专丂丗)) != true) ? 200 : 0;
        }
        internal int 丕丂丄丙丌丒丝丑丆(int 丅且三万丘丙业丙丗)
        {
            int val_8 = 丅且三万丘丙业丙丗;
            if((this.万丆丗丅一丌丅丑丏.ContainsKey(key:  val_8 = 丅且三万丘丙业丙丗)) == false)
            {
                    return 0;
            }
            
            丙下且专一丒丂专七 val_2 = this.万丆丗丅一丌丅丑丏.Item[val_8];
            val_8 = ???;
            return 0;
        }
        internal int 东丅一丘丏东下丕丆(int 丅且三万丘丙业丙丗)
        {
            System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七> val_4;
            var val_5;
            int val_6;
            if((this.万丆丗丅一丌丅丑丏.ContainsKey(key:  丅且三万丘丙业丙丗)) == false)
            {
                goto label_2;
            }
            
            val_4 = this.万丆丗丅一丌丅丑丏;
            val_5 = 1152921541237601616;
            goto label_4;
            label_2:
            if((this.丙丕丏丅丗丏丝上不.ContainsKey(key:  丅且三万丘丙业丙丗)) == false)
            {
                goto label_6;
            }
            
            val_4 = this.丙丕丏丅丗丏丝上不;
            val_5 = 1152921541237643728;
            label_4:
            if(val_4.Item[丅且三万丘丙业丙丗] == null)
            {
                goto label_8;
            }
            
            val_6 = val_3.丆万一不丌且东丐丐;
            return (int)val_6;
            label_6:
            val_6 = 0;
            return (int)val_6;
            label_8:
        }
        internal string 专丈世丘丝丒丙丙丐(int 丅且三万丘丙业丙丗)
        {
            int val_1 = this.东丅一丘丏东下丕丆(丅且三万丘丙业丙丗:  丅且三万丘丙业丙丗);
            return val_1.丌专丒不丝不世与万(丈丂下丝丕丞与七世:  val_1);
        }
        internal Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 丄丟丒丁丙三丞丗丒(int 丅且三万丘丙业丙丗, int 丐东业丕丕丂丗丅丙)
        {
            System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七> val_10;
            var val_11;
            val_10 = this;
            if((this.万丆丗丅一丌丅丑丏.ContainsKey(key:  丅且三万丘丙业丙丗)) == false)
            {
                goto label_6;
            }
            
            丙下且专一丒丂专七 val_2 = this.万丆丗丅一丌丅丑丏.Item[丅且三万丘丙业丙丗];
            if((val_2.丑一丈丅丆丂丙丙丐.ContainsKey(key:  丐东业丕丕丂丗丅丙)) == false)
            {
                goto label_6;
            }
            
            val_10 = this.万丆丗丅一丌丅丑丏;
            丙下且专一丒丂专七 val_4 = val_10.Item[丅且三万丘丙业丙丗];
            if(val_4.丑一丈丅丆丂丙丙丐 != null)
            {
                goto label_19;
            }
            
            label_20:
            label_19:
            ChestProgressDataObject val_5 = val_4.丑一丈丅丆丂丙丙丐.Item[丐东业丕丕丂丗丅丙];
            return (ChestProgressDataObject)val_11;
            label_6:
            if((this.丙丕丏丅丗丏丝上不.ContainsKey(key:  丅且三万丘丙业丙丗)) == false)
            {
                goto label_16;
            }
            
            丟丈丁世与丑丟丛丑 val_7 = this.丙丕丏丅丗丏丝上不.Item[丅且三万丘丙业丙丗];
            if((val_7.丑一丈丅丆丂丙丙丐.ContainsKey(key:  丐东业丕丕丂丗丅丙)) == false)
            {
                goto label_16;
            }
            
            丟丈丁世与丑丟丛丑 val_9 = this.丙丕丏丅丗丏丝上不.Item[丅且三万丘丙业丙丗];
            if(val_9.丑一丈丅丆丂丙丙丐 != null)
            {
                goto label_19;
            }
            
            goto label_20;
            label_16:
            val_11 = 0;
            return (ChestProgressDataObject)val_11;
        }
        internal Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 业丗丏丂丝丕下且丛(int 丅且三万丘丙业丙丗, int 丐东业丕丕丂丗丅丙)
        {
            if((this.万丆丗丅一丌丅丑丏.ContainsKey(key:  丅且三万丘丙业丙丗)) != false)
            {
                    丙下且专一丒丂专七 val_2 = this.万丆丗丅一丌丅丑丏.Item[丅且三万丘丙业丙丗];
                if((val_2.丑一丈丅丆丂丙丙丐.ContainsKey(key:  丐东业丕丕丂丗丅丙)) != false)
            {
                    丙下且专一丒丂专七 val_4 = this.万丆丗丅一丌丅丑丏.Item[丅且三万丘丙业丙丗];
                ChestProgressDataObject val_5 = val_4.丑一丈丅丆丂丙丙丐.Item[丐东业丕丕丂丗丅丙];
                if(val_5 != null)
            {
                    return val_5.不上丄与丁不丌丕丕();
            }
            
                return val_5.不上丄与丁不丌丕丕();
            }
            
            }
            
            if((this.丙丕丏丅丗丏丝上不.ContainsKey(key:  丅且三万丘丙业丙丗)) == false)
            {
                    return 0;
            }
            
            丟丈丁世与丑丟丛丑 val_7 = this.丙丕丏丅丗丏丝上不.Item[丅且三万丘丙业丙丗];
            if((val_7.丑一丈丅丆丂丙丙丐.ContainsKey(key:  丐东业丕丕丂丗丅丙)) == false)
            {
                    return 0;
            }
            
            丟丈丁世与丑丟丛丑 val_9 = this.丙丕丏丅丗丏丝上不.Item[丅且三万丘丙业丙丗];
            ChestProgressDataObject val_10 = val_9.丑一丈丅丆丂丙丙丐.Item[丐东业丕丕丂丗丅丙];
            if(val_10 != null)
            {
                    return val_10.丒丟丗丏与丒七与丙();
            }
            
            return val_10.丒丟丗丏与丒七与丙();
        }
        internal System.Collections.Generic.Dictionary<string, object> 丄丈丕丙丒丈七不三(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
            int val_57;
            System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七> val_58;
            var val_59;
            System.Collections.Generic.Dictionary<System.Int32, ChestProgressDataObject> val_60;
            int val_61;
            var val_62;
            int val_63;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_64;
            var val_65;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = 上专业三丟丁丞专下.ChestProgressDataObject.丘上上丗丝丂丄世七(与世丗且丟丁不专丏:  丅东专与不三丂丁丝.不业丙丒丂丞下丆丙(), 上丕专上且上丕万丘:  this.丄丟丒丁丙三丞丗丒(丅且三万丘丙业丙丗:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒(), 丐东业丕丕丂丗丅丙:  丐下丝丘丑丟丟丗丌.业上丙丞丐丄丆丅七()), 丕与丑七与万丄丂丂:  丐下丝丘丑丟丟丗丌.丐丄一世丅丐三丆东());
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
            val_7.Add(item:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒().ToString());
            val_7.Add(item:  丐下丝丘丑丟丟丗丌.业上丙丞丐丄丆丅七().ToString());
            string val_12 = 丅东专与不三丂丁丝.业上丙丞丐丄丆丅七();
            int val_13 = val_12.业丂丁丐丂丞丗不丘(丅且丐丄世不丙一丕:  val_12);
            if(丅东专与不三丂丁丝.不业丙丒丂丞下丆丙() != 100)
            {
                goto label_12;
            }
            
            val_7.Add(item:  "c");
            if((this.万丆丗丅一丌丅丑丏.ContainsKey(key:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒())) != true)
            {
                    this.万丆丗丅一丌丅丑丏.set_Item(key:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒(), value:  new 丙下且专一丒丂专七());
            }
            
            丙下且专一丒丂专七 val_20 = this.万丆丗丅一丌丅丑丏.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            val_57 = val_20.丆万一不丌且东丐丐;
            丙下且专一丒丂专七 val_22 = this.万丆丗丅一丌丅丑丏.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            if(丅东专与不三丂丁丝 == null)
            {
                goto label_24;
            }
            
            val_58 = this.万丆丗丅一丌丅丑丏;
            val_59 = 丅东专与不三丂丁丝.丂世上东丞且丏丝丗();
            goto label_25;
            label_12:
            val_7.Add(item:  "r");
            if((this.丙丕丏丅丗丏丝上不.ContainsKey(key:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒())) != true)
            {
                    this.丙丕丏丅丗丏丝上不.set_Item(key:  丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒(), value:  new 丟丈丁世与丑丟丛丑());
            }
            
            丟丈丁世与丑丟丛丑 val_29 = this.丙丕丏丅丗丏丝上不.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            val_57 = val_29.丆万一不丌且东丐丐;
            丟丈丁世与丑丟丛丑 val_31 = this.丙丕丏丅丗丏丝上不.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            val_60 = val_31.丑一丈丅丆丂丙丙丐;
            if(丐下丝丘丑丟丟丗丌 == null)
            {
                goto label_37;
            }
            
            val_61 = 丐下丝丘丑丟丟丗丌.业上丙丞丐丄丆丅七();
            goto label_38;
            label_24:
            val_58 = this.万丆丗丅一丌丅丑丏;
            val_59 = 丅东专与不三丂丁丝.丂世上东丞且丏丝丗();
            label_25:
            var val_34 = (val_22.丕丗专且丆丂丌丕丒 != val_59) ? 1 : 0;
            丙下且专一丒丂专七 val_36 = val_58.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            if(丐下丝丘丑丟丟丗丌 == null)
            {
                goto label_41;
            }
            
            val_63 = 丐下丝丘丑丟丟丗丌.业上丙丞丐丄丆丅七();
            goto label_42;
            label_37:
            val_61 = 0.业上丙丞丐丄丆丅七();
            label_38:
            val_60.set_Item(key:  val_61, value:  丐下丝丘丑丟丟丗丌.丐丄一世丅丐三丆东().丒丟丗丏与丒七与丙());
            val_64 = val_6;
            val_65 = this.丙丕丏丅丗丏丝上不.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            val_62 = 0;
            goto label_57;
            label_41:
            val_63 = 0.业上丙丞丐丄丆丅七();
            label_42:
            val_36.丑一丈丅丆丂丙丙丐.set_Item(key:  val_63, value:  丐下丝丘丑丟丟丗丌.丐丄一世丅丐三丆东().不上丄与丁不丌丕丕());
            val_64 = val_6;
            丙下且专一丒丂专七 val_47 = this.万丆丗丅一丌丅丑丏.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            val_60 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_49 = 丅东专与不三丂丁丝.丂世上东丞且丏丝丗();
            val_47.丕丗专且丆丂丌丕丒 = 0;
            mem2[0] = 0;
            val_65 = this.万丆丗丅一丌丅丑丏.Item[丅东专与不三丂丁丝.丅丙丛丑丌丆丌丕丒()];
            label_57:
            val_51.丆万一不丌且东丐丐 = val_13;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_52 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_52.Add(key:  "i", value:  System.String.Join(separator:  "|", value:  val_7.ToArray()));
            if(val_57 != val_13)
            {
                goto label_60;
            }
            
            if(val_34 != 0)
            {
                goto label_61;
            }
            
            label_66:
            label_70:
            if(val_64.Count < 1)
            {
                    return val_52;
            }
            
            val_52.Add(key:  "p", value:  val_64);
            return val_52;
            label_60:
            val_52.Add(key:  "t", value:  val_13);
            if(val_34 == 0)
            {
                goto label_66;
            }
            
            label_61:
            val_52.Add(key:  "s", value:  丅东专与不三丂丁丝.丂世上东丞且丏丝丗());
            if(val_64 != 0)
            {
                goto label_70;
            }
            
            goto label_70;
        }
        internal bool 丘丁丂丘三丒丙丈丄(Rilisoft.GameEventType 且下丕七丙丗丄不七, int 丂不世丒世丕丁丝与)
        {
            System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七> val_3;
            System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七> val_4;
            var val_5;
            val_3 = 且下丕七丙丗丄不七;
            if((val_3 != 300) && (val_3 != 200))
            {
                    if(val_3 != 100)
            {
                    return false;
            }
            
                val_3 = this.万丆丗丅一丌丅丑丏;
                if((val_3.ContainsKey(key:  丂不世丒世丕丁丝与)) == false)
            {
                    return false;
            }
            
                val_4 = this.万丆丗丅一丌丅丑丏;
                val_5 = 1152921541240604912;
                return val_4.Remove(key:  丂不世丒世丕丁丝与);
            }
            
            val_3 = this.丙丕丏丅丗丏丝上不;
            if((val_3.ContainsKey(key:  丂不世丒世丕丁丝与)) == false)
            {
                    return false;
            }
            
            val_4 = this.丙丕丏丅丗丏丝上不;
            val_5 = 1152921541240614128;
            return val_4.Remove(key:  丂不世丒世丕丁丝与);
        }
        internal int 业丂丁丐丂丞丗不丘(string 丅且丐丄世不丙一丕)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万.ContainsKey(key:  丅且丐丄世不丙一丕)) != false)
            {
                    val_4 = null;
                val_4 = null;
                if(Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万 != null)
            {
                    return Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万.Item[丅且丐丄世不丙一丕];
            }
            
                return Rilisoft.三一丈七且丄与丝东.丕丟丐丅丑丏丟丕万.Item[丅且丐丄世不丙一丕];
            }
            
            UnityEngine.Debug.LogError(message:  "Event Short ID ERROR! EventIdToShortId does not contains key: \'"("Event Short ID ERROR! EventIdToShortId does not contains key: \'") + 丅且丐丄世不丙一丕 + "\'");
            return 0;
        }
        internal string 丌专丒不丝不世与万(int 丈丂下丝丕丞与七世)
        {
            int val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = 丈丂下丝丕丞与七世;
            val_5 = null;
            val_5 = null;
            if((Rilisoft.三一丈七且丄与丝东.丘丟七不且业一世上.ContainsKey(key:  val_4)) != false)
            {
                    val_6 = null;
                val_6 = null;
                string val_2 = Rilisoft.三一丈七且丄与丝东.丘丟七不且业一世上.Item[val_4];
                return (string)val_7;
            }
            
            val_4 = System.String.Format(format:  "Event Long ID ERROR! EventShortIdToId does not contains key: \'{0}\'", arg0:  val_4);
            UnityEngine.Debug.LogError(message:  val_4);
            val_7 = "";
            return (string)val_7;
        }
        internal bool 丁丒世上不专不丗丞(string 丟丟丄专上丟丁丐丝)
        {
            int val_1 = this.业丂丁丐丂丞丗不丘(丅且丐丄世不丙一丕:  丟丟丄专上丟丁丐丝);
            if((val_1 & 2147483648) != 0)
            {
                    return false;
            }
            
            if(this.丑丑丘丅丝丄丈丘东 != null)
            {
                    return this.丑丑丘丅丝丄丈丘东.ContainsKey(key:  val_1);
            }
            
            return this.丑丑丘丅丝丄丈丘东.ContainsKey(key:  val_1);
        }
        internal int 三业丈世丐丒丐丒丅(string 丟丟丄专上丟丁丐丝)
        {
            System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且> val_4;
            var val_5;
            val_4 = this;
            int val_1 = this.业丂丁丐丂丞丗不丘(丅且丐丄世不丙一丕:  丟丟丄专上丟丁丐丝);
            if((val_1 & 2147483648) == 0)
            {
                    if((this.丑丑丘丅丝丄丈丘东.ContainsKey(key:  val_1)) != false)
            {
                    val_4 = this.丑丑丘丅丝丄丈丘东;
                Rilisoft.丝丑丂丛万丐丈丘且 val_3 = val_4.Item[val_1];
                val_5;
                return (int)val_5;
            }
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        internal bool 业七业丄业丟丄下一(int 丙业与丙丗丝不丈东, string 丟丟丄专上丟丁丐丝)
        {
            var val_4;
            int val_5;
            var val_6;
            val_4 = 丙业与丙丗丝不丈东;
            val_5 = this.业丂丁丐丂丞丗不丘(丅且丐丄世不丙一丕:  丟丟丄专上丟丁丐丝);
            if((val_5 & 2147483648) == 0)
            {
                    val_4 = val_4 & (~(val_4 >> 31));
                int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                this.丑丑丘丅丝丄丈丘东.set_Item(key:  val_5, value:  new Rilisoft.丝丑丂丛万丐丈丘且());
                val_6 = 1;
                return (bool)val_6;
            }
            
            val_5 = "SetEventCurrency ERROR! eventId: "("SetEventCurrency ERROR! eventId: ") + 丟丟丄专上丟丁丐丝;
            UnityEngine.Debug.LogError(message:  val_5);
            val_6 = 0;
            return (bool)val_6;
        }
        internal bool 下三丕丒专丐丄不丈(string 丟丟丄专上丟丁丐丝)
        {
            System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且> val_4;
            var val_5;
            int val_1 = this.业丂丁丐丂丞丗不丘(丅且丐丄世不丙一丕:  丟丟丄专上丟丁丐丝);
            if((val_1 & 2147483648) == 0)
            {
                    val_4 = this.丑丑丘丅丝丄丈丘东;
                bool val_2 = val_4.Remove(key:  val_1);
                val_5 = 1;
                return (bool)val_5;
            }
            
            val_4 = "RemoveEventCurrency ERROR! eventId: "("RemoveEventCurrency ERROR! eventId: ") + 丟丟丄专上丟丁丐丝;
            UnityEngine.Debug.LogError(message:  val_4);
            val_5 = 0;
            return (bool)val_5;
        }
        private System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且> 东丁丁世上与丆丑丟(object 万且万且丑丗且丌丆)
        {
            var val_9;
            System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且> val_1 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>();
            if(万且万且丑丗且丌丆 != null)
            {
                    val_9 = null;
                val_9 = null;
                var val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_9) ? 万且万且丑丗且丌丆 : 0;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = 0.GetEnumerator();
            label_10:
            if(((-2019971960) & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            int val_7 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            int val_8 = System.Convert.ToInt32(value:  val_4._value._obj);
            val_1.Add(key:  System.Int32.Parse(s:  val_4._value._obj.丐丏七丌丕丗业且上()), value:  new Rilisoft.丝丑丂丛万丐丈丘且());
            goto label_10;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private System.Collections.Generic.Dictionary<int, int> 一丌丆业丄不丆与不(System.Collections.Generic.Dictionary<int, Rilisoft.丝丑丂丛万丐丈丘且> 丑丑丘丅丝丄丈丘东)
        {
            var val_4;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_6;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_8;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            val_4 = null;
            val_4 = null;
            val_6 = 丕丞七世丒丐下七一.<>c.<>9__36_0;
            if(val_6 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_2 = null;
                val_6 = val_2;
                val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕丞七世丒丐下七一.<>c::业丗万丅丁上万专丕(System.Collections.Generic.KeyValuePair<int, Rilisoft.丝丑丂丛万丐丈丘且> 三丟东丕丄丄下下丑));
                val_4 = null;
                丕丞七世丒丐下七一.<>c.<>9__36_0 = val_6;
            }
            
            val_4 = null;
            val_8 = 丕丞七世丒丐下七一.<>c.<>9__36_1;
            if(val_8 != null)
            {
                    return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32, System.Int32>(source:  丑丑丘丅丝丄丈丘东, keySelector:  val_2, elementSelector:  System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32> val_3 = null);
            }
            
            val_8 = val_3;
            val_3 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32>(object:  丕丞七世丒丐下七一.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丕丞七世丒丐下七一.<>c::丂丝世世一丕丒丟丕(System.Collections.Generic.KeyValuePair<int, Rilisoft.丝丑丂丛万丐丈丘且> 三丟东丕丄丄下下丑));
            丕丞七世丒丐下七一.<>c.<>9__36_1 = val_8;
            return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>, System.Int32, System.Int32>(source:  丑丑丘丅丝丄丈丘东, keySelector:  val_2, elementSelector:  val_3);
        }
        public 丕丞七世丒丐下七一()
        {
            this.丑丑丘丅丝丄丈丘东 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.丝丑丂丛万丐丈丘且>();
            this.丘丘下丟丙不丂三丘 = new System.Collections.Generic.List<FreeSpin>();
            this.万丆丗丅一丌丅丑丏 = new System.Collections.Generic.Dictionary<System.Int32, 丙下且专一丒丂专七>();
            this.丙丕丏丅丗丏丝上不 = new System.Collections.Generic.Dictionary<System.Int32, 丟丈丁世与丑丟丛丑>();
        }
        private static 丕丞七世丒丐下七一()
        {
            Progress.丕丞七世丒丐下七一.丕丟一七丑丙丂丆丙 = "game_events_slot";
            Progress.丕丞七世丒丐下七一.丐丌丞上世丛丐丏丛 = "game_events_slot_Key";
            System.Collections.Generic.Dictionary<System.Int32, Rilisoft.GameEventType> val_1 = new System.Collections.Generic.Dictionary<System.Int32, Rilisoft.GameEventType>();
            if(val_1 != null)
            {
                    val_1.Add(key:  100, value:  100);
                val_1.Add(key:  101, value:  200);
            }
            else
            {
                    val_1.Add(key:  100, value:  100);
                val_1.Add(key:  101, value:  200);
            }
            
            val_1.Add(key:  102, value:  44);
            Progress.丕丞七世丒丐下七一.不一上丈丒丑与丛三 = val_1;
        }
    
    }

}
