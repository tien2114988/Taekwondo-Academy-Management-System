using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using AutoMapper;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Taekwondo
{
    public class StudentAppService : AbpZeroTemplateAppServiceBase, IStudentAppService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentAppService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public ListResultDto<StudentListDto> GetStudents(GetStudentsInput input)
        {
            var students = _studentRepository
                .GetAll()
                .WhereIf(
                !input.Filter.IsNullOrEmpty(),
                p => p.StudentId.Contains(input.Filter)
                )
                .ToList();

            return new ListResultDto<StudentListDto>(ObjectMapper.Map<List<StudentListDto>>(students));
        }

        public async Task CreateStudent(CreateStudentInput input)
        {
            var student = ObjectMapper.Map<Student>(input);
            await _studentRepository.InsertAsync(student);
        }

        public async Task UpdateStudent(UpdateStudentInput input)
        {
            var student = await _studentRepository.GetAsync(input.Id);
            student.Name = input.Name;
            student.BirthOfDate = input.BirthOfDate;
            student.PhoneNumber= input.PhoneNumber;
            student.Address = input.Address;
            student.StudentId = input.StudentId;
            student.Level = input.Level;
            student.Class = input.Class;
            student.Status= input.Status;
            await _studentRepository.UpdateAsync(student);
        }

        public async Task<StudentListDto> GetStudentForEdit(GetStudentForEditInput input)
        {
            var student = await _studentRepository.GetAsync(input.Id);
            return ObjectMapper.Map<StudentListDto>(student);
        }
    }

}
