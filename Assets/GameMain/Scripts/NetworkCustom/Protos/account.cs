//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: account.proto
namespace GameMain.Protos
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeartBeat_Request")]
  public partial class HeartBeat_Request : global::ProtoBuf.IExtensible
  {
    public HeartBeat_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HeartBeat_Result")]
  public partial class HeartBeat_Result : global::ProtoBuf.IExtensible
  {
    public HeartBeat_Result() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Login_Request")]
  public partial class Login_Request : global::ProtoBuf.IExtensible
  {
    public Login_Request() {}
    
    private string _accountId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string accountId
    {
      get { return _accountId; }
      set { _accountId = value; }
    }
    private string _accountPassWord = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"accountPassWord", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string accountPassWord
    {
      get { return _accountPassWord; }
      set { _accountPassWord = value; }
    }
    private bool _onWebGL = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"onWebGL", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool onWebGL
    {
      get { return _onWebGL; }
      set { _onWebGL = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Login_Result")]
  public partial class Login_Result : global::ProtoBuf.IExtensible
  {
    public Login_Result() {}
    
    private string _uid = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private bool _firstEnter = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"firstEnter", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool firstEnter
    {
      get { return _firstEnter; }
      set { _firstEnter = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _serverId = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"serverId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<int> serverId
    {
      get { return _serverId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateRole_Request")]
  public partial class CreateRole_Request : global::ProtoBuf.IExtensible
  {
    public CreateRole_Request() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _characterType = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"characterType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int characterType
    {
      get { return _characterType; }
      set { _characterType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateRole_Result")]
  public partial class CreateRole_Result : global::ProtoBuf.IExtensible
  {
    public CreateRole_Result() {}
    
    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
    private string _msg = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"PacketType")]
    public enum PacketType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"None", Value=0)]
      None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HeartBeat", Value=1000)]
      HeartBeat = 1000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Login", Value=1001)]
      Login = 1001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CreateRole", Value=1002)]
      CreateRole = 1002
    }
  
}