using CommandPattern;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        CommandHistory commandHistory = new CommandHistory();

        var insertCommand1 = new InsertTextCommand(editor, "Добрый день, вас беспокоит компания Oriflame!", editor.Text.Length);
        commandHistory.ExecuteCommand(insertCommand1);
        Console.WriteLine($"«{editor.Text}»");

        var insertCommand2 = new InsertTextCommand(editor, " С радостью сообщаем вам, что у нас в продаже появилось кофе!", editor.Text.Length);
        commandHistory.ExecuteCommand(insertCommand2);
        Console.WriteLine($"«{editor.Text}»");

        commandHistory.UndoLastCommand();
        Console.WriteLine($"«{editor.Text}»");

        var deleteCommand = new DeleteTextCommand(editor, 26, 19);
        commandHistory.ExecuteCommand(deleteCommand);
        Console.WriteLine($"«{editor.Text}»");

        var insertCommand3 = new InsertTextCommand(editor, " Лала сквад", editor.Text.Length);
        commandHistory.ExecuteCommand(insertCommand3);
        Console.WriteLine($"«{editor.Text}»");

    }
}