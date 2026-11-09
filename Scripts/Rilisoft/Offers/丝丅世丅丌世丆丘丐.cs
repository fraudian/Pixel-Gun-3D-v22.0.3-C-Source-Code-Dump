using UnityEngine;

namespace Rilisoft.Offers
{
    internal abstract class 丝丅世丅丌世丆丘丐 : 丑丝上世丄丂丛丛丕, IDisposable
    {
        // Fields
        private System.Collections.Generic.Dictionary<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule, System.Collections.Generic.List<Rilisoft.七丈业与与不七丈丟>> 丐下丛不丟丆万丁下;
        private System.Collections.Generic.Dictionary<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule, Rilisoft.Offers.丌且丐丅丗七万丆丙> 丂业丗三丂三丟丕丕;
        private System.Collections.Generic.Dictionary<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule, System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>> 且丑不丛丏丏丐丄丐;
        private readonly System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄.OfferModule> 丟丆丟专丞东与丄丗;
        
        // Properties
        public abstract int 业不一丒丁专丝丛丑 { get; }
        public abstract Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丗丑不丁丐丄丑丑东 { get; }
        public bool 七七世丅东丈丛丞丕 { get; }
        protected abstract string 与丝丏业丞丙上丝万 { get; }
        
        // Methods
        public abstract int 丕丞世一丟丞丞丗丐(); // 0
        public abstract Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 与丝丅丘且丐上丅世(); // 0
        public bool 丁世东三丂丒不七丆()
        {
            return true;
        }
        protected abstract string 七丕丈东丈丛且丞丘(); // 0
        public Rilisoft.业丙丘丆东丈丕丂丄 丐上丙世丂丅丝不丈()
        {
            OfferModule val_4;
            var val_5;
            val_4 = this;
            if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  this)) != false)
            {
                    val_4 = val_4;
                Rilisoft.Offers.丌且丐丅丗七万丆丙 val_2 = this.丂业丗三丂三丟丕丕.Item[this];
                if(val_2 == null)
            {
                    return (Rilisoft.业丙丘丆东丈丕丂丄)val_5;
            }
            
                if(val_2 == null)
            {
                    return (Rilisoft.业丙丘丆东丈丕丂丄)val_5;
            }
            
                Rilisoft.业丙丘丆东丈丕丂丄 val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_2);
                return (Rilisoft.业丙丘丆东丈丕丂丄)val_5;
            }
            
            val_5 = 0;
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_5;
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 丙丈丈东丟丟丒丄三()
        {
            OfferModule val_8 = this;
            if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  this)) == false)
            {
                    return 0;
            }
            
            val_8 = val_8;
            if(this.丂业丗三丂三丟丕丕.Item[this] == null)
            {
                    return 0;
            }
            
            val_8 = ???;
            goto typeof(Rilisoft.Offers.丌且丐丅丗七万丆丙).__il2cppRuntimeField_168;
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 丅世业丂丝丁丌七丗(string 业丒丌东丈丏丈一不)
        {
            string val_5 = 业丒丌东丈丏丈一不;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5 = 业丒丌东丈丏丈一不)) != false)
            {
                    return 0;
            }
            
            int val_2 = val_5.LastIndexOf(value:  '-');
            if((val_2 & 2147483648) != 0)
            {
                    return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5 = val_5.Substring(startIndex:  val_2 + 1));
            }
            
            return this.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_5);
        }
        public Rilisoft.业丙丘丆东丈丕丂丄 上丑下专丄下丟丏丆(string 丗丟丁丐与下丙丕丛)
        {
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_6;
            object val_7;
            var val_8;
            val_6 = this;
            丝丅世丅丌世丆丘丐.丗丛丘丑丐不丌丑丙 val_1 = null;
            val_7 = val_1;
            val_1 = new 丝丅世丅丌世丆丘丐.丗丛丘丑丐不丌丑丙();
            .丗丟丁丐与下丙丕丛 = 丗丟丁丐与下丙丕丛;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            label_7:
            if((519577048 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj == 0)
            {
                goto label_7;
            }
            
            val_6 = (丝丅世丅丌世丆丘丐.丗丛丘丑丐不丌丑丙)[1152921543781177920].上丌丘丑一且丆且丏;
            if(val_6 == null)
            {
                    val_6 = null;
                val_6 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  val_1, method:  System.Boolean 丝丅世丅丌世丆丘丐.丗丛丘丑丐不丌丑丙::万上下上与丅专丑丗(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
                .上丌丘丑一且丆且丏 = val_6;
            }
            
            val_8 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_3._value._obj, predicate:  null);
            if(val_8 == null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_3:
            val_8 = 0;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.业丙丘丆东丈丕丂丄)val_8;
        }
        public System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 东东丛一丄丅丌丗且()
        {
            OfferModule val_3;
            var val_4;
            val_3 = this;
            if((this.且丑不丛丏丏丐丄丐.ContainsKey(key:  this)) != false)
            {
                    val_3 = val_3;
                System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> val_2 = this.且丑不丛丏丏丐丄丐.Item[this];
                return (System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>)val_4;
            }
            
            val_4 = 0;
            return (System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>)val_4;
        }
        public void 丁东丐丄丞丌丘业上()
        {
            var val_4;
            var val_10;
            var val_11;
            var val_12;
            var val_15;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            val_10 = 0;
            val_11 = 0;
            var val_10 = 0;
            label_15:
            if((519869648 & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(val_5._value._obj == 0)
            {
                goto label_15;
            }
            
            List.Enumerator<T> val_6 = val_5._value._obj.GetEnumerator();
            label_7:
            if((519869600 & 1) == 0)
            {
                goto label_5;
            }
            
            val_4.丐丏七丌丕丗业且上().丁东丐丄丞丌丘业上();
            goto label_7;
            label_5:
            val_10 = val_10 + 1;
            mem2[0] = 83;
            val_12 = val_11;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_10 == 1) || ((1152921543781422128 + ((0 + 1)) << 2) != 83))
            {
                goto label_12;
            }
            
            var val_11 = 0;
            val_11 = val_11 ^ (val_10 >> 31);
            val_10 = val_10 + val_11;
            goto label_15;
            label_12:
            if( == 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_2:
            val_15 = val_10 + 1;
            mem2[0] = 108;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_15 != 1) && ((1152921543781422128 + ((0 + 1)) << 2) == 108))
            {
                    var val_12 = 0;
                val_12 = val_12 ^ (val_15 >> 31);
                val_15 = val_15 + val_12;
            }
            else
            {
                    if( != 0)
            {
                    val_11 = 0;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_8 = this.丂业丗三丂三丟丕丕.GetEnumerator();
            label_30:
            if((519869560 & 1) == 0)
            {
                goto label_27;
            }
            
            ConfiguredValueTaskAwaiter val_9 = 0.GetAwaiter();
            if(val_9._value._obj == 0)
            {
                goto label_30;
            }
            
            if(val_9._value._obj != 0)
            {
                goto label_30;
            }
            
            goto label_30;
            label_27:
            val_15 = val_15 + 1;
            mem2[0] = 177;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_15 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921543781422128 + (((0 + 1) + 1)) << 2) == 177)
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
        public void 丁丆丕丏东丟丐丄丂()
        {
            this.丁东丐丄丞丌丘业上();
        }
        public bool 且丟丌丑丘丕七专三()
        {
            OfferModule val_4;
            OfferModule val_5;
            var val_6;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_8;
            val_4 = this;
            val_5 = val_4;
            if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  this)) == false)
            {
                    return false;
            }
            
            val_4 = val_4;
            Rilisoft.Offers.丌且丐丅丗七万丆丙 val_2 = this.丂业丗三丂三丟丕丕.Item[this];
            if(val_2 == null)
            {
                    return false;
            }
            
            val_4 = val_2;
            if(val_4 == null)
            {
                    return false;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = 丝丅世丅丌世丆丘丐.<>c.<>9__15_0;
            if(val_8 != null)
            {
                    return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_4, predicate:  System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_3 = null);
            }
            
            val_8 = val_3;
            val_3 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  丝丅世丅丌世丆丘丐.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丝丅世丅丌世丆丘丐.<>c::下丙与丂丅万不丌不(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
            丝丅世丅丌世丆丘丐.<>c.<>9__15_0 = val_8;
            return System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_4, predicate:  val_3);
        }
        public void 且丛丕业丞万东七丒(bool 丆丄丘丂业丛七丁且 = False)
        {
            System.Object[] val_5;
            object[] val_1 = new object[2];
            val_5 = val_1;
            val_5[0] = this;
            val_5[1] = 丆丄丘丂业丛七丁且;
            UnityEngine.Debug.LogFormat(format:  "[UPDATE MODULE] type:\'{0}\', hard:\'{1}\'", args:  val_1);
            if(丆丄丘丂业丛七丁且 != false)
            {
                    val_5 = this;
                if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  this)) != false)
            {
                    val_5 = this;
                Rilisoft.Offers.丌且丐丅丗七万丆丙 val_4 = this.丂业丗三丂三丟丕丕.Item[this];
            }
            
            }
            
            this.丝东与丆丄丏丑一丘(世七七丟丑丁丂与丞:  this, 世丏丈不丗一丈七丐:  false);
        }
        public void 丑七丂丌世与七丏与(string 丅业丙丞且丐一丙丆)
        {
            string val_29;
            System.Object[] val_30;
            Progress.OfferProgress val_34;
            val_29 = 丅业丙丞且丐一丙丆;
            丝丅世丅丌世丆丘丐.三丅丞丒丕丅专一丅 val_1 = null;
            val_30 = val_1;
            val_1 = new 丝丅世丅丌世丆丘丐.三丅丞丒丕丅专一丅();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_29)) != true)
            {
                    object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_29);
                object[] val_4 = new object[1];
                val_30 = val_4;
                val_29 = this;
                val_30[0] = val_29;
                UnityEngine.Debug.LogErrorFormat(format:  "parse offers config fail: \'{0}\'", args:  val_4);
            }
            
            this.丆上专世下丒七丄业();
            return;
            label_42:
            if((520549440 & 1) == 0)
            {
                goto label_30;
            }
            
            new 丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专() = new System.Object();
            .丝丈丌万丁不丌丌丌 = 0.丐丏七丌丕丗业且上();
            val_34 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丈丒且丗七丗丄下丐(丗丟丁丐与下丙丕丛:  (丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专)[1152921543782199472].丝丈丌万丁不丌丌丌.下丄丈不与世丐业专);
            if(val_34 == null)
            {
                    val_34 = new Progress.OfferProgress();
                val_34 = new Progress.OfferProgress();
                .Id = (丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专)[1152921543782199472].丝丈丌万丁不丌丌丌.下丄丈不与世丐业专;
            }
            
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_19 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  new 丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专(), method:  System.Boolean 丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专::丘丌丂丗丁业业上下(Rilisoft.业丙丘丆东丈丕丂丄 七丏丄丅丌业与且丙));
            Rilisoft.业丙丘丆东丈丕丂丄 val_20 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.业丙丘丆东丈丕丂丄>(source:  null, predicate:  null);
            if(val_20 == null)
            {
                goto label_39;
            }
            
            Rilisoft.业丙丘丆东丈丕丂丄 val_21 = val_20.丅专下万丕丑丆丅丝(丕上业丕丘上丘七一:  this, 一丐丗丁丞丆丅丟丄:  (丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专)[1152921543782199472].丝丈丌万丁不丌丌丌, 上丕丈丞丌丘丅不与:  new Progress.OfferProgress(), 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false}, 东一丁世丑丞业丄丐:  0);
            goto label_42;
            label_39:
            new Rilisoft.业丙丘丆东丈丕丂丄() = new Rilisoft.业丙丘丆东丈丕丂丄(丁丅丈丌丟世丗丗丟:  this, 一丐丗丁丞丆丅丟丄:  (丝丅世丅丌世丆丘丐.丐丟三丐丈丙且且专)[1152921543782199472].丝丈丌万丁不丌丌丌, 上丕丈丞丌丘丅不与:  new Progress.OfferProgress(), 丑丒丛与下专且丗不:  new System.Nullable<AdaptiveModuleType>() {HasValue = false}, 东一丁世丑丞业丄丐:  0);
            Add(item:  new Rilisoft.业丙丘丆东丈丕丂丄());
            goto label_42;
            label_30:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_26 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  null, predicate:  new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  val_1, method:  System.Boolean 丝丅世丅丌世丆丘丐.三丅丞丒丕丅专一丅::丘专丈丁丝丂丘丈丁(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)))).GetEnumerator();
            label_65:
            if((520549416 & 1) == 0)
            {
                goto label_62;
            }
            
            bool val_28 = Remove(item:  0.丐丏七丌丕丗业且上());
            goto label_65;
            label_62:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public abstract void 丟一丏与丈丅丗丅丈(); // 0
        private void 丆上专世下丒七丄业()
        {
            OfferModule val_7;
            Rilisoft.Offers.专下丞一丕下下丗与.不丄丌丞丟丟丙万业(丕上业丕丘上丘七一:  this);
            if((this.且丑不丛丏丏丐丄丐.ContainsKey(key:  this)) != false)
            {
                    if(this.且丑不丛丏丏丐丄丐.Item[this] != null)
            {
                    this.且丑不丛丏丏丐丄丐.Item[this].Clear();
            }
            
            }
            
            val_7 = this;
            if((this.丐下丛不丟丆万丁下.ContainsKey(key:  this)) == false)
            {
                    return;
            }
            
            val_7 = this;
            if(this.丐下丛不丟丆万丁下.Item[this] == null)
            {
                    return;
            }
            
            this.丐下丛不丟丆万丁下.Item[this].Clear();
        }
        internal 丝丅世丅丌世丆丘丐()
        {
            this.丐下丛不丟丆万丁下 = new System.Collections.Generic.Dictionary<OfferModule, System.Collections.Generic.List<Rilisoft.七丈业与与不七丈丟>>();
            this.丂业丗三丂三丟丕丕 = new System.Collections.Generic.Dictionary<OfferModule, Rilisoft.Offers.丌且丐丅丗七万丆丙>();
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.Dictionary<OfferModule, System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>>();
            System.Collections.Generic.List<OfferModule> val_4 = new System.Collections.Generic.List<OfferModule>();
            if(val_4 != null)
            {
                    val_4.Add(item:  40);
            }
            else
            {
                    val_4.Add(item:  40);
            }
            
            val_4.Add(item:  10);
            this.丟丆丟专丞东与丄丗 = val_4;
        }
        protected void 丏丝丈丄丈丕一业丅(Rilisoft.Offers.丌且丐丅丗七万丆丙 三丆丝丏丒丆且万上, Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丈丏丘上丟且与丂丄)
        {
            System.Object[] val_4;
            string val_5;
            if(三丆丝丏丒丆且万上 == null)
            {
                goto label_1;
            }
            
            if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  丈丏丘上丟且与丂丄)) == false)
            {
                goto label_3;
            }
            
            val_4 = new object[1];
            val_4[0] = 丈丏丘上丟且与丂丄;
            val_5 = "injector with type \'{0}\' allready registered";
            goto label_10;
            label_1:
            object[] val_3 = new object[1];
            val_4 = val_3;
            val_4[0] = 丈丏丘上丟且与丂丄;
            val_5 = "injector cant be nullable";
            label_10:
            UnityEngine.Debug.LogErrorFormat(format:  val_5, args:  val_3);
            return;
            label_3:
            this.丂业丗三丂三丟丕丕.Add(key:  丈丏丘上丟且与丂丄, value:  三丆丝丏丒丆且万上);
        }
        private void 丝东与丆丄丏丑一丘(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞, bool 世丏丈不丗一丈七丐 = False)
        {
            System.Collections.Generic.List<OfferModule> val_13;
            var val_14;
            val_13 = 世丏丈不丗一丈七丐;
            val_14 = this;
            if(val_13 != true)
            {
                    val_13 = this.丟丆丟专丞东与丄丗;
                if((val_13.Contains(item:  世七七丟丑丁丂与丞)) != false)
            {
                    val_13 = this.丟丆丟专丞东与丄丗;
                int val_2 = val_13.IndexOf(item:  世七七丟丑丁丂与丞);
                if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
                do
            {
                Rilisoft.Offers.丌且丐丅丗七万丆丙 val_4 = this.专七不七丗丕世丕与(世七七丟丑丁丂与丞:  this.丟丆丟专丞东与丄丗.Item[0]);
                val_13 = 0 + 1;
            }
            while(val_13 <= val_2);
            
                return;
            }
            
            }
            
            if((this.专七不七丗丕世丕与(世七七丟丑丁丂与丞:  世七七丟丑丁丂与丞)) == null)
            {
                    return;
            }
            
            val_14 = ???;
            val_13 = ???;
            goto typeof(Rilisoft.Offers.丌且丐丅丗七万丆丙).__il2cppRuntimeField_178;
        }
        protected Rilisoft.Offers.丌且丐丅丗七万丆丙 专七不七丗丕世丕与(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞)
        {
            var val_3;
            if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  世七七丟丑丁丂与丞)) != false)
            {
                    Rilisoft.Offers.丌且丐丅丗七万丆丙 val_2 = this.丂业丗三丂三丟丕丕.Item[世七七丟丑丁丂与丞];
                return (Rilisoft.Offers.丌且丐丅丗七万丆丙)val_3;
            }
            
            val_3 = 0;
            return (Rilisoft.Offers.丌且丐丅丗七万丆丙)val_3;
        }
        protected T 专七不七丗丕世丕与<T>(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 世七七丟丑丁丂与丞)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = __RuntimeMethodHiddenParam;
            val_5 = this;
            if((this.丂业丗三丂三丟丕丕.ContainsKey(key:  世七七丟丑丁丂与丞)) != false)
            {
                    val_5 = this.丂业丗三丂三丟丕丕.Item[世七七丟丑丁丂与丞];
                val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
                if(val_5 != null)
            {
                    val_6 = val_5;
                if(val_6 != null)
            {
                    return (object)val_6;
            }
            
            }
            
            }
            
            val_6 = 0;
            return (object)val_6;
        }
        private bool 丏丑万丅丄丁丅丟不(System.Collections.Generic.Dictionary<string, object> 丐丂丕万丟业丐丛丅, string 丁一上上不丆上世丘, out System.Collections.Generic.List<Rilisoft.七丈业与与不七丈丟> 东且丁丆丛丁丏丘且)
        {
            var val_6;
            东且丁丆丛丁丏丘且 = new System.Collections.Generic.List<Rilisoft.七丈业与与不七丈丟>();
            if((丐丂丕万丟业丐丛丅.ContainsKey(key:  丁一上上不丆上世丘)) != false)
            {
                    object val_3 = 丐丂丕万丟业丐丛丅.Item[丁一上上不丆上世丘];
                UnityEngine.Debug.LogError(message:  "parse offers config fail: unknown format");
            }
            
            return false;
            label_25:
            if((521806160 & 1) == 0)
            {
                goto label_9;
            }
            
            object[] val_8 = new object[1];
            val_8[0] = val_6.丐丏七丌丕丗业且上();
            UnityEngine.Debug.LogErrorFormat(format:  "parse offers config fail: unknown offer format \'{0}\'", args:  val_8);
            goto label_25;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return false;
        }
        internal static Rilisoft.七丈业与与不七丈丟 丑丅丈丏丈丐且丂一(System.Collections.Generic.Dictionary<string, object> 丝丆不丟业丕东一不)
        {
            var val_30;
            string val_43;
            object val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            System.Collections.Generic.List<丂七丄不专下丘丂丟> val_50;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_43 = 丝丆不丟业丕东一不;
            if(val_43 == null)
            {
                    return 0;
            }
            
            Rilisoft.七丈业与与不七丈丟 val_1 = new Rilisoft.七丈业与与不七丈丟();
            if((val_43.ContainsKey(key:  "id")) == false)
            {
                goto label_2;
            }
            
            .下丄丈不与世丐业专 = val_43.Item["id"];
            if((val_43.ContainsKey(key:  "order")) != false)
            {
                    bool val_7 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_43.Item["order"], 丙业与丙丗丝不丈东: out  (Rilisoft.七丈业与与不七丈丟)[1152921543783647232].世不丑丙丞丘丘丙丈);
            }
            
            if((val_43.ContainsKey(key:  "lifeTime")) == false)
            {
                goto label_9;
            }
            
            val_43 = val_43.Item["lifeTime"];
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_43, 丙业与丙丗丝不丈东: out  0)) == false)
            {
                goto label_13;
            }
            
            .且与丙丑丕专七丈专 = 0;
            label_9:
            .丁丑丅丐丌不世丁下 = Rilisoft.Offers.丝丅世丅丌世丆丘丐.丌一丑丅丝丁业丞丏(三丁丕丒丕丒丌丆丞:  val_43);
            val_43 = "rewards";
            if((val_43.ContainsKey(key:  "rewards")) == false)
            {
                goto label_14;
            }
            
            val_43 = val_43.Item["rewards"];
            object[] val_15 = new object[1];
            val_15[0] = val_43.Item["rawRewards"];
            UnityEngine.Debug.LogErrorFormat(format:  "parse offers config fail: unknown rawRewards format \'{0}\'", args:  val_15);
            return 0;
            label_2:
            val_44 = "parse offers config fail: unknown offer id";
            goto label_30;
            label_14:
            val_44 = "parse offers config fail: rewards not exists";
            goto label_30;
            label_13:
            val_44 = "parse offers config fail: unknown offer lifeTime";
            label_30:
            UnityEngine.Debug.LogError(message:  val_44);
            return 0;
            label_87:
            object val_22 = Item[0];
            if(val_22 == null)
            {
                goto label_55;
            }
            
            int val_24 = 0;
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_22.Item["id"], 丙业与丙丗丝不丈东: out  val_24)) == false)
            {
                goto label_55;
            }
            
            object val_26 = val_22.Item["inapps"];
            if(val_26 == null)
            {
                goto label_80;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.DataObjects.IntInterval> val_27 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.DataObjects.IntInterval>();
            Dictionary.Enumerator<TKey, TValue> val_28 = val_26.GetEnumerator();
            label_67:
            if((522046320 & 1) == 0)
            {
                goto label_59;
            }
            
            ConfiguredValueTaskAwaiter val_32 = val_30.GetAwaiter();
            int val_34 = 0;
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_32._value._obj.丐丏七丌丕丗业且上(), 丙业与丙丗丝不丈东: out  val_34)) == false)
            {
                goto label_67;
            }
            
            PGCompany.DataObjects.IntInterval val_36 = PGCompany.DataObjects.IntInterval.东丝七业丄丑丒世七(丞丕丒专一下丙业上:  val_32._value._obj);
            if(val_36 == null)
            {
                goto label_67;
            }
            
            val_46 = val_34;
            if(val_27 == 0)
            {
                    val_46 = val_46;
            }
            
            val_27.Add(key:  0, value:  val_36);
            goto label_67;
            label_59:
            val_47 = 0;
            val_48 = 0 + 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    var val_44 = 0;
                val_44 = val_44 ^ 0;
                val_49 =  + val_44;
            }
            else
            {
                    if( != 0)
            {
                    val_47 = 0;
            }
            
                val_49 = 0;
            }
            
            PGCompany.DataObjects.IntInterval val_38 = PGCompany.DataObjects.IntInterval.东丝七业丄丑丒世七(丞丕丒专一下丙业上:  val_22.Item["payment"]);
            if(val_38 != null)
            {
                    东下上东丅丂丘丗丙.丂七丄不专下丘丂丟 val_39 = new 东下上东丅丂丘丗丙.丂七丄不专下丘丂丟();
                if(val_39 != null)
            {
                    .丏丆丂丘丆世丘下丅 = val_27;
                .上七丛丝丏丌丅七且 = 0;
            }
            else
            {
                    mem[16] = val_27;
                mem[24] = val_24;
            }
            
                .一丞东丅一上丒万且 = val_38;
                val_50 = (Rilisoft.七丈业与与不七丈丟)[1152921543783647232].丆东丂丄丁丛丑与七;
                if(val_50 == null)
            {
                    System.Collections.Generic.List<丂七丄不专下丘丂丟> val_40 = null;
                val_50 = val_40;
                val_40 = new System.Collections.Generic.List<丂七丄不专下丘丂丟>();
                .丆东丂丄丁丛丑与七 = val_50;
            }
            
                val_40.Add(item:  val_39);
            }
            
            label_80:
            label_55:
            val_45 = 1;
            if(val_45 < Count)
            {
                goto label_87;
            }
            
            return 0;
        }
        internal static Rilisoft.七丈业与与不七丈丟.世丕三丙七丆丁丂丒 下丄专丈七不丘专三(System.Collections.Generic.Dictionary<string, object> 东丆丛丛东丅上丒丝)
        {
            object val_110;
            decimal val_111;
            string val_112;
            var val_113;
            string val_114;
            var val_115;
            var val_116;
            var val_117;
            System.Object[] val_118;
            string val_119;
            val_110 = 东丆丛丛东丅上丒丝;
            if(val_110 == null)
            {
                    return 0;
            }
            
            if(val_110.Count < 2)
            {
                    return 0;
            }
            
            七丈业与与不七丈丟.世丕三丙七丆丁丂丒 val_2 = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒();
            if((val_110.ContainsKey(key:  "price")) == false)
            {
                goto label_3;
            }
            
            object val_4 = val_110.Item["price"];
            int val_6 = 0;
            if((System.Int32.TryParse(s:  val_4, style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_6)) == false)
            {
                goto label_7;
            }
            
            val_111 = "Real";
            goto label_18;
            label_7:
            char[] val_8 = new char[1];
            val_8[0] = ':';
            val_112 = val_4.Split(separator:  val_8);
            if(val_9.Length != 2)
            {
                goto label_13;
            }
            
            if((System.String.op_Equality(a:  val_112[0], b:  "C")) == false)
            {
                goto label_14;
            }
            
            val_113 = null;
            val_113 = null;
            val_114 = 1152921505171281152;
            goto label_17;
            label_13:
            val_111 = 0;
            goto label_18;
            label_14:
            val_111 = 0;
            if((System.String.op_Equality(a:  val_112[0], b:  "G")) == false)
            {
                goto label_20;
            }
            
            val_115 = null;
            val_115 = null;
            val_114 = 1152921505171281160;
            label_17:
            label_20:
            val_112 = val_112[1];
            bool val_13 = System.Int32.TryParse(s:  val_112, style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_6);
            label_18:
            if(val_6 >= 1)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_114)) == false)
            {
                goto label_29;
            }
            
            }
            
            if(val_2 != null)
            {
                goto label_45;
            }
            
            label_46:
            label_45:
            .丒丆丕丁丟业上七丅 = 丈丞丕丘丕丗与上一.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_4);
            label_3:
            if((val_110.ContainsKey(key:  "sale")) == false)
            {
                goto label_44;
            }
            
            string val_19 = val_110.Item["sale"].Trim().ToLower();
            if((System.String.op_Equality(a:  val_19, b:  "auto")) == false)
            {
                goto label_37;
            }
            
            .丂世丙丗丁丝丝丛业 = 0m;
            mem[1152921543784146168] = 0;
            goto label_44;
            label_37:
            if((System.String.op_Equality(a:  val_19, b:  "none")) == false)
            {
                goto label_40;
            }
            
            val_116 = null;
            val_116 = null;
            .丂世丙丗丁丝丝丛业 = System.Decimal.MinusOne;
            mem[1152921543784146168] = System.Decimal.Powers10.__il2cppRuntimeField_30;
            goto label_44;
            label_29:
            丈丞丕丘丕丗与上一 val_22 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  val_114);
            if(val_2 != null)
            {
                goto label_45;
            }
            
            goto label_46;
            label_40:
            val_111 = (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丂世丙丗丁丝丝丛业;
            bool val_24 = System.Decimal.TryParse(s:  val_19, style:  32, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  new System.Decimal() {flags = val_111, hi = val_111, lo = val_111, mid = val_111});
            label_44:
            if((val_110.ContainsKey(key:  "armor")) != false)
            {
                    bool val_28 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["armor"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].业且东丒丕丕丛专丛);
            }
            
            if((val_110.ContainsKey(key:  "mask")) != false)
            {
                    bool val_32 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["mask"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].一丌丌丟丟丐世万丏);
            }
            
            if((val_110.ContainsKey(key:  "hat")) != false)
            {
                    bool val_36 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["hat"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丒丙丘丙丒不业丂丏);
            }
            
            if((val_110.ContainsKey(key:  "boots")) != false)
            {
                    bool val_40 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["boots"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丈与丄丞丆丛丐专三);
            }
            
            if((val_110.ContainsKey(key:  "cape")) != false)
            {
                    if(val_110.Item["cape"] != null)
            {
                    bool val_45 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["cape"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].下丑东东且丞丏世下);
            }
            
            }
            
            if((val_110.ContainsKey(key:  "gems")) != false)
            {
                    bool val_49 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["gems"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丐世丑丈丟丏专专丝);
            }
            
            if((val_110.ContainsKey(key:  "coins")) != false)
            {
                    bool val_53 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["coins"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丕丁丙与丙丝丞上丄);
            }
            
            if((val_110.ContainsKey(key:  "eventCurrency")) != false)
            {
                    bool val_57 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["eventCurrency"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].东丝业丅丏丟七丗且);
            }
            
            if((val_110.ContainsKey(key:  "VIPseconds")) != false)
            {
                    bool val_61 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["VIPseconds"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丅与丛丘丁丈业丆业);
            }
            
            if((val_110.ContainsKey(key:  "BattlePassCurrency")) != false)
            {
                    bool val_65 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["BattlePassCurrency"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丌且丕丄丞丗丄与丂);
            }
            
            val_117 = "weapons";
            if((val_110.ContainsKey(key:  "weapons")) == false)
            {
                goto label_103;
            }
            
            object val_67 = val_110.Item["weapons"];
            val_118 = new object[1];
            val_110 = val_110.Item["weapons"];
            val_118[0] = val_110;
            val_119 = "parse offers config fail: unknown reward weapons format \'{0}\'";
            goto label_137;
            label_103:
            val_117 = "gadgets";
            if((val_110.ContainsKey(key:  "gadgets")) == false)
            {
                goto label_115;
            }
            
            object val_72 = val_110.Item["gadgets"];
            val_118 = new object[1];
            val_110 = val_110.Item["gadgets"];
            val_118[0] = val_110;
            val_119 = "parse offers config fail: unknown reward gadgets format \'{0}\'";
            goto label_137;
            label_115:
            val_117 = "pets";
            if((val_110.ContainsKey(key:  "pets")) == false)
            {
                goto label_127;
            }
            
            object val_77 = val_110.Item["pets"];
            val_118 = new object[1];
            val_110 = val_110.Item["pets"];
            val_118[0] = val_110;
            val_119 = "parse offers config fail: unknown reward pets format \'{0}\'";
            goto label_137;
            label_127:
            val_117 = "lobbyItems";
            if((val_110.ContainsKey(key:  "lobbyItems")) == false)
            {
                goto label_139;
            }
            
            object val_82 = val_110.Item["lobbyItems"];
            object[] val_83 = new object[1];
            val_118 = val_83;
            val_110 = val_110.Item["lobbyItems"];
            val_118[0] = val_110;
            val_119 = "parse offers config fail: unknown reward lobbyItems format \'{0}\'";
            label_137:
            UnityEngine.Debug.LogErrorFormat(format:  val_119, args:  val_83);
            return 0;
            label_139:
            if((val_110.ContainsKey(key:  "upgrades")) != false)
            {
                    bool val_89 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["upgrades"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丌丘不丑丗三不丐丏);
            }
            
            if((val_110.ContainsKey(key:  "gachaFreeSpins")) != false)
            {
                    bool val_93 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["gachaFreeSpins"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].不七丆一丆丘东丄丛);
            }
            
            if((val_110.ContainsKey(key:  "items")) == false)
            {
                goto label_177;
            }
            
            char[] val_97 = new char[1];
            val_97[0] = ',';
            System.String[] val_98 = val_110.Item["items"].Trim().Split(separator:  val_97);
            if(val_98 == null)
            {
                goto label_177;
            }
            
            .且东丌丏丐丝丕万业 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            if(val_98.Length < 1)
            {
                goto label_177;
            }
            
            label_176:
            Rilisoft.OfferItem val_100 = Rilisoft.OfferItem.东丝丄丈丆三丘与丈(丞丕丒专一下丙业上:  val_98[0]);
            if(val_100 == null)
            {
                goto label_172;
            }
            
            if(val_100.IsKnownItem == false)
            {
                goto label_175;
            }
            
            (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].且东丌丏丐丝丕万业.Add(item:  val_100);
            label_172:
            if((0 + 1) < val_98.Length)
            {
                goto label_176;
            }
            
            goto label_177;
            label_175:
            (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].且东丌丏丐丝丕万业.Clear();
            label_177:
            if((val_110.ContainsKey(key:  "glider")) != false)
            {
                    bool val_106 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["glider"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].与丂三世丛丗且丘丛);
            }
            
            if((val_110.ContainsKey(key:  "transport")) == false)
            {
                    return 0;
            }
            
            bool val_110 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_110.Item["transport"], 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒)[1152921543784146016].丅丈一东东丑丆丟丛);
            return 0;
        }
        private static Rilisoft.七丈业与与不七丈丟.丏一丄丐专丟丂丟丏 丌一丑丅丝丁业丞丏(System.Collections.Generic.Dictionary<string, object> 三丁丕丒丕丒丌丆丞)
        {
            var val_26;
            Rilisoft.PlayerPaymentType val_44;
            string val_45;
            string val_46;
            七丈业与与不七丈丟.丏一丄丐专丟丂丟丏 val_1 = new 七丈业与与不七丈丟.丏一丄丐专丟丂丟丏();
            .丂且丝世一丈业一丈 = new System.Collections.Generic.List<Rilisoft.PlayerPaymentType>();
            if((三丁丕丒丕丒丌丆丞.ContainsKey(key:  "conditions")) != false)
            {
                    var val_43 = 三丁丕丒丕丒丌丆丞.Item["conditions"];
            }
            
            label_86:
            if(val_1 != null)
            {
                goto label_90;
            }
            
            label_91:
            label_90:
            if((System.Linq.Enumerable.Any<Rilisoft.PlayerPaymentType>(source:  (七丈业与与不七丈丟.丏一丄丐专丟丂丟丏)[1152921543784653088].丂且丝世一丈业一丈)) == true)
            {
                    return val_1;
            }
            
            (七丈业与与不七丈丟.丏一丄丐专丟丂丟丏)[1152921543784653088].丂且丝世一丈业一丈.Add(item:  1);
            return val_1;
            label_49:
            if((523052224 & 1) == 0)
            {
                goto label_36;
            }
            
            new 丝丅世丅丌世丆丘丐.且下七业七业一上丈() = new System.Object();
            val_26 = 0;
            System.Nullable<T> val_29 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<Rilisoft.PlayerPaymentType>(下业七不丑丂丏丟东:  val_26.丐丏七丌丕丗业且上(), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(new 丝丅世丅丌世丆丘丐.且下七业七业一上丈() != null)
            {
                    val_44 = new 丝丅世丅丌世丆丘丐.且下七业七业一上丈();
                .丐丌丁丐三丆丒专且 = val_29.HasValue;
            }
            else
            {
                    mem[16] = val_29.HasValue;
                val_44 = 16;
            }
            
            if(((val_44 & 1) == 0) || (val_44 == 0))
            {
                goto label_49;
            }
            
            System.Func<Rilisoft.PlayerPaymentType, System.Boolean> val_30 = new System.Func<Rilisoft.PlayerPaymentType, System.Boolean>(object:  new 丝丅世丅丌世丆丘丐.且下七业七业一上丈(), method:  System.Boolean 丝丅世丅丌世丆丘丐.且下七业七业一上丈::丁丏丏丁下丂丞丁下(Rilisoft.PlayerPaymentType 丄三丅七丆丛与与上));
            if((System.Linq.Enumerable.Any<Rilisoft.PlayerPaymentType>(source:  (七丈业与与不七丈丟.丏一丄丐专丟丂丟丏)[1152921543784653088].丂且丝世一丈业一丈, predicate:  null)) == true)
            {
                goto label_49;
            }
            
            (七丈业与与不七丈丟.丏一丄丐专丟丂丟丏)[1152921543784653088].丂且丝世一丈业一丈.Add(item:  mem[16]);
            goto label_49;
            label_36:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_43.ContainsKey(key:  "start")) != false)
            {
                    object val_33 = val_43.Item["start"];
                if(val_33 != null)
            {
                    var val_34 = (null == null) ? (val_33) : 0;
            }
            else
            {
                    val_45 = 0;
            }
            
                System.DateTime val_36 = System.DateTime.Parse(s:  val_45, provider:  System.Globalization.CultureInfo.InvariantCulture);
                if((523052208 & 1) != 0)
            {
                    .三丌丄丆下丑丛七不 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {});
            }
            
            }
            
            if((val_43.ContainsKey(key:  "end")) == false)
            {
                goto label_86;
            }
            
            object val_39 = val_43.Item["end"];
            if(val_39 != null)
            {
                    val_43 = (null == null) ? (val_39) : 0;
            }
            else
            {
                    val_46 = 0;
            }
            
            System.DateTime val_41 = System.DateTime.Parse(s:  val_46, provider:  System.Globalization.CultureInfo.InvariantCulture);
            if((523052192 & 1) == 0)
            {
                goto label_86;
            }
            
            .丗专丒丕丄下丘丁丛 = 专七专下且专三一且.丅丛下丐东专万七丑(七三丗丙丏丘丘丅上:  new System.DateTime() {});
            if(val_1 != null)
            {
                goto label_90;
            }
            
            goto label_91;
        }
        protected virtual void 七丁丘丅世丟三且丆(System.Collections.Generic.Dictionary<string, object> 丈丗与丞一上且上上)
        {
        
        }
        public virtual void Dispose()
        {
            var val_4;
            System.Collections.Generic.Dictionary<OfferModule, System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>> val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = this;
            if(this.且丑不丛丏丏丐丄丐 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            val_10 = 0;
            val_11 = 0;
            var val_8 = 0;
            label_15:
            if((523391936 & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(val_5._value._obj == 0)
            {
                goto label_15;
            }
            
            List.Enumerator<T> val_6 = val_5._value._obj.GetEnumerator();
            label_7:
            if((523391888 & 1) == 0)
            {
                goto label_5;
            }
            
            if(val_4.丐丏七丌丕丗业且上() == null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_5:
            val_8 = val_8 + 1;
            mem2[0] = 97;
            val_12 = val_11;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_8 == 1) || ((1152921543784944464 + ((0 + 1)) << 2) != 97))
            {
                goto label_12;
            }
            
            var val_9 = 0;
            val_9 = val_9 ^ (val_8 >> 31);
            val_8 = val_8 + val_9;
            goto label_15;
            label_12:
            if( == 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_2:
            val_8 = val_8 + 1;
            mem2[0] = 122;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_8 == 1)
            {
                goto label_22;
            }
            
            if(( == 0) || ((1152921543784944464 + ((0 + 1)) << 2) == 122))
            {
                goto label_27;
            }
            
            label_26:
            label_27:
            val_9 = this.且丑不丛丏丏丐丄丐;
            val_9.Clear();
            return;
            label_22:
            if( != 0)
            {
                goto label_26;
            }
            
            goto label_27;
        }
    
    }

}
