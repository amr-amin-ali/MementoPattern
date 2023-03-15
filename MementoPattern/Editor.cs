namespace MementoPattern
{
    public class Editor
    {
        private string Content { get; set; }
        public EditorState CreateState() => new EditorState(Content);
        public void RestoreState(EditorState editorState) => Content=editorState.Content;
        public void SetContent(string content) => Content=content;
        public string GetContent() => Content;
    }
}
