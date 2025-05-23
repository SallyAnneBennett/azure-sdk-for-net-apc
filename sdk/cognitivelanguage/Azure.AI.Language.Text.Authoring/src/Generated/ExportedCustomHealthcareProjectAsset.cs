// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the exported assets for a CustomHealthcare project. </summary>
    public partial class ExportedCustomHealthcareProjectAsset : TextAuthoringExportedProjectAsset
    {
        /// <summary> Initializes a new instance of <see cref="ExportedCustomHealthcareProjectAsset"/>. </summary>
        public ExportedCustomHealthcareProjectAsset()
        {
            ProjectKind = TextAuthoringProjectKind.CustomHealthcare;
            Entities = new ChangeTrackingList<TextAuthoringExportedCompositeEntity>();
            Documents = new ChangeTrackingList<ExportedCustomHealthcareDocument>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportedCustomHealthcareProjectAsset"/>. </summary>
        /// <param name="projectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="entities"> The list of entities belonging to the project. </param>
        /// <param name="documents"> The list of documents belonging to the project. </param>
        internal ExportedCustomHealthcareProjectAsset(TextAuthoringProjectKind projectKind, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<TextAuthoringExportedCompositeEntity> entities, IList<ExportedCustomHealthcareDocument> documents) : base(projectKind, serializedAdditionalRawData)
        {
            Entities = entities;
            Documents = documents;
        }

        /// <summary> The list of entities belonging to the project. </summary>
        public IList<TextAuthoringExportedCompositeEntity> Entities { get; }
        /// <summary> The list of documents belonging to the project. </summary>
        public IList<ExportedCustomHealthcareDocument> Documents { get; }
    }
}
