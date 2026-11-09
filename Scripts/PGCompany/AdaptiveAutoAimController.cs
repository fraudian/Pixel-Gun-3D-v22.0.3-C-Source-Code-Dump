using UnityEngine;

namespace PGCompany
{
    internal sealed class AdaptiveAutoAimController : PGBehaviour
    {
        // Fields
        private static System.Action 丂丛丗丏丟丁三万不;
        internal static readonly string 丅丂与丟上丏丆丆不;
        internal static readonly string 东丘丈下丗三丙丏丏;
        internal static readonly string 丅业丏且一丒丐丌与;
        private static PGCompany.AdaptiveAutoAimController 丝业丆丁业三丈丟东;
        private PGCompany.AdaptiveAutoAimConfig 世丂上丌丞且丁七丏;
        private System.Collections.Generic.Dictionary<PGCompany.下三三丈与丁丈丒丛, float> 世丂丁且丁丂丐与丁;
        private int <丄专万且专丌且丁丟>k__BackingField;
        private int <丐东与下丐丆专不丒>k__BackingField;
        private UnityEngine.Coroutine 丈丝丏专上丈丘丑与;
        
        // Properties
        internal static PGCompany.AdaptiveAutoAimController 丆丕丝丒不丙且丐丗 { get; }
        internal int 不丒三丂不三丟丁丐 { get; set; }
        internal int 且丛丏丁丙下丒业一 { get; set; }
        
        // Methods
        internal static void 上丒丕丄上七丗丆且(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  PGCompany.AdaptiveAutoAimController.丂丛丗丏丟丁三万不, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 上丑丐七与三丟与丙(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  PGCompany.AdaptiveAutoAimController.丂丛丗丏丟丁三万不, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static PGCompany.AdaptiveAutoAimController 丑七不且上丗丁一世()
        {
            var val_4;
            PGCompany.AdaptiveAutoAimController val_5;
            var val_6;
            val_4 = null;
            val_4 = null;
            val_5 = PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东;
            if(val_5 == 0)
            {
                    val_6 = null;
                val_5 = new UnityEngine.GameObject(name:  "AdaptiveAutoAimController").AddComponent<PGCompany.AdaptiveAutoAimController>();
                val_6 = null;
                PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东 = val_5;
            }
            else
            {
                    val_6 = null;
            }
            
            val_6 = null;
            return (PGCompany.AdaptiveAutoAimController)PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东;
        }
        internal static float 丅业专丏不丒丄丐一(PGCompany.下三三丈与丁丈丒丛 丄丒丗丟世丘万丙丟)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东 == 0)
            {
                    return 0f;
            }
            
            val_3 = null;
            val_3 = null;
            if(PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东 != null)
            {
                    return PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东.上专丘丕丂丌丏七丅(丄丒丗丟世丘万丙丟:  丄丒丗丟世丘万丙丟);
            }
            
            return PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东.上专丘丕丂丌丏七丅(丄丒丗丟世丘万丙丟:  丄丒丗丟世丘万丙丟);
        }
        internal int 且专世丈三丝业一一()
        {
            return (int)this.<丄专万且专丌且丁丟>k__BackingField;
        }
        private void 且丞丑丂丟丗丐丗下(int 丙业与丙丗丝不丈东)
        {
            this.<丄专万且专丌且丁丟>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丅丙三丘丗丗世丙东()
        {
            return (int)this.<丐东与下丐丆专不丒>k__BackingField;
        }
        private void 丗丙且丒丌丐业不丂(int 丙业与丙丗丝不丈东)
        {
            this.<丐东与下丐丆专不丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private float 上专丘丕丂丌丏七丅(PGCompany.下三三丈与丁丈丒丛 丄丒丗丟世丘万丙丟)
        {
            if((this.世丂丁且丁丂丐与丁.ContainsKey(key:  丄丒丗丟世丘万丙丟)) == false)
            {
                    return 0f;
            }
            
            if(this.世丂丁且丁丂丐与丁 != null)
            {
                    return this.世丂丁且丁丂丐与丁.Item[丄丒丗丟世丘万丙丟];
            }
            
            return this.世丂丁且丁丂丐与丁.Item[丄丒丗丟世丘万丙丟];
        }
        private void Awake()
        {
            null = null;
            PGCompany.AdaptiveAutoAimController.丝业丆丁业三丈丟东 = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.丅与丌专丟一丝业三());
            this.丛且丐下世与丘丆丗();
            this.且丛一三业丈丝丞丅();
        }
        private void OnDestroy()
        {
            this.万与七三丄丁丏世丘();
        }
        private void 丛且丐下世与丘丆丗()
        {
            System.Action val_10;
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            val_10 = System.Delegate.Combine(a:  val_3.不丝七丕丐与与上丕, b:  new System.Action(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::丙丈丕丈东专不丏业()));
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世() == null)
            {
                goto label_3;
            }
            
            if(val_10 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_10 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_7:
            val_3.不丝七丕丐与与上丕 = val_10;
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::与东丆丆丘丕丏专业(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            PGCompany.丗丝万丏世丛丈丏丕.不七专丙丘丌七丗丂(丙业与丙丗丝不丈东:  new System.Action<System.DateTime, System.Decimal>(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::世丌丅丗业丝丐与丁(System.DateTime 丛丆东与丑丞丅丝专, decimal 不丁丌丐业丑丟且不)));
        }
        private void 万与七三丄丁丏世丘()
        {
            System.Action val_10;
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            val_10 = System.Delegate.Remove(source:  val_3.不丝七丕丐与与上丕, value:  new System.Action(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::丙丈丕丈东专不丏业()));
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世() == null)
            {
                goto label_3;
            }
            
            if(val_10 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_10 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_7:
            val_3.不丝七丕丐与与上丕 = val_10;
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::与东丆丆丘丕丏专业(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
            PGCompany.丗丝万丏世丛丈丏丕.丗世丑丏三丛丌一丂(丙业与丙丗丝不丈东:  new System.Action<System.DateTime, System.Decimal>(object:  this, method:  System.Void PGCompany.AdaptiveAutoAimController::世丌丅丗业丝丐与丁(System.DateTime 丛丆东与丑丞丅丝专, decimal 不丁丌丐业丑丟且不)));
        }
        private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 79)
            {
                    return;
            }
            
            this.且丛一三业丈丝丞丅();
        }
        private void 且丛一三业丈丝丞丅()
        {
            this.丛不丄与丅丘丙丁与(丛七丅东丒丅丘不业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  79));
        }
        private void 丛不丄与丅丘丙丁与(string 丛七丅东丒丅丘不业)
        {
            this.世丂上丌丞且丁七丏 = 0;
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.世丂上丌丞且丁七丏 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            this.丙丈丕丈东专不丏业();
        }
        private void 丙丈丕丈东专不丏业()
        {
            if(this.丈丝丏专上丈丘丑与 != null)
            {
                    this.StopCoroutine(routine:  this.丈丝丏专上丈丘丑与);
            }
            
            this.丈丝丏专上丈丘丑与 = this.StartCoroutine(routine:  this.不三丙丘一丟丕一一());
        }
        private System.Collections.IEnumerator 不三丙丘一丟丕一一()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AdaptiveAutoAimController.专丐与下丘丗丑丄专(丗丏丅丕丆世丁专丟:  0);
        }
        private void 与东丆丆丘丕丏专业(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丙丈丕丈东专不丏业();
        }
        private void 世丌丅丗业丝丐与丁(System.DateTime 丛丆东与丑丞丅丝专, decimal 不丁丌丐业丑丟且不)
        {
            this.丙丈丕丈东专不丏业();
        }
        private void 世丝丐七丕世丈丒丌()
        {
            this.世丂丁且丁丂丐与丁.Clear();
        }
        private float 七丒丗业丆丏业业丕()
        {
            decimal val_2 = Rilisoft.Singleton<KillrateController>.Instance.丙丝与丝万丞七丌与(一丑丗三一丛一丄业:  30);
            return System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
        }
        public AdaptiveAutoAimController()
        {
            this.世丂丁且丁丂丐与丁 = new System.Collections.Generic.Dictionary<PGCompany.下三三丈与丁丈丒丛, System.Single>();
            this = new Photon.MonoBehaviour();
        }
        private static AdaptiveAutoAimController()
        {
            PGCompany.AdaptiveAutoAimController.丅丂与丟上丏丆丆不 = "Adapt_iveAut_oAimEna_bledStora_geKey";
            PGCompany.AdaptiveAutoAimController.东丘丈下丗三丙丏丏 = "Adapti_veAutoA_imKil_lRateSto_rageKey";
            PGCompany.AdaptiveAutoAimController.丅业丏且一丒丐丌与 = "Ada_ptiveA_utoAimTi_meLeftS_torageK_ey";
        }
    
    }

}
