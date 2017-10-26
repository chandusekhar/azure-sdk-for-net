// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// App Service plan.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AppServicePlan : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AppServicePlan class.
        /// </summary>
        public AppServicePlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppServicePlan class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">Identity for the resource.</param>
        /// <param name="appServicePlanName">Name for the App Service
        /// plan.</param>
        /// <param name="workerTierName">Target worker tier assigned to the App
        /// Service plan.</param>
        /// <param name="status">App Service plan status. Possible values
        /// include: 'Ready', 'Pending', 'Creating'</param>
        /// <param name="subscription">App Service plan subscription.</param>
        /// <param name="adminSiteName">App Service plan administration
        /// site.</param>
        /// <param name="hostingEnvironmentProfile">Specification for the App
        /// Service Environment to use for the App Service plan.</param>
        /// <param name="maximumNumberOfWorkers">Maximum number of instances
        /// that can be assigned to this App Service plan.</param>
        /// <param name="geoRegion">Geographical location for the App Service
        /// plan.</param>
        /// <param name="perSiteScaling">If &lt;code&gt;true&lt;/code&gt;, apps
        /// assigned to this App Service plan can be scaled independently.
        /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App
        /// Service plan will scale to all instances of the plan.</param>
        /// <param name="numberOfSites">Number of apps assigned to this App
        /// Service plan.</param>
        /// <param name="resourceGroup">Resource group of the App Service
        /// plan.</param>
        /// <param name="reserved">Reserved.</param>
        /// <param name="targetWorkerCount">Scaling worker count.</param>
        /// <param name="targetWorkerSizeId">Scaling worker size ID.</param>
        /// <param name="provisioningState">Provisioning state of the App
        /// Service Environment. Possible values include: 'Succeeded',
        /// 'Failed', 'Canceled', 'InProgress', 'Deleting'</param>
        public AppServicePlan(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceIdentity identity = default(ResourceIdentity), string appServicePlanName = default(string), string workerTierName = default(string), StatusOptions? status = default(StatusOptions?), string subscription = default(string), string adminSiteName = default(string), HostingEnvironmentProfile hostingEnvironmentProfile = default(HostingEnvironmentProfile), int? maximumNumberOfWorkers = default(int?), string geoRegion = default(string), bool? perSiteScaling = default(bool?), int? numberOfSites = default(int?), string resourceGroup = default(string), bool? reserved = default(bool?), int? targetWorkerCount = default(int?), int? targetWorkerSizeId = default(int?), ProvisioningState? provisioningState = default(ProvisioningState?), SkuDescription sku = default(SkuDescription))
            : base(location, id, name, kind, type, tags, identity)
        {
            AppServicePlanName = appServicePlanName;
            WorkerTierName = workerTierName;
            Status = status;
            Subscription = subscription;
            AdminSiteName = adminSiteName;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            MaximumNumberOfWorkers = maximumNumberOfWorkers;
            GeoRegion = geoRegion;
            PerSiteScaling = perSiteScaling;
            NumberOfSites = numberOfSites;
            ResourceGroup = resourceGroup;
            Reserved = reserved;
            TargetWorkerCount = targetWorkerCount;
            TargetWorkerSizeId = targetWorkerSizeId;
            ProvisioningState = provisioningState;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name for the App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string AppServicePlanName { get; set; }

        /// <summary>
        /// Gets or sets target worker tier assigned to the App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.workerTierName")]
        public string WorkerTierName { get; set; }

        /// <summary>
        /// Gets app Service plan status. Possible values include: 'Ready',
        /// 'Pending', 'Creating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public StatusOptions? Status { get; private set; }

        /// <summary>
        /// Gets app Service plan subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscription")]
        public string Subscription { get; private set; }

        /// <summary>
        /// Gets or sets app Service plan administration site.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminSiteName")]
        public string AdminSiteName { get; set; }

        /// <summary>
        /// Gets or sets specification for the App Service Environment to use
        /// for the App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingEnvironmentProfile")]
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }

        /// <summary>
        /// Gets maximum number of instances that can be assigned to this App
        /// Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNumberOfWorkers")]
        public int? MaximumNumberOfWorkers { get; private set; }

        /// <summary>
        /// Gets geographical location for the App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.geoRegion")]
        public string GeoRegion { get; private set; }

        /// <summary>
        /// Gets or sets if &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;, apps
        /// assigned to this App Service plan can be scaled independently.
        /// If &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;, apps assigned to
        /// this App Service plan will scale to all instances of the plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.perSiteScaling")]
        public bool? PerSiteScaling { get; set; }

        /// <summary>
        /// Gets number of apps assigned to this App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfSites")]
        public int? NumberOfSites { get; private set; }

        /// <summary>
        /// Gets resource group of the App Service plan.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; private set; }

        /// <summary>
        /// Gets or sets reserved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reserved")]
        public bool? Reserved { get; set; }

        /// <summary>
        /// Gets or sets scaling worker count.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetWorkerCount")]
        public int? TargetWorkerCount { get; set; }

        /// <summary>
        /// Gets or sets scaling worker size ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetWorkerSizeId")]
        public int? TargetWorkerSizeId { get; set; }

        /// <summary>
        /// Gets provisioning state of the App Service Environment. Possible
        /// values include: 'Succeeded', 'Failed', 'Canceled', 'InProgress',
        /// 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuDescription Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
