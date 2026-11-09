using UnityEngine;

namespace PGCompany.VIP20
{
    internal sealed class Vip20ProgressView : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _holder;
        private UILabel _countLabel;
        private UnityEngine.BoxCollider _boxCollider;
        
        // Methods
        private void OnEnable()
        {
            this.丈且东丑丂且万丒丅();
            PGCompany.VIP20.丗一丄且与一丕丙丝.下不不上丒与一丁专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.VIP20.Vip20ProgressView::丈且东丑丂且万丒丅()));
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.VIP20.Vip20ProgressView::丈且东丑丂且万丒丅(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.世东三上七丂丌下丑.专且丞七丟丌一丝丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.VIP20.Vip20ProgressView::丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
        }
        private void OnDisable()
        {
            PGCompany.VIP20.丗一丄且与一丕丙丝.丂且丆丙一丈丙丛万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.VIP20.Vip20ProgressView::丈且东丑丂且万丒丅()));
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.VIP20.Vip20ProgressView::丈且东丑丂且万丒丅(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.世东三上七丂丌下丑.丑丗丟丑丑丒丈一不(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.VIP20.Vip20ProgressView::丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
        }
        private void 丈且东丑丂且万丒丅(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且 == null)
            {
                    return;
            }
            
            if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.业东丅东丌上丗丑不() != 24015)
            {
                    return;
            }
            
            this.丈且东丑丂且万丒丅();
        }
        private void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            if(丈丄不七三万丄丁不 == null)
            {
                    return;
            }
            
            if(丈丄不七三万丄丁不.业东丅东丌上丗丑不() != 24015)
            {
                    return;
            }
            
            this.丈且东丑丂且万丒丅();
        }
        private void 丈且东丑丂且万丒丅()
        {
            if(val_1.世丂上丌丞且丁七丏 != null)
            {
                    if(PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世().丈下三丒丄丄三丆专() != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_8;
            }
            
            }
            
            }
            
            if(this._boxCollider != 0)
            {
                    this._boxCollider.enabled = false;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            return;
            label_8:
            PGCompany.七下丐丂丙丑东专丂 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if((val_7 != null) && (val_7.丂丁丏一丙丛业且丌() > 0))
            {
                    if(this._boxCollider != 0)
            {
                    this._boxCollider.enabled = true;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
                this.丙丕丑丟丛丅业丝丙(丌丒丝东丌下丕丁丅:  val_7.丂丁丏一丙丛业且丌());
                return;
            }
            
            if(this._boxCollider != 0)
            {
                    this._boxCollider.enabled = false;
            }
            
            this = this._holder;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  false);
        }
        private void 丙丕丑丟丛丅业丝丙(int 丌丒丝东丌下丕丁丅)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._countLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2002"), arg0:  丌丒丝东丌下丕丁丅));
        }
        public void ShowInfoBanner()
        {
            PGCompany.VIP20.丗一丄且与一丕丙丝 val_8 = PGCompany.VIP20.丗一丄且与一丕丙丝.丑七不且上丗丁一世();
            if(val_1.世丂上丌丞且丁七丏 == null)
            {
                    return;
            }
            
            if(val_8.丈下三丒丄丄三丆专() == false)
            {
                    return;
            }
            
            val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.七下丐丂丙丑东专丂 val_5 = val_8.上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_5 == null)
            {
                    return;
            }
            
            if(val_5.丂丁丏一丙丛业且丌() < 1)
            {
                    return;
            }
            
            val_8 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_8.ForceShowBanner(丌丅丕一丛丛丄一万:  91, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        public Vip20ProgressView()
        {
        
        }
    
    }

}
