// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: image.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mmind {

  /// <summary>Holder for reflection information generated from image.proto</summary>
  public static partial class ImageReflection {

    #region Descriptor
    /// <summary>File descriptor for image.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtpbWFnZS5wcm90bxIFbW1pbmQiWQoHUmVxdWVzdBIPCgdjb21tYW5kGAEg",
            "ASgFEhMKC3ZhbHVlRG91YmxlGAIgASgBEhMKC21lcmdlTWF0cml4GAMgAygB",
            "EhMKC3ZhbHVlU3RyaW5nGAQgASgJIqQCCghSZXNwb25zZRIPCgdjb21tYW5k",
            "GAEgASgFEhAKCGltYWdlUkdCGAIgASgMEhIKCmltYWdlRGVwdGgYAyABKAwS",
            "DwoHaW1hZ2VJchgEIAEoDBIRCgljYW1lcmFJZHMYBSADKAkSFAoMaW1hZ2VH",
            "cmF0aW5nGAYgASgMEhAKCGNhbUludHJpGAcgASgJEhQKDG9mZnNldFBhcmFt",
            "cxgIIAEoCRIUCgxjYW1lcmFTdGF0dXMYCSABKAkSFAoMc3RlcmVvSW1hZ2Vz",
            "GAogASgMEhcKD2lzTG93QnJpZ2h0bmVzcxgLIAEoCBITCgtyZW1hcFBhcmFt",
            "cxgMIAEoCRIWCg5wYXJhbWV0ZXJWYWx1ZRgNIAEoCRINCgVlcnJvchgOIAEo",
            "CWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mmind.Request), global::Mmind.Request.Parser, new[]{ "Command", "ValueDouble", "MergeMatrix", "ValueString" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mmind.Response), global::Mmind.Response.Parser, new[]{ "Command", "ImageRGB", "ImageDepth", "ImageIr", "CameraIds", "ImageGrating", "CamIntri", "OffsetParams", "CameraStatus", "StereoImages", "IsLowBrightness", "RemapParams", "ParameterValue", "Error" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mmind.ImageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      command_ = other.command_;
      valueDouble_ = other.valueDouble_;
      mergeMatrix_ = other.mergeMatrix_.Clone();
      valueString_ = other.valueString_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int CommandFieldNumber = 1;
    private int command_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Command {
      get { return command_; }
      set {
        command_ = value;
      }
    }

    /// <summary>Field number for the "valueDouble" field.</summary>
    public const int ValueDoubleFieldNumber = 2;
    private double valueDouble_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double ValueDouble {
      get { return valueDouble_; }
      set {
        valueDouble_ = value;
      }
    }

    /// <summary>Field number for the "mergeMatrix" field.</summary>
    public const int MergeMatrixFieldNumber = 3;
    private static readonly pb::FieldCodec<double> _repeated_mergeMatrix_codec
        = pb::FieldCodec.ForDouble(26);
    private readonly pbc::RepeatedField<double> mergeMatrix_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> MergeMatrix {
      get { return mergeMatrix_; }
    }

    /// <summary>Field number for the "valueString" field.</summary>
    public const int ValueStringFieldNumber = 4;
    private string valueString_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValueString {
      get { return valueString_; }
      set {
        valueString_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Command != other.Command) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ValueDouble, other.ValueDouble)) return false;
      if(!mergeMatrix_.Equals(other.mergeMatrix_)) return false;
      if (ValueString != other.ValueString) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Command != 0) hash ^= Command.GetHashCode();
      if (ValueDouble != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ValueDouble);
      hash ^= mergeMatrix_.GetHashCode();
      if (ValueString.Length != 0) hash ^= ValueString.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Command != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Command);
      }
      if (ValueDouble != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(ValueDouble);
      }
      mergeMatrix_.WriteTo(output, _repeated_mergeMatrix_codec);
      if (ValueString.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ValueString);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Command != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Command);
      }
      if (ValueDouble != 0D) {
        size += 1 + 8;
      }
      size += mergeMatrix_.CalculateSize(_repeated_mergeMatrix_codec);
      if (ValueString.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValueString);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.Command != 0) {
        Command = other.Command;
      }
      if (other.ValueDouble != 0D) {
        ValueDouble = other.ValueDouble;
      }
      mergeMatrix_.Add(other.mergeMatrix_);
      if (other.ValueString.Length != 0) {
        ValueString = other.ValueString;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Command = input.ReadInt32();
            break;
          }
          case 17: {
            ValueDouble = input.ReadDouble();
            break;
          }
          case 26:
          case 25: {
            mergeMatrix_.AddEntriesFrom(input, _repeated_mergeMatrix_codec);
            break;
          }
          case 34: {
            ValueString = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mmind.ImageReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      command_ = other.command_;
      imageRGB_ = other.imageRGB_;
      imageDepth_ = other.imageDepth_;
      imageIr_ = other.imageIr_;
      cameraIds_ = other.cameraIds_.Clone();
      imageGrating_ = other.imageGrating_;
      camIntri_ = other.camIntri_;
      offsetParams_ = other.offsetParams_;
      cameraStatus_ = other.cameraStatus_;
      stereoImages_ = other.stereoImages_;
      isLowBrightness_ = other.isLowBrightness_;
      remapParams_ = other.remapParams_;
      parameterValue_ = other.parameterValue_;
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "command" field.</summary>
    public const int CommandFieldNumber = 1;
    private int command_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Command {
      get { return command_; }
      set {
        command_ = value;
      }
    }

    /// <summary>Field number for the "imageRGB" field.</summary>
    public const int ImageRGBFieldNumber = 2;
    private pb::ByteString imageRGB_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ImageRGB {
      get { return imageRGB_; }
      set {
        imageRGB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "imageDepth" field.</summary>
    public const int ImageDepthFieldNumber = 3;
    private pb::ByteString imageDepth_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ImageDepth {
      get { return imageDepth_; }
      set {
        imageDepth_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "imageIr" field.</summary>
    public const int ImageIrFieldNumber = 4;
    private pb::ByteString imageIr_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ImageIr {
      get { return imageIr_; }
      set {
        imageIr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cameraIds" field.</summary>
    public const int CameraIdsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_cameraIds_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> cameraIds_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> CameraIds {
      get { return cameraIds_; }
    }

    /// <summary>Field number for the "imageGrating" field.</summary>
    public const int ImageGratingFieldNumber = 6;
    private pb::ByteString imageGrating_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ImageGrating {
      get { return imageGrating_; }
      set {
        imageGrating_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "camIntri" field.</summary>
    public const int CamIntriFieldNumber = 7;
    private string camIntri_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CamIntri {
      get { return camIntri_; }
      set {
        camIntri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "offsetParams" field.</summary>
    public const int OffsetParamsFieldNumber = 8;
    private string offsetParams_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OffsetParams {
      get { return offsetParams_; }
      set {
        offsetParams_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cameraStatus" field.</summary>
    public const int CameraStatusFieldNumber = 9;
    private string cameraStatus_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CameraStatus {
      get { return cameraStatus_; }
      set {
        cameraStatus_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stereoImages" field.</summary>
    public const int StereoImagesFieldNumber = 10;
    private pb::ByteString stereoImages_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString StereoImages {
      get { return stereoImages_; }
      set {
        stereoImages_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "isLowBrightness" field.</summary>
    public const int IsLowBrightnessFieldNumber = 11;
    private bool isLowBrightness_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsLowBrightness {
      get { return isLowBrightness_; }
      set {
        isLowBrightness_ = value;
      }
    }

    /// <summary>Field number for the "remapParams" field.</summary>
    public const int RemapParamsFieldNumber = 12;
    private string remapParams_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RemapParams {
      get { return remapParams_; }
      set {
        remapParams_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parameterValue" field.</summary>
    public const int ParameterValueFieldNumber = 13;
    private string parameterValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ParameterValue {
      get { return parameterValue_; }
      set {
        parameterValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 14;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Command != other.Command) return false;
      if (ImageRGB != other.ImageRGB) return false;
      if (ImageDepth != other.ImageDepth) return false;
      if (ImageIr != other.ImageIr) return false;
      if(!cameraIds_.Equals(other.cameraIds_)) return false;
      if (ImageGrating != other.ImageGrating) return false;
      if (CamIntri != other.CamIntri) return false;
      if (OffsetParams != other.OffsetParams) return false;
      if (CameraStatus != other.CameraStatus) return false;
      if (StereoImages != other.StereoImages) return false;
      if (IsLowBrightness != other.IsLowBrightness) return false;
      if (RemapParams != other.RemapParams) return false;
      if (ParameterValue != other.ParameterValue) return false;
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Command != 0) hash ^= Command.GetHashCode();
      if (ImageRGB.Length != 0) hash ^= ImageRGB.GetHashCode();
      if (ImageDepth.Length != 0) hash ^= ImageDepth.GetHashCode();
      if (ImageIr.Length != 0) hash ^= ImageIr.GetHashCode();
      hash ^= cameraIds_.GetHashCode();
      if (ImageGrating.Length != 0) hash ^= ImageGrating.GetHashCode();
      if (CamIntri.Length != 0) hash ^= CamIntri.GetHashCode();
      if (OffsetParams.Length != 0) hash ^= OffsetParams.GetHashCode();
      if (CameraStatus.Length != 0) hash ^= CameraStatus.GetHashCode();
      if (StereoImages.Length != 0) hash ^= StereoImages.GetHashCode();
      if (IsLowBrightness != false) hash ^= IsLowBrightness.GetHashCode();
      if (RemapParams.Length != 0) hash ^= RemapParams.GetHashCode();
      if (ParameterValue.Length != 0) hash ^= ParameterValue.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Command != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Command);
      }
      if (ImageRGB.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(ImageRGB);
      }
      if (ImageDepth.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(ImageDepth);
      }
      if (ImageIr.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(ImageIr);
      }
      cameraIds_.WriteTo(output, _repeated_cameraIds_codec);
      if (ImageGrating.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(ImageGrating);
      }
      if (CamIntri.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(CamIntri);
      }
      if (OffsetParams.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(OffsetParams);
      }
      if (CameraStatus.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(CameraStatus);
      }
      if (StereoImages.Length != 0) {
        output.WriteRawTag(82);
        output.WriteBytes(StereoImages);
      }
      if (IsLowBrightness != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsLowBrightness);
      }
      if (RemapParams.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(RemapParams);
      }
      if (ParameterValue.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ParameterValue);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Command != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Command);
      }
      if (ImageRGB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ImageRGB);
      }
      if (ImageDepth.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ImageDepth);
      }
      if (ImageIr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ImageIr);
      }
      size += cameraIds_.CalculateSize(_repeated_cameraIds_codec);
      if (ImageGrating.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ImageGrating);
      }
      if (CamIntri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CamIntri);
      }
      if (OffsetParams.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OffsetParams);
      }
      if (CameraStatus.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CameraStatus);
      }
      if (StereoImages.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(StereoImages);
      }
      if (IsLowBrightness != false) {
        size += 1 + 1;
      }
      if (RemapParams.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemapParams);
      }
      if (ParameterValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParameterValue);
      }
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.Command != 0) {
        Command = other.Command;
      }
      if (other.ImageRGB.Length != 0) {
        ImageRGB = other.ImageRGB;
      }
      if (other.ImageDepth.Length != 0) {
        ImageDepth = other.ImageDepth;
      }
      if (other.ImageIr.Length != 0) {
        ImageIr = other.ImageIr;
      }
      cameraIds_.Add(other.cameraIds_);
      if (other.ImageGrating.Length != 0) {
        ImageGrating = other.ImageGrating;
      }
      if (other.CamIntri.Length != 0) {
        CamIntri = other.CamIntri;
      }
      if (other.OffsetParams.Length != 0) {
        OffsetParams = other.OffsetParams;
      }
      if (other.CameraStatus.Length != 0) {
        CameraStatus = other.CameraStatus;
      }
      if (other.StereoImages.Length != 0) {
        StereoImages = other.StereoImages;
      }
      if (other.IsLowBrightness != false) {
        IsLowBrightness = other.IsLowBrightness;
      }
      if (other.RemapParams.Length != 0) {
        RemapParams = other.RemapParams;
      }
      if (other.ParameterValue.Length != 0) {
        ParameterValue = other.ParameterValue;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Command = input.ReadInt32();
            break;
          }
          case 18: {
            ImageRGB = input.ReadBytes();
            break;
          }
          case 26: {
            ImageDepth = input.ReadBytes();
            break;
          }
          case 34: {
            ImageIr = input.ReadBytes();
            break;
          }
          case 42: {
            cameraIds_.AddEntriesFrom(input, _repeated_cameraIds_codec);
            break;
          }
          case 50: {
            ImageGrating = input.ReadBytes();
            break;
          }
          case 58: {
            CamIntri = input.ReadString();
            break;
          }
          case 66: {
            OffsetParams = input.ReadString();
            break;
          }
          case 74: {
            CameraStatus = input.ReadString();
            break;
          }
          case 82: {
            StereoImages = input.ReadBytes();
            break;
          }
          case 88: {
            IsLowBrightness = input.ReadBool();
            break;
          }
          case 98: {
            RemapParams = input.ReadString();
            break;
          }
          case 106: {
            ParameterValue = input.ReadString();
            break;
          }
          case 114: {
            Error = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
