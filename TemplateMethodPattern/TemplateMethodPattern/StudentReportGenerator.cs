namespace TemplateMethodPattern
{
    class StudentReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Собраны данные о студентах");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("Данные о студентах обработаны");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Отчет по студентам отформатирован");
        }
    }
}
