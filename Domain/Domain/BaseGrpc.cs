// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: base.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Domain {
  public static partial class gRPC
  {
    static readonly string __ServiceName = "Domain.gRPC";

    static readonly grpc::Marshaller<global::Domain.HelloRequest> __Marshaller_Domain_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Domain.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Domain.HelloReply> __Marshaller_Domain_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Domain.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Domain.HelloRequest, global::Domain.HelloReply> __Method_SayHello = new grpc::Method<global::Domain.HelloRequest, global::Domain.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_Domain_HelloRequest,
        __Marshaller_Domain_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Domain.BaseReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of gRPC</summary>
    [grpc::BindServiceMethod(typeof(gRPC), "BindService")]
    public abstract partial class gRPCBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Domain.HelloReply> SayHello(global::Domain.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for gRPC</summary>
    public partial class gRPCClient : grpc::ClientBase<gRPCClient>
    {
      /// <summary>Creates a new client for gRPC</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public gRPCClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for gRPC that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public gRPCClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected gRPCClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected gRPCClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Domain.HelloReply SayHello(global::Domain.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Domain.HelloReply SayHello(global::Domain.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Domain.HelloReply> SayHelloAsync(global::Domain.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Domain.HelloReply> SayHelloAsync(global::Domain.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override gRPCClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new gRPCClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(gRPCBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, gRPCBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Domain.HelloRequest, global::Domain.HelloReply>(serviceImpl.SayHello));
    }

  }
}
#endregion
