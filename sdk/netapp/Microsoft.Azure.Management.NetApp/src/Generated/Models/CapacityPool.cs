// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Capacity pool resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CapacityPool : IResource
    {
        /// <summary>
        /// Initializes a new instance of the CapacityPool class.
        /// </summary>
        public CapacityPool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityPool class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="size">size</param>
        /// <param name="serviceLevel">serviceLevel</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="poolId">poolId</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="totalThroughputMibps">Total throughput of pool in
        /// Mibps</param>
        /// <param name="utilizedThroughputMibps">Utilized throughput of pool
        /// in Mibps</param>
        /// <param name="qosType">qosType</param>
        /// <param name="coolAccess">If enabled (true) the pool can contain
        /// cool Access enabled volumes.</param>
        public CapacityPool(string location, long size, string serviceLevel, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string poolId = default(string), string provisioningState = default(string), double? totalThroughputMibps = default(double?), double? utilizedThroughputMibps = default(double?), string qosType = default(string), bool? coolAccess = default(bool?))
        {
            Location = location;
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            PoolId = poolId;
            Size = size;
            ServiceLevel = serviceLevel;
            ProvisioningState = provisioningState;
            TotalThroughputMibps = totalThroughputMibps;
            UtilizedThroughputMibps = utilizedThroughputMibps;
            QosType = qosType;
            CoolAccess = coolAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets poolId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the Pool
        /// </remarks>
        [JsonProperty(PropertyName = "properties.poolId")]
        public string PoolId { get; private set; }

        /// <summary>
        /// Gets or sets size
        /// </summary>
        /// <remarks>
        /// Provisioned size of the pool (in bytes). Allowed values are in 4TiB
        /// chunks (value must be multiply of 4398046511104).
        /// </remarks>
        [JsonProperty(PropertyName = "properties.size")]
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets serviceLevel
        /// </summary>
        /// <remarks>
        /// The service level of the file system. Possible values include:
        /// 'Standard', 'Premium', 'Ultra'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.serviceLevel")]
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets total throughput of pool in Mibps
        /// </summary>
        [JsonProperty(PropertyName = "properties.totalThroughputMibps")]
        public double? TotalThroughputMibps { get; private set; }

        /// <summary>
        /// Gets utilized throughput of pool in Mibps
        /// </summary>
        [JsonProperty(PropertyName = "properties.utilizedThroughputMibps")]
        public double? UtilizedThroughputMibps { get; private set; }

        /// <summary>
        /// Gets or sets qosType
        /// </summary>
        /// <remarks>
        /// The qos type of the pool. Possible values include: 'Auto', 'Manual'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.qosType")]
        public string QosType { get; set; }

        /// <summary>
        /// Gets or sets if enabled (true) the pool can contain cool Access
        /// enabled volumes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.coolAccess")]
        public bool? CoolAccess { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (ServiceLevel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceLevel");
            }
            if (PoolId != null)
            {
                if (PoolId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "PoolId", 36);
                }
                if (PoolId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "PoolId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(PoolId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "PoolId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
            if (Size > 549755813888000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Size", 549755813888000);
            }
            if (Size < 4398046511104)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Size", 4398046511104);
            }
        }
    }
}
