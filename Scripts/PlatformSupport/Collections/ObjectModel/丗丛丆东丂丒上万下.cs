using UnityEngine;

namespace PlatformSupport.Collections.ObjectModel
{
    public class 丗丛丆东丂丒上万下<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable, 丟与丙丅丐丘不不丅, INotifyPropertyChanged
    {
        // Fields
        private const string 丘业丕丗专万丞世丘 = "Count";
        private const string 且不丅业七三丒丙且 = "Item[]";
        private const string 丂且丐业与七业一世 = "Keys";
        private const string 丝丏丁丟丞丏丙一丌 = "Values";
        private System.Collections.Generic.IDictionary<TKey, TValue> 万丑丕七丛丟丌下丂;
        private PlatformSupport.Collections.Specialized.一七一丞丙丝业丆一 三丈业丙丝一丝丑专;
        private System.ComponentModel.PropertyChangedEventHandler 七万丟丆丂丘丒丒丄;
        
        // Properties
        protected System.Collections.Generic.IDictionary<TKey, TValue> 与世丛丝丂万下不丘 { get; }
        public System.Collections.Generic.ICollection<TKey> 丕世七丂丗专丝上丕 { get; }
        public System.Collections.Generic.ICollection<TValue> 丂丘且上丕三东丕丒 { get; }
        public TValue 不下下丞三一丘丗丐 { get; set; }
        public int 丒专下与丑丁丆丟业 { get; }
        public bool 丅丅丌一丕七业世丌 { get; }
        
        // Methods
        protected System.Collections.Generic.IDictionary<TKey, TValue> 丒丝丈一丈丟丁丟丏()
        {
            return (System.Collections.Generic.IDictionary<TKey, TValue>)this;
        }
        public 丗丛丆东丂丒上万下<TKey, TValue>()
        {
            mem[1152921553595876240] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public 丗丛丆东丂丒上万下<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> 万丝且丘不丑丝下丑)
        {
            mem[1152921553595992336] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public 丗丛丆东丂丒上万下<TKey, TValue>(System.Collections.Generic.IEqualityComparer<TKey> 业丌丆丝东不丑上丗)
        {
            mem[1152921553596112528] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public 丗丛丆东丂丒上万下<TKey, TValue>(int 丕专七丙丂丅丕与丘)
        {
            mem[1152921553596228624] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public 丗丛丆东丂丒上万下<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> 万丝且丘不丑丝下丑, System.Collections.Generic.IEqualityComparer<TKey> 业丌丆丝东不丑上丗)
        {
            mem[1152921553596348816] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public 丗丛丆东丂丒上万下<TKey, TValue>(int 丕专七丙丂丅丕与丘, System.Collections.Generic.IEqualityComparer<TKey> 业丌丆丝东不丑上丗)
        {
            mem[1152921553596473104] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public void Add(TKey 下上丐丆丝丟丝丒不, TValue 丙业与丙丗丝不丈东)
        {
            if(this == null)
            {
                
            }
        
        }
        public bool ContainsKey(TKey 下上丐丆丝丟丝丒不)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 72), slot: 4);
        }
        public System.Collections.Generic.ICollection<TKey> get_Keys()
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 72), slot: 2);
        }
        public bool Remove(TKey 下上丐丆丝丟丝丒不)
        {
            var val_5;
            var val_7;
            if(下上丐丆丝丟丝丒不 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                var val_5 = 0;
                val_5 = val_5 + 1;
                val_5 = 6;
                if((this & 1) != 0)
            {
                    val_7 = 1;
                return (bool)val_7;
            }
            
                val_7 = 0;
                return (bool)val_7;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "key");
        }
        public bool TryGetValue(TKey 下上丐丆丝丟丝丒不, out TValue 丙业与丙丗丝不丈东)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 72), slot: 7);
        }
        public System.Collections.Generic.ICollection<TValue> get_Values()
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 72), slot: 3);
        }
        public TValue get_Item(TKey 下上丐丆丝丟丝丒不)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 72), slot: 0);
        }
        public void set_Item(TKey 下上丐丆丝丟丝丒不, TValue 丙业与丙丗丝不丈东)
        {
            if(this == null)
            {
                
            }
        
        }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> 下丅丙一丂丗丅丝七)
        {
            string val_1 = 下丅丙一丂丗丅丝七.Value.丐丏七丌丕丗业且上();
            if(this != null)
            {
                    return;
            }
        
        }
        public void Clear()
        {
            var val_3;
            var val_5;
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 112;
            if(this < 1)
            {
                    return;
            }
            
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 112;
            if(this == null)
            {
                
            }
        
        }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> 下丅丙一丂丗丅丝七)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(X3 + 24 + 192 + 112), slot: 4);
        }
        public void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] 三丒丂世丕丟东丆丏, int 专丞丁世丈下且丁丑)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 112), slot: 5);
        }
        public int get_Count()
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 112;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 112), slot: 0);
        }
        public bool get_IsReadOnly()
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 112;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 112), slot: 1);
        }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> 下丅丙一丂丗丅丝七)
        {
            string val_1 = 下丅丙一丂丗丅丝七.Value.丐丏七丌丕丗业且上();
            if(this != null)
            {
                    return false;
            }
            
            return false;
        }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            var val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 128;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 128), slot: 0);
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.GetEnumerator();
        }
        public void 丑万丝丙丌丂与丝万(PlatformSupport.Collections.Specialized.一七一丞丙丝业丆一 丙业与丙丗丝不丈东)
        {
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  static_value_082D1000, b:  丙业与丙丗丝不丈东);
            if(val_1 != null)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            if(137170944 != 1152921553598674360)
            {
                goto label_3;
            }
        
        }
        public void 丅丆专三业丝丝业丙(PlatformSupport.Collections.Specialized.一七一丞丙丝业丆一 丙业与丙丗丝不丈东)
        {
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  static_value_082D1000, value:  丙业与丙丗丝不丈东);
            if(val_1 != null)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            if(137170944 != 1152921553598802744)
            {
                goto label_3;
            }
        
        }
        public void add_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler 丙业与丙丗丝不丈东)
        {
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  static_value_082D1000, b:  丙业与丙丗丝不丈东);
            if(val_1 != null)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            if(137170944 != 1152921553598931136)
            {
                goto label_3;
            }
        
        }
        public void remove_PropertyChanged(System.ComponentModel.PropertyChangedEventHandler 丙业与丙丗丝不丈东)
        {
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  static_value_082D1000, value:  丙业与丙丗丝不丈东);
            if(val_1 != null)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            if(137170944 != 1152921553599059520)
            {
                goto label_3;
            }
        
        }
        public void 丝丐丝丛上丙丕丟一(System.Collections.Generic.IDictionary<TKey, TValue> 丑七不与丛丆一丂丞)
        {
            var val_11;
            var val_12;
            var val_14;
            var val_15;
            var val_17;
            var val_19;
            var val_22;
            var val_25;
            var val_26;
            val_12 = this;
            if(丑七不与丛丆一丂丞 == null)
            {
                goto label_1;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(丑七不与丛丆一丂丞 < 1)
            {
                    return;
            }
            
            val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 64];
            val_14 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 112];
            val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 112;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = val_15;
            val_17 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 112), slot: 0) + 8];
            val_17 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 112), slot: 0) + 8;
            if(val_12 < 1)
            {
                goto label_61;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_17 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
            val_11 = 丑七不与丛丆一丂丞;
            val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 144;
            if((val_11 & 1) != 0)
            {
                goto label_22;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 128;
            val_11 = 丑七不与丛丆一丂丞;
            label_47:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_22 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_11.MoveNext() == false)
            {
                goto label_33;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_22 = __RuntimeMethodHiddenParam + 24 + 192 + 168;
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_47;
            label_33:
            val_25 = 0;
            val_15 = 0;
            if(val_11 != null)
            {
                goto label_48;
            }
            
            goto label_55;
            label_1:
            System.ArgumentNullException val_9 = null;
            val_12 = val_9;
            val_9 = new System.ArgumentNullException(paramName:  "items");
            goto label_53;
            label_22:
            System.ArgumentException val_10 = null;
            val_12 = val_10;
            val_10 = new System.ArgumentException(message:  "An item with the same key has already been added.");
            label_53:
            if(0 != 1)
            {
                goto label_54;
            }
            
            val_25 = 0;
            if(val_11 == null)
            {
                goto label_55;
            }
            
            label_48:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_11.Dispose();
            label_55:
            if(val_25 != 1)
            {
                goto label_60;
            }
            
            label_61:
            mem[1152921553599233424] = __RuntimeMethodHiddenParam + 24 + 192;
            label_60:
            val_26 = val_12;
            goto __RuntimeMethodHiddenParam + 24 + 192 + 184;
            label_54:
        }
        private void 丁丌丒七丐丂且下丞(TKey 下上丐丆丝丟丝丒不, TValue 丙业与丙丗丝不丈东, bool 丘丂丂丅丁一丈丕三)
        {
            var val_10;
            var val_14;
            val_10 = 丘丂丂丅丁一丈丕三;
            if(下上丐丆丝丟丝丒不 == null)
            {
                goto label_1;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            if((this & 1) == 0)
            {
                goto label_9;
            }
            
            if(val_10 == true)
            {
                goto label_10;
            }
            
            if((System.Object.Equals(objA:  0, objB:  丙业与丙丗丝不丈东)) == true)
            {
                    return;
            }
            
            val_10 = this;
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_18;
            label_9:
            val_10 = this;
            var val_12 = 0;
            val_12 = val_12 + 1;
            MoonSharp.Interpreter.TablePair val_4 = new MoonSharp.Interpreter.TablePair(key:  下上丐丆丝丟丝丒不, val:  丙业与丙丗丝不丈东);
            if(this != null)
            {
                    return;
            }
            
            return;
            label_18:
            MoonSharp.Interpreter.TablePair val_6 = new MoonSharp.Interpreter.TablePair(key:  下上丐丆丝丟丝丒不, val:  丙业与丙丗丝不丈东);
            MoonSharp.Interpreter.TablePair val_7 = new MoonSharp.Interpreter.TablePair(key:  下上丐丆丝丟丝丒不, val:  0);
            return;
            label_1:
            System.ArgumentNullException val_8 = null;
            val_14 = val_8;
            val_8 = new System.ArgumentNullException(paramName:  "key");
            goto label_29;
            label_10:
            System.ArgumentException val_9 = null;
            val_14 = val_9;
            val_9 = new System.ArgumentException(message:  "An item with the same key has already been added.");
            label_29:
        }
        private void 丄七丁东丌丝下丂丐()
        {
            if(this != null)
            {
                
            }
            
            if(this == null)
            {
                
            }
        
        }
        protected virtual void 丄七丁东丌丝下丂丐(string 丄三丒丛三丕东不一)
        {
            if(==0)
            {
                    return;
            }
            
            Invoke(sender:  this, e:  new System.ComponentModel.PropertyChangedEventArgs(propertyName:  丄三丒丛三丕东不一));
        }
        private void 丘丏三丟丈上三丑丝()
        {
            if(__RuntimeMethodHiddenParam == 0)
            {
                    return;
            }
            
            __RuntimeMethodHiddenParam.Invoke(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  new PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛(七丐丅专且专七三丆:  4));
        }
        private void 丘丏三丟丈上三丑丝(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.Generic.KeyValuePair<TKey, TValue> 一丄三东丝一丒上丅)
        {
            object val_2;
            PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛 val_3;
            val_2 = X4;
            val_3 = __RuntimeMethodHiddenParam;
            if(==0)
            {
                    return;
            }
            
            val_2 = ;
            PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛 val_1 = null;
            val_3 = val_1;
            val_1 = new PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛(七丐丅专且专七三丆:  七丐丅专且专七三丆, 一丄三东丝一丒上丅:  一丄三东丝一丒上丅.Value);
            Invoke(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  val_1);
        }
        private void 丘丏三丟丈上三丑丝(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.Generic.KeyValuePair<TKey, TValue> 丏一丕东丙丆与丒丄, System.Collections.Generic.KeyValuePair<TKey, TValue> 丌丏丗与丕丈丄三丈)
        {
            object val_2;
            TValue val_3;
            val_2 = X6;
            val_3 = 丌丏丗与丕丈丄三丈.Value;
            if(==0)
            {
                    return;
            }
            
            val_3 = mem[X6 + 24 + 192 + 200];
            val_3 = X6 + 24 + 192 + 200;
            val_2;
            Invoke(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  new PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丏一丕东丙丆与丒丄:  丏一丕东丙丆与丒丄.Value, 丌丏丗与丕丈丄三丈:  __RuntimeMethodHiddenParam));
        }
        private void 丘丏三丟丈上三丑丝(PlatformSupport.Collections.Specialized.NotifyCollectionChangedAction 七丐丅专且专七三丆, System.Collections.IList 丙丙与丕不丞丛丐业)
        {
            if(__RuntimeMethodHiddenParam == 0)
            {
                    return;
            }
            
            __RuntimeMethodHiddenParam.Invoke(不丟丗丏丛丕不丁丌:  this, 丗丛不丁丑专专丂且:  new PlatformSupport.Collections.Specialized.丗下上丌丄万丝丗丛(七丐丅专且专七三丆:  七丐丅专且专七三丆, 丄业丅丐不丄业丁丟:  丙丙与丕不丞丛丐业));
        }
        private bool 东上且丑万丝丂丆专(TKey 丟三下万一丄七一丗)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this, typeof(__RuntimeMethodHiddenParam + 24 + 192 + 72), slot: 4);
        }
    
    }

}
