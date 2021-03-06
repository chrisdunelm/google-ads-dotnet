// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/shopping_performance_view_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V2.Services {
  /// <summary>
  /// Service to fetch Shopping performance views.
  /// </summary>
  public static partial class ShoppingPerformanceViewService
  {
    static readonly string __ServiceName = "google.ads.googleads.v2.services.ShoppingPerformanceViewService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest> __Marshaller_google_ads_googleads_v2_services_GetShoppingPerformanceViewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView> __Marshaller_google_ads_googleads_v2_resources_ShoppingPerformanceView = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest, global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView> __Method_GetShoppingPerformanceView = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest, global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetShoppingPerformanceView",
        __Marshaller_google_ads_googleads_v2_services_GetShoppingPerformanceViewRequest,
        __Marshaller_google_ads_googleads_v2_resources_ShoppingPerformanceView);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V2.Services.ShoppingPerformanceViewServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ShoppingPerformanceViewService</summary>
    public abstract partial class ShoppingPerformanceViewServiceBase
    {
      /// <summary>
      /// Returns the requested Shopping performance view in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView> GetShoppingPerformanceView(global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ShoppingPerformanceViewService</summary>
    public partial class ShoppingPerformanceViewServiceClient : grpc::ClientBase<ShoppingPerformanceViewServiceClient>
    {
      /// <summary>Creates a new client for ShoppingPerformanceViewService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ShoppingPerformanceViewServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ShoppingPerformanceViewService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ShoppingPerformanceViewServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ShoppingPerformanceViewServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ShoppingPerformanceViewServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested Shopping performance view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView GetShoppingPerformanceView(global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetShoppingPerformanceView(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Shopping performance view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView GetShoppingPerformanceView(global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetShoppingPerformanceView, null, options, request);
      }
      /// <summary>
      /// Returns the requested Shopping performance view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView> GetShoppingPerformanceViewAsync(global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetShoppingPerformanceViewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Shopping performance view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.ShoppingPerformanceView> GetShoppingPerformanceViewAsync(global::Google.Ads.GoogleAds.V2.Services.GetShoppingPerformanceViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetShoppingPerformanceView, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ShoppingPerformanceViewServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ShoppingPerformanceViewServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ShoppingPerformanceViewServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetShoppingPerformanceView, serviceImpl.GetShoppingPerformanceView).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ShoppingPerformanceViewServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetShoppingPerformanceView, serviceImpl.GetShoppingPerformanceView);
    }

  }
}
#endregion
