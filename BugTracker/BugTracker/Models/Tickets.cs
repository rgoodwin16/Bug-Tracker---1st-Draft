using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Models
{
    public class Tickets
    {


        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [AllowHtml]
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        [Display(Name = "Project")]
        public int ProjectId { get; set; }
        [Display(Name = "Status")]
        public int TicketStatusId { get; set; }
        [Display(Name = "Priority")]
        public int TicketPriorityId { get; set; }
        [Display(Name = "Type")]
        public int TicketTypeId { get; set; }
        [Display(Name = "Owner")]
        public string OwnerUserId { get; set; }
        [Display(Name = "Assigned")]
        public string AssignedToUserId { get; set; }

        


    }
}