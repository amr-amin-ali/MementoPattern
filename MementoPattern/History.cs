namespace MementoPattern
{
    public class History
    {
        private Stack<EditorState> _history = new Stack<EditorState>();
        public void Push(EditorState state) => _history.Push(state);
        public EditorState Pop() => _history.Pop();

    }
}
