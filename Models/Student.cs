﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTogether.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string Group { get; set; }
        public int TotaltQuizzes { get; set; }
        public string Password { get; set; }
    }
}
