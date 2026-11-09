using UnityEngine;

namespace Rilisoft
{
    internal sealed class 世与丛一丕丄丗丈丅 : IDisposable
    {
        // Fields
        private static Rilisoft.世与丛一丕丄丗丈丅 丝业丆丁业三丈丟东;
        private UnityEngine.Coroutine 丄三丗一与丈丁丅丐;
        private bool 丁丟世丁一下丂与一;
        
        // Properties
        internal static Rilisoft.世与丛一丕丄丗丈丅 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static Rilisoft.世与丛一丕丄丗丈丅 丑七不且上丗丁一世()
        {
            Rilisoft.世与丛一丕丄丗丈丅 val_2 = Rilisoft.世与丛一丕丄丗丈丅.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Rilisoft.世与丛一丕丄丗丈丅 val_1 = null;
            val_2 = val_1;
            val_1 = new Rilisoft.世与丛一丕丄丗丈丅();
            Rilisoft.世与丛一丕丄丗丈丅.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal void 下丌业业丐丘丐丘三()
        {
            MainMenuController.三丟丗七三丛丅丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.世与丛一丕丄丗丈丅::七丞丘丞与丐与丁丝()));
        }
        private void 万不丒上丕丗丂丘丒()
        {
            MainMenuController.三丟丗七三丛丅丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.世与丛一丕丄丗丈丅::七丞丘丞与丐与丁丝()));
        }
        public void Dispose()
        {
            this.万不丒上丕丗丂丘丒();
        }
        internal void 丏丁专丑丌丑一丂丞(丈下专丂丑不丑丗丁 业七丄丄丘上丌不上, System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丞丈丁与丏丌丌丆丂)
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_2 = 丞丈丁与丏丌丌丆丂.GetEnumerator();
            label_5:
            if(((-562811064) & 1) == 0)
            {
                goto label_2;
            }
            
            val_1.Add(item:  0.丐丏七丌丕丗业且上().丑丐丙丄丅世世丑丒());
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丏丁专丑丌丑一丂丞(业七丄丄丘上丌不上:  5, 丞丈丁与丏丌丌丆丂:  val_1);
        }
        internal void 丏丁专丑丌丑一丂丞(丈下专丂丑不丑丗丁 业七丄丄丘上丌不上, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丞丈丁与丏丌丌丆丂)
        {
            this.丁丟世丁一下丂与一 = false;
            if(this.丄三丗一与丈丁丅丐 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丄三丗一与丈丁丅丐);
            }
            
            if(丞丈丁与丏丌丌丆丂.Count == 0)
            {
                    return;
            }
            
            this.丄三丗一与丈丁丅丐 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.不丁丝丕丘七丙丏丌(业七丄丄丘上丌不上:  业七丄丄丘上丌不上, 丞丈丁与丏丌丌丆丂:  丞丈丁与丏丌丌丆丂));
            PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().三丅丐丕东丛上丁丏(且丒丛与丞世丙丕丌:  业七丄丄丘上丌不上);
        }
        private System.Collections.IEnumerator 不丁丝丕丘七丙丏丌(丈下专丂丑不丑丗丁 业七丄丄丘上丌不上, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丞丈丁与丏丌丌丆丂)
        {
            世与丛一丕丄丗丈丅.丛丌不丂丘丛万与万 val_1 = new 世与丛一丕丄丗丈丅.丛丌不丂丘丛万与万();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .业七丄丄丘上丌不上 = 业七丄丄丘上丌不上;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 业七丄丄丘上丌不上;
            }
            
            .丞丈丁与丏丌丌丆丂 = 丞丈丁与丏丌丌丆丂;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丒丟丞丅丟丘丄丞丈(PGCompany.三东丏不丗世丅丌丄 丄业丏丙且丞业上东, 丈下专丂丑不丑丗丁 业七丄丄丘上丌不上)
        {
            世与丛一丕丄丗丈丅.丑与世丝丒与且丞丞 val_1 = new 世与丛一丕丄丗丈丅.丑与世丝丒与且丞丞();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丄业丏丙且丞业上东 = 丄业丏丙且丞业上东;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丐丗上丞业丕丟丏丕()
        {
            this.丁丟世丁一下丂与一 = false;
        }
        private void 七丞丘丞与丐与丁丝()
        {
        
        }
        public 世与丛一丕丄丗丈丅()
        {
        
        }
    
    }

}
