// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ProgrammableConnectivity.Models;
using Azure.ResourceManager.ProgrammableConnectivity.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.ProgrammableConnectivity.Tests.Tests
{
    [TestFixture]
    public class GatewayCrudTests : ProgrammableConnectivityManagementTestBase
    {
        public GatewayCrudTests() : base(true)
        {
        }

        [SetUp]
        public async Task ClearAndInitialize()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                await InitializeClient();
            }
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            CleanupResourceGroups();
        }

        [TestCase]
        [RecordedTest]
        public async Task TestGatewayAndOacCrudOperations()
        {
            // Set up RG
            var resourceGroupName = Recording.GenerateAssetName("SdkRg");
            await ProgrammableConnectivityManagementTestUtilities.TryRegisterResourceGroupAsync(ResourceGroupsOperations,
                ProgrammableConnectivityManagementTestUtilities.DefaultResourceLocation, resourceGroupName);

            // Set up Gateway
            var gatewayName = Recording.GenerateAssetName("SdkGateway");
            GatewayData gatewayData = new GatewayData(ProgrammableConnectivityManagementTestUtilities.DefaultResourceLocation);
            gatewayData.Properties = new GatewayProperties(
                new ApplicationProperties(
                    "Test name",
                    "Test Description",
                    Category.Agriculture,
                    "Test Commercial Name",
                    "Test Privacy Rights Request Email Address",
                    new Uri("https://www.example.com/privacypolicy")),
                new ApplicationOwnerProperties(
                    "Test Owner Name",
                    "Test Legal Name",
                    "Test Trading Name",
                    "Test Organization Description",
                    "Test Tax Number",
                    OrganizationType.OrganizationalUnit,
                    "Test Organization Identification Id",
                    "Test Organization Identification Issuer",
                    "Test Organization Identification Type",
                    "Test Contact Email Address",
                    new Person("First", "Last", "first.last@example.com"),
                    new Person("First", "Last", "first.last@example.com"),
                    new Person("First", "Last", "first.last@example.com"),
                    new GeographicAddress(
                        "Test Number",
                        "Test Street Name",
                        "Test Locality",
                        "Test City",
                        "Test State",
                        "Test Postal Code",
                        "AA",
                        new Dictionary<string, BinaryData>()),
                    new Uri("https://www.example.com/privacypolicy"),
                    new List<LocalRepresentative>
                    {
                        new LocalRepresentative(
                            "AA",
                            new Person ("Test Local Representative Name", "Test Local Representative Description", "contact@example.com")
                            )
                    })
                );
            GatewayCollection gatewayCollection = await GetGatewayCollectionAsync(resourceGroupName);

            // Set up Operator API Connection
            var operatorApiConnectionName = Recording.GenerateAssetName("SdkOperatorApiConnection");
            OperatorApiConnectionData operatorApiConnectionData = new OperatorApiConnectionData(ProgrammableConnectivityManagementTestUtilities.DefaultResourceLocation);
            operatorApiConnectionData.Properties = new OperatorApiConnectionProperties();
            var operatorApiPlanId = $"{Subscription.Data.Id}/providers/Microsoft.ProgrammableConnectivity/OperatorApiPlans/E2E_Test_Operator_Contoso_SimSwap1";
            operatorApiConnectionData.Properties.OperatorApiPlanId = new ResourceIdentifier(operatorApiPlanId);
            operatorApiConnectionData.Properties.PlanTermsAndConditionsAccepted = true;
            operatorApiConnectionData.Properties.Purposes = new List<Purpose> { Purpose.AcademicResearch };
            operatorApiConnectionData.Properties.PurposeReason = "Test Purpose Reason";
            operatorApiConnectionData.Properties.DataProcessingList = new List<DataProcessing> {
                new DataProcessing(
                    ProcessingOperation.Collect,
                    new List<Context> { Context.AlgorithmicLogic },
                    Duration.IndeterminateDuration,
                    Frequency.ContinuousFrequency,
                    new List<DataRegions> { new DataRegions ("AA", true, new Uri("https://www.example.com/dataprivacy")) },
                    new List<DataRegions> { new DataRegions ("AA", true, new Uri("https://www.example.com/dataprivacy")) }
                    )};
            OperatorApiConnectionCollection operatorApiConnectionCollection = await GetOperatorApiConnectionCollectionAsync(resourceGroupName);

            // Create Gateway
            var createGatewayOperation = await gatewayCollection.CreateOrUpdateAsync(WaitUntil.Completed, gatewayName, gatewayData);
            await createGatewayOperation.WaitForCompletionAsync();
            Assert.IsTrue(createGatewayOperation.HasCompleted);
            Assert.IsTrue(createGatewayOperation.HasValue);

            // Get
            Response<GatewayResource> getGatewayResponse = await gatewayCollection.GetAsync(gatewayName);
            GatewayResource gateway = getGatewayResponse.Value;
            Assert.IsNotNull(gateway);

            // Create Operator API Connection
            operatorApiConnectionData.Properties.GatewayId = gateway.Data.Id;
            var createOperatorApiConnectionOperation = await operatorApiConnectionCollection.CreateOrUpdateAsync(WaitUntil.Completed, operatorApiConnectionName, operatorApiConnectionData);
            await createOperatorApiConnectionOperation.WaitForCompletionAsync();
            Assert.IsTrue(createOperatorApiConnectionOperation.HasCompleted);
            Assert.IsTrue(createOperatorApiConnectionOperation.HasValue);

            // Get Operator API Connection
            Response<OperatorApiConnectionResource> getOperatorApiConnectionResponse = await operatorApiConnectionCollection.GetAsync(operatorApiConnectionName);
            OperatorApiConnectionResource operatorApiConnection = getOperatorApiConnectionResponse.Value;
            Assert.IsNotNull(operatorApiConnection);

            // Delete Operator API Connection
            var deleteOperatorApiConnectionOperation = await operatorApiConnection.DeleteAsync(WaitUntil.Completed);
            await deleteOperatorApiConnectionOperation.WaitForCompletionResponseAsync();
            Assert.IsTrue(deleteOperatorApiConnectionOperation.HasCompleted);

            // Delete Gateway
            var deleteGatewayOperation = await gateway.DeleteAsync(WaitUntil.Completed);
            await deleteGatewayOperation.WaitForCompletionResponseAsync();
            Assert.IsTrue(deleteGatewayOperation.HasCompleted);
        }
    }
}
