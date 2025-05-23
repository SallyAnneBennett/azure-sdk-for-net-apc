// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudTrunkedNetwork data model.
    /// TrunkedNetwork represents a network that utilizes multiple isolation domains and specified VLANs to create a trunked network.
    /// </summary>
    public partial class NetworkCloudTrunkedNetworkData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudTrunkedNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="isolationDomainIds"> The list of resource IDs representing the Network Fabric isolation domains. It can be any combination of l2IsolationDomain and l3IsolationDomain resources. </param>
        /// <param name="vlans"> The list of vlans that are selected from the isolation domains for trunking. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/>, <paramref name="isolationDomainIds"/> or <paramref name="vlans"/> is null. </exception>
        public NetworkCloudTrunkedNetworkData(AzureLocation location, ExtendedLocation extendedLocation, IEnumerable<ResourceIdentifier> isolationDomainIds, IEnumerable<long> vlans) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));
            Argument.AssertNotNull(isolationDomainIds, nameof(isolationDomainIds));
            Argument.AssertNotNull(vlans, nameof(vlans));

            ExtendedLocation = extendedLocation;
            AssociatedResourceIds = new ChangeTrackingList<string>();
            HybridAksClustersAssociatedIds = new ChangeTrackingList<ResourceIdentifier>();
            IsolationDomainIds = isolationDomainIds.ToList();
            VirtualMachinesAssociatedIds = new ChangeTrackingList<ResourceIdentifier>();
            Vlans = vlans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudTrunkedNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Resource ETag. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="associatedResourceIds"> The list of resource IDs for the other Microsoft.NetworkCloud resources that have attached this network. </param>
        /// <param name="clusterId"> The resource ID of the Network Cloud cluster this trunked network is associated with. </param>
        /// <param name="detailedStatus"> The more detailed status of the trunked network. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="hybridAksClustersAssociatedIds"> Field Deprecated. These fields will be empty/omitted. The list of Hybrid AKS cluster resource IDs that are associated with this trunked network. </param>
        /// <param name="hybridAksPluginType"> Field Deprecated. The field was previously optional, now it will have no defined behavior and will be ignored. The network plugin type for Hybrid AKS. </param>
        /// <param name="interfaceName"> The default interface name for this trunked network in the virtual machine. This name can be overridden by the name supplied in the network attachment configuration of that virtual machine. </param>
        /// <param name="isolationDomainIds"> The list of resource IDs representing the Network Fabric isolation domains. It can be any combination of l2IsolationDomain and l3IsolationDomain resources. </param>
        /// <param name="provisioningState"> The provisioning state of the trunked network. </param>
        /// <param name="virtualMachinesAssociatedIds"> Field Deprecated. These fields will be empty/omitted. The list of virtual machine resource IDs, excluding any Hybrid AKS virtual machines, that are currently using this trunked network. </param>
        /// <param name="vlans"> The list of vlans that are selected from the isolation domains for trunking. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudTrunkedNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, ExtendedLocation extendedLocation, IReadOnlyList<string> associatedResourceIds, ResourceIdentifier clusterId, TrunkedNetworkDetailedStatus? detailedStatus, string detailedStatusMessage, IReadOnlyList<ResourceIdentifier> hybridAksClustersAssociatedIds, HybridAksPluginType? hybridAksPluginType, string interfaceName, IList<ResourceIdentifier> isolationDomainIds, TrunkedNetworkProvisioningState? provisioningState, IReadOnlyList<ResourceIdentifier> virtualMachinesAssociatedIds, IList<long> vlans, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            ExtendedLocation = extendedLocation;
            AssociatedResourceIds = associatedResourceIds;
            ClusterId = clusterId;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            HybridAksClustersAssociatedIds = hybridAksClustersAssociatedIds;
            HybridAksPluginType = hybridAksPluginType;
            InterfaceName = interfaceName;
            IsolationDomainIds = isolationDomainIds;
            ProvisioningState = provisioningState;
            VirtualMachinesAssociatedIds = virtualMachinesAssociatedIds;
            Vlans = vlans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudTrunkedNetworkData"/> for deserialization. </summary>
        internal NetworkCloudTrunkedNetworkData()
        {
        }

        /// <summary> Resource ETag. </summary>
        public ETag? ETag { get; }
        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The list of resource IDs for the other Microsoft.NetworkCloud resources that have attached this network. </summary>
        public IReadOnlyList<string> AssociatedResourceIds { get; }
        /// <summary> The resource ID of the Network Cloud cluster this trunked network is associated with. </summary>
        public ResourceIdentifier ClusterId { get; }
        /// <summary> The more detailed status of the trunked network. </summary>
        public TrunkedNetworkDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> Field Deprecated. These fields will be empty/omitted. The list of Hybrid AKS cluster resource IDs that are associated with this trunked network. </summary>
        public IReadOnlyList<ResourceIdentifier> HybridAksClustersAssociatedIds { get; }
        /// <summary> Field Deprecated. The field was previously optional, now it will have no defined behavior and will be ignored. The network plugin type for Hybrid AKS. </summary>
        public HybridAksPluginType? HybridAksPluginType { get; set; }
        /// <summary> The default interface name for this trunked network in the virtual machine. This name can be overridden by the name supplied in the network attachment configuration of that virtual machine. </summary>
        public string InterfaceName { get; set; }
        /// <summary> The list of resource IDs representing the Network Fabric isolation domains. It can be any combination of l2IsolationDomain and l3IsolationDomain resources. </summary>
        public IList<ResourceIdentifier> IsolationDomainIds { get; }
        /// <summary> The provisioning state of the trunked network. </summary>
        public TrunkedNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Field Deprecated. These fields will be empty/omitted. The list of virtual machine resource IDs, excluding any Hybrid AKS virtual machines, that are currently using this trunked network. </summary>
        public IReadOnlyList<ResourceIdentifier> VirtualMachinesAssociatedIds { get; }
        /// <summary> The list of vlans that are selected from the isolation domains for trunking. </summary>
        public IList<long> Vlans { get; }
    }
}
