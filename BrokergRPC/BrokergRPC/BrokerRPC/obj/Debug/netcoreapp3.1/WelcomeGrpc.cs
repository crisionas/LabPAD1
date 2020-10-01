// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/welcome.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BrokerRPC {
  public static partial class WorkerRegistration
  {
    static readonly string __ServiceName = "greet.WorkerRegistration";

    static readonly grpc::Marshaller<global::BrokerRPC.WorkerMessage> __Marshaller_greet_WorkerMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BrokerRPC.WorkerMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::BrokerRPC.ConfirmationResponse> __Marshaller_greet_ConfirmationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::BrokerRPC.ConfirmationResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::BrokerRPC.WorkerMessage, global::BrokerRPC.ConfirmationResponse> __Method_RegisterWorker = new grpc::Method<global::BrokerRPC.WorkerMessage, global::BrokerRPC.ConfirmationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterWorker",
        __Marshaller_greet_WorkerMessage,
        __Marshaller_greet_ConfirmationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BrokerRPC.WelcomeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of WorkerRegistration</summary>
    [grpc::BindServiceMethod(typeof(WorkerRegistration), "BindService")]
    public abstract partial class WorkerRegistrationBase
    {
      public virtual global::System.Threading.Tasks.Task<global::BrokerRPC.ConfirmationResponse> RegisterWorker(global::BrokerRPC.WorkerMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for WorkerRegistration</summary>
    public partial class WorkerRegistrationClient : grpc::ClientBase<WorkerRegistrationClient>
    {
      /// <summary>Creates a new client for WorkerRegistration</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public WorkerRegistrationClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for WorkerRegistration that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public WorkerRegistrationClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WorkerRegistrationClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected WorkerRegistrationClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::BrokerRPC.ConfirmationResponse RegisterWorker(global::BrokerRPC.WorkerMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterWorker(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::BrokerRPC.ConfirmationResponse RegisterWorker(global::BrokerRPC.WorkerMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RegisterWorker, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::BrokerRPC.ConfirmationResponse> RegisterWorkerAsync(global::BrokerRPC.WorkerMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterWorkerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::BrokerRPC.ConfirmationResponse> RegisterWorkerAsync(global::BrokerRPC.WorkerMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RegisterWorker, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override WorkerRegistrationClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WorkerRegistrationClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(WorkerRegistrationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterWorker, serviceImpl.RegisterWorker).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WorkerRegistrationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterWorker, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BrokerRPC.WorkerMessage, global::BrokerRPC.ConfirmationResponse>(serviceImpl.RegisterWorker));
    }

  }
}
#endregion
