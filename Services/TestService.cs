using System.Linq;

namespace StudyTogether.Services
{
    public class TestService : ITestService
    {
        private readonly StudyContext _context;

        public TestService(StudyContext context)
        {
            _context = context;
        }

        public void DoThing()
        {
            //var test = _context.Students.FirstOrDefault();
        }

        public string GetName()
        {
            var test = _context.Students.FirstOrDefault();
            var name = test.StudentName;
            return name;
        }
    }
}
