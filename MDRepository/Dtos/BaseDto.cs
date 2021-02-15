using System;
using System.Collections.Generic;
using System.Text;

namespace MDRepository.Dtos
{
   public class BaseDto
    {
        public int Id { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
