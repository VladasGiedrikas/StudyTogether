using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudyTogether
{
    public class ApiClient
    {
        //Suteikia galimybe siusti HTTP užklausas ir gauti atsakymus iš šaltinio identifikuotu URI. 
        //Šiuo atveju tai būtų mano sukurtas API projektas
        readonly HttpClient httpClient = new HttpClient();
        public StudentsClient StudentService { get; set; }
        public QuestionsClient QuestionsService { get; set; }
        public QuizClient QuizService { get; set; }
        public GradesClient GradesService { get; set; }

        public ApiClient()
        {
         QuestionsService = new QuestionsClient("https://localhost:44353/", httpClient);
         QuizService = new QuizClient("https://localhost:44353/", httpClient);
         StudentService = new StudentsClient("https://localhost:44353/", httpClient);
            GradesService = new GradesClient("https://localhost:44353/", httpClient);
        }
    }
}
