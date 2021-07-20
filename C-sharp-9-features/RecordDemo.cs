namespace C_sharp_9_features
{
    //Records are primarily intended for supporting immutable data models.
    public record RecordDemo(int A, int B)
    {
        public int C => A + B;
    };
}
