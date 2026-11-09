using UnityEngine;

namespace Rilisoft
{
    internal class InAppBonusLobbyTopView : InAppBonusLobbyViewBase
    {
        // Fields
        private UnityEngine.GameObject _badge;
        private UnityEngine.GameObject _eventSpinAvailableOfferWall;
        private UnityEngine.GameObject actionDependingObjectsHolder;
        private Rilisoft.InAppBonusLobbyButtonDependingObject 丗丗丈丘丑不下丙下;
        private MultButton multButton;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _offerwallObj;
        private UILabel _timeLeftLabel;
        private Rilisoft.InAppBonusLobbyButtonDependingObject _vipObj;
        
        // Methods
        public override void UpdateView(bool 七丆丟丗世丟且丒丆 = False)
        {
            bool val_42;
            var val_43;
            UnityEngine.Object val_44;
            UnityEngine.GameObject val_45;
            UnityEngine.GameObject val_46;
            var val_47;
            val_43 = this;
            if(((七丆丟丗世丟且丒丆 != true) && (true != 0)) && (X9 != 0))
            {
                    if(1 == (X9 + 240))
            {
                goto label_75;
            }
            
            }
            
            if((七丆丟丗世丟且丒丆 + 240) != 6)
            {
                goto label_6;
            }
            
            if(this.丗丗丈丘丑不下丙下 != 0)
            {
                    val_42 = static_value_082C5078;
                if((System.String.op_Inequality(a:  this.丗丗丈丘丑不下丙下.gameEvent.业上丙丞丐丄丆丅七(), b:  val_42.业上丙丞丐丄丆丅七())) != false)
            {
                    UnityEngine.Object.Destroy(obj:  this.丗丗丈丘丑不下丙下.gameObject);
            }
            
            }
            
            if(PGCompany.丁东丌世与丕东丆上.丗不上丒丙七丆丏东() == false)
            {
                goto label_20;
            }
            
            val_44 = 0;
            if(this.丗丗丈丘丑不下丙下 != val_44)
            {
                goto label_75;
            }
            
            val_45 = this.actionDependingObjectsHolder;
            Rilisoft.InAppBonusLobbyButtonDependingObject val_9 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.InAppBonusLobbyButtonDependingObject>(丅东专与不三丂丁丝:  this.丗丗丈丘丑不下丙下, 丒丘丏上丙丟丑丕丈:  "icon", 丈东丘丏与丌东东下:  val_45.transform, 丛下丅丏丄且丁一业:  true);
            this.丗丗丈丘丑不下丙下 = val_9;
            val_44 = 0;
            if(val_9 == val_44)
            {
                goto label_75;
            }
            
            this.丗丗丈丘丑不下丙下.gameEvent = val_45;
            this.丗丗丈丘丑不下丙下.gameObject.SetActive(value:  true);
            val_44 = 0;
            if(this.multButton == val_44)
            {
                goto label_75;
            }
            
            val_44 = 0;
            if(this.丗丗丈丘丑不下丙下.Texture == val_44)
            {
                goto label_75;
            }
            
            val_45 = this.丗丗丈丘丑不下丙下.Texture.gameObject;
            val_44 = val_45;
            this.multButton.AddTargetObject(丝三丁东丈丒世丅业:  val_44);
            goto label_75;
            label_6:
            if((七丆丟丗世丟且丒丆 + 240) != 11)
            {
                goto label_45;
            }
            
            val_45 = 1152921504848912384;
            if(this._timeLeftLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._vipObj.gameObject, 丏业丟一东丂东丘丛:  true);
            if((UnityEngine.Object.op_Implicit(exists:  this.丗丗丈丘丑不下丙下)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丗丗丈丘丑不下丙下.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            val_44 = 0;
            if(this._offerwallObj == val_44)
            {
                goto label_75;
            }
            
            val_46 = this._offerwallObj.gameObject;
            val_44 = 0;
            goto label_67;
            label_20:
            if(this.丗丗丈丘丑不下丙下 == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.丗丗丈丘丑不下丙下.gameObject);
            return;
            label_45:
            if((七丆丟丗世丟且丒丆 + 240) != 17)
            {
                goto label_75;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._vipObj.gameObject, 丏业丟一东丂东丘丛:  false);
            if((UnityEngine.Object.op_Implicit(exists:  this.丗丗丈丘丑不下丙下)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丗丗丈丘丑不下丙下.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._offerwallObj != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._offerwallObj.gameObject, 丏业丟一东丂东丘丛:  true);
                if(this._timeLeftLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timeLeftLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            val_45 = PGCompany.OfferwallController.丑七不且上丗丁一世().TodayShown();
            val_44 = (~val_45) & 1;
            val_46 = this._badge;
            label_67:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_46, 丏业丟一东丂东丘丛:  val_44);
            label_75:
            val_43 = ???;
            val_47 = ???;
            goto typeof(Rilisoft.InAppBonusLobbyTopView).__il2cppRuntimeField_188;
        }
        protected override void 丗丌丂丙丈丆不丂七()
        {
            var val_18;
            int val_19;
            if(true == 0)
            {
                goto label_20;
            }
            
            if((1 == 11) && ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) != false))
            {
                    string val_5 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
                UITweener val_8 = this._vipObj.TweenRotationScript;
                if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上()) > 43199)
            {
                    val_8.ResetToBeginning();
                UITweener val_9 = this._vipObj.TweenRotationScript;
                val_18 = 0;
            }
            else
            {
                    val_18 = 1;
            }
            
                val_8.enabled = true;
            }
            
            if(((43199 == 0) || (262912 == 0)) || (262912.丈丐丞丐上丑且丕万() == false))
            {
                goto label_20;
            }
            
            System.Nullable<System.TimeSpan> val_11 = val_7 + 120.丙世丑丅丒丑业与不();
            if(((-257620352) & 1) == 0)
            {
                goto label_20;
            }
            
            System.Nullable<System.TimeSpan> val_12 = val_7 + 120 + 120.丙世丑丅丒丑业与不();
            if(PGCompany.丁东丌世与丕东丆上.丗不上丒丙七丆丏东() == false)
            {
                goto label_25;
            }
            
            val_19 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (long)val_12.HasValue.TotalSeconds, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            if(this._timeLeftLabel != null)
            {
                goto label_30;
            }
            
            goto label_29;
            label_25:
            val_19 = System.String.alignConst;
            if(this._timeLeftLabel != null)
            {
                goto label_30;
            }
            
            label_29:
            label_30:
            this._timeLeftLabel.text = val_19;
            label_20:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._badge, 丏业丟一东丂东丘丛:  this.业丂丟且丏丟丆丆丝());
        }
        private void OnClick()
        {
            goto typeof(Rilisoft.InAppBonusLobbyTopView).__il2cppRuntimeField_1B8;
        }
        public override void Interact()
        {
            if((X20 + 240) == 11)
            {
                    return;
            }
            
            this.Interact();
        }
        public InAppBonusLobbyTopView()
        {
        
        }
    
    }

}
