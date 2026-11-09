using UnityEngine;

namespace BestHTTP.Extensions
{
    public sealed class HeaderValue
    {
        // Fields
        private string <Key>k__BackingField;
        private string <Value>k__BackingField;
        private System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> <Options>k__BackingField;
        
        // Properties
        public string Key { get; set; }
        public string Value { get; set; }
        public System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> Options { get; set; }
        public bool HasValue { get; }
        
        // Methods
        public string get_Key()
        {
            return (string)this.<Key>k__BackingField;
        }
        public void set_Key(string value)
        {
            this.<Key>k__BackingField = value;
        }
        public string get_Value()
        {
            return (string)this.<Value>k__BackingField;
        }
        public void set_Value(string value)
        {
            this.<Value>k__BackingField = value;
        }
        public System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> get_Options()
        {
            return (System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>)this.<Options>k__BackingField;
        }
        public void set_Options(System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> value)
        {
            this.<Options>k__BackingField = value;
        }
        public bool get_HasValue()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.<Value>k__BackingField);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public HeaderValue()
        {
        
        }
        public HeaderValue(string key)
        {
            this.<Key>k__BackingField = key;
        }
        public void Parse(string headerStr, ref int pos)
        {
            this.ParseImplementation(headerStr:  headerStr, pos: ref  int val_1 = pos, isOptionIsAnOption:  true);
        }
        public bool TryGetOption(string key, out BestHTTP.Extensions.HeaderValue option)
        {
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_6;
            var val_7;
            System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_8;
            option = 0;
            val_6 = this.<Options>k__BackingField;
            if(val_6 == null)
            {
                    return (bool)val_6;
            }
            
            if(val_6.Count == 0)
            {
                    return (bool)val_6;
            }
            
            val_7 = 0;
            goto label_3;
            label_8:
            val_8 = this.<Options>k__BackingField.Item[0];
            if((System.String.Equals(a:  val_2.<Key>k__BackingField, b:  key, comparisonType:  5)) == true)
            {
                goto label_6;
            }
            
            val_7 = 1;
            label_3:
            val_8 = this.<Options>k__BackingField;
            if(val_7 < val_8.Count)
            {
                goto label_8;
            }
            
            val_6 = 0;
            return (bool)val_6;
            label_6:
            option = this.<Options>k__BackingField.Item[0];
            val_6 = 1;
            return (bool)val_6;
        }
        private void ParseImplementation(string headerStr, ref int pos, bool isOptionIsAnOption)
        {
            var val_34;
            System.Func<System.Char, System.Boolean> val_36;
            var val_37;
            BestHTTP.Extensions.HeaderValue val_38;
            var val_39;
            var val_40;
            System.Collections.Generic.List<T> val_41;
            var val_42;
            var val_43;
            val_34 = null;
            val_34 = null;
            val_36 = HeaderValue.<>c.<>9__18_0;
            if(val_36 == null)
            {
                    System.Func<System.Char, System.Boolean> val_1 = null;
                val_36 = val_1;
                val_1 = new System.Func<System.Char, System.Boolean>(object:  HeaderValue.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean HeaderValue.<>c::<ParseImplementation>b__18_0(char ch));
                HeaderValue.<>c.<>9__18_0 = val_36;
            }
            
            mem[1152921553779981440] = BestHTTP.Extensions.Extensions.Read(str:  headerStr, pos: ref  1152921553780017520, block:  val_1, needResult:  true);
            System.Nullable<System.Char> val_5 = BestHTTP.Extensions.Extensions.Peek(str:  headerStr, pos:  pos - 1);
            if((1928482076 & 1) != 0)
            {
                    int val_7 = val_5.HasValue.EventId & 65535;
                val_37 = 0;
            }
            else
            {
                    val_37 = 0;
            }
            
            val_38;
            if(isOptionIsAnOption == false)
            {
                goto label_10;
            }
            
            if((1928482076 & 1) == 0)
            {
                goto label_11;
            }
            
            int val_11 = val_5.HasValue.EventId & 65535;
            val_39 = 0;
            goto label_12;
            label_10:
            val_40 = 0;
            goto label_13;
            label_11:
            val_39 = 0;
            label_12:
            val_40 = ((val_39.丙东专丂世丈丏丁丂() == 59) ? 1 : 0) & 1152921553779969312;
            label_13:
            var val_14 = ((val_37.丙东专丂世丈丏丁丂() == 61) ? 1 : 0) & val_38;
            if((val_40 & 1) == 0)
            {
                    if((val_14 & 1152921553779969324) == 0)
            {
                    return;
            }
            
            }
            
            label_34:
            if((val_14 & 1) == 0)
            {
                goto label_16;
            }
            
            mem[1152921553779981448] = BestHTTP.Extensions.Extensions.ReadPossibleQuotedText(str:  headerStr, pos: ref  1152921553780017520);
            if(isOptionIsAnOption == true)
            {
                goto label_19;
            }
            
            return;
            label_16:
            if((val_40 & 1) != 0)
            {
                    BestHTTP.Extensions.HeaderValue val_18 = null;
                val_38 = val_18;
                val_18 = new BestHTTP.Extensions.HeaderValue();
                val_41 = mem[1152921553779981456];
                if(val_41 == 0)
            {
                    System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue> val_19 = null;
                val_41 = val_19;
                val_19 = new System.Collections.Generic.List<BestHTTP.Extensions.HeaderValue>();
                mem[1152921553779981456] = val_41;
            }
            
                val_19.Add(item:  val_18);
            }
            
            if(isOptionIsAnOption == false)
            {
                    return;
            }
            
            label_19:
            System.Nullable<System.Char> val_21 = BestHTTP.Extensions.Extensions.Peek(str:  headerStr, pos:  pos - 1);
            if((1928482076 & 1) != 0)
            {
                    int val_23 = val_21.HasValue.EventId & 65535;
                val_42 = 0;
            }
            else
            {
                    val_42 = 0;
            }
            
            if((1928482076 & 1) != 0)
            {
                    int val_28 = val_21.HasValue.EventId & 65535;
                val_43 = 0;
            }
            else
            {
                    val_43 = 0;
            }
            
            val_38 = val_43.丙东专丂世丈丏丁丂();
            if((((((val_38 == 59) ? 1 : 0) & 1152921553779969312) & 1) != 0) || ((((((val_42.丙东专丂世丈丏丁丂() == 61) ? 1 : 0) & 1152921553779969312) & 1152921553779969324) & 1) != 0))
            {
                goto label_34;
            }
        
        }
        public override string ToString()
        {
            string val_3 = this.<Key>k__BackingField;
            if((System.String.IsNullOrEmpty(value:  this.<Value>k__BackingField)) == true)
            {
                    return (string)val_3;
            }
            
            val_3 = val_3 + 61 + this.<Value>k__BackingField(this.<Value>k__BackingField);
            return (string)val_3;
        }
    
    }

}
