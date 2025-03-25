class Language
{
    private string name;
    private int age;

    public Language(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Description()
    {
        Console.WriteLine("{0} was created at {1}", this.name.ToUpper(), this.age);
    }
}

class LangProgram
{

    public static void Main()
    {
        Language html = new("HTML", 1993);
        html.Description();
        Language css = new("CSS", 1996);
        css.Description();
        Language js = new("JavaScript", 1996);
        js.Description();
    }

}