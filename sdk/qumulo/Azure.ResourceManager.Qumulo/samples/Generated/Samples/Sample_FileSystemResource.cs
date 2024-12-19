// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Qumulo.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Qumulo.Samples
{
    public partial class Sample_FileSystemResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FileSystemsGet()
        {
            // Generated from example definition: 2024-06-19/FileSystems_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystemResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileSystemResource created on azure
            // for more information of creating FileSystemResource, please refer to the document of FileSystemResource
            string subscriptionId = "382E8C7A-AC80-4D70-8580-EFE99537B9B7";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "sihbehcisdqtqqyfiewiiaphgh";
            ResourceIdentifier fileSystemResourceId = FileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            FileSystemResource fileSystemResource = client.GetFileSystemResource(fileSystemResourceId);

            // invoke the operation
            FileSystemResource result = await fileSystemResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FileSystemsGetMinimumSetGen()
        {
            // Generated from example definition: 2024-06-19/FileSystems_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystemResource_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileSystemResource created on azure
            // for more information of creating FileSystemResource, please refer to the document of FileSystemResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            ResourceIdentifier fileSystemResourceId = FileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            FileSystemResource fileSystemResource = client.GetFileSystemResource(fileSystemResourceId);

            // invoke the operation
            FileSystemResource result = await fileSystemResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_FileSystemsDelete()
        {
            // Generated from example definition: 2024-06-19/FileSystems_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystemResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileSystemResource created on azure
            // for more information of creating FileSystemResource, please refer to the document of FileSystemResource
            string subscriptionId = "382E8C7A-AC80-4D70-8580-EFE99537B9B7";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "xoschzkccroahrykedlvbbnsddq";
            ResourceIdentifier fileSystemResourceId = FileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            FileSystemResource fileSystemResource = client.GetFileSystemResource(fileSystemResourceId);

            // invoke the operation
            await fileSystemResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_FileSystemsDeleteMinimumSetGen()
        {
            // Generated from example definition: 2024-06-19/FileSystems_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystemResource_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileSystemResource created on azure
            // for more information of creating FileSystemResource, please refer to the document of FileSystemResource
            string subscriptionId = "382E8C7A-AC80-4D70-8580-EFE99537B9B7";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "jgtskkiplquyrlkaxvhdg";
            ResourceIdentifier fileSystemResourceId = FileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            FileSystemResource fileSystemResource = client.GetFileSystemResource(fileSystemResourceId);

            // invoke the operation
            await fileSystemResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FileSystemsUpdate()
        {
            // Generated from example definition: 2024-06-19/FileSystems_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "FileSystemResource_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileSystemResource created on azure
            // for more information of creating FileSystemResource, please refer to the document of FileSystemResource
            string subscriptionId = "382E8C7A-AC80-4D70-8580-EFE99537B9B7";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "ahpixnvykleksjlr";
            ResourceIdentifier fileSystemResourceId = FileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            FileSystemResource fileSystemResource = client.GetFileSystemResource(fileSystemResourceId);

            // invoke the operation
            FileSystemResourcePatch patch = new FileSystemResourcePatch
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("key7679")] = new UserAssignedIdentity()
},
                },
                Tags =
{
["key357"] = "ztkkvhfia"
},
                Properties = new FileSystemResourceUpdateProperties
                {
                    MarketplaceDetails = new MarketplaceDetails("fwtpz", "s")
                    {
                        MarketplaceSubscriptionId = "xaqtkloiyovmexqhn",
                        PublisherId = "czxcfrwodazyaft",
                        TermUnit = "cfwwczmygsimcyvoclcw",
                    },
                    UserDetailsEmail = "aqsnzyroo",
                    DelegatedSubnetId = "bqaryqsjlackxphpmzffgoqsvm",
                },
            };
            FileSystemResource result = await fileSystemResource.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FileSystemsUpdateMinimumSetGen()
        {
            // Generated from example definition: 2024-06-19/FileSystems_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "FileSystemResource_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FileSystemResource created on azure
            // for more information of creating FileSystemResource, please refer to the document of FileSystemResource
            string subscriptionId = "aaaaaaa";
            string resourceGroupName = "rgQumulo";
            string fileSystemName = "aaaaaaaaaaaaaaaaa";
            ResourceIdentifier fileSystemResourceId = FileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fileSystemName);
            FileSystemResource fileSystemResource = client.GetFileSystemResource(fileSystemResourceId);

            // invoke the operation
            FileSystemResourcePatch patch = new FileSystemResourcePatch();
            FileSystemResource result = await fileSystemResource.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FileSystemResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
