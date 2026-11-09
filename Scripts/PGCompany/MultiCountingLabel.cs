using UnityEngine;

namespace PGCompany
{
    internal class MultiCountingLabel : MonoBehaviour
    {
        // Fields
        public UnityEngine.AudioClip tickSound;
        public UILabel[] targets;
        private string <不丏一丅丝丛丑东丁>k__BackingField;
        private bool <丙丕七丞丕丄业一且>k__BackingField;
        private int[] 丂丞业丏与丄丁下丆;
        private float duration;
        private bool 丐东丄专万业丄丈丞;
        private PGCompany.MultiCountingLabel.业丐世一且丂丙丄丗[] 三丒丞三丂不丛万一;
        
        // Properties
        internal string 丂丒一与丑七一丅丆 { get; set; }
        internal bool 丌业万丗丒世丟七七 { get; set; }
        
        // Methods
        internal string 丏丝七上丌七丒丘丘()
        {
            return (string)this.<不丏一丅丝丛丑东丁>k__BackingField;
        }
        private void 上世丝丁世丈丘丕丆(string 丙业与丙丗丝不丈东)
        {
            this.<不丏一丅丝丛丑东丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 丆丛丌专丞丏丐丒丛()
        {
            return (bool)this.<丙丕七丞丕丄业一且>k__BackingField;
        }
        private void 东丐下丁丕丏专一丄(bool 丙业与丙丗丝不丈东)
        {
            this.<丙丕七丞丕丄业一且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 且丟丘专丕丗丟专下(float 与丈业丛丝丒丙一丏)
        {
            if((this.<丙丕七丞丕丄业一且>k__BackingField) != false)
            {
                    return;
            }
            
            this.duration = 与丈业丛丝丒丙一丏;
        }
        internal void 丅下丂丒东下丒丑丐()
        {
            this.<丙丕七丞丕丄业一且>k__BackingField = false;
            this.一与三丂丌丘丟丛丁(丕丗丘丑丛与丑业丒:  System.String.alignConst);
        }
        internal void 上不与丞丛不丏专丙(int[] 丟丕丞业丅不世丌万, string 丕丂丐丌丆丝且万丗 = "")
        {
            var val_5;
            System.Func<System.Int32, System.String> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = MultiCountingLabel.<>c.<>9__16_0;
            if(val_7 == null)
            {
                    System.Func<System.Int32, System.String> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Func<System.Int32, System.String>(object:  MultiCountingLabel.<>c.__il2cppRuntimeField_static_fields, method:  System.String MultiCountingLabel.<>c::丅丏一丛专丘三丌丝(int 三丟东丕丄丄下下丑));
                MultiCountingLabel.<>c.<>9__16_0 = val_7;
            }
            
            this.丂丞业丏与丄丁下丆 = 丟丕丞业丅不世丌万;
            this.<丙丕七丞丕丄业一且>k__BackingField = false;
            this.一与三丂丌丘丟丛丁(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丕丂丐丌丆丝且万丗, args:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  丟丕丞业丅不世丌万, selector:  val_1))));
        }
        internal void 丒丙丐丑丘不丅业下(int[] 丟丘下不上丁丈专一, int[] 专丝东丂丏三丘且不, float 丟丞一专丕三东丗一, string 丕丂丐丌丆丝且万丗 = "")
        {
            this.且丏丂丐丏业丕七丞(丟丘下不上丁丈专一:  丟丘下不上丁丈专一, 专丝东丂丏三丘且不:  专丝东丂丏三丘且不, 丕丂丐丌丆丝且万丗:  丕丂丐丌丆丝且万丗);
        }
        internal void 且丏丂丐丏业丕七丞(int[] 丟丘下不上丁丈专一, int[] 专丝东丂丏三丘且不, string 丕丂丐丌丆丝且万丗 = "")
        {
            int val_3;
            业丐世一且丂丙丄丗[] val_4;
            var val_5;
            if((this.<丙丕七丞丕丄业一且>k__BackingField) != false)
            {
                    return;
            }
            
            if(丟丘下不上丁丈专一 == null)
            {
                goto label_2;
            }
            
            label_19:
            if(丟丘下不上丁丈专一.Length != 专丝东丂丏三丘且不.Length)
            {
                    UnityEngine.Debug.LogError(message:  "MultiCountingLabel: startValues.Length != endValues.Length");
            }
            
            this.丐东丄专万业丄丈丞 = false;
            this.丂丞业丏与丄丁下丆 = 专丝东丂丏三丘且不;
            this.<不丏一丅丝丛丑东丁>k__BackingField = 丕丂丐丌丆丝且万丗;
            val_4 = new 业丐世一且丂丙丄丗[0];
            this.三丒丞三丂不丛万一 = val_4;
            val_5 = 0;
            goto label_7;
            label_17:
            val_3 = 丟丘下不上丁丈专一[0];
            MultiCountingLabel.业丐世一且丂丙丄丗 val_2 = new MultiCountingLabel.业丐世一且丂丙丄丗(丈丗与丞一上且上上:  val_3, 专丂丕丗丗东世丞下:  专丝东丂丏三丘且不[0], 与丈业丛丝丒丙一丏:  this.duration);
            if(this.三丒丞三丂不丛万一 == null)
            {
                goto label_10;
            }
            
            if(val_2 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_2 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            this.三丒丞三丂不丛万一[0] = val_2;
            val_4 = this.三丒丞三丂不丛万一;
            val_5 = 1;
            label_7:
            if(val_5 < this.三丒丞三丂不丛万一.Length)
            {
                goto label_17;
            }
            
            this.丒丁丅一下丂专万不(丟丕丞业丅不世丌万:  丟丘下不上丁丈专一, 丕丂丐丌丆丝且万丗:  this.<不丏一丅丝丛丑东丁>k__BackingField);
            return;
            label_2:
            if(专丝东丂丏三丘且不 != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        internal void 丞上丝丗七丁七丑丘()
        {
            this.丐东丄专万业丄丈丞 = true;
        }
        internal void 丄丄丛万丁丐丐与丏()
        {
            if(this.丐东丄专万业丄丈丞 == true)
            {
                    return;
            }
            
            if((this.<丙丕七丞丕丄业一且>k__BackingField) == true)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.<丙丕七丞丕丄业一且>k__BackingField = true;
        }
        internal void 丌丄丏下七丁专丂世()
        {
            this.<丙丕七丞丕丄业一且>k__BackingField = false;
        }
        private void Update()
        {
            var val_6;
            var val_7;
            var val_8;
            System.Func<业丐世一且丂丙丄丗, System.Int32> val_10;
            if((this.<丙丕七丞丕丄业一且>k__BackingField) == false)
            {
                    return;
            }
            
            if(this.targets == null)
            {
                    return;
            }
            
            val_6 = 0;
            val_7 = 1;
            goto label_3;
            label_8:
            业丐世一且丂丙丄丗 val_6 = this.三丒丞三丂不丛万一[0];
            float val_1 = UnityEngine.Time.deltaTime;
            if(val_6 != null)
            {
                    val_6.丙下丏三三丗万业丐(丑丗丘与丈不七东丛:  val_1);
            }
            else
            {
                    0.丙下丏三三丗万业丐(丑丗丘与丈不七东丛:  val_1);
            }
            
            val_6 = 1;
            val_7 = val_7 & (((this.三丒丞三丂不丛万一[0x0][0].<丒丁丆丟丞与丏不且>k__BackingField) == true) ? 1 : 0);
            label_3:
            if(val_6 < this.三丒丞三丂不丛万一.Length)
            {
                goto label_8;
            }
            
            if((val_7 & 1) != 0)
            {
                    this.丒丁丅一下丂专万不(丟丕丞业丅不世丌万:  this.丂丞业丏与丄丁下丆, 丕丂丐丌丆丝且万丗:  this.<不丏一丅丝丛丑东丁>k__BackingField);
                this.<丙丕七丞丕丄业一且>k__BackingField = false;
                return;
            }
            
            val_8 = null;
            val_8 = null;
            val_10 = MultiCountingLabel.<>c.<>9__22_0;
            if(val_10 == null)
            {
                    System.Func<业丐世一且丂丙丄丗, System.Int32> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Func<业丐世一且丂丙丄丗, System.Int32>(object:  MultiCountingLabel.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 MultiCountingLabel.<>c::世七丟一三丒丌丏七(PGCompany.MultiCountingLabel.业丐世一且丂丙丄丗 丁丂专业丁丅丅丈丙));
                MultiCountingLabel.<>c.<>9__22_0 = val_10;
            }
            
            this.丒丁丅一下丂专万不(丟丕丞业丅不世丌万:  System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<业丐世一且丂丙丄丗, System.Int32>(source:  this.三丒丞三丂不丛万一, selector:  val_3)), 丕丂丐丌丆丝且万丗:  this.<不丏一丅丝丛丑东丁>k__BackingField);
        }
        private void 丒丁丅一下丂专万不(int[] 丟丕丞业丅不世丌万, string 丕丂丐丌丆丝且万丗)
        {
            var val_5;
            System.Func<System.Int32, System.String> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = MultiCountingLabel.<>c.<>9__23_0;
            if(val_7 == null)
            {
                    System.Func<System.Int32, System.String> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Func<System.Int32, System.String>(object:  MultiCountingLabel.<>c.__il2cppRuntimeField_static_fields, method:  System.String MultiCountingLabel.<>c::三上一丌丘丙专丌丙(int 三丟东丕丄丄下下丑));
                MultiCountingLabel.<>c.<>9__23_0 = val_7;
            }
            
            this.一与三丂丌丘丟丛丁(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丕丂丐丌丆丝且万丗, args:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  丟丕丞业丅不世丌万, selector:  val_1))));
        }
        private void 一与三丂丌丘丟丛丁(string 丕丗丘丑丛与丑业丒)
        {
            goto label_1;
            label_16:
            if(this.targets[0] != 0)
            {
                    if((this.targets[0].text.Equals(value:  丕丗丘丑丛与丑业丒)) != true)
            {
                    this.targets[0].text = 丕丗丘丑丛与丑业丒;
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < this.targets.Length)
            {
                goto label_16;
            }
        
        }
        private void OnDisable()
        {
            this.<丙丕七丞丕丄业一且>k__BackingField = false;
        }
        private void 东丄且丞丘丕东且专()
        {
            this.丄丄丛万丁丐丐与丏();
        }
        public MultiCountingLabel()
        {
        
        }
    
    }

}
