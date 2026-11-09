using UnityEngine;

namespace PGCompany
{
    internal sealed class PixelPassLobbyView : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _holder;
        private PixelPassProgressView _pixelPassProgressView;
        private UnityEngine.GameObject _lockContainer;
        private UnityEngine.GameObject _unLockContainer;
        private UnityEngine.GameObject _comingSoonContainer;
        private UnityEngine.GameObject _needLevelContainer;
        private UILabel _needLevelLabel;
        private lockedOnProgressUI lockedUI;
        private UnityEngine.GameObject _tutorialContainer;
        private UILabel _tutorialLabel;
        private UnityEngine.GameObject _stateNormal;
        private UnityEngine.GameObject _stateHasCellRewardToCollect;
        private UnityEngine.GameObject _stateHasTaskRewardToCollect;
        private UnityEngine.GameObject _stateOnSeasonEnd;
        private PGCompany.InventoryItemView _bonusReward;
        private UnityEngine.GameObject _expTexture;
        private LobbyButton _lobbyButton;
        private LobbyButtonHint _lobbyButtonHint;
        private bool _inConnectScene;
        private PGCompany.丙世丌与丂丛丆丗丞 丙丛下业丗专丝与丞;
        private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
        
        // Properties
        private PGCompany.丙世丌与丂丛丆丗丞 丗丄丁与专专一丝万 { get; }
        
        // Methods
        private PGCompany.丙世丌与丂丛丆丗丞 丞丐专丐且一丝丑三()
        {
            PGCompany.丙世丌与丂丛丆丗丞 val_6 = this.丙丛下业丗专丝与丞;
            if(val_6 != null)
            {
                    return val_6;
            }
            
            if((PGCompany.世专三丑丘丗丂丅丞.丑七不且上丗丁一世().丝丒专丙世与三丌丞(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 24, 丏丟丑丙七东专丌丏 = false, 丒丂丌丑丟东东丒专 = false})) != null)
            {
                    val_6 = 0;
            }
            
            this.丙丛下业丗专丝与丞 = val_6;
            return val_6;
        }
        private void Awake()
        {
            if(this.丞丐专丐且一丝丑三() == null)
            {
                
            }
        
        }
        private void OnEnable()
        {
            this.丞丐专丐且一丝丑三().七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丘丘丙丒丛丈丟丕丛()));
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.东丄与丘丏专七世与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            BattlePassController.万且丟丘丐丑丏且专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            BattlePassController.丙七一丄下专丏不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            this.丈且东丑丂且万丒丅();
        }
        private void OnDisable()
        {
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            this.丞丐专丐且一丝丑三().与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丘丘丙丒丛丈丟丕丛()));
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丛丈丟丟世世上丞七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            BattlePassController.下丟丐丙丌世丆丌丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
            BattlePassController.业丏专与丝不东丁一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPassLobbyView::丈且东丑丂且万丒丅()));
        }
        private void OnDestroy()
        {
            if(this.丞丐专丐且一丝丑三() == null)
            {
                
            }
        
        }
        private void 丈且东丑丂且万丒丅()
        {
            UnityEngine.GameObject val_27;
            var val_28;
            UnityEngine.GameObject val_29;
            var val_30;
            UILabel val_31;
            string val_32;
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_33;
            PGCompany.InventoryItemView val_34;
            object val_35;
            val_27 = this;
            this.丑与万三丐丒丏一专 = 0;
            if((PixelTime.丝丗专上三不丄丑丑() < 1) || (PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丁下三且丛丝一一丏() == false))
            {
                goto label_5;
            }
            
            this.丑与万三丐丒丏一专 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unLockContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._comingSoonContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._needLevelContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateNormal, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateHasCellRewardToCollect, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateHasTaskRewardToCollect, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateOnSeasonEnd, 丏业丟一东丂东丘丛:  false);
            if((this.丑与万三丐丒丏一专 == null) || (this.丑与万三丐丒丏一专.不丆丑与七下一丛丅() == false))
            {
                goto label_10;
            }
            
            if(this.丑与万三丐丒丏一专.丞一丞上丞丞且丐丅() == false)
            {
                goto label_12;
            }
            
            if(this._inConnectScene == false)
            {
                goto label_15;
            }
            
            val_28 = this.丑与万三丐丒丏一专.三与上七业丟丞丙丛;
            bool val_8 = val_28.三下丐且世丝丛业丈();
            goto label_16;
            label_5:
            val_27 = this._holder;
            val_29 = val_27;
            val_30 = 0;
            goto label_19;
            label_10:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  true);
            val_29 = this._comingSoonContainer;
            val_30 = 1;
            label_19:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29, 丏业丟一东丂东丘丛:  true);
            return;
            label_12:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._needLevelContainer, 丏业丟一东丂东丘丛:  true);
            if(this.lockedUI != null)
            {
                    this.lockedUI.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  this.丑与万三丐丒丏一专.万丆丈丑上丛丏三丛());
            }
            
            val_31 = this._needLevelLabel;
            val_32 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11673"), arg0:  this.丑与万三丐丒丏一专.万丆丈丑上丛丏三丛());
            goto label_31;
            label_15:
            val_28 = this.丑与万三丐丒丏一专.三与上七业丟丞丙丛;
            label_16:
            if((val_28.万万上丆丑丐丗丝丛() == true) || (PGCompany.PixelPass.丁且七丅丞丐丌丌世.丟丂下七且七东丛丞() == true))
            {
                goto label_33;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialContainer, 丏业丟一东丂东丘丛:  true);
            val_33 = this.丑与万三丐丒丏一专;
            if(val_33 == null)
            {
                goto label_39;
            }
            
            if(this.丑与万三丐丒丏一专.三与上七业丟丞丙丛 == null)
            {
                goto label_38;
            }
            
            PGCompany.世丐下丕专东丘丏且 val_15 = this.丑与万三丐丒丏一专.三与上七业丟丞丙丛.丟下丄东上下丑与丆();
            if(val_15 == null)
            {
                goto label_38;
            }
            
            int val_16 = val_15.丁丝丞与丟与丟丌三();
            val_33 = 0;
            goto label_39;
            label_33:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unLockContainer, 丏业丟一东丂东丘丛:  true);
            if(this._pixelPassProgressView != null)
            {
                    this._pixelPassProgressView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专);
            }
            
            val_34 = this._bonusReward;
            if(val_34 != null)
            {
                    val_34.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丑与万三丐丒丏一专.丂丝下丏丄上丐丛丗().丈丏丁东上与东丙丕()));
                val_34 = this._bonusReward;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_34, 丏业丟一东丂东丘丛:  this.丑与万三丐丒丏一专.丘丗与丝专丑一丙丌());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._expTexture, 丏业丟一东丂东丘丛:  (~this.丑与万三丐丒丏一专.丘丗与丝专丑一丙丌()) & 1);
            this.丘丘丙丒丛丈丟丕丛();
            return;
            label_38:
            val_33 = 0;
            label_39:
            if(((-262394920) & 1) != 0)
            {
                    val_35 = val_33.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_35 = 0;
            }
            
            val_31 = this._tutorialLabel;
            val_32 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6443"), arg0:  val_35);
            label_31:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_31, 丕丗丘丑丛与丑业丒:  val_32);
        }
        private void 丘丘丙丒丛丈丟丕丛()
        {
            var val_8;
            UnityEngine.GameObject val_9;
            if(this.丑与万三丐丒丏一专 == null)
            {
                    return;
            }
            
            if(this.丑与万三丐丒丏一专.丂与丐下一丟丆丌与() == 0)
            {
                goto label_2;
            }
            
            if(this.丞丐专丐且一丝丑三().不专业丏不丄下丝不().不丌丈专丟丒丕专丏() == false)
            {
                goto label_5;
            }
            
            val_8 = 1152921505284374528;
            val_9 = this._stateHasTaskRewardToCollect;
            goto label_14;
            label_2:
            val_8 = 1152921505284374528;
            val_9 = this._stateOnSeasonEnd;
            goto label_14;
            label_5:
            if(this.丞丐专丐且一丝丑三().万丌三丏丒丘丕丙七().不丌丈专丟丒丕专丏() != false)
            {
                    val_9 = this._stateHasCellRewardToCollect;
            }
            else
            {
                    val_9 = this._stateNormal;
            }
            
            label_14:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        }
        public void U_OpenPixelPass()
        {
            if(this.丑与万三丐丒丏一专 == null)
            {
                    return;
            }
            
            .不丌不世且丄不三丝 = 1;
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丛丘专丌业且丑一丄(丗三丝丈专七万丕丆:  new 丆丝丈丐不专一丟且(), 丘丒丅三丞丞丛丛丌:  0);
        }
        public void U_OpenPixelPassFromConnectScene()
        {
            if((PGCompany.PixelPass.丁且七丅丞丐丌丌世.丁丗且丗丐且专丘丂(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专)) == null)
            {
                    return;
            }
            
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        public void U_LockedPressed()
        {
            LobbyButtonHint val_5;
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_2 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            if(val_2 == null)
            {
                    return;
            }
            
            if(this._lobbyButton == 0)
            {
                    return;
            }
            
            if(val_2.丞一丞上丞丞且丐丅() != false)
            {
                    return;
            }
            
            if(this._lobbyButtonHint != null)
            {
                    this._lobbyButtonHint.丈且东丑丂且万丒丅(一丑不丞丟丑东丗丛:  this._lobbyButton);
                val_5 = this._lobbyButtonHint;
            }
            else
            {
                    val_5 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        }
        public PixelPassLobbyView()
        {
        
        }
    
    }

}
