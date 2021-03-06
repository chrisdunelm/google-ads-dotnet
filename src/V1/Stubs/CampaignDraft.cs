// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/campaign_draft.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/campaign_draft.proto</summary>
  public static partial class CampaignDraftReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/campaign_draft.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignDraftReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "ZHJhZnQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNl",
            "cxo5Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvZW51bXMvY2FtcGFpZ25fZHJh",
            "ZnRfc3RhdHVzLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJv",
            "dG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iwgMKDUNhbXBhaWdu",
            "RHJhZnQSFQoNcmVzb3VyY2VfbmFtZRgBIAEoCRItCghkcmFmdF9pZBgCIAEo",
            "CzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlEjMKDWJhc2VfY2FtcGFp",
            "Z24YAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSKgoEbmFt",
            "ZRgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRI0Cg5kcmFm",
            "dF9jYW1wYWlnbhgFIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1",
            "ZRJaCgZzdGF0dXMYBiABKA4ySi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5l",
            "bnVtcy5DYW1wYWlnbkRyYWZ0U3RhdHVzRW51bS5DYW1wYWlnbkRyYWZ0U3Rh",
            "dHVzEjoKFmhhc19leHBlcmltZW50X3J1bm5pbmcYByABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuQm9vbFZhbHVlEjwKFmxvbmdfcnVubmluZ19vcGVyYXRpb24Y",
            "CCABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVC/wEKJWNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MS5yZXNvdXJjZXNCEkNhbXBhaWduRHJh",
            "ZnRQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dB",
            "QaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLlJlc291cmNlc8oCIUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYxOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Enums.CampaignDraftStatusReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.CampaignDraft), global::Google.Ads.GoogleAds.V1.Resources.CampaignDraft.Parser, new[]{ "ResourceName", "DraftId", "BaseCampaign", "Name", "DraftCampaign", "Status", "HasExperimentRunning", "LongRunningOperation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign draft.
  /// </summary>
  public sealed partial class CampaignDraft : pb::IMessage<CampaignDraft> {
    private static readonly pb::MessageParser<CampaignDraft> _parser = new pb::MessageParser<CampaignDraft>(() => new CampaignDraft());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignDraft> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.CampaignDraftReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignDraft() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignDraft(CampaignDraft other) : this() {
      resourceName_ = other.resourceName_;
      DraftId = other.DraftId;
      BaseCampaign = other.BaseCampaign;
      Name = other.Name;
      DraftCampaign = other.DraftCampaign;
      status_ = other.status_;
      HasExperimentRunning = other.HasExperimentRunning;
      LongRunningOperation = other.LongRunningOperation;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignDraft Clone() {
      return new CampaignDraft(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the campaign draft.
    /// Campaign draft resource names have the form:
    ///
    /// `customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "draft_id" field.</summary>
    public const int DraftIdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_draftId_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? draftId_;
    /// <summary>
    /// The ID of the draft.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? DraftId {
      get { return draftId_; }
      set {
        draftId_ = value;
      }
    }

    /// <summary>Field number for the "base_campaign" field.</summary>
    public const int BaseCampaignFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_baseCampaign_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string baseCampaign_;
    /// <summary>
    /// The base campaign to which the draft belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BaseCampaign {
      get { return baseCampaign_; }
      set {
        baseCampaign_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// The name of the campaign draft.
    ///
    /// This field is required and should not be empty when creating new
    /// campaign drafts.
    ///
    /// It must not contain any null (code point 0x0), NL line feed
    /// (code point 0xA) or carriage return (code point 0xD) characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }

    /// <summary>Field number for the "draft_campaign" field.</summary>
    public const int DraftCampaignFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_draftCampaign_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string draftCampaign_;
    /// <summary>
    /// Resource name of the Campaign that results from overlaying the draft
    /// changes onto the base campaign.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DraftCampaign {
      get { return draftCampaign_; }
      set {
        draftCampaign_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V1.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus status_ = 0;
    /// <summary>
    /// The status of the campaign draft. This field is read-only.
    ///
    /// When a new campaign draft is added, the status defaults to PROPOSED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "has_experiment_running" field.</summary>
    public const int HasExperimentRunningFieldNumber = 7;
    private static readonly pb::FieldCodec<bool?> _single_hasExperimentRunning_codec = pb::FieldCodec.ForStructWrapper<bool>(58);
    private bool? hasExperimentRunning_;
    /// <summary>
    /// Whether there is an experiment based on this draft currently serving.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? HasExperimentRunning {
      get { return hasExperimentRunning_; }
      set {
        hasExperimentRunning_ = value;
      }
    }

    /// <summary>Field number for the "long_running_operation" field.</summary>
    public const int LongRunningOperationFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _single_longRunningOperation_codec = pb::FieldCodec.ForClassWrapper<string>(66);
    private string longRunningOperation_;
    /// <summary>
    /// The resource name of the long-running operation that can be used to poll
    /// for completion of draft promotion. This is only set if the draft promotion
    /// is in progress or finished.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LongRunningOperation {
      get { return longRunningOperation_; }
      set {
        longRunningOperation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignDraft);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignDraft other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (DraftId != other.DraftId) return false;
      if (BaseCampaign != other.BaseCampaign) return false;
      if (Name != other.Name) return false;
      if (DraftCampaign != other.DraftCampaign) return false;
      if (Status != other.Status) return false;
      if (HasExperimentRunning != other.HasExperimentRunning) return false;
      if (LongRunningOperation != other.LongRunningOperation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (draftId_ != null) hash ^= DraftId.GetHashCode();
      if (baseCampaign_ != null) hash ^= BaseCampaign.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (draftCampaign_ != null) hash ^= DraftCampaign.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (hasExperimentRunning_ != null) hash ^= HasExperimentRunning.GetHashCode();
      if (longRunningOperation_ != null) hash ^= LongRunningOperation.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (draftId_ != null) {
        _single_draftId_codec.WriteTagAndValue(output, DraftId);
      }
      if (baseCampaign_ != null) {
        _single_baseCampaign_codec.WriteTagAndValue(output, BaseCampaign);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (draftCampaign_ != null) {
        _single_draftCampaign_codec.WriteTagAndValue(output, DraftCampaign);
      }
      if (Status != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (hasExperimentRunning_ != null) {
        _single_hasExperimentRunning_codec.WriteTagAndValue(output, HasExperimentRunning);
      }
      if (longRunningOperation_ != null) {
        _single_longRunningOperation_codec.WriteTagAndValue(output, LongRunningOperation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (draftId_ != null) {
        size += _single_draftId_codec.CalculateSizeWithTag(DraftId);
      }
      if (baseCampaign_ != null) {
        size += _single_baseCampaign_codec.CalculateSizeWithTag(BaseCampaign);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (draftCampaign_ != null) {
        size += _single_draftCampaign_codec.CalculateSizeWithTag(DraftCampaign);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (hasExperimentRunning_ != null) {
        size += _single_hasExperimentRunning_codec.CalculateSizeWithTag(HasExperimentRunning);
      }
      if (longRunningOperation_ != null) {
        size += _single_longRunningOperation_codec.CalculateSizeWithTag(LongRunningOperation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignDraft other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.draftId_ != null) {
        if (draftId_ == null || other.DraftId != 0L) {
          DraftId = other.DraftId;
        }
      }
      if (other.baseCampaign_ != null) {
        if (baseCampaign_ == null || other.BaseCampaign != "") {
          BaseCampaign = other.BaseCampaign;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.draftCampaign_ != null) {
        if (draftCampaign_ == null || other.DraftCampaign != "") {
          DraftCampaign = other.DraftCampaign;
        }
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.hasExperimentRunning_ != null) {
        if (hasExperimentRunning_ == null || other.HasExperimentRunning != false) {
          HasExperimentRunning = other.HasExperimentRunning;
        }
      }
      if (other.longRunningOperation_ != null) {
        if (longRunningOperation_ == null || other.LongRunningOperation != "") {
          LongRunningOperation = other.LongRunningOperation;
        }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_draftId_codec.Read(input);
            if (draftId_ == null || value != 0L) {
              DraftId = value;
            }
            break;
          }
          case 26: {
            string value = _single_baseCampaign_codec.Read(input);
            if (baseCampaign_ == null || value != "") {
              BaseCampaign = value;
            }
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 42: {
            string value = _single_draftCampaign_codec.Read(input);
            if (draftCampaign_ == null || value != "") {
              DraftCampaign = value;
            }
            break;
          }
          case 48: {
            status_ = (global::Google.Ads.GoogleAds.V1.Enums.CampaignDraftStatusEnum.Types.CampaignDraftStatus) input.ReadEnum();
            break;
          }
          case 58: {
            bool? value = _single_hasExperimentRunning_codec.Read(input);
            if (hasExperimentRunning_ == null || value != false) {
              HasExperimentRunning = value;
            }
            break;
          }
          case 66: {
            string value = _single_longRunningOperation_codec.Read(input);
            if (longRunningOperation_ == null || value != "") {
              LongRunningOperation = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
