using UnityEngine;

namespace TagSystem
{
    internal class 三与下丘七丘丌丏丄 : IEquatable<TagSystem.三与下丘七丘丌丏丄>, ICloneable, IDisposable
    {
        // Fields
        private System.Action<TagSystem.丟丈不丄三一且丄丄> 丝东丙丒丙不三丌丈;
        private System.Collections.Generic.Dictionary<string, TagSystem.且丝一丙丂七丂专丑> 万丒丛且丞业上丛业;
        
        // Methods
        internal void 且丝一不东东丌与丛(System.Action<TagSystem.丟丈不丄三一且丄丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝东丙丒丙不三丌丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝东丙丒丙不三丌丈 != 1152921540809684112);
        
        }
        internal void 丁上丄丒丒丁与上与(System.Action<TagSystem.丟丈不丄三一且丄丄> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝东丙丒丙不三丌丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝东丙丒丙不三丌丈 != 1152921540809820688);
        
        }
        internal 三与下丘七丘丌丏丄()
        {
            this.万丒丛且丞业上丛业 = PGCompany.七丑一上且三世丝三<System.String, TagSystem.且丝一丙丂七丂专丑>.万世丅七一专丕丞不();
        }
        internal 三与下丘七丘丌丏丄(string 丆万一不丌且东丐丐)
        {
            bool val_1 = this.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  丆万一不丌且东丐丐);
        }
        internal 三与下丘七丘丌丏丄(string[] 丏上业丞上丈丄丈不)
        {
            bool val_1 = this.业丏丗丐丂业东丂丗(丏上业丞上丈丄丈不:  丏上业丞上丈丄丈不);
        }
        internal 三与下丘七丘丌丏丄(System.Collections.Generic.ICollection<string> 丏上业丞上丈丄丈不)
        {
            bool val_1 = this.业丏丗丐丂业东丂丗(丏上业丞上丈丄丈不:  丏上业丞上丈丄丈不);
        }
        internal bool 不丈丅万不下丙丄丅()
        {
            if(this.万丒丛且丞业上丛业 == null)
            {
                    return (bool)this.万丒丛且丞业上丛业;
            }
            
            return System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, TagSystem.且丝一丙丂七丂专丑>>(source:  this.万丒丛且丞业上丛业);
        }
        internal bool 丆丁七丄专下丗丘一(string 丆万一不丌且东丐丐)
        {
            var val_8;
            var val_9;
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  丆万一不丌且东丐丐)) != false)
            {
                    val_9 = 1;
                return (bool);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.万丒丛且丞业上丛业.GetEnumerator();
            val_8 = 1152921540810599744;
            label_5:
            if((1844029368 & 1) == 0)
            {
                goto label_4;
            }
            
            if((1844029296 & 1) == 0)
            {
                goto label_5;
            }
            
            val_9 = 1;
            goto label_6;
            label_4:
            val_9 = 0;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool);
        }
        internal bool 且丄丄丛丏丑丕丕上(string 丆万一不丌且东丐丐)
        {
            if(this.万丒丛且丞业上丛业 != null)
            {
                    return this.万丒丛且丞业上丛业.ContainsKey(key:  丆万一不丌且东丐丐);
            }
            
            return this.万丒丛且丞业上丛业.ContainsKey(key:  丆万一不丌且东丐丐);
        }
        internal bool 丑东三丁下丝丏丁下(string[] 丏上业丞上丈丄丈不)
        {
            var val_3;
            var val_4;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  丏上业丞上丈丄丈不)) == true)
            {
                goto label_1;
            }
            
            val_3 = 0;
            label_5:
            if(val_3 >= 丏上业丞上丈丄丈不.Length)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if((this.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  丏上业丞上丈丄丈不[0])) == true)
            {
                goto label_5;
            }
            
            label_1:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        internal bool 丑东三丁下丝丏丁下(System.Collections.Generic.ICollection<string> 丏上业丞上丈丄丈不)
        {
            System.Collections.Generic.ICollection<T> val_7;
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            val_7 = 丏上业丞上丈丄丈不;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  val_7)) == true)
            {
                goto label_1;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_7 = val_7.GetEnumerator();
            label_18:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  val_7.Current)) == true)
            {
                goto label_18;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_13 = 61;
            goto label_19;
            label_12:
            val_11 = 0;
            val_12 = 0;
            val_13 = 59;
            label_19:
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_7.Dispose();
            }
            
            if( == 1)
            {
                goto label_30;
            }
            
            if(59 != 61)
            {
                goto label_31;
            }
            
            label_1:
            val_15 = 0;
            return (bool)val_15;
            label_30:
            if( == true)
            {
                goto label_33;
            }
            
            goto label_34;
            label_31:
            val_15 = 1;
            if( == false)
            {
                    return (bool)val_15;
            }
            
            if(59 == 59)
            {
                    return (bool)val_15;
            }
            
            label_33:
            label_34:
            val_15 = 1;
            return (bool)val_15;
        }
        internal bool 丑东三丁下丝丏丁下(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
        {
            var val_2;
            var val_7;
            var val_8;
            if(丏万且丈丙丁丁且世 == null)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = 丏万且丈丙丁丁且世.万丒丛且丞业上丛业.GetEnumerator();
            val_7 = 1152921540810599744;
            label_4:
            if((1844615736 & 1) == 0)
            {
                goto label_3;
            }
            
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_2.丐丏七丌丕丗业且上())) == true)
            {
                goto label_4;
            }
            
            val_8 = 0;
            goto label_5;
            label_1:
            val_8 = 0;
            return (bool);
            label_3:
            val_8 = 1;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool);
        }
        internal bool 上万丘丙一丛丕与下(string[] 丏上业丞上丈丄丈不)
        {
            var val_3;
            var val_4;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  丏上业丞上丈丄丈不)) == true)
            {
                goto label_1;
            }
            
            val_3 = 0;
            label_5:
            if(val_3 >= 丏上业丞上丈丄丈不.Length)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  丏上业丞上丈丄丈不[0])) == true)
            {
                goto label_5;
            }
            
            label_1:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        internal bool 上万丘丙一丛丕与下(System.Collections.Generic.ICollection<string> 丏上业丞上丈丄丈不)
        {
            System.Collections.Generic.ICollection<T> val_7;
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            val_7 = 丏上业丞上丈丄丈不;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  val_7)) == true)
            {
                goto label_1;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_7 = val_7.GetEnumerator();
            label_18:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_7.Current)) == true)
            {
                goto label_18;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_13 = 61;
            goto label_19;
            label_12:
            val_11 = 0;
            val_12 = 0;
            val_13 = 59;
            label_19:
            if(val_7 == null)
            {
                
            }
            else
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_7.Dispose();
            }
            
            if( == 1)
            {
                goto label_30;
            }
            
            if(59 != 61)
            {
                goto label_31;
            }
            
            label_1:
            val_15 = 0;
            return (bool)val_15;
            label_30:
            if( == true)
            {
                goto label_33;
            }
            
            goto label_34;
            label_31:
            val_15 = 1;
            if( == false)
            {
                    return (bool)val_15;
            }
            
            if(59 == 59)
            {
                    return (bool)val_15;
            }
            
            label_33:
            label_34:
            val_15 = 1;
            return (bool)val_15;
        }
        internal bool 上万丘丙一丛丕与下(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
        {
            var val_3;
            var val_8;
            var val_9;
            if((丏万且丈丙丁丁且世 == null) || (丏万且丈丙丁丁且世.不丈丅万不下丙丄丅() == false))
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = 丏万且丈丙丁丁且世.万丒丛且丞业上丛业.GetEnumerator();
            val_8 = 1152921540810599744;
            label_5:
            if((1845074744 & 1) == 0)
            {
                goto label_4;
            }
            
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_3.丐丏七丌丕丗业且上())) == true)
            {
                goto label_5;
            }
            
            val_9 = 0;
            goto label_6;
            label_2:
            val_9 = 0;
            return (bool);
            label_4:
            val_9 = 1;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool);
        }
        internal bool 不丈丅万不下丙丄丅(string[] 丏上业丞上丈丄丈不)
        {
            var val_3;
            var val_4;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  丏上业丞上丈丄丈不)) == true)
            {
                goto label_3;
            }
            
            val_3 = 0;
            label_5:
            if(val_3 >= 丏上业丞上丈丄丈不.Length)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if((this.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  丏上业丞上丈丄丈不[0])) == false)
            {
                goto label_5;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_3:
            val_4 = 0;
            return (bool)val_4;
        }
        internal bool 不丈丅万不下丙丄丅(System.Collections.Generic.ICollection<string> 丏上业丞上丈丄丈不)
        {
            System.Collections.Generic.ICollection<T> val_7;
            var val_11;
            var val_12;
            var val_13;
            val_7 = 丏上业丞上丈丄丈不;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  val_7)) == true)
            {
                goto label_36;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_7 = val_7.GetEnumerator();
            label_18:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  val_7.Current)) == false)
            {
                goto label_18;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_13 = 1;
            if(val_7 != null)
            {
                goto label_21;
            }
            
            goto label_26;
            label_12:
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            if(val_7 != null)
            {
                goto label_21;
            }
            
            goto label_26;
            label_21:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_7.Dispose();
            label_26:
            if( == 1)
            {
                goto label_31;
            }
            
            if(59 == 61)
            {
                    return (bool)val_13;
            }
            
            val_13 = 0;
            if( == false)
            {
                    return (bool)val_13;
            }
            
            if(59 != 59)
            {
                goto label_34;
            }
            
            return (bool)val_13;
            label_31:
            if( == false)
            {
                goto label_36;
            }
            
            label_34:
            label_36:
            val_13 = 0;
            return (bool)val_13;
        }
        internal bool 不丈丅万不下丙丄丅(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
        {
            var val_2;
            var val_7;
            var val_8;
            if(丏万且丈丙丁丁且世 == null)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = 丏万且丈丙丁丁且世.万丒丛且丞业上丛业.GetEnumerator();
            val_7 = 1152921540810599744;
            label_4:
            if((1845533752 & 1) == 0)
            {
                goto label_3;
            }
            
            if((this.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  val_2.丐丏七丌丕丗业且上())) == false)
            {
                goto label_4;
            }
            
            val_8 = 1;
            goto label_5;
            label_3:
            val_8 = 0;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_8;
            label_1:
            val_8 = 0;
            return (bool)val_8;
        }
        internal bool 丌丄丘丂丙东丕丟上(string[] 丏上业丞上丈丄丈不)
        {
            var val_3;
            var val_4;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  丏上业丞上丈丄丈不)) == true)
            {
                goto label_3;
            }
            
            val_3 = 0;
            label_5:
            if(val_3 >= 丏上业丞上丈丄丈不.Length)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  丏上业丞上丈丄丈不[0])) == false)
            {
                goto label_5;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_3:
            val_4 = 0;
            return (bool)val_4;
        }
        internal bool 丌丄丘丂丙东丕丟上(System.Collections.Generic.ICollection<string> 丏上业丞上丈丄丈不)
        {
            System.Collections.Generic.ICollection<T> val_7;
            var val_11;
            var val_12;
            var val_13;
            val_7 = 丏上业丞上丈丄丈不;
            if((PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<System.String>(丈丆丕与丒丌丘丕且:  val_7)) == true)
            {
                goto label_36;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_7 = val_7.GetEnumerator();
            label_18:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_7.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_7.Current)) == false)
            {
                goto label_18;
            }
            
            val_11 = 0;
            val_12 = 0;
            val_13 = 1;
            if(val_7 != null)
            {
                goto label_21;
            }
            
            goto label_26;
            label_12:
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            if(val_7 != null)
            {
                goto label_21;
            }
            
            goto label_26;
            label_21:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_7.Dispose();
            label_26:
            if( == 1)
            {
                goto label_31;
            }
            
            if(59 == 61)
            {
                    return (bool)val_13;
            }
            
            val_13 = 0;
            if( == false)
            {
                    return (bool)val_13;
            }
            
            if(59 != 59)
            {
                goto label_34;
            }
            
            return (bool)val_13;
            label_31:
            if( == false)
            {
                goto label_36;
            }
            
            label_34:
            label_36:
            val_13 = 0;
            return (bool)val_13;
        }
        internal bool 丌丄丘丂丙东丕丟上(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
        {
            var val_3;
            var val_38;
            var val_39;
            var val_40;
            System.String[] val_41;
            var val_42;
            var val_43;
            string val_44;
            var val_45;
            var val_46;
            if((丏万且丈丙丁丁且世 == null) || (丏万且丈丙丁丁且世.不丈丅万不下丙丄丅() == false))
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = 丏万且丈丙丁丁且世.万丒丛且丞业上丛业.GetEnumerator();
            val_38 = 1152921540810599744;
            label_5:
            if((1846062392 & 1) == 0)
            {
                goto label_4;
            }
            
            if((this.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_3.丐丏七丌丕丗业且上())) == false)
            {
                goto label_5;
            }
            
            val_39 = 1;
            goto label_6;
            label_4:
            val_39 = 0;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_39;
            label_2:
            val_39 = 0;
            return (bool)val_39;
            label_28:
            if(W23 >= 0.Length)
            {
                goto label_20;
            }
            
            label_29:
            val_40 = 0;
            if((W23 >= 1) && ((Chars[W23] & 65535) == '.'))
            {
                    Add(item:  Substring(startIndex:  0, length:  W23));
                val_40 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                Add(item:  Substring(startIndex:  1, length:  0));
            }
            
            val_42 = 1;
            val_43 = ;
            val_44 = val_42 + 1;
            if(as. 
                
              
             
            
             
              == 0)
            {
                goto label_28;
            }
            
            if(val_44 < Length)
            {
                goto label_29;
            }
            
            label_20:
            if(Length > val_43)
            {
                    Add(item:  public System.Void Dictionary.Enumerator<System.String, TagSystem.且丝一丙丂七丂专丑>::Dispose());
                if(as. 
                
              
             
            
             
              != 0)
            {
                    val_44 = Length;
            }
            else
            {
                    val_44 = 0.Length;
            }
            
                val_40 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                Add(item:  Substring(startIndex:  val_43 + 1, length:  val_44 + val_43));
            }
            
            if(Count < 1)
            {
                goto label_36;
            }
            
            int val_25 = Count;
            string[] val_26 = new string[0];
            val_45 = 0;
            goto label_38;
            label_47:
            val_41 = val_26;
            val_40 = public System.String System.Collections.Generic.List<System.String>::get_Item(int index);
            val_44 = Item[0];
            if(val_41 == 0)
            {
                goto label_40;
            }
            
            if(val_44 != null)
            {
                goto label_41;
            }
            
            goto label_44;
            label_40:
            if(val_44 == null)
            {
                goto label_44;
            }
            
            label_41:
            string val_40 = val_26[4];
            if(val_44 == null)
            {
                    val_40 = 0;
            }
            
            label_44:
            if(val_45 >= mem[1152921540812732824])
            {
                    val_40 = 0;
            }
            
            System.String[] val_28 = val_41 + 0;
            val_45 = 1;
            mem2[0] = val_44;
            label_38:
            if(val_45 < Count)
            {
                goto label_47;
            }
            
            label_63:
            if(Count < 1)
            {
                goto label_49;
            }
            
            int val_31 = Count;
            string[] val_32 = new string[0];
            val_46 = 0;
            goto label_51;
            label_60:
            val_41 = val_32;
            val_40 = public System.String System.Collections.Generic.List<System.String>::get_Item(int index);
            val_44 = Item[0];
            if(val_41 == 0)
            {
                goto label_53;
            }
            
            if(val_44 != null)
            {
                goto label_54;
            }
            
            goto label_57;
            label_53:
            if(val_44 == null)
            {
                goto label_57;
            }
            
            label_54:
            string val_41 = val_32[4];
            if(val_44 == null)
            {
                    val_40 = 0;
            }
            
            label_57:
            if(val_46 >= mem[1152921540812745112])
            {
                    val_40 = 0;
            }
            
            System.String[] val_34 = val_41 + 0;
            val_46 = 1;
            mem2[0] = val_44;
            label_51:
            if(val_46 < Count)
            {
                goto label_60;
            }
            
            goto label_61;
            label_36:
            string[] val_36 = new string[0];
            if( != null)
            {
                goto label_63;
            }
            
            goto label_63;
            label_49:
            string[] val_37 = new string[0];
            label_61:
            PGCompany.东丑丒丗一丞下丙丙<T> val_38 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            if((PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不()) == null)
            {
                
            }
        
        }
        internal bool 业丏丗丐丂业东丂丗(string[] 丏上业丞上丈丄丈不)
        {
            var val_2;
            if((丏上业丞上丈丄丈不 != null) && (丏上业丞上丈丄丈不.Length >= 1))
            {
                    do
            {
                bool val_1 = this.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  丏上业丞上丈丄丈不[0]);
            }
            while((0 + 1) < 丏上业丞上丈丄丈不.Length);
            
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        internal bool 业丏丗丐丂业东丂丗(System.Collections.Generic.ICollection<string> 丏上业丞上丈丄丈不)
        {
            var val_7;
            var val_8;
            var val_11;
            val_8 = this;
            if(丏上业丞上丈丄丈不 == null)
            {
                goto label_6;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(丏上业丞上丈丄丈不.Count < 1)
            {
                goto label_6;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_10;
            label_6:
            val_11 = 0;
            return (bool)val_11;
            label_10:
            System.Collections.Generic.IEnumerator<T> val_4 = 丏上业丞上丈丄丈不.GetEnumerator();
            label_23:
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            bool val_9 = this.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  val_4.Current);
            goto label_23;
            label_17:
            val_7 = 0;
            val_8 = 0;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_4.Dispose();
            }
            
            val_11 = 1;
            if( != 1)
            {
                    return (bool)val_11;
            }
            
            if( == false)
            {
                    return (bool)val_11;
            }
            
            val_11 = 1;
            return (bool)val_11;
        }
        internal bool 业丏丗丐丂业东丂丗(string 丆万一不丌且东丐丐)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) != true)
            {
                    if((this.万丒丛且丞业上丛业.ContainsKey(key:  丆万一不丌且东丐丐)) == false)
            {
                goto label_5;
            }
            
            }
            
            return false;
            label_5:
            this.万丒丛且丞业上丛业.Add(key:  丆万一不丌且东丐丐, value:  new TagSystem.且丝一丙丂七丂专丑());
            if(this.丝东丙丒丙不三丌丈 == null)
            {
                    return false;
            }
            
            this.丝东丙丒丙不三丌丈.Invoke(obj:  new TagSystem.丟丈不丄三一且丄丄() {<丙丝万丈丟丕丛丑丗>k__BackingField = 丆万一不丌且东丐丐, <不上不丙下东七丘丈>k__BackingField = 1});
            return false;
        }
        internal void Remove(string 丆万一不丌且东丐丐)
        {
            var val_7;
            string val_18;
            TagSystem.丁下丏丛丘丙不与丅 val_19;
            System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑> val_20;
            var val_21;
            var val_22;
            val_18 = 丆万一不丌且东丐丐;
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            val_19 = public System.Boolean System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑>::ContainsKey(System.String key);
            if((this.万丒丛且丞业上丛业.ContainsKey(key:  val_18)) != false)
            {
                    val_19 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                val_1.Add(item:  val_18);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.万丒丛且丞业上丛业.GetEnumerator();
            val_20 = 1152921540810598720;
            val_21 = 1152921540810600768;
            label_11:
            if((1846767520 & 1) == 0)
            {
                goto label_8;
            }
            
            if((1846767456 & 1) == 0)
            {
                goto label_11;
            }
            
            val_1.Add(item:  val_7.丐丏七丌丕丗业且上());
            goto label_11;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1.Count < 1)
            {
                goto label_21;
            }
            
            val_21 = 1152921540813319520;
            val_18 = 0;
            val_22 = 0;
            goto label_22;
            label_29:
            val_20 = this.万丒丛且丞业上丛业;
            val_19 = public System.Boolean System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑>::Remove(System.String key);
            bool val_13 = val_20.Remove(key:  val_1.Item[0]);
            if(this.丝东丙丒丙不三丌丈 != null)
            {
                    val_20 = val_1.Item[0];
                val_19 = 2;
                (this.丝东丙丒丙不三丌丈 == 0) ? (val_18) : this.丝东丙丒丙不三丌丈.Invoke(obj:  new TagSystem.丟丈不丄三一且丄丄() {<丙丝万丈丟丕丛丑丗>k__BackingField = val_20, <不上不丙下东七丘丈>k__BackingField = val_19});
            }
            
            val_22 = 1;
            label_22:
            if(val_22 < val_1.Count)
            {
                goto label_29;
            }
            
            label_21:
            if((PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不()) != null)
            {
                    return;
            }
        
        }
        internal bool 丘丅丐下丏与丞丂丏(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世, TagSystem.丞丟一丅丐专三万不 丟丐上丟丆丙丄丗丈)
        {
            var val_3;
            var val_10;
            var val_11;
            val_10 = 丟丐上丟丆丙丄丗丈;
            val_11 = 丏万且丈丙丁丁且世;
            if(val_11 == null)
            {
                    return (bool)val_11 & 1;
            }
            
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, TagSystem.且丝一丙丂七丂专丑>>(source:  丏万且丈丙丁丁且世.万丒丛且丞业上丛业)) == false)
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = 丏万且丈丙丁丁且世.万丒丛且丞业上丛业.GetEnumerator();
            val_11 = 0;
            goto label_6;
            label_7:
            if(val_10 != null)
            {
                    if((val_10.丞丐丂与下与上且丆(专丛丐上丈丙丏丛丂:  val_3.丐丏七丌丕丗业且上())) == false)
            {
                goto label_6;
            }
            
            }
            
            val_11 = val_11 | (this.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  val_3.丐丏七丌丕丗业且上()));
            label_6:
            if((1846949192 & 1) != 0)
            {
                goto label_7;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_11 & 1;
            label_2:
            val_11 = 0;
            return (bool)val_11 & 1;
        }
        internal bool 丗丟丘丙丛上专丟丒(TagSystem.三与下丘七丘丌丏丄 丏万且丈丙丁丁且世)
        {
            var val_3;
            var val_6;
            var val_7;
            var val_8;
            val_7 = this;
            if((丏万且丈丙丁丁且世 == null) || ((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, TagSystem.且丝一丙丂七丂专丑>>(source:  丏万且丈丙丁丁且世.万丒丛且丞业上丛业)) == false))
            {
                goto label_2;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = 丏万且丈丙丁丁且世.万丒丛且丞业上丛业.GetEnumerator();
            val_6 = 1152921540810599744;
            label_5:
            if((1847106264 & 1) == 0)
            {
                goto label_4;
            }
            
            this.Remove(丆万一不丌且东丐丐:  val_3.丐丏七丌丕丗业且上());
            goto label_5;
            label_2:
            val_8 = 0;
            return (bool)val_8;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_8 = 1;
            return (bool)val_8;
        }
        internal void 与上丒丆丟与丘与丑()
        {
            var val_7;
            var val_15;
            TagSystem.丁下丏丛丘丙不与丅 val_16;
            System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑> val_17;
            string val_18;
            val_15 = this;
            if(this.万丒丛且丞业上丛业 == null)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, TagSystem.且丝一丙丂七丂专丑>>(source:  this.万丒丛且丞业上丛业)) == false)
            {
                    return;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_2 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            val_17 = this.万丒丛且丞业上丛业;
            Dictionary.Enumerator<TKey, TValue> val_3 = val_17.GetEnumerator();
            val_18 = 1152921540810599744;
            label_9:
            if((1847275552 & 1) == 0)
            {
                goto label_7;
            }
            
            val_2.Add(item:  val_7.丐丏七丌丕丗业且上());
            goto label_9;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.丝东丙丒丙不三丌丈 == null)
            {
                goto label_15;
            }
            
            val_17 = 0;
            goto label_16;
            label_22:
            bool val_10 = this.万丒丛且丞业上丛业.Remove(key:  val_2.Item[0]);
            val_18 = val_2.Item[0];
            val_16 = 2;
            this.丝东丙丒丙不三丌丈.Invoke(obj:  new TagSystem.丟丈不丄三一且丄丄() {<丙丝万丈丟丕丛丑丗>k__BackingField = val_18, <不上不丙下东七丘丈>k__BackingField = val_16});
            val_17 = 1;
            label_16:
            if(val_17 < val_2.Count)
            {
                goto label_22;
            }
            
            label_15:
            val_15 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
        }
        internal bool 丘下丗丘业且七七丞(string 丆万一不丌且东丐丐, ref System.Collections.Generic.List<string> 东且丁丆丛丁丏丘且)
        {
            var val_3;
            System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑> val_10;
            System.Collections.Generic.List<System.String> val_11;
            val_10 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) != false)
            {
                    val_11 = 0;
                return (bool)System.Linq.Enumerable.Any<System.String>(source:  val_11 = 东且丁丆丛丁丏丘且);
            }
            
            val_10 = this.万丒丛且丞业上丛业;
            Dictionary.Enumerator<TKey, TValue> val_2 = val_10.GetEnumerator();
            label_9:
            if((1847444824 & 1) == 0)
            {
                goto label_6;
            }
            
            if((1847444752 & 1) == 0)
            {
                goto label_9;
            }
            
            东且丁丆丛丁丏丘且.Add(item:  val_3.丐丏七丌丕丗业且上());
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)System.Linq.Enumerable.Any<System.String>(source:  val_11);
        }
        internal string 丘下丗丘业且七七丞(string 丆万一不丌且东丐丐)
        {
            var val_3;
            string val_9;
            var val_10;
            val_9 = 丆万一不丌且东丐丐;
            val_10 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true)
            {
                    return (string)val_10;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.万丒丛且丞业上丛业.GetEnumerator();
            label_6:
            if((1847585464 & 1) == 0)
            {
                goto label_5;
            }
            
            if((1847585392 & 1) == 0)
            {
                goto label_6;
            }
            
            val_10 = val_3.丐丏七丌丕丗业且上();
            goto label_7;
            label_5:
            val_10 = 0;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_10;
        }
        internal bool 丕世丈一丕东三丒丕(string 丆万一不丌且东丐丐, ref System.Collections.Generic.List<string> 不七丘丘丒万七丄丒)
        {
            var val_3;
            var val_8;
            System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑> val_9;
            var val_10;
            val_8 = 1152921540814359600;
            val_9 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丆万一不丌且东丐丐)) != false)
            {
                    val_10 = 0;
                return (bool)val_10 & 1;
            }
            
            val_9 = this.万丒丛且丞业上丛业;
            Dictionary.Enumerator<TKey, TValue> val_2 = val_9.GetEnumerator();
            label_9:
            val_10 = 0;
            label_7:
            if((1847726008 & 1) == 0)
            {
                goto label_6;
            }
            
            if((1847725936 & 1) == 0)
            {
                goto label_7;
            }
            
            不七丘丘丒万七丄丒.Add(item:  val_3.丐丏七丌丕丗业且上());
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_10 & 1;
        }
        internal int 丕丌丈三上丌专丙丆(string 丆万一不丌且东丐丐)
        {
            var val_9;
            var val_10;
            val_9 = System.String.IsNullOrEmpty(value:  丆万一不丌且东丐丐);
            if(this.万丒丛且丞业上丛业 == null)
            {
                goto label_1;
            }
            
            if(val_9 == false)
            {
                goto label_2;
            }
            
            label_4:
            val_10 = this.万丒丛且丞业上丛业.Count;
            return (int)val_10;
            label_1:
            if(val_9 == true)
            {
                goto label_4;
            }
            
            label_2:
            Dictionary.Enumerator<TKey, TValue> val_3 = this.万丒丛且丞业上丛业.GetEnumerator();
            val_9 = 1152921540810598720;
            val_10 = 0;
            goto label_5;
            label_6:
            val_10 = 0;
            label_5:
            if((1847863560 & 1) != 0)
            {
                goto label_6;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (int)val_10;
        }
        internal bool 丞丈丑丗下丗三三三(ref System.Collections.Generic.List<string> 东且丁丆丛丁丏丘且)
        {
            var val_2;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.万丒丛且丞业上丛业.GetEnumerator();
            label_4:
            if((1847995944 & 1) == 0)
            {
                goto label_2;
            }
            
            东且丁丆丛丁丏丘且.Add(item:  val_2.丐丏七丌丕丗业且上());
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)(东且丁丆丛丁丏丘且.Count > 0) ? 1 : 0;
        }
        internal TagSystem.且丝一丙丂七丂专丑 万丞丁且丕丅丅丐丆(string 丆万一不丌且东丐丐)
        {
            TagSystem.且丝一丙丂七丂专丑 val_0;
            if((this.万丒丛且丞业上丛业.ContainsKey(key:  丆万一不丌且东丐丐)) != false)
            {
                    if(this.万丒丛且丞业上丛业 != null)
            {
                    return this.万丒丛且丞业上丛业.Item[丆万一不丌且东丐丐];
            }
            
                return this.万丒丛且丞业上丛业.Item[丆万一不丌且东丐丐];
            }
            
            val_0.丅业丟丝丝丘万上丄 = 0;
            val_0.丝丑丆丑丏丞七丂丝 = 0;
            val_0.一丟丘万世一下不下 = 0;
            return val_0;
        }
        internal bool 丂丆世世丕丅丕丅上(TagSystem.三与下丘七丘丌丏丄 丘丛丏丘丝七世七丅, TagSystem.下万上丅丗丂丄七上 丟且丒专下丈七丗丕)
        {
            if(丘丛丏丘丝七世七丅 == null)
            {
                    return false;
            }
            
            if((丟且丒专下丈七丗丕 - 1) > 3)
            {
                    return false;
            }
            
            var val_2 = 106015620 + ((丟且丒专下丈七丗丕 - 1)) << 2;
            val_2 = val_2 + 106015620;
            goto (106015620 + ((丟且丒专下丈七丗丕 - 1)) << 2 + 106015620);
        }
        internal bool 丂丆世世丕丅丕丅上(string 丆万一不丌且东丐丐, TagSystem.下万上丅丗丂丄七上 丟且丒专下丈七丗丕)
        {
            if(丆万一不丌且东丐丐 == null)
            {
                    return false;
            }
            
            if((丟且丒专下丈七丗丕 - 1) > 3)
            {
                    return false;
            }
            
            var val_3 = 106015636 + ((丟且丒专下丈七丗丕 - 1)) << 2;
            val_3 = val_3 + 106015636;
            goto (106015636 + ((丟且丒专下丈七丗丕 - 1)) << 2 + 106015636);
        }
        internal bool 丂丆世世丕丅丕丅上(string 丆万一不丌且东丐丐, TagSystem.上丒丄丕万丆丂丄丅 丟且丒专下丈七丗丕)
        {
            if(this != null)
            {
                    return this.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  丆万一不丌且东丐丐, 丟且丒专下丈七丗丕:  (丟且丒专下丈七丗丕 == 3) ? 4 : 2);
            }
            
            return this.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  丆万一不丌且东丐丐, 丟且丒专下丈七丗丕:  (丟且丒专下丈七丗丕 == 3) ? 4 : 2);
        }
        public bool Equals(TagSystem.三与下丘七丘丌丏丄 丘丛丏丘丝七世七丅)
        {
            var val_7;
            var val_9;
            System.Collections.Generic.Dictionary<System.String, TagSystem.且丝一丙丂七丂专丑> val_17;
            var val_18;
            var val_19;
            var val_22;
            var val_23;
            var val_24;
            val_18 = this;
            if(丘丛丏丘丝七世七丅 == null)
            {
                goto label_12;
            }
            
            if(val_18 == 丘丛丏丘丝七世七丅)
            {
                goto label_31;
            }
            
            val_17 = this.万丒丛且丞业上丛业;
            if(val_17 == 丘丛丏丘丝七世七丅.万丒丛且丞业上丛业)
            {
                goto label_31;
            }
            
            val_19 = 1152921540814436000;
            val_17 = val_17.Count;
            if(val_17 != 丘丛丏丘丝七世七丅.万丒丛且丞业上丛业.Count)
            {
                goto label_12;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.万丒丛且丞业上丛业.GetEnumerator();
            val_19 = 1152921540810598720;
            label_10:
            if((1848855696 & 1) == 0)
            {
                goto label_8;
            }
            
            if((丘丛丏丘丝七世七丅.万丒丛且丞业上丛业.ContainsKey(key:  val_9.丐丏七丌丕丗业且上())) == true)
            {
                goto label_10;
            }
            
            val_17 = 197;
            goto label_11;
            label_8:
            val_17 = 124;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_17 == 197)
            {
                goto label_12;
            }
            
            var val_12 = (val_17 == 124) ? -1 : 0;
            Dictionary.Enumerator<TKey, TValue> val_13 = 丘丛丏丘丝七世七丅.万丒丛且丞业上丛业.GetEnumerator();
            label_21:
            if((1848855696 & 1) == 0)
            {
                goto label_19;
            }
            
            val_17 = val_7.丐丏七丌丕丗业且上();
            if((this.万丒丛且丞业上丛业.ContainsKey(key:  val_17)) == true)
            {
                goto label_21;
            }
            
            val_18 = 0;
            val_22 = 1;
            val_23 = 197;
            goto label_22;
            label_19:
            val_18 = 0;
            val_22 = 0 + 1;
            val_23 = 195;
            label_22:
            mem2[0] = 195;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_22 == 1)
            {
                goto label_27;
            }
            
            if((1152921540815440864 + ((0 + 1)) << 2) != 197)
            {
                goto label_28;
            }
            
            label_12:
            val_24 = 0;
            return (bool)val_24;
            label_27:
            if( != 0)
            {
                goto label_30;
            }
            
            goto label_31;
            label_28:
            val_24 = 1;
            if( == 0)
            {
                    return (bool)val_24;
            }
            
            if((1152921540815440864 + ((0 + 1)) << 2) == 195)
            {
                    return (bool)val_24;
            }
            
            label_30:
            label_31:
            val_24 = 1;
            return (bool)val_24;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            System.Type val_8;
            TagSystem.三与下丘七丘丌丏丄 val_9;
            var val_10;
            val_9 = 万且万且丑丗且丌丆;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if(this == val_9)
            {
                goto label_2;
            }
            
            val_8 = val_9.GetType();
            if((System.Type.op_Inequality(left:  val_8, right:  this.GetType())) == false)
            {
                goto label_5;
            }
            
            label_1:
            val_10 = 0;
            return (bool)this.Equals(丘丛丏丘丝七世七丅:  val_9 = 0);
            label_2:
            val_10 = 1;
            return (bool)this.Equals(丘丛丏丘丝七世七丅:  val_9);
            label_5:
            val_10 = this;
            return (bool)this.Equals(丘丛丏丘丝七世七丅:  val_9);
        }
        public override int GetHashCode()
        {
            if(this.万丒丛且丞业上丛业 == null)
            {
                    return (int)this.万丒丛且丞业上丛业;
            }
            
            return this.万丒丛且丞业上丛业.GetHashCode();
        }
        public object Clone()
        {
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            int val_2 = this.万丒丛且丞业上丛业.Count;
            bool val_4 = this.丞丈丑丗下丗三三三(东且丁丆丛丁丏丘且: ref  val_1);
            TagSystem.三与下丘七丘丌丏丄 val_5 = new TagSystem.三与下丘七丘丌丏丄();
            bool val_6 = val_5.业丏丗丐丂业东丂丗(丏上业丞上丈丄丈不:  val_1);
            if((PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不()) != null)
            {
                    return (object)val_5;
            }
            
            return (object)val_5;
        }
        public void Dispose()
        {
            PGCompany.七丑一上且三世丝三<K, V> val_1 = PGCompany.七丑一上且三世丝三<System.String, TagSystem.且丝一丙丂七丂专丑>.万世丅七一专丕丞不();
            this.万丒丛且丞业上丛业 = 0;
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  this.万丒丛且丞业上丛业.Keys));
        }
    
    }

}
