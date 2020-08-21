// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The ReplicationLinks service client. </summary>
    public partial class ReplicationLinksOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ReplicationLinksRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of ReplicationLinksOperations for mocking. </summary>
        protected ReplicationLinksOperations()
        {
        }
        /// <summary> Initializes a new instance of ReplicationLinksOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ReplicationLinksOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ReplicationLinksRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Deletes a database replication link. Cannot be done during failover. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be dropped. </param>
        /// <param name="linkId"> The ID of the replication link to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, serverName, databaseName, linkId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a database replication link. Cannot be done during failover. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be dropped. </param>
        /// <param name="linkId"> The ID of the replication link to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, serverName, databaseName, linkId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a database replication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database to get the link for. </param>
        /// <param name="linkId"> The replication link ID to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReplicationLink>> GetAsync(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, databaseName, linkId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a database replication link. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database to get the link for. </param>
        /// <param name="linkId"> The replication link ID to be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReplicationLink> Get(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, databaseName, linkId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists a database&apos;s replication links. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database to retrieve links for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual AsyncPageable<ReplicationLink> ListByDatabaseAsync(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            async Task<Page<ReplicationLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByDatabaseAsync(resourceGroupName, serverName, databaseName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists a database&apos;s replication links. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database to retrieve links for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="databaseName"/> is null. </exception>
        public virtual Pageable<ReplicationLink> ListByDatabase(string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }

            Page<ReplicationLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.ListByDatabase");
                scope.Start();
                try
                {
                    var response = RestClient.ListByDatabase(resourceGroupName, serverName, databaseName, cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be failed over. </param>
        /// <param name="linkId"> The ID of the replication link to be failed over. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="linkId"/> is null. </exception>
        public virtual async Task<ReplicationLinksFailoverOperation> StartFailoverAsync(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.StartFailover");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.FailoverAsync(resourceGroupName, serverName, databaseName, linkId, cancellationToken).ConfigureAwait(false);
                return new ReplicationLinksFailoverOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverRequest(resourceGroupName, serverName, databaseName, linkId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be failed over. </param>
        /// <param name="linkId"> The ID of the replication link to be failed over. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="linkId"/> is null. </exception>
        public virtual ReplicationLinksFailoverOperation StartFailover(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.StartFailover");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Failover(resourceGroupName, serverName, databaseName, linkId, cancellationToken);
                return new ReplicationLinksFailoverOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverRequest(resourceGroupName, serverName, databaseName, linkId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. This operation might result in data loss. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be failed over. </param>
        /// <param name="linkId"> The ID of the replication link to be failed over. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="linkId"/> is null. </exception>
        public virtual async Task<ReplicationLinksFailoverAllowDataLossOperation> StartFailoverAllowDataLossAsync(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.StartFailoverAllowDataLoss");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.FailoverAllowDataLossAsync(resourceGroupName, serverName, databaseName, linkId, cancellationToken).ConfigureAwait(false);
                return new ReplicationLinksFailoverAllowDataLossOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverAllowDataLossRequest(resourceGroupName, serverName, databaseName, linkId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets which replica database is primary by failing over from the current primary replica database. This operation might result in data loss. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be failed over. </param>
        /// <param name="linkId"> The ID of the replication link to be failed over. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, or <paramref name="linkId"/> is null. </exception>
        public virtual ReplicationLinksFailoverAllowDataLossOperation StartFailoverAllowDataLoss(string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.StartFailoverAllowDataLoss");
            scope.Start();
            try
            {
                var originalResponse = RestClient.FailoverAllowDataLoss(resourceGroupName, serverName, databaseName, linkId, cancellationToken);
                return new ReplicationLinksFailoverAllowDataLossOperation(_clientDiagnostics, _pipeline, RestClient.CreateFailoverAllowDataLossRequest(resourceGroupName, serverName, databaseName, linkId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a database replication link in forced or friendly way. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be failed over. </param>
        /// <param name="linkId"> The ID of the replication link to be failed over. </param>
        /// <param name="parameters"> The required parameters for unlinking replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="linkId"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ReplicationLinksUnlinkOperation> StartUnlinkAsync(string resourceGroupName, string serverName, string databaseName, string linkId, UnlinkParameters parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.StartUnlink");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UnlinkAsync(resourceGroupName, serverName, databaseName, linkId, parameters, cancellationToken).ConfigureAwait(false);
                return new ReplicationLinksUnlinkOperation(_clientDiagnostics, _pipeline, RestClient.CreateUnlinkRequest(resourceGroupName, serverName, databaseName, linkId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a database replication link in forced or friendly way. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database that has the replication link to be failed over. </param>
        /// <param name="linkId"> The ID of the replication link to be failed over. </param>
        /// <param name="parameters"> The required parameters for unlinking replication link. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="databaseName"/>, <paramref name="linkId"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual ReplicationLinksUnlinkOperation StartUnlink(string resourceGroupName, string serverName, string databaseName, string linkId, UnlinkParameters parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (databaseName == null)
            {
                throw new ArgumentNullException(nameof(databaseName));
            }
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ReplicationLinksOperations.StartUnlink");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Unlink(resourceGroupName, serverName, databaseName, linkId, parameters, cancellationToken);
                return new ReplicationLinksUnlinkOperation(_clientDiagnostics, _pipeline, RestClient.CreateUnlinkRequest(resourceGroupName, serverName, databaseName, linkId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}