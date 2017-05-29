using System.ComponentModel.DataAnnotations;

namespace Recipe01.Models
{
    public class ConcertAlertPreference
    {
        [Key]
        public int ConcertAlertPreferenceId { get; set; }
        [StringLength(50)]
        public string BandName { get; set; }
        public bool NotificationIsActive { get; set; }
        public bool NotifyViaEmail { get; set; }
        public bool NotifyViaSMS { get; set; }
        public bool ShowsOnWeekdays { get; set; }
        public bool ShowsOnWeekEnds {get;set;}
        
        
    }
}
