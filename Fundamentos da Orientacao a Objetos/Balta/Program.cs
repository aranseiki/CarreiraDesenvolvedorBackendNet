using Balta.ContentContext;

internal class Program {
    private static void Main(string[] args) {
        var articles = new List<Article>();
        articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
        articles.Add(new Article("Artigo sobre C#", "orientacao-csharp"));
        articles.Add(new Article("Artigo sobre .NET", "orientacao-dotnet"));

        foreach (var article in articles) {
            Console.WriteLine(article.Id);
            Console.WriteLine(article.Title);
            Console.WriteLine(article.Url);
        }

        var courses = new List<Course>();
        var coursesOOP = new Course("Fundamentos OOP", "fundamentos-oop");
        var coursesCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
        var coursesAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
        courses.Add(coursesOOP);
        courses.Add(coursesCSharp);
        courses.Add(coursesAspNet);

        var careers = new List<Career>();
        var careerDotNet = new Career("Especialista .Net", "especialista-dotnet");
        var careerItem = new CareerItem(1, "Comece por aqui", "", null);
        var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
        var careerItem3 = new CareerItem(3, "Aprenda .Net", "", null);
        careerDotNet.Items.Add(careerItem2);
        careerDotNet.Items.Add(careerItem3);
        careerDotNet.Items.Add(careerItem);
        careers.Add(careerDotNet);

        foreach (var career in careers) {
            Console.WriteLine(career.Title);

            foreach (var item in career.Items.OrderBy(x => x.Order)) {
                Console.WriteLine($"{item.Order} - {item.Title}");
            }
        }
    }
}   