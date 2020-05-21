// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.EventHub.Models
{
    /// <summary> The response of the List Namespace IDs operation. </summary>
    public partial class EHNamespaceIdListResult
    {
        /// <summary> Initializes a new instance of EHNamespaceIdListResult. </summary>
        internal EHNamespaceIdListResult()
        {
        }

        /// <summary> Initializes a new instance of EHNamespaceIdListResult. </summary>
        /// <param name="value"> Result of the List Namespace IDs operation. </param>
        internal EHNamespaceIdListResult(IReadOnlyList<EHNamespaceIdContainer> value)
        {
            Value = value;
        }

        /// <summary> Result of the List Namespace IDs operation. </summary>
        public IReadOnlyList<EHNamespaceIdContainer> Value { get; }
    }
}