// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Qumulo.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableQumuloSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _fileSystemResourceFileSystemsClientDiagnostics;
        private FileSystemsRestOperations _fileSystemResourceFileSystemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableQumuloSubscriptionResource"/> class for mocking. </summary>
        protected MockableQumuloSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableQumuloSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableQumuloSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics FileSystemResourceFileSystemsClientDiagnostics => _fileSystemResourceFileSystemsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Qumulo", FileSystemResource.ResourceType.Namespace, Diagnostics);
        private FileSystemsRestOperations FileSystemResourceFileSystemsRestClient => _fileSystemResourceFileSystemsRestClient ??= new FileSystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(FileSystemResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List FileSystemResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystemResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FileSystemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FileSystemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FileSystemResource> GetFileSystemResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FileSystemResourceFileSystemsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FileSystemResourceFileSystemsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FileSystemResource(Client, FileSystemResourceData.DeserializeFileSystemResourceData(e)), FileSystemResourceFileSystemsClientDiagnostics, Pipeline, "MockableQumuloSubscriptionResource.GetFileSystemResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List FileSystemResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Qumulo.Storage/fileSystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileSystemResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FileSystemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FileSystemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FileSystemResource> GetFileSystemResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => FileSystemResourceFileSystemsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => FileSystemResourceFileSystemsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FileSystemResource(Client, FileSystemResourceData.DeserializeFileSystemResourceData(e)), FileSystemResourceFileSystemsClientDiagnostics, Pipeline, "MockableQumuloSubscriptionResource.GetFileSystemResources", "value", "nextLink", cancellationToken);
        }
    }
}
