using UnityEngine;

namespace Rilisoft
{
    internal class NestLobbyHeader : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 _headerPosWithoutTimer;
        private TextMeshBounds _headerText;
        private UnityEngine.Vector3 与丘与丞东丐上丝上;
        private long 丛丕专丐业丑三丙东;
        private UnityEngine.Vector3 丝丕丘丞丈东丙丙丌;
        private TextMeshBounds _timerText;
        
        // Methods
        private void Start()
        {
            UnityEngine.Vector3 val_3 = this._headerText.gameObject.transform.localPosition;
            this.丝丕丘丞丈东丙丙丌 = val_3;
            mem[1152921542574942428] = val_3.y;
            mem[1152921542574942432] = val_3.z;
        }
        public void Set(bool 下下东且万业丞丅丒, long 丄专万丏丘上丑与一)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(下下东且万业丞丅丒 == false)
            {
                goto label_1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerText.gameObject, 丏业丟一东丂东丘丛:  (丄专万丏丘上丑与一 > 0) ? 1 : 0);
            this._headerText.transform.localPosition = new UnityEngine.Vector3() {x = (丄专万丏丘上丑与一 < 1) ? this._headerPosWithoutTimer : this.丝丕丘丞丈东丙丙丌, y = (丄专万丏丘上丑与一 < 1) ? 1152921542575095340 : 1152921542575095388, z = (丄专万丏丘上丑与一 < 1) ? 1152921542575095344 : 1152921542575095392};
            if(this.丛丕专丐业丑三丙东 != 丄专万丏丘上丑与一)
            {
                goto label_9;
            }
            
            return;
            label_1:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
            return;
            label_9:
            this.丛丕专丐业丑三丙东 = 丄专万丏丘上丑与一;
            this._timerText.Text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丄专万丏丘上丑与一, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        }
        public NestLobbyHeader()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.与丘与丞东丐上丝上 = val_1;
            mem[1152921542575236036] = val_1.y;
            mem[1152921542575236040] = val_1.z;
        }
    
    }

}
