using MementoPattern;

/*
 __ Memento Pattern __

Used to solve implementing the undo mechanism
 
 
 */







var editor = new Editor();
var history = new History();

editor.SetContent("First Content");

history.Push(editor.CreateState());

editor.SetContent("Second Content");

history.Push(editor.CreateState());

editor.SetContent("Third Content");

editor.RestoreState(history.Pop());

Console.WriteLine(editor.GetContent());

editor.RestoreState(history.Pop());

Console.WriteLine(editor.GetContent());