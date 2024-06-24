using CQRSAndMediatRDemo.Models;
using MediatR;

namespace CQRSAndMediatRDemo.Commands
{
    public class CreateStudentCommand : IRequest<StudentDetails>
    {
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }
        public CreateStudentCommand(string studentdName, string studentEmail, string studentAddress, int studentAge)
        {
            StudentName = studentdName;
            StudentEmail = studentEmail;
            StudentAddress = studentAddress;
            StudentAge = studentAge;
        }
    }
}