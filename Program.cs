using CommandDesignPattern;

Console.WriteLine("Command Design Pattern");
Console.WriteLine("Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request.");
Console.WriteLine("This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.");
Console.WriteLine();

var invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Hello World"));

var receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Hello", "World"));
invoker.DoSomething();

Console.WriteLine();
Console.WriteLine("Command Design Pattern Undo Example");
Console.WriteLine();

var history = new History();
var htmlDocument = new HTMLDocument();
htmlDocument.SetContent("Hello World");

var boldCommand = new BoldCommand(htmlDocument, history);
boldCommand.Execute();
Console.WriteLine(htmlDocument.GetContent());

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(htmlDocument.GetContent());