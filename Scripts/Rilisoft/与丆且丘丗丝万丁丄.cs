using UnityEngine;

namespace Rilisoft
{
    public class 与丆且丘丗丝万丁丄 : 上专业三丟丁丞专下
    {
        // Properties
        internal override 丈丞丕丘丕丗与上一 业丏丌丌丝东丌世丑 { get; }
        public override System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 下丂丟世丐与丆东业 { get; }
        
        // Methods
        internal override 丈丞丕丘丕丗与上一 丆一丘万丁上丒丏三()
        {
            if(this.丁专丗万三上丟三丆() != null)
            {
                    return (丈丞丕丘丕丗与上一)val_1.OpenPrice;
            }
            
            return (丈丞丕丘丕丗与上一)val_1.OpenPrice;
        }
        public override System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 一不丄七丘丕丞丑丏()
        {
            var val_6;
            System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_8;
            val_6 = null;
            val_6 = null;
            val_8 = 与丆且丘丗丝万丁丄.<>c.<>9__3_0;
            if(val_8 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainer, System.Boolean> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  与丆且丘丗丝万丁丄.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 与丆且丘丗丝万丁丄.<>c::丝丑与业丑且丗上丁(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
                与丆且丘丗丝万丁丄.<>c.<>9__3_0 = val_8;
            }
            
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItemContainer>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItemContainer>(source:  this.业业世七丛丌业丙丅(), predicate:  val_2));
            val_4.Sort(comparison:  new System.Comparison<Rilisoft.GameEventItemContainer>(object:  0, method:  static System.Int32 Rilisoft.丛且世丐丆上七业丁::不丙丝下与丞业不丒(Rilisoft.GameEventItemContainer 丏丆丑丗七丄丙丝与, Rilisoft.GameEventItemContainer 丒丈丙丐丏丕丆万丗)));
            return (System.Collections.Generic.List<Rilisoft.GameEventItemContainer>)val_4;
        }
        public override void 丑七丂丌世与七丏与(Rilisoft.GameEventChestData 丄丌丟东专业丗丟丆, string 丟丟丄专上丟丁丐丝, int 丅且三万丘丙业丙丗)
        {
            this.丑七丂丌世与七丏与(丄丌丟东专业丗丟丆:  丄丌丟东专业丗丟丆, 丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丅且三万丘丙业丙丗:  丅且三万丘丙业丙丗);
        }
        public 与丆且丘丗丝万丁丄()
        {
        
        }
    
    }

}
