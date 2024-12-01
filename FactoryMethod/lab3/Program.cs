using lab3;
using StudyingLib;

class Program
{
    private static List<Entity> entities = new List<Entity>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите номер операции:\n"
                             + "1 - Добавить студента\n"
                             + "2 - Добавить преподавателя\n"
                             + "3 - Добавить курс\n"
                             + "4 - Загрузить данные из файла\n"
                             + "5 - Сохранить данные в файл\n"
                             + "6 - Показать все данные\n"
                             + "0 - Выход");

            var choice = Console.ReadLine();

            if (choice == "1") AddStudent();
            else if (choice == "2") AddTeacher();
            else if (choice == "3") AddCourse();
            else if (choice == "4") LoadData();
            else if (choice == "5") SaveData();
            else if (choice == "6") ShowData();
            else if (choice == "0") return;
            else Console.WriteLine("Некорректный ввод");
        }
    }

    private static void AddStudent()
    {
        Console.Write("Введите ID студента: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Введите имя студента: ");
        string name = Console.ReadLine();
        Console.Write("Введите ID курсов через запятую: ");
        var courses = Console.ReadLine().Split(',').Select(int.Parse).ToList();

        var student = new Student { Id = id, Name = name, Courses = courses };
        entities.Add(student);
    }

    private static void AddTeacher()
    {
        Console.Write("Введите ID преподавателя: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Введите имя преподавателя: ");
        string name = Console.ReadLine();
        Console.Write("Введите стаж преподавателя (лет): ");
        int experience = int.Parse(Console.ReadLine());
        Console.Write("Введите ID курсов через запятую: ");
        var courses = Console.ReadLine().Split(',').Select(int.Parse).ToList();

        var teacher = new Teacher { Id = id, Name = name, Experience = experience, Courses = courses };
        entities.Add(teacher);
    }

    private static void AddCourse()
    {
        Console.Write("Введите ID курса: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Введите название курса: ");
        string name = Console.ReadLine();
        Console.Write("Введите ID преподавателя: ");
        int teacherId = int.Parse(Console.ReadLine());
        Console.Write("Введите ID студентов через запятую: ");
        var students = Console.ReadLine().Split(',').Select(int.Parse).ToList();

        var course = new Course { Id = id, Name = name, TeacherId = teacherId, Students = students };
        entities.Add(course);
    }

    private static void SaveData()
    {
        Console.Write("Введите имя файла для сохранения: ");
        var filename = Console.ReadLine();
        DataManager.SaveData(filename, entities);
        Console.WriteLine("Данные сохранены");
        Console.ReadKey();
    }

    private static void LoadData()
    {
        // type Id | Name | CoursId1, CoursId2, CoursId3

        Console.Write("Введите имя файла: ");
        var filename = Console.ReadLine();
        entities = DataManager.LoadData(filename);
        Console.WriteLine("Данные загружены");
        Console.ReadKey();
    }


    private static void ShowData()
    {
        Console.Clear();

        var students = new Dictionary<int, Student>();
        var teachers = new Dictionary<int, Teacher>();
        var courses = new Dictionary<int, Course>();

        foreach (var entity in entities)
        {
            if (entity is Student student) students[student.Id] = student;
            else if (entity is Teacher teacher) teachers[teacher.Id] = teacher;
            else if (entity is Course course) courses[course.Id] = course;
        }

        Console.WriteLine("Студенты:");
        foreach (var student in students.Values)
        {
            var courseNames = student.Courses
                .Select(courseId => courses.TryGetValue(courseId, out var course)
                ? course.Name : $"Неизвестный курс ID {courseId}").ToList();

            Console.WriteLine($"ID: {student.Id}, Имя: {student.Name}, Курсы: {string.Join(", ", courseNames)}");
        }

        Console.WriteLine("\nПреподаватели:");
        foreach (var teacher in teachers.Values)
        {
            var courseNames = teacher.Courses
                .Select(courseId => courses.TryGetValue(courseId, out var course)
                ? course.Name : $"Неизвестный курс ID {courseId}").ToList();

            Console.WriteLine($"ID: {teacher.Id}, Имя: {teacher.Name}, Стаж: {teacher.Experience} лет, Курсы: {string.Join(", ", courseNames)}");
        }

        Console.WriteLine("\nКурсы:");
        foreach (var course in courses.Values)
        {
            var studentNames = course.Students
                .Select(studentId => students.TryGetValue(studentId, out var student)
                ? student.Name : $"Неизвестный студент ID {studentId}").ToList();

            string teacherName = teachers.TryGetValue(course.TeacherId, out var teacher)
                ? teacher.Name : $"Неизвестный преподаватель ID {course.TeacherId}";
            string studentNamesList = string.Join(", ", studentNames);

            Console.WriteLine($"ID: {course.Id}, Название: {course.Name}, Преподаватель: {teacherName}, Студенты: {studentNamesList}");
        }

        Console.ReadKey();
    }
}