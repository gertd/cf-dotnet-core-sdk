﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: uuid.proto
namespace CloudFoundry.Doppler.DropsondeProtocol
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UUID")]
    public partial class UUID : global::ProtoBuf.IExtensible
    {
        public UUID() { }

        private ulong _low;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"low", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public ulong low
        {
            get { return _low; }
            set { _low = value; }
        }
        private ulong _high;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"high", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public ulong high
        {
            get { return _high; }
            set { _high = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}
// Generated from: http.proto
// Note: requires additional types generated from: uuid.proto
namespace CloudFoundry.Doppler.DropsondeProtocol
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"HttpStartStop")]
    public partial class HttpStartStop : global::ProtoBuf.IExtensible
    {
        public HttpStartStop() { }

        private long _startTimestamp;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"startTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public long startTimestamp
        {
            get { return _startTimestamp; }
            set { _startTimestamp = value; }
        }
        private long _stopTimestamp;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"stopTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public long stopTimestamp
        {
            get { return _stopTimestamp; }
            set { _stopTimestamp = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.UUID _requestId;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"requestId", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public CloudFoundry.Doppler.DropsondeProtocol.UUID requestId
        {
            get { return _requestId; }
            set { _requestId = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.PeerType _peerType;
        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"peerType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public CloudFoundry.Doppler.DropsondeProtocol.PeerType peerType
        {
            get { return _peerType; }
            set { _peerType = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.Method _method;
        [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name = @"method", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public CloudFoundry.Doppler.DropsondeProtocol.Method method
        {
            get { return _method; }
            set { _method = value; }
        }
        private string _uri;
        [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name = @"uri", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string uri
        {
            get { return _uri; }
            set { _uri = value; }
        }
        private string _remoteAddress;
        [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name = @"remoteAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string remoteAddress
        {
            get { return _remoteAddress; }
            set { _remoteAddress = value; }
        }
        private string _userAgent;
        [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name = @"userAgent", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string userAgent
        {
            get { return _userAgent; }
            set { _userAgent = value; }
        }
        private int _statusCode;
        [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name = @"statusCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int statusCode
        {
            get { return _statusCode; }
            set { _statusCode = value; }
        }
        private long _contentLength;
        [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name = @"contentLength", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public long contentLength
        {
            get { return _contentLength; }
            set { _contentLength = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.UUID _applicationId = null;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"applicationId", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.UUID applicationId
        {
            get { return _applicationId; }
            set { _applicationId = value; }
        }
        private int _instanceIndex = default(int);
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"instanceIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int instanceIndex
        {
            get { return _instanceIndex; }
            set { _instanceIndex = value; }
        }
        private string _instanceId = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"instanceId", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string instanceId
        {
            get { return _instanceId; }
            set { _instanceId = value; }
        }
        private readonly global::System.Collections.Generic.List<string> _forwarded = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(15, Name = @"forwarded", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> forwarded
        {
            get { return _forwarded; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"PeerType")]
    public enum PeerType
    {

        [global::ProtoBuf.ProtoEnum(Name = @"Client", Value = 1)]
        Client = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"Server", Value = 2)]
        Server = 2
    }

    [global::ProtoBuf.ProtoContract(Name = @"Method")]
    public enum Method
    {

        [global::ProtoBuf.ProtoEnum(Name = @"GET", Value = 1)]
        GET = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"POST", Value = 2)]
        POST = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"PUT", Value = 3)]
        PUT = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"DELETE", Value = 4)]
        DELETE = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"HEAD", Value = 5)]
        HEAD = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"ACL", Value = 6)]
        ACL = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"BASELINE_CONTROL", Value = 7)]
        BASELINE_CONTROL = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"BIND", Value = 8)]
        BIND = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"CHECKIN", Value = 9)]
        CHECKIN = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"CHECKOUT", Value = 10)]
        CHECKOUT = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"CONNECT", Value = 11)]
        CONNECT = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"COPY", Value = 12)]
        COPY = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"DEBUG", Value = 13)]
        DEBUG = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"LABEL", Value = 14)]
        LABEL = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"LINK", Value = 15)]
        LINK = 15,

        [global::ProtoBuf.ProtoEnum(Name = @"LOCK", Value = 16)]
        LOCK = 16,

        [global::ProtoBuf.ProtoEnum(Name = @"MERGE", Value = 17)]
        MERGE = 17,

        [global::ProtoBuf.ProtoEnum(Name = @"MKACTIVITY", Value = 18)]
        MKACTIVITY = 18,

        [global::ProtoBuf.ProtoEnum(Name = @"MKCALENDAR", Value = 19)]
        MKCALENDAR = 19,

        [global::ProtoBuf.ProtoEnum(Name = @"MKCOL", Value = 20)]
        MKCOL = 20,

        [global::ProtoBuf.ProtoEnum(Name = @"MKREDIRECTREF", Value = 21)]
        MKREDIRECTREF = 21,

        [global::ProtoBuf.ProtoEnum(Name = @"MKWORKSPACE", Value = 22)]
        MKWORKSPACE = 22,

        [global::ProtoBuf.ProtoEnum(Name = @"MOVE", Value = 23)]
        MOVE = 23,

        [global::ProtoBuf.ProtoEnum(Name = @"OPTIONS", Value = 24)]
        OPTIONS = 24,

        [global::ProtoBuf.ProtoEnum(Name = @"ORDERPATCH", Value = 25)]
        ORDERPATCH = 25,

        [global::ProtoBuf.ProtoEnum(Name = @"PATCH", Value = 26)]
        PATCH = 26,

        [global::ProtoBuf.ProtoEnum(Name = @"PRI", Value = 27)]
        PRI = 27,

        [global::ProtoBuf.ProtoEnum(Name = @"PROPFIND", Value = 28)]
        PROPFIND = 28,

        [global::ProtoBuf.ProtoEnum(Name = @"PROPPATCH", Value = 29)]
        PROPPATCH = 29,

        [global::ProtoBuf.ProtoEnum(Name = @"REBIND", Value = 30)]
        REBIND = 30,

        [global::ProtoBuf.ProtoEnum(Name = @"REPORT", Value = 31)]
        REPORT = 31,

        [global::ProtoBuf.ProtoEnum(Name = @"SEARCH", Value = 32)]
        SEARCH = 32,

        [global::ProtoBuf.ProtoEnum(Name = @"SHOWMETHOD", Value = 33)]
        SHOWMETHOD = 33,

        [global::ProtoBuf.ProtoEnum(Name = @"SPACEJUMP", Value = 34)]
        SPACEJUMP = 34,

        [global::ProtoBuf.ProtoEnum(Name = @"TEXTSEARCH", Value = 35)]
        TEXTSEARCH = 35,

        [global::ProtoBuf.ProtoEnum(Name = @"TRACE", Value = 36)]
        TRACE = 36,

        [global::ProtoBuf.ProtoEnum(Name = @"TRACK", Value = 37)]
        TRACK = 37,

        [global::ProtoBuf.ProtoEnum(Name = @"UNBIND", Value = 38)]
        UNBIND = 38,

        [global::ProtoBuf.ProtoEnum(Name = @"UNCHECKOUT", Value = 39)]
        UNCHECKOUT = 39,

        [global::ProtoBuf.ProtoEnum(Name = @"UNLINK", Value = 40)]
        UNLINK = 40,

        [global::ProtoBuf.ProtoEnum(Name = @"UNLOCK", Value = 41)]
        UNLOCK = 41,

        [global::ProtoBuf.ProtoEnum(Name = @"UPDATE", Value = 42)]
        UPDATE = 42,

        [global::ProtoBuf.ProtoEnum(Name = @"UPDATEREDIRECTREF", Value = 43)]
        UPDATEREDIRECTREF = 43,

        [global::ProtoBuf.ProtoEnum(Name = @"VERSION_CONTROL", Value = 44)]
        VERSION_CONTROL = 44
    }

}
// Generated from: log.proto
namespace CloudFoundry.Doppler.DropsondeProtocol
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"LogMessage")]
    public partial class LogMessage : global::ProtoBuf.IExtensible
    {
        public LogMessage() { }

        private byte[] _message;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public byte[] message
        {
            get { return _message; }
            set { _message = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.LogMessage.MessageType _message_type;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"message_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public CloudFoundry.Doppler.DropsondeProtocol.LogMessage.MessageType message_type
        {
            get { return _message_type; }
            set { _message_type = value; }
        }
        private long _timestamp;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public long timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }
        private string _app_id = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"app_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string app_id
        {
            get { return _app_id; }
            set { _app_id = value; }
        }
        private string _source_type = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"source_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string source_type
        {
            get { return _source_type; }
            set { _source_type = value; }
        }
        private string _source_instance = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"source_instance", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string source_instance
        {
            get { return _source_instance; }
            set { _source_instance = value; }
        }
        [global::ProtoBuf.ProtoContract(Name = @"MessageType")]
        public enum MessageType
        {

            [global::ProtoBuf.ProtoEnum(Name = @"OUT", Value = 1)]
            OUT = 1,

            [global::ProtoBuf.ProtoEnum(Name = @"ERR", Value = 2)]
            ERR = 2
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}
// Generated from: metric.proto
// Note: requires additional types generated from: uuid.proto
namespace CloudFoundry.Doppler.DropsondeProtocol
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"ValueMetric")]
    public partial class ValueMetric : global::ProtoBuf.IExtensible
    {
        public ValueMetric() { }

        private string _name;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _value;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public double value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _unit;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CounterEvent")]
    public partial class CounterEvent : global::ProtoBuf.IExtensible
    {
        public CounterEvent() { }

        private string _name;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private ulong _delta;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"delta", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public ulong delta
        {
            get { return _delta; }
            set { _delta = value; }
        }
        private ulong _total = default(ulong);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"total", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong total
        {
            get { return _total; }
            set { _total = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"ContainerMetric")]
    public partial class ContainerMetric : global::ProtoBuf.IExtensible
    {
        public ContainerMetric() { }

        private string _applicationId;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"applicationId", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string applicationId
        {
            get { return _applicationId; }
            set { _applicationId = value; }
        }
        private int _instanceIndex;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"instanceIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int instanceIndex
        {
            get { return _instanceIndex; }
            set { _instanceIndex = value; }
        }
        private double _cpuPercentage;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"cpuPercentage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public double cpuPercentage
        {
            get { return _cpuPercentage; }
            set { _cpuPercentage = value; }
        }
        private ulong _memoryBytes;
        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"memoryBytes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public ulong memoryBytes
        {
            get { return _memoryBytes; }
            set { _memoryBytes = value; }
        }
        private ulong _diskBytes;
        [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name = @"diskBytes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public ulong diskBytes
        {
            get { return _diskBytes; }
            set { _diskBytes = value; }
        }
        private ulong _memoryBytesQuota = default(ulong);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"memoryBytesQuota", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong memoryBytesQuota
        {
            get { return _memoryBytesQuota; }
            set { _memoryBytesQuota = value; }
        }
        private ulong _diskBytesQuota = default(ulong);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"diskBytesQuota", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong diskBytesQuota
        {
            get { return _diskBytesQuota; }
            set { _diskBytesQuota = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}
// Generated from: error.proto
namespace CloudFoundry.Doppler.DropsondeProtocol
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Error")]
    public partial class Error : global::ProtoBuf.IExtensible
    {
        public Error() { }

        private string _source;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"source", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string source
        {
            get { return _source; }
            set { _source = value; }
        }
        private int _code;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _message;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}
// Generated from: envelope.proto
// Note: requires additional types generated from: http.proto
// Note: requires additional types generated from: log.proto
// Note: requires additional types generated from: metric.proto
// Note: requires additional types generated from: error.proto
namespace CloudFoundry.Doppler.DropsondeProtocol
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Envelope")]
    public partial class Envelope : global::ProtoBuf.IExtensible
    {
        public Envelope() { }

        private string _origin;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string origin
        {
            get { return _origin; }
            set { _origin = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.Envelope.EventType _eventType;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"eventType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public CloudFoundry.Doppler.DropsondeProtocol.Envelope.EventType eventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }
        private long _timestamp = default(long);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(long))]
        public long timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }
        private string _deployment = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"deployment", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string deployment
        {
            get { return _deployment; }
            set { _deployment = value; }
        }
        private string _job = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"job", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string job
        {
            get { return _job; }
            set { _job = value; }
        }
        private string _index = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"index", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string index
        {
            get { return _index; }
            set { _index = value; }
        }
        private string _ip = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name = @"ip", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }
        private readonly global::System.Collections.Generic.List<CloudFoundry.Doppler.DropsondeProtocol.Envelope.TagsEntry> _tags = new global::System.Collections.Generic.List<CloudFoundry.Doppler.DropsondeProtocol.Envelope.TagsEntry>();
        [global::ProtoBuf.ProtoMember(17, Name = @"tags", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CloudFoundry.Doppler.DropsondeProtocol.Envelope.TagsEntry> tags
        {
            get { return _tags; }
        }

        private CloudFoundry.Doppler.DropsondeProtocol.HttpStartStop _httpStartStop = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"httpStartStop", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.HttpStartStop httpStartStop
        {
            get { return _httpStartStop; }
            set { _httpStartStop = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.LogMessage _logMessage = null;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"logMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.LogMessage logMessage
        {
            get { return _logMessage; }
            set { _logMessage = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.ValueMetric _valueMetric = null;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"valueMetric", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.ValueMetric valueMetric
        {
            get { return _valueMetric; }
            set { _valueMetric = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.CounterEvent _counterEvent = null;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"counterEvent", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.CounterEvent counterEvent
        {
            get { return _counterEvent; }
            set { _counterEvent = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.Error _error = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"error", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.Error error
        {
            get { return _error; }
            set { _error = value; }
        }
        private CloudFoundry.Doppler.DropsondeProtocol.ContainerMetric _containerMetric = null;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"containerMetric", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CloudFoundry.Doppler.DropsondeProtocol.ContainerMetric containerMetric
        {
            get { return _containerMetric; }
            set { _containerMetric = value; }
        }
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"TagsEntry")]
        public partial class TagsEntry : global::ProtoBuf.IExtensible
        {
            public TagsEntry() { }

            private string _key = "";
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string key
            {
                get { return _key; }
                set { _key = value; }
            }
            private string _value = "";
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get { return _value; }
                set { _value = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::ProtoBuf.ProtoContract(Name = @"EventType")]
        public enum EventType
        {

            [global::ProtoBuf.ProtoEnum(Name = @"HttpStartStop", Value = 4)]
            HttpStartStop = 4,

            [global::ProtoBuf.ProtoEnum(Name = @"LogMessage", Value = 5)]
            LogMessage = 5,

            [global::ProtoBuf.ProtoEnum(Name = @"ValueMetric", Value = 6)]
            ValueMetric = 6,

            [global::ProtoBuf.ProtoEnum(Name = @"CounterEvent", Value = 7)]
            CounterEvent = 7,

            [global::ProtoBuf.ProtoEnum(Name = @"Error", Value = 8)]
            Error = 8,

            [global::ProtoBuf.ProtoEnum(Name = @"ContainerMetric", Value = 9)]
            ContainerMetric = 9
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}