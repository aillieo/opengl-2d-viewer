//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Msg_UpdateTeamData.proto
namespace ProtoBuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_UpdateTeamData")]
  public partial class C2S_UpdateTeamData : global::ProtoBuf.IExtensible
  {
    public C2S_UpdateTeamData() {}
    
    private string _team;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string team
    {
      get { return _team; }
      set { _team = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2C_UpdateTeamData")]
  public partial class S2C_UpdateTeamData : global::ProtoBuf.IExtensible
  {
    public S2C_UpdateTeamData() {}
    
    private int _ret;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private string _team;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string team
    {
      get { return _team; }
      set { _team = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}