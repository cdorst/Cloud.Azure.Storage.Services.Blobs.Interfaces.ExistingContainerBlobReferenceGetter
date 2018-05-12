// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage;

namespace Cloud.Azure.Storage.Services.Blobs.Interfaces.ExistingContainerBlobReferenceGetter
{
    /// <summary>Interface for service responsible for getting a blob reference</summary>
    public interface IExistingContainerBlobReferenceGetter
    {
        /// <summary>Returns reference to a blob</summary>
        CloudBlockBlob GetBlobReference(string containerName, string blobName);
    }
}
