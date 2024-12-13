namespace TemplateMethodPattern
{
    class CourseReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о курсах");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Данные о курсах обработаны");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет по курсам отформатирован");
        }
    }
}
