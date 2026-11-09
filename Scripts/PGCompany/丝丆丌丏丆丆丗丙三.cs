using UnityEngine;

namespace PGCompany
{
    internal abstract class 丝丆丌丏丆丆丗丙三 : 专丗上丌丗与丞下丄
    {
        // Fields
        protected string 丈丏丈丌且世丗不丌;
        protected System.Collections.Generic.List<TagSystem.CompoundTagBehaviour> 丟世丆丒丟丟丌丘丅;
        
        // Properties
        protected System.Collections.Generic.List<TagSystem.CompoundTagBehaviour> 丞业七丈丙丝东与丌 { get; }
        
        // Methods
        internal 丝丆丌丏丆丆丗丙三(string 丝三丗万丞丁丄丌一)
        {
            this.丟世丆丒丟丟丌丘丅 = new System.Collections.Generic.List<TagSystem.CompoundTagBehaviour>();
            this.丈丏丈丌且世丗不丌 = 丝三丗万丞丁丄丌一;
        }
        protected abstract void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗); // 0
        protected abstract void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗); // 0
        internal override void 三丑丛丄万丟丄丞丁()
        {
            var val_7;
            TagSystem.CompoundTagBehaviour.不世丏一丕一丅丒东(丙业与丙丗丝不丈东:  new System.Action<TagSystem.CompoundTagBehaviour>(object:  this, method:  System.Void PGCompany.丝丆丌丏丆丆丗丙三::丌世下上且世丄万丆(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)));
            System.Action<TagSystem.CompoundTagBehaviour> val_2 = new System.Action<TagSystem.CompoundTagBehaviour>(object:  this, method:  typeof(PGCompany.丝丆丌丏丆丆丗丙三).__il2cppRuntimeField_1B0);
            TagSystem.CompoundTagBehaviour.丙丁世丟丁丐丞万丝(丙业与丙丗丝不丈东:  null);
            TagSystem.CompoundTagBehaviour.丌专丂万一丒丐上丛(丙业与丙丗丝不丈东:  new System.Action<TagSystem.三与下丘七丘丌丏丄, TagSystem.CompoundTagBehaviour>(object:  this, method:  System.Void PGCompany.丝丆丌丏丆丆丗丙三::专专丒丏丅不丟丝丆(TagSystem.三与下丘七丘丌丏丄 丆丗丆丕不丌丁与丞, TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)));
            List.Enumerator<T> val_5 = this.丒一丗下且丁业下丁().GetEnumerator();
            label_11:
            if(((-81157040) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if((val_8.gameObject == 0) || (val_8.gameObject.activeSelf == false))
            {
                goto label_11;
            }
            
            this.丞丆专万万专与丏丆(丛丑业万丗丝丒三丗:  val_8);
            goto label_11;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override void 丌丄丏下七丁专丂世()
        {
            TagSystem.CompoundTagBehaviour.丏且业丒不丝丗专丂(丙业与丙丗丝不丈东:  new System.Action<TagSystem.CompoundTagBehaviour>(object:  this, method:  System.Void PGCompany.丝丆丌丏丆丆丗丙三::丌世下上且世丄万丆(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)));
            System.Action<TagSystem.CompoundTagBehaviour> val_2 = new System.Action<TagSystem.CompoundTagBehaviour>(object:  this, method:  typeof(PGCompany.丝丆丌丏丆丆丗丙三).__il2cppRuntimeField_1B0);
            TagSystem.CompoundTagBehaviour.丛丑丁业万上丁丘丌(丙业与丙丗丝不丈东:  null);
            TagSystem.CompoundTagBehaviour.七丗万东丞三东丆三(丙业与丙丗丝不丈东:  new System.Action<TagSystem.三与下丘七丘丌丏丄, TagSystem.CompoundTagBehaviour>(object:  this, method:  System.Void PGCompany.丝丆丌丏丆丆丗丙三::专专丒丏丅不丟丝丆(TagSystem.三与下丘七丘丌丏丄 丆丗丆丕不丌丁与丞, TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)));
            if(this.丟世丆丒丟丟丌丘丅.Count < 1)
            {
                    return;
            }
            
            System.Linq.Enumerable.ToList<TagSystem.CompoundTagBehaviour>(source:  this.丟世丆丒丟丟丌丘丅).ForEach(action:  new System.Action<TagSystem.CompoundTagBehaviour>(object:  this, method:  System.Void PGCompany.丝丆丌丏丆丆丗丙三::丆且丞下七丁东与且(TagSystem.CompoundTagBehaviour 丅丆东丏丙丝丅丆丟)));
        }
        private void 丞丆专万万专与丏丆(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            this.丟世丆丒丟丟丌丘丅.Add(item:  丛丑业万丗丝丒三丗);
            goto typeof(PGCompany.丝丆丌丏丆丆丗丙三).__il2cppRuntimeField_188;
        }
        private void 丄专东丆丐丁丑不丌(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            bool val_1 = this.丟世丆丒丟丟丌丘丅.Remove(item:  丛丑业万丗丝丒三丗);
            goto typeof(PGCompany.丝丆丌丏丆丆丗丙三).__il2cppRuntimeField_198;
        }
        private void 丌世下上且世丄万丆(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if((丛丑业万丗丝丒三丗.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌)) == false)
            {
                    return;
            }
            
            this.丞丆专万万专与丏丆(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
        }
        protected virtual void 丏丒上七丟七丁世万(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if((丛丑业万丗丝丒三丗.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌)) == false)
            {
                    return;
            }
            
            this.丄专东丆丐丁丑不丌(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
        }
        private void 专专丒丏丅不丟丝丆(TagSystem.三与下丘七丘丌丏丄 丆丗丆丕不丌丁与丞, TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            TagSystem.三与下丘七丘丌丏丄 val_7 = 丆丗丆丕不丌丁与丞;
            if((val_7.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌)) != false)
            {
                    if((丛丑业万丗丝丒三丗.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌)) == false)
            {
                goto label_4;
            }
            
            }
            
            if((val_7.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌)) == true)
            {
                    return;
            }
            
            val_7 = this.丈丏丈丌且世丗不丌;
            if((丛丑业万丗丝丒三丗.丐丂丒丅上与丂丗且().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  val_7)) == false)
            {
                    return;
            }
            
            this.丞丆专万万专与丏丆(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
            return;
            label_4:
            this.丄专东丆丐丁丑不丌(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
        }
        protected System.Collections.Generic.List<TagSystem.CompoundTagBehaviour> 丒一丗下且丁业下丁()
        {
            TagSystem.丐丝丙不丛丞丏丌丏 val_1 = TagSystem.丐丝丙不丛丞丏丌丏.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.不丄丑东丈丅上丌业(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌);
            }
            
            return val_1.不丄丑东丈丅上丌业(丆万一不丌且东丐丐:  this.丈丏丈丌且世丗不丌);
        }
        private void 丆且丞下七丁东与且(TagSystem.CompoundTagBehaviour 丅丆东丏丙丝丅丆丟)
        {
            this.丄专东丆丐丁丑不丌(丛丑业万丗丝丒三丗:  丅丆东丏丙丝丅丆丟);
        }
    
    }

}
