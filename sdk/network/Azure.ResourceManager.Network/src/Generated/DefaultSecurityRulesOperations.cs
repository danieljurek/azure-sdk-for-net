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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The DefaultSecurityRules service client. </summary>
    public partial class DefaultSecurityRulesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DefaultSecurityRulesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of DefaultSecurityRulesOperations for mocking. </summary>
        protected DefaultSecurityRulesOperations()
        {
        }
        /// <summary> Initializes a new instance of DefaultSecurityRulesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal DefaultSecurityRulesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new DefaultSecurityRulesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get the specified default network security rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityRule>> GetAsync(string resourceGroupName, string networkSecurityGroupName, string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRulesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, networkSecurityGroupName, defaultSecurityRuleName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified default network security rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="defaultSecurityRuleName"> The name of the default security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityRule> Get(string resourceGroupName, string networkSecurityGroupName, string defaultSecurityRuleName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRulesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, networkSecurityGroupName, defaultSecurityRuleName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all default security rules in a network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<SecurityRule> ListAsync(string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            async Task<Page<SecurityRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRulesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, networkSecurityGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SecurityRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRulesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, networkSecurityGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all default security rules in a network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<SecurityRule> List(string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            Page<SecurityRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRulesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, networkSecurityGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SecurityRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DefaultSecurityRulesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, networkSecurityGroupName, cancellationToken);
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
