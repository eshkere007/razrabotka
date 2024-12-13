namespace TemplateMethodPattern
{
    abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            ProcessData();
            FormatReport();
            ExportReport();
        }

        protected abstract void CollectData();
        protected abstract void ProcessData();
        protected abstract void FormatReport();

        protected virtual void ExportReport()
        {
            Console.WriteLine("Отчет экспортирован в файл");
        }
    }
}
