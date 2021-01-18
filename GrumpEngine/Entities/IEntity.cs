namespace GrumpEngine
{
    public interface IEntity
    {
        float Weight { get; }
        string Identifier { get; }
        bool IsGrabbable { get; set; }
    }
}
