//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Msg_GetHeroData.proto
// Note: requires additional types generated from: Dat_HeroData.proto
namespace ProtoBuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_GetHeroData")]
  public partial class C2S_GetHeroData : global::ProtoBuf.IExtensible
  {
    public C2S_GetHeroData() {}
    
    private readonly global::System.Collections.Generic.List<string> _heroes = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"heroes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> heroes
    {
      get { return _heroes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2C_GetHeroData")]
  public partial class S2C_GetHeroData : global::ProtoBuf.IExtensible
  {
    public S2C_GetHeroData() {}
    
    private int _ret;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoBuf.DAT_HeroData> _heroes = new global::System.Collections.Generic.List<ProtoBuf.DAT_HeroData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"heroes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoBuf.DAT_HeroData> heroes
    {
      get { return _heroes; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}