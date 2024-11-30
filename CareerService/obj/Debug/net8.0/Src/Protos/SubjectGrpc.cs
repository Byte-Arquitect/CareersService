// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Src/Protos/subject.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SubjectsService {
  public static partial class SubjectService
  {
    static readonly string __ServiceName = "subject.SubjectService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SubjectsService.SubjectList> __Marshaller_subject_SubjectList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SubjectsService.SubjectList.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SubjectsService.PrerequisitesMap> __Marshaller_subject_PrerequisitesMap = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SubjectsService.PrerequisitesMap.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SubjectsService.PostrequisitesMap> __Marshaller_subject_PostrequisitesMap = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SubjectsService.PostrequisitesMap.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SubjectsService.SubjectRelationships> __Marshaller_subject_SubjectRelationships = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SubjectsService.SubjectRelationships.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.SubjectList> __Method_GetAllSubjects = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.SubjectList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllSubjects",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_subject_SubjectList);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.PrerequisitesMap> __Method_GetPrerequisitesMap = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.PrerequisitesMap>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPrerequisitesMap",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_subject_PrerequisitesMap);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.PostrequisitesMap> __Method_GetPostrequisitesMap = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.PostrequisitesMap>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostrequisitesMap",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_subject_PostrequisitesMap);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.SubjectRelationships> __Method_GetPrerequisiteObjects = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.SubjectRelationships>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPrerequisiteObjects",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_subject_SubjectRelationships);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SubjectsService.SubjectReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SubjectService</summary>
    [grpc::BindServiceMethod(typeof(SubjectService), "BindService")]
    public abstract partial class SubjectServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SubjectsService.SubjectList> GetAllSubjects(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SubjectsService.PrerequisitesMap> GetPrerequisitesMap(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SubjectsService.PostrequisitesMap> GetPostrequisitesMap(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SubjectsService.SubjectRelationships> GetPrerequisiteObjects(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SubjectServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllSubjects, serviceImpl.GetAllSubjects)
          .AddMethod(__Method_GetPrerequisitesMap, serviceImpl.GetPrerequisitesMap)
          .AddMethod(__Method_GetPostrequisitesMap, serviceImpl.GetPostrequisitesMap)
          .AddMethod(__Method_GetPrerequisiteObjects, serviceImpl.GetPrerequisiteObjects).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SubjectServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllSubjects, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.SubjectList>(serviceImpl.GetAllSubjects));
      serviceBinder.AddMethod(__Method_GetPrerequisitesMap, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.PrerequisitesMap>(serviceImpl.GetPrerequisitesMap));
      serviceBinder.AddMethod(__Method_GetPostrequisitesMap, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.PostrequisitesMap>(serviceImpl.GetPostrequisitesMap));
      serviceBinder.AddMethod(__Method_GetPrerequisiteObjects, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SubjectsService.SubjectRelationships>(serviceImpl.GetPrerequisiteObjects));
    }

  }
}
#endregion