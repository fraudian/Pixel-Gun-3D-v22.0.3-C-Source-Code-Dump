using UnityEngine;

namespace PGCompany
{
    internal sealed class TrophyRoadProgressView : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _validContainer;
        private UnityEngine.GameObject _invalidContainer;
        private UISprite _progressSprite;
        private UILabel _progressLabel;
        private UnityEngine.GameObject _rewardContainer;
        private PGCompany.InventoryItemView _inventoryItemView;
        private UnityEngine.GameObject _takeContainer;
        private UILabel _takeLabel;
        
        // Methods
        private void OnEnable()
        {
            this.丈且东丑丂且万丒丅();
            PGCompany.TrophyRoad.与丂三专且丅万世一.丝一丅世与且三丁七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoadProgressView::丝丁一丂七丈丛一丁()));
            PGCompany.TrophyRoad.与丂三专且丅万世一.丝且与丂业丆丗丈丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoadProgressView::丝丁一丂七丈丛一丁()));
            PGCompany.TrophyRoad.与丂三专且丅万世一.丐丏三万丐且丗专世(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.TrophyRoadProgressView::丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)));
        }
        private void OnDestroy()
        {
            PGCompany.TrophyRoad.与丂三专且丅万世一.世专丘丛丕业丟东丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoadProgressView::丝丁一丂七丈丛一丁()));
            PGCompany.TrophyRoad.与丂三专且丅万世一.一专专三万上丑丐丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoadProgressView::丝丁一丂七丈丛一丁()));
            PGCompany.TrophyRoad.与丂三专且丅万世一.丑丂丂丄丂专丐丘与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.TrophyRoadProgressView::丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)));
        }
        public void U_OpenTrophyRoad()
        {
            var val_3;
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丁业丅丗丝业丂丅世() == false)
            {
                    return;
            }
            
            val_3 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_3.ForceShowBanner(丌丅丕一丛丛丄一万:  73, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        private void 丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)
        {
            this.丐丆丑万丞万与丘丂();
        }
        private void 丄且丙七不丐万不丅(int 丏丆丈不丁丞丒丒一)
        {
            this.丈且东丑丂且万丒丅();
        }
        private void 丈且东丑丂且万丒丅()
        {
            this.丝丁一丂七丈丛一丁();
            this.上不丕丌丄世丆丘丘();
            this.丞丕丈丄丐丐丏丂不();
            this.丐丆丑万丞万与丘丂();
        }
        private void 丝丁一丂七丈丛一丁()
        {
            var val_2;
            UnityEngine.GameObject val_3;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._validContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._invalidContainer, 丏业丟一东丂东丘丛:  false);
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丁业丅丗丝业丂丅世() != false)
            {
                    val_2 = null;
                val_3 = this._validContainer;
            }
            else
            {
                    val_2 = null;
                val_3 = this._invalidContainer;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
        }
        private void 丞丕丈丄丐丐丏丂不()
        {
            UnityEngine.GameObject val_4;
            UnityEngine.GameObject val_5;
            val_4 = this;
            if(this._inventoryItemView == 0)
            {
                    val_4 = this._rewardContainer;
                val_5 = val_4;
            }
            else
            {
                    PGCompany.三东丏不丗世丅丌丄 val_3 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().世丁上丅且丂丄丁丑();
                if(val_3 != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardContainer, 丏业丟一东丂东丘丛:  true);
                this._inventoryItemView.Setup(丈丄不七三万丄丁不:  val_3);
                return;
            }
            
                val_5 = this._rewardContainer;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
        }
        private void 上不丕丌丄世丆丘丘()
        {
            int val_2 = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().不丑丒丟丘不且七万();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}", arg0:  val_2));
            int val_5 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丙丆丝丞丘丗世且丙(丏丆丈不丁丞丒丒一:  val_2);
            float val_12 = (float)val_2;
            val_12 = val_12 / ((float)(PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().不丗丁不丛与万不业(丈丘丝一丗下丈丐不:  val_5 + 1)) - (PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().不丗丁不丛与万不业(丈丘丝一丗下丈丐不:  val_5)));
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this._progressSprite, 丙业与丙丗丝不丈东:  val_12);
        }
        private void 丐丆丑万丞万与丘丂()
        {
            int val_2 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丌丄丌丕丒下丒丙丆();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._takeContainer, 丏业丟一东丂东丘丛:  (val_2 > 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._takeLabel, 丕丗丘丑丛与丑业丒:  val_2);
        }
        public TrophyRoadProgressView()
        {
        
        }
    
    }

}
