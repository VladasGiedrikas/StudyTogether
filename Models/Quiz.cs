﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudyTogether.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string QuizName { get; set; }
        public string Course { get; set; }
        public string Owner { get; set; }

        public Student Student { get; set; }
    }
}
