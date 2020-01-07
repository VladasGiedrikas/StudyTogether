using StudyTogether.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace StudyTogether
{
    public class StudyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
    }
}
