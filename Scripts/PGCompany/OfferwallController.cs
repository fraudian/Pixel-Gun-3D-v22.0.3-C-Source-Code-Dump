using UnityEngine;

namespace PGCompany
{
    internal sealed class OfferwallController : MonoBehaviour
    {
        // Fields
        private const int 业专丙世丝与三业专 = 5;
        private const string 七丆丗丈丏下万不丕 = "LastTimeShownOfferwall";
        private static PGCompany.OfferwallController 世丒丞七专三与万丕;
        internal static System.Action 丒丈东上专专丐一丄;
        private PGCompany.OfferwallController.业世下丐丕丘上下三 东万丐万丈与世东丂;
        private PGCompany.OfferwallController.业世下丐丕丘上下三 丈丙七丕丒上丑丏且;
        private int 丂三万且丈丌丁丄不;
        private bool <丘东丗丑丑丂丌丑七>k__BackingField;
        private bool <丗丄丛丙业东丄专丑>k__BackingField;
        
        // Properties
        internal static PGCompany.OfferwallController 丆丕丝丒不丙且丐丗 { get; }
        internal static bool 七三东丑业世上丏不 { get; }
        private static bool 丆丌不丁东一一丞丟 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        private PGCompany.OfferwallController.业世下丐丕丘上下三 丛丟丄世丌丑世丅上 { get; set; }
        private PGCompany.OfferwallController.业世下丐丕丘上下三 丞七与七上东丈丑且 { get; set; }
        internal bool 丘丆上丄丙世专丑丙 { get; set; }
        internal bool 且丟丛不不丆七丕丙 { get; set; }
        
        // Methods
        internal static PGCompany.OfferwallController 丑七不且上丗丁一世()
        {
            return (PGCompany.OfferwallController)PGCompany.OfferwallController.世丒丞七专三与万丕;
        }
        internal static bool 专且丗丅丙丆业丈丁()
        {
            PGCompany.OfferwallController val_3;
            var val_4;
            val_3 = PGCompany.OfferwallController.世丒丞七专三与万丕;
            if(val_3 == 0)
            {
                    val_4 = 0;
                return (bool)((PGCompany.OfferwallController.世丒丞七专三与万丕.<丗丄丛丙业东丄专丑>k__BackingField) == true) ? 1 : 0;
            }
            
            val_3 = PGCompany.OfferwallController.世丒丞七专三与万丕;
            if((PGCompany.OfferwallController.世丒丞七专三与万丕.<丘东丗丑丑丂丌丑七>k__BackingField) != false)
            {
                    val_4 = 1;
                return (bool)((PGCompany.OfferwallController.世丒丞七专三与万丕.<丗丄丛丙业东丄专丑>k__BackingField) == true) ? 1 : 0;
            }
            
            val_3 = PGCompany.OfferwallController.世丒丞七专三与万丕;
            return (bool)((PGCompany.OfferwallController.世丒丞七专三与万丕.<丗丄丛丙业东丄专丑>k__BackingField) == true) ? 1 : 0;
        }
        private static bool 丑与丝下专丄且业丄()
        {
            return false;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private PGCompany.OfferwallController.业世下丐丕丘上下三 上丒上不丄丙世丛世()
        {
            return (业世下丐丕丘上下三)this.丈丙七丕丒上丑丏且;
        }
        private void 丙不专上丛丌丆丏丏(PGCompany.OfferwallController.业世下丐丕丘上下三 丙业与丙丗丝不丈东)
        {
            this.丈丙七丕丒上丑丏且 = 丙业与丙丗丝不丈东;
            if(this.丈丙七丕丒上丑丏且 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丈丙七丕丒上丑丏且.Dispose();
        }
        private PGCompany.OfferwallController.业世下丐丕丘上下三 丝丁丟丌丞不七万业()
        {
            return (业世下丐丕丘上下三)this.东万丐万丈与世东丂;
        }
        private void 丒丈丗且世三丞丟东(PGCompany.OfferwallController.业世下丐丕丘上下三 丙业与丙丗丝不丈东)
        {
            this.东万丐万丈与世东丂 = 丙业与丙丗丝不丈东;
            if(this.东万丐万丈与世东丂 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东万丐万丈与世东丂.Dispose();
        }
        internal bool 丞一丕一不丑丐丆丁()
        {
            return (bool)this.<丘东丗丑丑丂丌丑七>k__BackingField;
        }
        private void 专万丙丝业丑下丗丂(bool 丙业与丙丗丝不丈东)
        {
            this.<丘东丗丑丑丂丌丑七>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 东丘专丒丅业三丈世()
        {
            return (bool)this.<丗丄丛丙业东丄专丑>k__BackingField;
        }
        private void 世丙丗丛专丅丛丐丛(bool 丙业与丙丗丝不丈东)
        {
            this.<丗丄丛丙业东丄专丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丛不丗三丈丘与与丝()
        {
            PGCompany.OfferwallController.且丛上七丘万丆上丂();
        }
        private static void 丌丑丄七丒丏丛与丛()
        {
            PGCompany.OfferwallController.且丂丗丁丟丐一丌一();
        }
        internal static bool 不下世丝专一且业丏(out string 丏丞专丏业丗丝七丝)
        {
            string val_15;
            丆与丝上下万下丁世 val_4 = 0;
            string val_9 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丆丁丕丅专与丟东丕(上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  val_4, 丏丞专丏业丗丝七丝: out  string val_5 = 丏丞专丏业丗丝七丝)) == false)
            {
                goto label_4;
            }
            
            if((PGCompany.DataObjects.万丌丏丕丄丏丄七丅.丐丅且丗东丘上与丏(丟丐丗万丅下丗丝万:  val_4)) == false)
            {
                goto label_5;
            }
            
            if((PGCompany.Offerwall.丑丟专一丑丆一丒丙.丑七不且上丗丁一世().下丆与与丛丕丄丌丕(丙业与丙丗丝不丈东: out  val_9)) == false)
            {
                goto label_8;
            }
            
            if((PGCompany.丄丙与丄丛丒丟下丛.东一万丈丘业丂丂丑(丌丏不下一与丛丙丝:  val_9, 丙业与丙丗丝不丈东: out  new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false})) == false)
            {
                goto label_8;
            }
            
            val_15 = val_9;
            goto label_9;
            label_4:
            val_15 = 0;
            return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_15 = 0, 丄丙下丝丛丒七丂丘: out  val_5);
            label_5:
            val_15 = "IsEnabled: false";
            label_9:
            bool val_12 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_15, 丄丙下丝丛丒七丂丘: out  val_5);
            return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_15, 丄丙下丝丛丒七丂丘: out  val_5);
            label_8:
            PGCompany.OfferwallController.且丂丗丁丟丐一丌一();
            return (bool)PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_15, 丄丙下丝丛丒七丂丘: out  val_5);
        }
        internal static int 丙下丅七万丐与丌丁()
        {
            var val_8;
            丆与丝上下万下丁世 val_4 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丆丁丕丅专与丟东丕(上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  val_4, 丏丞专丏业丗丝七丝: out  0)) != false)
            {
                    if((PGCompany.DataObjects.万丌丏丕丄丏丄七丅.丐丅且丗东丘上与丏(丟丐丗万丅下丗丝万:  val_4)) != false)
            {
                    val_8 = val_4 + 44;
                return 5;
            }
            
            }
            
            val_8 = 5;
            return 5;
        }
        private void 丑不专丗丏世丅丂丗(bool 丛丅丘一丏丙且丌上)
        {
            bool val_1 = 丛丅丘一丏丙且丌上;
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  System.String.Format(format:  "[OfferwallController.SetBannerActive] active: {0}", arg0:  val_1));
            }
            
            this.<丘东丗丑丑丂丌丑七>k__BackingField = val_1;
            if(PGCompany.OfferwallController.丒丈东上专专丐一丄 == null)
            {
                    return;
            }
            
            PGCompany.OfferwallController.丒丈东上专专丐一丄.Invoke();
        }
        private void 丐丐丗丁东与丒丈丏(bool 丛丅丘一丏丙且丌上)
        {
            bool val_1 = 丛丅丘一丏丙且丌上;
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  System.String.Format(format:  "[OfferwallController.SetIconActive] active: {0}", arg0:  val_1));
            }
            
            this.<丗丄丛丙业东丄专丑>k__BackingField = val_1;
            if(PGCompany.OfferwallController.丒丈东上专专丐一丄 == null)
            {
                    return;
            }
            
            PGCompany.OfferwallController.丒丈东上专专丐一丄.Invoke();
        }
        private bool 丈丑丈三且且且下丌()
        {
            string val_21;
            var val_22;
            string val_7 = 0;
            string val_3 = 0;
            string val_15 = 0;
            string val_10 = 0;
            string val_17 = 0;
            丆与丝上下万下丁世 val_16 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != true)
            {
                    if((PGCompany.Offerwall.丙不三丁一丏丐丆与.丑七不且上丗丁一世().丝丂专上且丄专丏且(丏丞专丏业丗丝七丝: out  val_3)) == false)
            {
                goto label_3;
            }
            
            }
            
            if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
            {
                goto label_7;
            }
            
            if((PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_7)) == false)
            {
                goto label_8;
            }
            
            if((PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世().丌丂丄丑丞丆上丐丘(丐丟一丗丒丟且丂上: out  val_10)) == false)
            {
                goto label_10;
            }
            
            if((System.String.op_Inequality(a:  val_7, b:  val_10)) == false)
            {
                goto label_11;
            }
            
            val_21 = "userId != initialUserId";
            goto label_15;
            label_7:
            val_21 = "IsAuthorized: false";
            goto label_15;
            label_3:
            val_22 = val_3;
            goto label_21;
            label_8:
            val_21 = "TryGetId: false";
            goto label_15;
            label_10:
            val_21 = "TryGetInitialUserId: false";
            label_15:
            label_21:
            this.丌丌一世丏丟丅且丁(丁丂丕与丁丒丕丟丞:  val_21);
            this.丅不丌丒丁丂与丑上(丁丂丕与丁丒丕丟丞:  val_21);
            return false;
            label_11:
            bool val_18 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丆丁丕丅专与丟东丕(上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  val_15, 丟丐丗万丅下丗丝万: out  val_16, 丏丞专丏业丗丝七丝: out  val_17);
            bool val_19 = System.String.IsNullOrEmpty(value:  val_17);
            if(val_19 == false)
            {
                goto label_21;
            }
            
            if((val_19.丒丞丞丏丐七丑丈与(丟丐丗万丅下丗丝万:  val_16, 丁丂丕与丁丒丕丟丞: out  val_17)) == false)
            {
                goto label_20;
            }
            
            goto label_21;
            label_20:
            this.丕丟七丝丌丑丘业丄(丟丐丗万丅下丗丝万:  val_16, 七丆丒与丗丌丄且丂:  val_15);
            this.万丒七丗丐世上丙丒(丟丐丗万丅下丗丝万:  val_16, 七丆丒与丗丌丄且丂:  val_15);
            return false;
        }
        private bool 丒丞丞丏丐七丑丈与(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丆与丝上下万下丁世 丟丐丗万丅下丗丝万, out string 丁丂丕与丁丒丕丟丞)
        {
            string val_4;
            if(丟丐丗万丅下丗丝万 == null)
            {
                goto label_1;
            }
            
            if((PGCompany.DataObjects.万丌丏丕丄丏丄七丅.丐丅且丗东丘上与丏(丟丐丗万丅下丗丝万:  丟丐丗万丅下丗丝万)) == false)
            {
                goto label_2;
            }
            
            if((PGCompany.OfferwallController.丆丕丝七丞丐丘丆丙(丟丐丗万丅下丗丝万:  丟丐丗万丅下丗丝万)) == false)
            {
                goto label_3;
            }
            
            val_4 = "IsDisableByLevel";
            goto label_6;
            label_1:
            val_4 = "effectiveSettings";
            goto label_6;
            label_2:
            val_4 = "IsEnabled";
            goto label_6;
            label_3:
            if((PGCompany.OfferwallController.丒世丙业丕丏丆丙一(丟丐丗万丅下丗丝万:  丟丐丗万丅下丗丝万)) == false)
            {
                goto label_8;
            }
            
            val_4 = "IsDisabledByNonPayingPeriod";
            label_6:
            label_8:
            丁丂丕与丁丒丕丟丞 = val_4;
            return true;
        }
        private void 丕丟七丝丌丑丘业丄(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丆与丝上下万下丁世 丟丐丗万丅下丗丝万, string 七丆丒与丗丌丄且丂)
        {
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallController.SelectRotationStateThenTransit] category: "("[OfferwallController.SelectRotationStateThenTransit] category: ") + 七丆丒与丗丌丄且丂);
            }
            
            this.丌丌一世丏丟丅且丁(丁丂丕与丁丒丕丟丞:  "enabledInRotation: false");
        }
        private void 万丒七丗丐世上丙丒(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丆与丝上下万下丁世 丟丐丗万丅下丗丝万, string 七丆丒与丗丌丄且丂)
        {
            string val_4 = 七丆丒与丗丌丄且丂;
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    val_4 = "[OfferwallController.SelectIconStateThenTransit] category: "("[OfferwallController.SelectIconStateThenTransit] category: ") + val_4;
                UnityEngine.Debug.Log(message:  val_4);
            }
            
            if(丟丐丗万丅下丗丝万.enabledIcon.GetValueOrDefault() != false)
            {
                    this.丙丏一丈丗丛专且丌();
                return;
            }
            
            this.丅不丌丒丁丂与丑上(丁丂丕与丁丒丕丟丞:  "enabledIcon: false");
        }
        private void 丌丌一世丏丟丅且丁(string 丁丂丕与丁丒丕丟丞)
        {
            if(this.丈丙七丕丒上丑丏且 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            this.丑不专丗丏世丅丂丗(丛丅丘一丏丙且丌上:  false);
            this.丙不专上丛丌丆丏丏(丙业与丙丗丝不丈东:  new OfferwallController.下丝丒东丟丂一七世(丁丂丕与丁丒丕丟丞:  丁丂丕与丁丒丕丟丞));
            return;
            label_2:
            bool val_2 = this.丈丙七丕丒上丑丏且.三丅东一万丐东上丏(丁丂丕与丁丒丕丟丞:  丁丂丕与丁丒丕丟丞);
        }
        private void 丅不丌丒丁丂与丑上(string 丁丂丕与丁丒丕丟丞)
        {
            if(this.东万丐万丈与世东丂 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            this.丐丐丗丁东与丒丈丏(丛丅丘一丏丙且丌上:  false);
            this.丒丈丗且世三丞丟东(丙业与丙丗丝不丈东:  new OfferwallController.下丝丒东丟丂一七世(丁丂丕与丁丒丕丟丞:  丁丂丕与丁丒丕丟丞));
            return;
            label_2:
            bool val_2 = this.东万丐万丈与世东丂.三丅东一万丐东上丏(丁丂丕与丁丒丕丟丞:  丁丂丕与丁丒丕丟丞);
        }
        private void 且丈七丑丛丁东与七()
        {
            if(this.丈丙七丕丒上丑丏且 != null)
            {
                    if(null == null)
            {
                    return;
            }
            
            }
            
            this.丑不专丗丏世丅丂丗(丛丅丘一丏丙且丌上:  true);
            this.丙不专上丛丌丆丏丏(丙业与丙丗丝不丈东:  OfferwallController.上且丁不丄专丒丟专.丟一丞丝丑七丈与丝());
        }
        private void 丙丏一丈丗丛专且丌()
        {
            if(this.东万丐万丈与世东丂 != null)
            {
                    if(null == null)
            {
                    return;
            }
            
            }
            
            this.丐丐丗丁东与丒丈丏(丛丅丘一丏丙且丌上:  true);
            this.丒丈丗且世三丞丟东(丙业与丙丗丝不丈东:  OfferwallController.上且丁不丄专丒丟专.丟一丞丝丑七丈与丝());
        }
        private void Awake()
        {
            if(PGCompany.OfferwallController.世丒丞七专三与万丕 == 0)
            {
                    PGCompany.OfferwallController.世丒丞七专三与万丕 = this;
            }
            
            this.丂三万且丈丌丁丄不 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "LastTimeShownOfferwall", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        private void OnEnable()
        {
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallController.OnEnable] _lastShownOfferWall: "("[OfferwallController.OnEnable] _lastShownOfferWall: ") + this.丂三万且丈丌丁丄不.ToString());
            }
            
            IronSourceEvents.add_onOfferwallAvailableEvent(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.OfferwallController::丈丛丘丘三丈且一一(bool 丝丝不丝上丂三丌世)));
            业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.OfferwallController::丆三丁丂三丙七丐一()));
            业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.OfferwallController::丛丕丁下丒丞丗上丌()));
            bool val_7 = this.丈丑丈三且且且下丌();
            PGCompany.Ads.下丙丏丈三上丕丈一.东丕丝世丑丈丞丄丁();
            PGCompany.Offerwall.丙不三丁一丏丐丆与.东丕丝世丑丈丞丄丁();
        }
        private void OnDisable()
        {
            IronSourceEvents.remove_onOfferwallAvailableEvent(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.OfferwallController::丈丛丘丘三丈且一一(bool 丝丝不丝上丂三丌世)));
            业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.OfferwallController::丆三丁丂三丙七丐一()));
            业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.OfferwallController::丛丕丁下丒丞丗上丌()));
        }
        private void 丆三丁丂三丙七丐一()
        {
            string val_3 = 0;
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallController.OnAuthorized]");
            }
            
            bool val_2 = this.丈丑丈三且且且下丌();
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            string val_7 = PGCompany.OfferwallController.不下世丝专一且业丏(丏丞专丏业丗丝七丝: out  val_3).ToString();
            if((System.String.IsNullOrEmpty(value:  val_3)) != false)
            {
                    string val_9 = "[OfferwallController.OnAuthorized] TryRequestVcs: "("[OfferwallController.OnAuthorized] TryRequestVcs: ") + val_7;
            }
            
            this = "[OfferwallController.OnAuthorized] TryRequestVcs: "("[OfferwallController.OnAuthorized] TryRequestVcs: ") + val_7 + ", explanation: "(", explanation: ") + val_3;
            UnityEngine.Debug.Log(message:  this);
        }
        private void 丛丕丁下丒丞丗上丌()
        {
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallController.OnAuthorizationLost]");
            }
            
            bool val_2 = this.丈丑丈三且且且下丌();
        }
        private void 丈丛丘丘三丈且一一(bool 丝丝不丝上丂三丌世)
        {
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[OfferwallController.OnOfferwallAvailabilityChanged] status: "("[OfferwallController.OnOfferwallAvailabilityChanged] status: ") + 丝丝不丝上丂三丌世.ToString());
            }
            
            bool val_5 = this.丈丑丈三且且且下丌();
        }
        public bool TodayShown()
        {
            var val_4;
            if(FriendsController.丝丗专上三不丄丑丑() != 1)
            {
                    int val_4 = this.丂三万且丈丌丁丄不;
                val_4 = val_4 + 86400;
                var val_3 = (FriendsController.丝丗专上三不丄丑丑() < (val_4 << )) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public void SetShown()
        {
            int val_3 = this.丂三万且丈丌丁丄不;
            val_3 = val_3 + 86400;
            if(FriendsController.丝丗专上三不丄丑丑() <= (val_3 << ))
            {
                    return;
            }
            
            long val_2 = FriendsController.丝丗专上三不丄丑丑();
            this.丂三万且丈丌丁丄不 = val_2;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "LastTimeShownOfferwall", 下下丏一丙不丘丌丞:  val_2, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal static void 且丛上七丘万丆上丂()
        {
            object val_8;
            string val_2 = 0;
            if((PGCompany.Offerwall.丙不三丁一丏丐丆与.丑七不且上丗丁一世().丆一东万丞丗丐丗丆(三七一丁上且丐丝丌:  "DefaultOfferWall", 丏丞专丏业丗丝七丝: out  val_2)) == false)
            {
                goto label_2;
            }
            
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_2)) == false)
            {
                goto label_4;
            }
            
            val_8 = "[OfferwallController.ShowOfferwallIronSource] TryShowOfferwall: true";
            goto label_5;
            label_2:
            UnityEngine.Debug.LogWarning(message:  "[OfferwallController.ShowOfferwallIronSource] " + val_2);
            return;
            label_4:
            val_8 = "[OfferwallController.ShowOfferwallIronSource] " + val_2;
            label_5:
            UnityEngine.Debug.Log(message:  val_8);
        }
        internal static void 且丂丗丁丟丐一丌一()
        {
            object val_8;
            string val_2 = 0;
            if((PGCompany.Offerwall.丙不三丁一丏丐丆与.丑七不且上丗丁一世().丗丏世丕丌三上丝丅(丏丞专丏业丗丝七丝: out  val_2)) == false)
            {
                goto label_2;
            }
            
            if(PGCompany.OfferwallController.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_2)) == false)
            {
                goto label_4;
            }
            
            val_8 = "[OfferwallController.GetCreditsIronSource] TryGetOfferwallCredits: true";
            goto label_5;
            label_2:
            UnityEngine.Debug.LogWarning(message:  "[OfferwallController.GetCreditsIronSource] " + val_2);
            return;
            label_4:
            val_8 = "[OfferwallController.GetCreditsIronSource] " + val_2;
            label_5:
            UnityEngine.Debug.Log(message:  val_8);
        }
        private static bool 丆丕丝七丞丐丘丆丙(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丆与丝上下万下丁世 丟丐丗万丅下丗丝万)
        {
            return (bool)(ExperienceController.丞丞丘业东丙丏七丌() < 丟丐丗万丅下丗丝万.unlockLevel.丙东专丂世丈丏丁丂()) ? 1 : 0;
        }
        private static bool 丒世丙业丕丏丆丙一(PGCompany.DataObjects.万丞丘丏丆丆丝与与.丆与丝上下万下丁世 丟丐丗万丅下丗丝万)
        {
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "InstallTime_after_12_6_1_Key")) != true)
            {
                    System.DateTime val_2 = System.DateTime.UtcNow;
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "InstallTime_after_12_6_1_Key", 下下丏一丙不丘丌丞:  val_2.dateData);
            }
            
            bool val_4 = System.DateTime.TryParse(s:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "InstallTime_after_12_6_1_Key"), result: out  new System.DateTime());
            System.DateTime val_5 = System.DateTime.UtcNow;
            System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_5.dateData}, d2:  new System.DateTime());
            return (bool)(val_6._ticks.Days < 丟丐丗万丅下丗丝万.nonPaidPeriod.丙东专丂世丈丏丁丂()) ? 1 : 0;
        }
        public OfferwallController()
        {
            this.东万丐万丈与世东丂 = OfferwallController.下丝丒东丟丂一七世.丑下丗万丈丄丏一丞();
            this.丈丙七丕丒上丑丏且 = OfferwallController.下丝丒东丟丂一七世.丑下丗万丈丄丏一丞();
        }
        private bool 丕丄业七业丞下丗丛(string 丁丂丕与丁丒丕丟丞)
        {
            this.丌丌一世丏丟丅且丁(丁丂丕与丁丒丕丟丞:  丁丂丕与丁丒丕丟丞);
            this.丅不丌丒丁丂与丑上(丁丂丕与丁丒丕丟丞:  丁丂丕与丁丒丕丟丞);
            return false;
        }
        internal static bool 丅三丄丕丑世万丝万(string 东丒丝不上丛丒丌丄, out string 丄丙下丝丛丒七丂丘)
        {
            丄丙下丝丛丒七丂丘 = 东丒丝不上丛丒丌丄;
            return true;
        }
    
    }

}
