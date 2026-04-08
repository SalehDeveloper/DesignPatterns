using MementoPattern;

var editor = new Editor();
editor.SetContent("a");

var memento = editor.Save();

var history = new History();
history.Push(memento);


editor.SetContent("A");
history.Push(editor.Save());

editor.SetContent("B");
history.Push(editor.Save());

editor.SetContent("C");

Console.WriteLine(editor.GetContent()); // C

editor.Restore(history.Pop());
Console.WriteLine(editor.GetContent()); // B

editor.Restore(history.Pop());
Console.WriteLine(editor.GetContent()); // A


