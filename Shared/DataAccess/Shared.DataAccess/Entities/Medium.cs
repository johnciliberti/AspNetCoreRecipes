// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // Media
    public partial class Medium
    {
        public int MediaId { get; set; } // MediaId (Primary key)

        public int? ArtistId { get; set; } // ArtistId

        public string FriendlyFileName { get; set; } // FriendlyFileName

        public string FileExtention { get; set; } // FileExtention

        public string LocalFilePath { get; set; } // LocalFilePath

        public string WebUrl { get; set; } // WebURL

        public bool IsCloudBlob { get; set; } // IsCloudBlob

        public string AzureStorageContainer { get; set; } // AzureStorageContainer

        public string AzureBlobReferenceName { get; set; } // AzureBlobReferenceName

        public byte MediaType { get; set; } // MediaType

        public int FileSizeInBytes { get; set; } // FileSizeInBytes

        public int BitRateInKbps { get; set; } // BitRateInKbps

        public int AllowDownload { get; set; } // AllowDownload

        public int DownloadCount { get; set; } // DownloadCount

        public bool IsDeleted { get; set; } // IsDeleted

        public bool IsFileDeleted { get; set; } // IsFileDeleted

        public string Ripemd160Hash { get; set; } // RIPEMD160Hash

        public DateTime CreateDate { get; set; } // CreateDate

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile.FK_CollaborationSpaceFile_Media

        public virtual ICollection<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia.FK_CollaborationSpaceMedia_ToTable_1

        public virtual ICollection<Song> Songs { get; set; } // Song.FK_Song_Media

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_Media_ToTable

        public Medium()
        {
            IsCloudBlob = false;
            MediaType = 0;
            FileSizeInBytes = 0;
            BitRateInKbps = 0;
            AllowDownload = 0;
            DownloadCount = 0;
            IsDeleted = false;
            IsFileDeleted = false;
            CreateDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            CollaborationSpaceFiles = new List<CollaborationSpaceFile>();
            CollaborationSpaceMedias = new List<CollaborationSpaceMedia>();
            Songs = new List<Song>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}