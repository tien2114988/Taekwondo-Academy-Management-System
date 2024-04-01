using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Taekwondo
{
    [Table("Students")]
    public class Student : FullAuditedEntity
    {
        public const int MaxNameLength = 255;
        public const int MaxPhoneLength = 10;
        public const int MaxAddressLength = 255;
        public const int MaxStudentIdLength = 10;
        public const int MaxLevelLength = 50;
        public const int MaxClassLength = 255;

        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        public virtual DateTime BirthOfDate { get; set; }

        [MaxLength(MaxPhoneLength)]
        public virtual string PhoneNumber { get; set; }

        [MaxLength(MaxAddressLength)]
        public virtual string Address { get; set; }

        [MaxLength(MaxStudentIdLength)]
        public virtual string StudentId { get; set; }

        [MaxLength(MaxLevelLength)]
        public virtual string Level { get; set; }

        [MaxLength(MaxClassLength)]
        public virtual string Class { get; set; }

        public virtual bool Status { get; set; }
    }
}
