using UnityEngine;

namespace PGCompany
{
    internal sealed class 不丁下丈专丈东世下 : 丗丟丄丈东丝丕丄世
    {
        // Fields
        private Rilisoft.丏丘七丞丄丙丌丞丁 世丒丂且与三丁丙世;
        
        // Properties
        internal Rilisoft.丏丘七丞丄丙丌丞丁 丏丘七丞丄丙丌丞丁 { get; }
        
        // Methods
        internal Rilisoft.丏丘七丞丄丙丌丞丁 东上专丑丏丞上丞丐()
        {
            if(this.世丒丂且与三丁丙世 != null)
            {
                    return val_4;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean PGCompany.不丁下丈专丈东世下::丒丏与三万丁业丑下(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
            this.世丒丂且与三丁丙世 = val_4;
            return val_4;
        }
        public 不丁下丈专丈东世下(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override string 七业丑不七丐业丟丂()
        {
            int val_4;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_1 = this.东上专丑丏丞上丞丐();
            if(val_1 != null)
            {
                    val_4 = val_1.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐();
                if(val_4 != null)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4 = System.String.alignConst);
            }
            
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            int val_4;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_1 = this.东上专丑丏丞上丞丐();
            if(val_1 != null)
            {
                    val_4 = val_1.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐();
                if(val_4 != null)
            {
                    return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_4 = System.String.alignConst);
            }
            
            }
            
            return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_4);
        }
        internal override string 东且丏丆万与东丙万()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3398");
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            if(this.东上专丑丏丞上丞丐() == null)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.丙三专万丛丟万丝丘());
            }
            
            this = this.东上专丑丏丞上丞丐();
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.丙三专万丛丟万丝丘());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return 0;
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            Rilisoft.丏丘七丞丄丙丌丞丁 val_1 = this.东上专丑丏丞上丞丐();
            if(val_1 == null)
            {
                    return (丈丞丕丘丕丗与上一)val_1;
            }
            
            丕专丟上与丄丈三丏 val_2 = val_1.丙丕丞且丕不丘丙丑();
            if(val_2 != null)
            {
                    return val_2.丞丅世丄业丗丄丄丈();
            }
            
            return val_2.丞丅世丄业丗丄丄丈();
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.不丁下丈专丈东世下(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private bool 丒丏与三万丁业丑下(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
        {
            return System.String.op_Equality(a:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七(), b:  this.业上丙丞丐丄丆丅七());
        }
    
    }

}
