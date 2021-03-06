// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/keyword_plan_service.proto
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
  /// Service to manage keyword plans.
  /// </summary>
  public static partial class KeywordPlanService
  {
    static readonly string __ServiceName = "google.ads.googleads.v2.services.KeywordPlanService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest> __Marshaller_google_ads_googleads_v2_services_GetKeywordPlanRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan> __Marshaller_google_ads_googleads_v2_resources_KeywordPlan = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest> __Marshaller_google_ads_googleads_v2_services_MutateKeywordPlansRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse> __Marshaller_google_ads_googleads_v2_services_MutateKeywordPlansResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest> __Marshaller_google_ads_googleads_v2_services_GenerateForecastMetricsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse> __Marshaller_google_ads_googleads_v2_services_GenerateForecastMetricsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest> __Marshaller_google_ads_googleads_v2_services_GenerateHistoricalMetricsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse> __Marshaller_google_ads_googleads_v2_services_GenerateHistoricalMetricsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest, global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan> __Method_GetKeywordPlan = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest, global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetKeywordPlan",
        __Marshaller_google_ads_googleads_v2_services_GetKeywordPlanRequest,
        __Marshaller_google_ads_googleads_v2_resources_KeywordPlan);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest, global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse> __Method_MutateKeywordPlans = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest, global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlans",
        __Marshaller_google_ads_googleads_v2_services_MutateKeywordPlansRequest,
        __Marshaller_google_ads_googleads_v2_services_MutateKeywordPlansResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest, global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse> __Method_GenerateForecastMetrics = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest, global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateForecastMetrics",
        __Marshaller_google_ads_googleads_v2_services_GenerateForecastMetricsRequest,
        __Marshaller_google_ads_googleads_v2_services_GenerateForecastMetricsResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest, global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse> __Method_GenerateHistoricalMetrics = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest, global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateHistoricalMetrics",
        __Marshaller_google_ads_googleads_v2_services_GenerateHistoricalMetricsRequest,
        __Marshaller_google_ads_googleads_v2_services_GenerateHistoricalMetricsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V2.Services.KeywordPlanServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanService</summary>
    public abstract partial class KeywordPlanServiceBase
    {
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan> GetKeywordPlan(global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes keyword plans. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse> MutateKeywordPlans(global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the requested Keyword Plan forecasts.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse> GenerateForecastMetrics(global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the requested Keyword Plan historical metrics.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse> GenerateHistoricalMetrics(global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanService</summary>
    public partial class KeywordPlanServiceClient : grpc::ClientBase<KeywordPlanServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public KeywordPlanServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public KeywordPlanServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected KeywordPlanServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected KeywordPlanServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan GetKeywordPlan(global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlan(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan GetKeywordPlan(global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetKeywordPlan, null, options, request);
      }
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan> GetKeywordPlanAsync(global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetKeywordPlanAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested plan in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.KeywordPlan> GetKeywordPlanAsync(global::Google.Ads.GoogleAds.V2.Services.GetKeywordPlanRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetKeywordPlan, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes keyword plans. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse MutateKeywordPlans(global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlans(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes keyword plans. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse MutateKeywordPlans(global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlans, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes keyword plans. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse> MutateKeywordPlansAsync(global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlansAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes keyword plans. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansResponse> MutateKeywordPlansAsync(global::Google.Ads.GoogleAds.V2.Services.MutateKeywordPlansRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlans, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan forecasts.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse GenerateForecastMetrics(global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateForecastMetrics(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan forecasts.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse GenerateForecastMetrics(global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateForecastMetrics, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan forecasts.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateForecastMetricsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan forecasts.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(global::Google.Ads.GoogleAds.V2.Services.GenerateForecastMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateForecastMetrics, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan historical metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateHistoricalMetrics(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan historical metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateHistoricalMetrics, null, options, request);
      }
      /// <summary>
      /// Returns the requested Keyword Plan historical metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateHistoricalMetricsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested Keyword Plan historical metrics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(global::Google.Ads.GoogleAds.V2.Services.GenerateHistoricalMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateHistoricalMetrics, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override KeywordPlanServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(KeywordPlanServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetKeywordPlan, serviceImpl.GetKeywordPlan)
          .AddMethod(__Method_MutateKeywordPlans, serviceImpl.MutateKeywordPlans)
          .AddMethod(__Method_GenerateForecastMetrics, serviceImpl.GenerateForecastMetrics)
          .AddMethod(__Method_GenerateHistoricalMetrics, serviceImpl.GenerateHistoricalMetrics).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetKeywordPlan, serviceImpl.GetKeywordPlan);
      serviceBinder.AddMethod(__Method_MutateKeywordPlans, serviceImpl.MutateKeywordPlans);
      serviceBinder.AddMethod(__Method_GenerateForecastMetrics, serviceImpl.GenerateForecastMetrics);
      serviceBinder.AddMethod(__Method_GenerateHistoricalMetrics, serviceImpl.GenerateHistoricalMetrics);
    }

  }
}
#endregion
