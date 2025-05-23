// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.ProgrammableConnectivity.Tests
{
    public class ProgrammableConnectivityManagementTestBase : ManagementRecordedTestBase<ProgrammableConnectivityManagementTestEnvironment>
    {
        public string SubscriptionId { get; set; }
        protected ArmClient Client { get; private set; }
        public ResourceGroupCollection ResourceGroupsOperations { get; set; }
        protected SubscriptionResource Subscription { get; private set; }

        protected ProgrammableConnectivityManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected ProgrammableConnectivityManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task InitializeClient()
        {
            Client = GetArmClient();
            Subscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
            ResourceGroupsOperations = Subscription.GetResourceGroups();
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        public async Task<ResourceGroupResource> GetResourceGroupAsync(string name)
        {
            return await Subscription.GetResourceGroups().GetAsync(name);
        }

        protected async Task<GatewayCollection> GetGatewayCollectionAsync(string resourceGroupName)
        {
            ResourceGroupResource rg = await GetResourceGroupAsync(resourceGroupName);
            return rg.GetGateways();
        }

        protected async Task<OperatorApiConnectionCollection> GetOperatorApiConnectionCollectionAsync(string resourceGroupName)
        {
            ResourceGroupResource rg = await GetResourceGroupAsync(resourceGroupName);
            return rg.GetOperatorApiConnections();
        }
    }
}
