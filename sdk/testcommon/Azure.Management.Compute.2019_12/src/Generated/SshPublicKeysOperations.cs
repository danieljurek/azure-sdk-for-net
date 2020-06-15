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
using Azure.Management.Compute.Models;

namespace Azure.Management.Compute
{
    /// <summary> The SshPublicKeys service client. </summary>
    public partial class SshPublicKeysOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SshPublicKeysRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of SshPublicKeysOperations for mocking. </summary>
        protected SshPublicKeysOperations()
        {
        }
        /// <summary> Initializes a new instance of SshPublicKeysOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal SshPublicKeysOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new SshPublicKeysRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to create the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SshPublicKeyResource>> CreateAsync(string resourceGroupName, string sshPublicKeyName, SshPublicKeyResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(resourceGroupName, sshPublicKeyName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to create the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SshPublicKeyResource> Create(string resourceGroupName, string sshPublicKeyName, SshPublicKeyResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Create");
            scope.Start();
            try
            {
                return RestClient.Create(resourceGroupName, sshPublicKeyName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a new SSH public key resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to update the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SshPublicKeyResource>> UpdateAsync(string resourceGroupName, string sshPublicKeyName, SshPublicKeyUpdateResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, sshPublicKeyName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a new SSH public key resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="parameters"> Parameters supplied to update the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SshPublicKeyResource> Update(string resourceGroupName, string sshPublicKeyName, SshPublicKeyUpdateResource parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, sshPublicKeyName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an SSH public key. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(resourceGroupName, sshPublicKeyName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an SSH public key. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(resourceGroupName, sshPublicKeyName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an SSH public key. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SshPublicKeyResource>> GetAsync(string resourceGroupName, string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, sshPublicKeyName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an SSH public key. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SshPublicKeyResource> Get(string resourceGroupName, string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, sshPublicKeyName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generates and returns a public/private key pair and populates the SSH public key resource with the public key. The length of the key will be 3072 bits. This operation can only be performed once per SSH public key resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SshPublicKeyGenerateKeyPairResult>> GenerateKeyPairAsync(string resourceGroupName, string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.GenerateKeyPair");
            scope.Start();
            try
            {
                return await RestClient.GenerateKeyPairAsync(resourceGroupName, sshPublicKeyName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generates and returns a public/private key pair and populates the SSH public key resource with the public key. The length of the key will be 3072 bits. This operation can only be performed once per SSH public key resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SshPublicKeyGenerateKeyPairResult> GenerateKeyPair(string resourceGroupName, string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.GenerateKeyPair");
            scope.Start();
            try
            {
                return RestClient.GenerateKeyPair(resourceGroupName, sshPublicKeyName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the SSH public keys in the subscription. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SshPublicKeyResource> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SshPublicKeyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SshPublicKeyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the SSH public keys in the subscription. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SshPublicKeyResource> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<SshPublicKeyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SshPublicKeyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscriptionNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the SSH public keys in the specified resource group. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SshPublicKeyResource> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<SshPublicKeyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SshPublicKeyResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the SSH public keys in the specified resource group. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SshPublicKeyResource> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<SshPublicKeyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SshPublicKeyResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeysOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
