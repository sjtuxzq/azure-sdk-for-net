// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Azure Search Index.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSearchIndex")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureSearchIndexDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the AzureSearchIndexDataset class.
        /// </summary>
        public AzureSearchIndexDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSearchIndexDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="indexName">The name of the Azure Search Index. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        public AzureSearchIndexDataset(LinkedServiceReference linkedServiceName, object indexName, string description = default(string), object structure = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>))
            : base(linkedServiceName, description, structure, parameters)
        {
            IndexName = indexName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Azure Search Index. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.indexName")]
        public object IndexName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (IndexName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IndexName");
            }
        }
    }
}
