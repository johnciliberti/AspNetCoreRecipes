using System;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Tasks that has been assigned to an Artist via a work flow process
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// (Primary key)
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Link to artist
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// Title of the task displayed on task lists
        /// </summary>

        public string Title { get; set; } // Title

        /// <summary>
        /// Details of the task. Should describe what the user needs to do
        /// </summary>
        public string Details { get; set; } // Details

        /// <summary>
        /// When the task is due
        /// </summary>
        public DateTime? DueDate { get; set; } // DueDate

        /// <summary>
        /// Numeric indicator of state of task
        /// </summary>
        public int? State { get; set; } // State

        /// <summary>
        /// If the task is linked to another object, the int will specify the type of object
        /// </summary>
        public int? LinkType { get; set; } // LinkType

        /// <summary>
        /// If the task is linked to another object, the int will specify the type of object
        /// </summary>
        public int? LinkTypeId { get; set; } // LinkTypeID

        /// <summary>
        /// Date task was created
        /// </summary>
        public DateTime CreateDate { get; set; } // CreateDate

        /// <summary>
        /// Date task was last modified
        /// </summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        /// <summary>
        /// Foreign keys to FK_Task_Artist
        /// </summary>
        public virtual Artist Artist { get; set; }

        /// <summary>
        /// Constructor to initialize with default values
        /// </summary>
        public Task()
        {
            CreateDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}