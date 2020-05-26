// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Image Version that you want to update. </summary>
    public partial class GalleryImageVersionUpdate : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryImageVersionUpdate. </summary>
        public GalleryImageVersionUpdate()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageVersionUpdate. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="publishingProfile"> Describes the basic gallery artifact publishing profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="storageProfile"> This is the storage profile of a Gallery Image Version. </param>
        /// <param name="replicationStatus"> This is the replication status of the gallery Image Version. </param>
        internal GalleryImageVersionUpdate(string id, string name, string type, IDictionary<string, string> tags, GalleryArtifactPublishingProfileBase publishingProfile, GalleryImageVersionPropertiesProvisioningState? provisioningState, GalleryImageVersionStorageProfile storageProfile, ReplicationStatus replicationStatus) : base(id, name, type, tags)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            StorageProfile = storageProfile;
            ReplicationStatus = replicationStatus;
        }

        /// <summary> Describes the basic gallery artifact publishing profile. </summary>
        public GalleryArtifactPublishingProfileBase PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryImageVersionPropertiesProvisioningState? ProvisioningState { get; }
        /// <summary> This is the storage profile of a Gallery Image Version. </summary>
        public GalleryImageVersionStorageProfile StorageProfile { get; set; }
        /// <summary> This is the replication status of the gallery Image Version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
    }
}