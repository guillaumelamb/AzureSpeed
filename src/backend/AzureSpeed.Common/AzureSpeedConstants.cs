﻿namespace AzureSpeed.Common
{
    public static class AzureSpeedConstants
    {
        // Azure Storage
        public const string PublicContainerName = "public";
        public const string PrivateContainerName = "private";
        public const string UploadContainerName = "upload";
        public const string CallBackBlobName = "callback.js";
        public const string DownloadTestBlobName = "100MB.bin";

        // Lagecy IP range files
        public const string AzureIpRangeFileList = "PublicIPs.xml;PublicIPs_MC.xml";
    }
}