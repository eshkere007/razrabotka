using TemplateMethodPattern;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator studentReport = new StudentReportGenerator();
            Console.WriteLine("Генерация отчета по студентам:");
            studentReport.GenerateReport();

            Console.WriteLine();

            ReportGenerator courseReport = new CourseReportGenerator();
            Console.WriteLine("Генерация отчета по курсам:");
            courseReport.GenerateReport();
        }
    }
}
