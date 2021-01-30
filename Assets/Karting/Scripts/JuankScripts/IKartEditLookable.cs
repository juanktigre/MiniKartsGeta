namespace GetaGames
{
    public interface IKartEditLookable
    {
        void OnLookEditableSetPressed(int index, LookType type);
        void Init(KartLookSetUpScriptable kartLookSetUp);
    }
}