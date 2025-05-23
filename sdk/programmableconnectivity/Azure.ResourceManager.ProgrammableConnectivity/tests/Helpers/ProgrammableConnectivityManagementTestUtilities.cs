// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ProgrammableConnectivity.Tests.Helpers
{
    public class ProgrammableConnectivityManagementTestUtilities
    {
        public const string DefaultResourceGroupName = "rg-apc-sdk-tests";
        public const string DefaultResourceLocation = "eastus";

        public static async Task TryRegisterResourceGroupAsync(ResourceGroupCollection resourceGroupsOperations, string location, string resourceGroupName)
        {
            await resourceGroupsOperations.CreateOrUpdateAsync(WaitUntil.Completed, resourceGroupName, new ResourceGroupData(location));
        }
    }
}
