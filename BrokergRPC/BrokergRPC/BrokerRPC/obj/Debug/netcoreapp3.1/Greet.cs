// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BrokerRPC {

  /// <summary>Holder for reflection information generated from Protos/greet.proto</summary>
  public static partial class GreetReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/greet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZ3JlZXQucHJvdG8SBWdyZWV0IrkBChJUcmFuc2FjdGlvbk1l",
            "c3NhZ2USFQoNb3duZXJfY2FyZF9pZBgBIAEoCRIZChFyZWNpcGllbnRfY2Fy",
            "ZF9pZBgCIAEoCRIYChB0cmFuc2FjdGlvbl9zdW1tGAMgASgFEgsKA2NjeRgE",
            "IAEoCRIZChFhZGl0aW9uYWxfY29tbWVudBgFIAEoCRIvCg90cmFuc2FjdGlv",
            "blR5cGUYBiABKA4yFi5ncmVldC5UeXBlVHJhbnNhY3Rpb24iNgoTVHJhbnNh",
            "Y3Rpb25SZXNwb25zZRIPCgdtZXNzYWdlGAEgASgJEg4KBnN0YXR1cxgCIAEo",
            "CCppCg9UeXBlVHJhbnNhY3Rpb24SCwoHUGF5bWVudBAAEgoKBkNyZWRpdBAB",
            "EhEKDUF1dGhvcml6YXRpb24QAhITCg9EZWxheWVkX0NhcHR1cmUQAxIICgRW",
            "b2lkEAQSCwoHUHJlbm90ZRAFMmAKEkV4ZWN1dGVUcmFuc2FjdGlvbhJKChFQ",
            "dWJsaWNUcmFuc2FjdGlvbhIZLmdyZWV0LlRyYW5zYWN0aW9uTWVzc2FnZRoa",
            "LmdyZWV0LlRyYW5zYWN0aW9uUmVzcG9uc2VCDKoCCUJyb2tlclJQQ2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::BrokerRPC.TypeTransaction), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BrokerRPC.TransactionMessage), global::BrokerRPC.TransactionMessage.Parser, new[]{ "OwnerCardId", "RecipientCardId", "TransactionSumm", "Ccy", "AditionalComment", "TransactionType" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BrokerRPC.TransactionResponse), global::BrokerRPC.TransactionResponse.Parser, new[]{ "Message", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum TypeTransaction {
    [pbr::OriginalName("Payment")] Payment = 0,
    [pbr::OriginalName("Credit")] Credit = 1,
    [pbr::OriginalName("Authorization")] Authorization = 2,
    [pbr::OriginalName("Delayed_Capture")] DelayedCapture = 3,
    [pbr::OriginalName("Void")] Void = 4,
    [pbr::OriginalName("Prenote")] Prenote = 5,
  }

  #endregion

  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class TransactionMessage : pb::IMessage<TransactionMessage> {
    private static readonly pb::MessageParser<TransactionMessage> _parser = new pb::MessageParser<TransactionMessage>(() => new TransactionMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransactionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BrokerRPC.GreetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionMessage(TransactionMessage other) : this() {
      ownerCardId_ = other.ownerCardId_;
      recipientCardId_ = other.recipientCardId_;
      transactionSumm_ = other.transactionSumm_;
      ccy_ = other.ccy_;
      aditionalComment_ = other.aditionalComment_;
      transactionType_ = other.transactionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionMessage Clone() {
      return new TransactionMessage(this);
    }

    /// <summary>Field number for the "owner_card_id" field.</summary>
    public const int OwnerCardIdFieldNumber = 1;
    private string ownerCardId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OwnerCardId {
      get { return ownerCardId_; }
      set {
        ownerCardId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "recipient_card_id" field.</summary>
    public const int RecipientCardIdFieldNumber = 2;
    private string recipientCardId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecipientCardId {
      get { return recipientCardId_; }
      set {
        recipientCardId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transaction_summ" field.</summary>
    public const int TransactionSummFieldNumber = 3;
    private int transactionSumm_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TransactionSumm {
      get { return transactionSumm_; }
      set {
        transactionSumm_ = value;
      }
    }

    /// <summary>Field number for the "ccy" field.</summary>
    public const int CcyFieldNumber = 4;
    private string ccy_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ccy {
      get { return ccy_; }
      set {
        ccy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "aditional_comment" field.</summary>
    public const int AditionalCommentFieldNumber = 5;
    private string aditionalComment_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AditionalComment {
      get { return aditionalComment_; }
      set {
        aditionalComment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transactionType" field.</summary>
    public const int TransactionTypeFieldNumber = 6;
    private global::BrokerRPC.TypeTransaction transactionType_ = global::BrokerRPC.TypeTransaction.Payment;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BrokerRPC.TypeTransaction TransactionType {
      get { return transactionType_; }
      set {
        transactionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransactionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransactionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerCardId != other.OwnerCardId) return false;
      if (RecipientCardId != other.RecipientCardId) return false;
      if (TransactionSumm != other.TransactionSumm) return false;
      if (Ccy != other.Ccy) return false;
      if (AditionalComment != other.AditionalComment) return false;
      if (TransactionType != other.TransactionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerCardId.Length != 0) hash ^= OwnerCardId.GetHashCode();
      if (RecipientCardId.Length != 0) hash ^= RecipientCardId.GetHashCode();
      if (TransactionSumm != 0) hash ^= TransactionSumm.GetHashCode();
      if (Ccy.Length != 0) hash ^= Ccy.GetHashCode();
      if (AditionalComment.Length != 0) hash ^= AditionalComment.GetHashCode();
      if (TransactionType != global::BrokerRPC.TypeTransaction.Payment) hash ^= TransactionType.GetHashCode();
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
      if (OwnerCardId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OwnerCardId);
      }
      if (RecipientCardId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RecipientCardId);
      }
      if (TransactionSumm != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TransactionSumm);
      }
      if (Ccy.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Ccy);
      }
      if (AditionalComment.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AditionalComment);
      }
      if (TransactionType != global::BrokerRPC.TypeTransaction.Payment) {
        output.WriteRawTag(48);
        output.WriteEnum((int) TransactionType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OwnerCardId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerCardId);
      }
      if (RecipientCardId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecipientCardId);
      }
      if (TransactionSumm != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TransactionSumm);
      }
      if (Ccy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ccy);
      }
      if (AditionalComment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AditionalComment);
      }
      if (TransactionType != global::BrokerRPC.TypeTransaction.Payment) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TransactionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransactionMessage other) {
      if (other == null) {
        return;
      }
      if (other.OwnerCardId.Length != 0) {
        OwnerCardId = other.OwnerCardId;
      }
      if (other.RecipientCardId.Length != 0) {
        RecipientCardId = other.RecipientCardId;
      }
      if (other.TransactionSumm != 0) {
        TransactionSumm = other.TransactionSumm;
      }
      if (other.Ccy.Length != 0) {
        Ccy = other.Ccy;
      }
      if (other.AditionalComment.Length != 0) {
        AditionalComment = other.AditionalComment;
      }
      if (other.TransactionType != global::BrokerRPC.TypeTransaction.Payment) {
        TransactionType = other.TransactionType;
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
            OwnerCardId = input.ReadString();
            break;
          }
          case 18: {
            RecipientCardId = input.ReadString();
            break;
          }
          case 24: {
            TransactionSumm = input.ReadInt32();
            break;
          }
          case 34: {
            Ccy = input.ReadString();
            break;
          }
          case 42: {
            AditionalComment = input.ReadString();
            break;
          }
          case 48: {
            TransactionType = (global::BrokerRPC.TypeTransaction) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class TransactionResponse : pb::IMessage<TransactionResponse> {
    private static readonly pb::MessageParser<TransactionResponse> _parser = new pb::MessageParser<TransactionResponse>(() => new TransactionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TransactionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BrokerRPC.GreetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionResponse(TransactionResponse other) : this() {
      message_ = other.message_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionResponse Clone() {
      return new TransactionResponse(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 2;
    private bool status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TransactionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TransactionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Status != false) hash ^= Status.GetHashCode();
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Status != false) {
        output.WriteRawTag(16);
        output.WriteBool(Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Status != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TransactionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Status != false) {
        Status = other.Status;
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
            Message = input.ReadString();
            break;
          }
          case 16: {
            Status = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code