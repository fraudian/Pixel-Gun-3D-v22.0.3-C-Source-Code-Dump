using UnityEngine;

namespace Progress
{
    internal class 丂丂丑上丁丌业丑丈 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private static System.Action 丌丗万与丗丞三丝丞;
        private System.Collections.Generic.Dictionary<CategoryNames, int> 丞丙丛七世且丞丙丆;
        private System.Collections.Generic.Dictionary<int, CategoryNames> 丅丏丝丗一与丟专丄;
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        private 丙丟丛丞丝丂丁丑下 <丙上三丟丑业且东丑>k__BackingField;
        private Progress.丂丂丑上丁丌业丑丈.丒丘东与专丟丄业且 且丈丘七丐下专东丁;
        
        // Properties
        internal System.Collections.Generic.Dictionary<int, CategoryNames> 专上一且且且丌万丄 { get; }
        internal 丙丟丛丞丝丂丁丑下 丈不丏丅丆丑丕上与 { get; set; }
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal static void 七上丑丝七丒业丈业(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Progress.丂丂丑上丁丌业丑丈.丌丗万与丗丞三丝丞, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 与且东与丏下三业丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Progress.丂丂丑上丁丌业丑丈.丌丗万与丗丞三丝丞, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal System.Collections.Generic.Dictionary<int, CategoryNames> 丌丁丑一丂且丈一与()
        {
            if(this.丅丏丝丗一与丟专丄 != null)
            {
                    return (System.Collections.Generic.Dictionary<System.Int32, CategoryNames>)this.丅丏丝丗一与丟专丄;
            }
            
            this.丅丏丝丗一与丟专丄 = new System.Collections.Generic.Dictionary<System.Int32, CategoryNames>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.丞丙丛七世且丞丙丆.GetEnumerator();
            label_5:
            if(( & 1) == 0)
            {
                goto label_3;
            }
            
            this.丅丏丝丗一与丟专丄.set_Item(key:  -2072909544, value:  0.丐丏七丌丕丗业且上().丙东专丂世丈丏丁丂());
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.Int32, CategoryNames>)this.丅丏丝丗一与丟专丄;
        }
        internal 丙丟丛丞丝丂丁丑下 丈丞丄丑业东丈东丑()
        {
            return (丙丟丛丞丝丂丁丑下)this.<丙上三丟丑业且东丑>k__BackingField;
        }
        private void 丏下丘下与业专专丂(丙丟丛丞丝丂丁丑下 丙业与丙丗丝不丈东)
        {
            this.<丙上三丟丑业且东丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal override void 丘上丐世丆丑且丞丒()
        {
            this.且丈丘七丐下专东丁 = new 丂丂丑上丁丌业丑丈.丒丘东与专丟丄业且();
            this.<丙上三丟丑业且东丑>k__BackingField = new 丙丟丛丞丝丂丁丑下();
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Progress.丂丂丑上丁丌业丑丈::丝下上丏丏丆万下丆()));
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 25;
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
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            this.且丈丘七丐下专东丁 = this.<丙上三丟丑业且东丑>k__BackingField.三丆丁丙与万丑丕丗(一丐丗丁丞丆丅丟丄:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0);
            bool val_3 = this.万不丘万丘万与丐丒(丒丑丂万不丆且丒丝:  77, 上丟与丗七丅丈丅丁:  0, 丞不丌丘三丐丘东东:  true);
            bool val_4 = this.万不丘万丘万与丐丒(丒丑丂万不丆且丒丝:  138005, 上丟与丗七丅丈丅丁:  0, 丞不丌丘三丐丘东东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            if((this.<丙上三丟丑业且东丑>k__BackingField) != null)
            {
                    return this.<丙上三丟丑业且东丑>k__BackingField.丈万上丙丝丂丑丄丂(专丞丙一丟专丞与丗:  this.且丈丘七丐下专东丁);
            }
            
            return this.<丙上三丟丑业且东丑>k__BackingField.丈万上丙丝丂丑丄丂(专丞丙一丟专丞与丗:  this.且丈丘七丐下专东丁);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 与世丄万丈丈上丆下()
        {
            var val_7;
            Dictionary.Enumerator<TKey, TValue> val_4 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().GetEnumerator();
            label_14:
            if(((-2071661408) & 1) == 0)
            {
                goto label_7;
            }
            
            ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
            if((this.丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  val_8._value._obj.丒万丕七专不丏丞丌())) == false)
            {
                goto label_14;
            }
            
            if((Progress.七七世万专丕丁上业.丝丞丂丟业丈不丑东().专丏丕下上与与丟不().Contains(item:  val_8._value._obj.业东丅东丌上丗丑不())) == false)
            {
                goto label_14;
            }
            
            bool val_14 = this.万不丘万丘万与丐丒(丒丑丂万不丆且丒丝:  val_8._value._obj.业东丅东丌上丗丑不(), 上丟与丗七丅丈丅丁:  0, 丞不丌丘三丐丘东东:  true);
            goto label_14;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            object[] val_15 = new object[1];
            val_15[0] = this;
            UnityEngine.Debug.LogFormat(format:  "[BRV] MigrateFromLegacyData. Slot =-=-= {0}", args:  val_15);
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丂丂丑上丁丌业丑丈.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丂丂丑上丁丌业丑丈.丐丌丞上世丛丐丏丛;
        }
        internal bool 万不丘万丘万与丐丒(int 丒丑丂万不丆且丒丝, int 上丟与丗七丅丈丅丁, bool 丞不丌丘三丐丘东东 = True)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = this;
            if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  丒丑丂万不丆且丒丝)) != false)
            {
                    if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.Item[丒丑丂万不丆且丒丝]) >= 上丟与丗七丅丈丅丁)
            {
                goto label_6;
            }
            
            }
            
            this.且丈丘七丐下专东丁.业专丞三丈东丈丁三(丈丅丞世丛丆丘东丂:  丒丑丂万不丆且丒丝, 与丌万东七七下丑丗:  上丟与丗七丅丈丅丁);
            val_3 = 1152921505362010112;
            val_4 = null;
            val_4 = null;
            if(Progress.丂丂丑上丁丌业丑丈.丌丗万与丗丞三丝丞 != null)
            {
                    Progress.丂丂丑上丁丌业丑丈.丌丗万与丗丞三丝丞.Invoke();
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_6:
            val_5 = 0;
            return (bool)val_5;
        }
        internal bool 丘丐世丙丂丄万丁三(CategoryNames 七丆丒与丗丌丄且丂, long 业下丄丟丞丙一一一 = -1, int 丒丑丂万不丆且丒丝 = -1, int 上丟与丗七丅丈丅丁 = -1, bool 丞不丌丘三丐丘东东 = True)
        {
            CategoryNames val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_15 = 七丆丒与丗丌丄且丂;
            val_16 = this;
            val_17 = 0;
            if((this.丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  val_15)) == false)
            {
                    return (bool)val_17;
            }
            
            val_15 = this.丞丙丛七世且丞丙丆.Item[val_15];
            val_18 = null;
            val_18 = null;
            if((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丆丄丝丁丟世丝丅丅.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟.丁且丂丁丘丂不丗业})) != true)
            {
                    if((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丆丄丝丁丟世丝丅丅.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_15})) == false)
            {
                goto label_19;
            }
            
            }
            
            if(((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.<业丟与万上丁三且丞>k__BackingField.Equals(obj:  业下丄丟丞丙一一一)) != false) && ((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.且丏业七与丐丌丂丏.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丒丑丂万不丆且丒丝})) != false))
            {
                    if((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丞丙丞丛丗东丂丆丁.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 上丟与丗七丅丈丅丁})) != false)
            {
                    val_17 = 0;
                return (bool)val_17;
            }
            
            }
            
            label_19:
            val_20 = null;
            val_20 = null;
            if((业下丄丟丞丙一一一.Equals(obj:  丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟.专三丐丟丝丆上丝丆)) == false)
            {
                goto label_29;
            }
            
            val_21 = null;
            val_21 = null;
            if((丒丑丂万不丆且丒丝.Equals(obj:  丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟.丁且丂丁丘丂不丗业)) == false)
            {
                goto label_29;
            }
            
            val_22 = null;
            val_22 = null;
            if((上丟与丗七丅丈丅丁.Equals(obj:  丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟.丁且丂丁丘丂不丗业)) == false)
            {
                goto label_29;
            }
            
            val_23 = null;
            val_23 = null;
            int val_11 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_24 = 0;
            this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丆丄丝丁丟世丝丅丅 = 0;
            mem2[0] = val_24;
            goto label_34;
            label_29:
            int val_12 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            val_24 = 0;
            this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丆丄丝丁丟世丝丅丅 = 0;
            mem2[0] = val_24;
            label_34:
            int val_13 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丞丙丞丛丗东丂丆丁 = 0;
            mem2[0] = 0;
            this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.<业丟与万上丁三且丞>k__BackingField = 业下丄丟丞丙一一一;
            val_15 = 丒丑丂万不丆且丒丝;
            int val_14 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.且丏业七与丐丌丂丏 = 0;
            mem2[0] = 0;
            val_16 = 1152921505362010112;
            val_25 = null;
            val_25 = null;
            if(Progress.丂丂丑上丁丌业丑丈.丌丗万与丗丞三丝丞 != null)
            {
                    Progress.丂丂丑上丁丌业丑丈.丌丗万与丗丞三丝丞.Invoke();
            }
            
            val_17 = 1;
            return (bool)val_17;
        }
        internal bool 丈丛丒七丘丝丏丁丝(int 丞世不丒下上上丝丑)
        {
            if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField) == null)
            {
                    return false;
            }
            
            if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.Count) == 0)
            {
                    return false;
            }
            
            if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField) != null)
            {
                    return this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑);
            }
            
            return this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  丞世不丒下上上丝丑);
        }
        internal System.Collections.Generic.Dictionary<int, int> 丌丈丐丕万业上丆专()
        {
            if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField) != null)
            {
                    return this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.丁丕上三丕丌丟丗丙();
            }
            
            return this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.丁丕上三丕丌丟丗丙();
        }
        internal Progress.丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟 与丟三三丐丝丑万业()
        {
            if(this.且丈丘七丐下专东丁 != null)
            {
                    return (丞丑七丙业万与七丟)this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField;
            }
            
            return (丞丑七丙业万与七丟)this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField;
        }
        internal int 丈专丅业专且丈且丛()
        {
        
        }
        internal long 丅万丐一丕专丑与上()
        {
            if((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField) != null)
            {
                    return (long)this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.<业丟与万上丁三且丞>k__BackingField;
            }
            
            return (long)this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.<业丟与万上丁三且丞>k__BackingField;
        }
        internal bool 与东专七丈丅一丌丞()
        {
            null = null;
            bool val_1 = this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.<业丟与万上丁三且丞>k__BackingField.Equals(obj:  丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟.专三丐丟丝丆上丝丆);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        internal int 丈业七下丐丅丙东上()
        {
            var val_6;
            bool val_1 = this.与东专七丈丅一丌丞();
            val_6 = null;
            val_6 = null;
            return (int)丂丂丑上丁丌业丑丈.丞丑七丙业万与七丟.丁且丂丁丘丂不丗业;
        }
        internal bool 与东专七丈丅一丌丞(int 丛不丕七且丝东世丙)
        {
            var val_4 = 0;
            if(this.与东专七丈丅一丌丞() == false)
            {
                    return (bool)this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.且丏业七与丐丌丂丏.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丛不丕七且丝东世丙});
            }
            
            return (bool)this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.且丏业七与丐丌丂丏.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = 丛不丕七且丝东世丙});
        }
        internal bool 丛丘东丏丟丁丝与世(CategoryNames 丈丁丐丌三丟与一丕)
        {
            if(this.丞丙丛七世且丞丙丆 != null)
            {
                    return this.丞丙丛七世且丞丙丆.ContainsKey(key:  丈丁丐丌三丟与一丕);
            }
            
            return this.丞丙丛七世且丞丙丆.ContainsKey(key:  丈丁丐丌三丟与一丕);
        }
        internal bool 丅且与丒上丏东下丂(CategoryNames 丈丁丐丌三丟与一丕, int 丛不丕七且丝东世丙, int 上丟与丗七丅丈丅丁 = -9999)
        {
            if((this.丛丘东丏丟丁丝与世(丈丁丐丌三丟与一丕:  丈丁丐丌三丟与一丕)) == false)
            {
                    return false;
            }
            
            return this.丅且与丒上丏东下丂(丛不丕七且丝东世丙:  丛不丕七且丝东世丙, 上丟与丗七丅丈丅丁:  上丟与丗七丅丈丅丁);
        }
        internal bool 丅且与丒上丏东下丂(int 丛不丕七且丝东世丙, int 上丟与丗七丅丈丅丁 = -9999)
        {
            var val_5;
            if((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.ContainsKey(下上丐丆丝丟丝丒不:  丛不丕七且丝东世丙)) != false)
            {
                    if((上丟与丗七丅丈丅丁.Equals(obj:  9998)) == false)
            {
                    return (bool)((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.Item[丛不丕七且丝东世丙]) >= 上丟与丗七丅丈丅丁) ? 1 : 0;
            }
            
                val_5 = 1;
                return (bool)((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.Item[丛不丕七且丝东世丙]) >= 上丟与丗七丅丈丅丁) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)((this.且丈丘七丐下专东丁.<丂丟丏丟不丂丝丙丟>k__BackingField.Item[丛不丕七且丝东世丙]) >= 上丟与丗七丅丈丅丁) ? 1 : 0;
        }
        private void 丝下上丏丏丆万下丆()
        {
            var val_8;
            CategoryNames val_9;
            if(this.与东专七丈丅一丌丞() == false)
            {
                    return;
            }
            
            if((this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField) != null)
            {
                    val_8 = this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.且丏业七与丐丌丂丏;
                val_9 = this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.一七三不丝丄丌丆丘();
            }
            else
            {
                    val_8 = 32;
                val_9 = 0.一七三不丝丄丌丆丘();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  148);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丒丆业丁业一丁丂(七丆丒与丗丌丄且丂:  val_9, 丒丑丂万不丆且丒丝:  32, 上丟与丗七丅丈丅丁:  this.且丈丘七丐下专东丁.<专上东七丘业七丁与>k__BackingField.丞丙丞丛丗东丂丆丁);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丘丐世丙丂丄万丁三(七丆丒与丗丌丄且丂:  val_9, 业下丄丟丞丙一一一:  0, 丒丑丂万不丆且丒丝:  0, 上丟与丗七丅丈丅丁:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.且丈丘七丐下专东丁 = new 丂丂丑上丁丌业丑丈.丒丘东与专丟丄业且();
        }
        public 丂丂丑上丁丌业丑丈()
        {
            System.Collections.Generic.Dictionary<CategoryNames, System.Int32> val_2 = new System.Collections.Generic.Dictionary<CategoryNames, System.Int32>(comparer:  new 丟丗丒丏丈不丌专一());
            if(val_2 != null)
            {
                    val_2.Add(key:  0, value:  0);
            }
            else
            {
                    val_2.Add(key:  0, value:  0);
            }
            
            val_2.Add(key:  80, value:  1);
            this.丞丙丛七世且丞丙丆 = val_2;
        }
        private static 丂丂丑上丁丌业丑丈()
        {
            Progress.丂丂丑上丁丌业丑丈.丕丟一七丑丙丂丆丙 = "BRV_slot";
            Progress.丂丂丑上丁丌业丑丈.丐丌丞上世丛丐丏丛 = "BRV_Slot_Key_2019";
        }
    
    }

}
