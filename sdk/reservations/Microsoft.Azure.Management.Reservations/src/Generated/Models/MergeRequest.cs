// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class MergeRequest
    {
        /// <summary>
        /// Initializes a new instance of the MergeRequest class.
        /// </summary>
        public MergeRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MergeRequest class.
        /// </summary>
        /// <param name="sources">Format of the resource id should be
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}</param>
        public MergeRequest(IList<string> sources = default(IList<string>))
        {
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets format of the resource id should be
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}
        /// </summary>
        [JsonProperty(PropertyName = "properties.sources")]
        public IList<string> Sources { get; set; }

    }
}