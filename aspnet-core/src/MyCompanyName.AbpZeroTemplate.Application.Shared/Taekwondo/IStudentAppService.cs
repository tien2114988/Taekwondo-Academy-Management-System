using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Abp.ObjectMapping;

namespace MyCompanyName.AbpZeroTemplate.Taekwondo
{
    public interface IStudentAppService : IApplicationService
    {
        ListResultDto<StudentListDto> GetStudents(GetStudentsInput input);
        Task CreateStudent(CreateStudentInput input);
        Task UpdateStudent(UpdateStudentInput input);
        Task<StudentListDto> GetStudentForEdit(GetStudentForEditInput input);
    }

    public class GetStudentsInput
    {
        public string Filter { get; set; }
    }

    public class CreateStudentInput
    {
        [MaxLength(StudentConsts.MaxNameLength)]
        public string Name { get; set; }

        public DateTime BirthOfDate { get; set; }

        [MaxLength(StudentConsts.MaxPhoneLength)]
        public string PhoneNumber { get; set; }

        [MaxLength(StudentConsts.MaxAddressLength)]
        public string Address { get; set; }

        [MaxLength(StudentConsts.MaxStudentIdLength)]
        public string StudentId { get; set; }

        [MaxLength(StudentConsts.MaxLevelLength)]
        public string Level { get; set; }

        [MaxLength(StudentConsts.MaxClassLength)]
        public string Class { get; set; }

        public bool Status { get; set; }
    }

    public class UpdateStudentInput
    {
        public int Id { get; set; }

        [MaxLength(StudentConsts.MaxNameLength)]
        public string Name { get; set; }

        public DateTime BirthOfDate { get; set; }

        [MaxLength(StudentConsts.MaxPhoneLength)]
        public string PhoneNumber { get; set; }

        [MaxLength(StudentConsts.MaxAddressLength)]
        public string Address { get; set; }

        [MaxLength(StudentConsts.MaxStudentIdLength)]
        public string StudentId { get; set; }

        [MaxLength(StudentConsts.MaxLevelLength)]
        public string Level { get; set; }

        [MaxLength(StudentConsts.MaxClassLength)]
        public string Class { get; set; }

        public bool Status { get; set; }
    }

    public class GetStudentForEditInput {
        public int Id { get; set; }
    }

    public class GetStudentForEditOutput
    {
        public string Name { get; set; }

        public DateTime BirthOfDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string StudentId { get; set; }

        public string Level { get; set; }

        public string Class { get; set; }

        public bool Status { get; set; }
    }



    public class StudentListDto : FullAuditedEntityDto
    {
        public string Name { get; set; }

        public DateTime BirthOfDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string StudentId { get; set; }

        public string Level { get; set; }

        public string Class { get; set; }

        public bool Status { get; set; }
    }
}
