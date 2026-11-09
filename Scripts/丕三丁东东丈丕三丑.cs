using UnityEngine;
internal class 专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑
{
    // Fields
    internal Rilisoft.丝丑丂丛万丐丈丘且 _isMarkEndSeason;
    internal Rilisoft.丝丑丂丛万丐丈丘且 _currentSeason;
    internal Rilisoft.丝丑丂丛万丐丈丘且 _lastSeason;
    internal Rilisoft.丝丑丂丛万丐丈丘且 _isActiveSeason;
    private Rilisoft.丝丑丂丛万丐丈丘且 _currentLevel;
    private System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> _issuedRewards;
    
    // Properties
    internal bool 不上一丟丘丁不不业 { get; set; }
    internal int 丒丁东三一丆丙丘世 { get; set; }
    internal int 业世丙丐上业不丒东 { get; set; }
    internal bool 业一与丏丄与丁丅七 { get; set; }
    internal int 丑下丌上丑一丁丟东 { get; set; }
    internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 丒丞东丌丐丕下丌丂 { get; }
    
    // Methods
    internal bool 且丛丈丝丘丈一丙丟()
    {
        return (bool)(this._isMarkEndSeason != 0) ? 1 : 0;
    }
    internal void 不东丗丏七丈且丁一(bool 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        bool val_2 = 丙业与丙丗丝不丈东;
        this._isMarkEndSeason = 0;
        mem[1152921541348607768] = 0;
    }
    internal int 世万丅丞下丌丐不丈()
    {
    
    }
    internal void 丝一丈丟丏专一丑丐(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this._currentSeason = 0;
        mem[1152921541348831784] = 0;
    }
    internal int 与三丌专丒下丏丏丏()
    {
    
    }
    internal void 丝世且丏丂丂且丈与(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this._lastSeason = 0;
        mem[1152921541349055800] = 0;
    }
    internal bool 七丝丁丗七丆下丈丌()
    {
        return (bool)(this._isActiveSeason != 0) ? 1 : 0;
    }
    internal void 三东上东丝业丂世丆(bool 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        bool val_2 = 丙业与丙丗丝不丈东;
        this._isActiveSeason = 0;
        mem[1152921541349279816] = 0;
    }
    internal int 丞丞丘业东丙丏七丌()
    {
    
    }
    internal void 丁三丛三丙丄丆世丑(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this._currentLevel = 0;
        mem[1152921541349503832] = 0;
    }
    internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> 下丙三丗丗丕丂丁丞()
    {
        return (System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>)this._issuedRewards;
    }
    internal bool 丄丝下丙丅且丘丞丏(int 丈丘丝一丗下丈丐不)
    {
        System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> val_3;
        var val_4;
        val_3 = this;
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丘丝一丗下丈丐不);
        if((this.下丟万世东丞丛丏丟(丈丄七下下丙一丐丛:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_1.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_1.上万三丆专丏丒丗业})) != false)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        val_3 = this._issuedRewards;
        val_3.Add(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_1.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_1.上万三丆专丏丒丗业});
        val_4 = 1;
        return (bool)val_4;
    }
    internal bool 下丟万世东丞丛丏丟(int 丈丘丝一丗下丈丐不)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丘丝一丗下丈丐不);
        return this.下丟万世东丞丛丏丟(丈丄七下下丙一丐丛:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_1.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_1.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_1.上万三丆专丏丒丗业});
    }
    private bool 下丟万世东丞丛丏丟(Rilisoft.丝丑丂丛万丐丈丘且 丈丄七下下丙一丐丛)
    {
        if(this._issuedRewards != null)
        {
                return this._issuedRewards.Contains(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丈丄七下下丙一丐丛.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = 丈丄七下下丙一丐丛.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = 丈丄七下下丙一丐丛.上万三丆专丏丒丗业});
        }
        
        return this._issuedRewards.Contains(item:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丈丄七下下丙一丐丛.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = 丈丄七下下丙一丐丛.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = 丈丄七下下丙一丐丛.上万三丆专丏丒丗业});
    }
    public 专丟丝丂丕丟丒世东.丕三丁东东丈丕三丑()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
        this._currentLevel = val_1;
        mem[1152921541350092504] = val_1.上万三丆专丏丒丗业;
        this._issuedRewards = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
    }

}
