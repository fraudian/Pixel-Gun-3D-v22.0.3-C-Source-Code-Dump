using UnityEngine;
public class ClansInfoMemberView : ClansMemberView
{
    // Fields
    public UILabel _name;
    public UILabel cups;
    public UnityEngine.GameObject isOnline;
    public UnityEngine.GameObject isPlayer;
    public UILabel place;
    public UISprite roleIcon;
    public UISprite clanRankSprite;
    public int wrapIndex;
    
    // Methods
    public void UpdateView(与丛丕丝丑丁与丐丝 丕丝丄三丂三与丑世)
    {
        if(丕丝丄三丂三与丑世 == null)
        {
            goto label_1;
        }
        
        this._name.text = 丕丝丄三丂三与丑世.丒丘丏上丙丟丑丕丈;
        mem[1152921536663081272] = 丕丝丄三丂三与丑世.丞丅上丏丂且下丅与;
        this.place.text = 丕丝丄三丂三与丑世.专世专丟丝丌与丘上.ToString();
        this.cups.text = 丕丝丄三丂三与丑世.不业丑丂丝业丞专丈.ToString();
        this.gameObject.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.isOnline, 丏业丟一东丂东丘丛:  (丕丝丄三丂三与丑世.丘三三东且丈丅丈丛 == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.clanRankSprite, 万丑丞一丝丌丐丒丘:  丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  丕丝丄三丂三与丑世.丅丄与专下丅丄丝东));
        bool val_7 = 丕丝丄三丂三与丑世.丞丅上丏丂且下丅与.Equals(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        if(this.isPlayer == null)
        {
            goto label_11;
        }
        
        if(val_7 == false)
        {
            goto label_12;
        }
        
        label_15:
        this.isPlayer.SetActive(value:  true);
        UnityEngine.Color val_8 = UnityEngine.Color.yellow;
        goto label_13;
        label_1:
        this.gameObject.SetActive(value:  false);
        return;
        label_11:
        if(val_7 == true)
        {
            goto label_15;
        }
        
        label_12:
        this.isPlayer.SetActive(value:  false);
        UnityEngine.Color val_10 = UnityEngine.Color.white;
        label_13:
        this.丒丗丙丙丙丟专丅万(丂丄一丗业丗丐万丏:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
        this.丁丅丁丆七三一专丈(丕丝丄三丂三与丑世:  丕丝丄三丂三与丑世);
        if(丕丝丄三丂三与丑世.丁七万丟丆丟不万丗 != false)
        {
                UnityEngine.Color val_11 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        }
        else
        {
                UnityEngine.Color val_12 = this._name.color;
        }
        
        this._name.color = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
    }
    private void 丁丅丁丆七三一专丈(与丛丕丝丑丁与丐丝 丕丝丄三丂三与丑世)
    {
        UISprite val_5;
        string val_6;
        if(丕丝丄三丂三与丑世.丕万丐东与一丈万与 == 0)
        {
            goto label_2;
        }
        
        if(丕丝丄三丂三与丑世.丕万丐东与一丈万与 == 2)
        {
            goto label_3;
        }
        
        if(丕丝丄三丂三与丑世.丕万丐东与一丈万与 != 1)
        {
            goto label_4;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.roleIcon.gameObject, 丏业丟一东丂东丘丛:  true);
        val_5 = this.roleIcon;
        val_6 = "clan_leader_icon1";
        goto label_14;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.roleIcon.gameObject, 丏业丟一东丂东丘丛:  true);
        val_5 = this.roleIcon;
        val_6 = "clan_fighter_icon";
        goto label_14;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.roleIcon.gameObject, 丏业丟一东丂东丘丛:  true);
        val_5 = this.roleIcon;
        val_6 = "clan_officer_icon";
        label_14:
        val_5.spriteName = val_6;
        return;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.roleIcon.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丂丄一丗业丗丐万丏)
    {
        this._name.color = new UnityEngine.Color() {r = 丂丄一丗业丗丐万丏.r, g = 丂丄一丗业丗丐万丏.g, b = 丂丄一丗业丗丐万丏.b, a = 丂丄一丗业丗丐万丏.a};
    }
    public ClansInfoMemberView()
    {
        val_1 = new PGBehaviour();
    }

}
