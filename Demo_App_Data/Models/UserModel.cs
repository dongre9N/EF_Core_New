using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_App_Data.Models
{
   public class UserModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhotoId { get; set; }
        public string Mobile { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
